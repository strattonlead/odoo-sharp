using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("mail.presence")]
    public partial class MailPresence
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
        /// <para>Name: Users</para>
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
        [OdooField("guest_id")]
        public int? GuestId { get; set; }

        /// <summary>
        /// <para>Name: Last Poll</para>
        /// <para>Internal: last_poll</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("last_poll")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("last_poll")]
        public DateTime? LastPoll { get; set; }

        /// <summary>
        /// <para>Name: Last Presence</para>
        /// <para>Internal: last_presence</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("last_presence")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("last_presence")]
        public DateTime? LastPresence { get; set; }

        /// <summary>
        /// <para>Name: IM Status</para>
        /// <para>Internal: status</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [online]=Online,[away]=Away,[offline]=Offline</para>
        /// </summary>
        [JsonPropertyName("status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("status")]
        public string Status { get; set; }

    }
}
