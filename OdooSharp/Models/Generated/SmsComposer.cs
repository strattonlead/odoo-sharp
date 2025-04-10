using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("sms.composer")]
    public partial class SmsComposer
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
        /// <para>Name: Composition Mode</para>
        /// <para>Internal: composition_mode</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [numbers]=Send to numbers,[comment]=Post on a document,[mass]=Send SMS in batch</para>
        /// </summary>
        [JsonPropertyName("composition_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("composition_mode")]
        public string CompositionMode { get; set; }

        /// <summary>
        /// <para>Name: Document Model Name</para>
        /// <para>Internal: res_model</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("res_model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_model")]
        public string ResModel { get; set; }

        /// <summary>
        /// <para>Name: Document Model Description</para>
        /// <para>Internal: res_model_description</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("res_model_description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_model_description")]
        public string ResModelDescription { get; set; }

        /// <summary>
        /// <para>Name: Document ID</para>
        /// <para>Internal: res_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("res_id")]
        [OdooField("res_id")]
        public int ResId { get; set; }

        /// <summary>
        /// <para>Name: Document IDs</para>
        /// <para>Internal: res_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("res_ids")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_ids")]
        public string ResIds { get; set; }

        /// <summary>
        /// <para>Name: Visible records count</para>
        /// <para>Internal: res_ids_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("res_ids_count")]
        [OdooField("res_ids_count")]
        public int ResIdsCount { get; set; }

        /// <summary>
        /// <para>Name: Single Mode</para>
        /// <para>Internal: comment_single_recipient</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("comment_single_recipient")]
        [OdooField("comment_single_recipient")]
        public bool CommentSingleRecipient { get; set; }

        /// <summary>
        /// <para>Name: Keep a note on document</para>
        /// <para>Internal: mass_keep_log</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("mass_keep_log")]
        [OdooField("mass_keep_log")]
        public bool MassKeepLog { get; set; }

        /// <summary>
        /// <para>Name: Send directly</para>
        /// <para>Internal: mass_force_send</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("mass_force_send")]
        [OdooField("mass_force_send")]
        public bool MassForceSend { get; set; }

        /// <summary>
        /// <para>Name: Use blacklist</para>
        /// <para>Internal: mass_use_blacklist</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("mass_use_blacklist")]
        [OdooField("mass_use_blacklist")]
        public bool MassUseBlacklist { get; set; }

        /// <summary>
        /// <para>Name: # Valid recipients</para>
        /// <para>Internal: recipient_valid_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("recipient_valid_count")]
        [OdooField("recipient_valid_count")]
        public int RecipientValidCount { get; set; }

        /// <summary>
        /// <para>Name: # Invalid recipients</para>
        /// <para>Internal: recipient_invalid_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("recipient_invalid_count")]
        [OdooField("recipient_invalid_count")]
        public int RecipientInvalidCount { get; set; }

        /// <summary>
        /// <para>Name: Recipients (Partners)</para>
        /// <para>Internal: recipient_single_description</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("recipient_single_description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("recipient_single_description")]
        public string RecipientSingleDescription { get; set; }

        /// <summary>
        /// <para>Name: Stored Recipient Number</para>
        /// <para>Internal: recipient_single_number</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("recipient_single_number")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("recipient_single_number")]
        public string RecipientSingleNumber { get; set; }

        /// <summary>
        /// <para>Name: Recipient Number</para>
        /// <para>Internal: recipient_single_number_itf</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("recipient_single_number_itf")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("recipient_single_number_itf")]
        public string RecipientSingleNumberItf { get; set; }

        /// <summary>
        /// <para>Name: Is valid</para>
        /// <para>Internal: recipient_single_valid</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("recipient_single_valid")]
        [OdooField("recipient_single_valid")]
        public bool RecipientSingleValid { get; set; }

        /// <summary>
        /// <para>Name: Number Field</para>
        /// <para>Internal: number_field_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("number_field_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("number_field_name")]
        public string NumberFieldName { get; set; }

        /// <summary>
        /// <para>Name: Recipients (Numbers)</para>
        /// <para>Internal: numbers</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("numbers")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("numbers")]
        public string Numbers { get; set; }

        /// <summary>
        /// <para>Name: Sanitized Number</para>
        /// <para>Internal: sanitized_numbers</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("sanitized_numbers")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sanitized_numbers")]
        public string SanitizedNumbers { get; set; }

        /// <summary>
        /// <para>Name: Use Template</para>
        /// <para>Internal: template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sms.template</para>
        /// </summary>
        [JsonPropertyName("template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("template_id")]
        public int? TemplateId { get; set; }

        /// <summary>
        /// <para>Name: Message</para>
        /// <para>Internal: body</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("body")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("body")]
        public string Body { get; set; }

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
