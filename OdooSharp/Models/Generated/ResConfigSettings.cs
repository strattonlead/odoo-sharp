using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("res.config.settings")]
    public partial class ResConfigSettings
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
        /// <para>Name: Web App Name</para>
        /// <para>Internal: web_app_name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("web_app_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("web_app_name")]
        public string WebAppName { get; set; }

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
        [OdooField("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Is Root Company</para>
        /// <para>Internal: is_root_company</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_root_company")]
        [OdooField("is_root_company")]
        public bool IsRootCompany { get; set; }

        /// <summary>
        /// <para>Name: Default Access Rights</para>
        /// <para>Internal: user_default_rights</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("user_default_rights")]
        [OdooField("user_default_rights")]
        public bool UserDefaultRights { get; set; }

        /// <summary>
        /// <para>Name: Allow users to import data from CSV/XLS/XLSX/ODS files</para>
        /// <para>Internal: module_base_import</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_base_import")]
        [OdooField("module_base_import")]
        public bool ModuleBaseImport { get; set; }

        /// <summary>
        /// <para>Name: Allow the users to synchronize their calendar  with Google Calendar</para>
        /// <para>Internal: module_google_calendar</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_google_calendar")]
        [OdooField("module_google_calendar")]
        public bool ModuleGoogleCalendar { get; set; }

        /// <summary>
        /// <para>Name: Allow the users to synchronize their calendar with Outlook Calendar</para>
        /// <para>Internal: module_microsoft_calendar</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_microsoft_calendar")]
        [OdooField("module_microsoft_calendar")]
        public bool ModuleMicrosoftCalendar { get; set; }

        /// <summary>
        /// <para>Name: Allow integration with the mail plugins</para>
        /// <para>Internal: module_mail_plugin</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_mail_plugin")]
        [OdooField("module_mail_plugin")]
        public bool ModuleMailPlugin { get; set; }

        /// <summary>
        /// <para>Name: Use external authentication providers (OAuth)</para>
        /// <para>Internal: module_auth_oauth</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_auth_oauth")]
        [OdooField("module_auth_oauth")]
        public bool ModuleAuthOauth { get; set; }

        /// <summary>
        /// <para>Name: LDAP Authentication</para>
        /// <para>Internal: module_auth_ldap</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_auth_ldap")]
        [OdooField("module_auth_ldap")]
        public bool ModuleAuthLdap { get; set; }

        /// <summary>
        /// <para>Name: Manage Inter Company</para>
        /// <para>Internal: module_account_inter_company_rules</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_inter_company_rules")]
        [OdooField("module_account_inter_company_rules")]
        public bool ModuleAccountInterCompanyRules { get; set; }

        /// <summary>
        /// <para>Name: VoIP</para>
        /// <para>Internal: module_voip</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_voip")]
        [OdooField("module_voip")]
        public bool ModuleVoip { get; set; }

        /// <summary>
        /// <para>Name: Unsplash Image Library</para>
        /// <para>Internal: module_web_unsplash</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_web_unsplash")]
        [OdooField("module_web_unsplash")]
        public bool ModuleWebUnsplash { get; set; }

        /// <summary>
        /// <para>Name: SMS</para>
        /// <para>Internal: module_sms</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_sms")]
        [OdooField("module_sms")]
        public bool ModuleSms { get; set; }

        /// <summary>
        /// <para>Name: Partner Autocomplete</para>
        /// <para>Internal: module_partner_autocomplete</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_partner_autocomplete")]
        [OdooField("module_partner_autocomplete")]
        public bool ModulePartnerAutocomplete { get; set; }

        /// <summary>
        /// <para>Name: GeoLocalize</para>
        /// <para>Internal: module_base_geolocalize</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_base_geolocalize")]
        [OdooField("module_base_geolocalize")]
        public bool ModuleBaseGeolocalize { get; set; }

        /// <summary>
        /// <para>Name: reCAPTCHA</para>
        /// <para>Internal: module_google_recaptcha</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_google_recaptcha")]
        [OdooField("module_google_recaptcha")]
        public bool ModuleGoogleRecaptcha { get; set; }

        /// <summary>
        /// <para>Name: Cloudflare Turnstile</para>
        /// <para>Internal: module_website_cf_turnstile</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_website_cf_turnstile")]
        [OdooField("module_website_cf_turnstile")]
        public bool ModuleWebsiteCfTurnstile { get; set; }

        /// <summary>
        /// <para>Name: Google Address Autocomplete</para>
        /// <para>Internal: module_google_address_autocomplete</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_google_address_autocomplete")]
        [OdooField("module_google_address_autocomplete")]
        public bool ModuleGoogleAddressAutocomplete { get; set; }

        /// <summary>
        /// <para>Name: Custom Report Footer</para>
        /// <para>Internal: report_footer</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("report_footer")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("report_footer")]
        public string ReportFooter { get; set; }

        /// <summary>
        /// <para>Name: Multi-Currencies</para>
        /// <para>Internal: group_multi_currency</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_multi_currency")]
        [OdooField("group_multi_currency")]
        public bool GroupMultiCurrency { get; set; }

        /// <summary>
        /// <para>Name: Document Template</para>
        /// <para>Internal: external_report_layout_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("external_report_layout_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("external_report_layout_id")]
        public int? ExternalReportLayoutId { get; set; }

        /// <summary>
        /// <para>Name: Show Effect</para>
        /// <para>Internal: show_effect</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_effect")]
        [OdooField("show_effect")]
        public bool ShowEffect { get; set; }

        /// <summary>
        /// <para>Name: Number of Companies</para>
        /// <para>Internal: company_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("company_count")]
        [OdooField("company_count")]
        public int CompanyCount { get; set; }

        /// <summary>
        /// <para>Name: Number of Active Users</para>
        /// <para>Internal: active_user_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("active_user_count")]
        [OdooField("active_user_count")]
        public int ActiveUserCount { get; set; }

        /// <summary>
        /// <para>Name: Number of Languages</para>
        /// <para>Internal: language_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("language_count")]
        [OdooField("language_count")]
        public int LanguageCount { get; set; }

        /// <summary>
        /// <para>Name: Company Name</para>
        /// <para>Internal: company_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("company_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// <para>Name: Company Informations</para>
        /// <para>Internal: company_informations</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("company_informations")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_informations")]
        public string CompanyInformations { get; set; }

        /// <summary>
        /// <para>Name: Company Country Code</para>
        /// <para>Internal: company_country_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("company_country_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_country_code")]
        public string CompanyCountryCode { get; set; }

        /// <summary>
        /// <para>Name: Profiling enabled until</para>
        /// <para>Internal: profiling_enabled_until</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("profiling_enabled_until")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("profiling_enabled_until")]
        public DateTime? ProfilingEnabledUntil { get; set; }

        /// <summary>
        /// <para>Name: Enable reCAPTCHA</para>
        /// <para>Internal: enable_recaptcha</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("enable_recaptcha")]
        [OdooField("enable_recaptcha")]
        public bool EnableRecaptcha { get; set; }

        /// <summary>
        /// <para>Name: Site Key</para>
        /// <para>Internal: recaptcha_public_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("recaptcha_public_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("recaptcha_public_key")]
        public string RecaptchaPublicKey { get; set; }

        /// <summary>
        /// <para>Name: Secret Key</para>
        /// <para>Internal: recaptcha_private_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("recaptcha_private_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("recaptcha_private_key")]
        public string RecaptchaPrivateKey { get; set; }

        /// <summary>
        /// <para>Name: Minimum score</para>
        /// <para>Internal: recaptcha_min_score</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("recaptcha_min_score")]
        [OdooField("recaptcha_min_score")]
        public double RecaptchaMinScore { get; set; }

        /// <summary>
        /// <para>Name: Token Map Box</para>
        /// <para>Internal: map_box_token</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("map_box_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("map_box_token")]
        public string MapBoxToken { get; set; }

        /// <summary>
        /// <para>Name: Use Custom Email Servers</para>
        /// <para>Internal: external_email_server_default</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("external_email_server_default")]
        [OdooField("external_email_server_default")]
        public bool ExternalEmailServerDefault { get; set; }

        /// <summary>
        /// <para>Name: Fail Mail</para>
        /// <para>Internal: fail_counter</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("fail_counter")]
        [OdooField("fail_counter")]
        public int FailCounter { get; set; }

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
        /// <para>Name: Support Gmail Authentication</para>
        /// <para>Internal: module_google_gmail</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_google_gmail")]
        [OdooField("module_google_gmail")]
        public bool ModuleGoogleGmail { get; set; }

        /// <summary>
        /// <para>Name: Support Outlook Authentication</para>
        /// <para>Internal: module_microsoft_outlook</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_microsoft_outlook")]
        [OdooField("module_microsoft_outlook")]
        public bool ModuleMicrosoftOutlook { get; set; }

        /// <summary>
        /// <para>Name: Restrict Template Rendering</para>
        /// <para>Internal: restrict_template_rendering</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("restrict_template_rendering")]
        [OdooField("restrict_template_rendering")]
        public bool RestrictTemplateRendering { get; set; }

        /// <summary>
        /// <para>Name: Use Twilio ICE servers</para>
        /// <para>Internal: use_twilio_rtc_servers</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_twilio_rtc_servers")]
        [OdooField("use_twilio_rtc_servers")]
        public bool UseTwilioRtcServers { get; set; }

        /// <summary>
        /// <para>Name: Twilio Account SID</para>
        /// <para>Internal: twilio_account_sid</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("twilio_account_sid")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("twilio_account_sid")]
        public string TwilioAccountSid { get; set; }

        /// <summary>
        /// <para>Name: Twilio Account Auth Token</para>
        /// <para>Internal: twilio_account_token</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("twilio_account_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("twilio_account_token")]
        public string TwilioAccountToken { get; set; }

        /// <summary>
        /// <para>Name: SFU Server URL</para>
        /// <para>Internal: sfu_server_url</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("sfu_server_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sfu_server_url")]
        public string SfuServerUrl { get; set; }

        /// <summary>
        /// <para>Name: SFU Server key</para>
        /// <para>Internal: sfu_server_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("sfu_server_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sfu_server_key")]
        public string SfuServerKey { get; set; }

        /// <summary>
        /// <para>Name: Email Header Color</para>
        /// <para>Internal: email_primary_color</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email_primary_color")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email_primary_color")]
        public string EmailPrimaryColor { get; set; }

        /// <summary>
        /// <para>Name: Email Button Color</para>
        /// <para>Internal: email_secondary_color</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email_secondary_color")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email_secondary_color")]
        public string EmailSecondaryColor { get; set; }

        /// <summary>
        /// <para>Name: Tenor API key</para>
        /// <para>Internal: tenor_api_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("tenor_api_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("tenor_api_key")]
        public string TenorApiKey { get; set; }

        /// <summary>
        /// <para>Name: Message Translation API Key</para>
        /// <para>Internal: google_translate_api_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_translate_api_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("google_translate_api_key")]
        public string GoogleTranslateApiKey { get; set; }

        /// <summary>
        /// <para>Name: Analytic Accounting</para>
        /// <para>Internal: group_analytic_accounting</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_analytic_accounting")]
        [OdooField("group_analytic_accounting")]
        public bool GroupAnalyticAccounting { get; set; }

        /// <summary>
        /// <para>Name: Enable password reset from Login page</para>
        /// <para>Internal: auth_signup_reset_password</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("auth_signup_reset_password")]
        [OdooField("auth_signup_reset_password")]
        public bool AuthSignupResetPassword { get; set; }

        /// <summary>
        /// <para>Name: Customer Account</para>
        /// <para>Internal: auth_signup_uninvited</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [b2b]=On invitation,[b2c]=Free sign up</para>
        /// </summary>
        [JsonPropertyName("auth_signup_uninvited")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("auth_signup_uninvited")]
        public string AuthSignupUninvited { get; set; }

        /// <summary>
        /// <para>Name: Template user for new users created through signup</para>
        /// <para>Internal: auth_signup_template_user_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("auth_signup_template_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("auth_signup_template_user_id")]
        public int? AuthSignupTemplateUserId { get; set; }

        /// <summary>
        /// <para>Name: Enforce two-factor authentication</para>
        /// <para>Internal: auth_totp_enforce</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("auth_totp_enforce")]
        [OdooField("auth_totp_enforce")]
        public bool AuthTotpEnforce { get; set; }

        /// <summary>
        /// <para>Name: Two-factor authentication enforcing policy</para>
        /// <para>Internal: auth_totp_policy</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [employee_required]=Employees only,[all_required]=All users</para>
        /// </summary>
        [JsonPropertyName("auth_totp_policy")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("auth_totp_policy")]
        public string AuthTotpPolicy { get; set; }

        /// <summary>
        /// <para>Name: Gmail Client Id</para>
        /// <para>Internal: google_gmail_client_identifier</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_gmail_client_identifier")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("google_gmail_client_identifier")]
        public string GoogleGmailClientIdentifier { get; set; }

        /// <summary>
        /// <para>Name: Gmail Client Secret</para>
        /// <para>Internal: google_gmail_client_secret</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_gmail_client_secret")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("google_gmail_client_secret")]
        public string GoogleGmailClientSecret { get; set; }

        /// <summary>
        /// <para>Name: Units of Measure & Packagings</para>
        /// <para>Internal: group_uom</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_uom")]
        [OdooField("group_uom")]
        public bool GroupUom { get; set; }

        /// <summary>
        /// <para>Name: Variants</para>
        /// <para>Internal: group_product_variant</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_product_variant")]
        [OdooField("group_product_variant")]
        public bool GroupProductVariant { get; set; }

        /// <summary>
        /// <para>Name: Promotions, Coupons, Gift Card & Loyalty Program</para>
        /// <para>Internal: module_loyalty</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_loyalty")]
        [OdooField("module_loyalty")]
        public bool ModuleLoyalty { get; set; }

        /// <summary>
        /// <para>Name: Pricelists</para>
        /// <para>Internal: group_product_pricelist</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_product_pricelist")]
        [OdooField("group_product_pricelist")]
        public bool GroupProductPricelist { get; set; }

        /// <summary>
        /// <para>Name: Weight unit of measure</para>
        /// <para>Internal: product_weight_in_lbs</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [0]=Kilograms,[1]=Pounds</para>
        /// </summary>
        [JsonPropertyName("product_weight_in_lbs")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("product_weight_in_lbs")]
        public string ProductWeightInLbs { get; set; }

        /// <summary>
        /// <para>Name: Volume unit of measure</para>
        /// <para>Internal: product_volume_volume_in_cubic_feet</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [0]=Cubic Meters,[1]=Cubic Feet</para>
        /// </summary>
        [JsonPropertyName("product_volume_volume_in_cubic_feet")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("product_volume_volume_in_cubic_feet")]
        public string ProductVolumeVolumeInCubicFeet { get; set; }

        /// <summary>
        /// <para>Name: Access Key</para>
        /// <para>Internal: unsplash_access_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("unsplash_access_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("unsplash_access_key")]
        public string UnsplashAccessKey { get; set; }

        /// <summary>
        /// <para>Name: Application ID</para>
        /// <para>Internal: unsplash_app_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("unsplash_app_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("unsplash_app_id")]
        public string UnsplashAppId { get; set; }

        /// <summary>
        /// <para>Name: Disable link redirection to mobile app</para>
        /// <para>Internal: disable_redirect_firebase_dynamic_link</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("disable_redirect_firebase_dynamic_link")]
        [OdooField("disable_redirect_firebase_dynamic_link")]
        public bool DisableRedirectFirebaseDynamicLink { get; set; }

        /// <summary>
        /// <para>Name: Push Notifications</para>
        /// <para>Internal: enable_ocn</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("enable_ocn")]
        [OdooField("enable_ocn")]
        public bool EnableOcn { get; set; }

        /// <summary>
        /// <para>Name: Insufficient credit</para>
        /// <para>Internal: partner_autocomplete_insufficient_credit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("partner_autocomplete_insufficient_credit")]
        [OdooField("partner_autocomplete_insufficient_credit")]
        public bool PartnerAutocompleteInsufficientCredit { get; set; }

        /// <summary>
        /// <para>Name: Customer API Keys</para>
        /// <para>Internal: portal_allow_api_keys</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("portal_allow_api_keys")]
        [OdooField("portal_allow_api_keys")]
        public bool PortalAllowApiKeys { get; set; }

        /// <summary>
        /// <para>Name: API key</para>
        /// <para>Internal: barcodelookup_api_key</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("barcodelookup_api_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("barcodelookup_api_key")]
        public string BarcodelookupApiKey { get; set; }

        /// <summary>
        /// <para>Name: Print In Color</para>
        /// <para>Internal: snailmail_color</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("snailmail_color")]
        [OdooField("snailmail_color")]
        public bool SnailmailColor { get; set; }

        /// <summary>
        /// <para>Name: Add a Cover Page</para>
        /// <para>Internal: snailmail_cover</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("snailmail_cover")]
        [OdooField("snailmail_cover")]
        public bool SnailmailCover { get; set; }

        /// <summary>
        /// <para>Name: Print Both sides</para>
        /// <para>Internal: snailmail_duplex</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("snailmail_duplex")]
        [OdooField("snailmail_duplex")]
        public bool SnailmailDuplex { get; set; }

        /// <summary>
        /// <para>Name: Snailmail Cover Readonly</para>
        /// <para>Internal: snailmail_cover_readonly</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("snailmail_cover_readonly")]
        [OdooField("snailmail_cover_readonly")]
        public bool SnailmailCoverReadonly { get; set; }

        /// <summary>
        /// <para>Name: Digest Emails</para>
        /// <para>Internal: digest_emails</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("digest_emails")]
        [OdooField("digest_emails")]
        public bool DigestEmails { get; set; }

        /// <summary>
        /// <para>Name: Digest Email</para>
        /// <para>Internal: digest_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: digest.digest</para>
        /// </summary>
        [JsonPropertyName("digest_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("digest_id")]
        public int? DigestId { get; set; }

        /// <summary>
        /// <para>Name: Sign Terms & Conditions</para>
        /// <para>Internal: sign_terms</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("sign_terms")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sign_terms")]
        public string SignTerms { get; set; }

        /// <summary>
        /// <para>Name: Sign Terms & Conditions as a Web page</para>
        /// <para>Internal: sign_terms_html</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("sign_terms_html")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sign_terms_html")]
        public string SignTermsHtml { get; set; }

        /// <summary>
        /// <para>Name: Sign Terms & Conditions format</para>
        /// <para>Internal: sign_terms_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [plain]=Terms in Email,[html]=Terms as Web Page</para>
        /// </summary>
        [JsonPropertyName("sign_terms_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sign_terms_type")]
        public string SignTermsType { get; set; }

        /// <summary>
        /// <para>Name: Display sign preview button</para>
        /// <para>Internal: sign_preview_ready</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sign_preview_ready")]
        [OdooField("sign_preview_ready")]
        public bool SignPreviewReady { get; set; }

        /// <summary>
        /// <para>Name: Sign Default Terms & Conditions</para>
        /// <para>Internal: use_sign_terms</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_sign_terms")]
        [OdooField("use_sign_terms")]
        public bool UseSignTerms { get; set; }

        /// <summary>
        /// <para>Name: Manage template access</para>
        /// <para>Internal: group_manage_template_access</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_manage_template_access")]
        [OdooField("group_manage_template_access")]
        public bool GroupManageTemplateAccess { get; set; }

        /// <summary>
        /// <para>Name: Identify with itsme®</para>
        /// <para>Internal: module_sign_itsme</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_sign_itsme")]
        [OdooField("module_sign_itsme")]
        public bool ModuleSignItsme { get; set; }

        /// <summary>
        /// <para>Name: Signing certificate</para>
        /// <para>Internal: signing_certificate_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: certificate.certificate</para>
        /// </summary>
        [JsonPropertyName("signing_certificate_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("signing_certificate_id")]
        public int? SigningCertificateId { get; set; }

        /// <summary>
        /// <para>Name: Has Accounting Entries</para>
        /// <para>Internal: has_accounting_entries</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_accounting_entries")]
        [OdooField("has_accounting_entries")]
        public bool HasAccountingEntries { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
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
        /// <para>Name: Currency Exchange Journal</para>
        /// <para>Internal: currency_exchange_journal_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("currency_exchange_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("currency_exchange_journal_id")]
        public int? CurrencyExchangeJournalId { get; set; }

        /// <summary>
        /// <para>Name: Gain Exchange Rate Account</para>
        /// <para>Internal: income_currency_exchange_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("income_currency_exchange_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("income_currency_exchange_account_id")]
        public int? IncomeCurrencyExchangeAccountId { get; set; }

        /// <summary>
        /// <para>Name: Loss Exchange Rate Account</para>
        /// <para>Internal: expense_currency_exchange_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("expense_currency_exchange_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("expense_currency_exchange_account_id")]
        public int? ExpenseCurrencyExchangeAccountId { get; set; }

        /// <summary>
        /// <para>Name: Company has a chart of accounts</para>
        /// <para>Internal: has_chart_of_accounts</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_chart_of_accounts")]
        [OdooField("has_chart_of_accounts")]
        public bool HasChartOfAccounts { get; set; }

        /// <summary>
        /// <para>Name: Chart Template</para>
        /// <para>Internal: chart_template</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [de_skr03]=🇩🇪 Germany - German Chart of Accounts SKR03,[de_skr04]=🇩🇪 Germany - German chart of accounts SKR04,[generic_coa]=Vereinigte Staaten von Amerika (Generisch),[ae]=🇦🇪 United Arab Emirates,[ar_base]=🇦🇷 Argentina - Generic Chart of Accounts Argentina Single Taxpayer / Basis,[ar_ex]=🇦🇷 Argentina - Argentine Generic Chart of Accounts for Exempt Individuals,[ar_ri]=🇦🇷 Argentina - Argentine Generic Chart of Accounts for Registered Accountants,[at]=🇦🇹 Austria,[au]=🇦🇺 Australia,[bd]=🇧🇩 Bangladesh,[be_comp]=🇧🇪 Belgium - Unternehmen,[be_asso]=🇧🇪 Belgium - Vereinigungen und Stiftungen,[bf]=🇧🇫 Burkina Faso - SYSCOHADA for Companies,[bf_syscebnl]=🇧🇫 Burkina Faso - SYSCEBNL for Associations,[bg]=🇧🇬 Bulgaria,[bh]=🇧🇭 Bahrain,[bj]=🇧🇯 Benin - SYSCOHADA for Companies,[bj_syscebnl]=🇧🇯 Benin - SYSCEBNL for Associations,[bo]=🇧🇴 Bolivia,[br]=🇧🇷 Brazil,[ca_2023]=🇨🇦 Canada,[cd]=🇨🇩 Congo (DRC) - SYSCOHADA for Companies,[cd_syscebnl]=🇨🇩 Congo (DRC) - SYSCEBNL for Associations,[cf]=🇨🇫 Central African Republic - SYSCOHADA for Companies,[cf_syscebnl]=🇨🇫 Central African Republic - SYSCEBNL for Associations,[cg]=🇨🇬 Congo (Republic) - SYSCOHADA for Companies,[cg_syscebnl]=🇨🇬 Congo (Republic) - SYSCEBNL for Associations,[ch]=🇨🇭 Switzerland,[ci]=🇨🇮 Côte d'Ivoire - SYSCOHADA for Companies,[ci_syscebnl]=🇨🇮 Côte d'Ivoire - SYSCEBNL for Associations,[cl]=🇨🇱 Chile,[cm]=🇨🇲 Cameroon - SYSCOHADA for Companies,[cm_syscebnl]=🇨🇲 Cameroon - SYSCEBNL for Associations,[cn]=🇨🇳 China,[cn_large_bis]=🇨🇳 China - Large Business,[co]=🇨🇴 Colombia,[cr]=🇨🇷 Costa Rica,[cy]=🇨🇾 Cyprus,[cz]=🇨🇿 Czech Republic,[dk]=🇩🇰 Denmark,[do]=🇩🇴 Dominican Republic,[dz]=🇩🇿 Algeria,[ec]=🇪🇨 Ecuador,[ee]=🇪🇪 Estonia,[eg]=🇪🇬 Egypt,[es_pymes]=🇪🇸 Spain - SMEs (2008),[es_assec]=🇪🇸 Spain - Non-profit entities (2008),[es_canary_assoc]=🇪🇸 Spain - Canary Islands - PGCE non-profit entities (2008),[es_canary_full]=🇪🇸 Spain - Canary Islands - Complete (2008),[es_canary_pymes]=🇪🇸 Spain - Canary Islands - SMEs (2008),[es_coop_full]=🇪🇸 Spain - Cooperatives - Complete (2008),[es_coop_pymes]=🇪🇸 Spain - Cooperatives - SMEs (2008),[es_full]=🇪🇸 Spain - Complete (2008),[et]=🇪🇹 Ethiopia,[fi]=🇫🇮 Finland,[fr]=🇫🇷 France,[mc]=🇲🇨 Monaco,[ga]=🇬🇦 Gabon - SYSCOHADA for Companies,[ga_syscebnl]=🇬🇦 Gabon - SYSCEBNL for Associations,[gn]=🇬🇳 Guinea - SYSCOHADA for Companies,[gn_syscebnl]=🇬🇳 Guinea - SYSCEBNL for Associations,[gq]=🇬🇶 Equatorial Guinea - SYSCOHADA for Companies,[gq_syscebnl]=🇬🇶 Equatorial Guinea - SYSCEBNL for Associations,[gr]=🇬🇷 Greece,[gt]=🇬🇹 Guatemala,[gw]=🇬🇼 Guinea-Bissau - SYSCOHADA for Companies,[gw_syscebnl]=🇬🇼 Guinea-Bissau - SYSCEBNL for Associations,[hk]=🇭🇰 Hong Kong,[hn]=🇭🇳 Honduras,[hr]=🇭🇷 Croatia,[hr_kuna]=🇭🇷 Croatia - RRIF-ov računski plan za poduzetnike,[hu]=🇭🇺 Hungary,[id]=🇮🇩 Indonesia,[ie]=🇮🇪 Ireland,[il]=🇮🇱 Israel,[in]=🇮🇳 India,[iq]=🇮🇶 Iraq,[it]=🇮🇹 Italy,[jo_standard]=🇯🇴 Jordan,[jp]=🇯🇵 Japan,[ke]=🇰🇪 Kenya,[km]=🇰🇲 Comoros - SYSCOHADA for Companies,[km_syscebnl]=🇰🇲 Comoros - SYSCEBNL for Associations,[kr]=🇰🇷 South Korea,[kw]=🇰🇼 Kuwait,[kz]=🇰🇿 Kazakhstan,[lb]=🇱🇧 Lebanon,[lt]=🇱🇹 Lithuania,[lu]=🇱🇺 Luxembourg,[lv]=🇱🇻 Latvia,[ma]=🇲🇦 Morocco,[ml]=🇲🇱 Mali - SYSCOHADA for Companies,[ml_syscebnl]=🇲🇱 Mali - SYSCEBNL for Associations,[mn]=🇲🇳 Mongolia,[mt]=🇲🇹 Malta,[mu]=🇲🇺 Mauritius,[mx]=🇲🇽 Mexico,[my]=🇲🇾 Malaysia,[mz]=🇲🇿 Mozambique,[ne]=🇳🇪 Niger - SYSCOHADA for Companies,[ne_syscebnl]=🇳🇪 Niger - SYSCEBNL for Associations,[ng]=🇳🇬 Nigeria,[nl]=🇳🇱 Netherlands,[no]=🇳🇴 Norway,[nz]=🇳🇿 New Zealand,[pa]=🇵🇦 Panama,[pe]=🇵🇪 Peru,[ph]=🇵🇭 Philippines,[pk]=🇵🇰 Pakistan,[pl]=🇵🇱 Poland,[pt]=🇵🇹 Portugal,[qa]=🇶🇦 Qatar,[ro]=🇷🇴 Romania,[rs]=🇷🇸 Serbia,[rw]=🇷🇼 Rwanda,[sa]=🇸🇦 Saudi Arabia,[se]=🇸🇪 Sweden,[se_K2]=🇸🇪 Sweden - Swedish BAS Chart of Account complete K2,[se_K3]=🇸🇪 Sweden - Swedish BAS Chart of Account complete K3,[sg]=🇸🇬 Singapore,[si]=🇸🇮 Slovenia,[sk]=🇸🇰 Slovakia,[sn]=🇸🇳 Senegal - SYSCOHADA for Companies,[sn_syscebnl]=🇸🇳 Senegal - SYSCEBNL for Associations,[syscebnl]=SYSCEBNL,[syscohada]=SYSCOHADA - Revised,[td]=🇹🇩 Chad - SYSCOHADA for Companies,[td_syscebnl]=🇹🇩 Chad - SYSCEBNL for Associations,[tg]=🇹🇬 Togo - SYSCOHADA for Companies,[tg_syscebnl]=🇹🇬 Togo - SYSCEBNL for Associations,[th]=🇹🇭 Thailand,[tn]=🇹🇳 Tunisia,[tr]=🇹🇷 Türkiye,[tw]=🇹🇼 Taiwan,[tz]=🇹🇿 Tanzania,[ua_psbo]=🇺🇦 Ukraine - IFRS Chart of Accounts,[ug]=🇺🇬 Uganda - Uganda Generic Chart of Accounts,[uk]=🇬🇧 United Kingdom,[uy]=🇺🇾 Uruguay - Uruguayan Generic Chart of Accounts,[ve]=🇻🇪 Venezuela,[vn]=🇻🇳 Vietnam,[za]=🇿🇦 South Africa,[zm]=🇿🇲 Zambia</para>
        /// </summary>
        [JsonPropertyName("chart_template")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("chart_template")]
        public string ChartTemplate { get; set; }

        /// <summary>
        /// <para>Name: Default Sale Tax</para>
        /// <para>Internal: sale_tax_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("sale_tax_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sale_tax_id")]
        public int? SaleTaxId { get; set; }

        /// <summary>
        /// <para>Name: Default Purchase Tax</para>
        /// <para>Internal: purchase_tax_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("purchase_tax_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("purchase_tax_id")]
        public int? PurchaseTaxId { get; set; }

        /// <summary>
        /// <para>Name: Default Sales Price Include</para>
        /// <para>Internal: account_price_include</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [tax_included]=Tax Included,[tax_excluded]=Tax Excluded</para>
        /// </summary>
        [JsonPropertyName("account_price_include")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_price_include")]
        public string AccountPriceInclude { get; set; }

        /// <summary>
        /// <para>Name: Tax calculation rounding method</para>
        /// <para>Internal: tax_calculation_rounding_method</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [round_per_line]=Round per Line,[round_globally]=Round Globally</para>
        /// </summary>
        [JsonPropertyName("tax_calculation_rounding_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("tax_calculation_rounding_method")]
        public string TaxCalculationRoundingMethod { get; set; }

        /// <summary>
        /// <para>Name: Bank Suspense</para>
        /// <para>Internal: account_journal_suspense_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_journal_suspense_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_journal_suspense_account_id")]
        public int? AccountJournalSuspenseAccountId { get; set; }

        /// <summary>
        /// <para>Name: Internal Transfer</para>
        /// <para>Internal: transfer_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("transfer_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("transfer_account_id")]
        public int? TransferAccountId { get; set; }

        /// <summary>
        /// <para>Name: Accounting</para>
        /// <para>Internal: module_account_accountant</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_accountant")]
        [OdooField("module_account_accountant")]
        public bool ModuleAccountAccountant { get; set; }

        /// <summary>
        /// <para>Name: Warnings in Invoices</para>
        /// <para>Internal: group_warning_account</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_warning_account")]
        [OdooField("group_warning_account")]
        public bool GroupWarningAccount { get; set; }

        /// <summary>
        /// <para>Name: Cash Rounding</para>
        /// <para>Internal: group_cash_rounding</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_cash_rounding")]
        [OdooField("group_cash_rounding")]
        public bool GroupCashRounding { get; set; }

        /// <summary>
        /// <para>Name: Sale Receipt</para>
        /// <para>Internal: group_show_sale_receipts</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_show_sale_receipts")]
        [OdooField("group_show_sale_receipts")]
        public bool GroupShowSaleReceipts { get; set; }

        /// <summary>
        /// <para>Name: Purchase Receipt</para>
        /// <para>Internal: group_show_purchase_receipts</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_show_purchase_receipts")]
        [OdooField("group_show_purchase_receipts")]
        public bool GroupShowPurchaseReceipts { get; set; }

        /// <summary>
        /// <para>Name: Budget Management</para>
        /// <para>Internal: module_account_budget</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_budget")]
        [OdooField("module_account_budget")]
        public bool ModuleAccountBudget { get; set; }

        /// <summary>
        /// <para>Name: Invoice Online Payment</para>
        /// <para>Internal: module_account_payment</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_payment")]
        [OdooField("module_account_payment")]
        public bool ModuleAccountPayment { get; set; }

        /// <summary>
        /// <para>Name: Dynamic Reports</para>
        /// <para>Internal: module_account_reports</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_reports")]
        [OdooField("module_account_reports")]
        public bool ModuleAccountReports { get; set; }

        /// <summary>
        /// <para>Name: Allow check printing and deposits</para>
        /// <para>Internal: module_account_check_printing</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_check_printing")]
        [OdooField("module_account_check_printing")]
        public bool ModuleAccountCheckPrinting { get; set; }

        /// <summary>
        /// <para>Name: Use batch payments</para>
        /// <para>Internal: module_account_batch_payment</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_batch_payment")]
        [OdooField("module_account_batch_payment")]
        public bool ModuleAccountBatchPayment { get; set; }

        /// <summary>
        /// <para>Name: SEPA Credit Transfer / ISO20022</para>
        /// <para>Internal: module_account_iso20022</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_iso20022")]
        [OdooField("module_account_iso20022")]
        public bool ModuleAccountIso20022 { get; set; }

        /// <summary>
        /// <para>Name: Use SEPA Direct Debit</para>
        /// <para>Internal: module_account_sepa_direct_debit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_sepa_direct_debit")]
        [OdooField("module_account_sepa_direct_debit")]
        public bool ModuleAccountSepaDirectDebit { get; set; }

        /// <summary>
        /// <para>Name: Import .qif files</para>
        /// <para>Internal: module_account_bank_statement_import_qif</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_bank_statement_import_qif")]
        [OdooField("module_account_bank_statement_import_qif")]
        public bool ModuleAccountBankStatementImportQif { get; set; }

        /// <summary>
        /// <para>Name: Import in .ofx format</para>
        /// <para>Internal: module_account_bank_statement_import_ofx</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_bank_statement_import_ofx")]
        [OdooField("module_account_bank_statement_import_ofx")]
        public bool ModuleAccountBankStatementImportOfx { get; set; }

        /// <summary>
        /// <para>Name: Import in .csv, .xls, and .xlsx format</para>
        /// <para>Internal: module_account_bank_statement_import_csv</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_bank_statement_import_csv")]
        [OdooField("module_account_bank_statement_import_csv")]
        public bool ModuleAccountBankStatementImportCsv { get; set; }

        /// <summary>
        /// <para>Name: Import in CAMT.053 format</para>
        /// <para>Internal: module_account_bank_statement_import_camt</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_bank_statement_import_camt")]
        [OdooField("module_account_bank_statement_import_camt")]
        public bool ModuleAccountBankStatementImportCamt { get; set; }

        /// <summary>
        /// <para>Name: Automatic Currency Rates</para>
        /// <para>Internal: module_currency_rate_live</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_currency_rate_live")]
        [OdooField("module_currency_rate_live")]
        public bool ModuleCurrencyRateLive { get; set; }

        /// <summary>
        /// <para>Name: Intrastat</para>
        /// <para>Internal: module_account_intrastat</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_intrastat")]
        [OdooField("module_account_intrastat")]
        public bool ModuleAccountIntrastat { get; set; }

        /// <summary>
        /// <para>Name: Allow Product Margin</para>
        /// <para>Internal: module_product_margin</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_product_margin")]
        [OdooField("module_product_margin")]
        public bool ModuleProductMargin { get; set; }

        /// <summary>
        /// <para>Name: EU Intra-community Distance Selling</para>
        /// <para>Internal: module_l10n_eu_oss</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_l10n_eu_oss")]
        [OdooField("module_l10n_eu_oss")]
        public bool ModuleL10nEuOss { get; set; }

        /// <summary>
        /// <para>Name: Document Digitization</para>
        /// <para>Internal: module_account_extract</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_extract")]
        [OdooField("module_account_extract")]
        public bool ModuleAccountExtract { get; set; }

        /// <summary>
        /// <para>Name: Invoice Digitization</para>
        /// <para>Internal: module_account_invoice_extract</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_invoice_extract")]
        [OdooField("module_account_invoice_extract")]
        public bool ModuleAccountInvoiceExtract { get; set; }

        /// <summary>
        /// <para>Name: Bank Statement Digitization</para>
        /// <para>Internal: module_account_bank_statement_extract</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_bank_statement_extract")]
        [OdooField("module_account_bank_statement_extract")]
        public bool ModuleAccountBankStatementExtract { get; set; }

        /// <summary>
        /// <para>Name: Snailmail</para>
        /// <para>Internal: module_snailmail_account</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_snailmail_account")]
        [OdooField("module_snailmail_account")]
        public bool ModuleSnailmailAccount { get; set; }

        /// <summary>
        /// <para>Name: PEPPOL Invoicing</para>
        /// <para>Internal: module_account_peppol</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_peppol")]
        [OdooField("module_account_peppol")]
        public bool ModuleAccountPeppol { get; set; }

        /// <summary>
        /// <para>Name: Cash Basis</para>
        /// <para>Internal: tax_exigibility</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("tax_exigibility")]
        [OdooField("tax_exigibility")]
        public bool TaxExigibility { get; set; }

        /// <summary>
        /// <para>Name: Tax Cash Basis Journal</para>
        /// <para>Internal: tax_cash_basis_journal_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("tax_cash_basis_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("tax_cash_basis_journal_id")]
        public int? TaxCashBasisJournalId { get; set; }

        /// <summary>
        /// <para>Name: Base Tax Received Account</para>
        /// <para>Internal: account_cash_basis_base_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_cash_basis_base_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_cash_basis_base_account_id")]
        public int? AccountCashBasisBaseAccountId { get; set; }

        /// <summary>
        /// <para>Name: Fiscal Country Code</para>
        /// <para>Internal: account_fiscal_country_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("account_fiscal_country_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_fiscal_country_id")]
        public int? AccountFiscalCountryId { get; set; }

        /// <summary>
        /// <para>Name: Display SEPA QR-code</para>
        /// <para>Internal: qr_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("qr_code")]
        [OdooField("qr_code")]
        public bool QrCode { get; set; }

        /// <summary>
        /// <para>Name: Default incoterm</para>
        /// <para>Internal: incoterm_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.incoterms</para>
        /// </summary>
        [JsonPropertyName("incoterm_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("incoterm_id")]
        public int? IncotermId { get; set; }

        /// <summary>
        /// <para>Name: Terms & Conditions</para>
        /// <para>Internal: invoice_terms</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("invoice_terms")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_terms")]
        public string InvoiceTerms { get; set; }

        /// <summary>
        /// <para>Name: Terms & Conditions as a Web page</para>
        /// <para>Internal: invoice_terms_html</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("invoice_terms_html")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_terms_html")]
        public string InvoiceTermsHtml { get; set; }

        /// <summary>
        /// <para>Name: Terms & Conditions format</para>
        /// <para>Internal: terms_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [plain]=Add a Note,[html]=Add a link to a Web Page</para>
        /// </summary>
        [JsonPropertyName("terms_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("terms_type")]
        public string TermsType { get; set; }

        /// <summary>
        /// <para>Name: Total amount of invoice in letters</para>
        /// <para>Internal: display_invoice_amount_total_words</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_invoice_amount_total_words")]
        [OdooField("display_invoice_amount_total_words")]
        public bool DisplayInvoiceAmountTotalWords { get; set; }

        /// <summary>
        /// <para>Name: Taxes in company currency</para>
        /// <para>Internal: display_invoice_tax_company_currency</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_invoice_tax_company_currency")]
        [OdooField("display_invoice_tax_company_currency")]
        public bool DisplayInvoiceTaxCompanyCurrency { get; set; }

        /// <summary>
        /// <para>Name: Display preview button</para>
        /// <para>Internal: preview_ready</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("preview_ready")]
        [OdooField("preview_ready")]
        public bool PreviewReady { get; set; }

        /// <summary>
        /// <para>Name: Default Terms & Conditions</para>
        /// <para>Internal: use_invoice_terms</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_invoice_terms")]
        [OdooField("use_invoice_terms")]
        public bool UseInvoiceTerms { get; set; }

        /// <summary>
        /// <para>Name: Sales Credit Limit</para>
        /// <para>Internal: account_use_credit_limit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("account_use_credit_limit")]
        [OdooField("account_use_credit_limit")]
        public bool AccountUseCreditLimit { get; set; }

        /// <summary>
        /// <para>Name: Default Credit Limit</para>
        /// <para>Internal: account_default_credit_limit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("account_default_credit_limit")]
        [OdooField("account_default_credit_limit")]
        public decimal AccountDefaultCreditLimit { get; set; }

        /// <summary>
        /// <para>Name: Country Code</para>
        /// <para>Internal: country_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("country_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>Name: Storno accounting</para>
        /// <para>Internal: account_storno</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("account_storno")]
        [OdooField("account_storno")]
        public bool AccountStorno { get; set; }

        /// <summary>
        /// <para>Name: Customer Addresses</para>
        /// <para>Internal: group_sale_delivery_address</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_sale_delivery_address")]
        [OdooField("group_sale_delivery_address")]
        public bool GroupSaleDeliveryAddress { get; set; }

        /// <summary>
        /// <para>Name: Quick encoding</para>
        /// <para>Internal: quick_edit_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [out_invoices]=Customer Invoices,[in_invoices]=Vendor Bills,[out_and_in_invoices]=Customer Invoices and Vendor Bills</para>
        /// </summary>
        [JsonPropertyName("quick_edit_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("quick_edit_mode")]
        public string QuickEditMode { get; set; }

        /// <summary>
        /// <para>Name: Early Discount Loss</para>
        /// <para>Internal: account_journal_early_pay_discount_loss_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_journal_early_pay_discount_loss_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_journal_early_pay_discount_loss_account_id")]
        public int? AccountJournalEarlyPayDiscountLossAccountId { get; set; }

        /// <summary>
        /// <para>Name: Early Discount Gain</para>
        /// <para>Internal: account_journal_early_pay_discount_gain_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_journal_early_pay_discount_gain_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_journal_early_pay_discount_gain_account_id")]
        public int? AccountJournalEarlyPayDiscountGainAccountId { get; set; }

        /// <summary>
        /// <para>Name: Vendor Bills Discounts Account</para>
        /// <para>Internal: account_discount_income_allocation_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_discount_income_allocation_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_discount_income_allocation_id")]
        public int? AccountDiscountIncomeAllocationId { get; set; }

        /// <summary>
        /// <para>Name: Customer Invoices Discounts Account</para>
        /// <para>Internal: account_discount_expense_allocation_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_discount_expense_allocation_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_discount_expense_allocation_id")]
        public int? AccountDiscountExpenseAllocationId { get; set; }

        /// <summary>
        /// <para>Name: PEPPOL eligible</para>
        /// <para>Internal: is_account_peppol_eligible</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_account_peppol_eligible")]
        [OdooField("is_account_peppol_eligible")]
        public bool IsAccountPeppolEligible { get; set; }

        /// <summary>
        /// <para>Name: Audit Trail</para>
        /// <para>Internal: check_account_audit_trail</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("check_account_audit_trail")]
        [OdooField("check_account_audit_trail")]
        public bool CheckAccountAuditTrail { get; set; }

        /// <summary>
        /// <para>Name: Auto-validate bills</para>
        /// <para>Internal: autopost_bills</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("autopost_bills")]
        [OdooField("autopost_bills")]
        public bool AutopostBills { get; set; }

        /// <summary>
        /// <para>Name: Leads</para>
        /// <para>Internal: group_use_lead</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_use_lead")]
        [OdooField("group_use_lead")]
        public bool GroupUseLead { get; set; }

        /// <summary>
        /// <para>Name: Recurring Revenues</para>
        /// <para>Internal: group_use_recurring_revenues</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_use_recurring_revenues")]
        [OdooField("group_use_recurring_revenues")]
        public bool GroupUseRecurringRevenues { get; set; }

        /// <summary>
        /// <para>Name: Multi Teams</para>
        /// <para>Internal: is_membership_multi</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_membership_multi")]
        [OdooField("is_membership_multi")]
        public bool IsMembershipMulti { get; set; }

        /// <summary>
        /// <para>Name: Rule-Based Assignment</para>
        /// <para>Internal: crm_use_auto_assignment</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("crm_use_auto_assignment")]
        [OdooField("crm_use_auto_assignment")]
        public bool CrmUseAutoAssignment { get; set; }

        /// <summary>
        /// <para>Name: Auto Assignment Action</para>
        /// <para>Internal: crm_auto_assignment_action</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [manual]=Manually,[auto]=Repeatedly</para>
        /// </summary>
        [JsonPropertyName("crm_auto_assignment_action")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("crm_auto_assignment_action")]
        public string CrmAutoAssignmentAction { get; set; }

        /// <summary>
        /// <para>Name: Auto Assignment Interval Unit</para>
        /// <para>Internal: crm_auto_assignment_interval_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [minutes]=Minutes,[hours]=Hours,[days]=Days,[weeks]=Weeks</para>
        /// </summary>
        [JsonPropertyName("crm_auto_assignment_interval_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("crm_auto_assignment_interval_type")]
        public string CrmAutoAssignmentIntervalType { get; set; }

        /// <summary>
        /// <para>Name: Repeat every</para>
        /// <para>Internal: crm_auto_assignment_interval_number</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("crm_auto_assignment_interval_number")]
        [OdooField("crm_auto_assignment_interval_number")]
        public int CrmAutoAssignmentIntervalNumber { get; set; }

        /// <summary>
        /// <para>Name: Auto Assignment Next Execution Date</para>
        /// <para>Internal: crm_auto_assignment_run_datetime</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("crm_auto_assignment_run_datetime")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("crm_auto_assignment_run_datetime")]
        public DateTime? CrmAutoAssignmentRunDatetime { get; set; }

        /// <summary>
        /// <para>Name: Generate new leads based on their country, industries, size, etc.</para>
        /// <para>Internal: module_crm_iap_mine</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_crm_iap_mine")]
        [OdooField("module_crm_iap_mine")]
        public bool ModuleCrmIapMine { get; set; }

        /// <summary>
        /// <para>Name: Enrich your leads automatically with company data based on their email address.</para>
        /// <para>Internal: module_crm_iap_enrich</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_crm_iap_enrich")]
        [OdooField("module_crm_iap_enrich")]
        public bool ModuleCrmIapEnrich { get; set; }

        /// <summary>
        /// <para>Name: Create Leads/Opportunities from your website's traffic</para>
        /// <para>Internal: module_website_crm_iap_reveal</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_website_crm_iap_reveal")]
        [OdooField("module_website_crm_iap_reveal")]
        public bool ModuleWebsiteCrmIapReveal { get; set; }

        /// <summary>
        /// <para>Name: Enrich lead automatically</para>
        /// <para>Internal: lead_enrich_auto</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [manual]=Enrich leads on demand only,[auto]=Enrich all leads automatically</para>
        /// </summary>
        [JsonPropertyName("lead_enrich_auto")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("lead_enrich_auto")]
        public string LeadEnrichAuto { get; set; }

        /// <summary>
        /// <para>Name: Create a lead mining request directly from the opportunity pipeline.</para>
        /// <para>Internal: lead_mining_in_pipeline</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("lead_mining_in_pipeline")]
        [OdooField("lead_mining_in_pipeline")]
        public bool LeadMiningInPipeline { get; set; }

        /// <summary>
        /// <para>Name: Lead Scoring Starting Date</para>
        /// <para>Internal: predictive_lead_scoring_start_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("predictive_lead_scoring_start_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("predictive_lead_scoring_start_date")]
        public DateTime? PredictiveLeadScoringStartDate { get; set; }

        /// <summary>
        /// <para>Name: Lead Scoring Starting Date in String</para>
        /// <para>Internal: predictive_lead_scoring_start_date_str</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("predictive_lead_scoring_start_date_str")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("predictive_lead_scoring_start_date_str")]
        public string PredictiveLeadScoringStartDateStr { get; set; }

        /// <summary>
        /// <para>Name: Lead Scoring Frequency Fields</para>
        /// <para>Internal: predictive_lead_scoring_fields</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: crm.lead.scoring.frequency.field</para>
        /// </summary>
        [JsonPropertyName("predictive_lead_scoring_fields")]
        [OdooField("predictive_lead_scoring_fields")]
        public List<int> PredictiveLeadScoringFields { get; set; }

        /// <summary>
        /// <para>Name: Lead Scoring Frequency Fields in String</para>
        /// <para>Internal: predictive_lead_scoring_fields_str</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("predictive_lead_scoring_fields_str")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("predictive_lead_scoring_fields_str")]
        public string PredictiveLeadScoringFieldsStr { get; set; }

        /// <summary>
        /// <para>Name: Predictive Lead Scoring Field Labels</para>
        /// <para>Internal: predictive_lead_scoring_field_labels</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("predictive_lead_scoring_field_labels")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("predictive_lead_scoring_field_labels")]
        public string PredictiveLeadScoringFieldLabels { get; set; }

        /// <summary>
        /// <para>Name: Company Working Hours</para>
        /// <para>Internal: resource_calendar_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: resource.calendar</para>
        /// </summary>
        [JsonPropertyName("resource_calendar_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("resource_calendar_id")]
        public int? ResourceCalendarId { get; set; }

        /// <summary>
        /// <para>Name: Advanced Presence Control</para>
        /// <para>Internal: module_hr_presence</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_hr_presence")]
        [OdooField("module_hr_presence")]
        public bool ModuleHrPresence { get; set; }

        /// <summary>
        /// <para>Name: Skills Management</para>
        /// <para>Internal: module_hr_skills</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_hr_skills")]
        [OdooField("module_hr_skills")]
        public bool ModuleHrSkills { get; set; }

        /// <summary>
        /// <para>Name: Remote Work</para>
        /// <para>Internal: module_hr_homeworking</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_hr_homeworking")]
        [OdooField("module_hr_homeworking")]
        public bool ModuleHrHomeworking { get; set; }

        /// <summary>
        /// <para>Name: Contracts Management</para>
        /// <para>Internal: module_hr_contract</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_hr_contract")]
        [OdooField("module_hr_contract")]
        public bool ModuleHrContract { get; set; }

        /// <summary>
        /// <para>Name: Based on user status in system</para>
        /// <para>Internal: hr_presence_control_login</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("hr_presence_control_login")]
        [OdooField("hr_presence_control_login")]
        public bool HrPresenceControlLogin { get; set; }

        /// <summary>
        /// <para>Name: Based on number of emails sent</para>
        /// <para>Internal: hr_presence_control_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("hr_presence_control_email")]
        [OdooField("hr_presence_control_email")]
        public bool HrPresenceControlEmail { get; set; }

        /// <summary>
        /// <para>Name: Based on IP Address</para>
        /// <para>Internal: hr_presence_control_ip</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("hr_presence_control_ip")]
        [OdooField("hr_presence_control_ip")]
        public bool HrPresenceControlIp { get; set; }

        /// <summary>
        /// <para>Name: Based on attendances</para>
        /// <para>Internal: module_hr_attendance</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_hr_attendance")]
        [OdooField("module_hr_attendance")]
        public bool ModuleHrAttendance { get; set; }

        /// <summary>
        /// <para>Name: # emails to send</para>
        /// <para>Internal: hr_presence_control_email_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("hr_presence_control_email_amount")]
        [OdooField("hr_presence_control_email_amount")]
        public int HrPresenceControlEmailAmount { get; set; }

        /// <summary>
        /// <para>Name: Valid IP addresses</para>
        /// <para>Internal: hr_presence_control_ip_list</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("hr_presence_control_ip_list")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("hr_presence_control_ip_list")]
        public string HrPresenceControlIpList { get; set; }

        /// <summary>
        /// <para>Name: Employee Editing</para>
        /// <para>Internal: hr_employee_self_edit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("hr_employee_self_edit")]
        [OdooField("hr_employee_self_edit")]
        public bool HrEmployeeSelfEdit { get; set; }

        /// <summary>
        /// <para>Name: website</para>
        /// <para>Internal: website_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website</para>
        /// </summary>
        [JsonPropertyName("website_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("website_id")]
        public int? WebsiteId { get; set; }

        /// <summary>
        /// <para>Name: Website Name</para>
        /// <para>Internal: website_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_name")]
        public string WebsiteName { get; set; }

        /// <summary>
        /// <para>Name: Website Domain</para>
        /// <para>Internal: website_domain</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_domain")]
        public string WebsiteDomain { get; set; }

        /// <summary>
        /// <para>Name: Homepage Url</para>
        /// <para>Internal: website_homepage_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_homepage_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_homepage_url")]
        public string WebsiteHomepageUrl { get; set; }

        /// <summary>
        /// <para>Name: Website Company</para>
        /// <para>Internal: website_company_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("website_company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("website_company_id")]
        public int? WebsiteCompanyId { get; set; }

        /// <summary>
        /// <para>Name: Website Logo</para>
        /// <para>Internal: website_logo</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("website_logo")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("website_logo")]
        public byte[] WebsiteLogo { get; set; }

        /// <summary>
        /// <para>Name: Languages</para>
        /// <para>Internal: language_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.lang</para>
        /// </summary>
        [JsonPropertyName("language_ids")]
        [OdooField("language_ids")]
        public List<int> LanguageIds { get; set; }

        /// <summary>
        /// <para>Name: Number of languages</para>
        /// <para>Internal: website_language_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("website_language_count")]
        [OdooField("website_language_count")]
        public int WebsiteLanguageCount { get; set; }

        /// <summary>
        /// <para>Name: Default language</para>
        /// <para>Internal: website_default_lang_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.lang</para>
        /// </summary>
        [JsonPropertyName("website_default_lang_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("website_default_lang_id")]
        public int? WebsiteDefaultLangId { get; set; }

        /// <summary>
        /// <para>Name: Default language code</para>
        /// <para>Internal: website_default_lang_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_default_lang_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_default_lang_code")]
        public string WebsiteDefaultLangCode { get; set; }

        /// <summary>
        /// <para>Name: Shared Customer Accounts</para>
        /// <para>Internal: shared_user_account</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("shared_user_account")]
        [OdooField("shared_user_account")]
        public bool SharedUserAccount { get; set; }

        /// <summary>
        /// <para>Name: Cookies Bar</para>
        /// <para>Internal: website_cookies_bar</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_cookies_bar")]
        [OdooField("website_cookies_bar")]
        public bool WebsiteCookiesBar { get; set; }

        /// <summary>
        /// <para>Name: Block 3rd-party domains</para>
        /// <para>Internal: website_block_third_party_domains</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_block_third_party_domains")]
        [OdooField("website_block_third_party_domains")]
        public bool WebsiteBlockThirdPartyDomains { get; set; }

        /// <summary>
        /// <para>Name: Google Analytics Key</para>
        /// <para>Internal: google_analytics_key</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_analytics_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("google_analytics_key")]
        public string GoogleAnalyticsKey { get; set; }

        /// <summary>
        /// <para>Name: Google Search Console</para>
        /// <para>Internal: google_search_console</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("google_search_console")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("google_search_console")]
        public string GoogleSearchConsole { get; set; }

        /// <summary>
        /// <para>Name: Plausible auth Key</para>
        /// <para>Internal: plausible_shared_key</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("plausible_shared_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("plausible_shared_key")]
        public string PlausibleSharedKey { get; set; }

        /// <summary>
        /// <para>Name: Plausible Site (e.g. domain.com)</para>
        /// <para>Internal: plausible_site</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("plausible_site")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("plausible_site")]
        public string PlausibleSite { get; set; }

        /// <summary>
        /// <para>Name: Content Delivery Network (CDN)</para>
        /// <para>Internal: cdn_activated</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("cdn_activated")]
        [OdooField("cdn_activated")]
        public bool CdnActivated { get; set; }

        /// <summary>
        /// <para>Name: CDN Base URL</para>
        /// <para>Internal: cdn_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("cdn_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("cdn_url")]
        public string CdnUrl { get; set; }

        /// <summary>
        /// <para>Name: CDN Filters</para>
        /// <para>Internal: cdn_filters</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("cdn_filters")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("cdn_filters")]
        public string CdnFilters { get; set; }

        /// <summary>
        /// <para>Name: Favicon</para>
        /// <para>Internal: favicon</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("favicon")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("favicon")]
        public byte[] Favicon { get; set; }

        /// <summary>
        /// <para>Name: Default Social Share Image</para>
        /// <para>Internal: social_default_image</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("social_default_image")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("social_default_image")]
        public byte[] SocialDefaultImage { get; set; }

        /// <summary>
        /// <para>Name: Multi-website</para>
        /// <para>Internal: group_multi_website</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_multi_website")]
        [OdooField("group_multi_website")]
        public bool GroupMultiWebsite { get; set; }

        /// <summary>
        /// <para>Name: Google Analytics</para>
        /// <para>Internal: has_google_analytics</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_google_analytics")]
        [OdooField("has_google_analytics")]
        public bool HasGoogleAnalytics { get; set; }

        /// <summary>
        /// <para>Name: Console Google Search</para>
        /// <para>Internal: has_google_search_console</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_google_search_console")]
        [OdooField("has_google_search_console")]
        public bool HasGoogleSearchConsole { get; set; }

        /// <summary>
        /// <para>Name: Use a image by default for sharing</para>
        /// <para>Internal: has_default_share_image</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_default_share_image")]
        [OdooField("has_default_share_image")]
        public bool HasDefaultShareImage { get; set; }

        /// <summary>
        /// <para>Name: Plausible Analytics</para>
        /// <para>Internal: has_plausible_shared_key</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_plausible_shared_key")]
        [OdooField("has_plausible_shared_key")]
        public bool HasPlausibleSharedKey { get; set; }

        /// <summary>
        /// <para>Name: Module Website Livechat</para>
        /// <para>Internal: module_website_livechat</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_website_livechat")]
        [OdooField("module_website_livechat")]
        public bool ModuleWebsiteLivechat { get; set; }

        /// <summary>
        /// <para>Name: Module Marketing Automation</para>
        /// <para>Internal: module_marketing_automation</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_marketing_automation")]
        [OdooField("module_marketing_automation")]
        public bool ModuleMarketingAutomation { get; set; }

        /// <summary>
        /// <para>Name: Fiscalyear Last Day</para>
        /// <para>Internal: fiscalyear_last_day</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("fiscalyear_last_day")]
        [OdooField("fiscalyear_last_day")]
        public int FiscalyearLastDay { get; set; }

        /// <summary>
        /// <para>Name: Fiscalyear Last Month</para>
        /// <para>Internal: fiscalyear_last_month</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [1]=January,[2]=February,[3]=March,[4]=April,[5]=May,[6]=June,[7]=July,[8]=August,[9]=September,[10]=October,[11]=November,[12]=December</para>
        /// </summary>
        [JsonPropertyName("fiscalyear_last_month")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("fiscalyear_last_month")]
        public string FiscalyearLastMonth { get; set; }

        /// <summary>
        /// <para>Name: Anglo-Saxon Accounting</para>
        /// <para>Internal: use_anglo_saxon</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_anglo_saxon")]
        [OdooField("use_anglo_saxon")]
        public bool UseAngloSaxon { get; set; }

        /// <summary>
        /// <para>Name: Invoicing Switch Threshold</para>
        /// <para>Internal: invoicing_switch_threshold</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("invoicing_switch_threshold")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("invoicing_switch_threshold")]
        public DateTime? InvoicingSwitchThreshold { get; set; }

        /// <summary>
        /// <para>Name: Fiscal Years</para>
        /// <para>Internal: group_fiscal_year</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_fiscal_year")]
        [OdooField("group_fiscal_year")]
        public bool GroupFiscalYear { get; set; }

        /// <summary>
        /// <para>Name: Predict Bill Product</para>
        /// <para>Internal: predict_bill_product</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("predict_bill_product")]
        [OdooField("predict_bill_product")]
        public bool PredictBillProduct { get; set; }

        /// <summary>
        /// <para>Name: Authorized Signatory on invoice</para>
        /// <para>Internal: sign_invoice</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sign_invoice")]
        [OdooField("sign_invoice")]
        public bool SignInvoice { get; set; }

        /// <summary>
        /// <para>Name: Signature used to sign all the invoice</para>
        /// <para>Internal: signing_user</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("signing_user")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("signing_user")]
        public int? SigningUser { get; set; }

        /// <summary>
        /// <para>Name: Sign</para>
        /// <para>Internal: module_sign</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_sign")]
        [OdooField("module_sign")]
        public bool ModuleSign { get; set; }

        /// <summary>
        /// <para>Name: Deferred Expense Journal</para>
        /// <para>Internal: deferred_expense_journal_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("deferred_expense_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("deferred_expense_journal_id")]
        public int? DeferredExpenseJournalId { get; set; }

        /// <summary>
        /// <para>Name: Deferred Expense Account</para>
        /// <para>Internal: deferred_expense_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("deferred_expense_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("deferred_expense_account_id")]
        public int? DeferredExpenseAccountId { get; set; }

        /// <summary>
        /// <para>Name: Generate Deferred Expense Entries</para>
        /// <para>Internal: generate_deferred_expense_entries_method</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [on_validation]=On bill validation,[manual]=Manually & Grouped</para>
        /// </summary>
        [JsonPropertyName("generate_deferred_expense_entries_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("generate_deferred_expense_entries_method")]
        public string GenerateDeferredExpenseEntriesMethod { get; set; }

        /// <summary>
        /// <para>Name: Deferred Expense Based on</para>
        /// <para>Internal: deferred_expense_amount_computation_method</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [day]=Days,[month]=Months,[full_months]=Full Months</para>
        /// </summary>
        [JsonPropertyName("deferred_expense_amount_computation_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("deferred_expense_amount_computation_method")]
        public string DeferredExpenseAmountComputationMethod { get; set; }

        /// <summary>
        /// <para>Name: Deferred Revenue Journal</para>
        /// <para>Internal: deferred_revenue_journal_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("deferred_revenue_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("deferred_revenue_journal_id")]
        public int? DeferredRevenueJournalId { get; set; }

        /// <summary>
        /// <para>Name: Deferred Revenue Account</para>
        /// <para>Internal: deferred_revenue_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("deferred_revenue_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("deferred_revenue_account_id")]
        public int? DeferredRevenueAccountId { get; set; }

        /// <summary>
        /// <para>Name: Generate Deferred Revenue Entries</para>
        /// <para>Internal: generate_deferred_revenue_entries_method</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [on_validation]=On bill validation,[manual]=Manually & Grouped</para>
        /// </summary>
        [JsonPropertyName("generate_deferred_revenue_entries_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("generate_deferred_revenue_entries_method")]
        public string GenerateDeferredRevenueEntriesMethod { get; set; }

        /// <summary>
        /// <para>Name: Deferred Revenue Based on</para>
        /// <para>Internal: deferred_revenue_amount_computation_method</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [day]=Days,[month]=Months,[full_months]=Full Months</para>
        /// </summary>
        [JsonPropertyName("deferred_revenue_amount_computation_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("deferred_revenue_amount_computation_method")]
        public string DeferredRevenueAmountComputationMethod { get; set; }

        /// <summary>
        /// <para>Name: Pay Invoices Online</para>
        /// <para>Internal: pay_invoices_online</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("pay_invoices_online")]
        [OdooField("pay_invoices_online")]
        public bool PayInvoicesOnline { get; set; }

        /// <summary>
        /// <para>Name: Verify VAT Numbers</para>
        /// <para>Internal: vat_check_vies</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("vat_check_vies")]
        [OdooField("vat_check_vies")]
        public bool VatCheckVies { get; set; }

        /// <summary>
        /// <para>Name: Interval Unit</para>
        /// <para>Internal: currency_interval_unit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [manually]=Manually,[daily]=Daily,[weekly]=Weekly,[monthly]=Monthly</para>
        /// </summary>
        [JsonPropertyName("currency_interval_unit")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("currency_interval_unit")]
        public string CurrencyIntervalUnit { get; set; }

        /// <summary>
        /// <para>Name: Service Provider</para>
        /// <para>Internal: currency_provider</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [ecb]=European Central Bank,[xe_com]=xe.com,[cbuae]=[AE] Central Bank of the UAE,[bnb]=[BG] Bulgaria National Bank,[bbr]=[BR] Central Bank of Brazil,[boc]=[CA] Bank of Canada,[fta]=[CH] Federal Tax Administration of Switzerland,[mindicador]=[CL] Central Bank of Chile via mindicador.cl,[banrepco]=[CO] Bank of the Republic,[cnb]=[CZ] Czech National Bank,[cbegy]=[EG] Central Bank of Egypt,[banguat]=[GT] Bank of Guatemala,[mnb]=[HU] Magyar Nemzeti Bank,[boi]=[IT] Bank of Italy,[banxico]=[MX] Bank of Mexico,[bcrp]=[PE] SUNAT (replaces Bank of Peru),[nbp]=[PL] National Bank of Poland,[bnr]=[RO] National Bank of Romania,[srb]=[SE] Sveriges Riksbank,[tcmb]=[TR] Central Bank of the Republic of Türkiye,[hmrc]=[UK] HM Revenue & Customs,[bnm]=[MY] Bank Negara Malaysia,[bi]=[ID] Bank Indonesia,[bcu]=[UY] Uruguayan Central Bank,[bot]=[TH] Bank of Thailand</para>
        /// </summary>
        [JsonPropertyName("currency_provider")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("currency_provider")]
        public string CurrencyProvider { get; set; }

        /// <summary>
        /// <para>Name: Next Execution Date</para>
        /// <para>Internal: currency_next_execution_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("currency_next_execution_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("currency_next_execution_date")]
        public DateTime? CurrencyNextExecutionDate { get; set; }

        /// <summary>
        /// <para>Name: Lock Confirmed Orders</para>
        /// <para>Internal: lock_confirmed_po</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("lock_confirmed_po")]
        [OdooField("lock_confirmed_po")]
        public bool LockConfirmedPo { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order Modification *</para>
        /// <para>Internal: po_lock</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [edit]=Allow to edit purchase orders,[lock]=Confirmed purchase orders are not editable</para>
        /// </summary>
        [JsonPropertyName("po_lock")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("po_lock")]
        public string PoLock { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order Approval</para>
        /// <para>Internal: po_order_approval</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("po_order_approval")]
        [OdooField("po_order_approval")]
        public bool PoOrderApproval { get; set; }

        /// <summary>
        /// <para>Name: Levels of Approvals *</para>
        /// <para>Internal: po_double_validation</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [one_step]=Confirm purchase orders in one step,[two_step]=Get 2 levels of approvals to confirm a purchase order</para>
        /// </summary>
        [JsonPropertyName("po_double_validation")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("po_double_validation")]
        public string PoDoubleValidation { get; set; }

        /// <summary>
        /// <para>Name: Minimum Amount</para>
        /// <para>Internal: po_double_validation_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("po_double_validation_amount")]
        [OdooField("po_double_validation_amount")]
        public decimal PoDoubleValidationAmount { get; set; }

        /// <summary>
        /// <para>Name: Company Currency</para>
        /// <para>Internal: company_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("company_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("company_currency_id")]
        public int? CompanyCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Purchase Warnings</para>
        /// <para>Internal: group_warning_purchase</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_warning_purchase")]
        [OdooField("group_warning_purchase")]
        public bool GroupWarningPurchase { get; set; }

        /// <summary>
        /// <para>Name: 3-way matching: purchases, receptions and bills</para>
        /// <para>Internal: module_account_3way_match</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account_3way_match")]
        [OdooField("module_account_3way_match")]
        public bool ModuleAccount3wayMatch { get; set; }

        /// <summary>
        /// <para>Name: Purchase Agreements</para>
        /// <para>Internal: module_purchase_requisition</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_purchase_requisition")]
        [OdooField("module_purchase_requisition")]
        public bool ModulePurchaseRequisition { get; set; }

        /// <summary>
        /// <para>Name: Purchase Grid Entry</para>
        /// <para>Internal: module_purchase_product_matrix</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_purchase_product_matrix")]
        [OdooField("module_purchase_product_matrix")]
        public bool ModulePurchaseProductMatrix { get; set; }

        /// <summary>
        /// <para>Name: Purchase Lead Time</para>
        /// <para>Internal: po_lead</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("po_lead")]
        [OdooField("po_lead")]
        public double PoLead { get; set; }

        /// <summary>
        /// <para>Name: Security Lead Time for Purchase</para>
        /// <para>Internal: use_po_lead</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_po_lead")]
        [OdooField("use_po_lead")]
        public bool UsePoLead { get; set; }

        /// <summary>
        /// <para>Name: Receipt Reminder</para>
        /// <para>Internal: group_send_reminder</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_send_reminder")]
        [OdooField("group_send_reminder")]
        public bool GroupSendReminder { get; set; }

        /// <summary>
        /// <para>Name: EDI user</para>
        /// <para>Internal: account_peppol_edi_user</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account_edi_proxy_client.user</para>
        /// </summary>
        [JsonPropertyName("account_peppol_edi_user")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_peppol_edi_user")]
        public int? AccountPeppolEdiUser { get; set; }

        /// <summary>
        /// <para>Name: EDI operating mode</para>
        /// <para>Internal: account_peppol_edi_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [prod]=Production mode,[test]=Test mode,[demo]=Demo mode</para>
        /// </summary>
        [JsonPropertyName("account_peppol_edi_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_edi_mode")]
        public string AccountPeppolEdiMode { get; set; }

        /// <summary>
        /// <para>Name: Primary contact email</para>
        /// <para>Internal: account_peppol_contact_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_peppol_contact_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_contact_email")]
        public string AccountPeppolContactEmail { get; set; }

        /// <summary>
        /// <para>Name: Peppol e-address (EAS)</para>
        /// <para>Internal: account_peppol_eas</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [9923]=Albania VAT,[9922]=Andorra VAT,[0151]=Australia ABN,[9914]=Austria UID,[9915]=Austria VOKZ,[0208]=Belgian Company Registry,[9925]=Belgian VAT,[9924]=Bosnia and Herzegovina VAT,[9926]=Bulgaria VAT,[9934]=Croatia VAT,[9928]=Cyprus VAT,[9929]=Czech Republic VAT,[0096]=Denmark P,[0184]=Denmark CVR,[0198]=Denmark SE,[0191]=Estonia Company code,[9931]=Estonia VAT,[0037]=Finland LY-tunnus,[0216]=Finland OVT code,[0213]=Finland VAT,[0002]=France SIRENE,[0009]=France SIRET,[9957]=France VAT,[0204]=Germany Leitweg-ID,[9930]=Germany VAT,[9933]=Greece VAT,[9910]=Hungary VAT,[0196]=Iceland Kennitala,[9935]=Ireland VAT,[0211]=Italia Partita IVA,[0097]=Italia FTI,[0188]=Japan SST,[0221]=Japan IIN,[9939]=Latvia VAT,[9936]=Liechtenstein VAT,[0200]=Lithuania JAK,[9937]=Lithuania VAT,[9938]=Luxembourg VAT,[9942]=Macedonia VAT,[0230]=Malaysia,[9943]=Malta VAT,[9940]=Monaco VAT,[9941]=Montenegro VAT,[0106]=Netherlands KvK,[0190]=Netherlands OIN,[9944]=Netherlands VAT,[0192]=Norway Org.nr.,[9945]=Poland VAT,[9946]=Portugal VAT,[9947]=Romania VAT,[9948]=Serbia VAT,[0195]=Singapore UEN,[9949]=Slovenia VAT,[9950]=Slovakia VAT,[9920]=Spain VAT,[0007]=Sweden Org.nr.,[9955]=Sweden VAT,[9927]=Swiss VAT,[0183]=Swiss UIDB,[9952]=Turkey VAT,[9932]=United Kingdom VAT,[9959]=USA EIN,[0060]=DUNS Number,[0088]=EAN Location Code,[0130]=Directorates of the European Commission,[0135]=SIA Object Identifiers,[0142]=SECETI Object Identifiers,[0193]=UBL.BE party identifier,[0199]=Legal Entity Identifier (LEI),[0201]=Codice Univoco Unità Organizzativa iPA,[0202]=Indirizzo di Posta Elettronica Certificata,[0209]=GS1 identification keys,[0210]=Codice Fiscale,[9913]=Business Registers Network,[9918]=S.W.I.F.T,[9919]=Kennziffer des Unternehmensregisters,[9951]=San Marino VAT,[9953]=Vatican VAT</para>
        /// </summary>
        [JsonPropertyName("account_peppol_eas")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_eas")]
        public string AccountPeppolEas { get; set; }

        /// <summary>
        /// <para>Name: Edi Identification</para>
        /// <para>Internal: account_peppol_edi_identification</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_peppol_edi_identification")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_edi_identification")]
        public string AccountPeppolEdiIdentification { get; set; }

        /// <summary>
        /// <para>Name: Peppol Endpoint</para>
        /// <para>Internal: account_peppol_endpoint</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_peppol_endpoint")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_endpoint")]
        public string AccountPeppolEndpoint { get; set; }

        /// <summary>
        /// <para>Name: Migration Key</para>
        /// <para>Internal: account_peppol_migration_key</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_peppol_migration_key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_migration_key")]
        public string AccountPeppolMigrationKey { get; set; }

        /// <summary>
        /// <para>Name: Mobile number</para>
        /// <para>Internal: account_peppol_phone_number</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_peppol_phone_number")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_phone_number")]
        public string AccountPeppolPhoneNumber { get; set; }

        /// <summary>
        /// <para>Name: PEPPOL status</para>
        /// <para>Internal: account_peppol_proxy_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_registered]=Not registered,[sender]=Can send but not receive,[smp_registration]=Can send, pending registration to receive,[receiver]=Can send and receive,[rejected]=Rejected</para>
        /// </summary>
        [JsonPropertyName("account_peppol_proxy_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_proxy_state")]
        public string AccountPeppolProxyState { get; set; }

        /// <summary>
        /// <para>Name: Peppol Purchase Journal</para>
        /// <para>Internal: account_peppol_purchase_journal_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("account_peppol_purchase_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_peppol_purchase_journal_id")]
        public int? AccountPeppolPurchaseJournalId { get; set; }

        /// <summary>
        /// <para>Name: Peppol External Provider</para>
        /// <para>Internal: peppol_external_provider</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("peppol_external_provider")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("peppol_external_provider")]
        public string PeppolExternalProvider { get; set; }

        /// <summary>
        /// <para>Name: Add totals below sections</para>
        /// <para>Internal: totals_below_sections</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("totals_below_sections")]
        [OdooField("totals_below_sections")]
        public bool TotalsBelowSections { get; set; }

        /// <summary>
        /// <para>Name: Periodicity</para>
        /// <para>Internal: account_tax_periodicity</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [year]=annually,[semester]=semi-annually,[4_months]=every 4 months,[trimester]=quarterly,[2_months]=every 2 months,[monthly]=monthly</para>
        /// </summary>
        [JsonPropertyName("account_tax_periodicity")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_tax_periodicity")]
        public string AccountTaxPeriodicity { get; set; }

        /// <summary>
        /// <para>Name: Reminder</para>
        /// <para>Internal: account_tax_periodicity_reminder_day</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("account_tax_periodicity_reminder_day")]
        [OdooField("account_tax_periodicity_reminder_day")]
        public int AccountTaxPeriodicityReminderDay { get; set; }

        /// <summary>
        /// <para>Name: Journal</para>
        /// <para>Internal: account_tax_periodicity_journal_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("account_tax_periodicity_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_tax_periodicity_journal_id")]
        public int? AccountTaxPeriodicityJournalId { get; set; }

        /// <summary>
        /// <para>Name: Account Reports Show Per Company Setting</para>
        /// <para>Internal: account_reports_show_per_company_setting</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("account_reports_show_per_company_setting")]
        [OdooField("account_reports_show_per_company_setting")]
        public bool AccountReportsShowPerCompanySetting { get; set; }

        /// <summary>
        /// <para>Name: Invoicing Policy</para>
        /// <para>Internal: default_invoice_policy</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [order]=Invoice what is ordered,[delivery]=Invoice what is delivered</para>
        /// </summary>
        [JsonPropertyName("default_invoice_policy")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("default_invoice_policy")]
        public string DefaultInvoicePolicy { get; set; }

        /// <summary>
        /// <para>Name: Lock Confirmed Sales</para>
        /// <para>Internal: group_auto_done_setting</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_auto_done_setting")]
        [OdooField("group_auto_done_setting")]
        public bool GroupAutoDoneSetting { get; set; }

        /// <summary>
        /// <para>Name: Discounts</para>
        /// <para>Internal: group_discount_per_so_line</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_discount_per_so_line")]
        [OdooField("group_discount_per_so_line")]
        public bool GroupDiscountPerSoLine { get; set; }

        /// <summary>
        /// <para>Name: Pro-Forma Invoice</para>
        /// <para>Internal: group_proforma_sales</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_proforma_sales")]
        [OdooField("group_proforma_sales")]
        public bool GroupProformaSales { get; set; }

        /// <summary>
        /// <para>Name: Sale Order Warnings</para>
        /// <para>Internal: group_warning_sale</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_warning_sale")]
        [OdooField("group_warning_sale")]
        public bool GroupWarningSale { get; set; }

        /// <summary>
        /// <para>Name: Automatic Invoice</para>
        /// <para>Internal: automatic_invoice</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("automatic_invoice")]
        [OdooField("automatic_invoice")]
        public bool AutomaticInvoice { get; set; }

        /// <summary>
        /// <para>Name: Invoice Email Template</para>
        /// <para>Internal: invoice_mail_template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.template</para>
        /// </summary>
        [JsonPropertyName("invoice_mail_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("invoice_mail_template_id")]
        public int? InvoiceMailTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Default Quotation Validity</para>
        /// <para>Internal: quotation_validity_days</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("quotation_validity_days")]
        [OdooField("quotation_validity_days")]
        public int QuotationValidityDays { get; set; }

        /// <summary>
        /// <para>Name: Online Signature</para>
        /// <para>Internal: portal_confirmation_sign</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("portal_confirmation_sign")]
        [OdooField("portal_confirmation_sign")]
        public bool PortalConfirmationSign { get; set; }

        /// <summary>
        /// <para>Name: Online Payment</para>
        /// <para>Internal: portal_confirmation_pay</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("portal_confirmation_pay")]
        [OdooField("portal_confirmation_pay")]
        public bool PortalConfirmationPay { get; set; }

        /// <summary>
        /// <para>Name: Prepayment percentage</para>
        /// <para>Internal: prepayment_percent</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("prepayment_percent")]
        [OdooField("prepayment_percent")]
        public double PrepaymentPercent { get; set; }

        /// <summary>
        /// <para>Name: Delivery Methods</para>
        /// <para>Internal: module_delivery</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery")]
        [OdooField("module_delivery")]
        public bool ModuleDelivery { get; set; }

        /// <summary>
        /// <para>Name: bpost Connector</para>
        /// <para>Internal: module_delivery_bpost</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_bpost")]
        [OdooField("module_delivery_bpost")]
        public bool ModuleDeliveryBpost { get; set; }

        /// <summary>
        /// <para>Name: DHL Express Connector</para>
        /// <para>Internal: module_delivery_dhl</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_dhl")]
        [OdooField("module_delivery_dhl")]
        public bool ModuleDeliveryDhl { get; set; }

        /// <summary>
        /// <para>Name: Easypost Connector</para>
        /// <para>Internal: module_delivery_easypost</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_easypost")]
        [OdooField("module_delivery_easypost")]
        public bool ModuleDeliveryEasypost { get; set; }

        /// <summary>
        /// <para>Name: Envia.com Connector</para>
        /// <para>Internal: module_delivery_envia</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_envia")]
        [OdooField("module_delivery_envia")]
        public bool ModuleDeliveryEnvia { get; set; }

        /// <summary>
        /// <para>Name: FedEx Connector</para>
        /// <para>Internal: module_delivery_fedex</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_fedex")]
        [OdooField("module_delivery_fedex")]
        public bool ModuleDeliveryFedex { get; set; }

        /// <summary>
        /// <para>Name: Sendcloud Connector</para>
        /// <para>Internal: module_delivery_sendcloud</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_sendcloud")]
        [OdooField("module_delivery_sendcloud")]
        public bool ModuleDeliverySendcloud { get; set; }

        /// <summary>
        /// <para>Name: Shiprocket Connector</para>
        /// <para>Internal: module_delivery_shiprocket</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_shiprocket")]
        [OdooField("module_delivery_shiprocket")]
        public bool ModuleDeliveryShiprocket { get; set; }

        /// <summary>
        /// <para>Name: Starshipit Connector</para>
        /// <para>Internal: module_delivery_starshipit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_starshipit")]
        [OdooField("module_delivery_starshipit")]
        public bool ModuleDeliveryStarshipit { get; set; }

        /// <summary>
        /// <para>Name: UPS Connector</para>
        /// <para>Internal: module_delivery_ups</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_ups")]
        [OdooField("module_delivery_ups")]
        public bool ModuleDeliveryUps { get; set; }

        /// <summary>
        /// <para>Name: USPS Connector</para>
        /// <para>Internal: module_delivery_usps</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_usps")]
        [OdooField("module_delivery_usps")]
        public bool ModuleDeliveryUsps { get; set; }

        /// <summary>
        /// <para>Name: Specific Email</para>
        /// <para>Internal: module_product_email_template</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_product_email_template")]
        [OdooField("module_product_email_template")]
        public bool ModuleProductEmailTemplate { get; set; }

        /// <summary>
        /// <para>Name: Amazon Sync</para>
        /// <para>Internal: module_sale_amazon</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_sale_amazon")]
        [OdooField("module_sale_amazon")]
        public bool ModuleSaleAmazon { get; set; }

        /// <summary>
        /// <para>Name: Commissions</para>
        /// <para>Internal: module_sale_commission</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_sale_commission")]
        [OdooField("module_sale_commission")]
        public bool ModuleSaleCommission { get; set; }

        /// <summary>
        /// <para>Name: Coupons & Loyalty</para>
        /// <para>Internal: module_sale_loyalty</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_sale_loyalty")]
        [OdooField("module_sale_loyalty")]
        public bool ModuleSaleLoyalty { get; set; }

        /// <summary>
        /// <para>Name: Margins</para>
        /// <para>Internal: module_sale_margin</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_sale_margin")]
        [OdooField("module_sale_margin")]
        public bool ModuleSaleMargin { get; set; }

        /// <summary>
        /// <para>Name: PDF Quote builder</para>
        /// <para>Internal: module_sale_pdf_quote_builder</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_sale_pdf_quote_builder")]
        [OdooField("module_sale_pdf_quote_builder")]
        public bool ModuleSalePdfQuoteBuilder { get; set; }

        /// <summary>
        /// <para>Name: Sales Grid Entry</para>
        /// <para>Internal: module_sale_product_matrix</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_sale_product_matrix")]
        [OdooField("module_sale_product_matrix")]
        public bool ModuleSaleProductMatrix { get; set; }

        /// <summary>
        /// <para>Name: Shopee Sync</para>
        /// <para>Internal: module_sale_shopee</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_sale_shopee")]
        [OdooField("module_sale_shopee")]
        public bool ModuleSaleShopee { get; set; }

        /// <summary>
        /// <para>Name: Providers State</para>
        /// <para>Internal: providers_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [none]=None,[paypal_only]=Paypal Only,[other_than_paypal]=Other than Paypal</para>
        /// </summary>
        [JsonPropertyName("providers_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("providers_state")]
        public string ProvidersState { get; set; }

        /// <summary>
        /// <para>Name: First Provider Label</para>
        /// <para>Internal: first_provider_label</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("first_provider_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("first_provider_label")]
        public string FirstProviderLabel { get; set; }

        /// <summary>
        /// <para>Name: Is Stripe Supported Country</para>
        /// <para>Internal: is_stripe_supported_country</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_stripe_supported_country")]
        [OdooField("is_stripe_supported_country")]
        public bool IsStripeSupportedCountry { get; set; }

        /// <summary>
        /// <para>Name: DateV G/L account length</para>
        /// <para>Internal: l10n_de_datev_account_length</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("l10n_de_datev_account_length")]
        [OdooField("l10n_de_datev_account_length")]
        public int L10nDeDatevAccountLength { get; set; }

        /// <summary>
        /// <para>Name: Quotation Templates</para>
        /// <para>Internal: group_sale_order_template</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_sale_order_template")]
        [OdooField("group_sale_order_template")]
        public bool GroupSaleOrderTemplate { get; set; }

        /// <summary>
        /// <para>Name: Default Template</para>
        /// <para>Internal: company_so_template_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sale.order.template</para>
        /// </summary>
        [JsonPropertyName("company_so_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("company_so_template_id")]
        public int? CompanySoTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Bank Statements</para>
        /// <para>Internal: extract_bank_statement_digitalization_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no_send]=Do not digitize,[auto_send]=Digitize automatically</para>
        /// </summary>
        [JsonPropertyName("extract_bank_statement_digitalization_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("extract_bank_statement_digitalization_mode")]
        public string ExtractBankStatementDigitalizationMode { get; set; }

        /// <summary>
        /// <para>Name: Vendor Bills</para>
        /// <para>Internal: extract_in_invoice_digitalization_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no_send]=Do not digitize,[manual_send]=Digitize on demand only,[auto_send]=Digitize automatically</para>
        /// </summary>
        [JsonPropertyName("extract_in_invoice_digitalization_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("extract_in_invoice_digitalization_mode")]
        public string ExtractInInvoiceDigitalizationMode { get; set; }

        /// <summary>
        /// <para>Name: Customer Invoices</para>
        /// <para>Internal: extract_out_invoice_digitalization_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no_send]=Do not digitize,[manual_send]=Digitize on demand only,[auto_send]=Digitize automatically</para>
        /// </summary>
        [JsonPropertyName("extract_out_invoice_digitalization_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("extract_out_invoice_digitalization_mode")]
        public string ExtractOutInvoiceDigitalizationMode { get; set; }

        /// <summary>
        /// <para>Name: Single Invoice Line Per Tax</para>
        /// <para>Internal: extract_single_line_per_tax</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("extract_single_line_per_tax")]
        [OdooField("extract_single_line_per_tax")]
        public bool ExtractSingleLinePerTax { get; set; }

        /// <summary>
        /// <para>Name: Shipping Address</para>
        /// <para>Internal: group_delivery_invoice_address</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_delivery_invoice_address")]
        [OdooField("group_delivery_invoice_address")]
        public bool GroupDeliveryInvoiceAddress { get; set; }

        /// <summary>
        /// <para>Name: Base Unit Price</para>
        /// <para>Internal: group_show_uom_price</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_show_uom_price")]
        [OdooField("group_show_uom_price")]
        public bool GroupShowUomPrice { get; set; }

        /// <summary>
        /// <para>Name: Comparison Price</para>
        /// <para>Internal: group_product_price_comparison</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("group_product_price_comparison")]
        [OdooField("group_product_price_comparison")]
        public bool GroupProductPriceComparison { get; set; }

        /// <summary>
        /// <para>Name: Invoicing</para>
        /// <para>Internal: module_account</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_account")]
        [OdooField("module_account")]
        public bool ModuleAccount { get; set; }

        /// <summary>
        /// <para>Name: Mondial Relay Connector</para>
        /// <para>Internal: module_delivery_mondialrelay</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_delivery_mondialrelay")]
        [OdooField("module_delivery_mondialrelay")]
        public bool ModuleDeliveryMondialrelay { get; set; }

        /// <summary>
        /// <para>Name: Address Autocomplete</para>
        /// <para>Internal: module_website_sale_autocomplete</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_website_sale_autocomplete")]
        [OdooField("module_website_sale_autocomplete")]
        public bool ModuleWebsiteSaleAutocomplete { get; set; }

        /// <summary>
        /// <para>Name: Product Comparison Tool</para>
        /// <para>Internal: module_website_sale_comparison</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_website_sale_comparison")]
        [OdooField("module_website_sale_comparison")]
        public bool ModuleWebsiteSaleComparison { get; set; }

        /// <summary>
        /// <para>Name: Click & Collect</para>
        /// <para>Internal: module_website_sale_collect</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_website_sale_collect")]
        [OdooField("module_website_sale_collect")]
        public bool ModuleWebsiteSaleCollect { get; set; }

        /// <summary>
        /// <para>Name: Wishlists</para>
        /// <para>Internal: module_website_sale_wishlist</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("module_website_sale_wishlist")]
        [OdooField("module_website_sale_wishlist")]
        public bool ModuleWebsiteSaleWishlist { get; set; }

        /// <summary>
        /// <para>Name: Add To Cart Action</para>
        /// <para>Internal: add_to_cart_action</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [stay]=Stay on Product Page,[go_to_cart]=Go to cart,[force_dialog]=Let the user decide (dialog)</para>
        /// </summary>
        [JsonPropertyName("add_to_cart_action")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("add_to_cart_action")]
        public string AddToCartAction { get; set; }

        /// <summary>
        /// <para>Name: Cart Recovery Email</para>
        /// <para>Internal: cart_recovery_mail_template</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.template</para>
        /// </summary>
        [JsonPropertyName("cart_recovery_mail_template")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("cart_recovery_mail_template")]
        public int? CartRecoveryMailTemplate { get; set; }

        /// <summary>
        /// <para>Name: Abandoned Delay</para>
        /// <para>Internal: cart_abandoned_delay</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("cart_abandoned_delay")]
        [OdooField("cart_abandoned_delay")]
        public double CartAbandonedDelay { get; set; }

        /// <summary>
        /// <para>Name: Abandoned Email</para>
        /// <para>Internal: send_abandoned_cart_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("send_abandoned_cart_email")]
        [OdooField("send_abandoned_cart_email")]
        public bool SendAbandonedCartEmail { get; set; }

        /// <summary>
        /// <para>Name: Salesperson</para>
        /// <para>Internal: salesperson_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("salesperson_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("salesperson_id")]
        public int? SalespersonId { get; set; }

        /// <summary>
        /// <para>Name: Sales Team</para>
        /// <para>Internal: salesteam_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.team</para>
        /// </summary>
        [JsonPropertyName("salesteam_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("salesteam_id")]
        public int? SalesteamId { get; set; }

        /// <summary>
        /// <para>Name: Prevent Sale of Zero Priced Product</para>
        /// <para>Internal: website_sale_prevent_zero_price_sale</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_sale_prevent_zero_price_sale")]
        [OdooField("website_sale_prevent_zero_price_sale")]
        public bool WebsiteSalePreventZeroPriceSale { get; set; }

        /// <summary>
        /// <para>Name: Button Url</para>
        /// <para>Internal: website_sale_contact_us_button_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_sale_contact_us_button_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_sale_contact_us_button_url")]
        public string WebsiteSaleContactUsButtonUrl { get; set; }

        /// <summary>
        /// <para>Name: Re-order From Portal</para>
        /// <para>Internal: website_sale_enabled_portal_reorder_button</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_sale_enabled_portal_reorder_button")]
        [OdooField("website_sale_enabled_portal_reorder_button")]
        public bool WebsiteSaleEnabledPortalReorderButton { get; set; }

        /// <summary>
        /// <para>Name: Line Subtotals Tax Display</para>
        /// <para>Internal: show_line_subtotals_tax_selection</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [tax_excluded]=Tax Excluded,[tax_included]=Tax Included</para>
        /// </summary>
        [JsonPropertyName("show_line_subtotals_tax_selection")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("show_line_subtotals_tax_selection")]
        public string ShowLineSubtotalsTaxSelection { get; set; }

        /// <summary>
        /// <para>Name: Customer Accounts</para>
        /// <para>Internal: account_on_checkout</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [optional]=Optional,[disabled]=Disabled (buy as guest),[mandatory]=Mandatory (no guest checkout)</para>
        /// </summary>
        [JsonPropertyName("account_on_checkout")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_on_checkout")]
        public string AccountOnCheckout { get; set; }

        /// <summary>
        /// <para>Name: Ecommerce Access</para>
        /// <para>Internal: ecommerce_access</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [everyone]=All users,[logged_in]=Logged in users</para>
        /// </summary>
        [JsonPropertyName("ecommerce_access")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("ecommerce_access")]
        public string EcommerceAccess { get; set; }

        /// <summary>
        /// <para>Name: Extra Step During Checkout</para>
        /// <para>Internal: enabled_extra_checkout_step</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("enabled_extra_checkout_step")]
        [OdooField("enabled_extra_checkout_step")]
        public bool EnabledExtraCheckoutStep { get; set; }

        /// <summary>
        /// <para>Name: Buy Now</para>
        /// <para>Internal: enabled_buy_now_button</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("enabled_buy_now_button")]
        [OdooField("enabled_buy_now_button")]
        public bool EnabledBuyNowButton { get; set; }

    }
}
