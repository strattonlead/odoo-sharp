using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("ir.profile")]
    public partial class IrProfile
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
        /// <para>Name: Creation Date</para>
        /// <para>Internal: create_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("create_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("create_date")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// <para>Name: Session</para>
        /// <para>Internal: session</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("session")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("session")]
        public string Session { get; set; }

        /// <summary>
        /// <para>Name: Description</para>
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
        /// <para>Name: Duration</para>
        /// <para>Internal: duration</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("duration")]
        [OdooField("duration")]
        public double Duration { get; set; }

        /// <summary>
        /// <para>Name: Initial stack trace</para>
        /// <para>Internal: init_stack_trace</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("init_stack_trace")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("init_stack_trace")]
        public string InitStackTrace { get; set; }

        /// <summary>
        /// <para>Name: Sql</para>
        /// <para>Internal: sql</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("sql")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sql")]
        public string Sql { get; set; }

        /// <summary>
        /// <para>Name: Queries Count</para>
        /// <para>Internal: sql_count</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sql_count")]
        [OdooField("sql_count")]
        public int SqlCount { get; set; }

        /// <summary>
        /// <para>Name: Traces Async</para>
        /// <para>Internal: traces_async</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("traces_async")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("traces_async")]
        public string TracesAsync { get; set; }

        /// <summary>
        /// <para>Name: Traces Sync</para>
        /// <para>Internal: traces_sync</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("traces_sync")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("traces_sync")]
        public string TracesSync { get; set; }

        /// <summary>
        /// <para>Name: Qweb</para>
        /// <para>Internal: qweb</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("qweb")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("qweb")]
        public string Qweb { get; set; }

        /// <summary>
        /// <para>Name: Entry count</para>
        /// <para>Internal: entry_count</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("entry_count")]
        [OdooField("entry_count")]
        public int EntryCount { get; set; }

        /// <summary>
        /// <para>Name: Speedscope</para>
        /// <para>Internal: speedscope</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("speedscope")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("speedscope")]
        public object Speedscope { get; set; }

        /// <summary>
        /// <para>Name: Open</para>
        /// <para>Internal: speedscope_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("speedscope_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("speedscope_url")]
        public string SpeedscopeUrl { get; set; }

    }
}
