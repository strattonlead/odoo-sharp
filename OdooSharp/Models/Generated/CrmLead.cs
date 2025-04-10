using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("crm.lead")]
    public partial class CrmLead
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
        /// <para>Name: Status time</para>
        /// <para>Internal: duration_tracking</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("duration_tracking")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("duration_tracking")]
        public object DurationTracking { get; set; }

        /// <summary>
        /// <para>Name: Campaign</para>
        /// <para>Internal: campaign_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: utm.campaign</para>
        /// </summary>
        [JsonPropertyName("campaign_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("campaign_id")]
        public int? CampaignId { get; set; }

        /// <summary>
        /// <para>Name: Source</para>
        /// <para>Internal: source_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: utm.source</para>
        /// </summary>
        [JsonPropertyName("source_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("source_id")]
        public int? SourceId { get; set; }

        /// <summary>
        /// <para>Name: Medium</para>
        /// <para>Internal: medium_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: utm.medium</para>
        /// </summary>
        [JsonPropertyName("medium_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("medium_id")]
        public int? MediumId { get; set; }

        /// <summary>
        /// <para>Name: Activities</para>
        /// <para>Internal: activity_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.activity</para>
        /// </summary>
        [JsonPropertyName("activity_ids")]
        [OdooField("activity_ids")]
        public List<int> ActivityIds { get; set; }

        /// <summary>
        /// <para>Name: Activity State</para>
        /// <para>Internal: activity_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [overdue]=Overdue,[today]=Today,[planned]=Planned</para>
        /// </summary>
        [JsonPropertyName("activity_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_state")]
        public string ActivityState { get; set; }

        /// <summary>
        /// <para>Name: Responsible User</para>
        /// <para>Internal: activity_user_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("activity_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("activity_user_id")]
        public int? ActivityUserId { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Type</para>
        /// <para>Internal: activity_type_id</para>
        /// <para>Store: no</para>
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
        /// <para>Name: Activity Type Icon</para>
        /// <para>Internal: activity_type_icon</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_type_icon")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_type_icon")]
        public string ActivityTypeIcon { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Deadline</para>
        /// <para>Internal: activity_date_deadline</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("activity_date_deadline")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("activity_date_deadline")]
        public DateTime? ActivityDateDeadline { get; set; }

        /// <summary>
        /// <para>Name: My Activity Deadline</para>
        /// <para>Internal: my_activity_date_deadline</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("my_activity_date_deadline")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("my_activity_date_deadline")]
        public DateTime? MyActivityDateDeadline { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Summary</para>
        /// <para>Internal: activity_summary</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_summary")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_summary")]
        public string ActivitySummary { get; set; }

        /// <summary>
        /// <para>Name: Activity Exception Decoration</para>
        /// <para>Internal: activity_exception_decoration</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [warning]=Alert,[danger]=Error</para>
        /// </summary>
        [JsonPropertyName("activity_exception_decoration")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_exception_decoration")]
        public string ActivityExceptionDecoration { get; set; }

        /// <summary>
        /// <para>Name: Icon</para>
        /// <para>Internal: activity_exception_icon</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_exception_icon")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_exception_icon")]
        public string ActivityExceptionIcon { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Calendar Event</para>
        /// <para>Internal: activity_calendar_event_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: calendar.event</para>
        /// </summary>
        [JsonPropertyName("activity_calendar_event_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("activity_calendar_event_id")]
        public int? ActivityCalendarEventId { get; set; }

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
        /// <para>Name: Followers</para>
        /// <para>Internal: message_follower_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.followers</para>
        /// </summary>
        [JsonPropertyName("message_follower_ids")]
        [OdooField("message_follower_ids")]
        public List<int> MessageFollowerIds { get; set; }

        /// <summary>
        /// <para>Name: Followers (Partners)</para>
        /// <para>Internal: message_partner_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("message_partner_ids")]
        [OdooField("message_partner_ids")]
        public List<int> MessagePartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Messages</para>
        /// <para>Internal: message_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("message_ids")]
        [OdooField("message_ids")]
        public List<int> MessageIds { get; set; }

        /// <summary>
        /// <para>Name: Has Message</para>
        /// <para>Internal: has_message</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_message")]
        [OdooField("has_message")]
        public bool HasMessage { get; set; }

        /// <summary>
        /// <para>Name: Action Needed</para>
        /// <para>Internal: message_needaction</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_needaction")]
        [OdooField("message_needaction")]
        public bool MessageNeedaction { get; set; }

        /// <summary>
        /// <para>Name: Number of Actions</para>
        /// <para>Internal: message_needaction_counter</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_needaction_counter")]
        [OdooField("message_needaction_counter")]
        public int MessageNeedactionCounter { get; set; }

        /// <summary>
        /// <para>Name: Message Delivery error</para>
        /// <para>Internal: message_has_error</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_has_error")]
        [OdooField("message_has_error")]
        public bool MessageHasError { get; set; }

        /// <summary>
        /// <para>Name: Number of errors</para>
        /// <para>Internal: message_has_error_counter</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_has_error_counter")]
        [OdooField("message_has_error_counter")]
        public int MessageHasErrorCounter { get; set; }

        /// <summary>
        /// <para>Name: Attachment Count</para>
        /// <para>Internal: message_attachment_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_attachment_count")]
        [OdooField("message_attachment_count")]
        public int MessageAttachmentCount { get; set; }

        /// <summary>
        /// <para>Name: Ratings</para>
        /// <para>Internal: rating_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: rating.rating</para>
        /// </summary>
        [JsonPropertyName("rating_ids")]
        [OdooField("rating_ids")]
        public List<int> RatingIds { get; set; }

        /// <summary>
        /// <para>Name: Website Messages</para>
        /// <para>Internal: website_message_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("website_message_ids")]
        [OdooField("website_message_ids")]
        public List<int> WebsiteMessageIds { get; set; }

        /// <summary>
        /// <para>Name: SMS Delivery error</para>
        /// <para>Internal: message_has_sms_error</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_has_sms_error")]
        [OdooField("message_has_sms_error")]
        public bool MessageHasSmsError { get; set; }

        /// <summary>
        /// <para>Name: Sanitized Number</para>
        /// <para>Internal: phone_sanitized</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("phone_sanitized")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("phone_sanitized")]
        public string PhoneSanitized { get; set; }

        /// <summary>
        /// <para>Name: Phone Blacklisted</para>
        /// <para>Internal: phone_sanitized_blacklisted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("phone_sanitized_blacklisted")]
        [OdooField("phone_sanitized_blacklisted")]
        public bool PhoneSanitizedBlacklisted { get; set; }

        /// <summary>
        /// <para>Name: Blacklisted Phone is Phone</para>
        /// <para>Internal: phone_blacklisted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("phone_blacklisted")]
        [OdooField("phone_blacklisted")]
        public bool PhoneBlacklisted { get; set; }

        /// <summary>
        /// <para>Name: Phone Number</para>
        /// <para>Internal: phone_mobile_search</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("phone_mobile_search")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("phone_mobile_search")]
        public string PhoneMobileSearch { get; set; }

        /// <summary>
        /// <para>Name: Normalized Email</para>
        /// <para>Internal: email_normalized</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email_normalized")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email_normalized")]
        public string EmailNormalized { get; set; }

        /// <summary>
        /// <para>Name: Blacklist</para>
        /// <para>Internal: is_blacklisted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_blacklisted")]
        [OdooField("is_blacklisted")]
        public bool IsBlacklisted { get; set; }

        /// <summary>
        /// <para>Name: Bounce</para>
        /// <para>Internal: message_bounce</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_bounce")]
        [OdooField("message_bounce")]
        public int MessageBounce { get; set; }

        /// <summary>
        /// <para>Name: Email cc</para>
        /// <para>Internal: email_cc</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email_cc")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email_cc")]
        public string EmailCc { get; set; }

        /// <summary>
        /// <para>Name: Opportunity</para>
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
        /// <para>Name: Salesperson</para>
        /// <para>Internal: user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
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
        /// <para>Name: User Company</para>
        /// <para>Internal: user_company_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("user_company_ids")]
        [OdooField("user_company_ids")]
        public List<int> UserCompanyIds { get; set; }

        /// <summary>
        /// <para>Name: Sales Team</para>
        /// <para>Internal: team_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.team</para>
        /// </summary>
        [JsonPropertyName("team_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("team_id")]
        public int? TeamId { get; set; }

        /// <summary>
        /// <para>Name: Properties</para>
        /// <para>Internal: lead_properties</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Unknown</para>
        /// </summary>
        [JsonPropertyName("lead_properties")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("lead_properties")]
        public object LeadProperties { get; set; }

        /// <summary>
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Referred By</para>
        /// <para>Internal: referred</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("referred")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("referred")]
        public string Referred { get; set; }

        /// <summary>
        /// <para>Name: Notes</para>
        /// <para>Internal: description</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("description")]
        public string Description { get; set; }

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
        [OdooField("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>Name: Type</para>
        /// <para>Internal: type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [lead]=Lead,[opportunity]=Opportunity</para>
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("type")]
        public string Type { get; set; }

        /// <summary>
        /// <para>Name: Priority</para>
        /// <para>Internal: priority</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [0]=Low,[1]=Medium,[2]=High,[3]=Very High</para>
        /// </summary>
        [JsonPropertyName("priority")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// <para>Name: Stage</para>
        /// <para>Internal: stage_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.stage</para>
        /// </summary>
        [JsonPropertyName("stage_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("stage_id")]
        public int? StageId { get; set; }

        /// <summary>
        /// <para>Name: Tags</para>
        /// <para>Internal: tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: crm.tag</para>
        /// </summary>
        [JsonPropertyName("tag_ids")]
        [OdooField("tag_ids")]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// <para>Name: Color Index</para>
        /// <para>Internal: color</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("color")]
        [OdooField("color")]
        public int Color { get; set; }

        /// <summary>
        /// <para>Name: Expected Revenue</para>
        /// <para>Internal: expected_revenue</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("expected_revenue")]
        [OdooField("expected_revenue")]
        public decimal ExpectedRevenue { get; set; }

        /// <summary>
        /// <para>Name: Prorated Revenue</para>
        /// <para>Internal: prorated_revenue</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("prorated_revenue")]
        [OdooField("prorated_revenue")]
        public decimal ProratedRevenue { get; set; }

        /// <summary>
        /// <para>Name: Recurring Revenues</para>
        /// <para>Internal: recurring_revenue</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("recurring_revenue")]
        [OdooField("recurring_revenue")]
        public decimal RecurringRevenue { get; set; }

        /// <summary>
        /// <para>Name: Recurring Plan</para>
        /// <para>Internal: recurring_plan</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.recurring.plan</para>
        /// </summary>
        [JsonPropertyName("recurring_plan")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("recurring_plan")]
        public int? RecurringPlan { get; set; }

        /// <summary>
        /// <para>Name: Expected MRR</para>
        /// <para>Internal: recurring_revenue_monthly</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("recurring_revenue_monthly")]
        [OdooField("recurring_revenue_monthly")]
        public decimal RecurringRevenueMonthly { get; set; }

        /// <summary>
        /// <para>Name: Prorated MRR</para>
        /// <para>Internal: recurring_revenue_monthly_prorated</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("recurring_revenue_monthly_prorated")]
        [OdooField("recurring_revenue_monthly_prorated")]
        public decimal RecurringRevenueMonthlyProrated { get; set; }

        /// <summary>
        /// <para>Name: Prorated Recurring Revenues</para>
        /// <para>Internal: recurring_revenue_prorated</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("recurring_revenue_prorated")]
        [OdooField("recurring_revenue_prorated")]
        public decimal RecurringRevenueProrated { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: company_currency</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("company_currency")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("company_currency")]
        public int? CompanyCurrency { get; set; }

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
        [OdooField("date_closed")]
        public DateTime? DateClosed { get; set; }

        /// <summary>
        /// <para>Name: Last Action</para>
        /// <para>Internal: date_automation_last</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_automation_last")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date_automation_last")]
        public DateTime? DateAutomationLast { get; set; }

        /// <summary>
        /// <para>Name: Assignment Date</para>
        /// <para>Internal: date_open</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_open")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date_open")]
        public DateTime? DateOpen { get; set; }

        /// <summary>
        /// <para>Name: Days to Assign</para>
        /// <para>Internal: day_open</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("day_open")]
        [OdooField("day_open")]
        public double DayOpen { get; set; }

        /// <summary>
        /// <para>Name: Days to Close</para>
        /// <para>Internal: day_close</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("day_close")]
        [OdooField("day_close")]
        public double DayClose { get; set; }

        /// <summary>
        /// <para>Name: Last Stage Update</para>
        /// <para>Internal: date_last_stage_update</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_last_stage_update")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date_last_stage_update")]
        public DateTime? DateLastStageUpdate { get; set; }

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
        [OdooField("date_conversion")]
        public DateTime? DateConversion { get; set; }

        /// <summary>
        /// <para>Name: Expected Closing</para>
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
        /// <para>Name: Customer</para>
        /// <para>Internal: partner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("partner_id")]
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Partner is blacklisted</para>
        /// <para>Internal: partner_is_blacklisted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("partner_is_blacklisted")]
        [OdooField("partner_is_blacklisted")]
        public bool PartnerIsBlacklisted { get; set; }

        /// <summary>
        /// <para>Name: Contact Name</para>
        /// <para>Internal: contact_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("contact_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>Name: Company Name</para>
        /// <para>Internal: partner_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// <para>Name: Job Position</para>
        /// <para>Internal: function</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("function")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("function")]
        public string Function { get; set; }

        /// <summary>
        /// <para>Name: Email</para>
        /// <para>Internal: email_from</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email_from")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email_from")]
        public string EmailFrom { get; set; }

        /// <summary>
        /// <para>Name: Email Domain Criterion</para>
        /// <para>Internal: email_domain_criterion</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email_domain_criterion")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email_domain_criterion")]
        public string EmailDomainCriterion { get; set; }

        /// <summary>
        /// <para>Name: Phone</para>
        /// <para>Internal: phone</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// <para>Name: Phone Quality</para>
        /// <para>Internal: phone_state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [correct]=Correct,[incorrect]=Incorrect</para>
        /// </summary>
        [JsonPropertyName("phone_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("phone_state")]
        public string PhoneState { get; set; }

        /// <summary>
        /// <para>Name: Email Quality</para>
        /// <para>Internal: email_state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [correct]=Correct,[incorrect]=Incorrect</para>
        /// </summary>
        [JsonPropertyName("email_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email_state")]
        public string EmailState { get; set; }

        /// <summary>
        /// <para>Name: Website</para>
        /// <para>Internal: website</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website")]
        public string Website { get; set; }

        /// <summary>
        /// <para>Name: Language</para>
        /// <para>Internal: lang_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.lang</para>
        /// </summary>
        [JsonPropertyName("lang_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("lang_id")]
        public int? LangId { get; set; }

        /// <summary>
        /// <para>Name: Locale Code</para>
        /// <para>Internal: lang_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("lang_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("lang_code")]
        public string LangCode { get; set; }

        /// <summary>
        /// <para>Name: Lang Active Count</para>
        /// <para>Internal: lang_active_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("lang_active_count")]
        [OdooField("lang_active_count")]
        public int LangActiveCount { get; set; }

        /// <summary>
        /// <para>Name: Street</para>
        /// <para>Internal: street</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("street")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("street")]
        public string Street { get; set; }

        /// <summary>
        /// <para>Name: Street2</para>
        /// <para>Internal: street2</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("street2")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("street2")]
        public string Street2 { get; set; }

        /// <summary>
        /// <para>Name: Zip</para>
        /// <para>Internal: zip</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("zip")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// <para>Name: City</para>
        /// <para>Internal: city</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("city")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("city")]
        public string City { get; set; }

        /// <summary>
        /// <para>Name: State</para>
        /// <para>Internal: state_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country.state</para>
        /// </summary>
        [JsonPropertyName("state_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("state_id")]
        public int? StateId { get; set; }

        /// <summary>
        /// <para>Name: Country</para>
        /// <para>Internal: country_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("country_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("country_id")]
        public int? CountryId { get; set; }

        /// <summary>
        /// <para>Name: Probability</para>
        /// <para>Internal: probability</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("probability")]
        [OdooField("probability")]
        public double Probability { get; set; }

        /// <summary>
        /// <para>Name: Automated Probability</para>
        /// <para>Internal: automated_probability</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("automated_probability")]
        [OdooField("automated_probability")]
        public double AutomatedProbability { get; set; }

        /// <summary>
        /// <para>Name: Is automated probability?</para>
        /// <para>Internal: is_automated_probability</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_automated_probability")]
        [OdooField("is_automated_probability")]
        public bool IsAutomatedProbability { get; set; }

        /// <summary>
        /// <para>Name: Won/Lost</para>
        /// <para>Internal: won_status</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [won]=Won,[lost]=Lost,[pending]=Pending</para>
        /// </summary>
        [JsonPropertyName("won_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("won_status")]
        public string WonStatus { get; set; }

        /// <summary>
        /// <para>Name: Lost Reason</para>
        /// <para>Internal: lost_reason_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.lost.reason</para>
        /// </summary>
        [JsonPropertyName("lost_reason_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("lost_reason_id")]
        public int? LostReasonId { get; set; }

        /// <summary>
        /// <para>Name: Meetings</para>
        /// <para>Internal: calendar_event_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: calendar.event</para>
        /// </summary>
        [JsonPropertyName("calendar_event_ids")]
        [OdooField("calendar_event_ids")]
        public List<int> CalendarEventIds { get; set; }

        /// <summary>
        /// <para>Name: Potential Duplicate Lead</para>
        /// <para>Internal: duplicate_lead_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: crm.lead</para>
        /// </summary>
        [JsonPropertyName("duplicate_lead_ids")]
        [OdooField("duplicate_lead_ids")]
        public List<int> DuplicateLeadIds { get; set; }

        /// <summary>
        /// <para>Name: Potential Duplicate Lead Count</para>
        /// <para>Internal: duplicate_lead_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("duplicate_lead_count")]
        [OdooField("duplicate_lead_count")]
        public int DuplicateLeadCount { get; set; }

        /// <summary>
        /// <para>Name: Meeting Display Date</para>
        /// <para>Internal: meeting_display_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("meeting_display_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("meeting_display_date")]
        public DateTime? MeetingDisplayDate { get; set; }

        /// <summary>
        /// <para>Name: Meeting Display Label</para>
        /// <para>Internal: meeting_display_label</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("meeting_display_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("meeting_display_label")]
        public string MeetingDisplayLabel { get; set; }

        /// <summary>
        /// <para>Name: Partner Email will Update</para>
        /// <para>Internal: partner_email_update</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("partner_email_update")]
        [OdooField("partner_email_update")]
        public bool PartnerEmailUpdate { get; set; }

        /// <summary>
        /// <para>Name: Partner Phone will Update</para>
        /// <para>Internal: partner_phone_update</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("partner_phone_update")]
        [OdooField("partner_phone_update")]
        public bool PartnerPhoneUpdate { get; set; }

        /// <summary>
        /// <para>Name: Is Partner Visible</para>
        /// <para>Internal: is_partner_visible</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_partner_visible")]
        [OdooField("is_partner_visible")]
        public bool IsPartnerVisible { get; set; }

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
        /// <para>Name: Days To Convert</para>
        /// <para>Internal: days_to_convert</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("days_to_convert")]
        [OdooField("days_to_convert")]
        public double DaysToConvert { get; set; }

        /// <summary>
        /// <para>Name: Exceeded Closing Days</para>
        /// <para>Internal: days_exceeding_closing</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("days_exceeding_closing")]
        [OdooField("days_exceeding_closing")]
        public double DaysExceedingClosing { get; set; }

        /// <summary>
        /// <para>Name: Reveal ID</para>
        /// <para>Internal: reveal_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("reveal_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("reveal_id")]
        public string RevealId { get; set; }

        /// <summary>
        /// <para>Name: Web Visitors</para>
        /// <para>Internal: visitor_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: website.visitor</para>
        /// </summary>
        [JsonPropertyName("visitor_ids")]
        [OdooField("visitor_ids")]
        public List<int> VisitorIds { get; set; }

        /// <summary>
        /// <para>Name: # Page Views</para>
        /// <para>Internal: visitor_page_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("visitor_page_count")]
        [OdooField("visitor_page_count")]
        public int VisitorPageCount { get; set; }

        /// <summary>
        /// <para>Name: Enrichment done</para>
        /// <para>Internal: iap_enrich_done</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("iap_enrich_done")]
        [OdooField("iap_enrich_done")]
        public bool IapEnrichDone { get; set; }

        /// <summary>
        /// <para>Name: Allow manual enrich</para>
        /// <para>Internal: show_enrich_button</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_enrich_button")]
        [OdooField("show_enrich_button")]
        public bool ShowEnrichButton { get; set; }

        /// <summary>
        /// <para>Name: Lead Mining Request</para>
        /// <para>Internal: lead_mining_request_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.iap.lead.mining.request</para>
        /// </summary>
        [JsonPropertyName("lead_mining_request_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("lead_mining_request_id")]
        public int? LeadMiningRequestId { get; set; }

        /// <summary>
        /// <para>Name: Sum of Orders</para>
        /// <para>Internal: sale_amount_total</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("sale_amount_total")]
        [OdooField("sale_amount_total")]
        public decimal SaleAmountTotal { get; set; }

        /// <summary>
        /// <para>Name: Number of Quotations</para>
        /// <para>Internal: quotation_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("quotation_count")]
        [OdooField("quotation_count")]
        public int QuotationCount { get; set; }

        /// <summary>
        /// <para>Name: Number of Sale Orders</para>
        /// <para>Internal: sale_order_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sale_order_count")]
        [OdooField("sale_order_count")]
        public int SaleOrderCount { get; set; }

        /// <summary>
        /// <para>Name: Orders</para>
        /// <para>Internal: order_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: sale.order</para>
        /// </summary>
        [JsonPropertyName("order_ids")]
        [OdooField("order_ids")]
        public List<int> OrderIds { get; set; }

    }
}
