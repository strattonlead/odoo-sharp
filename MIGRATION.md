# Migration Guide: OdooSharp 0.0.31 → 1.0.0

## Overview

Version 1.0.0 fixes several bugs against the Odoo 18 JSON-RPC API, adds `CancellationToken` support, `IDisposable`, and proper error handling. All changes are **backwards compatible** — existing code compiles without modification. Old methods are marked `[Obsolete]` and will produce compiler warnings guiding you to the new overloads.

---

## Breaking Behavior Changes (no code changes required, but behavior differs)

### DeleteAsync\<T\> was broken — now fixed
Previously `DeleteAsync<T>(id)` sent `[id]` instead of `[[id]]` to Odoo's `unlink` endpoint, which likely caused server errors. If you had workarounds (e.g. calling `DeleteAsync(string model, int id)` instead), you can now switch to the generic version.

### CreateAsync\<T\> now filters fields
Previously `CreateAsync<T>(data)` sent the entire object to Odoo, including `Id = 0`, readonly fields, and null properties. Now it only sends writable, non-null fields with `[OdooField]` attributes. If you were manually building dictionaries to work around this, you can pass the model object directly.

### Deserialization errors now throw
Previously, JSON deserialization failures were silently caught, logged to `Console.WriteLine`, and returned `null`. Now they throw `OdooDeserializationException` with the raw JSON attached. If your code relied on null results from failed calls, add a try/catch:

```csharp
try
{
    var result = await client.ReadById<MyModel>(id);
}
catch (OdooDeserializationException ex)
{
    // ex.RawJson contains the raw response
    // ex.InnerException contains the original deserialization error
}
```

### HTTP errors now throw
Non-success HTTP status codes (500, 403, etc.) now throw `OdooHttpException` instead of attempting to deserialize garbage responses:

```csharp
try
{
    var result = await client.SearchReadAsync<MyModel>();
}
catch (OdooHttpException ex)
{
    // ex.StatusCode — the HTTP status code
    // ex.ResponseBody — the raw response body
}
```

### SearchReadAsync no longer fetches all fields by default
Previously, passing `fields: null` sent `fields: []` to Odoo, which returns **all fields** (expensive on large models like `res.partner` with 200+ fields). Now `fields` is omitted from the request when null, letting Odoo use its default behavior. If you explicitly need all fields, pass `fields: new string[0]` — but consider selecting only the fields you need.

---

## New Features

### CancellationToken support
All async methods now have overloads accepting `CancellationToken`. Old methods without it are marked `[Obsolete]` and delegate to the new ones internally.

```csharp
// Before (still works, but warns)
var result = await client.SearchReadAsync<ResPartner>();

// After
var result = await client.SearchReadAsync<ResPartner>(
    domain: null, fields: null, limit: 100, offset: 0,
    order: null, ct: cancellationToken);
```

### IDisposable
`IOdooClient` and `OdooClient` now implement `IDisposable`. If you use DI (`services.AddOdooClient(...)`) no changes are needed — the container handles disposal. If you create `OdooClient` manually:

```csharp
// Before
var client = new OdooClient(options);

// After
using var client = new OdooClient(options);
```

### SearchReadCountAsync with custom domain
Previously `SearchReadCountAsync<T>()` only used the model's default domain from `[OdooModel]`. Now you can pass a custom domain:

```csharp
var count = await client.SearchReadCountAsync<ResPartner>(
    new object[] { new object[] { "is_company", "=", true } },
    cancellationToken);
```

### SearchReadAllPagedAsync with ordering
The paging method now supports an `order` parameter to ensure deterministic pagination:

```csharp
var all = await client.SearchReadAllPagedAsync<ResPartner>(
    domain: null, fields: null, pageSize: 100,
    order: "id asc", ct: cancellationToken);
```

### DeleteAsync(string, int) on interface
`DeleteAsync(string model, int id)` was previously only on the class. It's now on `IOdooClient` too, so it works through the interface / DI.

---

## Obsolete Methods — Migration Table

| Old (warns) | New |
|---|---|
| `AuthenticateAsync()` | `AuthenticateAsync(CancellationToken)` |
| `AuthenticateUserAsync(user, pass)` | `AuthenticateUserAsync(user, pass, CancellationToken)` |
| `AuthenticateUserLightAsync(user, pass)` | `AuthenticateUserLightAsync(user, pass, CancellationToken)` |
| `CreateAsync<T>(data)` | `CreateAsync<T>(data, CancellationToken)` |
| `WriteAsync<T>(values)` | *(no CancellationToken overload yet — planned)* |
| `WriteChangedAsync<T>(modified)` | *(no CancellationToken overload yet — planned)* |
| `WriteChangedAsync<T>(orig, mod)` | `WriteChangedAsync<T>(orig, mod, CancellationToken)` |
| `ReadById<T>(id)` | `ReadById<T>(id, CancellationToken)` |
| `SearchReadAsync<T>(...)` | `SearchReadAsync<T>(domain, fields, limit, offset, order, CancellationToken)` |
| `SearchReadCountAsync<T>()` | `SearchReadCountAsync<T>(domain, CancellationToken)` |
| `DeleteAsync<T>(id)` | `DeleteAsync<T>(id, CancellationToken)` |
| `GetChangedFields<T>(orig, mod)` | *(will move to utility class in future version)* |

---

## New Exception Types

| Exception | When | Properties |
|---|---|---|
| `OdooHttpException` | HTTP status is not 2xx | `StatusCode`, `ResponseBody` |
| `OdooDeserializationException` | JSON response can't be deserialized | `RawJson`, `InnerException` |

Both are in `OdooSharp.Exceptions` namespace (same as existing `NotAuthenticatedException`).

---

## Version Numbers

All packages bumped to `1.0.0`:
- `CreateIf.OdooSharp`
- `OdooSharp.Configuration`
- `OdooSharp.DependencyInjection`
- `OdooSharp.Configuration.EnvironmentVariables`
- `OdooSharp.Models`
- `OdooSharp.Codegen`

---

## Verification Checklist

After updating, manually verify these flows against your Odoo 18 instance:

- [ ] `AuthenticateAsync()` returns `true`
- [ ] `SearchReadAsync<ResPartner>(limit: 5)` returns records
- [ ] `ReadById<ResPartner>(id)` returns a single record
- [ ] `CreateAsync<ResPartner>(new ResPartner { Name = "Test" })` returns ID > 0
- [ ] `WriteChangedAsync<ResPartner>(modified)` returns `true`
- [ ] `DeleteAsync<ResPartner>(createdId)` returns `true`
- [ ] `SearchReadAllPagedAsync<ResPartner>(pageSize: 10)` fetches all records
- [ ] `SearchReadCountAsync<ResPartner>(null)` returns count > 0
- [ ] `client.Query<ResPartner>().Where(x => x.Name.Contains("test")).Take(5).ToListAsync()` works
