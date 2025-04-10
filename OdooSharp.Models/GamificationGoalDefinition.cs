using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("gamification.goal.definition")]
    public partial class GamificationGoalDefinition
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
        /// <para>Name: Goal Definition</para>
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
        /// <para>Name: Goal Description</para>
        /// <para>Internal: description</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("description")]
        public string Description { get; set; }

        /// <summary>
        /// <para>Name: Monetary Value</para>
        /// <para>Internal: monetary</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("monetary")]
        [OdooField("monetary")]
        public bool Monetary { get; set; }

        /// <summary>
        /// <para>Name: Suffix</para>
        /// <para>Internal: suffix</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("suffix")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// <para>Name: Full Suffix</para>
        /// <para>Internal: full_suffix</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("full_suffix")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("full_suffix")]
        public string FullSuffix { get; set; }

        /// <summary>
        /// <para>Name: Computation Mode</para>
        /// <para>Internal: computation_mode</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [manually]=Recorded manually,[count]=Automatic: number of records,[sum]=Automatic: sum on a field,[python]=Automatic: execute a specific Python code</para>
        /// </summary>
        [JsonPropertyName("computation_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("computation_mode")]
        public string ComputationMode { get; set; }

        /// <summary>
        /// <para>Name: Displayed as</para>
        /// <para>Internal: display_mode</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [progress]=Progressive (using numerical values),[boolean]=Exclusive (done or not-done)</para>
        /// </summary>
        [JsonPropertyName("display_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("display_mode")]
        public string DisplayMode { get; set; }

        /// <summary>
        /// <para>Name: Model</para>
        /// <para>Internal: model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
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
        /// <para>Name: Inherited models</para>
        /// <para>Internal: model_inherited_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("model_inherited_ids")]
        [OdooField("model_inherited_ids")]
        public List<int> ModelInheritedIds { get; set; }

        /// <summary>
        /// <para>Name: Field to Sum</para>
        /// <para>Internal: field_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("field_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("field_id")]
        public int? FieldId { get; set; }

        /// <summary>
        /// <para>Name: Date Field</para>
        /// <para>Internal: field_date_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("field_date_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("field_date_id")]
        public int? FieldDateId { get; set; }

        /// <summary>
        /// <para>Name: Filter Domain</para>
        /// <para>Internal: domain</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Name: Batch Mode</para>
        /// <para>Internal: batch_mode</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("batch_mode")]
        [OdooField("batch_mode")]
        public bool BatchMode { get; set; }

        /// <summary>
        /// <para>Name: Distinctive field for batch user</para>
        /// <para>Internal: batch_distinctive_field</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("batch_distinctive_field")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("batch_distinctive_field")]
        public int? BatchDistinctiveField { get; set; }

        /// <summary>
        /// <para>Name: Evaluated expression for batch mode</para>
        /// <para>Internal: batch_user_expression</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("batch_user_expression")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("batch_user_expression")]
        public string BatchUserExpression { get; set; }

        /// <summary>
        /// <para>Name: Python Code</para>
        /// <para>Internal: compute_code</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("compute_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("compute_code")]
        public string ComputeCode { get; set; }

        /// <summary>
        /// <para>Name: Goal Performance</para>
        /// <para>Internal: condition</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [higher]=The higher the better,[lower]=The lower the better</para>
        /// </summary>
        [JsonPropertyName("condition")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// <para>Name: Action</para>
        /// <para>Internal: action_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.actions.act_window</para>
        /// </summary>
        [JsonPropertyName("action_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("action_id")]
        public int? ActionId { get; set; }

        /// <summary>
        /// <para>Name: ID Field of user</para>
        /// <para>Internal: res_id_field</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("res_id_field")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_id_field")]
        public string ResIdField { get; set; }

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
