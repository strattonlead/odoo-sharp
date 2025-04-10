using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("helpdesk.sla.report.analysis")]
    public partial class HelpdeskSlaReportAnalysis
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
        /// <para>Name: Ticket</para>
        /// <para>Internal: ticket_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: helpdesk.ticket</para>
        /// </summary>
        [JsonPropertyName("ticket_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("ticket_id")]
        public int? TicketId { get; set; }

        /// <summary>
        /// <para>Name: Description</para>
        /// <para>Internal: description</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("description")]
        public string Description { get; set; }

        /// <summary>
        /// <para>Name: Tags</para>
        /// <para>Internal: tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: helpdesk.tag</para>
        /// </summary>
        [JsonPropertyName("tag_ids")]
        [OdooField("tag_ids")]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// <para>Name: Ticket IDs Sequence</para>
        /// <para>Internal: ticket_ref</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("ticket_ref")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("ticket_ref")]
        public string TicketRef { get; set; }

        /// <summary>
        /// <para>Name: Subject</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Ticket Creation Date</para>
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
        /// <para>Name: Minimum Priority</para>
        /// <para>Internal: priority</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [0]=Low priority,[1]=Medium priority,[2]=High priority,[3]=Urgent</para>
        /// </summary>
        [JsonPropertyName("priority")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// <para>Name: Assigned To</para>
        /// <para>Internal: user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// <para>Name: Customer</para>
        /// <para>Internal: partner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("partner_id")]
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Customer Name</para>
        /// <para>Internal: partner_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// <para>Name: Customer Email</para>
        /// <para>Internal: partner_email</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_email")]
        public string PartnerEmail { get; set; }

        /// <summary>
        /// <para>Name: Customer Phone</para>
        /// <para>Internal: partner_phone</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_phone")]
        public string PartnerPhone { get; set; }

        /// <summary>
        /// <para>Name: Stage</para>
        /// <para>Internal: stage_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: helpdesk.stage</para>
        /// </summary>
        [JsonPropertyName("stage_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("stage_id")]
        public int? StageId { get; set; }

        /// <summary>
        /// <para>Name: Hours Open</para>
        /// <para>Internal: ticket_open_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("ticket_open_hours")]
        [OdooField("ticket_open_hours")]
        public double TicketOpenHours { get; set; }

        /// <summary>
        /// <para>Name: Ticket Closed</para>
        /// <para>Internal: ticket_closed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("ticket_closed")]
        [OdooField("ticket_closed")]
        public bool TicketClosed { get; set; }

        /// <summary>
        /// <para>Name: Working Hours to Close</para>
        /// <para>Internal: ticket_close_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("ticket_close_hours")]
        [OdooField("ticket_close_hours")]
        public int TicketCloseHours { get; set; }

        /// <summary>
        /// <para>Name: Working Hours to Assign</para>
        /// <para>Internal: ticket_assignation_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("ticket_assignation_hours")]
        [OdooField("ticket_assignation_hours")]
        public int TicketAssignationHours { get; set; }

        /// <summary>
        /// <para>Name: Closing Date</para>
        /// <para>Internal: close_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("close_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("close_date")]
        public DateTime? CloseDate { get; set; }

        /// <summary>
        /// <para>Name: SLA</para>
        /// <para>Internal: sla_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: helpdesk.sla</para>
        /// </summary>
        [JsonPropertyName("sla_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sla_id")]
        public int? SlaId { get; set; }

        /// <summary>
        /// <para>Name: SLAs</para>
        /// <para>Internal: sla_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: helpdesk.sla</para>
        /// </summary>
        [JsonPropertyName("sla_ids")]
        [OdooField("sla_ids")]
        public List<int> SlaIds { get; set; }

        /// <summary>
        /// <para>Name: SLA Status</para>
        /// <para>Internal: sla_status_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: helpdesk.sla.status</para>
        /// </summary>
        [JsonPropertyName("sla_status_ids")]
        [OdooField("sla_status_ids")]
        public List<int> SlaStatusIds { get; set; }

        /// <summary>
        /// <para>Name: SLA Stage</para>
        /// <para>Internal: sla_stage_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: helpdesk.stage</para>
        /// </summary>
        [JsonPropertyName("sla_stage_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sla_stage_id")]
        public int? SlaStageId { get; set; }

        /// <summary>
        /// <para>Name: SLA Deadline</para>
        /// <para>Internal: sla_deadline</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("sla_deadline")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("sla_deadline")]
        public DateTime? SlaDeadline { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: sla_status</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [failed]=SLA Failed,[reached]=SLA Success,[ongoing]=SLA in Progress</para>
        /// </summary>
        [JsonPropertyName("sla_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sla_status")]
        public string SlaStatus { get; set; }

        /// <summary>
        /// <para>Name: SLA Status Failed</para>
        /// <para>Internal: sla_fail</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sla_fail")]
        [OdooField("sla_fail")]
        public bool SlaFail { get; set; }

        /// <summary>
        /// <para>Name: SLA Status Success</para>
        /// <para>Internal: sla_success</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sla_success")]
        [OdooField("sla_success")]
        public bool SlaSuccess { get; set; }

        /// <summary>
        /// <para>Name: Working Hours until SLA Deadline</para>
        /// <para>Internal: sla_exceeded_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sla_exceeded_hours")]
        [OdooField("sla_exceeded_hours")]
        public int SlaExceededHours { get; set; }

        /// <summary>
        /// <para>Name: Number of SLAs Failed</para>
        /// <para>Internal: sla_status_failed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sla_status_failed")]
        [OdooField("sla_status_failed")]
        public int SlaStatusFailed { get; set; }

        /// <summary>
        /// <para>Name: Active</para>
        /// <para>Internal: active</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("active")]
        [OdooField("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>Name: Rating (1-5)</para>
        /// <para>Internal: rating_last_value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("rating_last_value")]
        [OdooField("rating_last_value")]
        public double RatingLastValue { get; set; }

        /// <summary>
        /// <para>Name: Average Rating</para>
        /// <para>Internal: rating_avg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("rating_avg")]
        [OdooField("rating_avg")]
        public double RatingAvg { get; set; }

        /// <summary>
        /// <para>Name: Helpdesk Team</para>
        /// <para>Internal: team_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: helpdesk.team</para>
        /// </summary>
        [JsonPropertyName("team_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("team_id")]
        public int? TeamId { get; set; }

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
        /// <para>Name: Is Follower</para>
        /// <para>Internal: message_is_follower</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_is_follower")]
        [OdooField("message_is_follower")]
        public bool MessageIsFollower { get; set; }

        /// <summary>
        /// <para>Name: Kanban State</para>
        /// <para>Internal: kanban_state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [normal]=Grey,[done]=Green,[blocked]=Red</para>
        /// </summary>
        [JsonPropertyName("kanban_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("kanban_state")]
        public string KanbanState { get; set; }

        /// <summary>
        /// <para>Name: Average Hours to Respond</para>
        /// <para>Internal: avg_response_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("avg_response_hours")]
        [OdooField("avg_response_hours")]
        public double AvgResponseHours { get; set; }

        /// <summary>
        /// <para>Name: Hours to First Response</para>
        /// <para>Internal: first_response_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("first_response_hours")]
        [OdooField("first_response_hours")]
        public double FirstResponseHours { get; set; }

        /// <summary>
        /// <para>Name: Ref. Sales Order</para>
        /// <para>Internal: sale_order_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sale.order</para>
        /// </summary>
        [JsonPropertyName("sale_order_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sale_order_id")]
        public int? SaleOrderId { get; set; }

    }
}
