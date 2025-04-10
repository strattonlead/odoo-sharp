using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.change.lock.date")]
    public partial class AccountChangeLockDate
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Lock Everything</para>
        /// <para>Internal: fiscalyear_lock_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("fiscalyear_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("fiscalyear_lock_date")]
        public DateTime? FiscalyearLockDate { get; set; }

        /// <summary>
        /// <para>Name: Lock Everything For Me</para>
        /// <para>Internal: fiscalyear_lock_date_for_me</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("fiscalyear_lock_date_for_me")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("fiscalyear_lock_date_for_me")]
        public DateTime? FiscalyearLockDateForMe { get; set; }

        /// <summary>
        /// <para>Name: Lock Everything For Everyone</para>
        /// <para>Internal: fiscalyear_lock_date_for_everyone</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("fiscalyear_lock_date_for_everyone")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("fiscalyear_lock_date_for_everyone")]
        public DateTime? FiscalyearLockDateForEveryone { get; set; }

        /// <summary>
        /// <para>Name: Min Fiscalyear Lock Date Exception For Me</para>
        /// <para>Internal: min_fiscalyear_lock_date_exception_for_me_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.lock_exception</para>
        /// </summary>
        [JsonPropertyName("min_fiscalyear_lock_date_exception_for_me_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("min_fiscalyear_lock_date_exception_for_me_id")]
        public int? MinFiscalyearLockDateExceptionForMeId { get; set; }

        /// <summary>
        /// <para>Name: Min Fiscalyear Lock Date Exception For Everyone</para>
        /// <para>Internal: min_fiscalyear_lock_date_exception_for_everyone_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.lock_exception</para>
        /// </summary>
        [JsonPropertyName("min_fiscalyear_lock_date_exception_for_everyone_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("min_fiscalyear_lock_date_exception_for_everyone_id")]
        public int? MinFiscalyearLockDateExceptionForEveryoneId { get; set; }

        /// <summary>
        /// <para>Name: Lock Tax Return</para>
        /// <para>Internal: tax_lock_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("tax_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("tax_lock_date")]
        public DateTime? TaxLockDate { get; set; }

        /// <summary>
        /// <para>Name: Lock Tax Return For Me</para>
        /// <para>Internal: tax_lock_date_for_me</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("tax_lock_date_for_me")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("tax_lock_date_for_me")]
        public DateTime? TaxLockDateForMe { get; set; }

        /// <summary>
        /// <para>Name: Lock Tax Return For Everyone</para>
        /// <para>Internal: tax_lock_date_for_everyone</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("tax_lock_date_for_everyone")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("tax_lock_date_for_everyone")]
        public DateTime? TaxLockDateForEveryone { get; set; }

        /// <summary>
        /// <para>Name: Min Tax Lock Date Exception For Me</para>
        /// <para>Internal: min_tax_lock_date_exception_for_me_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.lock_exception</para>
        /// </summary>
        [JsonPropertyName("min_tax_lock_date_exception_for_me_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("min_tax_lock_date_exception_for_me_id")]
        public int? MinTaxLockDateExceptionForMeId { get; set; }

        /// <summary>
        /// <para>Name: Min Tax Lock Date Exception For Everyone</para>
        /// <para>Internal: min_tax_lock_date_exception_for_everyone_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.lock_exception</para>
        /// </summary>
        [JsonPropertyName("min_tax_lock_date_exception_for_everyone_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("min_tax_lock_date_exception_for_everyone_id")]
        public int? MinTaxLockDateExceptionForEveryoneId { get; set; }

        /// <summary>
        /// <para>Name: Lock Sales</para>
        /// <para>Internal: sale_lock_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("sale_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("sale_lock_date")]
        public DateTime? SaleLockDate { get; set; }

        /// <summary>
        /// <para>Name: Lock Sales For Me</para>
        /// <para>Internal: sale_lock_date_for_me</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("sale_lock_date_for_me")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("sale_lock_date_for_me")]
        public DateTime? SaleLockDateForMe { get; set; }

        /// <summary>
        /// <para>Name: Lock Sales For Everyone</para>
        /// <para>Internal: sale_lock_date_for_everyone</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("sale_lock_date_for_everyone")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("sale_lock_date_for_everyone")]
        public DateTime? SaleLockDateForEveryone { get; set; }

        /// <summary>
        /// <para>Name: Min Sale Lock Date Exception For Me</para>
        /// <para>Internal: min_sale_lock_date_exception_for_me_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.lock_exception</para>
        /// </summary>
        [JsonPropertyName("min_sale_lock_date_exception_for_me_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("min_sale_lock_date_exception_for_me_id")]
        public int? MinSaleLockDateExceptionForMeId { get; set; }

        /// <summary>
        /// <para>Name: Min Sale Lock Date Exception For Everyone</para>
        /// <para>Internal: min_sale_lock_date_exception_for_everyone_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.lock_exception</para>
        /// </summary>
        [JsonPropertyName("min_sale_lock_date_exception_for_everyone_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("min_sale_lock_date_exception_for_everyone_id")]
        public int? MinSaleLockDateExceptionForEveryoneId { get; set; }

        /// <summary>
        /// <para>Name: Lock Purchases</para>
        /// <para>Internal: purchase_lock_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("purchase_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("purchase_lock_date")]
        public DateTime? PurchaseLockDate { get; set; }

        /// <summary>
        /// <para>Name: Lock Purchases For Me</para>
        /// <para>Internal: purchase_lock_date_for_me</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("purchase_lock_date_for_me")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("purchase_lock_date_for_me")]
        public DateTime? PurchaseLockDateForMe { get; set; }

        /// <summary>
        /// <para>Name: Lock Purchases For Everyone</para>
        /// <para>Internal: purchase_lock_date_for_everyone</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("purchase_lock_date_for_everyone")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("purchase_lock_date_for_everyone")]
        public DateTime? PurchaseLockDateForEveryone { get; set; }

        /// <summary>
        /// <para>Name: Min Purchase Lock Date Exception For Me</para>
        /// <para>Internal: min_purchase_lock_date_exception_for_me_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.lock_exception</para>
        /// </summary>
        [JsonPropertyName("min_purchase_lock_date_exception_for_me_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("min_purchase_lock_date_exception_for_me_id")]
        public int? MinPurchaseLockDateExceptionForMeId { get; set; }

        /// <summary>
        /// <para>Name: Min Purchase Lock Date Exception For Everyone</para>
        /// <para>Internal: min_purchase_lock_date_exception_for_everyone_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.lock_exception</para>
        /// </summary>
        [JsonPropertyName("min_purchase_lock_date_exception_for_everyone_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("min_purchase_lock_date_exception_for_everyone_id")]
        public int? MinPurchaseLockDateExceptionForEveryoneId { get; set; }

        /// <summary>
        /// <para>Name: Hard Lock</para>
        /// <para>Internal: hard_lock_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("hard_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("hard_lock_date")]
        public DateTime? HardLockDate { get; set; }

        /// <summary>
        /// <para>Name: Current Hard Lock</para>
        /// <para>Internal: current_hard_lock_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("current_hard_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("current_hard_lock_date")]
        public DateTime? CurrentHardLockDate { get; set; }

        /// <summary>
        /// <para>Name: Exception Needed Fields</para>
        /// <para>Internal: exception_needed_fields</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("exception_needed_fields")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("exception_needed_fields")]
        public string ExceptionNeededFields { get; set; }

        /// <summary>
        /// <para>Name: Exception applies</para>
        /// <para>Internal: exception_applies_to</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [me]=for me,[everyone]=for everyone</para>
        /// </summary>
        [JsonPropertyName("exception_applies_to")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("exception_applies_to")]
        public string ExceptionAppliesTo { get; set; }

        /// <summary>
        /// <para>Name: Exception Duration</para>
        /// <para>Internal: exception_duration</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [5min]=for 5 minutes,[15min]=for 15 minutes,[1h]=for 1 hour,[24h]=for 24 hours,[forever]=forever</para>
        /// </summary>
        [JsonPropertyName("exception_duration")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("exception_duration")]
        public string ExceptionDuration { get; set; }

        /// <summary>
        /// <para>Name: Exception Reason</para>
        /// <para>Internal: exception_reason</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("exception_reason")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("exception_reason")]
        public string ExceptionReason { get; set; }

        /// <summary>
        /// <para>Name: Show Draft Entries Warning</para>
        /// <para>Internal: show_draft_entries_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_draft_entries_warning")]
        [OdooField("show_draft_entries_warning")]
        public bool ShowDraftEntriesWarning { get; set; }

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
