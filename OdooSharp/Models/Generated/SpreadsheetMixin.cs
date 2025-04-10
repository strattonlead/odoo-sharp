using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("spreadsheet.mixin")]
    public partial class SpreadsheetMixin
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
        /// <para>Store: yes</para>
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

    }
}
