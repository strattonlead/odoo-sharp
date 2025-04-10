using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("mail.notification")]
    public partial class MailNotification
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
        /// <para>Name: Message</para>
        /// <para>Internal: mail_message_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("mail_message_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("mail_message_id")]
        public int? MailMessageId { get; set; }

        /// <summary>
        /// <para>Name: Mail</para>
        /// <para>Internal: mail_mail_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.mail</para>
        /// </summary>
        [JsonPropertyName("mail_mail_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("mail_mail_id")]
        public int? MailMailId { get; set; }

        /// <summary>
        /// <para>Name: Recipient</para>
        /// <para>Internal: res_partner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("res_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("res_partner_id")]
        public int? ResPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Notification Type</para>
        /// <para>Internal: notification_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [inbox]=Inbox,[email]=Email,[sms]=SMS,[snail]=Snailmail</para>
        /// </summary>
        [JsonPropertyName("notification_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("notification_type")]
        public string NotificationType { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: notification_status</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [ready]=Ready to Send,[process]=Processing,[pending]=Sent,[sent]=Delivered,[bounce]=Bounced,[exception]=Exception,[canceled]=Cancelled</para>
        /// </summary>
        [JsonPropertyName("notification_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("notification_status")]
        public string NotificationStatus { get; set; }

        /// <summary>
        /// <para>Name: Is Read</para>
        /// <para>Internal: is_read</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_read")]
        [OdooField("is_read")]
        public bool IsRead { get; set; }

        /// <summary>
        /// <para>Name: Read Date</para>
        /// <para>Internal: read_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("read_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("read_date")]
        public DateTime? ReadDate { get; set; }

        /// <summary>
        /// <para>Name: Failure type</para>
        /// <para>Internal: failure_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [unknown]=Unknown error,[mail_bounce]=Bounce,[mail_email_invalid]=Invalid email address,[mail_email_missing]=Missing email address,[mail_from_invalid]=Invalid from address,[mail_from_missing]=Missing from address,[mail_smtp]=Connection failed (outgoing mail server problem),[sms_number_missing]=Missing Number,[sms_number_format]=Wrong Number Format,[sms_credit]=Insufficient Credit,[sms_country_not_supported]=Country Not Supported,[sms_registration_needed]=Country-specific Registration Required,[sms_server]=Server Error,[sms_acc]=Unregistered Account,[sms_expired]=Expired,[sms_invalid_destination]=Invalid Destination,[sms_not_allowed]=Not Allowed,[sms_not_delivered]=Not Delivered,[sms_rejected]=Rejected,[sn_credit]=Snailmail Credit Error,[sn_trial]=Snailmail Trial Error,[sn_price]=Snailmail No Price Available,[sn_fields]=Snailmail Missing Required Fields,[sn_format]=Snailmail Format Error,[sn_error]=Snailmail Unknown Error</para>
        /// </summary>
        [JsonPropertyName("failure_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("failure_type")]
        public string FailureType { get; set; }

        /// <summary>
        /// <para>Name: Failure reason</para>
        /// <para>Internal: failure_reason</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("failure_reason")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// <para>Name: SMS ID</para>
        /// <para>Internal: sms_id_int</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sms_id_int")]
        [OdooField("sms_id_int")]
        public int SmsIdInt { get; set; }

        /// <summary>
        /// <para>Name: SMS</para>
        /// <para>Internal: sms_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sms.sms</para>
        /// </summary>
        [JsonPropertyName("sms_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sms_id")]
        public int? SmsId { get; set; }

        /// <summary>
        /// <para>Name: SMS Trackers</para>
        /// <para>Internal: sms_tracker_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: sms.tracker</para>
        /// </summary>
        [JsonPropertyName("sms_tracker_ids")]
        [OdooField("sms_tracker_ids")]
        public List<int> SmsTrackerIds { get; set; }

        /// <summary>
        /// <para>Name: SMS Number</para>
        /// <para>Internal: sms_number</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("sms_number")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sms_number")]
        public string SmsNumber { get; set; }

        /// <summary>
        /// <para>Name: Snailmail Letter</para>
        /// <para>Internal: letter_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: snailmail.letter</para>
        /// </summary>
        [JsonPropertyName("letter_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("letter_id")]
        public int? LetterId { get; set; }

    }
}
