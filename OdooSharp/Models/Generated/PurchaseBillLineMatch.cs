using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("purchase.bill.line.match")]
    public partial class PurchaseBillLineMatch
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
        /// <para>Name: Pol</para>
        /// <para>Internal: pol_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: purchase.order.line</para>
        /// </summary>
        [JsonPropertyName("pol_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? PolId { get; set; }

        /// <summary>
        /// <para>Name: Aml</para>
        /// <para>Internal: aml_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("aml_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? AmlId { get; set; }

        /// <summary>
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CompanyId { get; set; }

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
        public int? PartnerId { get; set; }

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
        /// <para>Name: Line Qty</para>
        /// <para>Internal: line_qty</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("line_qty")]
        public double LineQty { get; set; }

        /// <summary>
        /// <para>Name: Line Uom</para>
        /// <para>Internal: line_uom_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: uom.uom</para>
        /// </summary>
        [JsonPropertyName("line_uom_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? LineUomId { get; set; }

        /// <summary>
        /// <para>Name: Qty Invoiced</para>
        /// <para>Internal: qty_invoiced</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("qty_invoiced")]
        public double QtyInvoiced { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order</para>
        /// <para>Internal: purchase_order_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: purchase.order</para>
        /// </summary>
        [JsonPropertyName("purchase_order_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? PurchaseOrderId { get; set; }

        /// <summary>
        /// <para>Name: Account Move</para>
        /// <para>Internal: account_move_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("account_move_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? AccountMoveId { get; set; }

        /// <summary>
        /// <para>Name: Line Amount Untaxed</para>
        /// <para>Internal: line_amount_untaxed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("line_amount_untaxed")]
        public decimal LineAmountUntaxed { get; set; }

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
        public int? CurrencyId { get; set; }

        /// <summary>
        /// <para>Name: State</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Unit</para>
        /// <para>Internal: product_uom_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: uom.uom</para>
        /// </summary>
        [JsonPropertyName("product_uom_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ProductUomId { get; set; }

        /// <summary>
        /// <para>Name: Product Uom Qty</para>
        /// <para>Internal: product_uom_qty</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("product_uom_qty")]
        public double ProductUomQty { get; set; }

        /// <summary>
        /// <para>Name: Product Uom Price</para>
        /// <para>Internal: product_uom_price</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("product_uom_price")]
        public double ProductUomPrice { get; set; }

        /// <summary>
        /// <para>Name: Billed Amount Untaxed</para>
        /// <para>Internal: billed_amount_untaxed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("billed_amount_untaxed")]
        public decimal BilledAmountUntaxed { get; set; }

        /// <summary>
        /// <para>Name: Purchase Amount Untaxed</para>
        /// <para>Internal: purchase_amount_untaxed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("purchase_amount_untaxed")]
        public decimal PurchaseAmountUntaxed { get; set; }

        /// <summary>
        /// <para>Name: Reference</para>
        /// <para>Internal: reference</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("reference")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Reference { get; set; }

    }
}
