using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("ir.mail_server")]
    public partial class IrMailServer
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

        /// <summary>
        /// <para>Name: Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: FROM Filtering</para>
        /// <para>Internal: from_filter</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("from_filter")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("from_filter")]
        public string FromFilter { get; set; }

        /// <summary>
        /// <para>Name: SMTP Server</para>
        /// <para>Internal: smtp_host</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("smtp_host")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("smtp_host")]
        public string SmtpHost { get; set; }

        /// <summary>
        /// <para>Name: SMTP Port</para>
        /// <para>Internal: smtp_port</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("smtp_port")]
        [OdooField("smtp_port")]
        public int SmtpPort { get; set; }

        /// <summary>
        /// <para>Name: Authenticate with</para>
        /// <para>Internal: smtp_authentication</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [login]=Username,[certificate]=SSL Certificate,[cli]=Command Line Interface,[gmail]=Gmail OAuth Authentication</para>
        /// </summary>
        [JsonPropertyName("smtp_authentication")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("smtp_authentication")]
        public string SmtpAuthentication { get; set; }

        /// <summary>
        /// <para>Name: Authentication Info</para>
        /// <para>Internal: smtp_authentication_info</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("smtp_authentication_info")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("smtp_authentication_info")]
        public string SmtpAuthenticationInfo { get; set; }

        /// <summary>
        /// <para>Name: Username</para>
        /// <para>Internal: smtp_user</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("smtp_user")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("smtp_user")]
        public string SmtpUser { get; set; }

        /// <summary>
        /// <para>Name: Password</para>
        /// <para>Internal: smtp_pass</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("smtp_pass")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("smtp_pass")]
        public string SmtpPass { get; set; }

        /// <summary>
        /// <para>Name: Connection Encryption</para>
        /// <para>Internal: smtp_encryption</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [none]=None,[starttls_strict]=TLS (STARTTLS), encryption and validation,[starttls]=TLS (STARTTLS), encryption only,[ssl_strict]=SSL/TLS, encryption and validation,[ssl]=SSL/TLS, encryption only</para>
        /// </summary>
        [JsonPropertyName("smtp_encryption")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("smtp_encryption")]
        public string SmtpEncryption { get; set; }

        /// <summary>
        /// <para>Name: SSL Certificate</para>
        /// <para>Internal: smtp_ssl_certificate</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("smtp_ssl_certificate")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("smtp_ssl_certificate")]
        public byte[] SmtpSslCertificate { get; set; }

        /// <summary>
        /// <para>Name: SSL Private Key</para>
        /// <para>Internal: smtp_ssl_private_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("smtp_ssl_private_key")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("smtp_ssl_private_key")]
        public byte[] SmtpSslPrivateKey { get; set; }

        /// <summary>
        /// <para>Name: Debugging</para>
        /// <para>Internal: smtp_debug</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("smtp_debug")]
        [OdooField("smtp_debug")]
        public bool SmtpDebug { get; set; }

        /// <summary>
        /// <para>Name: Max Email Size</para>
        /// <para>Internal: max_email_size</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("max_email_size")]
        [OdooField("max_email_size")]
        public double MaxEmailSize { get; set; }

        /// <summary>
        /// <para>Name: Priority</para>
        /// <para>Internal: sequence</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sequence")]
        [OdooField("sequence")]
        public int Sequence { get; set; }

        /// <summary>
        /// <para>Name: Active</para>
        /// <para>Internal: active</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("active")]
        [OdooField("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>Name: Created by</para>
        /// <para>Internal: create_uid</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("create_uid")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("create_uid")]
        public int? CreateUid { get; set; }

        /// <summary>
        /// <para>Name: Created on</para>
        /// <para>Internal: create_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("create_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("create_date")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// <para>Name: Last Updated by</para>
        /// <para>Internal: write_uid</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("write_uid")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("write_uid")]
        public int? WriteUid { get; set; }

        /// <summary>
        /// <para>Name: Last Updated on</para>
        /// <para>Internal: write_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("write_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("write_date")]
        public DateTime? WriteDate { get; set; }

        /// <summary>
        /// <para>Name: Mail template using this mail server</para>
        /// <para>Internal: mail_template_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.template</para>
        /// </summary>
        [JsonPropertyName("mail_template_ids")]
        [OdooField("mail_template_ids")]
        public List<int> MailTemplateIds { get; set; }

    }
}
