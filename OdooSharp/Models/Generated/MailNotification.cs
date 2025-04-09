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
        public int? ResPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Notification Type</para>
        /// <para>Internal: notification_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("notification_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string NotificationType { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: notification_status</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("notification_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public DateTime? ReadDate { get; set; }

        /// <summary>
        /// <para>Name: Failure type</para>
        /// <para>Internal: failure_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("failure_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int? LetterId { get; set; }

    }
}
