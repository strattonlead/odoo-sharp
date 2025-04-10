using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("crm.iap.lead.mining.request")]
    public partial class CrmIapLeadMiningRequest
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
        /// <para>Name: Request Number</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [draft]=Draft,[error]=Error,[done]=Done</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Number of Leads</para>
        /// <para>Internal: lead_number</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("lead_number")]
        [OdooField("lead_number")]
        public int LeadNumber { get; set; }

        /// <summary>
        /// <para>Name: Target</para>
        /// <para>Internal: search_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [companies]=Companies,[people]=Companies and their Contacts</para>
        /// </summary>
        [JsonPropertyName("search_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("search_type")]
        public string SearchType { get; set; }

        /// <summary>
        /// <para>Name: Error Type</para>
        /// <para>Internal: error_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [credits]=Insufficient Credits,[no_result]=No Result</para>
        /// </summary>
        [JsonPropertyName("error_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("error_type")]
        public string ErrorType { get; set; }

        /// <summary>
        /// <para>Name: Type</para>
        /// <para>Internal: lead_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [lead]=Leads,[opportunity]=Opportunities</para>
        /// </summary>
        [JsonPropertyName("lead_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("lead_type")]
        public string LeadType { get; set; }

        /// <summary>
        /// <para>Name: Sales Team</para>
        /// <para>Internal: team_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.team</para>
        /// </summary>
        [JsonPropertyName("team_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("team_id")]
        public int? TeamId { get; set; }

        /// <summary>
        /// <para>Name: Salesperson</para>
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
        /// <para>Name: Tags</para>
        /// <para>Internal: tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: crm.tag</para>
        /// </summary>
        [JsonPropertyName("tag_ids")]
        [OdooField("tag_ids")]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// <para>Name: Generated Lead / Opportunity</para>
        /// <para>Internal: lead_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: crm.lead</para>
        /// </summary>
        [JsonPropertyName("lead_ids")]
        [OdooField("lead_ids")]
        public List<int> LeadIds { get; set; }

        /// <summary>
        /// <para>Name: Number of Generated Leads</para>
        /// <para>Internal: lead_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("lead_count")]
        [OdooField("lead_count")]
        public int LeadCount { get; set; }

        /// <summary>
        /// <para>Name: Filter on Size</para>
        /// <para>Internal: filter_on_size</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_on_size")]
        [OdooField("filter_on_size")]
        public bool FilterOnSize { get; set; }

        /// <summary>
        /// <para>Name: Size</para>
        /// <para>Internal: company_size_min</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("company_size_min")]
        [OdooField("company_size_min")]
        public int CompanySizeMin { get; set; }

        /// <summary>
        /// <para>Name: Company Size Max</para>
        /// <para>Internal: company_size_max</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("company_size_max")]
        [OdooField("company_size_max")]
        public int CompanySizeMax { get; set; }

        /// <summary>
        /// <para>Name: Countries</para>
        /// <para>Internal: country_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("country_ids")]
        [OdooField("country_ids")]
        public List<int> CountryIds { get; set; }

        /// <summary>
        /// <para>Name: States</para>
        /// <para>Internal: state_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.country.state</para>
        /// </summary>
        [JsonPropertyName("state_ids")]
        [OdooField("state_ids")]
        public List<int> StateIds { get; set; }

        /// <summary>
        /// <para>Name: Available State</para>
        /// <para>Internal: available_state_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.country.state</para>
        /// </summary>
        [JsonPropertyName("available_state_ids")]
        [OdooField("available_state_ids")]
        public List<int> AvailableStateIds { get; set; }

        /// <summary>
        /// <para>Name: Industries</para>
        /// <para>Internal: industry_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: crm.iap.lead.industry</para>
        /// </summary>
        [JsonPropertyName("industry_ids")]
        [OdooField("industry_ids")]
        public List<int> IndustryIds { get; set; }

        /// <summary>
        /// <para>Name: Number of Contacts</para>
        /// <para>Internal: contact_number</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("contact_number")]
        [OdooField("contact_number")]
        public int ContactNumber { get; set; }

        /// <summary>
        /// <para>Name: Filter on</para>
        /// <para>Internal: contact_filter_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [role]=Role,[seniority]=Seniority</para>
        /// </summary>
        [JsonPropertyName("contact_filter_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("contact_filter_type")]
        public string ContactFilterType { get; set; }

        /// <summary>
        /// <para>Name: Preferred Role</para>
        /// <para>Internal: preferred_role_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.iap.lead.role</para>
        /// </summary>
        [JsonPropertyName("preferred_role_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("preferred_role_id")]
        public int? PreferredRoleId { get; set; }

        /// <summary>
        /// <para>Name: Other Roles</para>
        /// <para>Internal: role_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: crm.iap.lead.role</para>
        /// </summary>
        [JsonPropertyName("role_ids")]
        [OdooField("role_ids")]
        public List<int> RoleIds { get; set; }

        /// <summary>
        /// <para>Name: Seniority</para>
        /// <para>Internal: seniority_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.iap.lead.seniority</para>
        /// </summary>
        [JsonPropertyName("seniority_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("seniority_id")]
        public int? SeniorityId { get; set; }

        /// <summary>
        /// <para>Name: Lead Credits</para>
        /// <para>Internal: lead_credits</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("lead_credits")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("lead_credits")]
        public string LeadCredits { get; set; }

        /// <summary>
        /// <para>Name: Lead Contacts Credits</para>
        /// <para>Internal: lead_contacts_credits</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("lead_contacts_credits")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("lead_contacts_credits")]
        public string LeadContactsCredits { get; set; }

        /// <summary>
        /// <para>Name: Lead Total Credits</para>
        /// <para>Internal: lead_total_credits</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("lead_total_credits")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("lead_total_credits")]
        public string LeadTotalCredits { get; set; }

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
