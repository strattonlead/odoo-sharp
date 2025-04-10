using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.report.line")]
    public partial class AccountReportLine
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
        /// <para>Name: Expressions</para>
        /// <para>Internal: expression_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.report.expression</para>
        /// </summary>
        [JsonPropertyName("expression_ids")]
        [OdooField("expression_ids")]
        public List<int> ExpressionIds { get; set; }

        /// <summary>
        /// <para>Name: Parent Report</para>
        /// <para>Internal: report_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.report</para>
        /// </summary>
        [JsonPropertyName("report_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("report_id")]
        public int? ReportId { get; set; }

        /// <summary>
        /// <para>Name: Level</para>
        /// <para>Internal: hierarchy_level</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("hierarchy_level")]
        [OdooField("hierarchy_level")]
        public int HierarchyLevel { get; set; }

        /// <summary>
        /// <para>Name: Parent Line</para>
        /// <para>Internal: parent_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.report.line</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("parent_id")]
        public int? ParentId { get; set; }

        /// <summary>
        /// <para>Name: Child Lines</para>
        /// <para>Internal: children_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.report.line</para>
        /// </summary>
        [JsonPropertyName("children_ids")]
        [OdooField("children_ids")]
        public List<int> ChildrenIds { get; set; }

        /// <summary>
        /// <para>Name: Group By</para>
        /// <para>Internal: groupby</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("groupby")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("groupby")]
        public string Groupby { get; set; }

        /// <summary>
        /// <para>Name: User Group By</para>
        /// <para>Internal: user_groupby</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("user_groupby")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("user_groupby")]
        public string UserGroupby { get; set; }

        /// <summary>
        /// <para>Name: Sequence</para>
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
        /// <para>Name: Code</para>
        /// <para>Internal: code</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("code")]
        public string Code { get; set; }

        /// <summary>
        /// <para>Name: Foldable</para>
        /// <para>Internal: foldable</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("foldable")]
        [OdooField("foldable")]
        public bool Foldable { get; set; }

        /// <summary>
        /// <para>Name: Print On New Page</para>
        /// <para>Internal: print_on_new_page</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("print_on_new_page")]
        [OdooField("print_on_new_page")]
        public bool PrintOnNewPage { get; set; }

        /// <summary>
        /// <para>Name: Action</para>
        /// <para>Internal: action_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.actions.actions</para>
        /// </summary>
        [JsonPropertyName("action_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("action_id")]
        public int? ActionId { get; set; }

        /// <summary>
        /// <para>Name: Hide if Zero</para>
        /// <para>Internal: hide_if_zero</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("hide_if_zero")]
        [OdooField("hide_if_zero")]
        public bool HideIfZero { get; set; }

        /// <summary>
        /// <para>Name: Domain Formula Shortcut</para>
        /// <para>Internal: domain_formula</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("domain_formula")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("domain_formula")]
        public string DomainFormula { get; set; }

        /// <summary>
        /// <para>Name: Account Codes Formula Shortcut</para>
        /// <para>Internal: account_codes_formula</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_codes_formula")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_codes_formula")]
        public string AccountCodesFormula { get; set; }

        /// <summary>
        /// <para>Name: Aggregation Formula Shortcut</para>
        /// <para>Internal: aggregation_formula</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("aggregation_formula")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("aggregation_formula")]
        public string AggregationFormula { get; set; }

        /// <summary>
        /// <para>Name: External Formula Shortcut</para>
        /// <para>Internal: external_formula</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("external_formula")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("external_formula")]
        public string ExternalFormula { get; set; }

        /// <summary>
        /// <para>Name: Horizontal Split Side</para>
        /// <para>Internal: horizontal_split_side</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [left]=Left,[right]=Right</para>
        /// </summary>
        [JsonPropertyName("horizontal_split_side")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("horizontal_split_side")]
        public string HorizontalSplitSide { get; set; }

        /// <summary>
        /// <para>Name: Tax Tags Formula Shortcut</para>
        /// <para>Internal: tax_tags_formula</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("tax_tags_formula")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("tax_tags_formula")]
        public string TaxTagsFormula { get; set; }

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
        /// <para>Name: Display Custom Groupby Warning</para>
        /// <para>Internal: display_custom_groupby_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_custom_groupby_warning")]
        [OdooField("display_custom_groupby_warning")]
        public bool DisplayCustomGroupbyWarning { get; set; }

    }
}
