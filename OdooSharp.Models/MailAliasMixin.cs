using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("mail.alias.mixin")]
    public partial class MailAliasMixin
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
        /// <para>Name: Alias</para>
        /// <para>Internal: alias_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.alias</para>
        /// </summary>
        [JsonPropertyName("alias_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_id")]
        public int? AliasId { get; set; }

        /// <summary>
        /// <para>Name: Alias Name</para>
        /// <para>Internal: alias_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>Name: Alias Domain</para>
        /// <para>Internal: alias_domain_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.alias.domain</para>
        /// </summary>
        [JsonPropertyName("alias_domain_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_domain_id")]
        public int? AliasDomainId { get; set; }

        /// <summary>
        /// <para>Name: Alias Domain Name</para>
        /// <para>Internal: alias_domain</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_domain")]
        public string AliasDomain { get; set; }

        /// <summary>
        /// <para>Name: Default Values</para>
        /// <para>Internal: alias_defaults</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("alias_defaults")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_defaults")]
        public string AliasDefaults { get; set; }

        /// <summary>
        /// <para>Name: Email Alias</para>
        /// <para>Internal: alias_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_email")]
        public string AliasEmail { get; set; }

    }
}
