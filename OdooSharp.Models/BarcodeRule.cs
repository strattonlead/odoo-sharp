using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("barcode.rule")]
    public partial class BarcodeRule
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
        /// <para>Name: Rule Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: Barcode Nomenclature</para>
        /// <para>Internal: barcode_nomenclature_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: barcode.nomenclature</para>
        /// </summary>
        [JsonPropertyName("barcode_nomenclature_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("barcode_nomenclature_id")]
        public int? BarcodeNomenclatureId { get; set; }

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
        /// <para>Name: Encoding</para>
        /// <para>Internal: encoding</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [any]=Any,[ean13]=EAN-13,[ean8]=EAN-8,[upca]=UPC-A,[gs1-128]=GS1-128</para>
        /// </summary>
        [JsonPropertyName("encoding")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>Name: Type</para>
        /// <para>Internal: type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [alias]=Alias,[product]=Unit Product,[quantity]=Quantity,[location]=Location,[location_dest]=Destination location,[lot]=Lot number,[package]=Package,[use_date]=Best before Date,[expiration_date]=Expiration Date,[package_type]=Package Type,[pack_date]=Pack Date</para>
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("type")]
        public string Type { get; set; }

        /// <summary>
        /// <para>Name: Barcode Pattern</para>
        /// <para>Internal: pattern</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("pattern")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>Name: Alias</para>
        /// <para>Internal: alias</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias")]
        public string Alias { get; set; }

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
        /// <para>Name: Is GS1 Nomenclature</para>
        /// <para>Internal: is_gs1_nomenclature</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_gs1_nomenclature")]
        [OdooField("is_gs1_nomenclature")]
        public bool IsGs1Nomenclature { get; set; }

        /// <summary>
        /// <para>Name: GS1 Content Type</para>
        /// <para>Internal: gs1_content_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [date]=Date,[measure]=Measure,[identifier]=Numeric Identifier,[alpha]=Alpha-Numeric Name</para>
        /// </summary>
        [JsonPropertyName("gs1_content_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("gs1_content_type")]
        public string Gs1ContentType { get; set; }

        /// <summary>
        /// <para>Name: Decimal</para>
        /// <para>Internal: gs1_decimal_usage</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("gs1_decimal_usage")]
        [OdooField("gs1_decimal_usage")]
        public bool Gs1DecimalUsage { get; set; }

        /// <summary>
        /// <para>Name: Associated Uom</para>
        /// <para>Internal: associated_uom_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: uom.uom</para>
        /// </summary>
        [JsonPropertyName("associated_uom_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("associated_uom_id")]
        public int? AssociatedUomId { get; set; }

    }
}
