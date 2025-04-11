using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("documents.document")]
    public partial class DocumentsDocument
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
        /// <para>Name: Spreadsheet file</para>
        /// <para>Internal: spreadsheet_binary_data</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("spreadsheet_binary_data")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("spreadsheet_binary_data")]
        public byte[] SpreadsheetBinaryData { get; set; }

        /// <summary>
        /// <para>Name: Spreadsheet Data</para>
        /// <para>Internal: spreadsheet_data</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("spreadsheet_data")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("spreadsheet_data")]
        public string SpreadsheetData { get; set; }

        /// <summary>
        /// <para>Name: Spreadsheet File Name</para>
        /// <para>Internal: spreadsheet_file_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("spreadsheet_file_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("spreadsheet_file_name")]
        public string SpreadsheetFileName { get; set; }

        /// <summary>
        /// <para>Name: Thumbnail</para>
        /// <para>Internal: thumbnail</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("thumbnail")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("thumbnail")]
        public byte[] Thumbnail { get; set; }

        /// <summary>
        /// <para>Name: Spreadsheet Snapshot</para>
        /// <para>Internal: spreadsheet_snapshot</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("spreadsheet_snapshot")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("spreadsheet_snapshot")]
        public byte[] SpreadsheetSnapshot { get; set; }

        /// <summary>
        /// <para>Name: Display Thumbnail</para>
        /// <para>Internal: display_thumbnail</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("display_thumbnail")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("display_thumbnail")]
        public byte[] DisplayThumbnail { get; set; }

        /// <summary>
        /// <para>Name: Spreadsheet Revision</para>
        /// <para>Internal: spreadsheet_revision_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: spreadsheet.revision</para>
        /// </summary>
        [JsonPropertyName("spreadsheet_revision_ids")]
        [OdooField("spreadsheet_revision_ids")]
        public List<int> SpreadsheetRevisionIds { get; set; }

        /// <summary>
        /// <para>Name: Current Revision Uuid</para>
        /// <para>Internal: current_revision_uuid</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("current_revision_uuid")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("current_revision_uuid")]
        public string CurrentRevisionUuid { get; set; }

        /// <summary>
        /// <para>Name: Alias</para>
        /// <para>Internal: alias_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.alias</para>
        /// </summary>
        [JsonPropertyName("alias_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_id")]
        public int? AliasId { get; set; }

        /// <summary>
        /// <para>Name: Alias Name</para>
        /// <para>Internal: alias_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>Name: Alias Domain</para>
        /// <para>Internal: alias_domain_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.alias.domain</para>
        /// </summary>
        [JsonPropertyName("alias_domain_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_domain_id")]
        public int? AliasDomainId { get; set; }

        /// <summary>
        /// <para>Name: Alias Domain Name</para>
        /// <para>Internal: alias_domain</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_domain")]
        public string AliasDomain { get; set; }

        /// <summary>
        /// <para>Name: Default Values</para>
        /// <para>Internal: alias_defaults</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("alias_defaults")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_defaults")]
        public string AliasDefaults { get; set; }

        /// <summary>
        /// <para>Name: Email Alias</para>
        /// <para>Internal: alias_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_email")]
        public string AliasEmail { get; set; }

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
        /// <para>Name: Attachment</para>
        /// <para>Internal: attachment_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("attachment_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("attachment_id")]
        public int? AttachmentId { get; set; }

        /// <summary>
        /// <para>Name: Attachment Name</para>
        /// <para>Internal: attachment_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("attachment_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("attachment_name")]
        public string AttachmentName { get; set; }

        /// <summary>
        /// <para>Name: Attachment Type</para>
        /// <para>Internal: attachment_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [url]=URL,[binary]=File</para>
        /// </summary>
        [JsonPropertyName("attachment_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("attachment_type")]
        public string AttachmentType { get; set; }

        /// <summary>
        /// <para>Name: Is Editable Attachment</para>
        /// <para>Internal: is_editable_attachment</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_editable_attachment")]
        [OdooField("is_editable_attachment")]
        public bool IsEditableAttachment { get; set; }

        /// <summary>
        /// <para>Name: Is considered multipage</para>
        /// <para>Internal: is_multipage</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_multipage")]
        [OdooField("is_multipage")]
        public bool IsMultipage { get; set; }

        /// <summary>
        /// <para>Name: File Content (base64)</para>
        /// <para>Internal: datas</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("datas")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("datas")]
        public byte[] Datas { get; set; }

        /// <summary>
        /// <para>Name: File Content (raw)</para>
        /// <para>Internal: raw</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("raw")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("raw")]
        public byte[] Raw { get; set; }

        /// <summary>
        /// <para>Name: File Extension</para>
        /// <para>Internal: file_extension</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("file_extension")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("file_extension")]
        public string FileExtension { get; set; }

        /// <summary>
        /// <para>Name: File Size</para>
        /// <para>Internal: file_size</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("file_size")]
        [OdooField("file_size")]
        public int FileSize { get; set; }

        /// <summary>
        /// <para>Name: Checksum/SHA1</para>
        /// <para>Internal: checksum</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("checksum")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("checksum")]
        public string Checksum { get; set; }

        /// <summary>
        /// <para>Name: Mime Type</para>
        /// <para>Internal: mimetype</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("mimetype")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// <para>Name: Resource Model</para>
        /// <para>Internal: res_model</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("res_model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_model")]
        public string ResModel { get; set; }

        /// <summary>
        /// <para>Name: Resource ID</para>
        /// <para>Internal: res_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Unknown</para>
        /// </summary>
        [JsonPropertyName("res_id")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("res_id")]
        public object ResId { get; set; }

        /// <summary>
        /// <para>Name: Resource Name</para>
        /// <para>Internal: res_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("res_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_name")]
        public string ResName { get; set; }

        /// <summary>
        /// <para>Name: Indexed Content</para>
        /// <para>Internal: index_content</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("index_content")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("index_content")]
        public string IndexContent { get; set; }

        /// <summary>
        /// <para>Name: Attachment Description</para>
        /// <para>Internal: description</para>
        /// <para>Store: no</para>
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
        /// <para>Name: History</para>
        /// <para>Internal: previous_attachment_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("previous_attachment_ids")]
        [OdooField("previous_attachment_ids")]
        public List<int> PreviousAttachmentIds { get; set; }

        /// <summary>
        /// <para>Name: Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
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
        /// <para>Name: Thumbnail Status</para>
        /// <para>Internal: thumbnail_status</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [present]=Present,[error]=Error,[client_generated]=Client Generated,[restricted]=Inaccessible</para>
        /// </summary>
        [JsonPropertyName("thumbnail_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("thumbnail_status")]
        public string ThumbnailStatus { get; set; }

        /// <summary>
        /// <para>Name: Link URL</para>
        /// <para>Internal: url</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("url")]
        public string Url { get; set; }

        /// <summary>
        /// <para>Name: URL Preview Image</para>
        /// <para>Internal: url_preview_image</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("url_preview_image")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("url_preview_image")]
        public string UrlPreviewImage { get; set; }

        /// <summary>
        /// <para>Name: Res Model Name</para>
        /// <para>Internal: res_model_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("res_model_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_model_name")]
        public string ResModelName { get; set; }

        /// <summary>
        /// <para>Name: Type</para>
        /// <para>Internal: type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [url]=URL,[binary]=File,[folder]=Folder</para>
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("type")]
        public string Type { get; set; }

        /// <summary>
        /// <para>Name: Source Document</para>
        /// <para>Internal: shortcut_document_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: documents.document</para>
        /// </summary>
        [JsonPropertyName("shortcut_document_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("shortcut_document_id")]
        public int? ShortcutDocumentId { get; set; }

        /// <summary>
        /// <para>Name: Source Document Owner</para>
        /// <para>Internal: shortcut_document_owner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("shortcut_document_owner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("shortcut_document_owner_id")]
        public int? ShortcutDocumentOwnerId { get; set; }

        /// <summary>
        /// <para>Name: Shortcut</para>
        /// <para>Internal: shortcut_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: documents.document</para>
        /// </summary>
        [JsonPropertyName("shortcut_ids")]
        [OdooField("shortcut_ids")]
        public List<int> ShortcutIds { get; set; }

        /// <summary>
        /// <para>Name: Favorite of</para>
        /// <para>Internal: favorited_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("favorited_ids")]
        [OdooField("favorited_ids")]
        public List<int> FavoritedIds { get; set; }

        /// <summary>
        /// <para>Name: Is Favorited</para>
        /// <para>Internal: is_favorited</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_favorited")]
        [OdooField("is_favorited")]
        public bool IsFavorited { get; set; }

        /// <summary>
        /// <para>Name: Tags</para>
        /// <para>Internal: tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: documents.tag</para>
        /// </summary>
        [JsonPropertyName("tag_ids")]
        [OdooField("tag_ids")]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// <para>Name: Contact</para>
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
        /// <para>Name: Owner</para>
        /// <para>Internal: owner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// <para>Name: Locked by</para>
        /// <para>Internal: lock_uid</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("lock_uid")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("lock_uid")]
        public int? LockUid { get; set; }

        /// <summary>
        /// <para>Name: Locked</para>
        /// <para>Internal: is_locked</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_locked")]
        [OdooField("is_locked")]
        public bool IsLocked { get; set; }

        /// <summary>
        /// <para>Name: Request Activity</para>
        /// <para>Internal: request_activity_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.activity</para>
        /// </summary>
        [JsonPropertyName("request_activity_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("request_activity_id")]
        public int? RequestActivityId { get; set; }

        /// <summary>
        /// <para>Name: Requestee Partner</para>
        /// <para>Internal: requestee_partner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("requestee_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("requestee_partner_id")]
        public int? RequesteePartnerId { get; set; }

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
        /// <para>Name: Document Token</para>
        /// <para>Internal: document_token</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("document_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("document_token")]
        public string DocumentToken { get; set; }

        /// <summary>
        /// <para>Name: Access Token</para>
        /// <para>Internal: access_token</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("access_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>Name: Access url</para>
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
        /// <para>Name: Link Access Hidden</para>
        /// <para>Internal: is_access_via_link_hidden</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_access_via_link_hidden")]
        [OdooField("is_access_via_link_hidden")]
        public bool IsAccessViaLinkHidden { get; set; }

        /// <summary>
        /// <para>Name: Link Access Rights</para>
        /// <para>Internal: access_via_link</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [view]=Viewer,[edit]=Editor,[none]=None</para>
        /// </summary>
        [JsonPropertyName("access_via_link")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_via_link")]
        public string AccessViaLink { get; set; }

        /// <summary>
        /// <para>Name: Internal Users Rights</para>
        /// <para>Internal: access_internal</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [view]=Viewer,[edit]=Editor,[none]=None</para>
        /// </summary>
        [JsonPropertyName("access_internal")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_internal")]
        public string AccessInternal { get; set; }

        /// <summary>
        /// <para>Name: Allowed Access</para>
        /// <para>Internal: access_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: documents.access</para>
        /// </summary>
        [JsonPropertyName("access_ids")]
        [OdooField("access_ids")]
        public List<int> AccessIds { get; set; }

        /// <summary>
        /// <para>Name: User permission</para>
        /// <para>Internal: user_permission</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [edit]=Editor,[view]=Viewer,[none]=None</para>
        /// </summary>
        [JsonPropertyName("user_permission")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("user_permission")]
        public string UserPermission { get; set; }

        /// <summary>
        /// <para>Name: Parent Path</para>
        /// <para>Internal: parent_path</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("parent_path")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("parent_path")]
        public string ParentPath { get; set; }

        /// <summary>
        /// <para>Name: Folder</para>
        /// <para>Internal: folder_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: documents.document</para>
        /// </summary>
        [JsonPropertyName("folder_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// <para>Name: Children</para>
        /// <para>Internal: children_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: documents.document</para>
        /// </summary>
        [JsonPropertyName("children_ids")]
        [OdooField("children_ids")]
        public List<int> ChildrenIds { get; set; }

        /// <summary>
        /// <para>Name: Deletion delay</para>
        /// <para>Internal: deletion_delay</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("deletion_delay")]
        [OdooField("deletion_delay")]
        public int DeletionDelay { get; set; }

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
        /// <para>Name: Pinned to Company roots</para>
        /// <para>Internal: is_company_root_folder</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_company_root_folder")]
        [OdooField("is_company_root_folder")]
        public bool IsCompanyRootFolder { get; set; }

        /// <summary>
        /// <para>Name: Document Count</para>
        /// <para>Internal: document_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("document_count")]
        [OdooField("document_count")]
        public int DocumentCount { get; set; }

        /// <summary>
        /// <para>Name: Create a new activity</para>
        /// <para>Internal: create_activity_option</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("create_activity_option")]
        [OdooField("create_activity_option")]
        public bool CreateActivityOption { get; set; }

        /// <summary>
        /// <para>Name: Activity type</para>
        /// <para>Internal: create_activity_type_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.activity.type</para>
        /// </summary>
        [JsonPropertyName("create_activity_type_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("create_activity_type_id")]
        public int? CreateActivityTypeId { get; set; }

        /// <summary>
        /// <para>Name: Summary</para>
        /// <para>Internal: create_activity_summary</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("create_activity_summary")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("create_activity_summary")]
        public string CreateActivitySummary { get; set; }

        /// <summary>
        /// <para>Name: Due Date In</para>
        /// <para>Internal: create_activity_date_deadline_range</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("create_activity_date_deadline_range")]
        [OdooField("create_activity_date_deadline_range")]
        public int CreateActivityDateDeadlineRange { get; set; }

        /// <summary>
        /// <para>Name: Due type</para>
        /// <para>Internal: create_activity_date_deadline_range_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [days]=Days,[weeks]=Weeks,[months]=Months</para>
        /// </summary>
        [JsonPropertyName("create_activity_date_deadline_range_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("create_activity_date_deadline_range_type")]
        public string CreateActivityDateDeadlineRangeType { get; set; }

        /// <summary>
        /// <para>Name: Note</para>
        /// <para>Internal: create_activity_note</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("create_activity_note")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("create_activity_note")]
        public string CreateActivityNote { get; set; }

        /// <summary>
        /// <para>Name: Responsible</para>
        /// <para>Internal: create_activity_user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("create_activity_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("create_activity_user_id")]
        public int? CreateActivityUserId { get; set; }

        /// <summary>
        /// <para>Name: Available Embedded Actions</para>
        /// <para>Internal: available_embedded_actions_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.embedded.actions</para>
        /// </summary>
        [JsonPropertyName("available_embedded_actions_ids")]
        [OdooField("available_embedded_actions_ids")]
        public List<int> AvailableEmbeddedActionsIds { get; set; }

        /// <summary>
        /// <para>Name: Alias Tags</para>
        /// <para>Internal: alias_tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: documents.tag</para>
        /// </summary>
        [JsonPropertyName("alias_tag_ids")]
        [OdooField("alias_tag_ids")]
        public List<int> AliasTagIds { get; set; }

        /// <summary>
        /// <para>Name: Last Accessed On</para>
        /// <para>Internal: last_access_date_group</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [0_older]=Older,[1_month]=This Month,[2_week]=This Week,[3_day]=Today</para>
        /// </summary>
        [JsonPropertyName("last_access_date_group")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("last_access_date_group")]
        public string LastAccessDateGroup { get; set; }

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
        /// <para>Name: Product</para>
        /// <para>Internal: product_template_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.template</para>
        /// </summary>
        [JsonPropertyName("product_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("product_template_id")]
        public int? ProductTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Product Variant</para>
        /// <para>Internal: product_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.product</para>
        /// </summary>
        [JsonPropertyName("product_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("product_id")]
        public int? ProductId { get; set; }

        /// <summary>
        /// <para>Name: Spreadsheet Thumbnail Checksum</para>
        /// <para>Internal: spreadsheet_thumbnail_checksum</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("spreadsheet_thumbnail_checksum")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("spreadsheet_thumbnail_checksum")]
        public string SpreadsheetThumbnailChecksum { get; set; }

        /// <summary>
        /// <para>Name: Excel Export</para>
        /// <para>Internal: excel_export</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("excel_export")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("excel_export")]
        public byte[] ExcelExport { get; set; }

        /// <summary>
        /// <para>Name: Handler</para>
        /// <para>Internal: handler</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [spreadsheet]=Spreadsheet,[frozen_folder]=Frozen Folder,[frozen_spreadsheet]=Frozen Spreadsheet</para>
        /// </summary>
        [JsonPropertyName("handler")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("handler")]
        public string Handler { get; set; }

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
        /// <para>Name: Has Embedded PDF</para>
        /// <para>Internal: has_embedded_pdf</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_embedded_pdf")]
        [OdooField("has_embedded_pdf")]
        public bool HasEmbeddedPdf { get; set; }

        /// <summary>
        /// <para>Name: Alias Email</para>
        /// <para>Internal: alias_full_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_full_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_full_name")]
        public string AliasFullName { get; set; }

        /// <summary>
        /// <para>Name: Aliased Model</para>
        /// <para>Internal: alias_model_id</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("alias_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_model_id")]
        public int? AliasModelId { get; set; }

        /// <summary>
        /// <para>Name: Record Thread ID</para>
        /// <para>Internal: alias_force_thread_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("alias_force_thread_id")]
        [OdooField("alias_force_thread_id")]
        public int AliasForceThreadId { get; set; }

        /// <summary>
        /// <para>Name: Parent Model</para>
        /// <para>Internal: alias_parent_model_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("alias_parent_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_parent_model_id")]
        public int? AliasParentModelId { get; set; }

        /// <summary>
        /// <para>Name: Parent Record Thread ID</para>
        /// <para>Internal: alias_parent_thread_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("alias_parent_thread_id")]
        [OdooField("alias_parent_thread_id")]
        public int AliasParentThreadId { get; set; }

        /// <summary>
        /// <para>Name: Alias Contact Security</para>
        /// <para>Internal: alias_contact</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [everyone]=Everyone,[partners]=Authenticated Partners,[followers]=Followers only,[employees]=Authenticated Employees</para>
        /// </summary>
        [JsonPropertyName("alias_contact")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_contact")]
        public string AliasContact { get; set; }

        /// <summary>
        /// <para>Name: Local-part based incoming detection</para>
        /// <para>Internal: alias_incoming_local</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("alias_incoming_local")]
        [OdooField("alias_incoming_local")]
        public bool AliasIncomingLocal { get; set; }

        /// <summary>
        /// <para>Name: Custom Bounced Message</para>
        /// <para>Internal: alias_bounced_content</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("alias_bounced_content")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_bounced_content")]
        public string AliasBouncedContent { get; set; }

        /// <summary>
        /// <para>Name: Alias Status</para>
        /// <para>Internal: alias_status</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_tested]=Not Tested,[valid]=Valid,[invalid]=Invalid</para>
        /// </summary>
        [JsonPropertyName("alias_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_status")]
        public string AliasStatus { get; set; }

    }
}
