using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("discuss.channel.member")]
    public partial class DiscussChannelMember
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
        /// <para>Name: Partner</para>
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
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Guest</para>
        /// <para>Internal: guest_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.guest</para>
        /// </summary>
        [JsonPropertyName("guest_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? GuestId { get; set; }

        /// <summary>
        /// <para>Name: Is Self</para>
        /// <para>Internal: is_self</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_self")]
        public bool IsSelf { get; set; }

        /// <summary>
        /// <para>Name: Channel</para>
        /// <para>Internal: channel_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: discuss.channel</para>
        /// </summary>
        [JsonPropertyName("channel_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ChannelId { get; set; }

        /// <summary>
        /// <para>Name: Custom channel name</para>
        /// <para>Internal: custom_channel_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("custom_channel_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string CustomChannelName { get; set; }

        /// <summary>
        /// <para>Name: Last Fetched</para>
        /// <para>Internal: fetched_message_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("fetched_message_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? FetchedMessageId { get; set; }

        /// <summary>
        /// <para>Name: Last Seen</para>
        /// <para>Internal: seen_message_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("seen_message_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SeenMessageId { get; set; }

        /// <summary>
        /// <para>Name: New Message Separator</para>
        /// <para>Internal: new_message_separator</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("new_message_separator")]
        public int NewMessageSeparator { get; set; }

        /// <summary>
        /// <para>Name: Unread Messages Counter</para>
        /// <para>Internal: message_unread_counter</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_unread_counter")]
        public int MessageUnreadCounter { get; set; }

        /// <summary>
        /// <para>Name: Customized Notifications</para>
        /// <para>Internal: custom_notifications</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("custom_notifications")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string CustomNotifications { get; set; }

        /// <summary>
        /// <para>Name: Mute notifications until</para>
        /// <para>Internal: mute_until_dt</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("mute_until_dt")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? MuteUntilDt { get; set; }

        /// <summary>
        /// <para>Name: Is pinned on the interface</para>
        /// <para>Internal: is_pinned</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_pinned")]
        public bool IsPinned { get; set; }

        /// <summary>
        /// <para>Name: Unpin date</para>
        /// <para>Internal: unpin_dt</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("unpin_dt")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? UnpinDt { get; set; }

        /// <summary>
        /// <para>Name: Last Interest</para>
        /// <para>Internal: last_interest_dt</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("last_interest_dt")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? LastInterestDt { get; set; }

        /// <summary>
        /// <para>Name: Last seen date</para>
        /// <para>Internal: last_seen_dt</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("last_seen_dt")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? LastSeenDt { get; set; }

        /// <summary>
        /// <para>Name: RTC Sessions</para>
        /// <para>Internal: rtc_session_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: discuss.channel.rtc.session</para>
        /// </summary>
        [JsonPropertyName("rtc_session_ids")]
        public List<int> RtcSessionIds { get; set; }

        /// <summary>
        /// <para>Name: Ringing session</para>
        /// <para>Internal: rtc_inviting_session_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: discuss.channel.rtc.session</para>
        /// </summary>
        [JsonPropertyName("rtc_inviting_session_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? RtcInvitingSessionId { get; set; }

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
        public DateTime? WriteDate { get; set; }

    }
}
