using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.import.summary")]
    public partial class AccountImportSummary
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
        /// <para>Name: Import Summary Account</para>
        /// <para>Internal: import_summary_account_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("import_summary_account_ids")]
        [OdooField("import_summary_account_ids")]
        public List<int> ImportSummaryAccountIds { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Journal</para>
        /// <para>Internal: import_summary_journal_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("import_summary_journal_ids")]
        [OdooField("import_summary_journal_ids")]
        public List<int> ImportSummaryJournalIds { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Move</para>
        /// <para>Internal: import_summary_move_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("import_summary_move_ids")]
        [OdooField("import_summary_move_ids")]
        public List<int> ImportSummaryMoveIds { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Partner</para>
        /// <para>Internal: import_summary_partner_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("import_summary_partner_ids")]
        [OdooField("import_summary_partner_ids")]
        public List<int> ImportSummaryPartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Tax</para>
        /// <para>Internal: import_summary_tax_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("import_summary_tax_ids")]
        [OdooField("import_summary_tax_ids")]
        public List<int> ImportSummaryTaxIds { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Name</para>
        /// <para>Internal: import_summary_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("import_summary_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("import_summary_name")]
        public string ImportSummaryName { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Len Account</para>
        /// <para>Internal: import_summary_len_account</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("import_summary_len_account")]
        [OdooField("import_summary_len_account")]
        public int ImportSummaryLenAccount { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Len Journal</para>
        /// <para>Internal: import_summary_len_journal</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("import_summary_len_journal")]
        [OdooField("import_summary_len_journal")]
        public int ImportSummaryLenJournal { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Len Move</para>
        /// <para>Internal: import_summary_len_move</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("import_summary_len_move")]
        [OdooField("import_summary_len_move")]
        public int ImportSummaryLenMove { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Len Partner</para>
        /// <para>Internal: import_summary_len_partner</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("import_summary_len_partner")]
        [OdooField("import_summary_len_partner")]
        public int ImportSummaryLenPartner { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Len Tax</para>
        /// <para>Internal: import_summary_len_tax</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("import_summary_len_tax")]
        [OdooField("import_summary_len_tax")]
        public int ImportSummaryLenTax { get; set; }

        /// <summary>
        /// <para>Name: Import Summary Have Data</para>
        /// <para>Internal: import_summary_have_data</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("import_summary_have_data")]
        [OdooField("import_summary_have_data")]
        public bool ImportSummaryHaveData { get; set; }

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
