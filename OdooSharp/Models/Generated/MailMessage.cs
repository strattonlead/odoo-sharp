using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("mail.message")]
    public partial class MailMessage
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
        /// <para>Name: Subject</para>
        /// <para>Internal: subject</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("subject")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// <para>Name: Date</para>
        /// <para>Internal: date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// <para>Name: Contents</para>
        /// <para>Internal: body</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("body")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("body")]
        public string Body { get; set; }

        /// <summary>
        /// <para>Name: Preview</para>
        /// <para>Internal: preview</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("preview")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("preview")]
        public string Preview { get; set; }

        /// <summary>
        /// <para>Name: Link Previews</para>
        /// <para>Internal: link_preview_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.link.preview</para>
        /// </summary>
        [JsonPropertyName("link_preview_ids")]
        [OdooField("link_preview_ids")]
        public List<int> LinkPreviewIds { get; set; }

        /// <summary>
        /// <para>Name: Reactions</para>
        /// <para>Internal: reaction_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.message.reaction</para>
        /// </summary>
        [JsonPropertyName("reaction_ids")]
        [OdooField("reaction_ids")]
        public List<int> ReactionIds { get; set; }

        /// <summary>
        /// <para>Name: Attachments</para>
        /// <para>Internal: attachment_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("attachment_ids")]
        [OdooField("attachment_ids")]
        public List<int> AttachmentIds { get; set; }

        /// <summary>
        /// <para>Name: Parent Message</para>
        /// <para>Internal: parent_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("parent_id")]
        public int? ParentId { get; set; }

        /// <summary>
        /// <para>Name: Child Messages</para>
        /// <para>Internal: child_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("child_ids")]
        [OdooField("child_ids")]
        public List<int> ChildIds { get; set; }

        /// <summary>
        /// <para>Name: Related Document Model</para>
        /// <para>Internal: model</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("model")]
        public string Model { get; set; }

        /// <summary>
        /// <para>Name: Related Document ID</para>
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
        /// <para>Name: Message Record Name</para>
        /// <para>Internal: record_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("record_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("record_name")]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>Name: Alias Domain</para>
        /// <para>Internal: record_alias_domain_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.alias.domain</para>
        /// </summary>
        [JsonPropertyName("record_alias_domain_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("record_alias_domain_id")]
        public int? RecordAliasDomainId { get; set; }

        /// <summary>
        /// <para>Name: Company</para>
        /// <para>Internal: record_company_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("record_company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("record_company_id")]
        public int? RecordCompanyId { get; set; }

        /// <summary>
        /// <para>Name: Type</para>
        /// <para>Internal: message_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [email]=Incoming Email,[comment]=Comment,[email_outgoing]=Outgoing Email,[notification]=System notification,[auto_comment]=Automated Targeted Notification,[user_notification]=User Specific Notification,[sms]=SMS,[snailmail]=Snailmail</para>
        /// </summary>
        [JsonPropertyName("message_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("message_type")]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>Name: Subtype</para>
        /// <para>Internal: subtype_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.message.subtype</para>
        /// </summary>
        [JsonPropertyName("subtype_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("subtype_id")]
        public int? SubtypeId { get; set; }

        /// <summary>
        /// <para>Name: Mail Activity Type</para>
        /// <para>Internal: mail_activity_type_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.activity.type</para>
        /// </summary>
        [JsonPropertyName("mail_activity_type_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("mail_activity_type_id")]
        public int? MailActivityTypeId { get; set; }

        /// <summary>
        /// <para>Name: Employee Only</para>
        /// <para>Internal: is_internal</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_internal")]
        [OdooField("is_internal")]
        public bool IsInternal { get; set; }

        /// <summary>
        /// <para>Name: From</para>
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
        /// <para>Name: Author</para>
        /// <para>Internal: author_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("author_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("author_id")]
        public int? AuthorId { get; set; }

        /// <summary>
        /// <para>Name: Author's avatar</para>
        /// <para>Internal: author_avatar</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("author_avatar")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("author_avatar")]
        public byte[] AuthorAvatar { get; set; }

        /// <summary>
        /// <para>Name: Guest</para>
        /// <para>Internal: author_guest_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.guest</para>
        /// </summary>
        [JsonPropertyName("author_guest_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("author_guest_id")]
        public int? AuthorGuestId { get; set; }

        /// <summary>
        /// <para>Name: Is Current User Or Guest Author</para>
        /// <para>Internal: is_current_user_or_guest_author</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_current_user_or_guest_author")]
        [OdooField("is_current_user_or_guest_author")]
        public bool IsCurrentUserOrGuestAuthor { get; set; }

        /// <summary>
        /// <para>Name: Recipients</para>
        /// <para>Internal: partner_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_ids")]
        [OdooField("partner_ids")]
        public List<int> PartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Emails To</para>
        /// <para>Internal: incoming_email_to</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("incoming_email_to")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("incoming_email_to")]
        public string IncomingEmailTo { get; set; }

        /// <summary>
        /// <para>Name: Emails Cc</para>
        /// <para>Internal: incoming_email_cc</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("incoming_email_cc")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("incoming_email_cc")]
        public string IncomingEmailCc { get; set; }

        /// <summary>
        /// <para>Name: Partners with Need Action</para>
        /// <para>Internal: notified_partner_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("notified_partner_ids")]
        [OdooField("notified_partner_ids")]
        public List<int> NotifiedPartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Need Action</para>
        /// <para>Internal: needaction</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("needaction")]
        [OdooField("needaction")]
        public bool Needaction { get; set; }

        /// <summary>
        /// <para>Name: Has error</para>
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
        /// <para>Name: Notifications</para>
        /// <para>Internal: notification_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.notification</para>
        /// </summary>
        [JsonPropertyName("notification_ids")]
        [OdooField("notification_ids")]
        public List<int> NotificationIds { get; set; }

        /// <summary>
        /// <para>Name: Favorited By</para>
        /// <para>Internal: starred_partner_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("starred_partner_ids")]
        [OdooField("starred_partner_ids")]
        public List<int> StarredPartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Pinned</para>
        /// <para>Internal: pinned_at</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("pinned_at")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("pinned_at")]
        public DateTime? PinnedAt { get; set; }

        /// <summary>
        /// <para>Name: Starred</para>
        /// <para>Internal: starred</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("starred")]
        [OdooField("starred")]
        public bool Starred { get; set; }

        /// <summary>
        /// <para>Name: Tracking values</para>
        /// <para>Internal: tracking_value_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.tracking.value</para>
        /// </summary>
        [JsonPropertyName("tracking_value_ids")]
        [OdooField("tracking_value_ids")]
        public List<int> TrackingValueIds { get; set; }

        /// <summary>
        /// <para>Name: No threading for answers</para>
        /// <para>Internal: reply_to_force_new</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("reply_to_force_new")]
        [OdooField("reply_to_force_new")]
        public bool ReplyToForceNew { get; set; }

        /// <summary>
        /// <para>Name: Message-Id</para>
        /// <para>Internal: message_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>Name: Reply-To</para>
        /// <para>Internal: reply_to</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("reply_to")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("reply_to")]
        public string ReplyTo { get; set; }

        /// <summary>
        /// <para>Name: Outgoing mail server</para>
        /// <para>Internal: mail_server_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.mail_server</para>
        /// </summary>
        [JsonPropertyName("mail_server_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("mail_server_id")]
        public int? MailServerId { get; set; }

        /// <summary>
        /// <para>Name: Layout</para>
        /// <para>Internal: email_layout_xmlid</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email_layout_xmlid")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email_layout_xmlid")]
        public string EmailLayoutXmlid { get; set; }

        /// <summary>
        /// <para>Name: Email Add Signature</para>
        /// <para>Internal: email_add_signature</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("email_add_signature")]
        [OdooField("email_add_signature")]
        public bool EmailAddSignature { get; set; }

        /// <summary>
        /// <para>Name: Mails</para>
        /// <para>Internal: mail_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.mail</para>
        /// </summary>
        [JsonPropertyName("mail_ids")]
        [OdooField("mail_ids")]
        public List<int> MailIds { get; set; }

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
        /// <para>Name: Related ratings</para>
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
        /// <para>Name: Rating</para>
        /// <para>Internal: rating_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: rating.rating</para>
        /// </summary>
        [JsonPropertyName("rating_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("rating_id")]
        public int? RatingId { get; set; }

        /// <summary>
        /// <para>Name: Rating Value</para>
        /// <para>Internal: rating_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("rating_value")]
        [OdooField("rating_value")]
        public double RatingValue { get; set; }

        /// <summary>
        /// <para>Name: Has SMS error</para>
        /// <para>Internal: has_sms_error</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_sms_error")]
        [OdooField("has_sms_error")]
        public bool HasSmsError { get; set; }

        /// <summary>
        /// <para>Name: Snailmail message in error</para>
        /// <para>Internal: snailmail_error</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("snailmail_error")]
        [OdooField("snailmail_error")]
        public bool SnailmailError { get; set; }

        /// <summary>
        /// <para>Name: Letter</para>
        /// <para>Internal: letter_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: snailmail.letter</para>
        /// </summary>
        [JsonPropertyName("letter_ids")]
        [OdooField("letter_ids")]
        public List<int> LetterIds { get; set; }

        /// <summary>
        /// <para>Name: Description</para>
        /// <para>Internal: account_audit_log_preview</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("account_audit_log_preview")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_audit_log_preview")]
        public string AccountAuditLogPreview { get; set; }

        /// <summary>
        /// <para>Name: Journal Entry</para>
        /// <para>Internal: account_audit_log_move_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("account_audit_log_move_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_audit_log_move_id")]
        public int? AccountAuditLogMoveId { get; set; }

        /// <summary>
        /// <para>Name: Partner</para>
        /// <para>Internal: account_audit_log_partner_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("account_audit_log_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_audit_log_partner_id")]
        public int? AccountAuditLogPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Account</para>
        /// <para>Internal: account_audit_log_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_audit_log_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_audit_log_account_id")]
        public int? AccountAuditLogAccountId { get; set; }

        /// <summary>
        /// <para>Name: Tax</para>
        /// <para>Internal: account_audit_log_tax_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("account_audit_log_tax_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_audit_log_tax_id")]
        public int? AccountAuditLogTaxId { get; set; }

        /// <summary>
        /// <para>Name: Company </para>
        /// <para>Internal: account_audit_log_company_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("account_audit_log_company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_audit_log_company_id")]
        public int? AccountAuditLogCompanyId { get; set; }

        /// <summary>
        /// <para>Name: Audit Log Activated</para>
        /// <para>Internal: account_audit_log_activated</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("account_audit_log_activated")]
        [OdooField("account_audit_log_activated")]
        public bool AccountAuditLogActivated { get; set; }

    }
}
