using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.report.expression")]
    public partial class AccountReportExpression
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
        /// <para>Name: Report Line</para>
        /// <para>Internal: report_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.report.line</para>
        /// </summary>
        [JsonPropertyName("report_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("report_line_id")]
        public int? ReportLineId { get; set; }

        /// <summary>
        /// <para>Name: Report Line Name</para>
        /// <para>Internal: report_line_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("report_line_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("report_line_name")]
        public string ReportLineName { get; set; }

        /// <summary>
        /// <para>Name: Label</para>
        /// <para>Internal: label</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("label")]
        public string Label { get; set; }

        /// <summary>
        /// <para>Name: Computation Engine</para>
        /// <para>Internal: engine</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [domain]=Odoo Domain,[tax_tags]=Tax Tags,[aggregation]=Aggregate Other Formulas,[account_codes]=Prefix of Account Codes,[external]=External Value,[custom]=Custom Python Function</para>
        /// </summary>
        [JsonPropertyName("engine")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("engine")]
        public string Engine { get; set; }

        /// <summary>
        /// <para>Name: Formula</para>
        /// <para>Internal: formula</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("formula")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("formula")]
        public string Formula { get; set; }

        /// <summary>
        /// <para>Name: Subformula</para>
        /// <para>Internal: subformula</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("subformula")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("subformula")]
        public string Subformula { get; set; }

        /// <summary>
        /// <para>Name: Date Scope</para>
        /// <para>Internal: date_scope</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [from_beginning]=From the very start,[from_fiscalyear]=From the start of the fiscal year,[to_beginning_of_fiscalyear]=At the beginning of the fiscal year,[to_beginning_of_period]=At the beginning of the period,[strict_range]=Strictly on the given dates,[previous_tax_period]=From previous tax period</para>
        /// </summary>
        [JsonPropertyName("date_scope")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("date_scope")]
        public string DateScope { get; set; }

        /// <summary>
        /// <para>Name: Figure Type</para>
        /// <para>Internal: figure_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [monetary]=Monetary,[percentage]=Percentage,[integer]=Integer,[float]=Float,[date]=Date,[datetime]=Datetime,[boolean]=Boolean,[string]=String</para>
        /// </summary>
        [JsonPropertyName("figure_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("figure_type")]
        public string FigureType { get; set; }

        /// <summary>
        /// <para>Name: Is Growth Good when Positive</para>
        /// <para>Internal: green_on_positive</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("green_on_positive")]
        [OdooField("green_on_positive")]
        public bool GreenOnPositive { get; set; }

        /// <summary>
        /// <para>Name: Blank if Zero</para>
        /// <para>Internal: blank_if_zero</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("blank_if_zero")]
        [OdooField("blank_if_zero")]
        public bool BlankIfZero { get; set; }

        /// <summary>
        /// <para>Name: Auditable</para>
        /// <para>Internal: auditable</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("auditable")]
        [OdooField("auditable")]
        public bool Auditable { get; set; }

        /// <summary>
        /// <para>Name: Carry Over To</para>
        /// <para>Internal: carryover_target</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("carryover_target")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("carryover_target")]
        public string CarryoverTarget { get; set; }

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
