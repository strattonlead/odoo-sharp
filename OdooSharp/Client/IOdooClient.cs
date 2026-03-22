using OdooSharp.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OdooSharp.Client
{
    public interface IOdooClient : IDisposable
    {
        bool Authenticated { get; }

        // Authentication
        [Obsolete("Use AuthenticateAsync(CancellationToken) overload.")]
        Task<bool> AuthenticateAsync();
        Task<bool> AuthenticateAsync(CancellationToken ct);

        [Obsolete("Use AuthenticateUserAsync(string, string, CancellationToken) overload.")]
        Task<OdooAuthEnvelope> AuthenticateUserAsync(string username, string password);
        Task<OdooAuthEnvelope> AuthenticateUserAsync(string username, string password, CancellationToken ct);

        [Obsolete("Use AuthenticateUserLightAsync(string, string, CancellationToken) overload.")]
        Task<int?> AuthenticateUserLightAsync(string username, string password);
        Task<int?> AuthenticateUserLightAsync(string username, string password, CancellationToken ct);

        // Metadata
        Task<List<OdooModel>> GetModelsAsync();
        Task<OdooFieldsResponse> GetModelFieldsTypedAsync(string model);

        // Create
        [Obsolete("Use CreateAsync<T>(T, CancellationToken) overload.")]
        Task<JsonRpcResponse<int>> CreateAsync<T>(T data);
        Task<JsonRpcResponse<int>> CreateAsync<T>(T data, CancellationToken ct);

        // Write
        [Obsolete("Use WriteAsync<T>(T, CancellationToken) overload.")]
        Task<JsonRpcResponse<bool>> WriteAsync<T>(T values);

        [Obsolete("Use WriteChangedAsync<T>(T, CancellationToken) overload.")]
        Task<JsonRpcResponse<bool>> WriteChangedAsync<T>(T modified);

        [Obsolete("Use WriteChangedAsync<T>(T, T, CancellationToken) overload.")]
        Task<JsonRpcResponse<bool>> WriteChangedAsync<T>(T original, T modified);
        Task<JsonRpcResponse<bool>> WriteChangedAsync<T>(T original, T modified, CancellationToken ct);

        // Read
        [Obsolete("Use SearchReadCountAsync<T>(object[], CancellationToken) overload.")]
        Task<JsonRpcResponse<int>> SearchReadCountAsync<T>();
        Task<JsonRpcResponse<int>> SearchReadCountAsync<T>(object[] domain, CancellationToken ct = default);

        [Obsolete("Use ReadById<T>(int, CancellationToken) overload.")]
        Task<JsonRpcResponse<T>> ReadById<T>(int id);
        Task<JsonRpcResponse<T>> ReadById<T>(int id, CancellationToken ct);

        [Obsolete("Use SearchReadAsync<T> overload with CancellationToken.")]
        Task<JsonRpcResponse<List<T>>> SearchReadAsync<T>(object[] domain = null, string[] fields = null, int limit = 100, int offset = 0, string order = null);
        Task<JsonRpcResponse<List<T>>> SearchReadAsync<T>(object[] domain, string[] fields, int limit, int offset, string order, CancellationToken ct);

        Task<List<T>> SearchReadAllPagedAsync<T>(object[] domain = null, string[] fields = null, int pageSize = 100);
        Task<List<T>> SearchReadAllPagedAsync<T>(object[] domain, string[] fields, int pageSize, string order, CancellationToken ct = default);

        // Delete
        [Obsolete("Use DeleteAsync<T>(int, CancellationToken) overload.")]
        Task<JsonRpcResponse<bool>> DeleteAsync<T>(int id);
        Task<JsonRpcResponse<bool>> DeleteAsync<T>(int id, CancellationToken ct);
        Task<JsonRpcResponse<bool>> DeleteAsync(string model, int id);

        // Utility
        [Obsolete("Will be moved to a utility class in a future version.")]
        Dictionary<string, object> GetChangedFields<T>(T original, T modified);
    }
}
