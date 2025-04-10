using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("asset.modify")]
    public partial class AssetModify
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
        /// <para>Name: Note</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: Asset</para>
        /// <para>Internal: asset_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.asset</para>
        /// </summary>
        [JsonPropertyName("asset_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("asset_id")]
        public int? AssetId { get; set; }

        /// <summary>
        /// <para>Name: Duration</para>
        /// <para>Internal: method_number</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("method_number")]
        [OdooField("method_number")]
        public int MethodNumber { get; set; }

        /// <summary>
        /// <para>Name: Number of Months in a Period</para>
        /// <para>Internal: method_period</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [1]=Months,[12]=Years</para>
        /// </summary>
        [JsonPropertyName("method_period")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("method_period")]
        public string MethodPeriod { get; set; }

        /// <summary>
        /// <para>Name: Depreciable Amount</para>
        /// <para>Internal: value_residual</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("value_residual")]
        [OdooField("value_residual")]
        public decimal ValueResidual { get; set; }

        /// <summary>
        /// <para>Name: Not Depreciable Amount</para>
        /// <para>Internal: salvage_value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("salvage_value")]
        [OdooField("salvage_value")]
        public decimal SalvageValue { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("currency_id")]
        public int? CurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Date</para>
        /// <para>Internal: date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// <para>Name: Select Invoice Line</para>
        /// <para>Internal: select_invoice_line_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("select_invoice_line_id")]
        [OdooField("select_invoice_line_id")]
        public bool SelectInvoiceLineId { get; set; }

        /// <summary>
        /// <para>Name: Gain Value</para>
        /// <para>Internal: gain_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("gain_value")]
        [OdooField("gain_value")]
        public bool GainValue { get; set; }

        /// <summary>
        /// <para>Name: Gross Increase Account</para>
        /// <para>Internal: account_asset_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_asset_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_asset_id")]
        public int? AccountAssetId { get; set; }

        /// <summary>
        /// <para>Name: Asset Counterpart Account</para>
        /// <para>Internal: account_asset_counterpart_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_asset_counterpart_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_asset_counterpart_id")]
        public int? AccountAssetCounterpartId { get; set; }

        /// <summary>
        /// <para>Name: Depreciation Account</para>
        /// <para>Internal: account_depreciation_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_depreciation_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_depreciation_id")]
        public int? AccountDepreciationId { get; set; }

        /// <summary>
        /// <para>Name: Expense Account</para>
        /// <para>Internal: account_depreciation_expense_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_depreciation_expense_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_depreciation_expense_id")]
        public int? AccountDepreciationExpenseId { get; set; }

        /// <summary>
        /// <para>Name: Action</para>
        /// <para>Internal: modify_action</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [dispose]=Veräußern,[sell]=Verkaufen,[modify]=Neu bewerten,[pause]=Pause</para>
        /// </summary>
        [JsonPropertyName("modify_action")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("modify_action")]
        public string ModifyAction { get; set; }

        /// <summary>
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Customer Invoice</para>
        /// <para>Internal: invoice_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("invoice_ids")]
        [OdooField("invoice_ids")]
        public List<int> InvoiceIds { get; set; }

        /// <summary>
        /// <para>Name: Invoice Line</para>
        /// <para>Internal: invoice_line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("invoice_line_ids")]
        [OdooField("invoice_line_ids")]
        public List<int> InvoiceLineIds { get; set; }

        /// <summary>
        /// <para>Name: Gain Account</para>
        /// <para>Internal: gain_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("gain_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("gain_account_id")]
        public int? GainAccountId { get; set; }

        /// <summary>
        /// <para>Name: Loss Account</para>
        /// <para>Internal: loss_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("loss_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("loss_account_id")]
        public int? LossAccountId { get; set; }

        /// <summary>
        /// <para>Name: Informational Text</para>
        /// <para>Internal: informational_text</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("informational_text")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("informational_text")]
        public string InformationalText { get; set; }

        /// <summary>
        /// <para>Name: Gain Or Loss</para>
        /// <para>Internal: gain_or_loss</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [gain]=Gain,[loss]=Loss,[no]=No</para>
        /// </summary>
        [JsonPropertyName("gain_or_loss")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("gain_or_loss")]
        public string GainOrLoss { get; set; }

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
