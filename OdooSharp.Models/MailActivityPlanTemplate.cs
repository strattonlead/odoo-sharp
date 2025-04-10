using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("mail.activity.plan.template")]
    public partial class MailActivityPlanTemplate
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
        /// <para>Name: Plan</para>
        /// <para>Internal: plan_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.activity.plan</para>
        /// </summary>
        [JsonPropertyName("plan_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("plan_id")]
        public int? PlanId { get; set; }

        /// <summary>
        /// <para>Name: Model</para>
        /// <para>Internal: res_model</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [account.account]=Account,[account.analytic.account]=Analytic Account,[appointment.type]=Appointment Type,[knowledge.article.thread]=Article Discussion Thread,[account.asset]=Asset/Revenue Recognition,[res.partner.bank]=Bank Accounts,[account.online.link]=Bank Connection,[account.bank.statement]=Bank Statement,[extract.mixin]=Base class to extract data from documents,[extract.mixin.with.words]=Base class to extract data from documents with OCRed words saved,[calendar.event]=Calendar Event,[res.company]=Companies,[res.partner]=Contact,[hr.department]=Department,[discuss.channel]=Discussion Channel,[mail.thread.cc]=Email CC management,[mail.thread]=Email Thread,[hr.employee]=Employee,[gamification.badge]=Gamification Badge,[gamification.challenge]=Gamification Challenge,[helpdesk.team]=Helpdesk Team,[helpdesk.ticket]=Helpdesk Ticket,[iap.account]=IAP Account,[hr.job]=Job Position,[account.journal]=Journal,[account.move]=Journal Entry,[knowledge.article]=Knowledge Article,[crm.lead]=Lead,[account.loan]=Loan,[x_logi_menu]=Logi Menü,[mail.blacklist]=Mail Blacklist,[mail.thread.blacklist]=Mail Blacklist mixin,[mail.thread.main.attachment]=Mail Main Attachment management,[account.payment]=Payments,[phone.blacklist]=Phone Blacklist,[mail.thread.phone]=Phone Blacklist Mixin,[account.reconcile.model]=Preset to create journal entries during a invoices and payments matching,[product.pricelist]=Pricelist,[product.template]=Product,[product.category]=Product Category,[product.product]=Product Variant,[purchase.order]=Purchase Order,[rating.mixin]=Rating Mixin,[sale.order]=Sales Order,[crm.team]=Sales Team,[crm.team.member]=Sales Team Member,[sign.request]=Signature Request,[spreadsheet.cell.thread]=Spreadsheet discussion thread,[studio.approval.rule]=Studio Approval Rule,[survey.survey]=Survey,[survey.user_input]=Survey User Input,[account.tax]=Tax</para>
        /// </summary>
        [JsonPropertyName("res_model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_model")]
        public string ResModel { get; set; }

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
        [OdooField("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Sequence</para>
        /// <para>Internal: sequence</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sequence")]
        [OdooField("sequence")]
        public int Sequence { get; set; }

        /// <summary>
        /// <para>Name: Activity Type</para>
        /// <para>Internal: activity_type_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.activity.type</para>
        /// </summary>
        [JsonPropertyName("activity_type_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("activity_type_id")]
        public int? ActivityTypeId { get; set; }

        /// <summary>
        /// <para>Name: Interval</para>
        /// <para>Internal: delay_count</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("delay_count")]
        [OdooField("delay_count")]
        public int DelayCount { get; set; }

        /// <summary>
        /// <para>Name: Delay units</para>
        /// <para>Internal: delay_unit</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [days]=days,[weeks]=weeks,[months]=months</para>
        /// </summary>
        [JsonPropertyName("delay_unit")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("delay_unit")]
        public string DelayUnit { get; set; }

        /// <summary>
        /// <para>Name: Trigger</para>
        /// <para>Internal: delay_from</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [before_plan_date]=Before Plan Date,[after_plan_date]=After Plan Date</para>
        /// </summary>
        [JsonPropertyName("delay_from")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("delay_from")]
        public string DelayFrom { get; set; }

        /// <summary>
        /// <para>Name: Icon</para>
        /// <para>Internal: icon</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("icon")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// <para>Name: Summary</para>
        /// <para>Internal: summary</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("summary")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// <para>Name: Assignment</para>
        /// <para>Internal: responsible_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [on_demand]=Ask at launch,[other]=Default user,[coach]=Coach,[manager]=Manager,[employee]=Employee</para>
        /// </summary>
        [JsonPropertyName("responsible_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("responsible_type")]
        public string ResponsibleType { get; set; }

        /// <summary>
        /// <para>Name: Assigned to</para>
        /// <para>Internal: responsible_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("responsible_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("responsible_id")]
        public int? ResponsibleId { get; set; }

        /// <summary>
        /// <para>Name: Note</para>
        /// <para>Internal: note</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("note")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("note")]
        public string Note { get; set; }

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
