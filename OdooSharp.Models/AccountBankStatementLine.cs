using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.bank.statement.line")]
    public partial class AccountBankStatementLine
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
        /// <para>Required: yes</para>
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
        /// <para>Name: Statement</para>
        /// <para>Internal: statement_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.bank.statement</para>
        /// </summary>
        [JsonPropertyName("statement_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("statement_id")]
        public int? StatementId { get; set; }

        /// <summary>
        /// <para>Name: Auto-generated Payments</para>
        /// <para>Internal: payment_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.payment</para>
        /// </summary>
        [JsonPropertyName("payment_ids")]
        [OdooField("payment_ids")]
        public List<int> PaymentIds { get; set; }

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
        /// <para>Name: Bank Account Number</para>
        /// <para>Internal: account_number</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_number")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// <para>Name: Partner Name</para>
        /// <para>Internal: partner_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// <para>Name: Transaction Type</para>
        /// <para>Internal: transaction_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("transaction_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("transaction_type")]
        public string TransactionType { get; set; }

        /// <summary>
        /// <para>Name: Label</para>
        /// <para>Internal: payment_ref</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("payment_ref")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("payment_ref")]
        public string PaymentRef { get; set; }

        /// <summary>
        /// <para>Name: Journal Currency</para>
        /// <para>Internal: currency_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Running Balance</para>
        /// <para>Internal: running_balance</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("running_balance")]
        [OdooField("running_balance")]
        public decimal RunningBalance { get; set; }

        /// <summary>
        /// <para>Name: Foreign Currency</para>
        /// <para>Internal: foreign_currency_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("foreign_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("foreign_currency_id")]
        public int? ForeignCurrencyId { get; set; }

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
        /// <para>Name: Residual Amount</para>
        /// <para>Internal: amount_residual</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("amount_residual")]
        [OdooField("amount_residual")]
        public double AmountResidual { get; set; }

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
        /// <para>Name: Internal Reference</para>
        /// <para>Internal: internal_index</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("internal_index")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("internal_index")]
        public string InternalIndex { get; set; }

        /// <summary>
        /// <para>Name: Is Reconciled</para>
        /// <para>Internal: is_reconciled</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_reconciled")]
        [OdooField("is_reconciled")]
        public bool IsReconciled { get; set; }

        /// <summary>
        /// <para>Name: Is Complete</para>
        /// <para>Internal: statement_complete</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("statement_complete")]
        [OdooField("statement_complete")]
        public bool StatementComplete { get; set; }

        /// <summary>
        /// <para>Name: Is Valid</para>
        /// <para>Internal: statement_valid</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("statement_valid")]
        [OdooField("statement_valid")]
        public bool StatementValid { get; set; }

        /// <summary>
        /// <para>Name: Ending Balance</para>
        /// <para>Internal: statement_balance_end_real</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("statement_balance_end_real")]
        [OdooField("statement_balance_end_real")]
        public decimal StatementBalanceEndReal { get; set; }

        /// <summary>
        /// <para>Name: Statement Name</para>
        /// <para>Internal: statement_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("statement_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("statement_name")]
        public string StatementName { get; set; }

        /// <summary>
        /// <para>Name: Transaction Details</para>
        /// <para>Internal: transaction_details</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("transaction_details")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("transaction_details")]
        public object TransactionDetails { get; set; }

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
        /// <para>Name: Cron Last Check</para>
        /// <para>Internal: cron_last_check</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("cron_last_check")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("cron_last_check")]
        public DateTime? CronLastCheck { get; set; }

        /// <summary>
        /// <para>Name: Bank Statement Attachment</para>
        /// <para>Internal: bank_statement_attachment_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("bank_statement_attachment_ids")]
        [OdooField("bank_statement_attachment_ids")]
        public List<int> BankStatementAttachmentIds { get; set; }

        /// <summary>
        /// <para>Name: Import ID</para>
        /// <para>Internal: unique_import_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("unique_import_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("unique_import_id")]
        public string UniqueImportId { get; set; }

        /// <summary>
        /// <para>Name: Online Transaction Identifier</para>
        /// <para>Internal: online_transaction_identifier</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("online_transaction_identifier")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("online_transaction_identifier")]
        public string OnlineTransactionIdentifier { get; set; }

        /// <summary>
        /// <para>Name: Online Partner Information</para>
        /// <para>Internal: online_partner_information</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("online_partner_information")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("online_partner_information")]
        public string OnlinePartnerInformation { get; set; }

        /// <summary>
        /// <para>Name: Online Account</para>
        /// <para>Internal: online_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.online.account</para>
        /// </summary>
        [JsonPropertyName("online_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("online_account_id")]
        public int? OnlineAccountId { get; set; }

        /// <summary>
        /// <para>Name: Account Online Link</para>
        /// <para>Internal: online_link_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.online.link</para>
        /// </summary>
        [JsonPropertyName("online_link_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("online_link_id")]
        public int? OnlineLinkId { get; set; }

        /// <summary>
        /// <para>Name: Campaign</para>
        /// <para>Internal: campaign_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: utm.campaign</para>
        /// </summary>
        [JsonPropertyName("campaign_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("campaign_id")]
        public int? CampaignId { get; set; }

        /// <summary>
        /// <para>Name: Source</para>
        /// <para>Internal: source_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: utm.source</para>
        /// </summary>
        [JsonPropertyName("source_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("source_id")]
        public int? SourceId { get; set; }

        /// <summary>
        /// <para>Name: Medium</para>
        /// <para>Internal: medium_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: utm.medium</para>
        /// </summary>
        [JsonPropertyName("medium_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("medium_id")]
        public int? MediumId { get; set; }

        /// <summary>
        /// <para>Name: Sequence Prefix</para>
        /// <para>Internal: sequence_prefix</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("sequence_prefix")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sequence_prefix")]
        public string SequencePrefix { get; set; }

        /// <summary>
        /// <para>Name: Sequence Number</para>
        /// <para>Internal: sequence_number</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sequence_number")]
        [OdooField("sequence_number")]
        public int SequenceNumber { get; set; }

        /// <summary>
        /// <para>Name: Activities</para>
        /// <para>Internal: activity_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.activity</para>
        /// </summary>
        [JsonPropertyName("activity_ids")]
        [OdooField("activity_ids")]
        public List<int> ActivityIds { get; set; }

        /// <summary>
        /// <para>Name: Activity State</para>
        /// <para>Internal: activity_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [overdue]=Overdue,[today]=Today,[planned]=Planned</para>
        /// </summary>
        [JsonPropertyName("activity_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_state")]
        public string ActivityState { get; set; }

        /// <summary>
        /// <para>Name: Responsible User</para>
        /// <para>Internal: activity_user_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("activity_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("activity_user_id")]
        public int? ActivityUserId { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Type</para>
        /// <para>Internal: activity_type_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.activity.type</para>
        /// </summary>
        [JsonPropertyName("activity_type_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("activity_type_id")]
        public int? ActivityTypeId { get; set; }

        /// <summary>
        /// <para>Name: Activity Type Icon</para>
        /// <para>Internal: activity_type_icon</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_type_icon")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_type_icon")]
        public string ActivityTypeIcon { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Deadline</para>
        /// <para>Internal: activity_date_deadline</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("activity_date_deadline")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("activity_date_deadline")]
        public DateTime? ActivityDateDeadline { get; set; }

        /// <summary>
        /// <para>Name: My Activity Deadline</para>
        /// <para>Internal: my_activity_date_deadline</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("my_activity_date_deadline")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("my_activity_date_deadline")]
        public DateTime? MyActivityDateDeadline { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Summary</para>
        /// <para>Internal: activity_summary</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_summary")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_summary")]
        public string ActivitySummary { get; set; }

        /// <summary>
        /// <para>Name: Activity Exception Decoration</para>
        /// <para>Internal: activity_exception_decoration</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [warning]=Alert,[danger]=Error</para>
        /// </summary>
        [JsonPropertyName("activity_exception_decoration")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_exception_decoration")]
        public string ActivityExceptionDecoration { get; set; }

        /// <summary>
        /// <para>Name: Icon</para>
        /// <para>Internal: activity_exception_icon</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_exception_icon")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_exception_icon")]
        public string ActivityExceptionIcon { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Calendar Event</para>
        /// <para>Internal: activity_calendar_event_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: calendar.event</para>
        /// </summary>
        [JsonPropertyName("activity_calendar_event_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("activity_calendar_event_id")]
        public int? ActivityCalendarEventId { get; set; }

        /// <summary>
        /// <para>Name: Portal Access URL</para>
        /// <para>Internal: access_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("access_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_url")]
        public string AccessUrl { get; set; }

        /// <summary>
        /// <para>Name: Security Token</para>
        /// <para>Internal: access_token</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("access_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>Name: Access warning</para>
        /// <para>Internal: access_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("access_warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_warning")]
        public string AccessWarning { get; set; }

        /// <summary>
        /// <para>Name: Is Follower</para>
        /// <para>Internal: message_is_follower</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_is_follower")]
        [OdooField("message_is_follower")]
        public bool MessageIsFollower { get; set; }

        /// <summary>
        /// <para>Name: Followers</para>
        /// <para>Internal: message_follower_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.followers</para>
        /// </summary>
        [JsonPropertyName("message_follower_ids")]
        [OdooField("message_follower_ids")]
        public List<int> MessageFollowerIds { get; set; }

        /// <summary>
        /// <para>Name: Followers (Partners)</para>
        /// <para>Internal: message_partner_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("message_partner_ids")]
        [OdooField("message_partner_ids")]
        public List<int> MessagePartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Messages</para>
        /// <para>Internal: message_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("message_ids")]
        [OdooField("message_ids")]
        public List<int> MessageIds { get; set; }

        /// <summary>
        /// <para>Name: Has Message</para>
        /// <para>Internal: has_message</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_message")]
        [OdooField("has_message")]
        public bool HasMessage { get; set; }

        /// <summary>
        /// <para>Name: Action Needed</para>
        /// <para>Internal: message_needaction</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_needaction")]
        [OdooField("message_needaction")]
        public bool MessageNeedaction { get; set; }

        /// <summary>
        /// <para>Name: Number of Actions</para>
        /// <para>Internal: message_needaction_counter</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_needaction_counter")]
        [OdooField("message_needaction_counter")]
        public int MessageNeedactionCounter { get; set; }

        /// <summary>
        /// <para>Name: Message Delivery error</para>
        /// <para>Internal: message_has_error</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_has_error")]
        [OdooField("message_has_error")]
        public bool MessageHasError { get; set; }

        /// <summary>
        /// <para>Name: Number of errors</para>
        /// <para>Internal: message_has_error_counter</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_has_error_counter")]
        [OdooField("message_has_error_counter")]
        public int MessageHasErrorCounter { get; set; }

        /// <summary>
        /// <para>Name: Attachment Count</para>
        /// <para>Internal: message_attachment_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_attachment_count")]
        [OdooField("message_attachment_count")]
        public int MessageAttachmentCount { get; set; }

        /// <summary>
        /// <para>Name: Ratings</para>
        /// <para>Internal: rating_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: rating.rating</para>
        /// </summary>
        [JsonPropertyName("rating_ids")]
        [OdooField("rating_ids")]
        public List<int> RatingIds { get; set; }

        /// <summary>
        /// <para>Name: Website Messages</para>
        /// <para>Internal: website_message_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("website_message_ids")]
        [OdooField("website_message_ids")]
        public List<int> WebsiteMessageIds { get; set; }

        /// <summary>
        /// <para>Name: SMS Delivery error</para>
        /// <para>Internal: message_has_sms_error</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_has_sms_error")]
        [OdooField("message_has_sms_error")]
        public bool MessageHasSmsError { get; set; }

        /// <summary>
        /// <para>Name: Main Attachment</para>
        /// <para>Internal: message_main_attachment_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("message_main_attachment_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("message_main_attachment_id")]
        public int? MessageMainAttachmentId { get; set; }

        /// <summary>
        /// <para>Name: Number</para>
        /// <para>Internal: name</para>
        /// <para>Store: no</para>
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
        /// <para>Name: Name Placeholder</para>
        /// <para>Internal: name_placeholder</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name_placeholder")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name_placeholder")]
        public string NamePlaceholder { get; set; }

        /// <summary>
        /// <para>Name: Reference</para>
        /// <para>Internal: ref</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("ref")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("ref")]
        public string Ref { get; set; }

        /// <summary>
        /// <para>Name: Date</para>
        /// <para>Internal: date</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: state</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [draft]=Draft,[posted]=Posted,[cancel]=Cancelled</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Type</para>
        /// <para>Internal: move_type</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
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
        /// <para>Name: Is Storno</para>
        /// <para>Internal: is_storno</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_storno")]
        [OdooField("is_storno")]
        public bool IsStorno { get; set; }

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
        /// <para>Name: Journal Items</para>
        /// <para>Internal: line_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("line_ids")]
        [OdooField("line_ids")]
        public List<int> LineIds { get; set; }

        /// <summary>
        /// <para>Name: Related reconciliation</para>
        /// <para>Internal: exchange_diff_partial_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.partial.reconcile</para>
        /// </summary>
        [JsonPropertyName("exchange_diff_partial_ids")]
        [OdooField("exchange_diff_partial_ids")]
        public List<int> ExchangeDiffPartialIds { get; set; }

        /// <summary>
        /// <para>Name: Payment</para>
        /// <para>Internal: origin_payment_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.payment</para>
        /// </summary>
        [JsonPropertyName("origin_payment_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("origin_payment_id")]
        public int? OriginPaymentId { get; set; }

        /// <summary>
        /// <para>Name: Matched Payments</para>
        /// <para>Internal: matched_payment_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.payment</para>
        /// </summary>
        [JsonPropertyName("matched_payment_ids")]
        [OdooField("matched_payment_ids")]
        public List<int> MatchedPaymentIds { get; set; }

        /// <summary>
        /// <para>Name: Payment Count</para>
        /// <para>Internal: payment_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("payment_count")]
        [OdooField("payment_count")]
        public int PaymentCount { get; set; }

        /// <summary>
        /// <para>Name: Statement Line</para>
        /// <para>Internal: statement_line_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.bank.statement.line</para>
        /// </summary>
        [JsonPropertyName("statement_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("statement_line_id")]
        public int? StatementLineId { get; set; }

        /// <summary>
        /// <para>Name: Adjusting Entry Origin Moves</para>
        /// <para>Internal: adjusting_entry_origin_move_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("adjusting_entry_origin_move_ids")]
        [OdooField("adjusting_entry_origin_move_ids")]
        public List<int> AdjustingEntryOriginMoveIds { get; set; }

        /// <summary>
        /// <para>Name: Adjusting Entry Origin Label</para>
        /// <para>Internal: adjusting_entry_origin_label</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("adjusting_entry_origin_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("adjusting_entry_origin_label")]
        public string AdjustingEntryOriginLabel { get; set; }

        /// <summary>
        /// <para>Name: Adjusting Entry Origin Moves Count</para>
        /// <para>Internal: adjusting_entry_origin_moves_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("adjusting_entry_origin_moves_count")]
        [OdooField("adjusting_entry_origin_moves_count")]
        public int AdjustingEntryOriginMovesCount { get; set; }

        /// <summary>
        /// <para>Name: Created Adjusting Entries</para>
        /// <para>Internal: adjusting_entries_move_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("adjusting_entries_move_ids")]
        [OdooField("adjusting_entries_move_ids")]
        public List<int> AdjustingEntriesMoveIds { get; set; }

        /// <summary>
        /// <para>Name: Adjusting Entries Count</para>
        /// <para>Internal: adjusting_entries_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("adjusting_entries_count")]
        [OdooField("adjusting_entries_count")]
        public int AdjustingEntriesCount { get; set; }

        /// <summary>
        /// <para>Name: Tax Cash Basis Entry of</para>
        /// <para>Internal: tax_cash_basis_rec_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.partial.reconcile</para>
        /// </summary>
        [JsonPropertyName("tax_cash_basis_rec_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("tax_cash_basis_rec_id")]
        public int? TaxCashBasisRecId { get; set; }

        /// <summary>
        /// <para>Name: Cash Basis Origin</para>
        /// <para>Internal: tax_cash_basis_origin_move_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("tax_cash_basis_origin_move_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("tax_cash_basis_origin_move_id")]
        public int? TaxCashBasisOriginMoveId { get; set; }

        /// <summary>
        /// <para>Name: Cash Basis Entries</para>
        /// <para>Internal: tax_cash_basis_created_move_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("tax_cash_basis_created_move_ids")]
        [OdooField("tax_cash_basis_created_move_ids")]
        public List<int> TaxCashBasisCreatedMoveIds { get; set; }

        /// <summary>
        /// <para>Name: Always Tax Exigible</para>
        /// <para>Internal: always_tax_exigible</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("always_tax_exigible")]
        [OdooField("always_tax_exigible")]
        public bool AlwaysTaxExigible { get; set; }

        /// <summary>
        /// <para>Name: Auto-post</para>
        /// <para>Internal: auto_post</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no]=No,[at_date]=At Date,[monthly]=Monthly,[quarterly]=Quarterly,[yearly]=Yearly</para>
        /// </summary>
        [JsonPropertyName("auto_post")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("auto_post")]
        public string AutoPost { get; set; }

        /// <summary>
        /// <para>Name: Auto-post until</para>
        /// <para>Internal: auto_post_until</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("auto_post_until")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("auto_post_until")]
        public DateTime? AutoPostUntil { get; set; }

        /// <summary>
        /// <para>Name: First recurring entry</para>
        /// <para>Internal: auto_post_origin_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("auto_post_origin_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("auto_post_origin_id")]
        public int? AutoPostOriginId { get; set; }

        /// <summary>
        /// <para>Name: Hide Post Button</para>
        /// <para>Internal: hide_post_button</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("hide_post_button")]
        [OdooField("hide_post_button")]
        public bool HidePostButton { get; set; }

        /// <summary>
        /// <para>Name: Checked</para>
        /// <para>Internal: checked</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("checked")]
        [OdooField("checked")]
        public bool Checked { get; set; }

        /// <summary>
        /// <para>Name: Posted Before</para>
        /// <para>Internal: posted_before</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("posted_before")]
        [OdooField("posted_before")]
        public bool PostedBefore { get; set; }

        /// <summary>
        /// <para>Name: Suitable Journal</para>
        /// <para>Internal: suitable_journal_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("suitable_journal_ids")]
        [OdooField("suitable_journal_ids")]
        public List<int> SuitableJournalIds { get; set; }

        /// <summary>
        /// <para>Name: Highest Name</para>
        /// <para>Internal: highest_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("highest_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("highest_name")]
        public string HighestName { get; set; }

        /// <summary>
        /// <para>Name: Made Sequence Gap</para>
        /// <para>Internal: made_sequence_gap</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("made_sequence_gap")]
        [OdooField("made_sequence_gap")]
        public bool MadeSequenceGap { get; set; }

        /// <summary>
        /// <para>Name: Show Name Warning</para>
        /// <para>Internal: show_name_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_name_warning")]
        [OdooField("show_name_warning")]
        public bool ShowNameWarning { get; set; }

        /// <summary>
        /// <para>Name: Type Name</para>
        /// <para>Internal: type_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("type_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("type_name")]
        public string TypeName { get; set; }

        /// <summary>
        /// <para>Name: Default Sales Price Include</para>
        /// <para>Internal: company_price_include</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [tax_included]=Tax Included,[tax_excluded]=Tax Excluded</para>
        /// </summary>
        [JsonPropertyName("company_price_include")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_price_include")]
        public string CompanyPriceInclude { get; set; }

        /// <summary>
        /// <para>Name: Attachments</para>
        /// <para>Internal: attachment_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("attachment_ids")]
        [OdooField("attachment_ids")]
        public List<int> AttachmentIds { get; set; }

        /// <summary>
        /// <para>Name: Audit Trail Messages</para>
        /// <para>Internal: audit_trail_message_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("audit_trail_message_ids")]
        [OdooField("audit_trail_message_ids")]
        public List<int> AuditTrailMessageIds { get; set; }

        /// <summary>
        /// <para>Name: Secure Posted Entries with Hash</para>
        /// <para>Internal: restrict_mode_hash_table</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("restrict_mode_hash_table")]
        [OdooField("restrict_mode_hash_table")]
        public bool RestrictModeHashTable { get; set; }

        /// <summary>
        /// <para>Name: Inalterability No Gap Sequence #</para>
        /// <para>Internal: secure_sequence_number</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("secure_sequence_number")]
        [OdooField("secure_sequence_number")]
        public int SecureSequenceNumber { get; set; }

        /// <summary>
        /// <para>Name: Inalterability Hash</para>
        /// <para>Internal: inalterable_hash</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("inalterable_hash")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("inalterable_hash")]
        public string InalterableHash { get; set; }

        /// <summary>
        /// <para>Name: Secured</para>
        /// <para>Internal: secured</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("secured")]
        [OdooField("secured")]
        public bool Secured { get; set; }

        /// <summary>
        /// <para>Name: Invoice lines</para>
        /// <para>Internal: invoice_line_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("invoice_line_ids")]
        [OdooField("invoice_line_ids")]
        public List<int> InvoiceLineIds { get; set; }

        /// <summary>
        /// <para>Name: Invoice/Bill Date</para>
        /// <para>Internal: invoice_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("invoice_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("invoice_date")]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// <para>Name: Due Date</para>
        /// <para>Internal: invoice_date_due</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("invoice_date_due")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("invoice_date_due")]
        public DateTime? InvoiceDateDue { get; set; }

        /// <summary>
        /// <para>Name: Delivery Date</para>
        /// <para>Internal: delivery_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("delivery_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("delivery_date")]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// <para>Name: Show Delivery Date</para>
        /// <para>Internal: show_delivery_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_delivery_date")]
        [OdooField("show_delivery_date")]
        public bool ShowDeliveryDate { get; set; }

        /// <summary>
        /// <para>Name: Payment Terms</para>
        /// <para>Internal: invoice_payment_term_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.payment.term</para>
        /// </summary>
        [JsonPropertyName("invoice_payment_term_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("invoice_payment_term_id")]
        public int? InvoicePaymentTermId { get; set; }

        /// <summary>
        /// <para>Name: Needed Terms</para>
        /// <para>Internal: needed_terms</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("needed_terms")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("needed_terms")]
        public object NeededTerms { get; set; }

        /// <summary>
        /// <para>Name: Needed Terms Dirty</para>
        /// <para>Internal: needed_terms_dirty</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("needed_terms_dirty")]
        [OdooField("needed_terms_dirty")]
        public bool NeededTermsDirty { get; set; }

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
        /// <para>Name: Commercial Entity</para>
        /// <para>Internal: commercial_partner_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("commercial_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("commercial_partner_id")]
        public int? CommercialPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Delivery Address</para>
        /// <para>Internal: partner_shipping_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_shipping_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("partner_shipping_id")]
        public int? PartnerShippingId { get; set; }

        /// <summary>
        /// <para>Name: Recipient Bank</para>
        /// <para>Internal: partner_bank_id</para>
        /// <para>Store: no</para>
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
        /// <para>Name: Fiscal Position</para>
        /// <para>Internal: fiscal_position_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.fiscal.position</para>
        /// </summary>
        [JsonPropertyName("fiscal_position_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("fiscal_position_id")]
        public int? FiscalPositionId { get; set; }

        /// <summary>
        /// <para>Name: Payment Reference</para>
        /// <para>Internal: payment_reference</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("payment_reference")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("payment_reference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// <para>Name: Display QR-code</para>
        /// <para>Internal: display_qr_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_qr_code")]
        [OdooField("display_qr_code")]
        public bool DisplayQrCode { get; set; }

        /// <summary>
        /// <para>Name: Payment QR-code</para>
        /// <para>Internal: qr_code_method</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [sct_qr]=QR für SEPA-Überweisung</para>
        /// </summary>
        [JsonPropertyName("qr_code_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("qr_code_method")]
        public string QrCodeMethod { get; set; }

        /// <summary>
        /// <para>Name: Invoice Outstanding Credits Debits Widget</para>
        /// <para>Internal: invoice_outstanding_credits_debits_widget</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("invoice_outstanding_credits_debits_widget")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("invoice_outstanding_credits_debits_widget")]
        public object InvoiceOutstandingCreditsDebitsWidget { get; set; }

        /// <summary>
        /// <para>Name: Invoice Has Outstanding</para>
        /// <para>Internal: invoice_has_outstanding</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("invoice_has_outstanding")]
        [OdooField("invoice_has_outstanding")]
        public bool InvoiceHasOutstanding { get; set; }

        /// <summary>
        /// <para>Name: Invoice Payments Widget</para>
        /// <para>Internal: invoice_payments_widget</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("invoice_payments_widget")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("invoice_payments_widget")]
        public object InvoicePaymentsWidget { get; set; }

        /// <summary>
        /// <para>Name: Preferred Payment Method Line</para>
        /// <para>Internal: preferred_payment_method_line_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.payment.method.line</para>
        /// </summary>
        [JsonPropertyName("preferred_payment_method_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("preferred_payment_method_line_id")]
        public int? PreferredPaymentMethodLineId { get; set; }

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
        /// <para>Name: Currency Rate</para>
        /// <para>Internal: invoice_currency_rate</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("invoice_currency_rate")]
        [OdooField("invoice_currency_rate")]
        public double InvoiceCurrencyRate { get; set; }

        /// <summary>
        /// <para>Name: Direction Sign</para>
        /// <para>Internal: direction_sign</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("direction_sign")]
        [OdooField("direction_sign")]
        public int DirectionSign { get; set; }

        /// <summary>
        /// <para>Name: Untaxed Amount</para>
        /// <para>Internal: amount_untaxed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_untaxed")]
        [OdooField("amount_untaxed")]
        public decimal AmountUntaxed { get; set; }

        /// <summary>
        /// <para>Name: Tax</para>
        /// <para>Internal: amount_tax</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_tax")]
        [OdooField("amount_tax")]
        public decimal AmountTax { get; set; }

        /// <summary>
        /// <para>Name: Total</para>
        /// <para>Internal: amount_total</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_total")]
        [OdooField("amount_total")]
        public decimal AmountTotal { get; set; }

        /// <summary>
        /// <para>Name: Untaxed Amount Signed</para>
        /// <para>Internal: amount_untaxed_signed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_untaxed_signed")]
        [OdooField("amount_untaxed_signed")]
        public decimal AmountUntaxedSigned { get; set; }

        /// <summary>
        /// <para>Name: Untaxed Amount Signed Currency</para>
        /// <para>Internal: amount_untaxed_in_currency_signed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_untaxed_in_currency_signed")]
        [OdooField("amount_untaxed_in_currency_signed")]
        public decimal AmountUntaxedInCurrencySigned { get; set; }

        /// <summary>
        /// <para>Name: Tax Signed</para>
        /// <para>Internal: amount_tax_signed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_tax_signed")]
        [OdooField("amount_tax_signed")]
        public decimal AmountTaxSigned { get; set; }

        /// <summary>
        /// <para>Name: Total Signed</para>
        /// <para>Internal: amount_total_signed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_total_signed")]
        [OdooField("amount_total_signed")]
        public decimal AmountTotalSigned { get; set; }

        /// <summary>
        /// <para>Name: Total in Currency Signed</para>
        /// <para>Internal: amount_total_in_currency_signed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_total_in_currency_signed")]
        [OdooField("amount_total_in_currency_signed")]
        public decimal AmountTotalInCurrencySigned { get; set; }

        /// <summary>
        /// <para>Name: Amount Due Signed</para>
        /// <para>Internal: amount_residual_signed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_residual_signed")]
        [OdooField("amount_residual_signed")]
        public decimal AmountResidualSigned { get; set; }

        /// <summary>
        /// <para>Name: Invoice Totals</para>
        /// <para>Internal: tax_totals</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("tax_totals")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("tax_totals")]
        public byte[] TaxTotals { get; set; }

        /// <summary>
        /// <para>Name: Payment Status</para>
        /// <para>Internal: payment_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_paid]=Not Paid,[in_payment]=In Payment,[paid]=Paid,[partial]=Partially Paid,[reversed]=Reversed,[blocked]=Blocked,[invoicing_legacy]=Invoicing App Legacy</para>
        /// </summary>
        [JsonPropertyName("payment_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("payment_state")]
        public string PaymentState { get; set; }

        /// <summary>
        /// <para>Name: Status In Payment</para>
        /// <para>Internal: status_in_payment</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_paid]=Not Paid,[in_payment]=In Payment,[paid]=Paid,[partial]=Partially Paid,[reversed]=Reversed,[blocked]=Blocked,[invoicing_legacy]=Invoicing App Legacy,[draft]=Draft,[cancel]=Cancelled</para>
        /// </summary>
        [JsonPropertyName("status_in_payment")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("status_in_payment")]
        public string StatusInPayment { get; set; }

        /// <summary>
        /// <para>Name: Amount total in words</para>
        /// <para>Internal: amount_total_words</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("amount_total_words")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("amount_total_words")]
        public string AmountTotalWords { get; set; }

        /// <summary>
        /// <para>Name: Reversal of</para>
        /// <para>Internal: reversed_entry_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("reversed_entry_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("reversed_entry_id")]
        public int? ReversedEntryId { get; set; }

        /// <summary>
        /// <para>Name: Reversal Move</para>
        /// <para>Internal: reversal_move_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("reversal_move_ids")]
        [OdooField("reversal_move_ids")]
        public List<int> ReversalMoveIds { get; set; }

        /// <summary>
        /// <para>Name: Vendor Bill</para>
        /// <para>Internal: invoice_vendor_bill_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("invoice_vendor_bill_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("invoice_vendor_bill_id")]
        public int? InvoiceVendorBillId { get; set; }

        /// <summary>
        /// <para>Name: Source Email</para>
        /// <para>Internal: invoice_source_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("invoice_source_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_source_email")]
        public string InvoiceSourceEmail { get; set; }

        /// <summary>
        /// <para>Name: Invoice Partner Display Name</para>
        /// <para>Internal: invoice_partner_display_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("invoice_partner_display_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_partner_display_name")]
        public string InvoicePartnerDisplayName { get; set; }

        /// <summary>
        /// <para>Name: Is Manually Modified</para>
        /// <para>Internal: is_manually_modified</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_manually_modified")]
        [OdooField("is_manually_modified")]
        public bool IsManuallyModified { get; set; }

        /// <summary>
        /// <para>Name: Quick Edit Mode</para>
        /// <para>Internal: quick_edit_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("quick_edit_mode")]
        [OdooField("quick_edit_mode")]
        public bool QuickEditMode { get; set; }

        /// <summary>
        /// <para>Name: Total (Tax inc.)</para>
        /// <para>Internal: quick_edit_total_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("quick_edit_total_amount")]
        [OdooField("quick_edit_total_amount")]
        public decimal QuickEditTotalAmount { get; set; }

        /// <summary>
        /// <para>Name: Quick Encoding Vals</para>
        /// <para>Internal: quick_encoding_vals</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("quick_encoding_vals")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("quick_encoding_vals")]
        public object QuickEncodingVals { get; set; }

        /// <summary>
        /// <para>Name: Terms and Conditions</para>
        /// <para>Internal: narration</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("narration")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("narration")]
        public string Narration { get; set; }

        /// <summary>
        /// <para>Name: Is Move Sent</para>
        /// <para>Internal: is_move_sent</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_move_sent")]
        [OdooField("is_move_sent")]
        public bool IsMoveSent { get; set; }

        /// <summary>
        /// <para>Name: Is Being Sent</para>
        /// <para>Internal: is_being_sent</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_being_sent")]
        [OdooField("is_being_sent")]
        public bool IsBeingSent { get; set; }

        /// <summary>
        /// <para>Name: Sent</para>
        /// <para>Internal: move_sent_values</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [sent]=Sent,[not_sent]=Not Sent</para>
        /// </summary>
        [JsonPropertyName("move_sent_values")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("move_sent_values")]
        public string MoveSentValues { get; set; }

        /// <summary>
        /// <para>Name: Salesperson</para>
        /// <para>Internal: invoice_user_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("invoice_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("invoice_user_id")]
        public int? InvoiceUserId { get; set; }

        /// <summary>
        /// <para>Name: User</para>
        /// <para>Internal: user_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("user_id")]
        public int? UserId { get; set; }

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
        /// <para>Name: Incoterm</para>
        /// <para>Internal: invoice_incoterm_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.incoterms</para>
        /// </summary>
        [JsonPropertyName("invoice_incoterm_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("invoice_incoterm_id")]
        public int? InvoiceIncotermId { get; set; }

        /// <summary>
        /// <para>Name: Incoterm Location</para>
        /// <para>Internal: incoterm_location</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("incoterm_location")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("incoterm_location")]
        public string IncotermLocation { get; set; }

        /// <summary>
        /// <para>Name: Cash Rounding Method</para>
        /// <para>Internal: invoice_cash_rounding_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.cash.rounding</para>
        /// </summary>
        [JsonPropertyName("invoice_cash_rounding_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("invoice_cash_rounding_id")]
        public int? InvoiceCashRoundingId { get; set; }

        /// <summary>
        /// <para>Name: Sending Data</para>
        /// <para>Internal: sending_data</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("sending_data")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("sending_data")]
        public object SendingData { get; set; }

        /// <summary>
        /// <para>Name: PDF Attachment</para>
        /// <para>Internal: invoice_pdf_report_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("invoice_pdf_report_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("invoice_pdf_report_id")]
        public int? InvoicePdfReportId { get; set; }

        /// <summary>
        /// <para>Name: PDF File</para>
        /// <para>Internal: invoice_pdf_report_file</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("invoice_pdf_report_file")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("invoice_pdf_report_file")]
        public byte[] InvoicePdfReportFile { get; set; }

        /// <summary>
        /// <para>Name: Invoice Filter Type Domain</para>
        /// <para>Internal: invoice_filter_type_domain</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("invoice_filter_type_domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_filter_type_domain")]
        public string InvoiceFilterTypeDomain { get; set; }

        /// <summary>
        /// <para>Name: Bank Partner</para>
        /// <para>Internal: bank_partner_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("bank_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("bank_partner_id")]
        public int? BankPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Tax Lock Date Message</para>
        /// <para>Internal: tax_lock_date_message</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("tax_lock_date_message")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("tax_lock_date_message")]
        public string TaxLockDateMessage { get; set; }

        /// <summary>
        /// <para>Name: Display Inactive Currency Warning</para>
        /// <para>Internal: display_inactive_currency_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_inactive_currency_warning")]
        [OdooField("display_inactive_currency_warning")]
        public bool DisplayInactiveCurrencyWarning { get; set; }

        /// <summary>
        /// <para>Name: Tax Country</para>
        /// <para>Internal: tax_country_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("tax_country_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("tax_country_id")]
        public int? TaxCountryId { get; set; }

        /// <summary>
        /// <para>Name: Tax Country Code</para>
        /// <para>Internal: tax_country_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("tax_country_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("tax_country_code")]
        public string TaxCountryCode { get; set; }

        /// <summary>
        /// <para>Name: Has Reconciled Entries</para>
        /// <para>Internal: has_reconciled_entries</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_reconciled_entries")]
        [OdooField("has_reconciled_entries")]
        public bool HasReconciledEntries { get; set; }

        /// <summary>
        /// <para>Name: Show Reset To Draft Button</para>
        /// <para>Internal: show_reset_to_draft_button</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_reset_to_draft_button")]
        [OdooField("show_reset_to_draft_button")]
        public bool ShowResetToDraftButton { get; set; }

        /// <summary>
        /// <para>Name: Partner Credit Warning</para>
        /// <para>Internal: partner_credit_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("partner_credit_warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_credit_warning")]
        public string PartnerCreditWarning { get; set; }

        /// <summary>
        /// <para>Name: Duplicated Ref</para>
        /// <para>Internal: duplicated_ref_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("duplicated_ref_ids")]
        [OdooField("duplicated_ref_ids")]
        public List<int> DuplicatedRefIds { get; set; }

        /// <summary>
        /// <para>Name: Need Cancel Request</para>
        /// <para>Internal: need_cancel_request</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("need_cancel_request")]
        [OdooField("need_cancel_request")]
        public bool NeedCancelRequest { get; set; }

        /// <summary>
        /// <para>Name: Has Fiscal Position Changed</para>
        /// <para>Internal: show_update_fpos</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_update_fpos")]
        [OdooField("show_update_fpos")]
        public bool ShowUpdateFpos { get; set; }

        /// <summary>
        /// <para>Name: Payment Term Details</para>
        /// <para>Internal: payment_term_details</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("payment_term_details")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("payment_term_details")]
        public object PaymentTermDetails { get; set; }

        /// <summary>
        /// <para>Name: Show Payment Term Details</para>
        /// <para>Internal: show_payment_term_details</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_payment_term_details")]
        [OdooField("show_payment_term_details")]
        public bool ShowPaymentTermDetails { get; set; }

        /// <summary>
        /// <para>Name: Show Discount Details</para>
        /// <para>Internal: show_discount_details</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_discount_details")]
        [OdooField("show_discount_details")]
        public bool ShowDiscountDetails { get; set; }

        /// <summary>
        /// <para>Name: Abnormal Amount Warning</para>
        /// <para>Internal: abnormal_amount_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("abnormal_amount_warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("abnormal_amount_warning")]
        public string AbnormalAmountWarning { get; set; }

        /// <summary>
        /// <para>Name: Abnormal Date Warning</para>
        /// <para>Internal: abnormal_date_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("abnormal_date_warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("abnormal_date_warning")]
        public string AbnormalDateWarning { get; set; }

        /// <summary>
        /// <para>Name: Taxes Legal Notes</para>
        /// <para>Internal: taxes_legal_notes</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("taxes_legal_notes")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("taxes_legal_notes")]
        public string TaxesLegalNotes { get; set; }

        /// <summary>
        /// <para>Name: Next Payment Date</para>
        /// <para>Internal: next_payment_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("next_payment_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("next_payment_date")]
        public DateTime? NextPaymentDate { get; set; }

        /// <summary>
        /// <para>Name: Statements</para>
        /// <para>Internal: statement_line_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.bank.statement.line</para>
        /// </summary>
        [JsonPropertyName("statement_line_ids")]
        [OdooField("statement_line_ids")]
        public List<int> StatementLineIds { get; set; }

        /// <summary>
        /// <para>Name: Payment State Before Switch</para>
        /// <para>Internal: payment_state_before_switch</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("payment_state_before_switch")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("payment_state_before_switch")]
        public string PaymentStateBeforeSwitch { get; set; }

        /// <summary>
        /// <para>Name: Deferred Entries</para>
        /// <para>Internal: deferred_move_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("deferred_move_ids")]
        [OdooField("deferred_move_ids")]
        public List<int> DeferredMoveIds { get; set; }

        /// <summary>
        /// <para>Name: Original Invoices</para>
        /// <para>Internal: deferred_original_move_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("deferred_original_move_ids")]
        [OdooField("deferred_original_move_ids")]
        public List<int> DeferredOriginalMoveIds { get; set; }

        /// <summary>
        /// <para>Name: Deferred Entry Type</para>
        /// <para>Internal: deferred_entry_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [expense]=Deferred Expense,[revenue]=Deferred Revenue</para>
        /// </summary>
        [JsonPropertyName("deferred_entry_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("deferred_entry_type")]
        public string DeferredEntryType { get; set; }

        /// <summary>
        /// <para>Name: Signer</para>
        /// <para>Internal: signing_user</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("signing_user")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("signing_user")]
        public int? SigningUser { get; set; }

        /// <summary>
        /// <para>Name: Show Signature Area</para>
        /// <para>Internal: show_signature_area</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_signature_area")]
        [OdooField("show_signature_area")]
        public bool ShowSignatureArea { get; set; }

        /// <summary>
        /// <para>Name: Signature</para>
        /// <para>Internal: signature</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("signature")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("signature")]
        public object Signature { get; set; }

        /// <summary>
        /// <para>Name: Attachment</para>
        /// <para>Internal: ubl_cii_xml_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("ubl_cii_xml_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("ubl_cii_xml_id")]
        public int? UblCiiXmlId { get; set; }

        /// <summary>
        /// <para>Name: UBL/CII File</para>
        /// <para>Internal: ubl_cii_xml_file</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("ubl_cii_xml_file")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("ubl_cii_xml_file")]
        public byte[] UblCiiXmlFile { get; set; }

        /// <summary>
        /// <para>Name: Transactions</para>
        /// <para>Internal: transaction_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: payment.transaction</para>
        /// </summary>
        [JsonPropertyName("transaction_ids")]
        [OdooField("transaction_ids")]
        public List<int> TransactionIds { get; set; }

        /// <summary>
        /// <para>Name: Authorized Transactions</para>
        /// <para>Internal: authorized_transaction_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: payment.transaction</para>
        /// </summary>
        [JsonPropertyName("authorized_transaction_ids")]
        [OdooField("authorized_transaction_ids")]
        public List<int> AuthorizedTransactionIds { get; set; }

        /// <summary>
        /// <para>Name: Transaction Count</para>
        /// <para>Internal: transaction_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("transaction_count")]
        [OdooField("transaction_count")]
        public int TransactionCount { get; set; }

        /// <summary>
        /// <para>Name: Amount paid</para>
        /// <para>Internal: amount_paid</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_paid")]
        [OdooField("amount_paid")]
        public decimal AmountPaid { get; set; }

        /// <summary>
        /// <para>Name: Auto-complete</para>
        /// <para>Internal: purchase_vendor_bill_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: purchase.bill.union</para>
        /// </summary>
        [JsonPropertyName("purchase_vendor_bill_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("purchase_vendor_bill_id")]
        public int? PurchaseVendorBillId { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order</para>
        /// <para>Internal: purchase_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: purchase.order</para>
        /// </summary>
        [JsonPropertyName("purchase_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("purchase_id")]
        public int? PurchaseId { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order Count</para>
        /// <para>Internal: purchase_order_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("purchase_order_count")]
        [OdooField("purchase_order_count")]
        public int PurchaseOrderCount { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order Name</para>
        /// <para>Internal: purchase_order_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("purchase_order_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("purchase_order_name")]
        public string PurchaseOrderName { get; set; }

        /// <summary>
        /// <para>Name: Is Purchase Matched</para>
        /// <para>Internal: is_purchase_matched</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_purchase_matched")]
        [OdooField("is_purchase_matched")]
        public bool IsPurchaseMatched { get; set; }

        /// <summary>
        /// <para>Name: Originating Model</para>
        /// <para>Internal: transfer_model_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.transfer.model</para>
        /// </summary>
        [JsonPropertyName("transfer_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("transfer_model_id")]
        public int? TransferModelId { get; set; }

        /// <summary>
        /// <para>Name: PEPPOL message ID</para>
        /// <para>Internal: peppol_message_uuid</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("peppol_message_uuid")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("peppol_message_uuid")]
        public string PeppolMessageUuid { get; set; }

        /// <summary>
        /// <para>Name: PEPPOL status</para>
        /// <para>Internal: peppol_move_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [ready]=Ready to send,[to_send]=Queued,[skipped]=Skipped,[processing]=Pending Reception,[done]=Done,[error]=Error</para>
        /// </summary>
        [JsonPropertyName("peppol_move_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("peppol_move_state")]
        public string PeppolMoveState { get; set; }

        /// <summary>
        /// <para>Name: Tax Closing Report</para>
        /// <para>Internal: tax_closing_report_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.report</para>
        /// </summary>
        [JsonPropertyName("tax_closing_report_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("tax_closing_report_id")]
        public int? TaxClosingReportId { get; set; }

        /// <summary>
        /// <para>Name: Tax Closing Alert</para>
        /// <para>Internal: tax_closing_alert</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("tax_closing_alert")]
        [OdooField("tax_closing_alert")]
        public bool TaxClosingAlert { get; set; }

        /// <summary>
        /// <para>Name: Meeting Booking</para>
        /// <para>Internal: calendar_booking_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: calendar.booking</para>
        /// </summary>
        [JsonPropertyName("calendar_booking_ids")]
        [OdooField("calendar_booking_ids")]
        public List<int> CalendarBookingIds { get; set; }

        /// <summary>
        /// <para>Name: Sales Team</para>
        /// <para>Internal: team_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.team</para>
        /// </summary>
        [JsonPropertyName("team_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("team_id")]
        public int? TeamId { get; set; }

        /// <summary>
        /// <para>Name: Sale Order Count</para>
        /// <para>Internal: sale_order_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sale_order_count")]
        [OdooField("sale_order_count")]
        public int SaleOrderCount { get; set; }

        /// <summary>
        /// <para>Name: Impacting Cash Basis</para>
        /// <para>Internal: impacting_cash_basis</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("impacting_cash_basis")]
        [OdooField("impacting_cash_basis")]
        public bool ImpactingCashBasis { get; set; }

        /// <summary>
        /// <para>Name: Request document from a bank statement line</para>
        /// <para>Internal: suspense_statement_line_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.bank.statement.line</para>
        /// </summary>
        [JsonPropertyName("suspense_statement_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("suspense_statement_line_id")]
        public int? SuspenseStatementLineId { get; set; }

        /// <summary>
        /// <para>Name: Has Documents</para>
        /// <para>Internal: has_documents</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_documents")]
        [OdooField("has_documents")]
        public bool HasDocuments { get; set; }

        /// <summary>
        /// <para>Name: L10N De Datev Main Account</para>
        /// <para>Internal: l10n_de_datev_main_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("l10n_de_datev_main_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("l10n_de_datev_main_account_id")]
        public int? L10nDeDatevMainAccountId { get; set; }

        /// <summary>
        /// <para>Name: Asset</para>
        /// <para>Internal: asset_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
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
        /// <para>Name: Depreciable Value</para>
        /// <para>Internal: asset_remaining_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("asset_remaining_value")]
        [OdooField("asset_remaining_value")]
        public decimal AssetRemainingValue { get; set; }

        /// <summary>
        /// <para>Name: Cumulative Depreciation</para>
        /// <para>Internal: asset_depreciated_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("asset_depreciated_value")]
        [OdooField("asset_depreciated_value")]
        public decimal AssetDepreciatedValue { get; set; }

        /// <summary>
        /// <para>Name: Asset Value Change</para>
        /// <para>Internal: asset_value_change</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("asset_value_change")]
        [OdooField("asset_value_change")]
        public bool AssetValueChange { get; set; }

        /// <summary>
        /// <para>Name: Number of days</para>
        /// <para>Internal: asset_number_days</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("asset_number_days")]
        [OdooField("asset_number_days")]
        public int AssetNumberDays { get; set; }

        /// <summary>
        /// <para>Name: Date of the beginning of the depreciation</para>
        /// <para>Internal: asset_depreciation_beginning_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("asset_depreciation_beginning_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("asset_depreciation_beginning_date")]
        public DateTime? AssetDepreciationBeginningDate { get; set; }

        /// <summary>
        /// <para>Name: Depreciation</para>
        /// <para>Internal: depreciation_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("depreciation_value")]
        [OdooField("depreciation_value")]
        public decimal DepreciationValue { get; set; }

        /// <summary>
        /// <para>Name: Assets</para>
        /// <para>Internal: asset_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.asset</para>
        /// </summary>
        [JsonPropertyName("asset_ids")]
        [OdooField("asset_ids")]
        public List<int> AssetIds { get; set; }

        /// <summary>
        /// <para>Name: Asset Id Display Name</para>
        /// <para>Internal: asset_id_display_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("asset_id_display_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("asset_id_display_name")]
        public string AssetIdDisplayName { get; set; }

        /// <summary>
        /// <para>Name: Count Asset</para>
        /// <para>Internal: count_asset</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("count_asset")]
        [OdooField("count_asset")]
        public int CountAsset { get; set; }

        /// <summary>
        /// <para>Name: Draft Asset Exists</para>
        /// <para>Internal: draft_asset_exists</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("draft_asset_exists")]
        [OdooField("draft_asset_exists")]
        public bool DraftAssetExists { get; set; }

        /// <summary>
        /// <para>Name: Asset Move Type</para>
        /// <para>Internal: asset_move_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [depreciation]=Depreciation,[sale]=Sale,[purchase]=Purchase,[disposal]=Disposal,[negative_revaluation]=Negative revaluation,[positive_revaluation]=Positive revaluation</para>
        /// </summary>
        [JsonPropertyName("asset_move_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("asset_move_type")]
        public string AssetMoveType { get; set; }

        /// <summary>
        /// <para>Name: Extract state</para>
        /// <para>Internal: extract_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no_extract_requested]=No extract requested,[not_enough_credit]=Not enough credits,[error_status]=An error occurred,[waiting_extraction]=Waiting extraction,[extract_not_ready]=waiting extraction, but it is not ready,[waiting_validation]=Waiting validation,[to_validate]=To validate,[done]=Completed flow</para>
        /// </summary>
        [JsonPropertyName("extract_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("extract_state")]
        public string ExtractState { get; set; }

        /// <summary>
        /// <para>Name: Extract status</para>
        /// <para>Internal: extract_status</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("extract_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("extract_status")]
        public string ExtractStatus { get; set; }

        /// <summary>
        /// <para>Name: Error message</para>
        /// <para>Internal: extract_error_message</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("extract_error_message")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("extract_error_message")]
        public string ExtractErrorMessage { get; set; }

        /// <summary>
        /// <para>Name: ID of the request to IAP-OCR</para>
        /// <para>Internal: extract_document_uuid</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("extract_document_uuid")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("extract_document_uuid")]
        public string ExtractDocumentUuid { get; set; }

        /// <summary>
        /// <para>Name: Can show the ocr send button</para>
        /// <para>Internal: extract_can_show_send_button</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("extract_can_show_send_button")]
        [OdooField("extract_can_show_send_button")]
        public bool ExtractCanShowSendButton { get; set; }

        /// <summary>
        /// <para>Name: Is In Extractable State</para>
        /// <para>Internal: is_in_extractable_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_in_extractable_state")]
        [OdooField("is_in_extractable_state")]
        public bool IsInExtractableState { get; set; }

        /// <summary>
        /// <para>Name: Extract State Processed</para>
        /// <para>Internal: extract_state_processed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("extract_state_processed")]
        [OdooField("extract_state_processed")]
        public bool ExtractStateProcessed { get; set; }

        /// <summary>
        /// <para>Name: Extract Attachment</para>
        /// <para>Internal: extract_attachment_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("extract_attachment_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("extract_attachment_id")]
        public int? ExtractAttachmentId { get; set; }

        /// <summary>
        /// <para>Name: Extracted Words</para>
        /// <para>Internal: extracted_word_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: iap.extracted.words</para>
        /// </summary>
        [JsonPropertyName("extracted_word_ids")]
        [OdooField("extracted_word_ids")]
        public List<int> ExtractedWordIds { get; set; }

        /// <summary>
        /// <para>Name: Extract Prefill Data</para>
        /// <para>Internal: extract_prefill_data</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("extract_prefill_data")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("extract_prefill_data")]
        public object ExtractPrefillData { get; set; }

        /// <summary>
        /// <para>Name: Can show the ocr banners</para>
        /// <para>Internal: extract_can_show_banners</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("extract_can_show_banners")]
        [OdooField("extract_can_show_banners")]
        public bool ExtractCanShowBanners { get; set; }

        /// <summary>
        /// <para>Name: Extract Detected Layout Id</para>
        /// <para>Internal: extract_detected_layout</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("extract_detected_layout")]
        [OdooField("extract_detected_layout")]
        public int ExtractDetectedLayout { get; set; }

        /// <summary>
        /// <para>Name: Extract Detected Partner Name</para>
        /// <para>Internal: extract_partner_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("extract_partner_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("extract_partner_name")]
        public string ExtractPartnerName { get; set; }

        /// <summary>
        /// <para>Name: Website</para>
        /// <para>Internal: website_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website</para>
        /// </summary>
        [JsonPropertyName("website_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("website_id")]
        public int? WebsiteId { get; set; }

        /// <summary>
        /// <para>Name: Generating Loan Line</para>
        /// <para>Internal: generating_loan_line_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.loan.line</para>
        /// </summary>
        [JsonPropertyName("generating_loan_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("generating_loan_line_id")]
        public int? GeneratingLoanLineId { get; set; }

        /// <summary>
        /// <para>Name: Loan</para>
        /// <para>Internal: loan_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.loan</para>
        /// </summary>
        [JsonPropertyName("loan_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("loan_id")]
        public int? LoanId { get; set; }

        /// <summary>
        /// <para>Name: Is Loan Payment Move</para>
        /// <para>Internal: is_loan_payment_move</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_loan_payment_move")]
        [OdooField("is_loan_payment_move")]
        public bool IsLoanPaymentMove { get; set; }

    }
}
