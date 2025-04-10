using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("appointment.type")]
    public partial class AppointmentType
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
        /// <para>Name: Website</para>
        /// <para>Internal: website_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website</para>
        /// </summary>
        [JsonPropertyName("website_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("website_id")]
        public int? WebsiteId { get; set; }

        /// <summary>
        /// <para>Name: Visible on current website</para>
        /// <para>Internal: website_published</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_published")]
        [OdooField("website_published")]
        public bool WebsitePublished { get; set; }

        /// <summary>
        /// <para>Name: Is Published</para>
        /// <para>Internal: is_published</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_published")]
        [OdooField("is_published")]
        public bool IsPublished { get; set; }

        /// <summary>
        /// <para>Name: Can Publish</para>
        /// <para>Internal: can_publish</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("can_publish")]
        [OdooField("can_publish")]
        public bool CanPublish { get; set; }

        /// <summary>
        /// <para>Name: Website URL</para>
        /// <para>Internal: website_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_url")]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// <para>Name: Website Absolute URL</para>
        /// <para>Internal: website_absolute_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_absolute_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_absolute_url")]
        public string WebsiteAbsoluteUrl { get; set; }

        /// <summary>
        /// <para>Name: SEO optimized</para>
        /// <para>Internal: is_seo_optimized</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_seo_optimized")]
        [OdooField("is_seo_optimized")]
        public bool IsSeoOptimized { get; set; }

        /// <summary>
        /// <para>Name: Website meta title</para>
        /// <para>Internal: website_meta_title</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_meta_title")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_meta_title")]
        public string WebsiteMetaTitle { get; set; }

        /// <summary>
        /// <para>Name: Website meta description</para>
        /// <para>Internal: website_meta_description</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("website_meta_description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_meta_description")]
        public string WebsiteMetaDescription { get; set; }

        /// <summary>
        /// <para>Name: Website meta keywords</para>
        /// <para>Internal: website_meta_keywords</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_meta_keywords")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_meta_keywords")]
        public string WebsiteMetaKeywords { get; set; }

        /// <summary>
        /// <para>Name: Website opengraph image</para>
        /// <para>Internal: website_meta_og_img</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_meta_og_img")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_meta_og_img")]
        public string WebsiteMetaOgImg { get; set; }

        /// <summary>
        /// <para>Name: Seo name</para>
        /// <para>Internal: seo_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("seo_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("seo_name")]
        public string SeoName { get; set; }

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
        /// <para>Name: CC to</para>
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
        /// <para>Name: Background Image</para>
        /// <para>Internal: image_1920</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_1920")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("image_1920")]
        public byte[] Image1920 { get; set; }

        /// <summary>
        /// <para>Name: Image 1024</para>
        /// <para>Internal: image_1024</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_1024")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("image_1024")]
        public byte[] Image1024 { get; set; }

        /// <summary>
        /// <para>Name: Image 512</para>
        /// <para>Internal: image_512</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_512")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("image_512")]
        public byte[] Image512 { get; set; }

        /// <summary>
        /// <para>Name: Image 256</para>
        /// <para>Internal: image_256</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_256")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("image_256")]
        public byte[] Image256 { get; set; }

        /// <summary>
        /// <para>Name: Image 128</para>
        /// <para>Internal: image_128</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_128")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("image_128")]
        public byte[] Image128 { get; set; }

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
        [OdooField("sequence")]
        public int Sequence { get; set; }

        /// <summary>
        /// <para>Name: Appointment Title</para>
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
        /// <para>Name: Duration</para>
        /// <para>Internal: appointment_duration</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("appointment_duration")]
        [OdooField("appointment_duration")]
        public double AppointmentDuration { get; set; }

        /// <summary>
        /// <para>Name: Appointment Duration Formatted </para>
        /// <para>Internal: appointment_duration_formatted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("appointment_duration_formatted")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("appointment_duration_formatted")]
        public string AppointmentDurationFormatted { get; set; }

        /// <summary>
        /// <para>Name: Manual Confirmation</para>
        /// <para>Internal: appointment_manual_confirmation</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("appointment_manual_confirmation")]
        [OdooField("appointment_manual_confirmation")]
        public bool AppointmentManualConfirmation { get; set; }

        /// <summary>
        /// <para>Name: Timezone</para>
        /// <para>Internal: appointment_tz</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [Africa/Abidjan]=Africa/Abidjan,[Africa/Accra]=Africa/Accra,[Africa/Addis_Ababa]=Africa/Addis_Ababa,[Africa/Algiers]=Africa/Algiers,[Africa/Asmara]=Africa/Asmara,[Africa/Asmera]=Africa/Asmera,[Africa/Bamako]=Africa/Bamako,[Africa/Bangui]=Africa/Bangui,[Africa/Banjul]=Africa/Banjul,[Africa/Bissau]=Africa/Bissau,[Africa/Blantyre]=Africa/Blantyre,[Africa/Brazzaville]=Africa/Brazzaville,[Africa/Bujumbura]=Africa/Bujumbura,[Africa/Cairo]=Africa/Cairo,[Africa/Casablanca]=Africa/Casablanca,[Africa/Ceuta]=Africa/Ceuta,[Africa/Conakry]=Africa/Conakry,[Africa/Dakar]=Africa/Dakar,[Africa/Dar_es_Salaam]=Africa/Dar_es_Salaam,[Africa/Djibouti]=Africa/Djibouti,[Africa/Douala]=Africa/Douala,[Africa/El_Aaiun]=Africa/El_Aaiun,[Africa/Freetown]=Africa/Freetown,[Africa/Gaborone]=Africa/Gaborone,[Africa/Harare]=Africa/Harare,[Africa/Johannesburg]=Africa/Johannesburg,[Africa/Juba]=Africa/Juba,[Africa/Kampala]=Africa/Kampala,[Africa/Khartoum]=Africa/Khartoum,[Africa/Kigali]=Africa/Kigali,[Africa/Kinshasa]=Africa/Kinshasa,[Africa/Lagos]=Africa/Lagos,[Africa/Libreville]=Africa/Libreville,[Africa/Lome]=Africa/Lome,[Africa/Luanda]=Africa/Luanda,[Africa/Lubumbashi]=Africa/Lubumbashi,[Africa/Lusaka]=Africa/Lusaka,[Africa/Malabo]=Africa/Malabo,[Africa/Maputo]=Africa/Maputo,[Africa/Maseru]=Africa/Maseru,[Africa/Mbabane]=Africa/Mbabane,[Africa/Mogadishu]=Africa/Mogadishu,[Africa/Monrovia]=Africa/Monrovia,[Africa/Nairobi]=Africa/Nairobi,[Africa/Ndjamena]=Africa/Ndjamena,[Africa/Niamey]=Africa/Niamey,[Africa/Nouakchott]=Africa/Nouakchott,[Africa/Ouagadougou]=Africa/Ouagadougou,[Africa/Porto-Novo]=Africa/Porto-Novo,[Africa/Sao_Tome]=Africa/Sao_Tome,[Africa/Timbuktu]=Africa/Timbuktu,[Africa/Tripoli]=Africa/Tripoli,[Africa/Tunis]=Africa/Tunis,[Africa/Windhoek]=Africa/Windhoek,[America/Adak]=America/Adak,[America/Anchorage]=America/Anchorage,[America/Anguilla]=America/Anguilla,[America/Antigua]=America/Antigua,[America/Araguaina]=America/Araguaina,[America/Argentina/Buenos_Aires]=America/Argentina/Buenos_Aires,[America/Argentina/Catamarca]=America/Argentina/Catamarca,[America/Argentina/ComodRivadavia]=America/Argentina/ComodRivadavia,[America/Argentina/Cordoba]=America/Argentina/Cordoba,[America/Argentina/Jujuy]=America/Argentina/Jujuy,[America/Argentina/La_Rioja]=America/Argentina/La_Rioja,[America/Argentina/Mendoza]=America/Argentina/Mendoza,[America/Argentina/Rio_Gallegos]=America/Argentina/Rio_Gallegos,[America/Argentina/Salta]=America/Argentina/Salta,[America/Argentina/San_Juan]=America/Argentina/San_Juan,[America/Argentina/San_Luis]=America/Argentina/San_Luis,[America/Argentina/Tucuman]=America/Argentina/Tucuman,[America/Argentina/Ushuaia]=America/Argentina/Ushuaia,[America/Aruba]=America/Aruba,[America/Asuncion]=America/Asuncion,[America/Atikokan]=America/Atikokan,[America/Atka]=America/Atka,[America/Bahia]=America/Bahia,[America/Bahia_Banderas]=America/Bahia_Banderas,[America/Barbados]=America/Barbados,[America/Belem]=America/Belem,[America/Belize]=America/Belize,[America/Blanc-Sablon]=America/Blanc-Sablon,[America/Boa_Vista]=America/Boa_Vista,[America/Bogota]=America/Bogota,[America/Boise]=America/Boise,[America/Buenos_Aires]=America/Buenos_Aires,[America/Cambridge_Bay]=America/Cambridge_Bay,[America/Campo_Grande]=America/Campo_Grande,[America/Cancun]=America/Cancun,[America/Caracas]=America/Caracas,[America/Catamarca]=America/Catamarca,[America/Cayenne]=America/Cayenne,[America/Cayman]=America/Cayman,[America/Chicago]=America/Chicago,[America/Chihuahua]=America/Chihuahua,[America/Ciudad_Juarez]=America/Ciudad_Juarez,[America/Coral_Harbour]=America/Coral_Harbour,[America/Cordoba]=America/Cordoba,[America/Costa_Rica]=America/Costa_Rica,[America/Coyhaique]=America/Coyhaique,[America/Creston]=America/Creston,[America/Cuiaba]=America/Cuiaba,[America/Curacao]=America/Curacao,[America/Danmarkshavn]=America/Danmarkshavn,[America/Dawson]=America/Dawson,[America/Dawson_Creek]=America/Dawson_Creek,[America/Denver]=America/Denver,[America/Detroit]=America/Detroit,[America/Dominica]=America/Dominica,[America/Edmonton]=America/Edmonton,[America/Eirunepe]=America/Eirunepe,[America/El_Salvador]=America/El_Salvador,[America/Ensenada]=America/Ensenada,[America/Fort_Nelson]=America/Fort_Nelson,[America/Fort_Wayne]=America/Fort_Wayne,[America/Fortaleza]=America/Fortaleza,[America/Glace_Bay]=America/Glace_Bay,[America/Godthab]=America/Godthab,[America/Goose_Bay]=America/Goose_Bay,[America/Grand_Turk]=America/Grand_Turk,[America/Grenada]=America/Grenada,[America/Guadeloupe]=America/Guadeloupe,[America/Guatemala]=America/Guatemala,[America/Guayaquil]=America/Guayaquil,[America/Guyana]=America/Guyana,[America/Halifax]=America/Halifax,[America/Havana]=America/Havana,[America/Hermosillo]=America/Hermosillo,[America/Indiana/Indianapolis]=America/Indiana/Indianapolis,[America/Indiana/Knox]=America/Indiana/Knox,[America/Indiana/Marengo]=America/Indiana/Marengo,[America/Indiana/Petersburg]=America/Indiana/Petersburg,[America/Indiana/Tell_City]=America/Indiana/Tell_City,[America/Indiana/Vevay]=America/Indiana/Vevay,[America/Indiana/Vincennes]=America/Indiana/Vincennes,[America/Indiana/Winamac]=America/Indiana/Winamac,[America/Indianapolis]=America/Indianapolis,[America/Inuvik]=America/Inuvik,[America/Iqaluit]=America/Iqaluit,[America/Jamaica]=America/Jamaica,[America/Jujuy]=America/Jujuy,[America/Juneau]=America/Juneau,[America/Kentucky/Louisville]=America/Kentucky/Louisville,[America/Kentucky/Monticello]=America/Kentucky/Monticello,[America/Knox_IN]=America/Knox_IN,[America/Kralendijk]=America/Kralendijk,[America/La_Paz]=America/La_Paz,[America/Lima]=America/Lima,[America/Los_Angeles]=America/Los_Angeles,[America/Louisville]=America/Louisville,[America/Lower_Princes]=America/Lower_Princes,[America/Maceio]=America/Maceio,[America/Managua]=America/Managua,[America/Manaus]=America/Manaus,[America/Marigot]=America/Marigot,[America/Martinique]=America/Martinique,[America/Matamoros]=America/Matamoros,[America/Mazatlan]=America/Mazatlan,[America/Mendoza]=America/Mendoza,[America/Menominee]=America/Menominee,[America/Merida]=America/Merida,[America/Metlakatla]=America/Metlakatla,[America/Mexico_City]=America/Mexico_City,[America/Miquelon]=America/Miquelon,[America/Moncton]=America/Moncton,[America/Monterrey]=America/Monterrey,[America/Montevideo]=America/Montevideo,[America/Montreal]=America/Montreal,[America/Montserrat]=America/Montserrat,[America/Nassau]=America/Nassau,[America/New_York]=America/New_York,[America/Nipigon]=America/Nipigon,[America/Nome]=America/Nome,[America/Noronha]=America/Noronha,[America/North_Dakota/Beulah]=America/North_Dakota/Beulah,[America/North_Dakota/Center]=America/North_Dakota/Center,[America/North_Dakota/New_Salem]=America/North_Dakota/New_Salem,[America/Nuuk]=America/Nuuk,[America/Ojinaga]=America/Ojinaga,[America/Panama]=America/Panama,[America/Pangnirtung]=America/Pangnirtung,[America/Paramaribo]=America/Paramaribo,[America/Phoenix]=America/Phoenix,[America/Port-au-Prince]=America/Port-au-Prince,[America/Port_of_Spain]=America/Port_of_Spain,[America/Porto_Acre]=America/Porto_Acre,[America/Porto_Velho]=America/Porto_Velho,[America/Puerto_Rico]=America/Puerto_Rico,[America/Punta_Arenas]=America/Punta_Arenas,[America/Rainy_River]=America/Rainy_River,[America/Rankin_Inlet]=America/Rankin_Inlet,[America/Recife]=America/Recife,[America/Regina]=America/Regina,[America/Resolute]=America/Resolute,[America/Rio_Branco]=America/Rio_Branco,[America/Rosario]=America/Rosario,[America/Santa_Isabel]=America/Santa_Isabel,[America/Santarem]=America/Santarem,[America/Santiago]=America/Santiago,[America/Santo_Domingo]=America/Santo_Domingo,[America/Sao_Paulo]=America/Sao_Paulo,[America/Scoresbysund]=America/Scoresbysund,[America/Shiprock]=America/Shiprock,[America/Sitka]=America/Sitka,[America/St_Barthelemy]=America/St_Barthelemy,[America/St_Johns]=America/St_Johns,[America/St_Kitts]=America/St_Kitts,[America/St_Lucia]=America/St_Lucia,[America/St_Thomas]=America/St_Thomas,[America/St_Vincent]=America/St_Vincent,[America/Swift_Current]=America/Swift_Current,[America/Tegucigalpa]=America/Tegucigalpa,[America/Thule]=America/Thule,[America/Thunder_Bay]=America/Thunder_Bay,[America/Tijuana]=America/Tijuana,[America/Toronto]=America/Toronto,[America/Tortola]=America/Tortola,[America/Vancouver]=America/Vancouver,[America/Virgin]=America/Virgin,[America/Whitehorse]=America/Whitehorse,[America/Winnipeg]=America/Winnipeg,[America/Yakutat]=America/Yakutat,[America/Yellowknife]=America/Yellowknife,[Antarctica/Casey]=Antarctica/Casey,[Antarctica/Davis]=Antarctica/Davis,[Antarctica/DumontDUrville]=Antarctica/DumontDUrville,[Antarctica/Macquarie]=Antarctica/Macquarie,[Antarctica/Mawson]=Antarctica/Mawson,[Antarctica/McMurdo]=Antarctica/McMurdo,[Antarctica/Palmer]=Antarctica/Palmer,[Antarctica/Rothera]=Antarctica/Rothera,[Antarctica/South_Pole]=Antarctica/South_Pole,[Antarctica/Syowa]=Antarctica/Syowa,[Antarctica/Troll]=Antarctica/Troll,[Antarctica/Vostok]=Antarctica/Vostok,[Arctic/Longyearbyen]=Arctic/Longyearbyen,[Asia/Aden]=Asia/Aden,[Asia/Almaty]=Asia/Almaty,[Asia/Amman]=Asia/Amman,[Asia/Anadyr]=Asia/Anadyr,[Asia/Aqtau]=Asia/Aqtau,[Asia/Aqtobe]=Asia/Aqtobe,[Asia/Ashgabat]=Asia/Ashgabat,[Asia/Ashkhabad]=Asia/Ashkhabad,[Asia/Atyrau]=Asia/Atyrau,[Asia/Baghdad]=Asia/Baghdad,[Asia/Bahrain]=Asia/Bahrain,[Asia/Baku]=Asia/Baku,[Asia/Bangkok]=Asia/Bangkok,[Asia/Barnaul]=Asia/Barnaul,[Asia/Beirut]=Asia/Beirut,[Asia/Bishkek]=Asia/Bishkek,[Asia/Brunei]=Asia/Brunei,[Asia/Calcutta]=Asia/Calcutta,[Asia/Chita]=Asia/Chita,[Asia/Choibalsan]=Asia/Choibalsan,[Asia/Chongqing]=Asia/Chongqing,[Asia/Chungking]=Asia/Chungking,[Asia/Colombo]=Asia/Colombo,[Asia/Dacca]=Asia/Dacca,[Asia/Damascus]=Asia/Damascus,[Asia/Dhaka]=Asia/Dhaka,[Asia/Dili]=Asia/Dili,[Asia/Dubai]=Asia/Dubai,[Asia/Dushanbe]=Asia/Dushanbe,[Asia/Famagusta]=Asia/Famagusta,[Asia/Gaza]=Asia/Gaza,[Asia/Harbin]=Asia/Harbin,[Asia/Hebron]=Asia/Hebron,[Asia/Ho_Chi_Minh]=Asia/Ho_Chi_Minh,[Asia/Hong_Kong]=Asia/Hong_Kong,[Asia/Hovd]=Asia/Hovd,[Asia/Irkutsk]=Asia/Irkutsk,[Asia/Istanbul]=Asia/Istanbul,[Asia/Jakarta]=Asia/Jakarta,[Asia/Jayapura]=Asia/Jayapura,[Asia/Jerusalem]=Asia/Jerusalem,[Asia/Kabul]=Asia/Kabul,[Asia/Kamchatka]=Asia/Kamchatka,[Asia/Karachi]=Asia/Karachi,[Asia/Kashgar]=Asia/Kashgar,[Asia/Kathmandu]=Asia/Kathmandu,[Asia/Katmandu]=Asia/Katmandu,[Asia/Khandyga]=Asia/Khandyga,[Asia/Kolkata]=Asia/Kolkata,[Asia/Krasnoyarsk]=Asia/Krasnoyarsk,[Asia/Kuala_Lumpur]=Asia/Kuala_Lumpur,[Asia/Kuching]=Asia/Kuching,[Asia/Kuwait]=Asia/Kuwait,[Asia/Macao]=Asia/Macao,[Asia/Macau]=Asia/Macau,[Asia/Magadan]=Asia/Magadan,[Asia/Makassar]=Asia/Makassar,[Asia/Manila]=Asia/Manila,[Asia/Muscat]=Asia/Muscat,[Asia/Nicosia]=Asia/Nicosia,[Asia/Novokuznetsk]=Asia/Novokuznetsk,[Asia/Novosibirsk]=Asia/Novosibirsk,[Asia/Omsk]=Asia/Omsk,[Asia/Oral]=Asia/Oral,[Asia/Phnom_Penh]=Asia/Phnom_Penh,[Asia/Pontianak]=Asia/Pontianak,[Asia/Pyongyang]=Asia/Pyongyang,[Asia/Qatar]=Asia/Qatar,[Asia/Qostanay]=Asia/Qostanay,[Asia/Qyzylorda]=Asia/Qyzylorda,[Asia/Rangoon]=Asia/Rangoon,[Asia/Riyadh]=Asia/Riyadh,[Asia/Saigon]=Asia/Saigon,[Asia/Sakhalin]=Asia/Sakhalin,[Asia/Samarkand]=Asia/Samarkand,[Asia/Seoul]=Asia/Seoul,[Asia/Shanghai]=Asia/Shanghai,[Asia/Singapore]=Asia/Singapore,[Asia/Srednekolymsk]=Asia/Srednekolymsk,[Asia/Taipei]=Asia/Taipei,[Asia/Tashkent]=Asia/Tashkent,[Asia/Tbilisi]=Asia/Tbilisi,[Asia/Tehran]=Asia/Tehran,[Asia/Tel_Aviv]=Asia/Tel_Aviv,[Asia/Thimbu]=Asia/Thimbu,[Asia/Thimphu]=Asia/Thimphu,[Asia/Tokyo]=Asia/Tokyo,[Asia/Tomsk]=Asia/Tomsk,[Asia/Ujung_Pandang]=Asia/Ujung_Pandang,[Asia/Ulaanbaatar]=Asia/Ulaanbaatar,[Asia/Ulan_Bator]=Asia/Ulan_Bator,[Asia/Urumqi]=Asia/Urumqi,[Asia/Ust-Nera]=Asia/Ust-Nera,[Asia/Vientiane]=Asia/Vientiane,[Asia/Vladivostok]=Asia/Vladivostok,[Asia/Yakutsk]=Asia/Yakutsk,[Asia/Yangon]=Asia/Yangon,[Asia/Yekaterinburg]=Asia/Yekaterinburg,[Asia/Yerevan]=Asia/Yerevan,[Atlantic/Azores]=Atlantic/Azores,[Atlantic/Bermuda]=Atlantic/Bermuda,[Atlantic/Canary]=Atlantic/Canary,[Atlantic/Cape_Verde]=Atlantic/Cape_Verde,[Atlantic/Faeroe]=Atlantic/Faeroe,[Atlantic/Faroe]=Atlantic/Faroe,[Atlantic/Jan_Mayen]=Atlantic/Jan_Mayen,[Atlantic/Madeira]=Atlantic/Madeira,[Atlantic/Reykjavik]=Atlantic/Reykjavik,[Atlantic/South_Georgia]=Atlantic/South_Georgia,[Atlantic/St_Helena]=Atlantic/St_Helena,[Atlantic/Stanley]=Atlantic/Stanley,[Australia/ACT]=Australia/ACT,[Australia/Adelaide]=Australia/Adelaide,[Australia/Brisbane]=Australia/Brisbane,[Australia/Broken_Hill]=Australia/Broken_Hill,[Australia/Canberra]=Australia/Canberra,[Australia/Currie]=Australia/Currie,[Australia/Darwin]=Australia/Darwin,[Australia/Eucla]=Australia/Eucla,[Australia/Hobart]=Australia/Hobart,[Australia/LHI]=Australia/LHI,[Australia/Lindeman]=Australia/Lindeman,[Australia/Lord_Howe]=Australia/Lord_Howe,[Australia/Melbourne]=Australia/Melbourne,[Australia/NSW]=Australia/NSW,[Australia/North]=Australia/North,[Australia/Perth]=Australia/Perth,[Australia/Queensland]=Australia/Queensland,[Australia/South]=Australia/South,[Australia/Sydney]=Australia/Sydney,[Australia/Tasmania]=Australia/Tasmania,[Australia/Victoria]=Australia/Victoria,[Australia/West]=Australia/West,[Australia/Yancowinna]=Australia/Yancowinna,[Brazil/Acre]=Brazil/Acre,[Brazil/DeNoronha]=Brazil/DeNoronha,[Brazil/East]=Brazil/East,[Brazil/West]=Brazil/West,[CET]=CET,[CST6CDT]=CST6CDT,[Canada/Atlantic]=Canada/Atlantic,[Canada/Central]=Canada/Central,[Canada/Eastern]=Canada/Eastern,[Canada/Mountain]=Canada/Mountain,[Canada/Newfoundland]=Canada/Newfoundland,[Canada/Pacific]=Canada/Pacific,[Canada/Saskatchewan]=Canada/Saskatchewan,[Canada/Yukon]=Canada/Yukon,[Chile/Continental]=Chile/Continental,[Chile/EasterIsland]=Chile/EasterIsland,[Cuba]=Cuba,[EET]=EET,[EST]=EST,[EST5EDT]=EST5EDT,[Egypt]=Egypt,[Eire]=Eire,[Europe/Amsterdam]=Europe/Amsterdam,[Europe/Andorra]=Europe/Andorra,[Europe/Astrakhan]=Europe/Astrakhan,[Europe/Athens]=Europe/Athens,[Europe/Belfast]=Europe/Belfast,[Europe/Belgrade]=Europe/Belgrade,[Europe/Berlin]=Europe/Berlin,[Europe/Bratislava]=Europe/Bratislava,[Europe/Brussels]=Europe/Brussels,[Europe/Bucharest]=Europe/Bucharest,[Europe/Budapest]=Europe/Budapest,[Europe/Busingen]=Europe/Busingen,[Europe/Chisinau]=Europe/Chisinau,[Europe/Copenhagen]=Europe/Copenhagen,[Europe/Dublin]=Europe/Dublin,[Europe/Gibraltar]=Europe/Gibraltar,[Europe/Guernsey]=Europe/Guernsey,[Europe/Helsinki]=Europe/Helsinki,[Europe/Isle_of_Man]=Europe/Isle_of_Man,[Europe/Istanbul]=Europe/Istanbul,[Europe/Jersey]=Europe/Jersey,[Europe/Kaliningrad]=Europe/Kaliningrad,[Europe/Kiev]=Europe/Kiev,[Europe/Kirov]=Europe/Kirov,[Europe/Kyiv]=Europe/Kyiv,[Europe/Lisbon]=Europe/Lisbon,[Europe/Ljubljana]=Europe/Ljubljana,[Europe/London]=Europe/London,[Europe/Luxembourg]=Europe/Luxembourg,[Europe/Madrid]=Europe/Madrid,[Europe/Malta]=Europe/Malta,[Europe/Mariehamn]=Europe/Mariehamn,[Europe/Minsk]=Europe/Minsk,[Europe/Monaco]=Europe/Monaco,[Europe/Moscow]=Europe/Moscow,[Europe/Nicosia]=Europe/Nicosia,[Europe/Oslo]=Europe/Oslo,[Europe/Paris]=Europe/Paris,[Europe/Podgorica]=Europe/Podgorica,[Europe/Prague]=Europe/Prague,[Europe/Riga]=Europe/Riga,[Europe/Rome]=Europe/Rome,[Europe/Samara]=Europe/Samara,[Europe/San_Marino]=Europe/San_Marino,[Europe/Sarajevo]=Europe/Sarajevo,[Europe/Saratov]=Europe/Saratov,[Europe/Simferopol]=Europe/Simferopol,[Europe/Skopje]=Europe/Skopje,[Europe/Sofia]=Europe/Sofia,[Europe/Stockholm]=Europe/Stockholm,[Europe/Tallinn]=Europe/Tallinn,[Europe/Tirane]=Europe/Tirane,[Europe/Tiraspol]=Europe/Tiraspol,[Europe/Ulyanovsk]=Europe/Ulyanovsk,[Europe/Uzhgorod]=Europe/Uzhgorod,[Europe/Vaduz]=Europe/Vaduz,[Europe/Vatican]=Europe/Vatican,[Europe/Vienna]=Europe/Vienna,[Europe/Vilnius]=Europe/Vilnius,[Europe/Volgograd]=Europe/Volgograd,[Europe/Warsaw]=Europe/Warsaw,[Europe/Zagreb]=Europe/Zagreb,[Europe/Zaporozhye]=Europe/Zaporozhye,[Europe/Zurich]=Europe/Zurich,[GB]=GB,[GB-Eire]=GB-Eire,[GMT]=GMT,[GMT+0]=GMT+0,[GMT-0]=GMT-0,[GMT0]=GMT0,[Greenwich]=Greenwich,[HST]=HST,[Hongkong]=Hongkong,[Iceland]=Iceland,[Indian/Antananarivo]=Indian/Antananarivo,[Indian/Chagos]=Indian/Chagos,[Indian/Christmas]=Indian/Christmas,[Indian/Cocos]=Indian/Cocos,[Indian/Comoro]=Indian/Comoro,[Indian/Kerguelen]=Indian/Kerguelen,[Indian/Mahe]=Indian/Mahe,[Indian/Maldives]=Indian/Maldives,[Indian/Mauritius]=Indian/Mauritius,[Indian/Mayotte]=Indian/Mayotte,[Indian/Reunion]=Indian/Reunion,[Iran]=Iran,[Israel]=Israel,[Jamaica]=Jamaica,[Japan]=Japan,[Kwajalein]=Kwajalein,[Libya]=Libya,[MET]=MET,[MST]=MST,[MST7MDT]=MST7MDT,[Mexico/BajaNorte]=Mexico/BajaNorte,[Mexico/BajaSur]=Mexico/BajaSur,[Mexico/General]=Mexico/General,[NZ]=NZ,[NZ-CHAT]=NZ-CHAT,[Navajo]=Navajo,[PRC]=PRC,[PST8PDT]=PST8PDT,[Pacific/Apia]=Pacific/Apia,[Pacific/Auckland]=Pacific/Auckland,[Pacific/Bougainville]=Pacific/Bougainville,[Pacific/Chatham]=Pacific/Chatham,[Pacific/Chuuk]=Pacific/Chuuk,[Pacific/Easter]=Pacific/Easter,[Pacific/Efate]=Pacific/Efate,[Pacific/Enderbury]=Pacific/Enderbury,[Pacific/Fakaofo]=Pacific/Fakaofo,[Pacific/Fiji]=Pacific/Fiji,[Pacific/Funafuti]=Pacific/Funafuti,[Pacific/Galapagos]=Pacific/Galapagos,[Pacific/Gambier]=Pacific/Gambier,[Pacific/Guadalcanal]=Pacific/Guadalcanal,[Pacific/Guam]=Pacific/Guam,[Pacific/Honolulu]=Pacific/Honolulu,[Pacific/Johnston]=Pacific/Johnston,[Pacific/Kanton]=Pacific/Kanton,[Pacific/Kiritimati]=Pacific/Kiritimati,[Pacific/Kosrae]=Pacific/Kosrae,[Pacific/Kwajalein]=Pacific/Kwajalein,[Pacific/Majuro]=Pacific/Majuro,[Pacific/Marquesas]=Pacific/Marquesas,[Pacific/Midway]=Pacific/Midway,[Pacific/Nauru]=Pacific/Nauru,[Pacific/Niue]=Pacific/Niue,[Pacific/Norfolk]=Pacific/Norfolk,[Pacific/Noumea]=Pacific/Noumea,[Pacific/Pago_Pago]=Pacific/Pago_Pago,[Pacific/Palau]=Pacific/Palau,[Pacific/Pitcairn]=Pacific/Pitcairn,[Pacific/Pohnpei]=Pacific/Pohnpei,[Pacific/Ponape]=Pacific/Ponape,[Pacific/Port_Moresby]=Pacific/Port_Moresby,[Pacific/Rarotonga]=Pacific/Rarotonga,[Pacific/Saipan]=Pacific/Saipan,[Pacific/Samoa]=Pacific/Samoa,[Pacific/Tahiti]=Pacific/Tahiti,[Pacific/Tarawa]=Pacific/Tarawa,[Pacific/Tongatapu]=Pacific/Tongatapu,[Pacific/Truk]=Pacific/Truk,[Pacific/Wake]=Pacific/Wake,[Pacific/Wallis]=Pacific/Wallis,[Pacific/Yap]=Pacific/Yap,[Poland]=Poland,[Portugal]=Portugal,[ROC]=ROC,[ROK]=ROK,[Singapore]=Singapore,[Turkey]=Turkey,[UCT]=UCT,[US/Alaska]=US/Alaska,[US/Aleutian]=US/Aleutian,[US/Arizona]=US/Arizona,[US/Central]=US/Central,[US/East-Indiana]=US/East-Indiana,[US/Eastern]=US/Eastern,[US/Hawaii]=US/Hawaii,[US/Indiana-Starke]=US/Indiana-Starke,[US/Michigan]=US/Michigan,[US/Mountain]=US/Mountain,[US/Pacific]=US/Pacific,[US/Samoa]=US/Samoa,[UTC]=UTC,[Universal]=Universal,[W-SU]=W-SU,[WET]=WET,[Zulu]=Zulu,[Etc/GMT]=Etc/GMT,[Etc/GMT+0]=Etc/GMT+0,[Etc/GMT+1]=Etc/GMT+1,[Etc/GMT+10]=Etc/GMT+10,[Etc/GMT+11]=Etc/GMT+11,[Etc/GMT+12]=Etc/GMT+12,[Etc/GMT+2]=Etc/GMT+2,[Etc/GMT+3]=Etc/GMT+3,[Etc/GMT+4]=Etc/GMT+4,[Etc/GMT+5]=Etc/GMT+5,[Etc/GMT+6]=Etc/GMT+6,[Etc/GMT+7]=Etc/GMT+7,[Etc/GMT+8]=Etc/GMT+8,[Etc/GMT+9]=Etc/GMT+9,[Etc/GMT-0]=Etc/GMT-0,[Etc/GMT-1]=Etc/GMT-1,[Etc/GMT-10]=Etc/GMT-10,[Etc/GMT-11]=Etc/GMT-11,[Etc/GMT-12]=Etc/GMT-12,[Etc/GMT-13]=Etc/GMT-13,[Etc/GMT-14]=Etc/GMT-14,[Etc/GMT-2]=Etc/GMT-2,[Etc/GMT-3]=Etc/GMT-3,[Etc/GMT-4]=Etc/GMT-4,[Etc/GMT-5]=Etc/GMT-5,[Etc/GMT-6]=Etc/GMT-6,[Etc/GMT-7]=Etc/GMT-7,[Etc/GMT-8]=Etc/GMT-8,[Etc/GMT-9]=Etc/GMT-9,[Etc/GMT0]=Etc/GMT0,[Etc/Greenwich]=Etc/Greenwich,[Etc/UCT]=Etc/UCT,[Etc/UTC]=Etc/UTC,[Etc/Universal]=Etc/Universal,[Etc/Zulu]=Etc/Zulu</para>
        /// </summary>
        [JsonPropertyName("appointment_tz")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("appointment_tz")]
        public string AppointmentTz { get; set; }

        /// <summary>
        /// <para>Name: Location</para>
        /// <para>Internal: location_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("location_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("location_id")]
        public int? LocationId { get; set; }

        /// <summary>
        /// <para>Name: Location formatted</para>
        /// <para>Internal: location</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("location")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("location")]
        public string Location { get; set; }

        /// <summary>
        /// <para>Name: Videoconference Link</para>
        /// <para>Internal: event_videocall_source</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [discuss]=Odoo Discuss</para>
        /// </summary>
        [JsonPropertyName("event_videocall_source")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("event_videocall_source")]
        public string EventVideocallSource { get; set; }

        /// <summary>
        /// <para>Name: Allow Guests</para>
        /// <para>Internal: allow_guests</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("allow_guests")]
        [OdooField("allow_guests")]
        public bool AllowGuests { get; set; }

        /// <summary>
        /// <para>Name: Start Datetime</para>
        /// <para>Internal: start_datetime</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("start_datetime")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("start_datetime")]
        public DateTime? StartDatetime { get; set; }

        /// <summary>
        /// <para>Name: End Datetime</para>
        /// <para>Internal: end_datetime</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("end_datetime")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("end_datetime")]
        public DateTime? EndDatetime { get; set; }

        /// <summary>
        /// <para>Name: Booking Email</para>
        /// <para>Internal: booked_mail_template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.template</para>
        /// </summary>
        [JsonPropertyName("booked_mail_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("booked_mail_template_id")]
        public int? BookedMailTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Cancellation Email</para>
        /// <para>Internal: canceled_mail_template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.template</para>
        /// </summary>
        [JsonPropertyName("canceled_mail_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("canceled_mail_template_id")]
        public int? CanceledMailTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Assignment Method</para>
        /// <para>Internal: assign_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [resource_time]=Pick User/Resource then Time,[time_resource]=Select Time then User/Resource,[time_auto_assign]=Select Time then auto-assign</para>
        /// </summary>
        [JsonPropertyName("assign_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("assign_method")]
        public string AssignMethod { get; set; }

        /// <summary>
        /// <para>Name: Front-End Display</para>
        /// <para>Internal: avatars_display</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [hide]=No Picture,[show]=Show Pictures</para>
        /// </summary>
        [JsonPropertyName("avatars_display")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("avatars_display")]
        public string AvatarsDisplay { get; set; }

        /// <summary>
        /// <para>Name: Category</para>
        /// <para>Internal: category</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [recurring]=Regular,[punctual]=Punctual,[custom]=Specific Slots,[anytime]=Shared Calendar</para>
        /// </summary>
        [JsonPropertyName("category")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("category")]
        public string Category { get; set; }

        /// <summary>
        /// <para>Name: Displayed category time fields</para>
        /// <para>Internal: category_time_display</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [recurring_fields]=Available now,[punctual_fields]=Within a date range</para>
        /// </summary>
        [JsonPropertyName("category_time_display")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("category_time_display")]
        public string CategoryTimeDisplay { get; set; }

        /// <summary>
        /// <para>Name: Allowed Countries</para>
        /// <para>Internal: country_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("country_ids")]
        [OdooField("country_ids")]
        public List<int> CountryIds { get; set; }

        /// <summary>
        /// <para>Name: Confirmation Message</para>
        /// <para>Internal: message_confirmation</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("message_confirmation")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("message_confirmation")]
        public string MessageConfirmation { get; set; }

        /// <summary>
        /// <para>Name: Introduction Message</para>
        /// <para>Internal: message_intro</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("message_intro")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("message_intro")]
        public string MessageIntro { get; set; }

        /// <summary>
        /// <para>Name: Hide Duration</para>
        /// <para>Internal: hide_duration</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("hide_duration")]
        [OdooField("hide_duration")]
        public bool HideDuration { get; set; }

        /// <summary>
        /// <para>Name: Hide Time Zone</para>
        /// <para>Internal: hide_timezone</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("hide_timezone")]
        [OdooField("hide_timezone")]
        public bool HideTimezone { get; set; }

        /// <summary>
        /// <para>Name: Cancel Before (hours)</para>
        /// <para>Internal: min_cancellation_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("min_cancellation_hours")]
        [OdooField("min_cancellation_hours")]
        public double MinCancellationHours { get; set; }

        /// <summary>
        /// <para>Name: Schedule before (hours)</para>
        /// <para>Internal: min_schedule_hours</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("min_schedule_hours")]
        [OdooField("min_schedule_hours")]
        public double MinScheduleHours { get; set; }

        /// <summary>
        /// <para>Name: Schedule not after (days)</para>
        /// <para>Internal: max_schedule_days</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("max_schedule_days")]
        [OdooField("max_schedule_days")]
        public int MaxScheduleDays { get; set; }

        /// <summary>
        /// <para>Name: Questions</para>
        /// <para>Internal: question_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: appointment.question</para>
        /// </summary>
        [JsonPropertyName("question_ids")]
        [OdooField("question_ids")]
        public List<int> QuestionIds { get; set; }

        /// <summary>
        /// <para>Name: Reminders</para>
        /// <para>Internal: reminder_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: calendar.alarm</para>
        /// </summary>
        [JsonPropertyName("reminder_ids")]
        [OdooField("reminder_ids")]
        public List<int> ReminderIds { get; set; }

        /// <summary>
        /// <para>Name: Availability on</para>
        /// <para>Internal: schedule_based_on</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [users]=Users,[resources]=Resources (e.g. Tables, Courts, Rooms, ...)</para>
        /// </summary>
        [JsonPropertyName("schedule_based_on")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("schedule_based_on")]
        public string ScheduleBasedOn { get; set; }

        /// <summary>
        /// <para>Name: Availabilities</para>
        /// <para>Internal: slot_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: appointment.slot</para>
        /// </summary>
        [JsonPropertyName("slot_ids")]
        [OdooField("slot_ids")]
        public List<int> SlotIds { get; set; }

        /// <summary>
        /// <para>Name: Create a slot every</para>
        /// <para>Internal: slot_creation_interval</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("slot_creation_interval")]
        [OdooField("slot_creation_interval")]
        public double SlotCreationInterval { get; set; }

        /// <summary>
        /// <para>Name: Users</para>
        /// <para>Internal: staff_user_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("staff_user_ids")]
        [OdooField("staff_user_ids")]
        public List<int> StaffUserIds { get; set; }

        /// <summary>
        /// <para>Name: # Staff Users</para>
        /// <para>Internal: staff_user_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("staff_user_count")]
        [OdooField("staff_user_count")]
        public int StaffUserCount { get; set; }

        /// <summary>
        /// <para>Name: Resources</para>
        /// <para>Internal: resource_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: appointment.resource</para>
        /// </summary>
        [JsonPropertyName("resource_ids")]
        [OdooField("resource_ids")]
        public List<int> ResourceIds { get; set; }

        /// <summary>
        /// <para>Name: # Resources</para>
        /// <para>Internal: resource_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("resource_count")]
        [OdooField("resource_count")]
        public int ResourceCount { get; set; }

        /// <summary>
        /// <para>Name: Capacity Percentage</para>
        /// <para>Internal: resource_manual_confirmation_percentage</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("resource_manual_confirmation_percentage")]
        [OdooField("resource_manual_confirmation_percentage")]
        public double ResourceManualConfirmationPercentage { get; set; }

        /// <summary>
        /// <para>Name: Manage Capacities</para>
        /// <para>Internal: resource_manage_capacity</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("resource_manage_capacity")]
        [OdooField("resource_manage_capacity")]
        public bool ResourceManageCapacity { get; set; }

        /// <summary>
        /// <para>Name: Total Capacity</para>
        /// <para>Internal: resource_total_capacity</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("resource_total_capacity")]
        [OdooField("resource_total_capacity")]
        public int ResourceTotalCapacity { get; set; }

        /// <summary>
        /// <para>Name: # Appointments</para>
        /// <para>Internal: appointment_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("appointment_count")]
        [OdooField("appointment_count")]
        public int AppointmentCount { get; set; }

        /// <summary>
        /// <para>Name: # Appointments To Confirm</para>
        /// <para>Internal: appointment_count_request</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("appointment_count_request")]
        [OdooField("appointment_count_request")]
        public int AppointmentCountRequest { get; set; }

        /// <summary>
        /// <para>Name: # Upcoming Appointments</para>
        /// <para>Internal: appointment_count_upcoming</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("appointment_count_upcoming")]
        [OdooField("appointment_count_upcoming")]
        public int AppointmentCountUpcoming { get; set; }

        /// <summary>
        /// <para>Name: Invitation Links</para>
        /// <para>Internal: appointment_invite_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: appointment.invite</para>
        /// </summary>
        [JsonPropertyName("appointment_invite_ids")]
        [OdooField("appointment_invite_ids")]
        public List<int> AppointmentInviteIds { get; set; }

        /// <summary>
        /// <para>Name: # Invitation Links</para>
        /// <para>Internal: appointment_invite_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("appointment_invite_count")]
        [OdooField("appointment_invite_count")]
        public int AppointmentInviteCount { get; set; }

        /// <summary>
        /// <para>Name: Appointment Meetings</para>
        /// <para>Internal: meeting_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: calendar.event</para>
        /// </summary>
        [JsonPropertyName("meeting_ids")]
        [OdooField("meeting_ids")]
        public List<int> MeetingIds { get; set; }

        /// <summary>
        /// <para>Name: Connectors Displayed</para>
        /// <para>Internal: connectors_displayed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("connectors_displayed")]
        [OdooField("connectors_displayed")]
        public bool ConnectorsDisplayed { get; set; }

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
        /// <para>Name: Create Opportunities</para>
        /// <para>Internal: lead_create</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("lead_create")]
        [OdooField("lead_create")]
        public bool LeadCreate { get; set; }

        /// <summary>
        /// <para>Name: Leads/Opportunity</para>
        /// <para>Internal: lead_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: crm.lead</para>
        /// </summary>
        [JsonPropertyName("lead_ids")]
        [OdooField("lead_ids")]
        public List<int> LeadIds { get; set; }

        /// <summary>
        /// <para>Name: Leads Count</para>
        /// <para>Internal: lead_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("lead_count")]
        [OdooField("lead_count")]
        public int LeadCount { get; set; }

        /// <summary>
        /// <para>Name: Limit to Work Hours</para>
        /// <para>Internal: work_hours_activated</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("work_hours_activated")]
        [OdooField("work_hours_activated")]
        public bool WorkHoursActivated { get; set; }

        /// <summary>
        /// <para>Name: Up-front Payment</para>
        /// <para>Internal: has_payment_step</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_payment_step")]
        [OdooField("has_payment_step")]
        public bool HasPaymentStep { get; set; }

        /// <summary>
        /// <para>Name: Booking Product</para>
        /// <para>Internal: product_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.product</para>
        /// </summary>
        [JsonPropertyName("product_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("product_id")]
        public int? ProductId { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: product_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("product_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("product_currency_id")]
        public int? ProductCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Sales Price</para>
        /// <para>Internal: product_lst_price</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("product_lst_price")]
        [OdooField("product_lst_price")]
        public double ProductLstPrice { get; set; }

    }
}
