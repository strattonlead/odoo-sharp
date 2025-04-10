using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.move.line")]
    public partial class AccountMoveLine
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
        [OdooField("analytic_distribution")]
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
        [OdooField("analytic_precision")]
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
        [OdooField("distribution_analytic_account_ids")]
        public List<int> DistributionAnalyticAccountIds { get; set; }

        /// <summary>
        /// <para>Name: Journal Entry</para>
        /// <para>Internal: move_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
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
        /// <para>Name: Journal</para>
        /// <para>Internal: journal_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("journal_id")]
        public int? JournalId { get; set; }

        /// <summary>
        /// <para>Name: Ledger</para>
        /// <para>Internal: journal_group_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal.group</para>
        /// </summary>
        [JsonPropertyName("journal_group_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("journal_group_id")]
        public int? JournalGroupId { get; set; }

        /// <summary>
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Company Currency</para>
        /// <para>Internal: company_currency_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Number</para>
        /// <para>Internal: move_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("move_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("move_name")]
        public string MoveName { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: parent_state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [draft]=Draft,[posted]=Posted,[cancel]=Cancelled</para>
        /// </summary>
        [JsonPropertyName("parent_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("parent_state")]
        public string ParentState { get; set; }

        /// <summary>
        /// <para>Name: Date</para>
        /// <para>Internal: date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// <para>Name: Invoice/Bill Date</para>
        /// <para>Internal: invoice_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("invoice_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("invoice_date")]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// <para>Name: Reference</para>
        /// <para>Internal: ref</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("ref")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("ref")]
        public string Ref { get; set; }

        /// <summary>
        /// <para>Name: Company Storno Accounting</para>
        /// <para>Internal: is_storno</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_storno")]
        [OdooField("is_storno")]
        public bool IsStorno { get; set; }

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
        /// <para>Name: Type</para>
        /// <para>Internal: move_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [entry]=Journal Entry,[out_invoice]=Customer Invoice,[out_refund]=Customer Credit Note,[in_invoice]=Vendor Bill,[in_refund]=Vendor Credit Note,[out_receipt]=Sales Receipt,[in_receipt]=Purchase Receipt</para>
        /// </summary>
        [JsonPropertyName("move_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("move_type")]
        public string MoveType { get; set; }

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
        [OdooField("account_id")]
        public int? AccountId { get; set; }

        /// <summary>
        /// <para>Name: Account Name</para>
        /// <para>Internal: account_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>Name: Code</para>
        /// <para>Internal: account_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_code")]
        public string AccountCode { get; set; }

        /// <summary>
        /// <para>Name: Label</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: Debit</para>
        /// <para>Internal: debit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("debit")]
        [OdooField("debit")]
        public decimal Debit { get; set; }

        /// <summary>
        /// <para>Name: Credit</para>
        /// <para>Internal: credit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("credit")]
        [OdooField("credit")]
        public decimal Credit { get; set; }

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
        [OdooField("balance")]
        public decimal Balance { get; set; }

        /// <summary>
        /// <para>Name: Cumulated Balance</para>
        /// <para>Internal: cumulated_balance</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("cumulated_balance")]
        [OdooField("cumulated_balance")]
        public decimal CumulatedBalance { get; set; }

        /// <summary>
        /// <para>Name: Currency Rate</para>
        /// <para>Internal: currency_rate</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("currency_rate")]
        [OdooField("currency_rate")]
        public double CurrencyRate { get; set; }

        /// <summary>
        /// <para>Name: Amount in Currency</para>
        /// <para>Internal: amount_currency</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_currency")]
        [OdooField("amount_currency")]
        public decimal AmountCurrency { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: currency_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("currency_id")]
        public int? CurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Is Same Currency</para>
        /// <para>Internal: is_same_currency</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_same_currency")]
        [OdooField("is_same_currency")]
        public bool IsSameCurrency { get; set; }

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
        /// <para>Name: Is Imported</para>
        /// <para>Internal: is_imported</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_imported")]
        [OdooField("is_imported")]
        public bool IsImported { get; set; }

        /// <summary>
        /// <para>Name: Reconciliation Model</para>
        /// <para>Internal: reconcile_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.reconcile.model</para>
        /// </summary>
        [JsonPropertyName("reconcile_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("reconcile_model_id")]
        public int? ReconcileModelId { get; set; }

        /// <summary>
        /// <para>Name: Originator Payment</para>
        /// <para>Internal: payment_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.payment</para>
        /// </summary>
        [JsonPropertyName("payment_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("payment_id")]
        public int? PaymentId { get; set; }

        /// <summary>
        /// <para>Name: Originator Statement Line</para>
        /// <para>Internal: statement_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.bank.statement.line</para>
        /// </summary>
        [JsonPropertyName("statement_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("statement_line_id")]
        public int? StatementLineId { get; set; }

        /// <summary>
        /// <para>Name: Statement</para>
        /// <para>Internal: statement_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.bank.statement</para>
        /// </summary>
        [JsonPropertyName("statement_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("statement_id")]
        public int? StatementId { get; set; }

        /// <summary>
        /// <para>Name: Taxes</para>
        /// <para>Internal: tax_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("tax_ids")]
        [OdooField("tax_ids")]
        public List<int> TaxIds { get; set; }

        /// <summary>
        /// <para>Name: Originator Group of Taxes</para>
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
        [OdooField("group_tax_id")]
        public int? GroupTaxId { get; set; }

        /// <summary>
        /// <para>Name: Originator Tax</para>
        /// <para>Internal: tax_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("tax_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("tax_line_id")]
        public int? TaxLineId { get; set; }

        /// <summary>
        /// <para>Name: Originator tax group</para>
        /// <para>Internal: tax_group_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax.group</para>
        /// </summary>
        [JsonPropertyName("tax_group_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("tax_group_id")]
        public int? TaxGroupId { get; set; }

        /// <summary>
        /// <para>Name: Base Amount</para>
        /// <para>Internal: tax_base_amount</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("tax_base_amount")]
        [OdooField("tax_base_amount")]
        public decimal TaxBaseAmount { get; set; }

        /// <summary>
        /// <para>Name: Originator Tax Distribution Line</para>
        /// <para>Internal: tax_repartition_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax.repartition.line</para>
        /// </summary>
        [JsonPropertyName("tax_repartition_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("tax_repartition_line_id")]
        public int? TaxRepartitionLineId { get; set; }

        /// <summary>
        /// <para>Name: Tags</para>
        /// <para>Internal: tax_tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.account.tag</para>
        /// </summary>
        [JsonPropertyName("tax_tag_ids")]
        [OdooField("tax_tag_ids")]
        public List<int> TaxTagIds { get; set; }

        /// <summary>
        /// <para>Name: Invert Tags</para>
        /// <para>Internal: tax_tag_invert</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("tax_tag_invert")]
        [OdooField("tax_tag_invert")]
        public bool TaxTagInvert { get; set; }

        /// <summary>
        /// <para>Name: Residual Amount</para>
        /// <para>Internal: amount_residual</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_residual")]
        [OdooField("amount_residual")]
        public decimal AmountResidual { get; set; }

        /// <summary>
        /// <para>Name: Residual Amount in Currency</para>
        /// <para>Internal: amount_residual_currency</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_residual_currency")]
        [OdooField("amount_residual_currency")]
        public decimal AmountResidualCurrency { get; set; }

        /// <summary>
        /// <para>Name: Reconciled</para>
        /// <para>Internal: reconciled</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("reconciled")]
        [OdooField("reconciled")]
        public bool Reconciled { get; set; }

        /// <summary>
        /// <para>Name: Matching</para>
        /// <para>Internal: full_reconcile_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.full.reconcile</para>
        /// </summary>
        [JsonPropertyName("full_reconcile_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("full_reconcile_id")]
        public int? FullReconcileId { get; set; }

        /// <summary>
        /// <para>Name: Matched Debits</para>
        /// <para>Internal: matched_debit_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.partial.reconcile</para>
        /// </summary>
        [JsonPropertyName("matched_debit_ids")]
        [OdooField("matched_debit_ids")]
        public List<int> MatchedDebitIds { get; set; }

        /// <summary>
        /// <para>Name: Matched Credits</para>
        /// <para>Internal: matched_credit_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.partial.reconcile</para>
        /// </summary>
        [JsonPropertyName("matched_credit_ids")]
        [OdooField("matched_credit_ids")]
        public List<int> MatchedCreditIds { get; set; }

        /// <summary>
        /// <para>Name: Matching #</para>
        /// <para>Internal: matching_number</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("matching_number")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("matching_number")]
        public string MatchingNumber { get; set; }

        /// <summary>
        /// <para>Name: Account Reconcile</para>
        /// <para>Internal: is_account_reconcile</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_account_reconcile")]
        [OdooField("is_account_reconcile")]
        public bool IsAccountReconcile { get; set; }

        /// <summary>
        /// <para>Name: Internal Type</para>
        /// <para>Internal: account_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [asset_receivable]=Receivable,[asset_cash]=Bank and Cash,[asset_current]=Current Assets,[asset_non_current]=Non-current Assets,[asset_prepayments]=Prepayments,[asset_fixed]=Fixed Assets,[liability_payable]=Payable,[liability_credit_card]=Credit Card,[liability_current]=Current Liabilities,[liability_non_current]=Non-current Liabilities,[equity]=Equity,[equity_unaffected]=Current Year Earnings,[income]=Income,[income_other]=Other Income,[expense]=Expenses,[expense_depreciation]=Depreciation,[expense_direct_cost]=Cost of Revenue,[off_balance]=Off-Balance Sheet</para>
        /// </summary>
        [JsonPropertyName("account_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>Name: Internal Group</para>
        /// <para>Internal: account_internal_group</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [equity]=Equity,[asset]=Asset,[liability]=Liability,[income]=Income,[expense]=Expense,[off]=Off Balance</para>
        /// </summary>
        [JsonPropertyName("account_internal_group")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_internal_group")]
        public string AccountInternalGroup { get; set; }

        /// <summary>
        /// <para>Name: Account Root</para>
        /// <para>Internal: account_root_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.root</para>
        /// </summary>
        [JsonPropertyName("account_root_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_root_id")]
        public int? AccountRootId { get; set; }

        /// <summary>
        /// <para>Name: Product Category</para>
        /// <para>Internal: product_category_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.category</para>
        /// </summary>
        [JsonPropertyName("product_category_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("product_category_id")]
        public int? ProductCategoryId { get; set; }

        /// <summary>
        /// <para>Name: Display Type</para>
        /// <para>Internal: display_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [product]=Product,[cogs]=Cost of Goods Sold,[tax]=Tax,[discount]=Discount,[rounding]=Rounding,[payment_term]=Payment Term,[line_section]=Section,[line_note]=Note,[epd]=Early Payment Discount,[non_deductible_product_total]=Non Deductible Products Total,[non_deductible_product]=Non Deductible Products,[non_deductible_tax]=Non Deductible Tax</para>
        /// </summary>
        [JsonPropertyName("display_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("display_type")]
        public string DisplayType { get; set; }

        /// <summary>
        /// <para>Name: Product</para>
        /// <para>Internal: product_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.product</para>
        /// </summary>
        [JsonPropertyName("product_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("product_id")]
        public int? ProductId { get; set; }

        /// <summary>
        /// <para>Name: Allowed Uom</para>
        /// <para>Internal: allowed_uom_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: uom.uom</para>
        /// </summary>
        [JsonPropertyName("allowed_uom_ids")]
        [OdooField("allowed_uom_ids")]
        public List<int> AllowedUomIds { get; set; }

        /// <summary>
        /// <para>Name: Unit</para>
        /// <para>Internal: product_uom_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: uom.uom</para>
        /// </summary>
        [JsonPropertyName("product_uom_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("product_uom_id")]
        public int? ProductUomId { get; set; }

        /// <summary>
        /// <para>Name: Quantity</para>
        /// <para>Internal: quantity</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("quantity")]
        [OdooField("quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// <para>Name: Due Date</para>
        /// <para>Internal: date_maturity</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("date_maturity")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date_maturity")]
        public DateTime? DateMaturity { get; set; }

        /// <summary>
        /// <para>Name: Unit Price</para>
        /// <para>Internal: price_unit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("price_unit")]
        [OdooField("price_unit")]
        public double PriceUnit { get; set; }

        /// <summary>
        /// <para>Name: Subtotal</para>
        /// <para>Internal: price_subtotal</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("price_subtotal")]
        [OdooField("price_subtotal")]
        public decimal PriceSubtotal { get; set; }

        /// <summary>
        /// <para>Name: Total</para>
        /// <para>Internal: price_total</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("price_total")]
        [OdooField("price_total")]
        public decimal PriceTotal { get; set; }

        /// <summary>
        /// <para>Name: Discount (%)</para>
        /// <para>Internal: discount</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("discount")]
        [OdooField("discount")]
        public double Discount { get; set; }

        /// <summary>
        /// <para>Name: Tax calculation rounding method</para>
        /// <para>Internal: tax_calculation_rounding_method</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [round_per_line]=Round per Line,[round_globally]=Round Globally</para>
        /// </summary>
        [JsonPropertyName("tax_calculation_rounding_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("tax_calculation_rounding_method")]
        public string TaxCalculationRoundingMethod { get; set; }

        /// <summary>
        /// <para>Name: Deductibility</para>
        /// <para>Internal: deductible_amount</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("deductible_amount")]
        [OdooField("deductible_amount")]
        public double DeductibleAmount { get; set; }

        /// <summary>
        /// <para>Name: Term Key</para>
        /// <para>Internal: term_key</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("term_key")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("term_key")]
        public object TermKey { get; set; }

        /// <summary>
        /// <para>Name: Epd Key</para>
        /// <para>Internal: epd_key</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("epd_key")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("epd_key")]
        public object EpdKey { get; set; }

        /// <summary>
        /// <para>Name: Epd Needed</para>
        /// <para>Internal: epd_needed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("epd_needed")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("epd_needed")]
        public object EpdNeeded { get; set; }

        /// <summary>
        /// <para>Name: Epd Dirty</para>
        /// <para>Internal: epd_dirty</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("epd_dirty")]
        [OdooField("epd_dirty")]
        public bool EpdDirty { get; set; }

        /// <summary>
        /// <para>Name: Discount Allocation Key</para>
        /// <para>Internal: discount_allocation_key</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("discount_allocation_key")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("discount_allocation_key")]
        public object DiscountAllocationKey { get; set; }

        /// <summary>
        /// <para>Name: Discount Allocation Needed</para>
        /// <para>Internal: discount_allocation_needed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("discount_allocation_needed")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("discount_allocation_needed")]
        public object DiscountAllocationNeeded { get; set; }

        /// <summary>
        /// <para>Name: Discount Allocation Dirty</para>
        /// <para>Internal: discount_allocation_dirty</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("discount_allocation_dirty")]
        [OdooField("discount_allocation_dirty")]
        public bool DiscountAllocationDirty { get; set; }

        /// <summary>
        /// <para>Name: Analytic lines</para>
        /// <para>Internal: analytic_line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.analytic.line</para>
        /// </summary>
        [JsonPropertyName("analytic_line_ids")]
        [OdooField("analytic_line_ids")]
        public List<int> AnalyticLineIds { get; set; }

        /// <summary>
        /// <para>Name: Discount Date</para>
        /// <para>Internal: discount_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("discount_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("discount_date")]
        public DateTime? DiscountDate { get; set; }

        /// <summary>
        /// <para>Name: Discount amount in Currency</para>
        /// <para>Internal: discount_amount_currency</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("discount_amount_currency")]
        [OdooField("discount_amount_currency")]
        public decimal DiscountAmountCurrency { get; set; }

        /// <summary>
        /// <para>Name: Discount Balance</para>
        /// <para>Internal: discount_balance</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("discount_balance")]
        [OdooField("discount_balance")]
        public decimal DiscountBalance { get; set; }

        /// <summary>
        /// <para>Name: Next Payment Date</para>
        /// <para>Internal: payment_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("payment_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("payment_date")]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// <para>Name: Is Refund</para>
        /// <para>Internal: is_refund</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_refund")]
        [OdooField("is_refund")]
        public bool IsRefund { get; set; }

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
        /// <para>Name: Move Attachment</para>
        /// <para>Internal: move_attachment_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("move_attachment_ids")]
        [OdooField("move_attachment_ids")]
        public List<int> MoveAttachmentIds { get; set; }

        /// <summary>
        /// <para>Name: Start Date</para>
        /// <para>Internal: deferred_start_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("deferred_start_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("deferred_start_date")]
        public DateTime? DeferredStartDate { get; set; }

        /// <summary>
        /// <para>Name: End Date</para>
        /// <para>Internal: deferred_end_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("deferred_end_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("deferred_end_date")]
        public DateTime? DeferredEndDate { get; set; }

        /// <summary>
        /// <para>Name: Has Deferred Moves</para>
        /// <para>Internal: has_deferred_moves</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_deferred_moves")]
        [OdooField("has_deferred_moves")]
        public bool HasDeferredMoves { get; set; }

        /// <summary>
        /// <para>Name: Has Abnormal Deferred Dates</para>
        /// <para>Internal: has_abnormal_deferred_dates</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_abnormal_deferred_dates")]
        [OdooField("has_abnormal_deferred_dates")]
        public bool HasAbnormalDeferredDates { get; set; }

        /// <summary>
        /// <para>Name: Is Downpayment</para>
        /// <para>Internal: is_downpayment</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_downpayment")]
        [OdooField("is_downpayment")]
        public bool IsDownpayment { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order Line</para>
        /// <para>Internal: purchase_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: purchase.order.line</para>
        /// </summary>
        [JsonPropertyName("purchase_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("purchase_line_id")]
        public int? PurchaseLineId { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order</para>
        /// <para>Internal: purchase_order_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: purchase.order</para>
        /// </summary>
        [JsonPropertyName("purchase_order_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("purchase_order_id")]
        public int? PurchaseOrderId { get; set; }

        /// <summary>
        /// <para>Name: Exclude Bank Lines</para>
        /// <para>Internal: exclude_bank_lines</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("exclude_bank_lines")]
        [OdooField("exclude_bank_lines")]
        public bool ExcludeBankLines { get; set; }

        /// <summary>
        /// <para>Name: Sales Order Lines</para>
        /// <para>Internal: sale_line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: sale.order.line</para>
        /// </summary>
        [JsonPropertyName("sale_line_ids")]
        [OdooField("sale_line_ids")]
        public List<int> SaleLineIds { get; set; }

        /// <summary>
        /// <para>Name: Follow-up Level</para>
        /// <para>Internal: followup_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account_followup.followup.line</para>
        /// </summary>
        [JsonPropertyName("followup_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("followup_line_id")]
        public int? FollowupLineId { get; set; }

        /// <summary>
        /// <para>Name: Origin</para>
        /// <para>Internal: invoice_origin</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("invoice_origin")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_origin")]
        public string InvoiceOrigin { get; set; }

        /// <summary>
        /// <para>Name: Related Assets</para>
        /// <para>Internal: asset_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.asset</para>
        /// </summary>
        [JsonPropertyName("asset_ids")]
        [OdooField("asset_ids")]
        public List<int> AssetIds { get; set; }

        /// <summary>
        /// <para>Name: Non Deductible Tax Value</para>
        /// <para>Internal: non_deductible_tax_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("non_deductible_tax_value")]
        [OdooField("non_deductible_tax_value")]
        public decimal NonDeductibleTaxValue { get; set; }

    }
}
