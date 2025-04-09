using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("purchase.order.line")]
    public partial class PurchaseOrderLine
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
        /// <para>Name: Quantity</para>
        /// <para>Internal: product_qty</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("product_qty")]
        public double ProductQty { get; set; }

        /// <summary>
        /// <para>Name: Total Quantity</para>
        /// <para>Internal: product_uom_qty</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("product_uom_qty")]
        public double ProductUomQty { get; set; }

        /// <summary>
        /// <para>Name: Expected Arrival</para>
        /// <para>Internal: date_planned</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_planned")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? DatePlanned { get; set; }

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
        /// <para>Name: Unit Price (Discounted)</para>
        /// <para>Internal: price_unit_discounted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("price_unit_discounted")]
        public double PriceUnitDiscounted { get; set; }

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
        /// <para>Name: Tax</para>
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
        /// <para>Name: Order Reference</para>
        /// <para>Internal: order_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: purchase.order</para>
        /// </summary>
        [JsonPropertyName("order_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? OrderId { get; set; }

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
        /// <para>Name: Status</para>
        /// <para>Internal: state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Bill Lines</para>
        /// <para>Internal: invoice_lines</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("invoice_lines")]
        public List<int> InvoiceLines { get; set; }

        /// <summary>
        /// <para>Name: Billed Qty</para>
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
        /// <para>Name: Received Qty Method</para>
        /// <para>Internal: qty_received_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("qty_received_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string QtyReceivedMethod { get; set; }

        /// <summary>
        /// <para>Name: Received Qty</para>
        /// <para>Internal: qty_received</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("qty_received")]
        public double QtyReceived { get; set; }

        /// <summary>
        /// <para>Name: Manual Received Qty</para>
        /// <para>Internal: qty_received_manual</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("qty_received_manual")]
        public double QtyReceivedManual { get; set; }

        /// <summary>
        /// <para>Name: To Invoice Quantity</para>
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
        /// <para>Name: Partner</para>
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
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: currency_id</para>
        /// <para>Store: no</para>
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
        /// <para>Name: Order Date</para>
        /// <para>Internal: date_order</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_order")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? DateOrder { get; set; }

        /// <summary>
        /// <para>Name: Confirmation Date</para>
        /// <para>Internal: date_approve</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_approve")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? DateApprove { get; set; }

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
        /// <para>Name: Is Downpayment</para>
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
        /// <para>Name: Product attribute values that do not create variants</para>
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
        /// <para>Name: Sale Order</para>
        /// <para>Internal: sale_order_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sale.order</para>
        /// </summary>
        [JsonPropertyName("sale_order_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SaleOrderId { get; set; }

        /// <summary>
        /// <para>Name: Origin Sale Item</para>
        /// <para>Internal: sale_line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sale.order.line</para>
        /// </summary>
        [JsonPropertyName("sale_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SaleLineId { get; set; }

    }
}
