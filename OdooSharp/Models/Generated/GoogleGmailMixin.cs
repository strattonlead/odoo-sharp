using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("google.gmail.mixin")]
    public partial class GoogleGmailMixin
    {
        /// <summary>
        /// <para>Name: ID</para>
        /// <para>Internal: id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("id")]
        [OdooField("id")]
        public int Id { get; set; }

        /// <summary>
        /// <para>Name: Display Name</para>
        /// <para>Internal: display_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("display_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Name: Authorization Code</para>
        /// <para>Internal: google_gmail_authorization_code</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_gmail_authorization_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("google_gmail_authorization_code")]
        public string GoogleGmailAuthorizationCode { get; set; }

        /// <summary>
        /// <para>Name: Refresh Token</para>
        /// <para>Internal: google_gmail_refresh_token</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_gmail_refresh_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("google_gmail_refresh_token")]
        public string GoogleGmailRefreshToken { get; set; }

        /// <summary>
        /// <para>Name: Access Token</para>
        /// <para>Internal: google_gmail_access_token</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_gmail_access_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("google_gmail_access_token")]
        public string GoogleGmailAccessToken { get; set; }

        /// <summary>
        /// <para>Name: Access Token Expiration Timestamp</para>
        /// <para>Internal: google_gmail_access_token_expiration</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("google_gmail_access_token_expiration")]
        [OdooField("google_gmail_access_token_expiration")]
        public int GoogleGmailAccessTokenExpiration { get; set; }

        /// <summary>
        /// <para>Name: URI</para>
        /// <para>Internal: google_gmail_uri</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_gmail_uri")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("google_gmail_uri")]
        public string GoogleGmailUri { get; set; }

    }
}
