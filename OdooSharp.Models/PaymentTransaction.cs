using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("payment.transaction")]
    public partial class PaymentTransaction
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
        /// <para>Name: Provider</para>
        /// <para>Internal: provider_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: payment.provider</para>
        /// </summary>
        [JsonPropertyName("provider_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("provider_id")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// <para>Name: Provider Code</para>
        /// <para>Internal: provider_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [none]=No Provider Set</para>
        /// </summary>
        [JsonPropertyName("provider_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("provider_code")]
        public string ProviderCode { get; set; }

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
        /// <para>Name: Payment Method</para>
        /// <para>Internal: payment_method_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: payment.method</para>
        /// </summary>
        [JsonPropertyName("payment_method_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("payment_method_id")]
        public int? PaymentMethodId { get; set; }

        /// <summary>
        /// <para>Name: Payment Method Code</para>
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

        /// <summary>
        /// <para>Name: Reference</para>
        /// <para>Internal: reference</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("reference")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// <para>Name: Provider Reference</para>
        /// <para>Internal: provider_reference</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("provider_reference")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("provider_reference")]
        public string ProviderReference { get; set; }

        /// <summary>
        /// <para>Name: Amount</para>
        /// <para>Internal: amount</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount")]
        [OdooField("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: currency_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
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
        /// <para>Name: Payment Token</para>
        /// <para>Internal: token_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: payment.token</para>
        /// </summary>
        [JsonPropertyName("token_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("token_id")]
        public int? TokenId { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [draft]=Draft,[pending]=Pending,[authorized]=Authorized,[done]=Confirmed,[cancel]=Canceled,[error]=Error</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Message</para>
        /// <para>Internal: state_message</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("state_message")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state_message")]
        public string StateMessage { get; set; }

        /// <summary>
        /// <para>Name: Last State Change Date</para>
        /// <para>Internal: last_state_change</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("last_state_change")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("last_state_change")]
        public DateTime? LastStateChange { get; set; }

        /// <summary>
        /// <para>Name: Operation</para>
        /// <para>Internal: operation</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [online_redirect]=Online payment with redirection,[online_direct]=Online direct payment,[online_token]=Online payment by token,[validation]=Validation of the payment method,[offline]=Offline payment by token,[refund]=Refund</para>
        /// </summary>
        [JsonPropertyName("operation")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// <para>Name: Source Transaction</para>
        /// <para>Internal: source_transaction_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: payment.transaction</para>
        /// </summary>
        [JsonPropertyName("source_transaction_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("source_transaction_id")]
        public int? SourceTransactionId { get; set; }

        /// <summary>
        /// <para>Name: Child Transactions</para>
        /// <para>Internal: child_transaction_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: payment.transaction</para>
        /// </summary>
        [JsonPropertyName("child_transaction_ids")]
        [OdooField("child_transaction_ids")]
        public List<int> ChildTransactionIds { get; set; }

        /// <summary>
        /// <para>Name: Refunds Count</para>
        /// <para>Internal: refunds_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("refunds_count")]
        [OdooField("refunds_count")]
        public int RefundsCount { get; set; }

        /// <summary>
        /// <para>Name: Is Post-processed</para>
        /// <para>Internal: is_post_processed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_post_processed")]
        [OdooField("is_post_processed")]
        public bool IsPostProcessed { get; set; }

        /// <summary>
        /// <para>Name: Create Token</para>
        /// <para>Internal: tokenize</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("tokenize")]
        [OdooField("tokenize")]
        public bool Tokenize { get; set; }

        /// <summary>
        /// <para>Name: Landing Route</para>
        /// <para>Internal: landing_route</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("landing_route")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("landing_route")]
        public string LandingRoute { get; set; }

        /// <summary>
        /// <para>Name: Customer</para>
        /// <para>Internal: partner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
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
        /// <para>Name: Language</para>
        /// <para>Internal: partner_lang</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [de_DE]=German / Deutsch</para>
        /// </summary>
        [JsonPropertyName("partner_lang")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_lang")]
        public string PartnerLang { get; set; }

        /// <summary>
        /// <para>Name: Email</para>
        /// <para>Internal: partner_email</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_email")]
        public string PartnerEmail { get; set; }

        /// <summary>
        /// <para>Name: Address</para>
        /// <para>Internal: partner_address</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_address")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_address")]
        public string PartnerAddress { get; set; }

        /// <summary>
        /// <para>Name: Zip</para>
        /// <para>Internal: partner_zip</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_zip")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_zip")]
        public string PartnerZip { get; set; }

        /// <summary>
        /// <para>Name: City</para>
        /// <para>Internal: partner_city</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_city")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_city")]
        public string PartnerCity { get; set; }

        /// <summary>
        /// <para>Name: State</para>
        /// <para>Internal: partner_state_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country.state</para>
        /// </summary>
        [JsonPropertyName("partner_state_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("partner_state_id")]
        public int? PartnerStateId { get; set; }

        /// <summary>
        /// <para>Name: Country</para>
        /// <para>Internal: partner_country_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("partner_country_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("partner_country_id")]
        public int? PartnerCountryId { get; set; }

        /// <summary>
        /// <para>Name: Phone</para>
        /// <para>Internal: partner_phone</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_phone")]
        public string PartnerPhone { get; set; }

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
        /// <para>Name: Payment</para>
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
        /// <para>Name: Invoices</para>
        /// <para>Internal: invoice_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("invoice_ids")]
        [OdooField("invoice_ids")]
        public List<int> InvoiceIds { get; set; }

        /// <summary>
        /// <para>Name: Invoices Count</para>
        /// <para>Internal: invoices_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("invoices_count")]
        [OdooField("invoices_count")]
        public int InvoicesCount { get; set; }

        /// <summary>
        /// <para>Name: Sales Orders</para>
        /// <para>Internal: sale_order_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: sale.order</para>
        /// </summary>
        [JsonPropertyName("sale_order_ids")]
        [OdooField("sale_order_ids")]
        public List<int> SaleOrderIds { get; set; }

        /// <summary>
        /// <para>Name: # of Sales Orders</para>
        /// <para>Internal: sale_order_ids_nbr</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sale_order_ids_nbr")]
        [OdooField("sale_order_ids_nbr")]
        public int SaleOrderIdsNbr { get; set; }

        /// <summary>
        /// <para>Name: Is donation</para>
        /// <para>Internal: is_donation</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_donation")]
        [OdooField("is_donation")]
        public bool IsDonation { get; set; }

    }
}
