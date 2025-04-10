using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("website.page_options.mixin")]
    public partial class WebsitePageOptionsMixin
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
        /// <para>Name: Header Visible</para>
        /// <para>Internal: header_visible</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("header_visible")]
        [OdooField("header_visible")]
        public bool HeaderVisible { get; set; }

        /// <summary>
        /// <para>Name: Footer Visible</para>
        /// <para>Internal: footer_visible</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("footer_visible")]
        [OdooField("footer_visible")]
        public bool FooterVisible { get; set; }

        /// <summary>
        /// <para>Name: Header Overlay</para>
        /// <para>Internal: header_overlay</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("header_overlay")]
        [OdooField("header_overlay")]
        public bool HeaderOverlay { get; set; }

        /// <summary>
        /// <para>Name: Header Color</para>
        /// <para>Internal: header_color</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("header_color")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("header_color")]
        public string HeaderColor { get; set; }

        /// <summary>
        /// <para>Name: Header Text Color</para>
        /// <para>Internal: header_text_color</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("header_text_color")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("header_text_color")]
        public string HeaderTextColor { get; set; }

    }
}
