using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("product.pricelist.item")]
    public partial class ProductPricelistItem
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
        /// <para>Name: Pricelist</para>
        /// <para>Internal: pricelist_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.pricelist</para>
        /// </summary>
        [JsonPropertyName("pricelist_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("pricelist_id")]
        public int? PricelistId { get; set; }

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
        [OdooField("currency_id")]
        public int? CurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Start Date</para>
        /// <para>Internal: date_start</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_start")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date_start")]
        public DateTime? DateStart { get; set; }

        /// <summary>
        /// <para>Name: End Date</para>
        /// <para>Internal: date_end</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_end")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date_end")]
        public DateTime? DateEnd { get; set; }

        /// <summary>
        /// <para>Name: Min. Quantity</para>
        /// <para>Internal: min_quantity</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("min_quantity")]
        [OdooField("min_quantity")]
        public double MinQuantity { get; set; }

        /// <summary>
        /// <para>Name: Apply On</para>
        /// <para>Internal: applied_on</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [3_global]=All Products,[2_product_category]=Product Category,[1_product]=Product,[0_product_variant]=Product Variant</para>
        /// </summary>
        [JsonPropertyName("applied_on")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("applied_on")]
        public string AppliedOn { get; set; }

        /// <summary>
        /// <para>Name: Display Applied On</para>
        /// <para>Internal: display_applied_on</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [1_product]=Product,[2_product_category]=Category</para>
        /// </summary>
        [JsonPropertyName("display_applied_on")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("display_applied_on")]
        public string DisplayAppliedOn { get; set; }

        /// <summary>
        /// <para>Name: Category</para>
        /// <para>Internal: categ_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.category</para>
        /// </summary>
        [JsonPropertyName("categ_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("categ_id")]
        public int? CategId { get; set; }

        /// <summary>
        /// <para>Name: Product</para>
        /// <para>Internal: product_tmpl_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.template</para>
        /// </summary>
        [JsonPropertyName("product_tmpl_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("product_tmpl_id")]
        public int? ProductTmplId { get; set; }

        /// <summary>
        /// <para>Name: Variant</para>
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
        [OdooField("product_id")]
        public int? ProductId { get; set; }

        /// <summary>
        /// <para>Name: Unit Name</para>
        /// <para>Internal: product_uom_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("product_uom_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("product_uom_name")]
        public string ProductUomName { get; set; }

        /// <summary>
        /// <para>Name: # Product Variants</para>
        /// <para>Internal: product_variant_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("product_variant_count")]
        [OdooField("product_variant_count")]
        public int ProductVariantCount { get; set; }

        /// <summary>
        /// <para>Name: Based on</para>
        /// <para>Internal: base</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [list_price]=Sales Price,[standard_price]=Cost,[pricelist]=Other Pricelist</para>
        /// </summary>
        [JsonPropertyName("base")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("base")]
        public string Base { get; set; }

        /// <summary>
        /// <para>Name: Other Pricelist</para>
        /// <para>Internal: base_pricelist_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.pricelist</para>
        /// </summary>
        [JsonPropertyName("base_pricelist_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("base_pricelist_id")]
        public int? BasePricelistId { get; set; }

        /// <summary>
        /// <para>Name: Compute Price</para>
        /// <para>Internal: compute_price</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [percentage]=Discount,[formula]=Formula,[fixed]=Fixed Price</para>
        /// </summary>
        [JsonPropertyName("compute_price")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("compute_price")]
        public string ComputePrice { get; set; }

        /// <summary>
        /// <para>Name: Fixed Price</para>
        /// <para>Internal: fixed_price</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("fixed_price")]
        [OdooField("fixed_price")]
        public double FixedPrice { get; set; }

        /// <summary>
        /// <para>Name: Percentage Price</para>
        /// <para>Internal: percent_price</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("percent_price")]
        [OdooField("percent_price")]
        public double PercentPrice { get; set; }

        /// <summary>
        /// <para>Name: Price Discount</para>
        /// <para>Internal: price_discount</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("price_discount")]
        [OdooField("price_discount")]
        public double PriceDiscount { get; set; }

        /// <summary>
        /// <para>Name: Price Rounding</para>
        /// <para>Internal: price_round</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("price_round")]
        [OdooField("price_round")]
        public double PriceRound { get; set; }

        /// <summary>
        /// <para>Name: Extra Fee</para>
        /// <para>Internal: price_surcharge</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("price_surcharge")]
        [OdooField("price_surcharge")]
        public double PriceSurcharge { get; set; }

        /// <summary>
        /// <para>Name: Markup</para>
        /// <para>Internal: price_markup</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("price_markup")]
        [OdooField("price_markup")]
        public double PriceMarkup { get; set; }

        /// <summary>
        /// <para>Name: Min. Price Margin</para>
        /// <para>Internal: price_min_margin</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("price_min_margin")]
        [OdooField("price_min_margin")]
        public double PriceMinMargin { get; set; }

        /// <summary>
        /// <para>Name: Max. Price Margin</para>
        /// <para>Internal: price_max_margin</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("price_max_margin")]
        [OdooField("price_max_margin")]
        public double PriceMaxMargin { get; set; }

        /// <summary>
        /// <para>Name: Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: Price</para>
        /// <para>Internal: price</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("price")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("price")]
        public string Price { get; set; }

        /// <summary>
        /// <para>Name: Rule Tip</para>
        /// <para>Internal: rule_tip</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("rule_tip")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("rule_tip")]
        public string RuleTip { get; set; }

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
