using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("sign.request.item")]
    public partial class SignRequestItem
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
        /// <para>Name: Portal Access URL</para>
        /// <para>Internal: access_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("access_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_url")]
        public string AccessUrl { get; set; }

        /// <summary>
        /// <para>Name: Security Token</para>
        /// <para>Internal: access_token</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("access_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>Name: Access warning</para>
        /// <para>Internal: access_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("access_warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_warning")]
        public string AccessWarning { get; set; }

        /// <summary>
        /// <para>Name: Signer</para>
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
        [OdooField("partner_id")]
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Signature Request</para>
        /// <para>Internal: sign_request_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sign.request</para>
        /// </summary>
        [JsonPropertyName("sign_request_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sign_request_id")]
        public int? SignRequestId { get; set; }

        /// <summary>
        /// <para>Name: Value</para>
        /// <para>Internal: sign_item_value_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: sign.request.item.value</para>
        /// </summary>
        [JsonPropertyName("sign_item_value_ids")]
        [OdooField("sign_item_value_ids")]
        public List<int> SignItemValueIds { get; set; }

        /// <summary>
        /// <para>Name: Document Name</para>
        /// <para>Internal: reference</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("reference")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// <para>Name: Mail Sent Order</para>
        /// <para>Internal: mail_sent_order</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("mail_sent_order")]
        [OdooField("mail_sent_order")]
        public int MailSentOrder { get; set; }

        /// <summary>
        /// <para>Name: Company used for communication</para>
        /// <para>Internal: communication_company_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("communication_company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("communication_company_id")]
        public int? CommunicationCompanyId { get; set; }

        /// <summary>
        /// <para>Name: Accessed Through Token</para>
        /// <para>Internal: access_via_link</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("access_via_link")]
        [OdooField("access_via_link")]
        public bool AccessViaLink { get; set; }

        /// <summary>
        /// <para>Name: Role</para>
        /// <para>Internal: role_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sign.item.role</para>
        /// </summary>
        [JsonPropertyName("role_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("role_id")]
        public int? RoleId { get; set; }

        /// <summary>
        /// <para>Name: Phone</para>
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
        /// <para>Name: SMS Token</para>
        /// <para>Internal: sms_token</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("sms_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sms_token")]
        public string SmsToken { get; set; }

        /// <summary>
        /// <para>Name: Signed Without Extra Authentication</para>
        /// <para>Internal: signed_without_extra_auth</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("signed_without_extra_auth")]
        [OdooField("signed_without_extra_auth")]
        public bool SignedWithoutExtraAuth { get; set; }

        /// <summary>
        /// <para>Name: Signature</para>
        /// <para>Internal: signature</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("signature")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("signature")]
        public byte[] Signature { get; set; }

        /// <summary>
        /// <para>Name: Frame Hash</para>
        /// <para>Internal: frame_hash</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("frame_hash")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("frame_hash")]
        public string FrameHash { get; set; }

        /// <summary>
        /// <para>Name: Signed on</para>
        /// <para>Internal: signing_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("signing_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("signing_date")]
        public DateTime? SigningDate { get; set; }

        /// <summary>
        /// <para>Name: State</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [sent]=To Sign,[completed]=Completed,[canceled]=Cancelled</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Color</para>
        /// <para>Internal: color</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("color")]
        [OdooField("color")]
        public int Color { get; set; }

        /// <summary>
        /// <para>Name: Email</para>
        /// <para>Internal: signer_email</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("signer_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("signer_email")]
        public string SignerEmail { get; set; }

        /// <summary>
        /// <para>Name: Is Mail Sent</para>
        /// <para>Internal: is_mail_sent</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_mail_sent")]
        [OdooField("is_mail_sent")]
        public bool IsMailSent { get; set; }

        /// <summary>
        /// <para>Name: Change Authorized</para>
        /// <para>Internal: change_authorized</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("change_authorized")]
        [OdooField("change_authorized")]
        public bool ChangeAuthorized { get; set; }

        /// <summary>
        /// <para>Name: Latitude</para>
        /// <para>Internal: latitude</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("latitude")]
        [OdooField("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// <para>Name: Longitude</para>
        /// <para>Internal: longitude</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("longitude")]
        [OdooField("longitude")]
        public double Longitude { get; set; }

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
