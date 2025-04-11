using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("ir.actions.server")]
    public partial class IrActionsServer
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
        /// <para>Name: Action Name</para>
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
        /// <para>Name: Action Type</para>
        /// <para>Internal: type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("type")]
        public string Type { get; set; }

        /// <summary>
        /// <para>Name: External ID</para>
        /// <para>Internal: xml_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("xml_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("xml_id")]
        public string XmlId { get; set; }

        /// <summary>
        /// <para>Name: Path to show in the URL</para>
        /// <para>Internal: path</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("path")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("path")]
        public string Path { get; set; }

        /// <summary>
        /// <para>Name: Action Description</para>
        /// <para>Internal: help</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("help")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("help")]
        public string Help { get; set; }

        /// <summary>
        /// <para>Name: Binding Model</para>
        /// <para>Internal: binding_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("binding_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("binding_model_id")]
        public int? BindingModelId { get; set; }

        /// <summary>
        /// <para>Name: Binding Type</para>
        /// <para>Internal: binding_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [action]=Action,[report]=Report</para>
        /// </summary>
        [JsonPropertyName("binding_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("binding_type")]
        public string BindingType { get; set; }

        /// <summary>
        /// <para>Name: Binding View Types</para>
        /// <para>Internal: binding_view_types</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("binding_view_types")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("binding_view_types")]
        public string BindingViewTypes { get; set; }

        /// <summary>
        /// <para>Name: Invisible attribute</para>
        /// <para>Internal: binding_invisible</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("binding_invisible")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("binding_invisible")]
        public string BindingInvisible { get; set; }

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
        /// <para>Name: Automated Name</para>
        /// <para>Internal: automated_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("automated_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("automated_name")]
        public string AutomatedName { get; set; }

        /// <summary>
        /// <para>Name: Usage</para>
        /// <para>Internal: usage</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [ir_actions_server]=Server Action,[ir_cron]=Scheduled Action,[base_automation]=Automation Rule</para>
        /// </summary>
        [JsonPropertyName("usage")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("usage")]
        public string Usage { get; set; }

        /// <summary>
        /// <para>Name: Type</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [object_write]=Update Record,[next_activity]=Create Activity,[mail_post]=Send Email,[sms]=Send SMS,[followers]=Add Followers,[remove_followers]=Remove Followers,[object_create]=Create Record,[code]=Execute Code,[webhook]=Send Webhook Notification,[multi]=Multi Actions</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

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
        /// <para>Name: Model</para>
        /// <para>Internal: model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("model_id")]
        public int? ModelId { get; set; }

        /// <summary>
        /// <para>Name: Available Models</para>
        /// <para>Internal: available_model_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("available_model_ids")]
        [OdooField("available_model_ids")]
        public List<int> AvailableModelIds { get; set; }

        /// <summary>
        /// <para>Name: Model Name</para>
        /// <para>Internal: model_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("model_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Name: Warning</para>
        /// <para>Internal: warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("warning")]
        public string Warning { get; set; }

        /// <summary>
        /// <para>Name: Python Code</para>
        /// <para>Internal: code</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("code")]
        public string Code { get; set; }

        /// <summary>
        /// <para>Name: Parent Action</para>
        /// <para>Internal: parent_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.actions.server</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("parent_id")]
        public int? ParentId { get; set; }

        /// <summary>
        /// <para>Name: Child Actions</para>
        /// <para>Internal: child_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.actions.server</para>
        /// </summary>
        [JsonPropertyName("child_ids")]
        [OdooField("child_ids")]
        public List<int> ChildIds { get; set; }

        /// <summary>
        /// <para>Name: Record to Create</para>
        /// <para>Internal: crud_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("crud_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("crud_model_id")]
        public int? CrudModelId { get; set; }

        /// <summary>
        /// <para>Name: Target Model Name</para>
        /// <para>Internal: crud_model_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("crud_model_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("crud_model_name")]
        public string CrudModelName { get; set; }

        /// <summary>
        /// <para>Name: Link Field</para>
        /// <para>Internal: link_field_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("link_field_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("link_field_id")]
        public int? LinkFieldId { get; set; }

        /// <summary>
        /// <para>Name: Allowed Groups</para>
        /// <para>Internal: group_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.groups</para>
        /// </summary>
        [JsonPropertyName("group_ids")]
        [OdooField("group_ids")]
        public List<int> GroupIds { get; set; }

        /// <summary>
        /// <para>Name: Field to Update</para>
        /// <para>Internal: update_field_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("update_field_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("update_field_id")]
        public int? UpdateFieldId { get; set; }

        /// <summary>
        /// <para>Name: Field to Update Path</para>
        /// <para>Internal: update_path</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("update_path")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("update_path")]
        public string UpdatePath { get; set; }

        /// <summary>
        /// <para>Name: Update Related Model</para>
        /// <para>Internal: update_related_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("update_related_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("update_related_model_id")]
        public int? UpdateRelatedModelId { get; set; }

        /// <summary>
        /// <para>Name: Field Type</para>
        /// <para>Internal: update_field_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [binary]=binary,[boolean]=boolean,[char]=char,[date]=date,[datetime]=datetime,[float]=float,[html]=html,[integer]=integer,[json]=json,[many2many]=many2many,[many2one]=many2one,[many2one_reference]=many2one_reference,[monetary]=monetary,[one2many]=one2many,[properties]=properties,[properties_definition]=properties_definition,[reference]=reference,[selection]=selection,[text]=text</para>
        /// </summary>
        [JsonPropertyName("update_field_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("update_field_type")]
        public string UpdateFieldType { get; set; }

        /// <summary>
        /// <para>Name: Many2many Operations</para>
        /// <para>Internal: update_m2m_operation</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [add]=Adding,[remove]=Removing,[set]=Setting it to,[clear]=Clearing it</para>
        /// </summary>
        [JsonPropertyName("update_m2m_operation")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("update_m2m_operation")]
        public string UpdateM2mOperation { get; set; }

        /// <summary>
        /// <para>Name: Boolean Value</para>
        /// <para>Internal: update_boolean_value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [true]=Yes (True),[false]=No (False)</para>
        /// </summary>
        [JsonPropertyName("update_boolean_value")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("update_boolean_value")]
        public string UpdateBooleanValue { get; set; }

        /// <summary>
        /// <para>Name: Value</para>
        /// <para>Internal: value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("value")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("value")]
        public string Value { get; set; }

        /// <summary>
        /// <para>Name: Value Type</para>
        /// <para>Internal: evaluation_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [value]=Update,[equation]=Compute</para>
        /// </summary>
        [JsonPropertyName("evaluation_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("evaluation_type")]
        public string EvaluationType { get; set; }

        /// <summary>
        /// <para>Name: Record</para>
        /// <para>Internal: resource_ref</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Reference</para>
        /// <para>Allowed selection values: [account.account]=Account,[account.analytic.account]=Analytic Account,[appointment.type]=Appointment Type,[knowledge.article.thread]=Article Discussion Thread,[account.asset]=Asset/Revenue Recognition,[res.partner.bank]=Bank Accounts,[account.online.link]=Bank Connection,[account.bank.statement]=Bank Statement,[extract.mixin]=Base class to extract data from documents,[extract.mixin.with.words]=Base class to extract data from documents with OCRed words saved,[calendar.event]=Calendar Event,[res.company]=Companies,[res.partner]=Contact,[hr.department]=Department,[discuss.channel]=Discussion Channel,[documents.document]=Document,[mail.thread.cc]=Email CC management,[mail.thread]=Email Thread,[hr.employee]=Employee,[gamification.badge]=Gamification Badge,[gamification.challenge]=Gamification Challenge,[helpdesk.team]=Helpdesk Team,[helpdesk.ticket]=Helpdesk Ticket,[iap.account]=IAP Account,[hr.job]=Job Position,[account.journal]=Journal,[account.move]=Journal Entry,[knowledge.article]=Knowledge Article,[crm.lead]=Lead,[account.loan]=Loan,[x_logi_menu]=Logi Menü,[mail.blacklist]=Mail Blacklist,[mail.thread.blacklist]=Mail Blacklist mixin,[mail.thread.main.attachment]=Mail Main Attachment management,[account.payment]=Payments,[phone.blacklist]=Phone Blacklist,[mail.thread.phone]=Phone Blacklist Mixin,[account.reconcile.model]=Preset to create journal entries during a invoices and payments matching,[product.pricelist]=Pricelist,[product.template]=Product,[product.category]=Product Category,[product.product]=Product Variant,[purchase.order]=Purchase Order,[rating.mixin]=Rating Mixin,[sale.order]=Sales Order,[crm.team]=Sales Team,[crm.team.member]=Sales Team Member,[sign.request]=Signature Request,[spreadsheet.cell.thread]=Spreadsheet discussion thread,[studio.approval.rule]=Studio Approval Rule,[survey.survey]=Survey,[survey.user_input]=Survey User Input,[account.tax]=Tax,[auth_totp.wizard]=2-Factor Setup Wizard,[account.edi.xml.ubl_a_nz]=A-NZ BIS Billing 3.0,[res.users.apikeys.description]=API Key Description,[res.groups]=Access Groups,[account.cash.rounding]=Account Cash Rounding,[account.chart.template]=Account Chart Template,[account_edi_proxy_client.user]=Account EDI proxy user,[account.group]=Account Group,[account.journal.group]=Account Journal Group,[account.lock_exception]=Account Lock Exception,[account.move.reversal]=Account Move Reversal,[account.move.send]=Account Move Send,[account.move.send.batch.wizard]=Account Move Send Batch Wizard,[account.move.send.wizard]=Account Move Send Wizard,[account.report.annotation]=Account Report Annotation,[account.report.custom.handler]=Account Report Custom Handler,[account.tax.report.handler]=Account Report Handler for Tax Reports,[account.report.send]=Account Report Send,[account.account.tag]=Account Tag,[account.transfer.model]=Account Transfer Model,[account.transfer.model.line]=Account Transfer Model Line,[account.auto.reconcile.wizard]=Account automatic reconciliation wizard,[account.root]=Account codes first 2 digits,[account.import.summary]=Account import summary view,[account.merge.wizard]=Account merge wizard,[account.merge.wizard.line]=Account merge wizard line,[account.reconcile.wizard]=Account reconciliation wizard,[report.account.report_invoice_with_payments]=Account report with payment lines,[report.account.report_invoice]=Account report without payment lines,[account.report]=Accounting Report,[account.report.budget]=Accounting Report Budget,[account.report.budget.item]=Accounting Report Budget Item,[account.report.column]=Accounting Report Column,[account.report.expression]=Accounting Report Expression,[account.report.external.value]=Accounting Report External Value,[account.report.line]=Accounting Report Line,[account.fiscal.position.account]=Accounts Mapping of Fiscal Position,[account.accrued.orders.wizard]=Accrued Orders Wizard,[ir.actions.act_url]=Action URL,[ir.actions.act_window]=Action Window,[ir.actions.act_window_close]=Action Window Close,[ir.actions.act_window.view]=Action Window View,[ir.actions.actions]=Actions,[mail.activity]=Activity,[mail.activity.mixin]=Activity Mixin,[mail.activity.plan]=Activity Plan,[mail.activity.type]=Activity Type,[mail.activity.plan.template]=Activity plan template,[mail.activity.schedule]=Activity schedule plan Wizard,[appointment.manage.leaves]=Add or remove leaves from appointments,[format.address.mixin]=Address Format,[account.aged.partner.balance.report.handler]=Aged Partner Balance Custom Handler,[account.aged.payable.report.handler]=Aged Payable Custom Handler,[account.aged.receivable.report.handler]=Aged Receivable Custom Handler,[website.route]=All Website Route,[ir.profile]=Allow profiling only to Tech Support level,[account.analytic.distribution.model]=Analytic Distribution Model,[account.analytic.line]=Analytic Line,[analytic.mixin]=Analytic Mixin,[analytic.plan.fields.mixin]=Analytic Plan Fields,[account.analytic.applicability]=Analytic Plan's Applicabilities,[account.analytic.plan]=Analytic Plans,[ir.module.category]=Application,[appointment.answer.input]=Appointment Answer Inputs,[appointment.booking.line]=Appointment Booking Line,[appointment.invite]=Appointment Invite,[appointment.answer]=Appointment Question Answers,[appointment.question]=Appointment Questions,[appointment.resource]=Appointment Resource,[appointment.slot]=Appointment: Time Slot,[studio.approval.rule.approver]=Approval Rule Approvers Enriched,[studio.approval.rule.delegate]=Approval Rule Delegate,[knowledge.article.member]=Article Member,[knowledge.article.template.category]=Article Template Category,[ir.asset]=Asset,[account.asset.group]=Asset Group,[account.asset.report.handler]=Assets Report Custom Handler,[web_editor.assets]=Assets Utils,[ir.attachment]=Attachment,[product.attribute.value]=Attribute Value,[auth_totp.device]=Authentication Device,[ir.autovacuum]=Automatic Vacuum,[sequence.mixin]=Automatic sequence,[base.automation]=Automation Rule,[account.autopost.bills.wizard]=Autopost Bills Wizard,[avatar.mixin]=Avatar Mixin,[account.edi.xml.ubl_de]=BIS3 DE (XRechnung),[account.balance.sheet.report.handler]=Balance Sheet Custom Handler,[res.bank]=Bank,[account.bank.reconciliation.report.handler]=Bank Reconciliation Report Custom Handler,[account.bank.statement.line]=Bank Statement Line,[bank.rec.widget]=Bank reconciliation widget for a single statement line,[account.setup.bank.manual.config]=Bank setup manual config,[barcodes.barcode_events_mixin]=Barcode Event Mixin,[barcode.nomenclature]=Barcode Nomenclature,[barcode.rule]=Barcode Rule,[base]=Base,[base_import.import]=Base Import,[base_import.mapping]=Base Import Mapping,[hr.employee.base]=Basic Employee,[bill.to.po.wizard]=Bill to Purchase Order,[crm.activity.report]=CRM Activity Analysis,[crm.iap.lead.industry]=CRM IAP Lead Industry,[crm.iap.lead.mining.request]=CRM Lead Mining Request,[crm.recurring.plan]=CRM Recurring revenue plans,[crm.stage]=CRM Stages,[crm.tag]=CRM Tag,[calendar.attendee]=Calendar Attendee Information,[calendar.filters]=Calendar Filters,[calendar.popover.delete.wizard]=Calendar Popover Delete Wizard,[calendar.provider.config]=Calendar Provider Configuration Wizard,[utm.stage]=Campaign Stage,[bus.listener.mixin]=Can send messages via bus.bus,[sale.mass.cancel.orders]=Cancel multiple quotations,[mail.canned.response]=Canned Response,[account.cash.flow.report.handler]=Cash Flow Report Custom Handler,[certificate.certificate]=Certificate,[account.change.lock.date]=Change Lock Date,[change.password.wizard]=Change Password Wizard,[discuss.channel.member]=Channel Member,[product.label.layout]=Choose the sheet layout to print the labels,[ir.actions.client]=Client Action,[account.loan.close.wizard]=Close Loan Wizard,[spreadsheet.revision]=Collaborative spreadsheet revision,[account.edi.common]=Common functions for EDI documents: generate the data, the constraints, etc,[sale.edi.common]=Common functions for EDI orders,[bus.bus]=Communication Bus,[base.document.layout]=Company Document Layout,[res.config]=Config,[res.config.settings]=Config Settings,[ir.actions.todo]=Configuration Wizards,[hr.contract.type]=Contract Type,[crm.lead2opportunity.partner.mass]=Convert Lead to Opportunity (in mass),[crm.lead2opportunity.partner]=Convert Lead to Opportunity (not in mass),[helpdesk.ticket.to.lead]=Convert Ticket to Lead,[spreadsheet.dashboard.share]=Copy of a shared dashboard,[res.country]=Country,[res.country.group]=Country Group,[format.vat.label.mixin]=Country Specific VAT Label,[res.country.state]=Country state,[website.cover_properties.mixin]=Cover Properties Website Mixin,[account.automatic.entry.wizard]=Create Automatic Entries,[wizard.ir.model.menu.create]=Create Menu Wizard,[spreadsheet.document.to.dashboard]=Create a dashboard from a spreadsheet document,[crm.quotation.partner]=Create new or use existing Customer on new Quotation,[certificate.key]=Cryptographic Keys,[res.currency]=Currency,[res.currency.rate]=Currency Rate,[ir.ui.view.custom]=Custom View,[account.customer.statement.report.handler]=Customer Statement Custom Handler,[decimal.precision]=Decimal Precision,[ir.default]=Default Values,[account.deferred.expense.report.handler]=Deferred Expense Custom Handler,[account.deferred.report.handler]=Deferred Expense Report Custom Handler,[account.deferred.revenue.report.handler]=Deferred Revenue Custom Handler,[choose.delivery.carrier]=Delivery Carrier Selection Wizard,[delivery.price.rule]=Delivery Price Rules,[delivery.zip.prefix]=Delivery Zip Prefix,[ir.demo]=Demo,[ir.demo_failure.wizard]=Demo Failure wizard,[ir.demo_failure]=Demo failure,[hr.departure.reason]=Departure Reason,[hr.departure.wizard]=Departure Wizard,[res.device.log]=Device Log,[res.device]=Devices,[digest.digest]=Digest,[digest.tip]=Digest Tips,[account.disallowed.expenses.category]=Disallowed Expenses Category,[account.disallowed.expenses.report.handler]=Disallowed Expenses Custom Handler,[account.disallowed.expenses.rate]=Disallowed Expenses Rate,[sale.order.discount]=Discount Wizard,[documents.access]=Document / Partner,[mail.followers]=Document Followers,[documents.redirect]=Document Redirect,[documents.request_wizard]=Document Request,[documents.link_to_record_wizard]=Documents Link to Record,[documents.mixin]=Documents creation mixin,[documents.unlink.mixin]=Documents unlink mixin,[website.sale.extra.field]=E-Commerce Extra Info Shown on product page,[account.edi.xml.ubl_efff]=E-FFF (BE),[account.ec.sales.report.handler]=EC Sales Report Custom Handler,[mail.alias]=Email Aliases,[mail.alias.mixin]=Email Aliases Mixin,[mail.alias.mixin.optional]=Email Aliases Mixin (light),[mail.alias.domain]=Email Domain,[mail.template.preview]=Email Template Preview,[mail.template]=Email Templates,[mail.compose.message]=Email composition wizard,[mail.resend.message]=Email resend wizard,[ir.embedded.actions]=Embedded Actions,[hr.employee.category]=Employee Category,[report.hr_skills.report_employee_cv]=Employee Resume,[hr.employee.skill.report]=Employee Skills Report,[base.enable.profiling.wizard]=Enable profiling for some time,[calendar.alarm]=Event Alarm,[calendar.alarm_manager]=Event Alarm Manager,[calendar.event.type]=Event Meeting Type,[calendar.recurrence]=Event Recurrence Rule,[account_reports.export.wizard.format]=Export format for accounting's reports,[account_reports.export.wizard]=Export wizard for accounting's reports,[ir.exports]=Exports,[ir.exports.line]=Exports Line,[iap.extracted.words]=Extracted words from an OCRed document,[account.edi.xml.cii]=Factur-x/XRechnung CII 2.2.0,[knowledge.article.favorite]=Favorite Article,[product.fetch.image.wizard]=Fetch product images from Barcode Lookup based on the product's barcode.,[html.field.history.mixin]=Field html History,[ir.model.fields]=Fields,[ir.fields.converter]=Fields Converter,[ir.model.fields.selection]=Fields Selection,[crm.lead.scoring.frequency.field]=Fields that can be used for predictive lead scoring computation,[sign.item]=Fields to be sign on Document,[ir.binary]=File streaming helper model for controllers,[ir.filters]=Filters,[account.fiscal.position]=Fiscal Position,[account.fiscal.year]=Fiscal Year,[account.followup.report.handler]=Follow-Up Report Custom Handler,[account_followup.followup.line]=Follow-up Criteria,[account.followup.report]=Follow-up Report,[mail.followers.edit]=Followers edit wizard,[account_followup.missing.information.wizard]=Followup missing information wizard,[sale.pdf.form.field]=Form fields of inside quotation documents.,[snailmail.letter.format.error]=Format Error Sending a Snailmail Letter,[account.full.reconcile]=Full Reconcile,[gamification.goal]=Gamification Goal,[gamification.goal.definition]=Gamification Goal Definition,[gamification.goal.wizard]=Gamification Goal Wizard,[gamification.badge.user]=Gamification User Badge,[gamification.badge.user.wizard]=Gamification User Badge Wizard,[gamification.challenge.line]=Gamification generic goal for challenge,[account.general.ledger.report.handler]=General Ledger Custom Handler,[payment.link.wizard]=Generate Sales Payment Link,[account.generic.tax.report.handler]=Generic Tax Report Custom Handler,[account.generic.tax.report.handler.account.tax]=Generic Tax Report Custom Handler (Account -> Tax),[account.generic.tax.report.handler.tax.account]=Generic Tax Report Custom Handler (Tax -> Account),[l10n_de.ec.sales.report.handler]=German EC Sales Report Custom Handler,[l10n_de.tax.report.handler]=German Tax Report Custom Handler,[crm.lead.lost]=Get Lost Reason,[report.account.report_hash_integrity]=Get hash integrity result as PDF.,[google.gmail.mixin]=Google Gmail Mixin,[portal.wizard]=Grant Portal Access,[report.sign.green_savings_report]=Green Savings Report model,[spreadsheet.dashboard.group]=Group of dashboards,[mail.guest]=Guest,[ir.http]=HTTP Routing,[helpdesk.sla]=Helpdesk SLA Policies,[helpdesk.stage]=Helpdesk Stage,[helpdesk.stage.delete.wizard]=Helpdesk Stage Delete Wizard,[helpdesk.tag.assignment]=Helpdesk Tag Assignment,[helpdesk.tag]=Helpdesk Tags,[crm.iap.lead.helpers]=Helper methods for crm_iap_mine modules,[account.report.horizontal.group]=Horizontal group for reports,[account.report.horizontal.group.rule]=Horizontal group rule for reports,[hr.manager.department.report]=Hr Manager Department Report,[iap.enrich.api]=IAP Lead Enrichment API,[iap.autocomplete.api]=IAP Partner Autocomplete API,[iap.service]=IAP Service,[mail.ice.server]=ICE server,[image.mixin]=Image Mixin,[base.import.module]=Import Module,[fetchmail.server]=Incoming Mail Server,[account.incoterms]=Incoterms,[res.partner.industry]=Industry,[base.language.install]=Install Language,[account.invoice.report]=Invoices Statistics,[account.move.line]=Journal Item,[account.journal.report.handler]=Journal Report Custom Handler,[documents.account.folder.setting]=Journal and Folder settings,[knowledge.cover]=Knowledge Cover,[knowledge.invite]=Knowledge Invite Wizard,[knowledge.article.stage]=Knowledge Stage,[base.language.export]=Language Export,[base.language.import]=Language Import,[res.lang]=Languages,[crm.lead.scoring.frequency]=Lead Scoring Frequency,[crm.lead.convert2ticket]=Lead convert to Ticket,[bank.rec.widget.line]=Line of the bank reconciliation widget,[sms.tracker]=Link SMS to mailing/sms tracking models,[account.bank.selection]=Link a bank account to the selected journal,[product.uom]=Link between products and their UoMs,[account.loan.compute.wizard]=Loan Compute Wizard,[account.loan.line]=Loan Line,[ir.logging]=Logging,[x_logi_menu_stage]=Logi Menü Stages,[x_logi_menu_tag]=Logi Menü Tags,[mail.bot]=Mail Bot,[mail.composer.mixin]=Mail Composer Mixin,[mail.gateway.allowed]=Mail Gateway Allowed,[discuss.channel.rtc.session]=Mail RTC session,[mail.render.mixin]=Mail Render Mixin,[ir.mail_server]=Mail Server,[mail.template.reset]=Mail Template Reset,[mail.tracking.value]=Mail Tracking Value,[account.report.file.download.error.wizard]=Manage the file generation errors from report exports.,[account.code.mapping]=Mapping of account codes per company,[calendar.booking]=Meeting Booking,[calendar.booking.line]=Meeting Resource Booking,[ir.ui.menu]=Menu,[crm.merge.opportunity]=Merge Opportunities,[base.partner.merge.line]=Merge Partner Line,[base.partner.merge.automatic.wizard]=Merge Partner Wizard,[mail.message]=Message,[mail.notification]=Message Notifications,[mail.message.reaction]=Message Reaction,[mail.message.translation]=Message Translation,[mail.message.subtype]=Message subtypes,[discuss.voice.metadata]=Metadata for voice attachments,[mail.tracking.duration.mixin]=Mixin to compute the time a record has spent in each value a many2one field can take,[ir.model.access]=Model Access,[ir.model.constraint]=Model Constraint,[ir.model.data]=Model Data,[ir.model.inherit]=Model Inheritance Tree,[website.controller.page]=Model Page,[ir.model]=Models,[asset.modify]=Modify Asset,[ir.module.module]=Module,[base.module.install.request]=Module Activation Request,[base.module.install.review]=Module Activation Review,[report.base.report_irmodulereference]=Module Reference Report (base),[base.module.uninstall]=Module Uninstall,[ir.module.module.dependency]=Module dependency,[ir.module.module.exclusion]=Module exclusion,[website.multi.mixin]=Multi Website Mixin,[website.published.multi.mixin]=Multi Website Published Mixin,[account.multicurrency.revaluation.report.handler]=Multicurrency Revaluation Report Custom Handler,[account.multicurrency.revaluation.wizard]=Multicurrency Revaluation Wizard,[onboarding.onboarding]=Onboarding,[onboarding.progress.step]=Onboarding Progress Step Tracker,[onboarding.progress]=Onboarding Progress Tracker,[onboarding.onboarding.step]=Onboarding Step,[account.financial.year.op]=Opening Balance of Financial Year,[crm.lost.reason]=Opp. Lost Reason,[sign.item.option]=Option of a selection Field,[mail.mail]=Outgoing Mails,[sms.sms]=Outgoing SMS,[website.page]=Page,[website.page.properties]=Page Properties,[website.page.properties.base]=Page Properties Base,[report.paperformat]=Paper Format Config,[account.partial.reconcile]=Partial Reconcile,[res.partner.autocomplete.sync]=Partner Autocomplete Sync,[account.partner.ledger.report.handler]=Partner Ledger Custom Handler,[res.partner.category]=Partner Tags,[account.reconcile.model.partner.mapping]=Partner mapping for reconciliation models,[mail.resend.partner]=Partner with additional information for mail resend,[res.users.identitycheck]=Password Check Wizard,[account.payment.register]=Pay,[payment.capture.wizard]=Payment Capture Wizard,[payment.method]=Payment Method,[account.payment.method.line]=Payment Methods,[account.payment.method]=Payment Methods,[payment.provider]=Payment Provider,[payment.refund.wizard]=Payment Refund Wizard,[account.payment.term]=Payment Terms,[account.payment.term.line]=Payment Terms Line,[payment.token]=Payment Token,[payment.transaction]=Payment Transaction,[payment.provider.onboarding.wizard]=Payment provider onboarding wizard,[crm.iap.lead.role]=People Role,[crm.iap.lead.seniority]=People Seniority,[peppol.config.wizard]=Peppol Configuration Wizard,[peppol.registration]=Peppol Registration,[account_peppol.service]=Peppol Service,[portal.mixin]=Portal Mixin,[portal.share]=Portal Sharing,[portal.wizard.user]=Portal User Config,[report.product.report_pricelist]=Pricelist Report,[product.pricelist.item]=Pricelist Rule,[hr.employee.cv.wizard]=Print Resume,[privacy.log]=Privacy Log,[privacy.lookup.wizard]=Privacy Lookup Wizard,[privacy.lookup.wizard.line]=Privacy Lookup Wizard Line,[product.attribute]=Product Attribute,[product.attribute.custom.value]=Product Attribute Custom Value,[product.catalog.mixin]=Product Catalog Mixin,[product.combo]=Product Combo,[product.combo.item]=Product Combo Item,[product.document]=Product Document,[product.image]=Product Image,[report.product.report_producttemplatelabel_dymo]=Product Label Report,[report.product.report_producttemplatelabel2x7]=Product Label Report 2x7,[report.product.report_producttemplatelabel4x12]=Product Label Report 4x12,[report.product.report_producttemplatelabel4x12noprice]=Product Label Report 4x12 No Price,[report.product.report_producttemplatelabel4x7]=Product Label Report 4x7,[product.tag]=Product Tag,[product.template.attribute.exclusion]=Product Template Attribute Exclusion,[product.template.attribute.line]=Product Template Attribute Line,[product.template.attribute.value]=Product Template Attribute Value,[uom.uom]=Product Unit of Measure,[product.ribbon]=Product ribbon,[ir.cron.progress]=Progress of Scheduled Actions,[hr.employee.public]=Public Employee,[publisher_warranty.contract]=Publisher Warranty Contract,[purchase.bill.line.match]=Purchase Line and Vendor Bill line matching view,[purchase.order.line]=Purchase Order Line,[purchase.report]=Purchase Report,[purchase.bill.union]=Purchases & Bills Union,[mail.push.device]=Push Notification Device,[mail.push]=Push Notifications,[ir.qweb.field.time]=QWeb Field Time,[sale.order.spreadsheet]=Quotation Spreadsheet,[sale.order.template]=Quotation Template,[sale.order.template.line]=Quotation Template Line,[sale.order.template.option]=Quotation Template Option,[quotation.document]=Quotation's Headers & Footers,[ir.qweb]=Qweb,[ir.qweb.field]=Qweb Field,[ir.qweb.field.barcode]=Qweb Field Barcode,[ir.qweb.field.contact]=Qweb Field Contact,[ir.qweb.field.date]=Qweb Field Date,[ir.qweb.field.datetime]=Qweb Field Datetime,[ir.qweb.field.duration]=Qweb Field Duration,[ir.qweb.field.float]=Qweb Field Float,[ir.qweb.field.float_time]=Qweb Field Float Time,[ir.qweb.field.html]=Qweb Field HTML,[ir.qweb.field.image]=Qweb Field Image,[ir.qweb.field.image_url]=Qweb Field Image,[ir.qweb.field.integer]=Qweb Field Integer,[ir.qweb.field.many2one]=Qweb Field Many to One,[ir.qweb.field.monetary]=Qweb Field Monetary,[ir.qweb.field.relative]=Qweb Field Relative,[ir.qweb.field.selection]=Qweb Field Selection,[ir.qweb.field.text]=Qweb Field Text,[ir.qweb.field.qweb]=Qweb Field qweb,[ir.qweb.field.many2many]=Qweb field many2many,[sign.item.radio.set]=Radio button set for keeping radio button items together,[gamification.karma.rank]=Rank based on karma,[rating.rating]=Rating,[rating.parent.mixin]=Rating Parent Mixin,[ir.model.relation]=Relation Model,[account.resequence.wizard]=Remake the sequence of Journal Entries.,[mail.blacklist.remove]=Remove email from blacklist wizard,[phone.blacklist.remove]=Remove phone from blacklist,[ir.actions.report]=Report Action,[report.layout]=Report Layout,[sms.resend.recipient]=Resend Notification,[reset.view.arch.wizard]=Reset View Architecture Wizard,[resource.mixin]=Resource Mixin,[resource.calendar.leaves]=Resource Time Off Detail,[resource.calendar]=Resource Working Time,[resource.resource]=Resources,[hr.resume.line]=Resume line of an employee,[website.robots]=Robots.txt Editor,[ir.rule]=Rule,[account.reconcile.model.line]=Rules for the reconciliation model,[website.seo.metadata]=SEO metadata,[account.edi.xml.ubl_sg]=SG BIS Billing 3.0,[account.edi.xml.ubl_nl]=SI-UBL 2.0 (NLCIUS),[helpdesk.sla.report.analysis]=SLA Status Analysis,[sms.account.phone]=SMS Account Registration Phone Number Wizard,[sms.account.sender]=SMS Account Sender Name Wizard,[sms.account.code]=SMS Account Verification Code Wizard,[sms.resend]=SMS Resend,[sms.template.preview]=SMS Template Preview,[sms.template.reset]=SMS Template Reset,[sms.template]=SMS Templates,[sale.order.option]=Sale Options,[sale.payment.provider.onboarding.wizard]=Sale Payment provider onboarding wizard,[sale.advance.payment.inv]=Sales Advance Payment Invoice,[sale.report]=Sales Analysis Report,[sale.order.line]=Sales Order Line,[discuss.gif.favorite]=Save favorite GIF from Tenor API,[ir.cron]=Scheduled Actions,[mail.scheduled.message]=Scheduled Message,[mail.message.schedule]=Scheduled Messages,[account.secure.entries.wizard]=Secure Journal Entries,[sms.composer]=Send SMS Wizard,[ir.sequence]=Sequence,[ir.sequence.date_range]=Sequence Date Range,[ir.actions.server]=Server Action,[ir.min.cron.mixin]=Set Min Next call on metabase,[delivery.carrier]=Shipping Methods,[res.users.apikeys.show]=Show API Key,[sign.duplicate.template.pdf]=Sign Duplicate Template with new PDF,[sign.request.download]=Sign Request Download,[sign.template.preview]=Sign Tempate Preview,[sign.template.tag]=Sign Template Tag,[sign.log]=Sign requests access history,[sign.send.request]=Sign send request,[sign.send.request.signer]=Sign send request signer,[sign.item.role]=Signature Item Role,[sign.item.type]=Signature Item Type,[sign.request.item.value]=Signature Item Value,[sign.request.item]=Signature Request Item,[sign.template]=Signature Template,[hr.skill]=Skill,[hr.skill.level]=Skill Level,[hr.skill.type]=Skill Type,[hr.employee.skill]=Skill level for an employee,[hr.employee.skill.log]=Skills History,[snailmail.letter]=Snailmail Letter,[spreadsheet.contributor]=Spreadsheet Contributor,[spreadsheet.dashboard]=Spreadsheet Dashboard,[spreadsheet.template]=Spreadsheet Template,[save.spreadsheet.template]=Spreadsheet Template Save Wizard,[spreadsheet.mixin]=Spreadsheet mixin,[mail.link.preview]=Store link preview data,[studio.approval.entry]=Studio Approval Entry,[studio.approval.request]=Studio Approval Request,[studio.export.wizard.data]=Studio Export Data,[studio.export.model]=Studio Export Models,[studio.export.wizard]=Studio Export Wizard,[studio.mixin]=Studio Mixin,[product.supplierinfo]=Supplier Pricelist,[survey.invite]=Survey Invitation Wizard,[survey.question.answer]=Survey Label,[survey.question]=Survey Question,[survey.user_input.line]=Survey User Input Line,[ir.config_parameter]=System Parameter,[auth.totp.rate.limit.log]=TOTP rate limit logs,[documents.tag]=Tag,[account.tax.group]=Tax Group,[account.fiscal.position.tax]=Tax Mapping of Fiscal Position,[account.tax.repartition.line]=Tax Repartition Line,[account.tax.unit]=Tax Unit,[ir_actions_account_report_download]=Technical model for accounting report downloads,[template.reset.mixin]=Template Reset Mixin,[theme.ir.asset]=Theme Asset,[theme.ir.attachment]=Theme Attachments,[theme.ir.ui.view]=Theme UI View,[theme.utils]=Theme Utils,[helpdesk.ticket.report.analysis]=Ticket Analysis,[helpdesk.sla.status]=Ticket SLA Status,[web_tour.tour.step]=Tour's step,[web_tour.tour]=Tours,[gamification.karma.tracking]=Track Karma Changes,[account.bank.statement.line.transient]=Transient model for bank statement line,[account.trial.balance.report.handler]=Trial Balance Custom Handler,[ir.cron.trigger]=Triggered actions,[hr.resume.line.type]=Type of a resume line,[account.edi.xml.ubl_20]=UBL 2.0,[account.edi.xml.ubl_21]=UBL 2.1,[purchase.edi.xml.ubl_bis3]=UBL BIS 3 Peppol Order transaction 3.4,[account.edi.xml.ubl_bis3]=UBL BIS Billing 3.0.12,[sale.edi.xml.ubl_bis3]=UBL BIS Ordering 3.0,[utm.campaign]=UTM Campaign,[utm.medium]=UTM Medium,[utm.mixin]=UTM Mixin,[utm.source]=UTM Source,[utm.source.mixin]=UTM Source Mixin,[utm.tag]=UTM Tag,[website.base.unit]=Unit of Measure for price per unit on eCommerce products.,[_unknown]=Unknown,[base.module.update]=Update Module,[snailmail.letter.missing.required.fields]=Update address of partner,[update.product.attribute.value]=Update product attribute value,[crm.lead.pls.update]=Update the probabilities,[base.module.upgrade]=Upgrade Module,[res.users]=User,[res.users.settings]=User Settings,[res.users.settings.volumes]=User Settings Volumes,[website.custom_blocked_third_party_domains]=User list of blocked 3rd-party domains,[change.password.user]=User, Change Password Wizard,[change.password.own]=User, change own password wizard,[mail.presence]=User/Guest Presence,[res.users.apikeys]=Users API Keys,[res.users.deletion]=Users Deletion Request,[res.users.log]=Users Log,[validate.account.move]=Validate Account Move,[ir.ui.view]=View,[website.track]=Visited Pages,[web_editor.converter.test.sub]=Web Editor Converter Subtest,[web_editor.converter.test]=Web Editor Converter Test,[website]=Website,[website.configurator.feature]=Website Configurator Feature,[website.menu]=Website Menu,[product.public.category]=Website Product Category,[website.published.mixin]=Website Published Mixin,[website.searchable.mixin]=Website Searchable Mixin,[website.snippet.filter]=Website Snippet Filter,[theme.website.menu]=Website Theme Menu,[theme.website.page]=Website Theme Page,[website.visitor]=Website Visitor,[website.page_options.mixin]=Website page/record specific options,[website.page_visibility_options.mixin]=Website page/record specific visibility options,[website.rewrite]=Website rewrite,[account.duplicate.transaction.wizard]=Wizard for duplicate transactions,[account.missing.transaction.wizard]=Wizard for missing transactions,[account_followup.manual_reminder]=Wizard for sending manual reminders to clients,[resource.calendar.attendance]=Work Detail,[hr.work.location]=Work Location,[x_logi_menu_line_26ac4]=logi_menu_line,[account.online.account]=representation of an online bank account,[ir.websocket]=websocket message handling</para>
        /// </summary>
        [JsonPropertyName("resource_ref")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("resource_ref")]
        public string ResourceRef { get; set; }

        /// <summary>
        /// <para>Name: Custom Value</para>
        /// <para>Internal: selection_value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.fields.selection</para>
        /// </summary>
        [JsonPropertyName("selection_value")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("selection_value")]
        public int? SelectionValue { get; set; }

        /// <summary>
        /// <para>Name: Value Field To Show</para>
        /// <para>Internal: value_field_to_show</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [value]=value,[resource_ref]=reference,[update_boolean_value]=update_boolean_value,[selection_value]=selection_value</para>
        /// </summary>
        [JsonPropertyName("value_field_to_show")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("value_field_to_show")]
        public string ValueFieldToShow { get; set; }

        /// <summary>
        /// <para>Name: Webhook URL</para>
        /// <para>Internal: webhook_url</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("webhook_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("webhook_url")]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// <para>Name: Webhook Fields</para>
        /// <para>Internal: webhook_field_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.model.fields</para>
        /// </summary>
        [JsonPropertyName("webhook_field_ids")]
        [OdooField("webhook_field_ids")]
        public List<int> WebhookFieldIds { get; set; }

        /// <summary>
        /// <para>Name: Sample Payload</para>
        /// <para>Internal: webhook_sample_payload</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("webhook_sample_payload")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("webhook_sample_payload")]
        public string WebhookSamplePayload { get; set; }

        /// <summary>
        /// <para>Name: Followers Type</para>
        /// <para>Internal: followers_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [specific]=Specific Followers,[generic]=Dynamic Followers</para>
        /// </summary>
        [JsonPropertyName("followers_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("followers_type")]
        public string FollowersType { get; set; }

        /// <summary>
        /// <para>Name: Followers Field</para>
        /// <para>Internal: followers_partner_field_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("followers_partner_field_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("followers_partner_field_name")]
        public string FollowersPartnerFieldName { get; set; }

        /// <summary>
        /// <para>Name: Partner</para>
        /// <para>Internal: partner_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_ids")]
        [OdooField("partner_ids")]
        public List<int> PartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Email Template</para>
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
        [OdooField("template_id")]
        public int? TemplateId { get; set; }

        /// <summary>
        /// <para>Name: Subscribe Recipients</para>
        /// <para>Internal: mail_post_autofollow</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("mail_post_autofollow")]
        [OdooField("mail_post_autofollow")]
        public bool MailPostAutofollow { get; set; }

        /// <summary>
        /// <para>Name: Send Email As</para>
        /// <para>Internal: mail_post_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [email]=Email,[comment]=Message,[note]=Note</para>
        /// </summary>
        [JsonPropertyName("mail_post_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("mail_post_method")]
        public string MailPostMethod { get; set; }

        /// <summary>
        /// <para>Name: Activity Type</para>
        /// <para>Internal: activity_type_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
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
        /// <para>Name: Title</para>
        /// <para>Internal: activity_summary</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_summary")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_summary")]
        public string ActivitySummary { get; set; }

        /// <summary>
        /// <para>Name: Note</para>
        /// <para>Internal: activity_note</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("activity_note")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_note")]
        public string ActivityNote { get; set; }

        /// <summary>
        /// <para>Name: Due Date In</para>
        /// <para>Internal: activity_date_deadline_range</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("activity_date_deadline_range")]
        [OdooField("activity_date_deadline_range")]
        public int ActivityDateDeadlineRange { get; set; }

        /// <summary>
        /// <para>Name: Due type</para>
        /// <para>Internal: activity_date_deadline_range_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [days]=Days,[weeks]=Weeks,[months]=Months</para>
        /// </summary>
        [JsonPropertyName("activity_date_deadline_range_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_date_deadline_range_type")]
        public string ActivityDateDeadlineRangeType { get; set; }

        /// <summary>
        /// <para>Name: User Type</para>
        /// <para>Internal: activity_user_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [specific]=Specific User,[generic]=Dynamic User (based on record)</para>
        /// </summary>
        [JsonPropertyName("activity_user_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_user_type")]
        public string ActivityUserType { get; set; }

        /// <summary>
        /// <para>Name: Responsible</para>
        /// <para>Internal: activity_user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("activity_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("activity_user_id")]
        public int? ActivityUserId { get; set; }

        /// <summary>
        /// <para>Name: User Field</para>
        /// <para>Internal: activity_user_field_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_user_field_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_user_field_name")]
        public string ActivityUserFieldName { get; set; }

        /// <summary>
        /// <para>Name: SMS Template</para>
        /// <para>Internal: sms_template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sms.template</para>
        /// </summary>
        [JsonPropertyName("sms_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sms_template_id")]
        public int? SmsTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Send SMS As</para>
        /// <para>Internal: sms_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [sms]=SMS (without note),[comment]=SMS (with note),[note]=Note only</para>
        /// </summary>
        [JsonPropertyName("sms_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sms_method")]
        public string SmsMethod { get; set; }

        /// <summary>
        /// <para>Name: Automation Rule</para>
        /// <para>Internal: base_automation_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: base.automation</para>
        /// </summary>
        [JsonPropertyName("base_automation_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("base_automation_id")]
        public int? BaseAutomationId { get; set; }

        /// <summary>
        /// <para>Name: Website Path</para>
        /// <para>Internal: website_path</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_path")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_path")]
        public string WebsitePath { get; set; }

        /// <summary>
        /// <para>Name: Website Url</para>
        /// <para>Internal: website_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_url")]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// <para>Name: Available on the Website</para>
        /// <para>Internal: website_published</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_published")]
        [OdooField("website_published")]
        public bool WebsitePublished { get; set; }

    }
}
