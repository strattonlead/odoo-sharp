using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("crm.activity.report")]
    public partial class CrmActivityReport
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
        /// <para>Name: Completion Date</para>
        /// <para>Internal: date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// <para>Name: Creation Date</para>
        /// <para>Internal: lead_create_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("lead_create_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? LeadCreateDate { get; set; }

        /// <summary>
        /// <para>Name: Conversion Date</para>
        /// <para>Internal: date_conversion</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_conversion")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? DateConversion { get; set; }

        /// <summary>
        /// <para>Name: Expected Closing</para>
        /// <para>Internal: date_deadline</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("date_deadline")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? DateDeadline { get; set; }

        /// <summary>
        /// <para>Name: Closed Date</para>
        /// <para>Internal: date_closed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_closed")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? DateClosed { get; set; }

        /// <summary>
        /// <para>Name: Assigned To</para>
        /// <para>Internal: author_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("author_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? AuthorId { get; set; }

        /// <summary>
        /// <para>Name: Salesperson</para>
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
        public int? UserId { get; set; }

        /// <summary>
        /// <para>Name: Sales Team</para>
        /// <para>Internal: team_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.team</para>
        /// </summary>
        [JsonPropertyName("team_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? TeamId { get; set; }

        /// <summary>
        /// <para>Name: Opportunity</para>
        /// <para>Internal: lead_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.lead</para>
        /// </summary>
        [JsonPropertyName("lead_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? LeadId { get; set; }

        /// <summary>
        /// <para>Name: Activity Description</para>
        /// <para>Internal: body</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("body")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Body { get; set; }

        /// <summary>
        /// <para>Name: Subtype</para>
        /// <para>Internal: subtype_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.message.subtype</para>
        /// </summary>
        [JsonPropertyName("subtype_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SubtypeId { get; set; }

        /// <summary>
        /// <para>Name: Activity Type</para>
        /// <para>Internal: mail_activity_type_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.activity.type</para>
        /// </summary>
        [JsonPropertyName("mail_activity_type_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? MailActivityTypeId { get; set; }

        /// <summary>
        /// <para>Name: Country</para>
        /// <para>Internal: country_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("country_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CountryId { get; set; }

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
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Stage</para>
        /// <para>Internal: stage_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.stage</para>
        /// </summary>
        [JsonPropertyName("stage_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? StageId { get; set; }

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
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Type</para>
        /// <para>Internal: lead_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("lead_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string LeadType { get; set; }

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
        public bool Active { get; set; }

        /// <summary>
        /// <para>Name: Tags</para>
        /// <para>Internal: tag_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: crm.tag</para>
        /// </summary>
        [JsonPropertyName("tag_ids")]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// <para>Name: Is Won</para>
        /// <para>Internal: won_status</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("won_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string WonStatus { get; set; }

    }
}
