using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("res.lang")]
    public partial class ResLang
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
        /// <para>Name: Name</para>
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
        /// <para>Name: Locale Code</para>
        /// <para>Internal: code</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("code")]
        public string Code { get; set; }

        /// <summary>
        /// <para>Name: ISO code</para>
        /// <para>Internal: iso_code</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("iso_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("iso_code")]
        public string IsoCode { get; set; }

        /// <summary>
        /// <para>Name: URL Code</para>
        /// <para>Internal: url_code</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("url_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("url_code")]
        public string UrlCode { get; set; }

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
        /// <para>Name: Direction</para>
        /// <para>Internal: direction</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [ltr]=Left-to-Right,[rtl]=Right-to-Left</para>
        /// </summary>
        [JsonPropertyName("direction")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Name: Date Format</para>
        /// <para>Internal: date_format</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("date_format")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("date_format")]
        public string DateFormat { get; set; }

        /// <summary>
        /// <para>Name: Time Format</para>
        /// <para>Internal: time_format</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("time_format")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("time_format")]
        public string TimeFormat { get; set; }

        /// <summary>
        /// <para>Name: Short Time Format</para>
        /// <para>Internal: short_time_format</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("short_time_format")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("short_time_format")]
        public string ShortTimeFormat { get; set; }

        /// <summary>
        /// <para>Name: First Day of Week</para>
        /// <para>Internal: week_start</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [1]=Monday,[2]=Tuesday,[3]=Wednesday,[4]=Thursday,[5]=Friday,[6]=Saturday,[7]=Sunday</para>
        /// </summary>
        [JsonPropertyName("week_start")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("week_start")]
        public string WeekStart { get; set; }

        /// <summary>
        /// <para>Name: Separator Format</para>
        /// <para>Internal: grouping</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("grouping")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("grouping")]
        public string Grouping { get; set; }

        /// <summary>
        /// <para>Name: Decimal Separator</para>
        /// <para>Internal: decimal_point</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("decimal_point")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("decimal_point")]
        public string DecimalPoint { get; set; }

        /// <summary>
        /// <para>Name: Thousands Separator</para>
        /// <para>Internal: thousands_sep</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("thousands_sep")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("thousands_sep")]
        public string ThousandsSep { get; set; }

        /// <summary>
        /// <para>Name: Image</para>
        /// <para>Internal: flag_image</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("flag_image")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("flag_image")]
        public byte[] FlagImage { get; set; }

        /// <summary>
        /// <para>Name: Flag Image Url</para>
        /// <para>Internal: flag_image_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("flag_image_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("flag_image_url")]
        public string FlagImageUrl { get; set; }

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

    }
}
