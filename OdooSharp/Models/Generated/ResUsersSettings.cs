using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("res.users.settings")]
    public partial class ResUsersSettings
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
        /// <para>Name: User</para>
        /// <para>Internal: user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
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
        /// <para>Name: Home Menu Configuration</para>
        /// <para>Internal: homemenu_config</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("homemenu_config")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("homemenu_config")]
        public object HomemenuConfig { get; set; }

        /// <summary>
        /// <para>Name: Is discuss sidebar category channel open?</para>
        /// <para>Internal: is_discuss_sidebar_category_channel_open</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_discuss_sidebar_category_channel_open")]
        [OdooField("is_discuss_sidebar_category_channel_open")]
        public bool IsDiscussSidebarCategoryChannelOpen { get; set; }

        /// <summary>
        /// <para>Name: Is discuss sidebar category chat open?</para>
        /// <para>Internal: is_discuss_sidebar_category_chat_open</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_discuss_sidebar_category_chat_open")]
        [OdooField("is_discuss_sidebar_category_chat_open")]
        public bool IsDiscussSidebarCategoryChatOpen { get; set; }

        /// <summary>
        /// <para>Name: Push-To-Talk shortcut</para>
        /// <para>Internal: push_to_talk_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("push_to_talk_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("push_to_talk_key")]
        public string PushToTalkKey { get; set; }

        /// <summary>
        /// <para>Name: Use the push to talk feature</para>
        /// <para>Internal: use_push_to_talk</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_push_to_talk")]
        [OdooField("use_push_to_talk")]
        public bool UsePushToTalk { get; set; }

        /// <summary>
        /// <para>Name: Duration of voice activity in ms</para>
        /// <para>Internal: voice_active_duration</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("voice_active_duration")]
        [OdooField("voice_active_duration")]
        public int VoiceActiveDuration { get; set; }

        /// <summary>
        /// <para>Name: Volumes of other partners</para>
        /// <para>Internal: volume_settings_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.users.settings.volumes</para>
        /// </summary>
        [JsonPropertyName("volume_settings_ids")]
        [OdooField("volume_settings_ids")]
        public List<int> VolumeSettingsIds { get; set; }

        /// <summary>
        /// <para>Name: Channel Notifications</para>
        /// <para>Internal: channel_notifications</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [all]=All Messages,[no_notif]=Nothing</para>
        /// </summary>
        [JsonPropertyName("channel_notifications")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("channel_notifications")]
        public string ChannelNotifications { get; set; }

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
        [OdooField("mute_until_dt")]
        public DateTime? MuteUntilDt { get; set; }

        /// <summary>
        /// <para>Name: Calendar Default Privacy</para>
        /// <para>Internal: calendar_default_privacy</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [public]=Public,[private]=Private,[confidential]=Only internal users</para>
        /// </summary>
        [JsonPropertyName("calendar_default_privacy")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("calendar_default_privacy")]
        public string CalendarDefaultPrivacy { get; set; }

    }
}
