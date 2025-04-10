using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("ir.actions.act_window")]
    public partial class IrActionsActWindow
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
        [OdooField("name")]
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
        [OdooField("type")]
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
        [OdooField("xml_id")]
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
        [OdooField("path")]
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
        [OdooField("help")]
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
        [OdooField("binding_model_id")]
        public int? BindingModelId { get; set; }

        /// <summary>
        /// <para>Name: Binding Type</para>
        /// <para>Internal: binding_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [action]=Action,[report]=Report</para>
        /// </summary>
        [JsonPropertyName("binding_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("binding_type")]
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
        [OdooField("binding_view_types")]
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
        [OdooField("binding_invisible")]
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
        /// <para>Name: View Ref.</para>
        /// <para>Internal: view_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("view_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("view_id")]
        public int? ViewId { get; set; }

        /// <summary>
        /// <para>Name: Domain Value</para>
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
        /// <para>Name: Context Value</para>
        /// <para>Internal: context</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("context")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("context")]
        public string Context { get; set; }

        /// <summary>
        /// <para>Name: Record ID</para>
        /// <para>Internal: res_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("res_id")]
        [OdooField("res_id")]
        public int ResId { get; set; }

        /// <summary>
        /// <para>Name: Destination Model</para>
        /// <para>Internal: res_model</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("res_model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_model")]
        public string ResModel { get; set; }

        /// <summary>
        /// <para>Name: Target Window</para>
        /// <para>Internal: target</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [current]=Current Window,[new]=New Window,[fullscreen]=Full Screen,[main]=Main action of Current Window</para>
        /// </summary>
        [JsonPropertyName("target")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("target")]
        public string Target { get; set; }

        /// <summary>
        /// <para>Name: View Mode</para>
        /// <para>Internal: view_mode</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("view_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("view_mode")]
        public string ViewMode { get; set; }

        /// <summary>
        /// <para>Name: Mobile View Mode</para>
        /// <para>Internal: mobile_view_mode</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("mobile_view_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("mobile_view_mode")]
        public string MobileViewMode { get; set; }

        /// <summary>
        /// <para>Name: Action Usage</para>
        /// <para>Internal: usage</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("usage")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("usage")]
        public string Usage { get; set; }

        /// <summary>
        /// <para>Name: No of Views</para>
        /// <para>Internal: view_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.actions.act_window.view</para>
        /// </summary>
        [JsonPropertyName("view_ids")]
        [OdooField("view_ids")]
        public List<int> ViewIds { get; set; }

        /// <summary>
        /// <para>Name: Views</para>
        /// <para>Internal: views</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("views")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("views")]
        public object Views { get; set; }

        /// <summary>
        /// <para>Name: Limit</para>
        /// <para>Internal: limit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("limit")]
        [OdooField("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// <para>Name: Groups</para>
        /// <para>Internal: group_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.groups</para>
        /// </summary>
        [JsonPropertyName("group_ids")]
        [OdooField("group_ids")]
        public List<int> GroupIds { get; set; }

        /// <summary>
        /// <para>Name: Search View Ref.</para>
        /// <para>Internal: search_view_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("search_view_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("search_view_id")]
        public int? SearchViewId { get; set; }

        /// <summary>
        /// <para>Name: Embedded Action</para>
        /// <para>Internal: embedded_action_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.embedded.actions</para>
        /// </summary>
        [JsonPropertyName("embedded_action_ids")]
        [OdooField("embedded_action_ids")]
        public List<int> EmbeddedActionIds { get; set; }

        /// <summary>
        /// <para>Name: Filter</para>
        /// <para>Internal: filter</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter")]
        [OdooField("filter")]
        public bool Filter { get; set; }

    }
}
