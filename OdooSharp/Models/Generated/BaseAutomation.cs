using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("base.automation")]
    public partial class BaseAutomation
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
        /// <para>Name: Automation Rule Name</para>
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
        /// <para>Name: Description</para>
        /// <para>Internal: description</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Description { get; set; }

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
        /// <para>Name: Has Mail Thread</para>
        /// <para>Internal: model_is_mail_thread</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("model_is_mail_thread")]
        public bool ModelIsMailThread { get; set; }

        /// <summary>
        /// <para>Name: Actions</para>
        /// <para>Internal: action_server_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.actions.server</para>
        /// </summary>
        [JsonPropertyName("action_server_ids")]
        public List<int> ActionServerIds { get; set; }

        /// <summary>
        /// <para>Name: Url</para>
        /// <para>Internal: url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Url { get; set; }

        /// <summary>
        /// <para>Name: Webhook UUID</para>
        /// <para>Internal: webhook_uuid</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("webhook_uuid")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string WebhookUuid { get; set; }

        /// <summary>
        /// <para>Name: Record Getter</para>
        /// <para>Internal: record_getter</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("record_getter")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string RecordGetter { get; set; }

        /// <summary>
        /// <para>Name: Log Calls</para>
        /// <para>Internal: log_webhook_calls</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("log_webhook_calls")]
        public bool LogWebhookCalls { get; set; }

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
        /// <para>Name: Trigger</para>
        /// <para>Internal: trigger</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("trigger")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Trigger { get; set; }

        /// <summary>
        /// <para>Name: Trigger Field</para>
        /// <para>Internal: trg_selection_field_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields.selection</para>
        /// </summary>
        [JsonPropertyName("trg_selection_field_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? TrgSelectionFieldId { get; set; }

        /// <summary>
        /// <para>Name: Trigger Field Model</para>
        /// <para>Internal: trg_field_ref_model_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("trg_field_ref_model_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string TrgFieldRefModelName { get; set; }

        /// <summary>
        /// <para>Name: Trigger Reference</para>
        /// <para>Internal: trg_field_ref</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Unknown</para>
        /// </summary>
        [JsonPropertyName("trg_field_ref")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        public object TrgFieldRef { get; set; }

        /// <summary>
        /// <para>Name: Trigger Date</para>
        /// <para>Internal: trg_date_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("trg_date_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? TrgDateId { get; set; }

        /// <summary>
        /// <para>Name: Delay after trigger date</para>
        /// <para>Internal: trg_date_range</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("trg_date_range")]
        public int TrgDateRange { get; set; }

        /// <summary>
        /// <para>Name: Delay type</para>
        /// <para>Internal: trg_date_range_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("trg_date_range_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string TrgDateRangeType { get; set; }

        /// <summary>
        /// <para>Name: Use Calendar</para>
        /// <para>Internal: trg_date_calendar_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: resource.calendar</para>
        /// </summary>
        [JsonPropertyName("trg_date_calendar_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? TrgDateCalendarId { get; set; }

        /// <summary>
        /// <para>Name: Before Update Domain</para>
        /// <para>Internal: filter_pre_domain</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("filter_pre_domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string FilterPreDomain { get; set; }

        /// <summary>
        /// <para>Name: Apply on</para>
        /// <para>Internal: filter_domain</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("filter_domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string FilterDomain { get; set; }

        /// <summary>
        /// <para>Name: Last Run</para>
        /// <para>Internal: last_run</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("last_run")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? LastRun { get; set; }

        /// <summary>
        /// <para>Name: On Change Fields Trigger</para>
        /// <para>Internal: on_change_field_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("on_change_field_ids")]
        public List<int> OnChangeFieldIds { get; set; }

        /// <summary>
        /// <para>Name: Trigger Fields</para>
        /// <para>Internal: trigger_field_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("trigger_field_ids")]
        public List<int> TriggerFieldIds { get; set; }

        /// <summary>
        /// <para>Name: Least Delay Msg</para>
        /// <para>Internal: least_delay_msg</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("least_delay_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string LeastDelayMsg { get; set; }

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

    }
}
