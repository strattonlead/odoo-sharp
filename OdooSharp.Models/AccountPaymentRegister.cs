using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.payment.register")]
    public partial class AccountPaymentRegister
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
        /// <para>Name: Payment Date</para>
        /// <para>Internal: payment_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("payment_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("payment_date")]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// <para>Name: Amount</para>
        /// <para>Internal: amount</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount")]
        [OdooField("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// <para>Name: Hide Writeoff Section</para>
        /// <para>Internal: hide_writeoff_section</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("hide_writeoff_section")]
        [OdooField("hide_writeoff_section")]
        public bool HideWriteoffSection { get; set; }

        /// <summary>
        /// <para>Name: Memo</para>
        /// <para>Internal: communication</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("communication")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("communication")]
        public string Communication { get; set; }

        /// <summary>
        /// <para>Name: Group Payments</para>
        /// <para>Internal: group_payment</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_payment")]
        [OdooField("group_payment")]
        public bool GroupPayment { get; set; }

        /// <summary>
        /// <para>Name: Early Payment Discount Mode</para>
        /// <para>Internal: early_payment_discount_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("early_payment_discount_mode")]
        [OdooField("early_payment_discount_mode")]
        public bool EarlyPaymentDiscountMode { get; set; }

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
        [OdooField("currency_id")]
        public int? CurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Journal</para>
        /// <para>Internal: journal_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("journal_id")]
        public int? JournalId { get; set; }

        /// <summary>
        /// <para>Name: Available Journal</para>
        /// <para>Internal: available_journal_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("available_journal_ids")]
        [OdooField("available_journal_ids")]
        public List<int> AvailableJournalIds { get; set; }

        /// <summary>
        /// <para>Name: Available Partner Bank</para>
        /// <para>Internal: available_partner_bank_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner.bank</para>
        /// </summary>
        [JsonPropertyName("available_partner_bank_ids")]
        [OdooField("available_partner_bank_ids")]
        public List<int> AvailablePartnerBankIds { get; set; }

        /// <summary>
        /// <para>Name: Recipient Bank Account</para>
        /// <para>Internal: partner_bank_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner.bank</para>
        /// </summary>
        [JsonPropertyName("partner_bank_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("partner_bank_id")]
        public int? PartnerBankId { get; set; }

        /// <summary>
        /// <para>Name: Company Currency</para>
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
        /// <para>Name: QR Code URL</para>
        /// <para>Internal: qr_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("qr_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// <para>Name: Batches</para>
        /// <para>Internal: batches</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("batches")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("batches")]
        public object Batches { get; set; }

        /// <summary>
        /// <para>Name: Installments Mode</para>
        /// <para>Internal: installments_mode</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [next]=Next Installment,[overdue]=Overdue Amount,[before_date]=Before Next Payment Date,[full]=Full Amount</para>
        /// </summary>
        [JsonPropertyName("installments_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("installments_mode")]
        public string InstallmentsMode { get; set; }

        /// <summary>
        /// <para>Name: Installments Switch Html</para>
        /// <para>Internal: installments_switch_html</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("installments_switch_html")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("installments_switch_html")]
        public string InstallmentsSwitchHtml { get; set; }

        /// <summary>
        /// <para>Name: Installments Switch Amount</para>
        /// <para>Internal: installments_switch_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("installments_switch_amount")]
        [OdooField("installments_switch_amount")]
        public decimal InstallmentsSwitchAmount { get; set; }

        /// <summary>
        /// <para>Name: Custom User Amount</para>
        /// <para>Internal: custom_user_amount</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("custom_user_amount")]
        [OdooField("custom_user_amount")]
        public decimal CustomUserAmount { get; set; }

        /// <summary>
        /// <para>Name: Custom User Currency</para>
        /// <para>Internal: custom_user_currency_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("custom_user_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("custom_user_currency_id")]
        public int? CustomUserCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Journal items</para>
        /// <para>Internal: line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("line_ids")]
        [OdooField("line_ids")]
        public List<int> LineIds { get; set; }

        /// <summary>
        /// <para>Name: Payment Type</para>
        /// <para>Internal: payment_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [outbound]=Send Money,[inbound]=Receive Money</para>
        /// </summary>
        [JsonPropertyName("payment_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>Name: Partner Type</para>
        /// <para>Internal: partner_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [customer]=Customer,[supplier]=Vendor</para>
        /// </summary>
        [JsonPropertyName("partner_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_type")]
        public string PartnerType { get; set; }

        /// <summary>
        /// <para>Name: Amount to Pay (company currency)</para>
        /// <para>Internal: source_amount</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("source_amount")]
        [OdooField("source_amount")]
        public decimal SourceAmount { get; set; }

        /// <summary>
        /// <para>Name: Amount to Pay (foreign currency)</para>
        /// <para>Internal: source_amount_currency</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("source_amount_currency")]
        [OdooField("source_amount_currency")]
        public decimal SourceAmountCurrency { get; set; }

        /// <summary>
        /// <para>Name: Source Currency</para>
        /// <para>Internal: source_currency_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("source_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("source_currency_id")]
        public int? SourceCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Can Edit Wizard</para>
        /// <para>Internal: can_edit_wizard</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("can_edit_wizard")]
        [OdooField("can_edit_wizard")]
        public bool CanEditWizard { get; set; }

        /// <summary>
        /// <para>Name: Can Group Payments</para>
        /// <para>Internal: can_group_payments</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("can_group_payments")]
        [OdooField("can_group_payments")]
        public bool CanGroupPayments { get; set; }

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
        /// <para>Name: Customer/Vendor</para>
        /// <para>Internal: partner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("partner_id")]
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Payment Method</para>
        /// <para>Internal: payment_method_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.payment.method.line</para>
        /// </summary>
        [JsonPropertyName("payment_method_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("payment_method_line_id")]
        public int? PaymentMethodLineId { get; set; }

        /// <summary>
        /// <para>Name: Available Payment Method Line</para>
        /// <para>Internal: available_payment_method_line_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.payment.method.line</para>
        /// </summary>
        [JsonPropertyName("available_payment_method_line_ids")]
        [OdooField("available_payment_method_line_ids")]
        public List<int> AvailablePaymentMethodLineIds { get; set; }

        /// <summary>
        /// <para>Name: Payment Difference</para>
        /// <para>Internal: payment_difference</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("payment_difference")]
        [OdooField("payment_difference")]
        public decimal PaymentDifference { get; set; }

        /// <summary>
        /// <para>Name: Payment Difference Handling</para>
        /// <para>Internal: payment_difference_handling</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [open]=Keep open,[reconcile]=Mark as fully paid</para>
        /// </summary>
        [JsonPropertyName("payment_difference_handling")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("payment_difference_handling")]
        public string PaymentDifferenceHandling { get; set; }

        /// <summary>
        /// <para>Name: Difference Account</para>
        /// <para>Internal: writeoff_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("writeoff_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("writeoff_account_id")]
        public int? WriteoffAccountId { get; set; }

        /// <summary>
        /// <para>Name: Journal Item Label</para>
        /// <para>Internal: writeoff_label</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("writeoff_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("writeoff_label")]
        public string WriteoffLabel { get; set; }

        /// <summary>
        /// <para>Name: Writeoff Is Exchange Account</para>
        /// <para>Internal: writeoff_is_exchange_account</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("writeoff_is_exchange_account")]
        [OdooField("writeoff_is_exchange_account")]
        public bool WriteoffIsExchangeAccount { get; set; }

        /// <summary>
        /// <para>Name: Show Payment Difference</para>
        /// <para>Internal: show_payment_difference</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_payment_difference")]
        [OdooField("show_payment_difference")]
        public bool ShowPaymentDifference { get; set; }

        /// <summary>
        /// <para>Name: Show Partner Bank Account</para>
        /// <para>Internal: show_partner_bank_account</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_partner_bank_account")]
        [OdooField("show_partner_bank_account")]
        public bool ShowPartnerBankAccount { get; set; }

        /// <summary>
        /// <para>Name: Require Partner Bank Account</para>
        /// <para>Internal: require_partner_bank_account</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("require_partner_bank_account")]
        [OdooField("require_partner_bank_account")]
        public bool RequirePartnerBankAccount { get; set; }

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
        /// <para>Name: Duplicate Payment</para>
        /// <para>Internal: duplicate_payment_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.payment</para>
        /// </summary>
        [JsonPropertyName("duplicate_payment_ids")]
        [OdooField("duplicate_payment_ids")]
        public List<int> DuplicatePaymentIds { get; set; }

        /// <summary>
        /// <para>Name: Is Register Payment On Draft</para>
        /// <para>Internal: is_register_payment_on_draft</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_register_payment_on_draft")]
        [OdooField("is_register_payment_on_draft")]
        public bool IsRegisterPaymentOnDraft { get; set; }

        /// <summary>
        /// <para>Name: Actionable Errors</para>
        /// <para>Internal: actionable_errors</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("actionable_errors")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("actionable_errors")]
        public object ActionableErrors { get; set; }

        /// <summary>
        /// <para>Name: Untrusted Bank</para>
        /// <para>Internal: untrusted_bank_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner.bank</para>
        /// </summary>
        [JsonPropertyName("untrusted_bank_ids")]
        [OdooField("untrusted_bank_ids")]
        public List<int> UntrustedBankIds { get; set; }

        /// <summary>
        /// <para>Name: Total Payments Amount</para>
        /// <para>Internal: total_payments_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("total_payments_amount")]
        [OdooField("total_payments_amount")]
        public int TotalPaymentsAmount { get; set; }

        /// <summary>
        /// <para>Name: Untrusted Payments Count</para>
        /// <para>Internal: untrusted_payments_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("untrusted_payments_count")]
        [OdooField("untrusted_payments_count")]
        public int UntrustedPaymentsCount { get; set; }

        /// <summary>
        /// <para>Name: Missing Account Partners</para>
        /// <para>Internal: missing_account_partners</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("missing_account_partners")]
        [OdooField("missing_account_partners")]
        public List<int> MissingAccountPartners { get; set; }

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
        /// <para>Name: Saved payment token</para>
        /// <para>Internal: payment_token_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: payment.token</para>
        /// </summary>
        [JsonPropertyName("payment_token_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("payment_token_id")]
        public int? PaymentTokenId { get; set; }

        /// <summary>
        /// <para>Name: Suitable Payment Token</para>
        /// <para>Internal: suitable_payment_token_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: payment.token</para>
        /// </summary>
        [JsonPropertyName("suitable_payment_token_ids")]
        [OdooField("suitable_payment_token_ids")]
        public List<int> SuitablePaymentTokenIds { get; set; }

        /// <summary>
        /// <para>Name: Use Electronic Payment Method</para>
        /// <para>Internal: use_electronic_payment_method</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_electronic_payment_method")]
        [OdooField("use_electronic_payment_method")]
        public bool UseElectronicPaymentMethod { get; set; }

        /// <summary>
        /// <para>Name: Code</para>
        /// <para>Internal: payment_method_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("payment_method_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("payment_method_code")]
        public string PaymentMethodCode { get; set; }

    }
}
