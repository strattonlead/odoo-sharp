using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.report.send")]
    public partial class AccountReportSend
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
        /// <para>Name: Partner</para>
        /// <para>Internal: partner_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_ids")]
        [OdooField("partner_ids")]
        public List<int> PartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Mode</para>
        /// <para>Internal: mode</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [single]=Single Recipient,[multi]=Multiple Recipients</para>
        /// </summary>
        [JsonPropertyName("mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// <para>Name: Enable Download</para>
        /// <para>Internal: enable_download</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("enable_download")]
        [OdooField("enable_download")]
        public bool EnableDownload { get; set; }

        /// <summary>
        /// <para>Name: Download</para>
        /// <para>Internal: checkbox_download</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("checkbox_download")]
        [OdooField("checkbox_download")]
        public bool CheckboxDownload { get; set; }

        /// <summary>
        /// <para>Name: Enable Send Mail</para>
        /// <para>Internal: enable_send_mail</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("enable_send_mail")]
        [OdooField("enable_send_mail")]
        public bool EnableSendMail { get; set; }

        /// <summary>
        /// <para>Name: Email</para>
        /// <para>Internal: checkbox_send_mail</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("checkbox_send_mail")]
        [OdooField("checkbox_send_mail")]
        public bool CheckboxSendMail { get; set; }

        /// <summary>
        /// <para>Name: Display Mail Composer</para>
        /// <para>Internal: display_mail_composer</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_mail_composer")]
        [OdooField("display_mail_composer")]
        public bool DisplayMailComposer { get; set; }

        /// <summary>
        /// <para>Name: Warnings</para>
        /// <para>Internal: warnings</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("warnings")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("warnings")]
        public object Warnings { get; set; }

        /// <summary>
        /// <para>Name: Send Mail Readonly</para>
        /// <para>Internal: send_mail_readonly</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("send_mail_readonly")]
        [OdooField("send_mail_readonly")]
        public bool SendMailReadonly { get; set; }

        /// <summary>
        /// <para>Name: Email template</para>
        /// <para>Internal: mail_template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.template</para>
        /// </summary>
        [JsonPropertyName("mail_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("mail_template_id")]
        public int? MailTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Report</para>
        /// <para>Internal: account_report_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.report</para>
        /// </summary>
        [JsonPropertyName("account_report_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_report_id")]
        public int? AccountReportId { get; set; }

        /// <summary>
        /// <para>Name: Report Options</para>
        /// <para>Internal: report_options</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("report_options")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("report_options")]
        public object ReportOptions { get; set; }

        /// <summary>
        /// <para>Name: Lang</para>
        /// <para>Internal: mail_lang</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("mail_lang")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("mail_lang")]
        public string MailLang { get; set; }

        /// <summary>
        /// <para>Name: Recipients</para>
        /// <para>Internal: mail_partner_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("mail_partner_ids")]
        [OdooField("mail_partner_ids")]
        public List<int> MailPartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Subject</para>
        /// <para>Internal: mail_subject</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("mail_subject")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("mail_subject")]
        public string MailSubject { get; set; }

        /// <summary>
        /// <para>Name: Contents</para>
        /// <para>Internal: mail_body</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("mail_body")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("mail_body")]
        public string MailBody { get; set; }

        /// <summary>
        /// <para>Name: Mail Attachments Widget</para>
        /// <para>Internal: mail_attachments_widget</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("mail_attachments_widget")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("mail_attachments_widget")]
        public object MailAttachmentsWidget { get; set; }

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
