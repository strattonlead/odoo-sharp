using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("gamification.goal")]
    public partial class GamificationGoal
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
        /// <para>Internal: definition_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: gamification.goal.definition</para>
        /// </summary>
        [JsonPropertyName("definition_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("definition_id")]
        public int? DefinitionId { get; set; }

        /// <summary>
        /// <para>Name: User</para>
        /// <para>Internal: user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// <para>Name: Related Partner</para>
        /// <para>Internal: user_partner_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("user_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("user_partner_id")]
        public int? UserPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Challenge Line</para>
        /// <para>Internal: line_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: gamification.challenge.line</para>
        /// </summary>
        [JsonPropertyName("line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("line_id")]
        public int? LineId { get; set; }

        /// <summary>
        /// <para>Name: Challenge</para>
        /// <para>Internal: challenge_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: gamification.challenge</para>
        /// </summary>
        [JsonPropertyName("challenge_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("challenge_id")]
        public int? ChallengeId { get; set; }

        /// <summary>
        /// <para>Name: Start Date</para>
        /// <para>Internal: start_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("start_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// <para>Name: End Date</para>
        /// <para>Internal: end_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("end_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("end_date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// <para>Name: To Reach</para>
        /// <para>Internal: target_goal</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("target_goal")]
        [OdooField("target_goal")]
        public double TargetGoal { get; set; }

        /// <summary>
        /// <para>Name: Current Value</para>
        /// <para>Internal: current</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("current")]
        [OdooField("current")]
        public double Current { get; set; }

        /// <summary>
        /// <para>Name: Completeness</para>
        /// <para>Internal: completeness</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("completeness")]
        [OdooField("completeness")]
        public double Completeness { get; set; }

        /// <summary>
        /// <para>Name: State</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [draft]=Draft,[inprogress]=In progress,[reached]=Reached,[failed]=Failed,[canceled]=Cancelled</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: To update</para>
        /// <para>Internal: to_update</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("to_update")]
        [OdooField("to_update")]
        public bool ToUpdate { get; set; }

        /// <summary>
        /// <para>Name: Closed goal</para>
        /// <para>Internal: closed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("closed")]
        [OdooField("closed")]
        public bool Closed { get; set; }

        /// <summary>
        /// <para>Name: Computation Mode</para>
        /// <para>Internal: computation_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
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
        /// <para>Name: Color Index</para>
        /// <para>Internal: color</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("color")]
        [OdooField("color")]
        public int Color { get; set; }

        /// <summary>
        /// <para>Name: Remind delay</para>
        /// <para>Internal: remind_update_delay</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("remind_update_delay")]
        [OdooField("remind_update_delay")]
        public int RemindUpdateDelay { get; set; }

        /// <summary>
        /// <para>Name: Last Update</para>
        /// <para>Internal: last_update</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("last_update")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("last_update")]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// <para>Name: Definition Description</para>
        /// <para>Internal: definition_description</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("definition_description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("definition_description")]
        public string DefinitionDescription { get; set; }

        /// <summary>
        /// <para>Name: Definition Condition</para>
        /// <para>Internal: definition_condition</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [higher]=The higher the better,[lower]=The lower the better</para>
        /// </summary>
        [JsonPropertyName("definition_condition")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("definition_condition")]
        public string DefinitionCondition { get; set; }

        /// <summary>
        /// <para>Name: Suffix</para>
        /// <para>Internal: definition_suffix</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("definition_suffix")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("definition_suffix")]
        public string DefinitionSuffix { get; set; }

        /// <summary>
        /// <para>Name: Display Mode</para>
        /// <para>Internal: definition_display</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [progress]=Progressive (using numerical values),[boolean]=Exclusive (done or not-done)</para>
        /// </summary>
        [JsonPropertyName("definition_display")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("definition_display")]
        public string DefinitionDisplay { get; set; }

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
