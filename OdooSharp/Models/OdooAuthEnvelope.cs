namespace OdooSharp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public sealed class OdooAuthEnvelope
    {
        [JsonPropertyName("jsonrpc")]
        public string JsonRpc { get; set; } = default!;

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("result")]
        public OdooSessionResult Result { get; set; } = default!;
    }

    public sealed class OdooSessionResult
    {
        [JsonPropertyName("uid")]
        public int Uid { get; set; }

        [JsonPropertyName("is_system")]
        public bool IsSystem { get; set; }

        [JsonPropertyName("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonPropertyName("is_public")]
        public bool IsPublic { get; set; }

        [JsonPropertyName("is_internal_user")]
        public bool IsInternalUser { get; set; }

        [JsonPropertyName("user_context")]
        public OdooUserContext UserContext { get; set; } = default!;

        [JsonPropertyName("db")]
        public string Db { get; set; } = default!;

        // user_settings ist sehr umfangreich/volatil -> ExtensionData kapselt alles
        [JsonPropertyName("user_settings")]
        public OdooLooseObject? UserSettings { get; set; }

        [JsonPropertyName("server_version")]
        public string ServerVersion { get; set; } = default!;

        // Mixed array (string + number) -> JsonElement[]
        [JsonPropertyName("server_version_info")]
        public JsonElement[]? ServerVersionInfo { get; set; }

        [JsonPropertyName("support_url")]
        public string? SupportUrl { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        // Odoo nennt das in deinem Beispiel "username"
        [JsonPropertyName("username")]
        public string Username { get; set; } = default!;

        [JsonPropertyName("quick_login")]
        public bool QuickLogin { get; set; }

        // Zeitformat kommt als "YYYY-MM-DD HH:mm:ss" (naiv) -> string beibehalten
        [JsonPropertyName("partner_write_date")]
        public string? PartnerWriteDate { get; set; }

        [JsonPropertyName("partner_display_name")]
        public string? PartnerDisplayName { get; set; }

        [JsonPropertyName("partner_id")]
        public int? PartnerId { get; set; }

        // Propertyname mit Punkt
        [JsonPropertyName("web.base.url")]
        public string? WebBaseUrl { get; set; }

        [JsonPropertyName("active_ids_limit")]
        public int? ActiveIdsLimit { get; set; }

        [JsonPropertyName("expiration_date")]
        public string? ExpirationDate { get; set; }

        [JsonPropertyName("expiration_reason")]
        public string? ExpirationReason { get; set; }

        // "currencies": Keys sind Strings ("125"), Werte typisiert
        [JsonPropertyName("currencies")]
        public Dictionary<string, OdooCurrencyInfo>? Currencies { get; set; }

        [JsonPropertyName("bundle_params")]
        public OdooBundleParams? BundleParams { get; set; }

        [JsonPropertyName("view_info")]
        public OdooLooseObject? ViewInfo { get; set; }

        [JsonPropertyName("user_companies")]
        public OdooUserCompanies? UserCompanies { get; set; }

        // Alles Weitere sicher auffangen
        [JsonExtensionData]
        public Dictionary<string, JsonElement>? AdditionalData { get; set; }
    }

    public sealed class OdooUserContext
    {
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = default!;

        [JsonPropertyName("tz")]
        public string Timezone { get; set; } = default!

        ;

        [JsonPropertyName("uid")]
        public int Uid { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement>? AdditionalData { get; set; }
    }

    public sealed class OdooCurrencyInfo
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = default!;

        [JsonPropertyName("position")]
        public string Position { get; set; } = default!; // "after" | "before"

        // "digits": [69, 2] -> meist [precision, scale]
        [JsonPropertyName("digits")]
        public int[] Digits { get; set; } = Array.Empty<int>();

        [JsonExtensionData]
        public Dictionary<string, JsonElement>? AdditionalData { get; set; }
    }

    public sealed class OdooBundleParams
    {
        [JsonPropertyName("lang")]
        public string? Lang { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement>? AdditionalData { get; set; }
    }

    public sealed class OdooUserCompanies
    {
        [JsonPropertyName("current_company")]
        public int CurrentCompany { get; set; }

        // Keys sind Company-IDs als String
        [JsonPropertyName("allowed_companies")]
        public Dictionary<string, OdooCompanyInfo> AllowedCompanies { get; set; } = new Dictionary<string, OdooCompanyInfo>();

        [JsonPropertyName("disallowed_ancestor_companies")]
        public Dictionary<string, JsonElement> DisallowedAncestorCompanies { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalData { get; set; }
    }

    public sealed class OdooCompanyInfo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("sequence")]
        public int? Sequence { get; set; }

        [JsonPropertyName("child_ids")]
        public int[]? ChildIds { get; set; }

        [JsonPropertyName("parent_id")]
        public JsonElement? ParentId { get; set; } // false oder int

        [JsonPropertyName("timesheet_uom_id")]
        public int? TimesheetUomId { get; set; }

        [JsonPropertyName("timesheet_uom_factor")]
        public double? TimesheetUomFactor { get; set; }

        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalData { get; set; }
    }

    /// <summary>
    /// Universeller Container für „lose“/volatile Objekte (alles via ExtensionData).
    /// Praktisch, wenn Odoo Felder oft ändert oder heterogene Typen (false/objekt) liefert.
    /// </summary>
    public sealed class OdooLooseObject
    {
        [JsonExtensionData]
        public Dictionary<string, JsonElement> Data { get; set; } = new Dictionary<string, JsonElement>();
    }

}
