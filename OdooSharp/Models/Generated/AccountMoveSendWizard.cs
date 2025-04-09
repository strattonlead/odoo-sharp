using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.move.send.wizard")]
    public partial class AccountMoveSendWizard
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
        /// <para>Name: Language</para>
        /// <para>Internal: lang</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("lang")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Name: Rendering Model</para>
        /// <para>Internal: render_model</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("render_model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string RenderModel { get; set; }

        /// <summary>
        /// <para>Name: Subject</para>
        /// <para>Internal: subject</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("subject")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Subject { get; set; }

        /// <summary>
        /// <para>Name: Contents</para>
        /// <para>Internal: body</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("body")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Body { get; set; }

        /// <summary>
        /// <para>Name: Body content is the same as the template</para>
        /// <para>Internal: body_has_template_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("body_has_template_value")]
        public bool BodyHasTemplateValue { get; set; }

        /// <summary>
        /// <para>Name: Mail Template</para>
        /// <para>Internal: template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.template</para>
        /// </summary>
        [JsonPropertyName("template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? TemplateId { get; set; }

        /// <summary>
        /// <para>Name: Is Editor</para>
        /// <para>Internal: is_mail_template_editor</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_mail_template_editor")]
        public bool IsMailTemplateEditor { get; set; }

        /// <summary>
        /// <para>Name: Can Edit Body</para>
        /// <para>Internal: can_edit_body</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("can_edit_body")]
        public bool CanEditBody { get; set; }

        /// <summary>
        /// <para>Name: Move</para>
        /// <para>Internal: move_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("move_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? MoveId { get; set; }

        /// <summary>
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Alerts</para>
        /// <para>Internal: alerts</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("alerts")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        public object Alerts { get; set; }

        /// <summary>
        /// <para>Name: Sending Methods</para>
        /// <para>Internal: sending_methods</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("sending_methods")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        public object SendingMethods { get; set; }

        /// <summary>
        /// <para>Name: Sending Method Checkboxes</para>
        /// <para>Internal: sending_method_checkboxes</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("sending_method_checkboxes")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        public object SendingMethodCheckboxes { get; set; }

        /// <summary>
        /// <para>Name: Extra Edis</para>
        /// <para>Internal: extra_edis</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("extra_edis")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        public object ExtraEdis { get; set; }

        /// <summary>
        /// <para>Name: Extra Edi Checkboxes</para>
        /// <para>Internal: extra_edi_checkboxes</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("extra_edi_checkboxes")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        public object ExtraEdiCheckboxes { get; set; }

        /// <summary>
        /// <para>Name: Invoice Edi Format</para>
        /// <para>Internal: invoice_edi_format</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("invoice_edi_format")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string InvoiceEdiFormat { get; set; }

        /// <summary>
        /// <para>Name: Invoice report</para>
        /// <para>Internal: pdf_report_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.actions.report</para>
        /// </summary>
        [JsonPropertyName("pdf_report_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? PdfReportId { get; set; }

        /// <summary>
        /// <para>Name: Available Pdf Report</para>
        /// <para>Internal: available_pdf_report_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.actions.report</para>
        /// </summary>
        [JsonPropertyName("available_pdf_report_ids")]
        public List<int> AvailablePdfReportIds { get; set; }

        /// <summary>
        /// <para>Name: Display Pdf Report</para>
        /// <para>Internal: display_pdf_report_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_pdf_report_id")]
        public bool DisplayPdfReportId { get; set; }

        /// <summary>
        /// <para>Name: To</para>
        /// <para>Internal: mail_partner_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("mail_partner_ids")]
        public List<int> MailPartnerIds { get; set; }

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
        public object MailAttachmentsWidget { get; set; }

        /// <summary>
        /// <para>Name: Related Document Model</para>
        /// <para>Internal: model</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Model { get; set; }

        /// <summary>
        /// <para>Name: Related Document IDs</para>
        /// <para>Internal: res_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("res_ids")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ResIds { get; set; }

        /// <summary>
        /// <para>Name: Template Name</para>
        /// <para>Internal: template_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("template_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string TemplateName { get; set; }

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
