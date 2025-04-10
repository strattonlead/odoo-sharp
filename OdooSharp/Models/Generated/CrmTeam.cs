using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("crm.team")]
    public partial class CrmTeam
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
        /// <para>Name: Is Follower</para>
        /// <para>Internal: message_is_follower</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_is_follower")]
        [OdooField("message_is_follower")]
        public bool MessageIsFollower { get; set; }

        /// <summary>
        /// <para>Name: Followers</para>
        /// <para>Internal: message_follower_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.followers</para>
        /// </summary>
        [JsonPropertyName("message_follower_ids")]
        [OdooField("message_follower_ids")]
        public List<int> MessageFollowerIds { get; set; }

        /// <summary>
        /// <para>Name: Followers (Partners)</para>
        /// <para>Internal: message_partner_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("message_partner_ids")]
        [OdooField("message_partner_ids")]
        public List<int> MessagePartnerIds { get; set; }

        /// <summary>
        /// <para>Name: Messages</para>
        /// <para>Internal: message_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("message_ids")]
        [OdooField("message_ids")]
        public List<int> MessageIds { get; set; }

        /// <summary>
        /// <para>Name: Has Message</para>
        /// <para>Internal: has_message</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_message")]
        [OdooField("has_message")]
        public bool HasMessage { get; set; }

        /// <summary>
        /// <para>Name: Action Needed</para>
        /// <para>Internal: message_needaction</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_needaction")]
        [OdooField("message_needaction")]
        public bool MessageNeedaction { get; set; }

        /// <summary>
        /// <para>Name: Number of Actions</para>
        /// <para>Internal: message_needaction_counter</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_needaction_counter")]
        [OdooField("message_needaction_counter")]
        public int MessageNeedactionCounter { get; set; }

        /// <summary>
        /// <para>Name: Message Delivery error</para>
        /// <para>Internal: message_has_error</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_has_error")]
        [OdooField("message_has_error")]
        public bool MessageHasError { get; set; }

        /// <summary>
        /// <para>Name: Number of errors</para>
        /// <para>Internal: message_has_error_counter</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_has_error_counter")]
        [OdooField("message_has_error_counter")]
        public int MessageHasErrorCounter { get; set; }

        /// <summary>
        /// <para>Name: Attachment Count</para>
        /// <para>Internal: message_attachment_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_attachment_count")]
        [OdooField("message_attachment_count")]
        public int MessageAttachmentCount { get; set; }

        /// <summary>
        /// <para>Name: Ratings</para>
        /// <para>Internal: rating_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: rating.rating</para>
        /// </summary>
        [JsonPropertyName("rating_ids")]
        [OdooField("rating_ids")]
        public List<int> RatingIds { get; set; }

        /// <summary>
        /// <para>Name: Website Messages</para>
        /// <para>Internal: website_message_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("website_message_ids")]
        [OdooField("website_message_ids")]
        public List<int> WebsiteMessageIds { get; set; }

        /// <summary>
        /// <para>Name: SMS Delivery error</para>
        /// <para>Internal: message_has_sms_error</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("message_has_sms_error")]
        [OdooField("message_has_sms_error")]
        public bool MessageHasSmsError { get; set; }

        /// <summary>
        /// <para>Name: Sales Team</para>
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
        /// <para>Name: Currency</para>
        /// <para>Internal: currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("currency_id")]
        public int? CurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Team Leader</para>
        /// <para>Internal: user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// <para>Name: Multiple Memberships Allowed</para>
        /// <para>Internal: is_membership_multi</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_membership_multi")]
        [OdooField("is_membership_multi")]
        public bool IsMembershipMulti { get; set; }

        /// <summary>
        /// <para>Name: Salespersons</para>
        /// <para>Internal: member_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("member_ids")]
        [OdooField("member_ids")]
        public List<int> MemberIds { get; set; }

        /// <summary>
        /// <para>Name: Member Company</para>
        /// <para>Internal: member_company_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("member_company_ids")]
        [OdooField("member_company_ids")]
        public List<int> MemberCompanyIds { get; set; }

        /// <summary>
        /// <para>Name: Membership Issue Warning</para>
        /// <para>Internal: member_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("member_warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("member_warning")]
        public string MemberWarning { get; set; }

        /// <summary>
        /// <para>Name: Sales Team Members</para>
        /// <para>Internal: crm_team_member_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: crm.team.member</para>
        /// </summary>
        [JsonPropertyName("crm_team_member_ids")]
        [OdooField("crm_team_member_ids")]
        public List<int> CrmTeamMemberIds { get; set; }

        /// <summary>
        /// <para>Name: Sales Team Members (incl. inactive)</para>
        /// <para>Internal: crm_team_member_all_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: crm.team.member</para>
        /// </summary>
        [JsonPropertyName("crm_team_member_all_ids")]
        [OdooField("crm_team_member_all_ids")]
        public List<int> CrmTeamMemberAllIds { get; set; }

        /// <summary>
        /// <para>Name: Color Index</para>
        /// <para>Internal: color</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("color")]
        [OdooField("color")]
        public int Color { get; set; }

        /// <summary>
        /// <para>Name: Favorite Members</para>
        /// <para>Internal: favorite_user_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("favorite_user_ids")]
        [OdooField("favorite_user_ids")]
        public List<int> FavoriteUserIds { get; set; }

        /// <summary>
        /// <para>Name: Show on dashboard</para>
        /// <para>Internal: is_favorite</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_favorite")]
        [OdooField("is_favorite")]
        public bool IsFavorite { get; set; }

        /// <summary>
        /// <para>Name: Dashboard Button</para>
        /// <para>Internal: dashboard_button_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("dashboard_button_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("dashboard_button_name")]
        public string DashboardButtonName { get; set; }

        /// <summary>
        /// <para>Name: Dashboard Graph Data</para>
        /// <para>Internal: dashboard_graph_data</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("dashboard_graph_data")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("dashboard_graph_data")]
        public string DashboardGraphData { get; set; }

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
        /// <para>Name: Alias</para>
        /// <para>Internal: alias_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.alias</para>
        /// </summary>
        [JsonPropertyName("alias_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_id")]
        public int? AliasId { get; set; }

        /// <summary>
        /// <para>Name: Alias Name</para>
        /// <para>Internal: alias_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>Name: Alias Domain</para>
        /// <para>Internal: alias_domain_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.alias.domain</para>
        /// </summary>
        [JsonPropertyName("alias_domain_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_domain_id")]
        public int? AliasDomainId { get; set; }

        /// <summary>
        /// <para>Name: Alias Domain Name</para>
        /// <para>Internal: alias_domain</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_domain")]
        public string AliasDomain { get; set; }

        /// <summary>
        /// <para>Name: Default Values</para>
        /// <para>Internal: alias_defaults</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("alias_defaults")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_defaults")]
        public string AliasDefaults { get; set; }

        /// <summary>
        /// <para>Name: Email Alias</para>
        /// <para>Internal: alias_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_email")]
        public string AliasEmail { get; set; }

        /// <summary>
        /// <para>Name: Leads</para>
        /// <para>Internal: use_leads</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_leads")]
        [OdooField("use_leads")]
        public bool UseLeads { get; set; }

        /// <summary>
        /// <para>Name: Pipeline</para>
        /// <para>Internal: use_opportunities</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_opportunities")]
        [OdooField("use_opportunities")]
        public bool UseOpportunities { get; set; }

        /// <summary>
        /// <para>Name: Lead Assign</para>
        /// <para>Internal: assignment_enabled</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("assignment_enabled")]
        [OdooField("assignment_enabled")]
        public bool AssignmentEnabled { get; set; }

        /// <summary>
        /// <para>Name: Auto Assignment</para>
        /// <para>Internal: assignment_auto_enabled</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("assignment_auto_enabled")]
        [OdooField("assignment_auto_enabled")]
        public bool AssignmentAutoEnabled { get; set; }

        /// <summary>
        /// <para>Name: Skip auto assignment</para>
        /// <para>Internal: assignment_optout</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("assignment_optout")]
        [OdooField("assignment_optout")]
        public bool AssignmentOptout { get; set; }

        /// <summary>
        /// <para>Name: Lead Average Capacity</para>
        /// <para>Internal: assignment_max</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("assignment_max")]
        [OdooField("assignment_max")]
        public int AssignmentMax { get; set; }

        /// <summary>
        /// <para>Name: Assignment Domain</para>
        /// <para>Internal: assignment_domain</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("assignment_domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("assignment_domain")]
        public string AssignmentDomain { get; set; }

        /// <summary>
        /// <para>Name: # Unassigned Leads</para>
        /// <para>Internal: lead_unassigned_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("lead_unassigned_count")]
        [OdooField("lead_unassigned_count")]
        public int LeadUnassignedCount { get; set; }

        /// <summary>
        /// <para>Name: # Leads/Opps assigned this month</para>
        /// <para>Internal: lead_all_assigned_month_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("lead_all_assigned_month_count")]
        [OdooField("lead_all_assigned_month_count")]
        public int LeadAllAssignedMonthCount { get; set; }

        /// <summary>
        /// <para>Name: Exceed monthly lead assignement</para>
        /// <para>Internal: lead_all_assigned_month_exceeded</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("lead_all_assigned_month_exceeded")]
        [OdooField("lead_all_assigned_month_exceeded")]
        public bool LeadAllAssignedMonthExceeded { get; set; }

        /// <summary>
        /// <para>Name: # Opportunities</para>
        /// <para>Internal: opportunities_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("opportunities_count")]
        [OdooField("opportunities_count")]
        public int OpportunitiesCount { get; set; }

        /// <summary>
        /// <para>Name: Opportunities Revenues</para>
        /// <para>Internal: opportunities_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("opportunities_amount")]
        [OdooField("opportunities_amount")]
        public decimal OpportunitiesAmount { get; set; }

        /// <summary>
        /// <para>Name: # Overdue Opportunities</para>
        /// <para>Internal: opportunities_overdue_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("opportunities_overdue_count")]
        [OdooField("opportunities_overdue_count")]
        public int OpportunitiesOverdueCount { get; set; }

        /// <summary>
        /// <para>Name: Overdue Opportunities Revenues</para>
        /// <para>Internal: opportunities_overdue_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("opportunities_overdue_amount")]
        [OdooField("opportunities_overdue_amount")]
        public decimal OpportunitiesOverdueAmount { get; set; }

        /// <summary>
        /// <para>Name: Lead Properties</para>
        /// <para>Internal: lead_properties_definition</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Unknown</para>
        /// </summary>
        [JsonPropertyName("lead_properties_definition")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("lead_properties_definition")]
        public object LeadPropertiesDefinition { get; set; }

        /// <summary>
        /// <para>Name: Invoiced This Month</para>
        /// <para>Internal: invoiced</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("invoiced")]
        [OdooField("invoiced")]
        public double Invoiced { get; set; }

        /// <summary>
        /// <para>Name: Invoicing Target</para>
        /// <para>Internal: invoiced_target</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("invoiced_target")]
        [OdooField("invoiced_target")]
        public double InvoicedTarget { get; set; }

        /// <summary>
        /// <para>Name: Number of quotations to invoice</para>
        /// <para>Internal: quotations_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("quotations_count")]
        [OdooField("quotations_count")]
        public int QuotationsCount { get; set; }

        /// <summary>
        /// <para>Name: Amount of quotations to invoice</para>
        /// <para>Internal: quotations_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("quotations_amount")]
        [OdooField("quotations_amount")]
        public double QuotationsAmount { get; set; }

        /// <summary>
        /// <para>Name: Number of sales to invoice</para>
        /// <para>Internal: sales_to_invoice_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sales_to_invoice_count")]
        [OdooField("sales_to_invoice_count")]
        public int SalesToInvoiceCount { get; set; }

        /// <summary>
        /// <para>Name: # Sale Orders</para>
        /// <para>Internal: sale_order_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sale_order_count")]
        [OdooField("sale_order_count")]
        public int SaleOrderCount { get; set; }

        /// <summary>
        /// <para>Name: Websites</para>
        /// <para>Internal: website_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: website</para>
        /// </summary>
        [JsonPropertyName("website_ids")]
        [OdooField("website_ids")]
        public List<int> WebsiteIds { get; set; }

        /// <summary>
        /// <para>Name: Amount of Abandoned Carts</para>
        /// <para>Internal: abandoned_carts_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("abandoned_carts_amount")]
        [OdooField("abandoned_carts_amount")]
        public int AbandonedCartsAmount { get; set; }

        /// <summary>
        /// <para>Name: Number of Abandoned Carts</para>
        /// <para>Internal: abandoned_carts_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("abandoned_carts_count")]
        [OdooField("abandoned_carts_count")]
        public int AbandonedCartsCount { get; set; }

        /// <summary>
        /// <para>Name: Alias Email</para>
        /// <para>Internal: alias_full_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_full_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_full_name")]
        public string AliasFullName { get; set; }

        /// <summary>
        /// <para>Name: Aliased Model</para>
        /// <para>Internal: alias_model_id</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("alias_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_model_id")]
        public int? AliasModelId { get; set; }

        /// <summary>
        /// <para>Name: Record Thread ID</para>
        /// <para>Internal: alias_force_thread_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("alias_force_thread_id")]
        [OdooField("alias_force_thread_id")]
        public int AliasForceThreadId { get; set; }

        /// <summary>
        /// <para>Name: Parent Model</para>
        /// <para>Internal: alias_parent_model_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("alias_parent_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_parent_model_id")]
        public int? AliasParentModelId { get; set; }

        /// <summary>
        /// <para>Name: Parent Record Thread ID</para>
        /// <para>Internal: alias_parent_thread_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("alias_parent_thread_id")]
        [OdooField("alias_parent_thread_id")]
        public int AliasParentThreadId { get; set; }

        /// <summary>
        /// <para>Name: Alias Contact Security</para>
        /// <para>Internal: alias_contact</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [everyone]=Everyone,[partners]=Authenticated Partners,[followers]=Followers only,[employees]=Authenticated Employees</para>
        /// </summary>
        [JsonPropertyName("alias_contact")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_contact")]
        public string AliasContact { get; set; }

        /// <summary>
        /// <para>Name: Local-part based incoming detection</para>
        /// <para>Internal: alias_incoming_local</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("alias_incoming_local")]
        [OdooField("alias_incoming_local")]
        public bool AliasIncomingLocal { get; set; }

        /// <summary>
        /// <para>Name: Custom Bounced Message</para>
        /// <para>Internal: alias_bounced_content</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("alias_bounced_content")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_bounced_content")]
        public string AliasBouncedContent { get; set; }

        /// <summary>
        /// <para>Name: Alias Status</para>
        /// <para>Internal: alias_status</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_tested]=Not Tested,[valid]=Valid,[invalid]=Invalid</para>
        /// </summary>
        [JsonPropertyName("alias_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_status")]
        public string AliasStatus { get; set; }

    }
}
