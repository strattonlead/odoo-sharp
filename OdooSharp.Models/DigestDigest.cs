using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("digest.digest")]
    public partial class DigestDigest
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
        /// <para>Name: Recipients</para>
        /// <para>Internal: user_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("user_ids")]
        [OdooField("user_ids")]
        public List<int> UserIds { get; set; }

        /// <summary>
        /// <para>Name: Periodicity</para>
        /// <para>Internal: periodicity</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [daily]=Daily,[weekly]=Weekly,[monthly]=Monthly,[quarterly]=Quarterly</para>
        /// </summary>
        [JsonPropertyName("periodicity")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("periodicity")]
        public string Periodicity { get; set; }

        /// <summary>
        /// <para>Name: Next Mailing Date</para>
        /// <para>Internal: next_run_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("next_run_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("next_run_date")]
        public DateTime? NextRunDate { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("currency_id")]
        public int? CurrencyId { get; set; }

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
        /// <para>Name: Available Fields</para>
        /// <para>Internal: available_fields</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("available_fields")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("available_fields")]
        public string AvailableFields { get; set; }

        /// <summary>
        /// <para>Name: Is user subscribed</para>
        /// <para>Internal: is_subscribed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_subscribed")]
        [OdooField("is_subscribed")]
        public bool IsSubscribed { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [activated]=Activated,[deactivated]=Deactivated</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Connected Users</para>
        /// <para>Internal: kpi_res_users_connected</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("kpi_res_users_connected")]
        [OdooField("kpi_res_users_connected")]
        public bool KpiResUsersConnected { get; set; }

        /// <summary>
        /// <para>Name: Kpi Res Users Connected Value</para>
        /// <para>Internal: kpi_res_users_connected_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("kpi_res_users_connected_value")]
        [OdooField("kpi_res_users_connected_value")]
        public int KpiResUsersConnectedValue { get; set; }

        /// <summary>
        /// <para>Name: Messages Sent</para>
        /// <para>Internal: kpi_mail_message_total</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("kpi_mail_message_total")]
        [OdooField("kpi_mail_message_total")]
        public bool KpiMailMessageTotal { get; set; }

        /// <summary>
        /// <para>Name: Kpi Mail Message Total Value</para>
        /// <para>Internal: kpi_mail_message_total_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("kpi_mail_message_total_value")]
        [OdooField("kpi_mail_message_total_value")]
        public int KpiMailMessageTotalValue { get; set; }

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
        /// <para>Name: Revenue</para>
        /// <para>Internal: kpi_account_total_revenue</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("kpi_account_total_revenue")]
        [OdooField("kpi_account_total_revenue")]
        public bool KpiAccountTotalRevenue { get; set; }

        /// <summary>
        /// <para>Name: Kpi Account Total Revenue Value</para>
        /// <para>Internal: kpi_account_total_revenue_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("kpi_account_total_revenue_value")]
        [OdooField("kpi_account_total_revenue_value")]
        public decimal KpiAccountTotalRevenueValue { get; set; }

        /// <summary>
        /// <para>Name: New Leads</para>
        /// <para>Internal: kpi_crm_lead_created</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("kpi_crm_lead_created")]
        [OdooField("kpi_crm_lead_created")]
        public bool KpiCrmLeadCreated { get; set; }

        /// <summary>
        /// <para>Name: Kpi Crm Lead Created Value</para>
        /// <para>Internal: kpi_crm_lead_created_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("kpi_crm_lead_created_value")]
        [OdooField("kpi_crm_lead_created_value")]
        public int KpiCrmLeadCreatedValue { get; set; }

        /// <summary>
        /// <para>Name: Opportunities Won</para>
        /// <para>Internal: kpi_crm_opportunities_won</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("kpi_crm_opportunities_won")]
        [OdooField("kpi_crm_opportunities_won")]
        public bool KpiCrmOpportunitiesWon { get; set; }

        /// <summary>
        /// <para>Name: Kpi Crm Opportunities Won Value</para>
        /// <para>Internal: kpi_crm_opportunities_won_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("kpi_crm_opportunities_won_value")]
        [OdooField("kpi_crm_opportunities_won_value")]
        public int KpiCrmOpportunitiesWonValue { get; set; }

        /// <summary>
        /// <para>Name: Tickets Closed</para>
        /// <para>Internal: kpi_helpdesk_tickets_closed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("kpi_helpdesk_tickets_closed")]
        [OdooField("kpi_helpdesk_tickets_closed")]
        public bool KpiHelpdeskTicketsClosed { get; set; }

        /// <summary>
        /// <para>Name: Kpi Helpdesk Tickets Closed Value</para>
        /// <para>Internal: kpi_helpdesk_tickets_closed_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("kpi_helpdesk_tickets_closed_value")]
        [OdooField("kpi_helpdesk_tickets_closed_value")]
        public int KpiHelpdeskTicketsClosedValue { get; set; }

        /// <summary>
        /// <para>Name: Bank & Cash Moves</para>
        /// <para>Internal: kpi_account_bank_cash</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("kpi_account_bank_cash")]
        [OdooField("kpi_account_bank_cash")]
        public bool KpiAccountBankCash { get; set; }

        /// <summary>
        /// <para>Name: Kpi Account Bank Cash Value</para>
        /// <para>Internal: kpi_account_bank_cash_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("kpi_account_bank_cash_value")]
        [OdooField("kpi_account_bank_cash_value")]
        public decimal KpiAccountBankCashValue { get; set; }

        /// <summary>
        /// <para>Name: All Sales</para>
        /// <para>Internal: kpi_all_sale_total</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("kpi_all_sale_total")]
        [OdooField("kpi_all_sale_total")]
        public bool KpiAllSaleTotal { get; set; }

        /// <summary>
        /// <para>Name: Kpi All Sale Total Value</para>
        /// <para>Internal: kpi_all_sale_total_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("kpi_all_sale_total_value")]
        [OdooField("kpi_all_sale_total_value")]
        public decimal KpiAllSaleTotalValue { get; set; }

        /// <summary>
        /// <para>Name: eCommerce Sales</para>
        /// <para>Internal: kpi_website_sale_total</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("kpi_website_sale_total")]
        [OdooField("kpi_website_sale_total")]
        public bool KpiWebsiteSaleTotal { get; set; }

        /// <summary>
        /// <para>Name: Kpi Website Sale Total Value</para>
        /// <para>Internal: kpi_website_sale_total_value</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("kpi_website_sale_total_value")]
        [OdooField("kpi_website_sale_total_value")]
        public decimal KpiWebsiteSaleTotalValue { get; set; }

    }
}
