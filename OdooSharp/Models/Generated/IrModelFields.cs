using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("ir.model.fields")]
    public partial class IrModelFields
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
        /// <para>Name: Field Name</para>
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
        /// <para>Name: Complete Name</para>
        /// <para>Internal: complete_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("complete_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("complete_name")]
        public string CompleteName { get; set; }

        /// <summary>
        /// <para>Name: Model Name</para>
        /// <para>Internal: model</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("model")]
        public string Model { get; set; }

        /// <summary>
        /// <para>Name: Related Model</para>
        /// <para>Internal: relation</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("relation")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("relation")]
        public string Relation { get; set; }

        /// <summary>
        /// <para>Name: Relation Field</para>
        /// <para>Internal: relation_field</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("relation_field")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("relation_field")]
        public string RelationField { get; set; }

        /// <summary>
        /// <para>Name: Relation field</para>
        /// <para>Internal: relation_field_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("relation_field_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("relation_field_id")]
        public int? RelationFieldId { get; set; }

        /// <summary>
        /// <para>Name: Model</para>
        /// <para>Internal: model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("model_id")]
        public int? ModelId { get; set; }

        /// <summary>
        /// <para>Name: Field Label</para>
        /// <para>Internal: field_description</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("field_description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("field_description")]
        public string FieldDescription { get; set; }

        /// <summary>
        /// <para>Name: Field Help</para>
        /// <para>Internal: help</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("help")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("help")]
        public string Help { get; set; }

        /// <summary>
        /// <para>Name: Field Type</para>
        /// <para>Internal: ttype</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [binary]=binary,[boolean]=boolean,[char]=char,[date]=date,[datetime]=datetime,[float]=float,[html]=html,[integer]=integer,[json]=json,[many2many]=many2many,[many2one]=many2one,[many2one_reference]=many2one_reference,[monetary]=monetary,[one2many]=one2many,[properties]=properties,[properties_definition]=properties_definition,[reference]=reference,[selection]=selection,[text]=text</para>
        /// </summary>
        [JsonPropertyName("ttype")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("ttype")]
        public string Ttype { get; set; }

        /// <summary>
        /// <para>Name: Selection Options (Deprecated)</para>
        /// <para>Internal: selection</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("selection")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("selection")]
        public string Selection { get; set; }

        /// <summary>
        /// <para>Name: Selection Options</para>
        /// <para>Internal: selection_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.model.fields.selection</para>
        /// </summary>
        [JsonPropertyName("selection_ids")]
        [OdooField("selection_ids")]
        public List<int> SelectionIds { get; set; }

        /// <summary>
        /// <para>Name: Copied</para>
        /// <para>Internal: copied</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("copied")]
        [OdooField("copied")]
        public bool Copied { get; set; }

        /// <summary>
        /// <para>Name: Related Field Definition</para>
        /// <para>Internal: related</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("related")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("related")]
        public string Related { get; set; }

        /// <summary>
        /// <para>Name: Related Field</para>
        /// <para>Internal: related_field_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("related_field_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("related_field_id")]
        public int? RelatedFieldId { get; set; }

        /// <summary>
        /// <para>Name: Required</para>
        /// <para>Internal: required</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("required")]
        [OdooField("required")]
        public bool Required { get; set; }

        /// <summary>
        /// <para>Name: Readonly</para>
        /// <para>Internal: readonly</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("readonly")]
        [OdooField("readonly")]
        public bool Readonly { get; set; }

        /// <summary>
        /// <para>Name: Indexed</para>
        /// <para>Internal: index</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("index")]
        [OdooField("index")]
        public bool Index { get; set; }

        /// <summary>
        /// <para>Name: Translatable</para>
        /// <para>Internal: translate</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("translate")]
        [OdooField("translate")]
        public bool Translate { get; set; }

        /// <summary>
        /// <para>Name: Company Dependent</para>
        /// <para>Internal: company_dependent</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("company_dependent")]
        [OdooField("company_dependent")]
        public bool CompanyDependent { get; set; }

        /// <summary>
        /// <para>Name: Size</para>
        /// <para>Internal: size</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("size")]
        [OdooField("size")]
        public int Size { get; set; }

        /// <summary>
        /// <para>Name: Type</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [manual]=Custom Field,[base]=Base Field</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: On Delete</para>
        /// <para>Internal: on_delete</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [cascade]=Cascade,[set null]=Set NULL,[restrict]=Restrict</para>
        /// </summary>
        [JsonPropertyName("on_delete")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("on_delete")]
        public string OnDelete { get; set; }

        /// <summary>
        /// <para>Name: Domain</para>
        /// <para>Internal: domain</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Name: Groups</para>
        /// <para>Internal: groups</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.groups</para>
        /// </summary>
        [JsonPropertyName("groups")]
        [OdooField("groups")]
        public List<int> Groups { get; set; }

        /// <summary>
        /// <para>Name: Expand Groups</para>
        /// <para>Internal: group_expand</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_expand")]
        [OdooField("group_expand")]
        public bool GroupExpand { get; set; }

        /// <summary>
        /// <para>Name: Selectable</para>
        /// <para>Internal: selectable</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("selectable")]
        [OdooField("selectable")]
        public bool Selectable { get; set; }

        /// <summary>
        /// <para>Name: In Apps</para>
        /// <para>Internal: modules</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("modules")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("modules")]
        public string Modules { get; set; }

        /// <summary>
        /// <para>Name: Relation Table</para>
        /// <para>Internal: relation_table</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("relation_table")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("relation_table")]
        public string RelationTable { get; set; }

        /// <summary>
        /// <para>Name: Column 1</para>
        /// <para>Internal: column1</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("column1")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("column1")]
        public string Column1 { get; set; }

        /// <summary>
        /// <para>Name: Column 2</para>
        /// <para>Internal: column2</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("column2")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("column2")]
        public string Column2 { get; set; }

        /// <summary>
        /// <para>Name: Compute</para>
        /// <para>Internal: compute</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("compute")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("compute")]
        public string Compute { get; set; }

        /// <summary>
        /// <para>Name: Dependencies</para>
        /// <para>Internal: depends</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("depends")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("depends")]
        public string Depends { get; set; }

        /// <summary>
        /// <para>Name: Stored</para>
        /// <para>Internal: store</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("store")]
        [OdooField("store")]
        public bool Store { get; set; }

        /// <summary>
        /// <para>Name: Currency field</para>
        /// <para>Internal: currency_field</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("currency_field")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("currency_field")]
        public string CurrencyField { get; set; }

        /// <summary>
        /// <para>Name: Sanitize HTML</para>
        /// <para>Internal: sanitize</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sanitize")]
        [OdooField("sanitize")]
        public bool Sanitize { get; set; }

        /// <summary>
        /// <para>Name: Sanitize HTML overridable</para>
        /// <para>Internal: sanitize_overridable</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sanitize_overridable")]
        [OdooField("sanitize_overridable")]
        public bool SanitizeOverridable { get; set; }

        /// <summary>
        /// <para>Name: Sanitize HTML Tags</para>
        /// <para>Internal: sanitize_tags</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sanitize_tags")]
        [OdooField("sanitize_tags")]
        public bool SanitizeTags { get; set; }

        /// <summary>
        /// <para>Name: Sanitize HTML Attributes</para>
        /// <para>Internal: sanitize_attributes</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sanitize_attributes")]
        [OdooField("sanitize_attributes")]
        public bool SanitizeAttributes { get; set; }

        /// <summary>
        /// <para>Name: Sanitize HTML Style</para>
        /// <para>Internal: sanitize_style</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sanitize_style")]
        [OdooField("sanitize_style")]
        public bool SanitizeStyle { get; set; }

        /// <summary>
        /// <para>Name: Sanitize HTML Form</para>
        /// <para>Internal: sanitize_form</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sanitize_form")]
        [OdooField("sanitize_form")]
        public bool SanitizeForm { get; set; }

        /// <summary>
        /// <para>Name: Strip Style Attribute</para>
        /// <para>Internal: strip_style</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("strip_style")]
        [OdooField("strip_style")]
        public bool StripStyle { get; set; }

        /// <summary>
        /// <para>Name: Strip Class Attribute</para>
        /// <para>Internal: strip_classes</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("strip_classes")]
        [OdooField("strip_classes")]
        public bool StripClasses { get; set; }

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
        /// <para>Name: Enable Ordered Tracking</para>
        /// <para>Internal: tracking</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("tracking")]
        [OdooField("tracking")]
        public int Tracking { get; set; }

        /// <summary>
        /// <para>Name: Blacklisted in web forms</para>
        /// <para>Internal: website_form_blacklisted</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_form_blacklisted")]
        [OdooField("website_form_blacklisted")]
        public bool WebsiteFormBlacklisted { get; set; }

    }
}
