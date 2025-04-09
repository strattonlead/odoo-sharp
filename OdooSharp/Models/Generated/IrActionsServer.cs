using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("ir.actions.server")]
    public partial class IrActionsServer
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
        /// <para>Name: Action Name</para>
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
        /// <para>Name: Action Type</para>
        /// <para>Internal: type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Type { get; set; }

        /// <summary>
        /// <para>Name: External ID</para>
        /// <para>Internal: xml_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("xml_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string XmlId { get; set; }

        /// <summary>
        /// <para>Name: Path to show in the URL</para>
        /// <para>Internal: path</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("path")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Path { get; set; }

        /// <summary>
        /// <para>Name: Action Description</para>
        /// <para>Internal: help</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("help")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Help { get; set; }

        /// <summary>
        /// <para>Name: Binding Model</para>
        /// <para>Internal: binding_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("binding_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? BindingModelId { get; set; }

        /// <summary>
        /// <para>Name: Binding Type</para>
        /// <para>Internal: binding_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("binding_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string BindingType { get; set; }

        /// <summary>
        /// <para>Name: Binding View Types</para>
        /// <para>Internal: binding_view_types</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("binding_view_types")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string BindingViewTypes { get; set; }

        /// <summary>
        /// <para>Name: Invisible attribute</para>
        /// <para>Internal: binding_invisible</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("binding_invisible")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string BindingInvisible { get; set; }

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
        /// <para>Name: Automated Name</para>
        /// <para>Internal: automated_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("automated_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string AutomatedName { get; set; }

        /// <summary>
        /// <para>Name: Usage</para>
        /// <para>Internal: usage</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("usage")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Usage { get; set; }

        /// <summary>
        /// <para>Name: Type</para>
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
        public int? ModelId { get; set; }

        /// <summary>
        /// <para>Name: Available Models</para>
        /// <para>Internal: available_model_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("available_model_ids")]
        public List<int> AvailableModelIds { get; set; }

        /// <summary>
        /// <para>Name: Model Name</para>
        /// <para>Internal: model_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("model_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Name: Warning</para>
        /// <para>Internal: warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Warning { get; set; }

        /// <summary>
        /// <para>Name: Python Code</para>
        /// <para>Internal: code</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Code { get; set; }

        /// <summary>
        /// <para>Name: Parent Action</para>
        /// <para>Internal: parent_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.actions.server</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ParentId { get; set; }

        /// <summary>
        /// <para>Name: Child Actions</para>
        /// <para>Internal: child_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.actions.server</para>
        /// </summary>
        [JsonPropertyName("child_ids")]
        public List<int> ChildIds { get; set; }

        /// <summary>
        /// <para>Name: Record to Create</para>
        /// <para>Internal: crud_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("crud_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CrudModelId { get; set; }

        /// <summary>
        /// <para>Name: Target Model Name</para>
        /// <para>Internal: crud_model_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("crud_model_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string CrudModelName { get; set; }

        /// <summary>
        /// <para>Name: Link Field</para>
        /// <para>Internal: link_field_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("link_field_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? LinkFieldId { get; set; }

        /// <summary>
        /// <para>Name: Allowed Groups</para>
        /// <para>Internal: group_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.groups</para>
        /// </summary>
        [JsonPropertyName("group_ids")]
        public List<int> GroupIds { get; set; }

        /// <summary>
        /// <para>Name: Field to Update</para>
        /// <para>Internal: update_field_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("update_field_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? UpdateFieldId { get; set; }

        /// <summary>
        /// <para>Name: Field to Update Path</para>
        /// <para>Internal: update_path</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("update_path")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string UpdatePath { get; set; }

        /// <summary>
        /// <para>Name: Update Related Model</para>
        /// <para>Internal: update_related_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("update_related_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? UpdateRelatedModelId { get; set; }

        /// <summary>
        /// <para>Name: Field Type</para>
        /// <para>Internal: update_field_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("update_field_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string UpdateFieldType { get; set; }

        /// <summary>
        /// <para>Name: Many2many Operations</para>
        /// <para>Internal: update_m2m_operation</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("update_m2m_operation")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string UpdateM2mOperation { get; set; }

        /// <summary>
        /// <para>Name: Boolean Value</para>
        /// <para>Internal: update_boolean_value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("update_boolean_value")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string UpdateBooleanValue { get; set; }

        /// <summary>
        /// <para>Name: Value</para>
        /// <para>Internal: value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("value")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Value { get; set; }

        /// <summary>
        /// <para>Name: Value Type</para>
        /// <para>Internal: evaluation_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("evaluation_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string EvaluationType { get; set; }

        /// <summary>
        /// <para>Name: Record</para>
        /// <para>Internal: resource_ref</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Reference</para>
        /// </summary>
        [JsonPropertyName("resource_ref")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ResourceRef { get; set; }

        /// <summary>
        /// <para>Name: Custom Value</para>
        /// <para>Internal: selection_value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields.selection</para>
        /// </summary>
        [JsonPropertyName("selection_value")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SelectionValue { get; set; }

        /// <summary>
        /// <para>Name: Value Field To Show</para>
        /// <para>Internal: value_field_to_show</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("value_field_to_show")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ValueFieldToShow { get; set; }

        /// <summary>
        /// <para>Name: Webhook URL</para>
        /// <para>Internal: webhook_url</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("webhook_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// <para>Name: Webhook Fields</para>
        /// <para>Internal: webhook_field_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("webhook_field_ids")]
        public List<int> WebhookFieldIds { get; set; }

        /// <summary>
        /// <para>Name: Sample Payload</para>
        /// <para>Internal: webhook_sample_payload</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("webhook_sample_payload")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string WebhookSamplePayload { get; set; }

        /// <summary>
        /// <para>Name: Followers Type</para>
        /// <para>Internal: followers_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("followers_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string FollowersType { get; set; }

        /// <summary>
        /// <para>Name: Followers Field</para>
        /// <para>Internal: followers_partner_field_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("followers_partner_field_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string FollowersPartnerFieldName { get; set; }

        /// <summary>
        /// <para>Name: Partner</para>
        /// <para>Internal: partner_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_ids")]
        public List<int> PartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Email Template</para>
        /// <para>Internal: template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.template</para>
        /// </summary>
        [JsonPropertyName("template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? TemplateId { get; set; }

        /// <summary>
        /// <para>Name: Subscribe Recipients</para>
        /// <para>Internal: mail_post_autofollow</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("mail_post_autofollow")]
        public bool MailPostAutofollow { get; set; }

        /// <summary>
        /// <para>Name: Send Email As</para>
        /// <para>Internal: mail_post_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("mail_post_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string MailPostMethod { get; set; }

        /// <summary>
        /// <para>Name: Activity Type</para>
        /// <para>Internal: activity_type_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.activity.type</para>
        /// </summary>
        [JsonPropertyName("activity_type_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ActivityTypeId { get; set; }

        /// <summary>
        /// <para>Name: Title</para>
        /// <para>Internal: activity_summary</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_summary")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ActivitySummary { get; set; }

        /// <summary>
        /// <para>Name: Note</para>
        /// <para>Internal: activity_note</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("activity_note")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ActivityNote { get; set; }

        /// <summary>
        /// <para>Name: Due Date In</para>
        /// <para>Internal: activity_date_deadline_range</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("activity_date_deadline_range")]
        public int ActivityDateDeadlineRange { get; set; }

        /// <summary>
        /// <para>Name: Due type</para>
        /// <para>Internal: activity_date_deadline_range_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("activity_date_deadline_range_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ActivityDateDeadlineRangeType { get; set; }

        /// <summary>
        /// <para>Name: User Type</para>
        /// <para>Internal: activity_user_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("activity_user_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ActivityUserType { get; set; }

        /// <summary>
        /// <para>Name: Responsible</para>
        /// <para>Internal: activity_user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("activity_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ActivityUserId { get; set; }

        /// <summary>
        /// <para>Name: User Field</para>
        /// <para>Internal: activity_user_field_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_user_field_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ActivityUserFieldName { get; set; }

        /// <summary>
        /// <para>Name: SMS Template</para>
        /// <para>Internal: sms_template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sms.template</para>
        /// </summary>
        [JsonPropertyName("sms_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SmsTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Send SMS As</para>
        /// <para>Internal: sms_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("sms_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SmsMethod { get; set; }

        /// <summary>
        /// <para>Name: Automation Rule</para>
        /// <para>Internal: base_automation_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: base.automation</para>
        /// </summary>
        [JsonPropertyName("base_automation_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? BaseAutomationId { get; set; }

        /// <summary>
        /// <para>Name: Website Path</para>
        /// <para>Internal: website_path</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_path")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string WebsitePath { get; set; }

        /// <summary>
        /// <para>Name: Website Url</para>
        /// <para>Internal: website_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// <para>Name: Available on the Website</para>
        /// <para>Internal: website_published</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_published")]
        public bool WebsitePublished { get; set; }

    }
}
