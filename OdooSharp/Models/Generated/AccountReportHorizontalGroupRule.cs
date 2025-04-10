using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.report.horizontal.group.rule")]
    public partial class AccountReportHorizontalGroupRule
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
        /// <para>Name: Horizontal Group</para>
        /// <para>Internal: horizontal_group_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.report.horizontal.group</para>
        /// </summary>
        [JsonPropertyName("horizontal_group_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("horizontal_group_id")]
        public int? HorizontalGroupId { get; set; }

        /// <summary>
        /// <para>Name: Domain</para>
        /// <para>Internal: domain</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Name: Field</para>
        /// <para>Internal: field_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [distribution_analytic_account_ids]=Distribution Analytic Account,[move_id]=Journal Entry,[journal_id]=Journal,[journal_group_id]=Ledger,[company_id]=Company,[company_currency_id]=Company Currency,[account_id]=Account,[currency_id]=Currency,[partner_id]=Partner,[reconcile_model_id]=Reconciliation Model,[payment_id]=Originator Payment,[statement_line_id]=Originator Statement Line,[statement_id]=Statement,[tax_ids]=Taxes,[group_tax_id]=Originator Group of Taxes,[tax_line_id]=Originator Tax,[tax_group_id]=Originator tax group,[tax_repartition_line_id]=Originator Tax Distribution Line,[tax_tag_ids]=Tags,[full_reconcile_id]=Matching,[account_root_id]=Account Root,[product_category_id]=Product Category,[product_id]=Product,[allowed_uom_ids]=Allowed Uom,[product_uom_id]=Unit,[create_uid]=Created by,[write_uid]=Last Updated by,[purchase_line_id]=Purchase Order Line,[purchase_order_id]=Purchase Order,[sale_line_ids]=Sales Order Lines,[followup_line_id]=Follow-up Level,[asset_ids]=Related Assets</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>Name: Model</para>
        /// <para>Internal: res_model_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("res_model_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_model_name")]
        public string ResModelName { get; set; }

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
