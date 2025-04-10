using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("mail.activity.schedule")]
    public partial class MailActivitySchedule
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
        /// <para>Name: Applies to</para>
        /// <para>Internal: res_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("res_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("res_model_id")]
        public int? ResModelId { get; set; }

        /// <summary>
        /// <para>Name: Model</para>
        /// <para>Internal: res_model</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("res_model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_model")]
        public string ResModel { get; set; }

        /// <summary>
        /// <para>Name: Document IDs</para>
        /// <para>Internal: res_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("res_ids")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_ids")]
        public string ResIds { get; set; }

        /// <summary>
        /// <para>Name: Use in batch</para>
        /// <para>Internal: is_batch_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_batch_mode")]
        [OdooField("is_batch_mode")]
        public bool IsBatchMode { get; set; }

        /// <summary>
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
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
        /// <para>Name: Error</para>
        /// <para>Internal: error</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("error")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("error")]
        public string Error { get; set; }

        /// <summary>
        /// <para>Name: Has Error</para>
        /// <para>Internal: has_error</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_error")]
        [OdooField("has_error")]
        public bool HasError { get; set; }

        /// <summary>
        /// <para>Name: Plan Available</para>
        /// <para>Internal: plan_available_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: mail.activity.plan</para>
        /// </summary>
        [JsonPropertyName("plan_available_ids")]
        [OdooField("plan_available_ids")]
        public List<int> PlanAvailableIds { get; set; }

        /// <summary>
        /// <para>Name: Plan</para>
        /// <para>Internal: plan_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.activity.plan</para>
        /// </summary>
        [JsonPropertyName("plan_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("plan_id")]
        public int? PlanId { get; set; }

        /// <summary>
        /// <para>Name: Has on demand responsible</para>
        /// <para>Internal: plan_has_user_on_demand</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("plan_has_user_on_demand")]
        [OdooField("plan_has_user_on_demand")]
        public bool PlanHasUserOnDemand { get; set; }

        /// <summary>
        /// <para>Name: Plan Summary</para>
        /// <para>Internal: plan_summary</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("plan_summary")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("plan_summary")]
        public string PlanSummary { get; set; }

        /// <summary>
        /// <para>Name: Assigned To</para>
        /// <para>Internal: plan_on_demand_user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("plan_on_demand_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("plan_on_demand_user_id")]
        public int? PlanOnDemandUserId { get; set; }

        /// <summary>
        /// <para>Name: Plan Date</para>
        /// <para>Internal: plan_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("plan_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("plan_date")]
        public DateTime? PlanDate { get; set; }

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
        [OdooField("activity_type_id")]
        public int? ActivityTypeId { get; set; }

        /// <summary>
        /// <para>Name: Action</para>
        /// <para>Internal: activity_category</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [default]=None,[upload_file]=Upload Document,[phonecall]=Phonecall,[meeting]=Meeting,[sign_request]=Request Signature,[grant_approval]=Grant Approval,[tax_report]=Tax report</para>
        /// </summary>
        [JsonPropertyName("activity_category")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_category")]
        public string ActivityCategory { get; set; }

        /// <summary>
        /// <para>Name: Due Date</para>
        /// <para>Internal: date_deadline</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("date_deadline")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date_deadline")]
        public DateTime? DateDeadline { get; set; }

        /// <summary>
        /// <para>Name: Summary</para>
        /// <para>Internal: summary</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("summary")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// <para>Name: Note</para>
        /// <para>Internal: note</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("note")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("note")]
        public string Note { get; set; }

        /// <summary>
        /// <para>Name: Assigned to</para>
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
        [OdooField("activity_user_id")]
        public int? ActivityUserId { get; set; }

        /// <summary>
        /// <para>Name: Chaining Type</para>
        /// <para>Internal: chaining_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [suggest]=Suggest Next Activity,[trigger]=Trigger Next Activity</para>
        /// </summary>
        [JsonPropertyName("chaining_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("chaining_type")]
        public string ChainingType { get; set; }

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
        /// <para>Name: Department</para>
        /// <para>Internal: department_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.department</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("department_id")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// <para>Name: Plan Department Filterable</para>
        /// <para>Internal: plan_department_filterable</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("plan_department_filterable")]
        [OdooField("plan_department_filterable")]
        public bool PlanDepartmentFilterable { get; set; }

    }
}
