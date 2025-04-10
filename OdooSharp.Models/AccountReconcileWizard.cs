using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.reconcile.wizard")]
    public partial class AccountReconcileWizard
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
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
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
        /// <para>Name: Move lines to reconcile</para>
        /// <para>Internal: move_line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("move_line_ids")]
        [OdooField("move_line_ids")]
        public List<int> MoveLineIds { get; set; }

        /// <summary>
        /// <para>Name: Reconcile Account</para>
        /// <para>Internal: reco_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("reco_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("reco_account_id")]
        public int? RecoAccountId { get; set; }

        /// <summary>
        /// <para>Name: Amount in company currency</para>
        /// <para>Internal: amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount")]
        [OdooField("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// <para>Name: Company currency</para>
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
        /// <para>Name: Amount</para>
        /// <para>Internal: amount_currency</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_currency")]
        [OdooField("amount_currency")]
        public decimal AmountCurrency { get; set; }

        /// <summary>
        /// <para>Name: Currency to use for reconciliation</para>
        /// <para>Internal: reco_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("reco_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("reco_currency_id")]
        public int? RecoCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Edit Mode Amount</para>
        /// <para>Internal: edit_mode_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("edit_mode_amount")]
        [OdooField("edit_mode_amount")]
        public decimal EditModeAmount { get; set; }

        /// <summary>
        /// <para>Name: Edit mode amount</para>
        /// <para>Internal: edit_mode_amount_currency</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("edit_mode_amount_currency")]
        [OdooField("edit_mode_amount_currency")]
        public decimal EditModeAmountCurrency { get; set; }

        /// <summary>
        /// <para>Name: Edit Mode Reco Currency</para>
        /// <para>Internal: edit_mode_reco_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("edit_mode_reco_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("edit_mode_reco_currency_id")]
        public int? EditModeRecoCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Edit Mode</para>
        /// <para>Internal: edit_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("edit_mode")]
        [OdooField("edit_mode")]
        public bool EditMode { get; set; }

        /// <summary>
        /// <para>Name: Single Currency Mode</para>
        /// <para>Internal: single_currency_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("single_currency_mode")]
        [OdooField("single_currency_mode")]
        public bool SingleCurrencyMode { get; set; }

        /// <summary>
        /// <para>Name: Allow partials</para>
        /// <para>Internal: allow_partials</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("allow_partials")]
        [OdooField("allow_partials")]
        public bool AllowPartials { get; set; }

        /// <summary>
        /// <para>Name: Force Partials</para>
        /// <para>Internal: force_partials</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("force_partials")]
        [OdooField("force_partials")]
        public bool ForcePartials { get; set; }

        /// <summary>
        /// <para>Name: Display Allow Partials</para>
        /// <para>Internal: display_allow_partials</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_allow_partials")]
        [OdooField("display_allow_partials")]
        public bool DisplayAllowPartials { get; set; }

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
        /// <para>Name: Is Rec Pay Account</para>
        /// <para>Internal: is_rec_pay_account</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_rec_pay_account")]
        [OdooField("is_rec_pay_account")]
        public bool IsRecPayAccount { get; set; }

        /// <summary>
        /// <para>Name: Partner</para>
        /// <para>Internal: to_partner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("to_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("to_partner_id")]
        public int? ToPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Label</para>
        /// <para>Internal: label</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("label")]
        public string Label { get; set; }

        /// <summary>
        /// <para>Name: Tax</para>
        /// <para>Internal: tax_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("tax_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("tax_id")]
        public int? TaxId { get; set; }

        /// <summary>
        /// <para>Name: To Check</para>
        /// <para>Internal: to_check</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("to_check")]
        [OdooField("to_check")]
        public bool ToCheck { get; set; }

        /// <summary>
        /// <para>Name: Is a write-off move required to reconcile</para>
        /// <para>Internal: is_write_off_required</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_write_off_required")]
        [OdooField("is_write_off_required")]
        public bool IsWriteOffRequired { get; set; }

        /// <summary>
        /// <para>Name: Is an account transfer required</para>
        /// <para>Internal: is_transfer_required</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_transfer_required")]
        [OdooField("is_transfer_required")]
        public bool IsTransferRequired { get; set; }

        /// <summary>
        /// <para>Name: Is an account transfer required to reconcile</para>
        /// <para>Internal: transfer_warning_message</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("transfer_warning_message")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("transfer_warning_message")]
        public string TransferWarningMessage { get; set; }

        /// <summary>
        /// <para>Name: Account Transfer From</para>
        /// <para>Internal: transfer_from_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("transfer_from_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("transfer_from_account_id")]
        public int? TransferFromAccountId { get; set; }

        /// <summary>
        /// <para>Name: Is the date violating the lock date of moves</para>
        /// <para>Internal: lock_date_violated_warning_message</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("lock_date_violated_warning_message")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("lock_date_violated_warning_message")]
        public string LockDateViolatedWarningMessage { get; set; }

        /// <summary>
        /// <para>Name: Reconciliation model</para>
        /// <para>Internal: reco_model_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.reconcile.model</para>
        /// </summary>
        [JsonPropertyName("reco_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("reco_model_id")]
        public int? RecoModelId { get; set; }

        /// <summary>
        /// <para>Name: All reconciliation models</para>
        /// <para>Internal: reco_model_autocomplete_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.reconcile.model</para>
        /// </summary>
        [JsonPropertyName("reco_model_autocomplete_ids")]
        [OdooField("reco_model_autocomplete_ids")]
        public List<int> RecoModelAutocompleteIds { get; set; }

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
