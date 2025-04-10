using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("bank.rec.widget")]
    public partial class BankRecWidget
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
        /// <para>Name: St Line</para>
        /// <para>Internal: st_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.bank.statement.line</para>
        /// </summary>
        [JsonPropertyName("st_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("st_line_id")]
        public int? StLineId { get; set; }

        /// <summary>
        /// <para>Name: Journal Entry</para>
        /// <para>Internal: move_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("move_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("move_id")]
        public int? MoveId { get; set; }

        /// <summary>
        /// <para>Name: Checked</para>
        /// <para>Internal: st_line_checked</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("st_line_checked")]
        [OdooField("st_line_checked")]
        public bool StLineChecked { get; set; }

        /// <summary>
        /// <para>Name: Is Reconciled</para>
        /// <para>Internal: st_line_is_reconciled</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("st_line_is_reconciled")]
        [OdooField("st_line_is_reconciled")]
        public bool StLineIsReconciled { get; set; }

        /// <summary>
        /// <para>Name: Journal</para>
        /// <para>Internal: st_line_journal_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("st_line_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("st_line_journal_id")]
        public int? StLineJournalId { get; set; }

        /// <summary>
        /// <para>Name: St Line Transaction Details</para>
        /// <para>Internal: st_line_transaction_details</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("st_line_transaction_details")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("st_line_transaction_details")]
        public string StLineTransactionDetails { get; set; }

        /// <summary>
        /// <para>Name: Transaction Currency</para>
        /// <para>Internal: transaction_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("transaction_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("transaction_currency_id")]
        public int? TransactionCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Journal Currency</para>
        /// <para>Internal: journal_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("journal_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("journal_currency_id")]
        public int? JournalCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Partner</para>
        /// <para>Internal: partner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("partner_id")]
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Line</para>
        /// <para>Internal: line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: bank.rec.widget.line</para>
        /// </summary>
        [JsonPropertyName("line_ids")]
        [OdooField("line_ids")]
        public List<int> LineIds { get; set; }

        /// <summary>
        /// <para>Name: Available Reco Model</para>
        /// <para>Internal: available_reco_model_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.reconcile.model</para>
        /// </summary>
        [JsonPropertyName("available_reco_model_ids")]
        [OdooField("available_reco_model_ids")]
        public List<int> AvailableRecoModelIds { get; set; }

        /// <summary>
        /// <para>Name: Selected Reco Model</para>
        /// <para>Internal: selected_reco_model_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.reconcile.model</para>
        /// </summary>
        [JsonPropertyName("selected_reco_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("selected_reco_model_id")]
        public int? SelectedRecoModelId { get; set; }

        /// <summary>
        /// <para>Name: Partner Name</para>
        /// <para>Internal: partner_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_name")]
        public string PartnerName { get; set; }

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
        /// <para>Name: Country Code</para>
        /// <para>Internal: country_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("country_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>Name: Wizard Company Currency</para>
        /// <para>Internal: company_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("company_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("company_currency_id")]
        public int? CompanyCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Matching Rules Allow Auto Reconcile</para>
        /// <para>Internal: matching_rules_allow_auto_reconcile</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("matching_rules_allow_auto_reconcile")]
        [OdooField("matching_rules_allow_auto_reconcile")]
        public bool MatchingRulesAllowAutoReconcile { get; set; }

        /// <summary>
        /// <para>Name: State</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [invalid]=Invalid,[valid]=Valid,[reconciled]=Reconciled</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Is Multi Currency</para>
        /// <para>Internal: is_multi_currency</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_multi_currency")]
        [OdooField("is_multi_currency")]
        public bool IsMultiCurrency { get; set; }

        /// <summary>
        /// <para>Name: Selected Aml</para>
        /// <para>Internal: selected_aml_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("selected_aml_ids")]
        [OdooField("selected_aml_ids")]
        public List<int> SelectedAmlIds { get; set; }

        /// <summary>
        /// <para>Name: Todo Command</para>
        /// <para>Internal: todo_command</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("todo_command")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("todo_command")]
        public object TodoCommand { get; set; }

        /// <summary>
        /// <para>Name: Return Todo Command</para>
        /// <para>Internal: return_todo_command</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("return_todo_command")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("return_todo_command")]
        public object ReturnTodoCommand { get; set; }

        /// <summary>
        /// <para>Name: Form Index</para>
        /// <para>Internal: form_index</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("form_index")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("form_index")]
        public string FormIndex { get; set; }

        /// <summary>
        /// <para>Name: Matched Sale Order</para>
        /// <para>Internal: matched_sale_order_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: sale.order</para>
        /// </summary>
        [JsonPropertyName("matched_sale_order_ids")]
        [OdooField("matched_sale_order_ids")]
        public List<int> MatchedSaleOrderIds { get; set; }

    }
}
