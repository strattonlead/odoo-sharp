using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("helpdesk.ticket")]
    public partial class HelpdeskTicket
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
        /// <para>Name: Rating Last Value</para>
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
        /// <para>Name: Rating Last Feedback</para>
        /// <para>Internal: rating_last_feedback</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("rating_last_feedback")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("rating_last_feedback")]
        public string RatingLastFeedback { get; set; }

        /// <summary>
        /// <para>Name: Rating Last Image</para>
        /// <para>Internal: rating_last_image</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("rating_last_image")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("rating_last_image")]
        public object RatingLastImage { get; set; }

        /// <summary>
        /// <para>Name: Rating count</para>
        /// <para>Internal: rating_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("rating_count")]
        [OdooField("rating_count")]
        public int RatingCount { get; set; }

        /// <summary>
        /// <para>Name: Average Rating</para>
        /// <para>Internal: rating_avg</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("rating_avg")]
        [OdooField("rating_avg")]
        public double RatingAvg { get; set; }

        /// <summary>
        /// <para>Name: Rating Avg Text</para>
        /// <para>Internal: rating_avg_text</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [top]=Satisfied,[ok]=Okay,[ko]=Dissatisfied,[none]=No Rating yet</para>
        /// </summary>
        [JsonPropertyName("rating_avg_text")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("rating_avg_text")]
        public string RatingAvgText { get; set; }

        /// <summary>
        /// <para>Name: Rating Satisfaction</para>
        /// <para>Internal: rating_percentage_satisfaction</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("rating_percentage_satisfaction")]
        [OdooField("rating_percentage_satisfaction")]
        public double RatingPercentageSatisfaction { get; set; }

        /// <summary>
        /// <para>Name: Rating Text</para>
        /// <para>Internal: rating_last_text</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [top]=Satisfied,[ok]=Okay,[ko]=Dissatisfied,[none]=No Rating yet</para>
        /// </summary>
        [JsonPropertyName("rating_last_text")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("rating_last_text")]
        public string RatingLastText { get; set; }

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
        /// <para>Name: Portal Access URL</para>
        /// <para>Internal: access_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("access_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_url")]
        public string AccessUrl { get; set; }

        /// <summary>
        /// <para>Name: Security Token</para>
        /// <para>Internal: access_token</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("access_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>Name: Access warning</para>
        /// <para>Internal: access_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("access_warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_warning")]
        public string AccessWarning { get; set; }

        /// <summary>
        /// <para>Name: Subject</para>
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
        /// <para>Name: Helpdesk Team</para>
        /// <para>Internal: team_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: helpdesk.team</para>
        /// </summary>
        [JsonPropertyName("team_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("team_id")]
        public int? TeamId { get; set; }

        /// <summary>
        /// <para>Name: SLA Policies</para>
        /// <para>Internal: use_sla</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_sla")]
        [OdooField("use_sla")]
        public bool UseSla { get; set; }

        /// <summary>
        /// <para>Name: Visibility</para>
        /// <para>Internal: team_privacy_visibility</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [invited_internal]=Invited internal users (private),[internal]=All internal users (company),[portal]=Invited portal users and all internal users (public)</para>
        /// </summary>
        [JsonPropertyName("team_privacy_visibility")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("team_privacy_visibility")]
        public string TeamPrivacyVisibility { get; set; }

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
        /// <para>Name: Tags</para>
        /// <para>Internal: tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: helpdesk.tag</para>
        /// </summary>
        [JsonPropertyName("tag_ids")]
        [OdooField("tag_ids")]
        public List<int> TagIds { get; set; }

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
        /// <para>Name: Kanban State</para>
        /// <para>Internal: kanban_state</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [normal]=In progress,[done]=Ready,[blocked]=Blocked</para>
        /// </summary>
        [JsonPropertyName("kanban_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("kanban_state")]
        public string KanbanState { get; set; }

        /// <summary>
        /// <para>Name: Kanban State Label</para>
        /// <para>Internal: kanban_state_label</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("kanban_state_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("kanban_state_label")]
        public string KanbanStateLabel { get; set; }

        /// <summary>
        /// <para>Name: Kanban Blocked Explanation</para>
        /// <para>Internal: legend_blocked</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("legend_blocked")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("legend_blocked")]
        public string LegendBlocked { get; set; }

        /// <summary>
        /// <para>Name: Kanban Valid Explanation</para>
        /// <para>Internal: legend_done</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("legend_done")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("legend_done")]
        public string LegendDone { get; set; }

        /// <summary>
        /// <para>Name: Kanban Ongoing Explanation</para>
        /// <para>Internal: legend_normal</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("legend_normal")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("legend_normal")]
        public string LegendNormal { get; set; }

        /// <summary>
        /// <para>Name: Domain User</para>
        /// <para>Internal: domain_user_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("domain_user_ids")]
        [OdooField("domain_user_ids")]
        public List<int> DomainUserIds { get; set; }

        /// <summary>
        /// <para>Name: Assigned to</para>
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
        /// <para>Name: Properties</para>
        /// <para>Internal: properties</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Unknown</para>
        /// </summary>
        [JsonPropertyName("properties")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("properties")]
        public object Properties { get; set; }

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
        /// <para>Name: Partner Tickets</para>
        /// <para>Internal: partner_ticket_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: helpdesk.ticket</para>
        /// </summary>
        [JsonPropertyName("partner_ticket_ids")]
        [OdooField("partner_ticket_ids")]
        public List<int> PartnerTicketIds { get; set; }

        /// <summary>
        /// <para>Name: Number of other tickets from the same partner</para>
        /// <para>Internal: partner_ticket_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("partner_ticket_count")]
        [OdooField("partner_ticket_count")]
        public int PartnerTicketCount { get; set; }

        /// <summary>
        /// <para>Name: Number of other open tickets from the same partner</para>
        /// <para>Internal: partner_open_ticket_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("partner_open_ticket_count")]
        [OdooField("partner_open_ticket_count")]
        public int PartnerOpenTicketCount { get; set; }

        /// <summary>
        /// <para>Name: Customer Name</para>
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
        /// <para>Name: Customer Email</para>
        /// <para>Internal: partner_email</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
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
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_phone")]
        public string PartnerPhone { get; set; }

        /// <summary>
        /// <para>Name: Commercial Entity</para>
        /// <para>Internal: commercial_partner_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("commercial_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("commercial_partner_id")]
        public int? CommercialPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Closed by Partner</para>
        /// <para>Internal: closed_by_partner</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("closed_by_partner")]
        [OdooField("closed_by_partner")]
        public bool ClosedByPartner { get; set; }

        /// <summary>
        /// <para>Name: Priority</para>
        /// <para>Internal: priority</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [0]=Low priority,[1]=Medium priority,[2]=High priority,[3]=Urgent</para>
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
        /// <para>Relation: helpdesk.stage</para>
        /// </summary>
        [JsonPropertyName("stage_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("stage_id")]
        public int? StageId { get; set; }

        /// <summary>
        /// <para>Name: Folded in Kanban</para>
        /// <para>Internal: fold</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("fold")]
        [OdooField("fold")]
        public bool Fold { get; set; }

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
        /// <para>Name: First assignment date</para>
        /// <para>Internal: assign_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("assign_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("assign_date")]
        public DateTime? AssignDate { get; set; }

        /// <summary>
        /// <para>Name: Time to first assignment (hours)</para>
        /// <para>Internal: assign_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("assign_hours")]
        [OdooField("assign_hours")]
        public double AssignHours { get; set; }

        /// <summary>
        /// <para>Name: Close date</para>
        /// <para>Internal: close_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("close_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("close_date")]
        public DateTime? CloseDate { get; set; }

        /// <summary>
        /// <para>Name: Time to close (hours)</para>
        /// <para>Internal: close_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("close_hours")]
        [OdooField("close_hours")]
        public double CloseHours { get; set; }

        /// <summary>
        /// <para>Name: Open Time (hours)</para>
        /// <para>Internal: open_hours</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("open_hours")]
        [OdooField("open_hours")]
        public int OpenHours { get; set; }

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
        /// <para>Name: Has SLA reached late</para>
        /// <para>Internal: sla_reached_late</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sla_reached_late")]
        [OdooField("sla_reached_late")]
        public bool SlaReachedLate { get; set; }

        /// <summary>
        /// <para>Name: Has SLA reached</para>
        /// <para>Internal: sla_reached</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sla_reached")]
        [OdooField("sla_reached")]
        public bool SlaReached { get; set; }

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
        /// <para>Name: Working Hours until SLA Deadline</para>
        /// <para>Internal: sla_deadline_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("sla_deadline_hours")]
        [OdooField("sla_deadline_hours")]
        public double SlaDeadlineHours { get; set; }

        /// <summary>
        /// <para>Name: Failed SLA Policy</para>
        /// <para>Internal: sla_fail</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sla_fail")]
        [OdooField("sla_fail")]
        public bool SlaFail { get; set; }

        /// <summary>
        /// <para>Name: Success SLA Policy</para>
        /// <para>Internal: sla_success</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sla_success")]
        [OdooField("sla_success")]
        public bool SlaSuccess { get; set; }

        /// <summary>
        /// <para>Name: Refunds</para>
        /// <para>Internal: use_credit_notes</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_credit_notes")]
        [OdooField("use_credit_notes")]
        public bool UseCreditNotes { get; set; }

        /// <summary>
        /// <para>Name: Use Coupons</para>
        /// <para>Internal: use_coupons</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_coupons")]
        [OdooField("use_coupons")]
        public bool UseCoupons { get; set; }

        /// <summary>
        /// <para>Name: Returns</para>
        /// <para>Internal: use_product_returns</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_product_returns")]
        [OdooField("use_product_returns")]
        public bool UseProductReturns { get; set; }

        /// <summary>
        /// <para>Name: Repairs</para>
        /// <para>Internal: use_product_repairs</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_product_repairs")]
        [OdooField("use_product_repairs")]
        public bool UseProductRepairs { get; set; }

        /// <summary>
        /// <para>Name: Customer Ratings</para>
        /// <para>Internal: use_rating</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_rating")]
        [OdooField("use_rating")]
        public bool UseRating { get; set; }

        /// <summary>
        /// <para>Name: Is Partner Email Update</para>
        /// <para>Internal: is_partner_email_update</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_partner_email_update")]
        [OdooField("is_partner_email_update")]
        public bool IsPartnerEmailUpdate { get; set; }

        /// <summary>
        /// <para>Name: Is Partner Phone Update</para>
        /// <para>Internal: is_partner_phone_update</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_partner_phone_update")]
        [OdooField("is_partner_phone_update")]
        public bool IsPartnerPhoneUpdate { get; set; }

        /// <summary>
        /// <para>Name: Hours to First Response</para>
        /// <para>Internal: first_response_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("first_response_hours")]
        [OdooField("first_response_hours")]
        public double FirstResponseHours { get; set; }

        /// <summary>
        /// <para>Name: Average Hours to Respond</para>
        /// <para>Internal: avg_response_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("avg_response_hours")]
        [OdooField("avg_response_hours")]
        public double AvgResponseHours { get; set; }

        /// <summary>
        /// <para>Name: Oldest Unanswered Customer Message Date</para>
        /// <para>Internal: oldest_unanswered_customer_message_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("oldest_unanswered_customer_message_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("oldest_unanswered_customer_message_date")]
        public DateTime? OldestUnansweredCustomerMessageDate { get; set; }

        /// <summary>
        /// <para>Name: # Exchanges</para>
        /// <para>Internal: answered_customer_message_count</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("answered_customer_message_count")]
        [OdooField("answered_customer_message_count")]
        public int AnsweredCustomerMessageCount { get; set; }

        /// <summary>
        /// <para>Name: Total Exchange Time in Hours</para>
        /// <para>Internal: total_response_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("total_response_hours")]
        [OdooField("total_response_hours")]
        public double TotalResponseHours { get; set; }

        /// <summary>
        /// <para>Name: Display Extra Info</para>
        /// <para>Internal: display_extra_info</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_extra_info")]
        [OdooField("display_extra_info")]
        public bool DisplayExtraInfo { get; set; }

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
        /// <para>Name: Company Name</para>
        /// <para>Internal: partner_company_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_company_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_company_name")]
        public string PartnerCompanyName { get; set; }

        /// <summary>
        /// <para>Name: Ref. Sales Order</para>
        /// <para>Internal: sale_order_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sale.order</para>
        /// </summary>
        [JsonPropertyName("sale_order_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sale_order_id")]
        public int? SaleOrderId { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: sale_order_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [draft]=Quotation,[sent]=Quotation Sent,[sale]=Sales Order,[cancel]=Cancelled</para>
        /// </summary>
        [JsonPropertyName("sale_order_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sale_order_state")]
        public string SaleOrderState { get; set; }

    }
}
