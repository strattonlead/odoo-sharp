using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("mail.activity.plan")]
    public partial class MailActivityPlan
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
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Activities</para>
        /// <para>Internal: template_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.activity.plan.template</para>
        /// </summary>
        [JsonPropertyName("template_ids")]
        [OdooField("template_ids")]
        public List<int> TemplateIds { get; set; }

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
        /// <para>Name: Applies to</para>
        /// <para>Internal: res_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("res_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("res_model_id")]
        public int? ResModelId { get; set; }

        /// <summary>
        /// <para>Name: Model</para>
        /// <para>Internal: res_model</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [account.account]=Account,[account.analytic.account]=Analytic Account,[appointment.type]=Appointment Type,[knowledge.article.thread]=Article Discussion Thread,[account.asset]=Asset/Revenue Recognition,[res.partner.bank]=Bank Accounts,[account.online.link]=Bank Connection,[account.bank.statement]=Bank Statement,[extract.mixin]=Base class to extract data from documents,[extract.mixin.with.words]=Base class to extract data from documents with OCRed words saved,[calendar.event]=Calendar Event,[res.company]=Companies,[res.partner]=Contact,[hr.department]=Department,[discuss.channel]=Discussion Channel,[documents.document]=Document,[mail.thread.cc]=Email CC management,[mail.thread]=Email Thread,[hr.employee]=Employee,[gamification.badge]=Gamification Badge,[gamification.challenge]=Gamification Challenge,[helpdesk.team]=Helpdesk Team,[helpdesk.ticket]=Helpdesk Ticket,[iap.account]=IAP Account,[hr.job]=Job Position,[account.journal]=Journal,[account.move]=Journal Entry,[knowledge.article]=Knowledge Article,[crm.lead]=Lead,[account.loan]=Loan,[x_logi_menu]=Logi Menü,[mail.blacklist]=Mail Blacklist,[mail.thread.blacklist]=Mail Blacklist mixin,[mail.thread.main.attachment]=Mail Main Attachment management,[account.payment]=Payments,[phone.blacklist]=Phone Blacklist,[mail.thread.phone]=Phone Blacklist Mixin,[account.reconcile.model]=Preset to create journal entries during a invoices and payments matching,[product.pricelist]=Pricelist,[product.template]=Product,[product.category]=Product Category,[product.product]=Product Variant,[purchase.order]=Purchase Order,[rating.mixin]=Rating Mixin,[sale.order]=Sales Order,[crm.team]=Sales Team,[crm.team.member]=Sales Team Member,[sign.request]=Signature Request,[spreadsheet.cell.thread]=Spreadsheet discussion thread,[studio.approval.rule]=Studio Approval Rule,[survey.survey]=Survey,[survey.user_input]=Survey User Input,[account.tax]=Tax</para>
        /// </summary>
        [JsonPropertyName("res_model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("res_model")]
        public string ResModel { get; set; }

        /// <summary>
        /// <para>Name: Steps Count</para>
        /// <para>Internal: steps_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("steps_count")]
        [OdooField("steps_count")]
        public int StepsCount { get; set; }

        /// <summary>
        /// <para>Name: Has on demand responsible</para>
        /// <para>Internal: has_user_on_demand</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_user_on_demand")]
        [OdooField("has_user_on_demand")]
        public bool HasUserOnDemand { get; set; }

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

        /// <summary>
        /// <para>Name: Department</para>
        /// <para>Internal: department_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.department</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("department_id")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// <para>Name: Department Assignable</para>
        /// <para>Internal: department_assignable</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("department_assignable")]
        [OdooField("department_assignable")]
        public bool DepartmentAssignable { get; set; }

    }
}
