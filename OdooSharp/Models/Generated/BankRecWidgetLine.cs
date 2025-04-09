using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("bank.rec.widget.line")]
    public partial class BankRecWidgetLine
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
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Name: Analytic Distribution</para>
        /// <para>Internal: analytic_distribution</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("analytic_distribution")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        public object AnalyticDistribution { get; set; }

        /// <summary>
        /// <para>Name: Analytic Precision</para>
        /// <para>Internal: analytic_precision</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("analytic_precision")]
        public int AnalyticPrecision { get; set; }

        /// <summary>
        /// <para>Name: Distribution Analytic Account</para>
        /// <para>Internal: distribution_analytic_account_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.analytic.account</para>
        /// </summary>
        [JsonPropertyName("distribution_analytic_account_ids")]
        public List<int> DistributionAnalyticAccountIds { get; set; }

        /// <summary>
        /// <para>Name: Wizard</para>
        /// <para>Internal: wizard_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: bank.rec.widget</para>
        /// </summary>
        [JsonPropertyName("wizard_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? WizardId { get; set; }

        /// <summary>
        /// <para>Name: Index</para>
        /// <para>Internal: index</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("index")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Index { get; set; }

        /// <summary>
        /// <para>Name: Flag</para>
        /// <para>Internal: flag</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("flag")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Flag { get; set; }

        /// <summary>
        /// <para>Name: Default Account</para>
        /// <para>Internal: journal_default_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("journal_default_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? JournalDefaultAccountId { get; set; }

        /// <summary>
        /// <para>Name: Account</para>
        /// <para>Internal: account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? AccountId { get; set; }

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
        public DateTime? Date { get; set; }

        /// <summary>
        /// <para>Name: Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Name { get; set; }

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
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: currency_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CurrencyId { get; set; }

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
        public int? CompanyCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Amount Currency</para>
        /// <para>Internal: amount_currency</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_currency")]
        public decimal AmountCurrency { get; set; }

        /// <summary>
        /// <para>Name: Balance</para>
        /// <para>Internal: balance</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("balance")]
        public decimal Balance { get; set; }

        /// <summary>
        /// <para>Name: Foreign Currency</para>
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
        public int? TransactionCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Amount in Currency</para>
        /// <para>Internal: amount_transaction_currency</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_transaction_currency")]
        public decimal AmountTransactionCurrency { get; set; }

        /// <summary>
        /// <para>Name: Debit</para>
        /// <para>Internal: debit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("debit")]
        public decimal Debit { get; set; }

        /// <summary>
        /// <para>Name: Credit</para>
        /// <para>Internal: credit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("credit")]
        public decimal Credit { get; set; }

        /// <summary>
        /// <para>Name: Force Price Included Taxes</para>
        /// <para>Internal: force_price_included_taxes</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("force_price_included_taxes")]
        public bool ForcePriceIncludedTaxes { get; set; }

        /// <summary>
        /// <para>Name: Tax Base Amount Currency</para>
        /// <para>Internal: tax_base_amount_currency</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("tax_base_amount_currency")]
        public decimal TaxBaseAmountCurrency { get; set; }

        /// <summary>
        /// <para>Name: Source Aml</para>
        /// <para>Internal: source_aml_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("source_aml_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SourceAmlId { get; set; }

        /// <summary>
        /// <para>Name: Source Aml Move</para>
        /// <para>Internal: source_aml_move_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("source_aml_move_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SourceAmlMoveId { get; set; }

        /// <summary>
        /// <para>Name: Source Aml Move Name</para>
        /// <para>Internal: source_aml_move_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("source_aml_move_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SourceAmlMoveName { get; set; }

        /// <summary>
        /// <para>Name: Tax Repartition Line</para>
        /// <para>Internal: tax_repartition_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax.repartition.line</para>
        /// </summary>
        [JsonPropertyName("tax_repartition_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? TaxRepartitionLineId { get; set; }

        /// <summary>
        /// <para>Name: Tax</para>
        /// <para>Internal: tax_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("tax_ids")]
        public List<int> TaxIds { get; set; }

        /// <summary>
        /// <para>Name: Tax Tag</para>
        /// <para>Internal: tax_tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.account.tag</para>
        /// </summary>
        [JsonPropertyName("tax_tag_ids")]
        public List<int> TaxTagIds { get; set; }

        /// <summary>
        /// <para>Name: Group Tax</para>
        /// <para>Internal: group_tax_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("group_tax_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? GroupTaxId { get; set; }

        /// <summary>
        /// <para>Name: Reconcile Model</para>
        /// <para>Internal: reconcile_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.reconcile.model</para>
        /// </summary>
        [JsonPropertyName("reconcile_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ReconcileModelId { get; set; }

        /// <summary>
        /// <para>Name: Source Amount Currency</para>
        /// <para>Internal: source_amount_currency</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("source_amount_currency")]
        public decimal SourceAmountCurrency { get; set; }

        /// <summary>
        /// <para>Name: Source Balance</para>
        /// <para>Internal: source_balance</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("source_balance")]
        public decimal SourceBalance { get; set; }

        /// <summary>
        /// <para>Name: Source Debit</para>
        /// <para>Internal: source_debit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("source_debit")]
        public decimal SourceDebit { get; set; }

        /// <summary>
        /// <para>Name: Source Credit</para>
        /// <para>Internal: source_credit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("source_credit")]
        public decimal SourceCredit { get; set; }

        /// <summary>
        /// <para>Name: Source Rate</para>
        /// <para>Internal: source_rate</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("source_rate")]
        public double SourceRate { get; set; }

        /// <summary>
        /// <para>Name: Display Stroked Amount Currency</para>
        /// <para>Internal: display_stroked_amount_currency</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_stroked_amount_currency")]
        public bool DisplayStrokedAmountCurrency { get; set; }

        /// <summary>
        /// <para>Name: Display Stroked Balance</para>
        /// <para>Internal: display_stroked_balance</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_stroked_balance")]
        public bool DisplayStrokedBalance { get; set; }

        /// <summary>
        /// <para>Name: Partner Currency</para>
        /// <para>Internal: partner_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("partner_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? PartnerCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Partner Receivable Account</para>
        /// <para>Internal: partner_receivable_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("partner_receivable_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? PartnerReceivableAccountId { get; set; }

        /// <summary>
        /// <para>Name: Partner Payable Account</para>
        /// <para>Internal: partner_payable_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("partner_payable_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? PartnerPayableAccountId { get; set; }

        /// <summary>
        /// <para>Name: Partner Receivable Amount</para>
        /// <para>Internal: partner_receivable_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("partner_receivable_amount")]
        public decimal PartnerReceivableAmount { get; set; }

        /// <summary>
        /// <para>Name: Partner Payable Amount</para>
        /// <para>Internal: partner_payable_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("partner_payable_amount")]
        public decimal PartnerPayableAmount { get; set; }

        /// <summary>
        /// <para>Name: Bank Account</para>
        /// <para>Internal: bank_account</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("bank_account")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string BankAccount { get; set; }

        /// <summary>
        /// <para>Name: Suggestion Html</para>
        /// <para>Internal: suggestion_html</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("suggestion_html")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SuggestionHtml { get; set; }

        /// <summary>
        /// <para>Name: Suggestion Amount Currency</para>
        /// <para>Internal: suggestion_amount_currency</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("suggestion_amount_currency")]
        public decimal SuggestionAmountCurrency { get; set; }

        /// <summary>
        /// <para>Name: Suggestion Balance</para>
        /// <para>Internal: suggestion_balance</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("suggestion_balance")]
        public decimal SuggestionBalance { get; set; }

        /// <summary>
        /// <para>Name: Ref</para>
        /// <para>Internal: ref</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("ref")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Ref { get; set; }

        /// <summary>
        /// <para>Name: Narration</para>
        /// <para>Internal: narration</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("narration")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Narration { get; set; }

        /// <summary>
        /// <para>Name: Manually Modified</para>
        /// <para>Internal: manually_modified</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("manually_modified")]
        public bool ManuallyModified { get; set; }

    }
}
