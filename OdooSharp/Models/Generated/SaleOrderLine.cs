using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("sale.order.line")]
    public partial class SaleOrderLine
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
        /// <para>Name: Order Reference</para>
        /// <para>Internal: order_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sale.order</para>
        /// </summary>
        [JsonPropertyName("order_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? OrderId { get; set; }

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
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
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
        public int? CurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Customer</para>
        /// <para>Internal: order_partner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("order_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? OrderPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Salesperson</para>
        /// <para>Internal: salesman_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("salesman_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SalesmanId { get; set; }

        /// <summary>
        /// <para>Name: Order Status</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string State { get; set; }

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
        public int? TaxCountryId { get; set; }

        /// <summary>
        /// <para>Name: Display Type</para>
        /// <para>Internal: display_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("display_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string DisplayType { get; set; }

        /// <summary>
        /// <para>Name: Is the product configurable?</para>
        /// <para>Internal: is_configurable_product</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_configurable_product")]
        public bool IsConfigurableProduct { get; set; }

        /// <summary>
        /// <para>Name: Is a down payment</para>
        /// <para>Internal: is_downpayment</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_downpayment")]
        public bool IsDownpayment { get; set; }

        /// <summary>
        /// <para>Name: Is expense</para>
        /// <para>Internal: is_expense</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_expense")]
        public bool IsExpense { get; set; }

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
        public int? ProductId { get; set; }

        /// <summary>
        /// <para>Name: Product Template</para>
        /// <para>Internal: product_template_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.template</para>
        /// </summary>
        [JsonPropertyName("product_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ProductTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Attribute Values</para>
        /// <para>Internal: product_template_attribute_value_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.template.attribute.value</para>
        /// </summary>
        [JsonPropertyName("product_template_attribute_value_ids")]
        public List<int> ProductTemplateAttributeValueIds { get; set; }

        /// <summary>
        /// <para>Name: Custom Values</para>
        /// <para>Internal: product_custom_attribute_value_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: product.attribute.custom.value</para>
        /// </summary>
        [JsonPropertyName("product_custom_attribute_value_ids")]
        public List<int> ProductCustomAttributeValueIds { get; set; }

        /// <summary>
        /// <para>Name: Extra Values</para>
        /// <para>Internal: product_no_variant_attribute_value_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.template.attribute.value</para>
        /// </summary>
        [JsonPropertyName("product_no_variant_attribute_value_ids")]
        public List<int> ProductNoVariantAttributeValueIds { get; set; }

        /// <summary>
        /// <para>Name: Is Product Archived</para>
        /// <para>Internal: is_product_archived</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_product_archived")]
        public bool IsProductArchived { get; set; }

        /// <summary>
        /// <para>Name: Description</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: Quantity</para>
        /// <para>Internal: product_uom_qty</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("product_uom_qty")]
        public double ProductUomQty { get; set; }

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
        public int? ProductUomId { get; set; }

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
        public List<int> AllowedUomIds { get; set; }

        /// <summary>
        /// <para>Name: Linked Order Line</para>
        /// <para>Internal: linked_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sale.order.line</para>
        /// </summary>
        [JsonPropertyName("linked_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? LinkedLineId { get; set; }

        /// <summary>
        /// <para>Name: Linked Order Lines</para>
        /// <para>Internal: linked_line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: sale.order.line</para>
        /// </summary>
        [JsonPropertyName("linked_line_ids")]
        public List<int> LinkedLineIds { get; set; }

        /// <summary>
        /// <para>Name: Virtual</para>
        /// <para>Internal: virtual_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("virtual_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string VirtualId { get; set; }

        /// <summary>
        /// <para>Name: Linked Virtual</para>
        /// <para>Internal: linked_virtual_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("linked_virtual_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string LinkedVirtualId { get; set; }

        /// <summary>
        /// <para>Name: Selected Combo Items</para>
        /// <para>Internal: selected_combo_items</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("selected_combo_items")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SelectedComboItems { get; set; }

        /// <summary>
        /// <para>Name: Combo Item</para>
        /// <para>Internal: combo_item_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.combo.item</para>
        /// </summary>
        [JsonPropertyName("combo_item_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ComboItemId { get; set; }

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
        public List<int> TaxIds { get; set; }

        /// <summary>
        /// <para>Name: Pricelist Item</para>
        /// <para>Internal: pricelist_item_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.pricelist.item</para>
        /// </summary>
        [JsonPropertyName("pricelist_item_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? PricelistItemId { get; set; }

        /// <summary>
        /// <para>Name: Unit Price</para>
        /// <para>Internal: price_unit</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("price_unit")]
        public double PriceUnit { get; set; }

        /// <summary>
        /// <para>Name: Technical Price Unit</para>
        /// <para>Internal: technical_price_unit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("technical_price_unit")]
        public double TechnicalPriceUnit { get; set; }

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
        public double Discount { get; set; }

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
        public decimal PriceSubtotal { get; set; }

        /// <summary>
        /// <para>Name: Total Tax</para>
        /// <para>Internal: price_tax</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("price_tax")]
        public double PriceTax { get; set; }

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
        public decimal PriceTotal { get; set; }

        /// <summary>
        /// <para>Name: Price Reduce Tax excl</para>
        /// <para>Internal: price_reduce_taxexcl</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("price_reduce_taxexcl")]
        public decimal PriceReduceTaxexcl { get; set; }

        /// <summary>
        /// <para>Name: Price Reduce Tax incl</para>
        /// <para>Internal: price_reduce_taxinc</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("price_reduce_taxinc")]
        public decimal PriceReduceTaxinc { get; set; }

        /// <summary>
        /// <para>Name: Lead Time</para>
        /// <para>Internal: customer_lead</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("customer_lead")]
        public double CustomerLead { get; set; }

        /// <summary>
        /// <para>Name: Method to update delivered qty</para>
        /// <para>Internal: qty_delivered_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("qty_delivered_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string QtyDeliveredMethod { get; set; }

        /// <summary>
        /// <para>Name: Delivery Quantity</para>
        /// <para>Internal: qty_delivered</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("qty_delivered")]
        public double QtyDelivered { get; set; }

        /// <summary>
        /// <para>Name: Invoiced Quantity</para>
        /// <para>Internal: qty_invoiced</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("qty_invoiced")]
        public double QtyInvoiced { get; set; }

        /// <summary>
        /// <para>Name: Invoiced Quantity (posted)</para>
        /// <para>Internal: qty_invoiced_posted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("qty_invoiced_posted")]
        public double QtyInvoicedPosted { get; set; }

        /// <summary>
        /// <para>Name: Quantity To Invoice</para>
        /// <para>Internal: qty_to_invoice</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("qty_to_invoice")]
        public double QtyToInvoice { get; set; }

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
        public List<int> AnalyticLineIds { get; set; }

        /// <summary>
        /// <para>Name: Invoice Lines</para>
        /// <para>Internal: invoice_lines</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("invoice_lines")]
        public List<int> InvoiceLines { get; set; }

        /// <summary>
        /// <para>Name: Invoice Status</para>
        /// <para>Internal: invoice_status</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("invoice_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// <para>Name: Untaxed Invoiced Amount</para>
        /// <para>Internal: untaxed_amount_invoiced</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("untaxed_amount_invoiced")]
        public decimal UntaxedAmountInvoiced { get; set; }

        /// <summary>
        /// <para>Name: Invoiced Amount</para>
        /// <para>Internal: amount_invoiced</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_invoiced")]
        public decimal AmountInvoiced { get; set; }

        /// <summary>
        /// <para>Name: Untaxed Amount To Invoice</para>
        /// <para>Internal: untaxed_amount_to_invoice</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("untaxed_amount_to_invoice")]
        public decimal UntaxedAmountToInvoice { get; set; }

        /// <summary>
        /// <para>Name: Un-invoiced Balance</para>
        /// <para>Internal: amount_to_invoice</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("amount_to_invoice")]
        public decimal AmountToInvoice { get; set; }

        /// <summary>
        /// <para>Name: Product Type</para>
        /// <para>Internal: product_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("product_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>Name: Create on Order</para>
        /// <para>Internal: service_tracking</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("service_tracking")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ServiceTracking { get; set; }

        /// <summary>
        /// <para>Name: Can Edit Product</para>
        /// <para>Internal: product_updatable</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("product_updatable")]
        public bool ProductUpdatable { get; set; }

        /// <summary>
        /// <para>Name: Product Uom Readonly</para>
        /// <para>Internal: product_uom_readonly</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("product_uom_readonly")]
        public bool ProductUomReadonly { get; set; }

        /// <summary>
        /// <para>Name: Tax calculation rounding method</para>
        /// <para>Internal: tax_calculation_rounding_method</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("tax_calculation_rounding_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string TaxCalculationRoundingMethod { get; set; }

        /// <summary>
        /// <para>Name: Default Sales Price Include</para>
        /// <para>Internal: company_price_include</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("company_price_include")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string CompanyPriceInclude { get; set; }

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
        /// <para>Name: Is a Delivery</para>
        /// <para>Internal: is_delivery</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_delivery")]
        public bool IsDelivery { get; set; }

        /// <summary>
        /// <para>Name: Product Qty</para>
        /// <para>Internal: product_qty</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("product_qty")]
        public double ProductQty { get; set; }

        /// <summary>
        /// <para>Name: Delivery cost should be recomputed</para>
        /// <para>Internal: recompute_delivery_price</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("recompute_delivery_price")]
        public bool RecomputeDeliveryPrice { get; set; }

        /// <summary>
        /// <para>Name: Optional Products Lines</para>
        /// <para>Internal: sale_order_option_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: sale.order.option</para>
        /// </summary>
        [JsonPropertyName("sale_order_option_ids")]
        public List<int> SaleOrderOptionIds { get; set; }

        /// <summary>
        /// <para>Name: Generated Purchase Lines</para>
        /// <para>Internal: purchase_line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: purchase.order.line</para>
        /// </summary>
        [JsonPropertyName("purchase_line_ids")]
        public List<int> PurchaseLineIds { get; set; }

        /// <summary>
        /// <para>Name: Number of generated purchase items</para>
        /// <para>Internal: purchase_line_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("purchase_line_count")]
        public int PurchaseLineCount { get; set; }

        /// <summary>
        /// <para>Name: Available Product Documents</para>
        /// <para>Internal: available_product_document_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.document</para>
        /// </summary>
        [JsonPropertyName("available_product_document_ids")]
        public List<int> AvailableProductDocumentIds { get; set; }

        /// <summary>
        /// <para>Name: Product Documents</para>
        /// <para>Internal: product_document_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.document</para>
        /// </summary>
        [JsonPropertyName("product_document_ids")]
        public List<int> ProductDocumentIds { get; set; }

        /// <summary>
        /// <para>Name: Is a Service</para>
        /// <para>Internal: is_service</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_service")]
        public bool IsService { get; set; }

        /// <summary>
        /// <para>Name: Name Short</para>
        /// <para>Internal: name_short</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name_short")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string NameShort { get; set; }

        /// <summary>
        /// <para>Name: Warning</para>
        /// <para>Internal: shop_warning</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("shop_warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ShopWarning { get; set; }

        /// <summary>
        /// <para>Name: Bookings</para>
        /// <para>Internal: calendar_booking_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: calendar.booking</para>
        /// </summary>
        [JsonPropertyName("calendar_booking_ids")]
        public List<int> CalendarBookingIds { get; set; }

        /// <summary>
        /// <para>Name: Meeting</para>
        /// <para>Internal: calendar_event_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: calendar.event</para>
        /// </summary>
        [JsonPropertyName("calendar_event_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CalendarEventId { get; set; }

    }
}
