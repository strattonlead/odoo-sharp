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
        public string ExceptionNeededFields { get; set; }

        /// <summary>
        /// <para>Name: Exception applies</para>
        /// <para>Internal: exception_applies_to</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("exception_applies_to")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ExceptionAppliesTo { get; set; }

        /// <summary>
        /// <para>Name: Exception Duration</para>
        /// <para>Internal: exception_duration</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("exception_duration")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public DateTime? WriteDate { get; set; }

    }
}
