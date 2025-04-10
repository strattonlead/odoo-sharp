using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("peppol.config.wizard")]
    public partial class PeppolConfigWizard
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
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Account Peppol Edi User</para>
        /// <para>Internal: account_peppol_edi_user</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account_edi_proxy_client.user</para>
        /// </summary>
        [JsonPropertyName("account_peppol_edi_user")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_peppol_edi_user")]
        public int? AccountPeppolEdiUser { get; set; }

        /// <summary>
        /// <para>Name: Edi Identification</para>
        /// <para>Internal: account_peppol_edi_identification</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_peppol_edi_identification")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_edi_identification")]
        public string AccountPeppolEdiIdentification { get; set; }

        /// <summary>
        /// <para>Name: PEPPOL status</para>
        /// <para>Internal: account_peppol_proxy_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_registered]=Not registered,[sender]=Can send but not receive,[smp_registration]=Can send, pending registration to receive,[receiver]=Can send and receive,[rejected]=Rejected</para>
        /// </summary>
        [JsonPropertyName("account_peppol_proxy_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_proxy_state")]
        public string AccountPeppolProxyState { get; set; }

        /// <summary>
        /// <para>Name: Primary contact email</para>
        /// <para>Internal: account_peppol_contact_email</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_peppol_contact_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_contact_email")]
        public string AccountPeppolContactEmail { get; set; }

        /// <summary>
        /// <para>Name: Migration Key</para>
        /// <para>Internal: account_peppol_migration_key</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_peppol_migration_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_migration_key")]
        public string AccountPeppolMigrationKey { get; set; }

        /// <summary>
        /// <para>Name: Service Json</para>
        /// <para>Internal: service_json</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("service_json")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("service_json")]
        public object ServiceJson { get; set; }

        /// <summary>
        /// <para>Name: Service Info</para>
        /// <para>Internal: service_info</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("service_info")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("service_info")]
        public string ServiceInfo { get; set; }

        /// <summary>
        /// <para>Name: Service</para>
        /// <para>Internal: service_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account_peppol.service</para>
        /// </summary>
        [JsonPropertyName("service_ids")]
        [OdooField("service_ids")]
        public List<int> ServiceIds { get; set; }

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
