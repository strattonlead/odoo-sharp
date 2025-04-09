using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("website")]
    public partial class Website
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
        /// <para>Name: Website Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int Sequence { get; set; }

        /// <summary>
        /// <para>Name: Website Domain</para>
        /// <para>Internal: domain</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Languages</para>
        /// <para>Internal: language_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.lang</para>
        /// </summary>
        [JsonPropertyName("language_ids")]
        public List<int> LanguageIds { get; set; }

        /// <summary>
        /// <para>Name: Number of languages</para>
        /// <para>Internal: language_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("language_count")]
        public int LanguageCount { get; set; }

        /// <summary>
        /// <para>Name: Default Language</para>
        /// <para>Internal: default_lang_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.lang</para>
        /// </summary>
        [JsonPropertyName("default_lang_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? DefaultLangId { get; set; }

        /// <summary>
        /// <para>Name: Autoredirect Language</para>
        /// <para>Internal: auto_redirect_lang</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("auto_redirect_lang")]
        public bool AutoRedirectLang { get; set; }

        /// <summary>
        /// <para>Name: Cookies Bar</para>
        /// <para>Internal: cookies_bar</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("cookies_bar")]
        public bool CookiesBar { get; set; }

        /// <summary>
        /// <para>Name: Configurator Done</para>
        /// <para>Internal: configurator_done</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("configurator_done")]
        public bool ConfiguratorDone { get; set; }

        /// <summary>
        /// <para>Name: Block 3rd-party domains</para>
        /// <para>Internal: block_third_party_domains</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("block_third_party_domains")]
        public bool BlockThirdPartyDomains { get; set; }

        /// <summary>
        /// <para>Name: User list of blocked 3rd-party domains</para>
        /// <para>Internal: custom_blocked_third_party_domains</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("custom_blocked_third_party_domains")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string CustomBlockedThirdPartyDomains { get; set; }

        /// <summary>
        /// <para>Name: List of blocked 3rd-party domains</para>
        /// <para>Internal: blocked_third_party_domains</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("blocked_third_party_domains")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string BlockedThirdPartyDomains { get; set; }

        /// <summary>
        /// <para>Name: Website Logo</para>
        /// <para>Internal: logo</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("logo")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        public byte[] Logo { get; set; }

        /// <summary>
        /// <para>Name: X Account</para>
        /// <para>Internal: social_twitter</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("social_twitter")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SocialTwitter { get; set; }

        /// <summary>
        /// <para>Name: Facebook Account</para>
        /// <para>Internal: social_facebook</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("social_facebook")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SocialFacebook { get; set; }

        /// <summary>
        /// <para>Name: GitHub Account</para>
        /// <para>Internal: social_github</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("social_github")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SocialGithub { get; set; }

        /// <summary>
        /// <para>Name: LinkedIn Account</para>
        /// <para>Internal: social_linkedin</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("social_linkedin")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SocialLinkedin { get; set; }

        /// <summary>
        /// <para>Name: Youtube Account</para>
        /// <para>Internal: social_youtube</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("social_youtube")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SocialYoutube { get; set; }

        /// <summary>
        /// <para>Name: Instagram Account</para>
        /// <para>Internal: social_instagram</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("social_instagram")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SocialInstagram { get; set; }

        /// <summary>
        /// <para>Name: TikTok Account</para>
        /// <para>Internal: social_tiktok</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("social_tiktok")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string SocialTiktok { get; set; }

        /// <summary>
        /// <para>Name: Default Social Share Image</para>
        /// <para>Internal: social_default_image</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("social_default_image")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        public byte[] SocialDefaultImage { get; set; }

        /// <summary>
        /// <para>Name: Has Social Default Image</para>
        /// <para>Internal: has_social_default_image</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_social_default_image")]
        public bool HasSocialDefaultImage { get; set; }

        /// <summary>
        /// <para>Name: Google Analytics Key</para>
        /// <para>Internal: google_analytics_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_analytics_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string GoogleAnalyticsKey { get; set; }

        /// <summary>
        /// <para>Name: Google Search Console</para>
        /// <para>Internal: google_search_console</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_search_console")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string GoogleSearchConsole { get; set; }

        /// <summary>
        /// <para>Name: Google Maps API Key</para>
        /// <para>Internal: google_maps_api_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_maps_api_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string GoogleMapsApiKey { get; set; }

        /// <summary>
        /// <para>Name: Plausible Shared Key</para>
        /// <para>Internal: plausible_shared_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("plausible_shared_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string PlausibleSharedKey { get; set; }

        /// <summary>
        /// <para>Name: Plausible Site</para>
        /// <para>Internal: plausible_site</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("plausible_site")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string PlausibleSite { get; set; }

        /// <summary>
        /// <para>Name: Public User</para>
        /// <para>Internal: user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? UserId { get; set; }

        /// <summary>
        /// <para>Name: Content Delivery Network (CDN)</para>
        /// <para>Internal: cdn_activated</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("cdn_activated")]
        public bool CdnActivated { get; set; }

        /// <summary>
        /// <para>Name: CDN Base URL</para>
        /// <para>Internal: cdn_url</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("cdn_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string CdnUrl { get; set; }

        /// <summary>
        /// <para>Name: CDN Filters</para>
        /// <para>Internal: cdn_filters</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("cdn_filters")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string CdnFilters { get; set; }

        /// <summary>
        /// <para>Name: Public Partner</para>
        /// <para>Internal: partner_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Main Menu</para>
        /// <para>Internal: menu_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website.menu</para>
        /// </summary>
        [JsonPropertyName("menu_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? MenuId { get; set; }

        /// <summary>
        /// <para>Name: Homepage Url</para>
        /// <para>Internal: homepage_url</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("homepage_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string HomepageUrl { get; set; }

        /// <summary>
        /// <para>Name: Custom <head> code</para>
        /// <para>Internal: custom_code_head</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("custom_code_head")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string CustomCodeHead { get; set; }

        /// <summary>
        /// <para>Name: Custom end of <body> code</para>
        /// <para>Internal: custom_code_footer</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("custom_code_footer")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string CustomCodeFooter { get; set; }

        /// <summary>
        /// <para>Name: Robots.txt</para>
        /// <para>Internal: robots_txt</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("robots_txt")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string RobotsTxt { get; set; }

        /// <summary>
        /// <para>Name: Website Favicon</para>
        /// <para>Internal: favicon</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("favicon")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        public byte[] Favicon { get; set; }

        /// <summary>
        /// <para>Name: Theme</para>
        /// <para>Internal: theme_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.module.module</para>
        /// </summary>
        [JsonPropertyName("theme_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ThemeId { get; set; }

        /// <summary>
        /// <para>Name: Specific User Account</para>
        /// <para>Internal: specific_user_account</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("specific_user_account")]
        public bool SpecificUserAccount { get; set; }

        /// <summary>
        /// <para>Name: Customer Account</para>
        /// <para>Internal: auth_signup_uninvited</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("auth_signup_uninvited")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string AuthSignupUninvited { get; set; }

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

        /// <summary>
        /// <para>Name: Default Sales Teams</para>
        /// <para>Internal: crm_default_team_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.team</para>
        /// </summary>
        [JsonPropertyName("crm_default_team_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CrmDefaultTeamId { get; set; }

        /// <summary>
        /// <para>Name: Default Salesperson</para>
        /// <para>Internal: crm_default_user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("crm_default_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CrmDefaultUserId { get; set; }

        /// <summary>
        /// <para>Name: Re-order From Portal</para>
        /// <para>Internal: enabled_portal_reorder_button</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("enabled_portal_reorder_button")]
        public bool EnabledPortalReorderButton { get; set; }

        /// <summary>
        /// <para>Name: Salesperson</para>
        /// <para>Internal: salesperson_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("salesperson_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SalespersonId { get; set; }

        /// <summary>
        /// <para>Name: Sales Team</para>
        /// <para>Internal: salesteam_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.team</para>
        /// </summary>
        [JsonPropertyName("salesteam_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? SalesteamId { get; set; }

        /// <summary>
        /// <para>Name: Line Subtotals Tax Display</para>
        /// <para>Internal: show_line_subtotals_tax_selection</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("show_line_subtotals_tax_selection")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ShowLineSubtotalsTaxSelection { get; set; }

        /// <summary>
        /// <para>Name: Add To Cart Action</para>
        /// <para>Internal: add_to_cart_action</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("add_to_cart_action")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string AddToCartAction { get; set; }

        /// <summary>
        /// <para>Name: Customer Accounts</para>
        /// <para>Internal: account_on_checkout</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("account_on_checkout")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string AccountOnCheckout { get; set; }

        /// <summary>
        /// <para>Name: Cart Recovery Email</para>
        /// <para>Internal: cart_recovery_mail_template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.template</para>
        /// </summary>
        [JsonPropertyName("cart_recovery_mail_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? CartRecoveryMailTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Contact Us Button URL</para>
        /// <para>Internal: contact_us_button_url</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("contact_us_button_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ContactUsButtonUrl { get; set; }

        /// <summary>
        /// <para>Name: Abandoned Delay</para>
        /// <para>Internal: cart_abandoned_delay</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("cart_abandoned_delay")]
        public double CartAbandonedDelay { get; set; }

        /// <summary>
        /// <para>Name: Send email to customers who abandoned their cart.</para>
        /// <para>Internal: send_abandoned_cart_email</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("send_abandoned_cart_email")]
        public bool SendAbandonedCartEmail { get; set; }

        /// <summary>
        /// <para>Name: Number of products in the grid on the shop</para>
        /// <para>Internal: shop_ppg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("shop_ppg")]
        public int ShopPpg { get; set; }

        /// <summary>
        /// <para>Name: Number of grid columns on the shop</para>
        /// <para>Internal: shop_ppr</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("shop_ppr")]
        public int ShopPpr { get; set; }

        /// <summary>
        /// <para>Name: Grid-gap on the shop</para>
        /// <para>Internal: shop_gap</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("shop_gap")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ShopGap { get; set; }

        /// <summary>
        /// <para>Name: Shop Default Sort</para>
        /// <para>Internal: shop_default_sort</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("shop_default_sort")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ShopDefaultSort { get; set; }

        /// <summary>
        /// <para>Name: E-Commerce Extra Fields</para>
        /// <para>Internal: shop_extra_field_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: website.sale.extra.field</para>
        /// </summary>
        [JsonPropertyName("shop_extra_field_ids")]
        public List<int> ShopExtraFieldIds { get; set; }

        /// <summary>
        /// <para>Name: Product Page Image Layout</para>
        /// <para>Internal: product_page_image_layout</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("product_page_image_layout")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ProductPageImageLayout { get; set; }

        /// <summary>
        /// <para>Name: Product Page Image Width</para>
        /// <para>Internal: product_page_image_width</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("product_page_image_width")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ProductPageImageWidth { get; set; }

        /// <summary>
        /// <para>Name: Product Page Image Spacing</para>
        /// <para>Internal: product_page_image_spacing</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("product_page_image_spacing")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ProductPageImageSpacing { get; set; }

        /// <summary>
        /// <para>Name: Ecommerce Access</para>
        /// <para>Internal: ecommerce_access</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("ecommerce_access")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string EcommerceAccess { get; set; }

        /// <summary>
        /// <para>Name: Product Page Grid Columns</para>
        /// <para>Internal: product_page_grid_columns</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("product_page_grid_columns")]
        public int ProductPageGridColumns { get; set; }

        /// <summary>
        /// <para>Name: Hide 'Add To Cart' when price = 0</para>
        /// <para>Internal: prevent_zero_price_sale</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("prevent_zero_price_sale")]
        public bool PreventZeroPriceSale { get; set; }

        /// <summary>
        /// <para>Name: Text to show instead of price</para>
        /// <para>Internal: prevent_zero_price_sale_text</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("prevent_zero_price_sale_text")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string PreventZeroPriceSaleText { get; set; }

        /// <summary>
        /// <para>Name: Default Currency</para>
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
        public int? CurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Price list available for this Ecommerce/Website</para>
        /// <para>Internal: pricelist_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: product.pricelist</para>
        /// </summary>
        [JsonPropertyName("pricelist_ids")]
        public List<int> PricelistIds { get; set; }

    }
}
