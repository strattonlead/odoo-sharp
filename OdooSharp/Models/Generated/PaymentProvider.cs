using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("payment.provider")]
    public partial class PaymentProvider
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
        /// <para>Name: Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Name { get; set; }

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
        public int Sequence { get; set; }

        /// <summary>
        /// <para>Name: Code</para>
        /// <para>Internal: code</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Code { get; set; }

        /// <summary>
        /// <para>Name: State</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Published</para>
        /// <para>Internal: is_published</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_published")]
        public bool IsPublished { get; set; }

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
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: main_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("main_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? MainCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Supported Payment Methods</para>
        /// <para>Internal: payment_method_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: payment.method</para>
        /// </summary>
        [JsonPropertyName("payment_method_ids")]
        public List<int> PaymentMethodIds { get; set; }

        /// <summary>
        /// <para>Name: Allow Saving Payment Methods</para>
        /// <para>Internal: allow_tokenization</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("allow_tokenization")]
        public bool AllowTokenization { get; set; }

        /// <summary>
        /// <para>Name: Capture Amount Manually</para>
        /// <para>Internal: capture_manually</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("capture_manually")]
        public bool CaptureManually { get; set; }

        /// <summary>
        /// <para>Name: Allow Express Checkout</para>
        /// <para>Internal: allow_express_checkout</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("allow_express_checkout")]
        public bool AllowExpressCheckout { get; set; }

        /// <summary>
        /// <para>Name: Redirect Form Template</para>
        /// <para>Internal: redirect_form_view_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("redirect_form_view_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? RedirectFormViewId { get; set; }

        /// <summary>
        /// <para>Name: Inline Form Template</para>
        /// <para>Internal: inline_form_view_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("inline_form_view_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? InlineFormViewId { get; set; }

        /// <summary>
        /// <para>Name: Token Inline Form Template</para>
        /// <para>Internal: token_inline_form_view_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("token_inline_form_view_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? TokenInlineFormViewId { get; set; }

        /// <summary>
        /// <para>Name: Express Checkout Form Template</para>
        /// <para>Internal: express_checkout_form_view_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("express_checkout_form_view_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ExpressCheckoutFormViewId { get; set; }

        /// <summary>
        /// <para>Name: Countries</para>
        /// <para>Internal: available_country_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("available_country_ids")]
        public List<int> AvailableCountryIds { get; set; }

        /// <summary>
        /// <para>Name: Currencies</para>
        /// <para>Internal: available_currency_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("available_currency_ids")]
        public List<int> AvailableCurrencyIds { get; set; }

        /// <summary>
        /// <para>Name: Maximum Amount</para>
        /// <para>Internal: maximum_amount</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("maximum_amount")]
        public decimal MaximumAmount { get; set; }

        /// <summary>
        /// <para>Name: Help Message</para>
        /// <para>Internal: pre_msg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("pre_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string PreMsg { get; set; }

        /// <summary>
        /// <para>Name: Pending Message</para>
        /// <para>Internal: pending_msg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("pending_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string PendingMsg { get; set; }

        /// <summary>
        /// <para>Name: Authorize Message</para>
        /// <para>Internal: auth_msg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("auth_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string AuthMsg { get; set; }

        /// <summary>
        /// <para>Name: Done Message</para>
        /// <para>Internal: done_msg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("done_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string DoneMsg { get; set; }

        /// <summary>
        /// <para>Name: Cancelled Message</para>
        /// <para>Internal: cancel_msg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("cancel_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string CancelMsg { get; set; }

        /// <summary>
        /// <para>Name: Tokenization</para>
        /// <para>Internal: support_tokenization</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("support_tokenization")]
        public bool SupportTokenization { get; set; }

        /// <summary>
        /// <para>Name: Manual Capture Supported</para>
        /// <para>Internal: support_manual_capture</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("support_manual_capture")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SupportManualCapture { get; set; }

        /// <summary>
        /// <para>Name: Express Checkout</para>
        /// <para>Internal: support_express_checkout</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("support_express_checkout")]
        public bool SupportExpressCheckout { get; set; }

        /// <summary>
        /// <para>Name: Refund</para>
        /// <para>Internal: support_refund</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("support_refund")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SupportRefund { get; set; }

        /// <summary>
        /// <para>Name: Image</para>
        /// <para>Internal: image_128</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_128")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        public byte[] Image128 { get; set; }

        /// <summary>
        /// <para>Name: Color</para>
        /// <para>Internal: color</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("color")]
        public int Color { get; set; }

        /// <summary>
        /// <para>Name: Corresponding Module</para>
        /// <para>Internal: module_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.module.module</para>
        /// </summary>
        [JsonPropertyName("module_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ModuleId { get; set; }

        /// <summary>
        /// <para>Name: Installation State</para>
        /// <para>Internal: module_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("module_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ModuleState { get; set; }

        /// <summary>
        /// <para>Name: Odoo Enterprise Module</para>
        /// <para>Internal: module_to_buy</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_to_buy")]
        public bool ModuleToBuy { get; set; }

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

        /// <summary>
        /// <para>Name: Payment Journal</para>
        /// <para>Internal: journal_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? JournalId { get; set; }

        /// <summary>
        /// <para>Name: Communication</para>
        /// <para>Internal: so_reference_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("so_reference_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SoReferenceType { get; set; }

        /// <summary>
        /// <para>Name: Website</para>
        /// <para>Internal: website_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website</para>
        /// </summary>
        [JsonPropertyName("website_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? WebsiteId { get; set; }

    }
}
