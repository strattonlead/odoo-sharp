using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("mail.alias")]
    public partial class MailAlias
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
        /// <para>Name: Alias Name</para>
        /// <para>Internal: alias_name</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Alias Email</para>
        /// <para>Internal: alias_full_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_full_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_full_name")]
        public string AliasFullName { get; set; }

        /// <summary>
        /// <para>Name: Alias Domain</para>
        /// <para>Internal: alias_domain_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Alias domain name</para>
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
        /// <para>Name: Aliased Model</para>
        /// <para>Internal: alias_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("alias_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_model_id")]
        public int? AliasModelId { get; set; }

        /// <summary>
        /// <para>Name: Default Values</para>
        /// <para>Internal: alias_defaults</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("alias_defaults")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_defaults")]
        public string AliasDefaults { get; set; }

        /// <summary>
        /// <para>Name: Record Thread ID</para>
        /// <para>Internal: alias_force_thread_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("alias_force_thread_id")]
        [OdooField("alias_force_thread_id")]
        public int AliasForceThreadId { get; set; }

        /// <summary>
        /// <para>Name: Parent Model</para>
        /// <para>Internal: alias_parent_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("alias_parent_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_parent_model_id")]
        public int? AliasParentModelId { get; set; }

        /// <summary>
        /// <para>Name: Parent Record Thread ID</para>
        /// <para>Internal: alias_parent_thread_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("alias_parent_thread_id")]
        [OdooField("alias_parent_thread_id")]
        public int AliasParentThreadId { get; set; }

        /// <summary>
        /// <para>Name: Alias Contact Security</para>
        /// <para>Internal: alias_contact</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [everyone]=Everyone,[partners]=Authenticated Partners,[followers]=Followers only,[employees]=Authenticated Employees</para>
        /// </summary>
        [JsonPropertyName("alias_contact")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_contact")]
        public string AliasContact { get; set; }

        /// <summary>
        /// <para>Name: Local-part based incoming detection</para>
        /// <para>Internal: alias_incoming_local</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("alias_incoming_local")]
        [OdooField("alias_incoming_local")]
        public bool AliasIncomingLocal { get; set; }

        /// <summary>
        /// <para>Name: Custom Bounced Message</para>
        /// <para>Internal: alias_bounced_content</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("alias_bounced_content")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_bounced_content")]
        public string AliasBouncedContent { get; set; }

        /// <summary>
        /// <para>Name: Alias Status</para>
        /// <para>Internal: alias_status</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_tested]=Not Tested,[valid]=Valid,[invalid]=Invalid</para>
        /// </summary>
        [JsonPropertyName("alias_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_status")]
        public string AliasStatus { get; set; }

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

    }
}
