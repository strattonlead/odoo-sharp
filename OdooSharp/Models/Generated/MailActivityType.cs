using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("mail.activity.type")]
    public partial class MailActivityType
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
        /// <para>Name: Default Summary</para>
        /// <para>Internal: summary</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("summary")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Summary { get; set; }

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
        /// <para>Name: Active</para>
        /// <para>Internal: active</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>Name: Create Uid</para>
        /// <para>Internal: create_uid</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("create_uid")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CreateUid { get; set; }

        /// <summary>
        /// <para>Name: Schedule</para>
        /// <para>Internal: delay_count</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("delay_count")]
        public int DelayCount { get; set; }

        /// <summary>
        /// <para>Name: Delay units</para>
        /// <para>Internal: delay_unit</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("delay_unit")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string DelayUnit { get; set; }

        /// <summary>
        /// <para>Name: Delay Label</para>
        /// <para>Internal: delay_label</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("delay_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string DelayLabel { get; set; }

        /// <summary>
        /// <para>Name: Delay Type</para>
        /// <para>Internal: delay_from</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("delay_from")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string DelayFrom { get; set; }

        /// <summary>
        /// <para>Name: Icon</para>
        /// <para>Internal: icon</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("icon")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Icon { get; set; }

        /// <summary>
        /// <para>Name: Decoration Type</para>
        /// <para>Internal: decoration_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("decoration_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string DecorationType { get; set; }

        /// <summary>
        /// <para>Name: Model</para>
        /// <para>Internal: res_model</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("res_model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ResModel { get; set; }

        /// <summary>
        /// <para>Name: Trigger</para>
        /// <para>Internal: triggered_next_type_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.activity.type</para>
        /// </summary>
        [JsonPropertyName("triggered_next_type_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? TriggeredNextTypeId { get; set; }

        /// <summary>
        /// <para>Name: Chaining Type</para>
        /// <para>Internal: chaining_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("chaining_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ChainingType { get; set; }

        /// <summary>
        /// <para>Name: Suggest</para>
        /// <para>Internal: suggested_next_type_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: mail.activity.type</para>
        /// </summary>
        [JsonPropertyName("suggested_next_type_ids")]
        public List<int> SuggestedNextTypeIds { get; set; }

        /// <summary>
        /// <para>Name: Preceding Activities</para>
        /// <para>Internal: previous_type_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: mail.activity.type</para>
        /// </summary>
        [JsonPropertyName("previous_type_ids")]
        public List<int> PreviousTypeIds { get; set; }

        /// <summary>
        /// <para>Name: Action</para>
        /// <para>Internal: category</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("category")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Category { get; set; }

        /// <summary>
        /// <para>Name: Email templates</para>
        /// <para>Internal: mail_template_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: mail.template</para>
        /// </summary>
        [JsonPropertyName("mail_template_ids")]
        public List<int> MailTemplateIds { get; set; }

        /// <summary>
        /// <para>Name: Default User</para>
        /// <para>Internal: default_user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("default_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? DefaultUserId { get; set; }

        /// <summary>
        /// <para>Name: Default Note</para>
        /// <para>Internal: default_note</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("default_note")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string DefaultNote { get; set; }

        /// <summary>
        /// <para>Name: Keep Done</para>
        /// <para>Internal: keep_done</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("keep_done")]
        public bool KeepDone { get; set; }

        /// <summary>
        /// <para>Name: Initial model</para>
        /// <para>Internal: initial_res_model</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("initial_res_model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string InitialResModel { get; set; }

        /// <summary>
        /// <para>Name: Model has change</para>
        /// <para>Internal: res_model_change</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("res_model_change")]
        public bool ResModelChange { get; set; }

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
        /// <para>Name: Dashboard Visibility</para>
        /// <para>Internal: dashboard_visibility</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("dashboard_visibility")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string DashboardVisibility { get; set; }

        /// <summary>
        /// <para>Name: Default Signature Template</para>
        /// <para>Internal: default_sign_template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sign.template</para>
        /// </summary>
        [JsonPropertyName("default_sign_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? DefaultSignTemplateId { get; set; }

    }
}
