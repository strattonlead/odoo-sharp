using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("res.users")]
    public partial class ResUsers
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
        /// <para>Name: Related Partner</para>
        /// <para>Internal: partner_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("partner_id")]
        public int? PartnerId { get; set; }

        /// <summary>
        /// <para>Name: Login</para>
        /// <para>Internal: login</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("login")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("login")]
        public string Login { get; set; }

        /// <summary>
        /// <para>Name: Password</para>
        /// <para>Internal: password</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("password")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("password")]
        public string Password { get; set; }

        /// <summary>
        /// <para>Name: Set Password</para>
        /// <para>Internal: new_password</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("new_password")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("new_password")]
        public string NewPassword { get; set; }

        /// <summary>
        /// <para>Name: API Keys</para>
        /// <para>Internal: api_key_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.users.apikeys</para>
        /// </summary>
        [JsonPropertyName("api_key_ids")]
        [OdooField("api_key_ids")]
        public List<int> ApiKeyIds { get; set; }

        /// <summary>
        /// <para>Name: Email Signature</para>
        /// <para>Internal: signature</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("signature")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("signature")]
        public string Signature { get; set; }

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
        /// <para>Name: Partner is Active</para>
        /// <para>Internal: active_partner</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("active_partner")]
        [OdooField("active_partner")]
        public bool ActivePartner { get; set; }

        /// <summary>
        /// <para>Name: Home Action</para>
        /// <para>Internal: action_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.actions.actions</para>
        /// </summary>
        [JsonPropertyName("action_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("action_id")]
        public int? ActionId { get; set; }

        /// <summary>
        /// <para>Name: User log entries</para>
        /// <para>Internal: log_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.users.log</para>
        /// </summary>
        [JsonPropertyName("log_ids")]
        [OdooField("log_ids")]
        public List<int> LogIds { get; set; }

        /// <summary>
        /// <para>Name: User devices</para>
        /// <para>Internal: device_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.device</para>
        /// </summary>
        [JsonPropertyName("device_ids")]
        [OdooField("device_ids")]
        public List<int> DeviceIds { get; set; }

        /// <summary>
        /// <para>Name: Latest authentication</para>
        /// <para>Internal: login_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("login_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("login_date")]
        public DateTime? LoginDate { get; set; }

        /// <summary>
        /// <para>Name: Share User</para>
        /// <para>Internal: share</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("share")]
        [OdooField("share")]
        public bool Share { get; set; }

        /// <summary>
        /// <para>Name: Number of Companies</para>
        /// <para>Internal: companies_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("companies_count")]
        [OdooField("companies_count")]
        public int CompaniesCount { get; set; }

        /// <summary>
        /// <para>Name: Timezone offset</para>
        /// <para>Internal: tz_offset</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("tz_offset")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("tz_offset")]
        public string TzOffset { get; set; }

        /// <summary>
        /// <para>Name: Res Users Settings</para>
        /// <para>Internal: res_users_settings_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.users.settings</para>
        /// </summary>
        [JsonPropertyName("res_users_settings_ids")]
        [OdooField("res_users_settings_ids")]
        public List<int> ResUsersSettingsIds { get; set; }

        /// <summary>
        /// <para>Name: Settings</para>
        /// <para>Internal: res_users_settings_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users.settings</para>
        /// </summary>
        [JsonPropertyName("res_users_settings_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("res_users_settings_id")]
        public int? ResUsersSettingsId { get; set; }

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
        /// <para>Name: Companies</para>
        /// <para>Internal: company_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("company_ids")]
        [OdooField("company_ids")]
        public List<int> CompanyIds { get; set; }

        /// <summary>
        /// <para>Name: Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: Email</para>
        /// <para>Internal: email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email")]
        public string Email { get; set; }

        /// <summary>
        /// <para>Name: Phone</para>
        /// <para>Internal: phone</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// <para>Name: Groups</para>
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
        /// <para>Name: Groups and implied groups</para>
        /// <para>Internal: all_group_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.groups</para>
        /// </summary>
        [JsonPropertyName("all_group_ids")]
        [OdooField("all_group_ids")]
        public List<int> AllGroupIds { get; set; }

        /// <summary>
        /// <para>Name: # Access Rights</para>
        /// <para>Internal: accesses_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("accesses_count")]
        [OdooField("accesses_count")]
        public int AccessesCount { get; set; }

        /// <summary>
        /// <para>Name: # Record Rules</para>
        /// <para>Internal: rules_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("rules_count")]
        [OdooField("rules_count")]
        public int RulesCount { get; set; }

        /// <summary>
        /// <para>Name: # Groups</para>
        /// <para>Internal: groups_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("groups_count")]
        [OdooField("groups_count")]
        public int GroupsCount { get; set; }

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
        /// <para>Name: Technical field for user group setting</para>
        /// <para>Internal: view_group_hierarchy</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("view_group_hierarchy")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("view_group_hierarchy")]
        public object ViewGroupHierarchy { get; set; }

        /// <summary>
        /// <para>Name: Disjoint groups</para>
        /// <para>Internal: view_disjoint_group_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.groups</para>
        /// </summary>
        [JsonPropertyName("view_disjoint_group_ids")]
        [OdooField("view_disjoint_group_ids")]
        public List<int> ViewDisjointGroupIds { get; set; }

        /// <summary>
        /// <para>Name: All disjoint groups</para>
        /// <para>Internal: view_all_disjoint_group_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.groups</para>
        /// </summary>
        [JsonPropertyName("view_all_disjoint_group_ids")]
        [OdooField("view_all_disjoint_group_ids")]
        public List<int> ViewAllDisjointGroupIds { get; set; }

        /// <summary>
        /// <para>Name: Groups added automatically</para>
        /// <para>Internal: view_visible_implied_group_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.groups</para>
        /// </summary>
        [JsonPropertyName("view_visible_implied_group_ids")]
        [OdooField("view_visible_implied_group_ids")]
        public List<int> ViewVisibleImpliedGroupIds { get; set; }

        /// <summary>
        /// <para>Name: Show technical groups</para>
        /// <para>Internal: view_show_technical_groups</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("view_show_technical_groups")]
        [OdooField("view_show_technical_groups")]
        public bool ViewShowTechnicalGroups { get; set; }

        /// <summary>
        /// <para>Name: Two-factor authentication</para>
        /// <para>Internal: totp_enabled</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("totp_enabled")]
        [OdooField("totp_enabled")]
        public bool TotpEnabled { get; set; }

        /// <summary>
        /// <para>Name: Trusted Devices</para>
        /// <para>Internal: totp_trusted_device_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: auth_totp.device</para>
        /// </summary>
        [JsonPropertyName("totp_trusted_device_ids")]
        [OdooField("totp_trusted_device_ids")]
        public List<int> TotpTrustedDeviceIds { get; set; }

        /// <summary>
        /// <para>Name: Resources</para>
        /// <para>Internal: resource_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: resource.resource</para>
        /// </summary>
        [JsonPropertyName("resource_ids")]
        [OdooField("resource_ids")]
        public List<int> ResourceIds { get; set; }

        /// <summary>
        /// <para>Name: Default Working Hours</para>
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
        /// <para>Name: Onboarding</para>
        /// <para>Internal: tour_enabled</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("tour_enabled")]
        [OdooField("tour_enabled")]
        public bool TourEnabled { get; set; }

        /// <summary>
        /// <para>Name: Notification</para>
        /// <para>Internal: notification_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [email]=Handle by Emails,[inbox]=Handle in Odoo</para>
        /// </summary>
        [JsonPropertyName("notification_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("notification_type")]
        public string NotificationType { get; set; }

        /// <summary>
        /// <para>Name: Presence</para>
        /// <para>Internal: presence_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.presence</para>
        /// </summary>
        [JsonPropertyName("presence_ids")]
        [OdooField("presence_ids")]
        public List<int> PresenceIds { get; set; }

        /// <summary>
        /// <para>Name: IM Status</para>
        /// <para>Internal: im_status</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("im_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("im_status")]
        public string ImStatus { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [new]=Never Connected,[active]=Confirmed</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Calendar Default Privacy</para>
        /// <para>Internal: calendar_default_privacy</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [public]=Public,[private]=Private,[confidential]=Only internal users</para>
        /// </summary>
        [JsonPropertyName("calendar_default_privacy")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("calendar_default_privacy")]
        public string CalendarDefaultPrivacy { get; set; }

        /// <summary>
        /// <para>Name: Karma</para>
        /// <para>Internal: karma</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("karma")]
        [OdooField("karma")]
        public int Karma { get; set; }

        /// <summary>
        /// <para>Name: Karma Changes</para>
        /// <para>Internal: karma_tracking_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: gamification.karma.tracking</para>
        /// </summary>
        [JsonPropertyName("karma_tracking_ids")]
        [OdooField("karma_tracking_ids")]
        public List<int> KarmaTrackingIds { get; set; }

        /// <summary>
        /// <para>Name: Badges</para>
        /// <para>Internal: badge_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: gamification.badge.user</para>
        /// </summary>
        [JsonPropertyName("badge_ids")]
        [OdooField("badge_ids")]
        public List<int> BadgeIds { get; set; }

        /// <summary>
        /// <para>Name: Gold badges count</para>
        /// <para>Internal: gold_badge</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("gold_badge")]
        [OdooField("gold_badge")]
        public int GoldBadge { get; set; }

        /// <summary>
        /// <para>Name: Silver badges count</para>
        /// <para>Internal: silver_badge</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("silver_badge")]
        [OdooField("silver_badge")]
        public int SilverBadge { get; set; }

        /// <summary>
        /// <para>Name: Bronze badges count</para>
        /// <para>Internal: bronze_badge</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("bronze_badge")]
        [OdooField("bronze_badge")]
        public int BronzeBadge { get; set; }

        /// <summary>
        /// <para>Name: Rank</para>
        /// <para>Internal: rank_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: gamification.karma.rank</para>
        /// </summary>
        [JsonPropertyName("rank_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("rank_id")]
        public int? RankId { get; set; }

        /// <summary>
        /// <para>Name: Next Rank</para>
        /// <para>Internal: next_rank_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: gamification.karma.rank</para>
        /// </summary>
        [JsonPropertyName("next_rank_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("next_rank_id")]
        public int? NextRankId { get; set; }

        /// <summary>
        /// <para>Name: OdooBot Status</para>
        /// <para>Internal: odoobot_state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_initialized]=Not initialized,[onboarding_emoji]=Onboarding emoji,[onboarding_attachement]=Onboarding attachment,[onboarding_command]=Onboarding command,[onboarding_ping]=Onboarding ping,[onboarding_canned]=Onboarding canned,[idle]=Idle,[disabled]=Disabled</para>
        /// </summary>
        [JsonPropertyName("odoobot_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("odoobot_state")]
        public string OdoobotState { get; set; }

        /// <summary>
        /// <para>Name: Odoobot Failed</para>
        /// <para>Internal: odoobot_failed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("odoobot_failed")]
        [OdooField("odoobot_failed")]
        public bool OdoobotFailed { get; set; }

        /// <summary>
        /// <para>Name: Sales Teams</para>
        /// <para>Internal: crm_team_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: crm.team</para>
        /// </summary>
        [JsonPropertyName("crm_team_ids")]
        [OdooField("crm_team_ids")]
        public List<int> CrmTeamIds { get; set; }

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
        /// <para>Name: User Sales Team</para>
        /// <para>Internal: sale_team_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.team</para>
        /// </summary>
        [JsonPropertyName("sale_team_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sale_team_id")]
        public int? SaleTeamId { get; set; }

        /// <summary>
        /// <para>Name: OAuth User ID</para>
        /// <para>Internal: oauth_uid</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("oauth_uid")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("oauth_uid")]
        public string OauthUid { get; set; }

        /// <summary>
        /// <para>Name: Odoo.com User ID</para>
        /// <para>Internal: odoo_com_uid</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("odoo_com_uid")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("odoo_com_uid")]
        public string OdooComUid { get; set; }

        /// <summary>
        /// <para>Name: Digital Signature</para>
        /// <para>Internal: sign_signature</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("sign_signature")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("sign_signature")]
        public byte[] SignSignature { get; set; }

        /// <summary>
        /// <para>Name: Digital Initials</para>
        /// <para>Internal: sign_initials</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("sign_initials")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("sign_initials")]
        public byte[] SignInitials { get; set; }

        /// <summary>
        /// <para>Name: Digital Signature Frame</para>
        /// <para>Internal: sign_signature_frame</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("sign_signature_frame")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("sign_signature_frame")]
        public byte[] SignSignatureFrame { get; set; }

        /// <summary>
        /// <para>Name: Digital Initials Frame</para>
        /// <para>Internal: sign_initials_frame</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("sign_initials_frame")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("sign_initials_frame")]
        public byte[] SignInitialsFrame { get; set; }

        /// <summary>
        /// <para>Name: Helpdesk Target Closed</para>
        /// <para>Internal: helpdesk_target_closed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("helpdesk_target_closed")]
        [OdooField("helpdesk_target_closed")]
        public int HelpdeskTargetClosed { get; set; }

        /// <summary>
        /// <para>Name: Helpdesk Target Rating</para>
        /// <para>Internal: helpdesk_target_rating</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("helpdesk_target_rating")]
        [OdooField("helpdesk_target_rating")]
        public double HelpdeskTargetRating { get; set; }

        /// <summary>
        /// <para>Name: Helpdesk Target Success</para>
        /// <para>Internal: helpdesk_target_success</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("helpdesk_target_success")]
        [OdooField("helpdesk_target_success")]
        public double HelpdeskTargetSuccess { get; set; }

        /// <summary>
        /// <para>Name: Related employee</para>
        /// <para>Internal: employee_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: hr.employee</para>
        /// </summary>
        [JsonPropertyName("employee_ids")]
        [OdooField("employee_ids")]
        public List<int> EmployeeIds { get; set; }

        /// <summary>
        /// <para>Name: Company employee</para>
        /// <para>Internal: employee_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.employee</para>
        /// </summary>
        [JsonPropertyName("employee_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("employee_id")]
        public int? EmployeeId { get; set; }

        /// <summary>
        /// <para>Name: Job Title</para>
        /// <para>Internal: job_title</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("job_title")]
        public string JobTitle { get; set; }

        /// <summary>
        /// <para>Name: Work Phone</para>
        /// <para>Internal: work_phone</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("work_phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("work_phone")]
        public string WorkPhone { get; set; }

        /// <summary>
        /// <para>Name: Work Mobile</para>
        /// <para>Internal: mobile_phone</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("mobile_phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// <para>Name: Work Email</para>
        /// <para>Internal: work_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("work_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("work_email")]
        public string WorkEmail { get; set; }

        /// <summary>
        /// <para>Name: Employee Tags</para>
        /// <para>Internal: category_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: hr.employee.category</para>
        /// </summary>
        [JsonPropertyName("category_ids")]
        [OdooField("category_ids")]
        public List<int> CategoryIds { get; set; }

        /// <summary>
        /// <para>Name: Department</para>
        /// <para>Internal: department_id</para>
        /// <para>Store: no</para>
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
        /// <para>Name: Work Address</para>
        /// <para>Internal: address_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("address_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("address_id")]
        public int? AddressId { get; set; }

        /// <summary>
        /// <para>Name: Work Contact</para>
        /// <para>Internal: work_contact_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("work_contact_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("work_contact_id")]
        public int? WorkContactId { get; set; }

        /// <summary>
        /// <para>Name: Work Location</para>
        /// <para>Internal: work_location_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.work.location</para>
        /// </summary>
        [JsonPropertyName("work_location_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("work_location_id")]
        public int? WorkLocationId { get; set; }

        /// <summary>
        /// <para>Name: Work Location Name</para>
        /// <para>Internal: work_location_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("work_location_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("work_location_name")]
        public string WorkLocationName { get; set; }

        /// <summary>
        /// <para>Name: Work Location Type</para>
        /// <para>Internal: work_location_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [home]=Home,[office]=Office,[other]=Other</para>
        /// </summary>
        [JsonPropertyName("work_location_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("work_location_type")]
        public string WorkLocationType { get; set; }

        /// <summary>
        /// <para>Name: Manager</para>
        /// <para>Internal: employee_parent_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.employee</para>
        /// </summary>
        [JsonPropertyName("employee_parent_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("employee_parent_id")]
        public int? EmployeeParentId { get; set; }

        /// <summary>
        /// <para>Name: Coach</para>
        /// <para>Internal: coach_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.employee</para>
        /// </summary>
        [JsonPropertyName("coach_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("coach_id")]
        public int? CoachId { get; set; }

        /// <summary>
        /// <para>Name: Private Street</para>
        /// <para>Internal: private_street</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("private_street")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("private_street")]
        public string PrivateStreet { get; set; }

        /// <summary>
        /// <para>Name: Private Street2</para>
        /// <para>Internal: private_street2</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("private_street2")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("private_street2")]
        public string PrivateStreet2 { get; set; }

        /// <summary>
        /// <para>Name: Private City</para>
        /// <para>Internal: private_city</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("private_city")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("private_city")]
        public string PrivateCity { get; set; }

        /// <summary>
        /// <para>Name: Private State</para>
        /// <para>Internal: private_state_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country.state</para>
        /// </summary>
        [JsonPropertyName("private_state_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("private_state_id")]
        public int? PrivateStateId { get; set; }

        /// <summary>
        /// <para>Name: Private Zip</para>
        /// <para>Internal: private_zip</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("private_zip")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("private_zip")]
        public string PrivateZip { get; set; }

        /// <summary>
        /// <para>Name: Private Country</para>
        /// <para>Internal: private_country_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("private_country_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("private_country_id")]
        public int? PrivateCountryId { get; set; }

        /// <summary>
        /// <para>Name: Private Phone</para>
        /// <para>Internal: private_phone</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("private_phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("private_phone")]
        public string PrivatePhone { get; set; }

        /// <summary>
        /// <para>Name: Private Email</para>
        /// <para>Internal: private_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("private_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("private_email")]
        public string PrivateEmail { get; set; }

        /// <summary>
        /// <para>Name: Employee Lang</para>
        /// <para>Internal: private_lang</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [de_DE]=German / Deutsch</para>
        /// </summary>
        [JsonPropertyName("private_lang")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("private_lang")]
        public string PrivateLang { get; set; }

        /// <summary>
        /// <para>Name: Home-Work Distance in Km</para>
        /// <para>Internal: km_home_work</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("km_home_work")]
        [OdooField("km_home_work")]
        public int KmHomeWork { get; set; }

        /// <summary>
        /// <para>Name: Home-Work Distance</para>
        /// <para>Internal: distance_home_work</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("distance_home_work")]
        [OdooField("distance_home_work")]
        public int DistanceHomeWork { get; set; }

        /// <summary>
        /// <para>Name: Home-Work Distance unit</para>
        /// <para>Internal: distance_home_work_unit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [kilometers]=km,[miles]=mi</para>
        /// </summary>
        [JsonPropertyName("distance_home_work_unit")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("distance_home_work_unit")]
        public string DistanceHomeWorkUnit { get; set; }

        /// <summary>
        /// <para>Name: Employee's Bank Account Number</para>
        /// <para>Internal: employee_bank_account_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner.bank</para>
        /// </summary>
        [JsonPropertyName("employee_bank_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("employee_bank_account_id")]
        public int? EmployeeBankAccountId { get; set; }

        /// <summary>
        /// <para>Name: Employee's Country</para>
        /// <para>Internal: employee_country_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("employee_country_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("employee_country_id")]
        public int? EmployeeCountryId { get; set; }

        /// <summary>
        /// <para>Name: Identification No</para>
        /// <para>Internal: identification_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("identification_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("identification_id")]
        public string IdentificationId { get; set; }

        /// <summary>
        /// <para>Name: SSN No</para>
        /// <para>Internal: ssnid</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("ssnid")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("ssnid")]
        public string Ssnid { get; set; }

        /// <summary>
        /// <para>Name: Passport No</para>
        /// <para>Internal: passport_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("passport_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// <para>Name: Gender</para>
        /// <para>Internal: gender</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [male]=Male,[female]=Female,[other]=Other</para>
        /// </summary>
        [JsonPropertyName("gender")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// <para>Name: Birthday</para>
        /// <para>Internal: birthday</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("birthday")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("birthday")]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// <para>Name: Show to all employees</para>
        /// <para>Internal: birthday_public_display</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("birthday_public_display")]
        [OdooField("birthday_public_display")]
        public bool BirthdayPublicDisplay { get; set; }

        /// <summary>
        /// <para>Name: Place of Birth</para>
        /// <para>Internal: place_of_birth</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("place_of_birth")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("place_of_birth")]
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// <para>Name: Country of Birth</para>
        /// <para>Internal: country_of_birth</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("country_of_birth")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("country_of_birth")]
        public int? CountryOfBirth { get; set; }

        /// <summary>
        /// <para>Name: Marital Status</para>
        /// <para>Internal: marital</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [single]=Ledig,[married]=Verheiratet,[cohabitant]=Eheähnliche Gemeinschaft,[widower]=Verwitwet,[divorced]=Geschieden</para>
        /// </summary>
        [JsonPropertyName("marital")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("marital")]
        public string Marital { get; set; }

        /// <summary>
        /// <para>Name: Spouse Complete Name</para>
        /// <para>Internal: spouse_complete_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("spouse_complete_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("spouse_complete_name")]
        public string SpouseCompleteName { get; set; }

        /// <summary>
        /// <para>Name: Spouse Birthdate</para>
        /// <para>Internal: spouse_birthdate</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("spouse_birthdate")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("spouse_birthdate")]
        public DateTime? SpouseBirthdate { get; set; }

        /// <summary>
        /// <para>Name: Number of Dependent Children</para>
        /// <para>Internal: children</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("children")]
        [OdooField("children")]
        public int Children { get; set; }

        /// <summary>
        /// <para>Name: Contact Name</para>
        /// <para>Internal: emergency_contact</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("emergency_contact")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("emergency_contact")]
        public string EmergencyContact { get; set; }

        /// <summary>
        /// <para>Name: Contact Phone</para>
        /// <para>Internal: emergency_phone</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("emergency_phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("emergency_phone")]
        public string EmergencyPhone { get; set; }

        /// <summary>
        /// <para>Name: Visa No</para>
        /// <para>Internal: visa_no</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("visa_no")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("visa_no")]
        public string VisaNo { get; set; }

        /// <summary>
        /// <para>Name: Work Permit No</para>
        /// <para>Internal: permit_no</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("permit_no")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("permit_no")]
        public string PermitNo { get; set; }

        /// <summary>
        /// <para>Name: Visa Expiration Date</para>
        /// <para>Internal: visa_expire</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("visa_expire")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("visa_expire")]
        public DateTime? VisaExpire { get; set; }

        /// <summary>
        /// <para>Name: Additional Note</para>
        /// <para>Internal: additional_note</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("additional_note")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("additional_note")]
        public string AdditionalNote { get; set; }

        /// <summary>
        /// <para>Name: Badge ID</para>
        /// <para>Internal: barcode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("barcode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// <para>Name: PIN</para>
        /// <para>Internal: pin</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("pin")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("pin")]
        public string Pin { get; set; }

        /// <summary>
        /// <para>Name: Certificate Level</para>
        /// <para>Internal: certificate</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [graduate]=Graduate,[bachelor]=Bachelor,[master]=Master,[doctor]=Doctor,[other]=Other</para>
        /// </summary>
        [JsonPropertyName("certificate")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>Name: Field of Study</para>
        /// <para>Internal: study_field</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("study_field")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("study_field")]
        public string StudyField { get; set; }

        /// <summary>
        /// <para>Name: School</para>
        /// <para>Internal: study_school</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("study_school")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("study_school")]
        public string StudySchool { get; set; }

        /// <summary>
        /// <para>Name: Employee Count</para>
        /// <para>Internal: employee_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("employee_count")]
        [OdooField("employee_count")]
        public int EmployeeCount { get; set; }

        /// <summary>
        /// <para>Name: Hr Presence State</para>
        /// <para>Internal: hr_presence_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [present]=Present,[absent]=Absent,[archive]=Archived,[out_of_working_hour]=Out of Working hours</para>
        /// </summary>
        [JsonPropertyName("hr_presence_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("hr_presence_state")]
        public string HrPresenceState { get; set; }

        /// <summary>
        /// <para>Name: Last Activity</para>
        /// <para>Internal: last_activity</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("last_activity")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("last_activity")]
        public DateTime? LastActivity { get; set; }

        /// <summary>
        /// <para>Name: Last Activity Time</para>
        /// <para>Internal: last_activity_time</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("last_activity_time")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("last_activity_time")]
        public string LastActivityTime { get; set; }

        /// <summary>
        /// <para>Name: Employee Type</para>
        /// <para>Internal: employee_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [employee]=Employee,[worker]=Worker,[student]=Student,[trainee]=Trainee,[contractor]=Contractor,[freelance]=Freelancer</para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("employee_type")]
        public string EmployeeType { get; set; }

        /// <summary>
        /// <para>Name: Employee's Working Hours</para>
        /// <para>Internal: employee_resource_calendar_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: resource.calendar</para>
        /// </summary>
        [JsonPropertyName("employee_resource_calendar_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("employee_resource_calendar_id")]
        public int? EmployeeResourceCalendarId { get; set; }

        /// <summary>
        /// <para>Name: Technical field, whether to create an employee</para>
        /// <para>Internal: create_employee</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("create_employee")]
        [OdooField("create_employee")]
        public bool CreateEmployee { get; set; }

        /// <summary>
        /// <para>Name: Technical field, bind user to this employee on create</para>
        /// <para>Internal: create_employee_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.employee</para>
        /// </summary>
        [JsonPropertyName("create_employee_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("create_employee_id")]
        public int? CreateEmployeeId { get; set; }

        /// <summary>
        /// <para>Name: Can Edit</para>
        /// <para>Internal: can_edit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("can_edit")]
        [OdooField("can_edit")]
        public bool CanEdit { get; set; }

        /// <summary>
        /// <para>Name: Is System</para>
        /// <para>Internal: is_system</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_system")]
        [OdooField("is_system")]
        public bool IsSystem { get; set; }

        /// <summary>
        /// <para>Name: Website</para>
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
        /// <para>Name: Goal</para>
        /// <para>Internal: goal_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: gamification.goal</para>
        /// </summary>
        [JsonPropertyName("goal_ids")]
        [OdooField("goal_ids")]
        public List<int> GoalIds { get; set; }

        /// <summary>
        /// <para>Name: Resume lines</para>
        /// <para>Internal: resume_line_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: hr.resume.line</para>
        /// </summary>
        [JsonPropertyName("resume_line_ids")]
        [OdooField("resume_line_ids")]
        public List<int> ResumeLineIds { get; set; }

        /// <summary>
        /// <para>Name: Skills</para>
        /// <para>Internal: employee_skill_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: hr.employee.skill</para>
        /// </summary>
        [JsonPropertyName("employee_skill_ids")]
        [OdooField("employee_skill_ids")]
        public List<int> EmployeeSkillIds { get; set; }

        /// <summary>
        /// <para>Name: SEO optimized</para>
        /// <para>Internal: is_seo_optimized</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_seo_optimized")]
        [OdooField("is_seo_optimized")]
        public bool IsSeoOptimized { get; set; }

        /// <summary>
        /// <para>Name: Website meta title</para>
        /// <para>Internal: website_meta_title</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_meta_title")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_meta_title")]
        public string WebsiteMetaTitle { get; set; }

        /// <summary>
        /// <para>Name: Website meta description</para>
        /// <para>Internal: website_meta_description</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("website_meta_description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_meta_description")]
        public string WebsiteMetaDescription { get; set; }

        /// <summary>
        /// <para>Name: Website meta keywords</para>
        /// <para>Internal: website_meta_keywords</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_meta_keywords")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_meta_keywords")]
        public string WebsiteMetaKeywords { get; set; }

        /// <summary>
        /// <para>Name: Website opengraph image</para>
        /// <para>Internal: website_meta_og_img</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_meta_og_img")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_meta_og_img")]
        public string WebsiteMetaOgImg { get; set; }

        /// <summary>
        /// <para>Name: Seo name</para>
        /// <para>Internal: seo_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("seo_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("seo_name")]
        public string SeoName { get; set; }

        /// <summary>
        /// <para>Name: Visible on current website</para>
        /// <para>Internal: website_published</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_published")]
        [OdooField("website_published")]
        public bool WebsitePublished { get; set; }

        /// <summary>
        /// <para>Name: Is Published</para>
        /// <para>Internal: is_published</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_published")]
        [OdooField("is_published")]
        public bool IsPublished { get; set; }

        /// <summary>
        /// <para>Name: Can Publish</para>
        /// <para>Internal: can_publish</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("can_publish")]
        [OdooField("can_publish")]
        public bool CanPublish { get; set; }

        /// <summary>
        /// <para>Name: Website URL</para>
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
        /// <para>Name: Website Absolute URL</para>
        /// <para>Internal: website_absolute_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website_absolute_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_absolute_url")]
        public string WebsiteAbsoluteUrl { get; set; }

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
        /// <para>Store: no</para>
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
        /// <para>Store: no</para>
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
        /// <para>Store: no</para>
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
        /// <para>Store: no</para>
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
        /// <para>Name: Normalized Email</para>
        /// <para>Internal: email_normalized</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email_normalized")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email_normalized")]
        public string EmailNormalized { get; set; }

        /// <summary>
        /// <para>Name: Blacklist</para>
        /// <para>Internal: is_blacklisted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_blacklisted")]
        [OdooField("is_blacklisted")]
        public bool IsBlacklisted { get; set; }

        /// <summary>
        /// <para>Name: Bounce</para>
        /// <para>Internal: message_bounce</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("message_bounce")]
        [OdooField("message_bounce")]
        public int MessageBounce { get; set; }

        /// <summary>
        /// <para>Name: Activities</para>
        /// <para>Internal: activity_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: mail.activity</para>
        /// </summary>
        [JsonPropertyName("activity_ids")]
        [OdooField("activity_ids")]
        public List<int> ActivityIds { get; set; }

        /// <summary>
        /// <para>Name: Activity State</para>
        /// <para>Internal: activity_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [overdue]=Overdue,[today]=Today,[planned]=Planned</para>
        /// </summary>
        [JsonPropertyName("activity_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_state")]
        public string ActivityState { get; set; }

        /// <summary>
        /// <para>Name: Responsible User</para>
        /// <para>Internal: activity_user_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("activity_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("activity_user_id")]
        public int? ActivityUserId { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Type</para>
        /// <para>Internal: activity_type_id</para>
        /// <para>Store: no</para>
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
        /// <para>Name: Activity Type Icon</para>
        /// <para>Internal: activity_type_icon</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_type_icon")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_type_icon")]
        public string ActivityTypeIcon { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Deadline</para>
        /// <para>Internal: activity_date_deadline</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("activity_date_deadline")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("activity_date_deadline")]
        public DateTime? ActivityDateDeadline { get; set; }

        /// <summary>
        /// <para>Name: My Activity Deadline</para>
        /// <para>Internal: my_activity_date_deadline</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("my_activity_date_deadline")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("my_activity_date_deadline")]
        public DateTime? MyActivityDateDeadline { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Summary</para>
        /// <para>Internal: activity_summary</para>
        /// <para>Store: no</para>
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
        /// <para>Name: Activity Exception Decoration</para>
        /// <para>Internal: activity_exception_decoration</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [warning]=Alert,[danger]=Error</para>
        /// </summary>
        [JsonPropertyName("activity_exception_decoration")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_exception_decoration")]
        public string ActivityExceptionDecoration { get; set; }

        /// <summary>
        /// <para>Name: Icon</para>
        /// <para>Internal: activity_exception_icon</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("activity_exception_icon")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("activity_exception_icon")]
        public string ActivityExceptionIcon { get; set; }

        /// <summary>
        /// <para>Name: Next Activity Calendar Event</para>
        /// <para>Internal: activity_calendar_event_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: calendar.event</para>
        /// </summary>
        [JsonPropertyName("activity_calendar_event_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("activity_calendar_event_id")]
        public int? ActivityCalendarEventId { get; set; }

        /// <summary>
        /// <para>Name: Image</para>
        /// <para>Internal: image_1920</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_1920")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("image_1920")]
        public byte[] Image1920 { get; set; }

        /// <summary>
        /// <para>Name: Image 1024</para>
        /// <para>Internal: image_1024</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_1024")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("image_1024")]
        public object Image1024 { get; set; }

        /// <summary>
        /// <para>Name: Image 512</para>
        /// <para>Internal: image_512</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_512")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("image_512")]
        public object Image512 { get; set; }

        /// <summary>
        /// <para>Name: Image 256</para>
        /// <para>Internal: image_256</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_256")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("image_256")]
        public object Image256 { get; set; }

        /// <summary>
        /// <para>Name: Image 128</para>
        /// <para>Internal: image_128</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_128")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("image_128")]
        public object Image128 { get; set; }

        /// <summary>
        /// <para>Name: Avatar</para>
        /// <para>Internal: avatar_1920</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("avatar_1920")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("avatar_1920")]
        public object Avatar1920 { get; set; }

        /// <summary>
        /// <para>Name: Avatar 1024</para>
        /// <para>Internal: avatar_1024</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("avatar_1024")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("avatar_1024")]
        public object Avatar1024 { get; set; }

        /// <summary>
        /// <para>Name: Avatar 512</para>
        /// <para>Internal: avatar_512</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("avatar_512")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("avatar_512")]
        public object Avatar512 { get; set; }

        /// <summary>
        /// <para>Name: Avatar 256</para>
        /// <para>Internal: avatar_256</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("avatar_256")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("avatar_256")]
        public object Avatar256 { get; set; }

        /// <summary>
        /// <para>Name: Avatar 128</para>
        /// <para>Internal: avatar_128</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("avatar_128")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("avatar_128")]
        public object Avatar128 { get; set; }

        /// <summary>
        /// <para>Name: Complete Name</para>
        /// <para>Internal: complete_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("complete_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("complete_name")]
        public string CompleteName { get; set; }

        /// <summary>
        /// <para>Name: Related Company</para>
        /// <para>Internal: parent_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("parent_id")]
        public int? ParentId { get; set; }

        /// <summary>
        /// <para>Name: Parent name</para>
        /// <para>Internal: parent_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("parent_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("parent_name")]
        public string ParentName { get; set; }

        /// <summary>
        /// <para>Name: Contact</para>
        /// <para>Internal: child_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("child_ids")]
        [OdooField("child_ids")]
        public List<int> ChildIds { get; set; }

        /// <summary>
        /// <para>Name: Reference</para>
        /// <para>Internal: ref</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("ref")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("ref")]
        public string Ref { get; set; }

        /// <summary>
        /// <para>Name: Language</para>
        /// <para>Internal: lang</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [de_DE]=German / Deutsch</para>
        /// </summary>
        [JsonPropertyName("lang")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("lang")]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Name: Active Lang Count</para>
        /// <para>Internal: active_lang_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("active_lang_count")]
        [OdooField("active_lang_count")]
        public int ActiveLangCount { get; set; }

        /// <summary>
        /// <para>Name: Timezone</para>
        /// <para>Internal: tz</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [Africa/Abidjan]=Africa/Abidjan,[Africa/Accra]=Africa/Accra,[Africa/Addis_Ababa]=Africa/Addis_Ababa,[Africa/Algiers]=Africa/Algiers,[Africa/Asmara]=Africa/Asmara,[Africa/Asmera]=Africa/Asmera,[Africa/Bamako]=Africa/Bamako,[Africa/Bangui]=Africa/Bangui,[Africa/Banjul]=Africa/Banjul,[Africa/Bissau]=Africa/Bissau,[Africa/Blantyre]=Africa/Blantyre,[Africa/Brazzaville]=Africa/Brazzaville,[Africa/Bujumbura]=Africa/Bujumbura,[Africa/Cairo]=Africa/Cairo,[Africa/Casablanca]=Africa/Casablanca,[Africa/Ceuta]=Africa/Ceuta,[Africa/Conakry]=Africa/Conakry,[Africa/Dakar]=Africa/Dakar,[Africa/Dar_es_Salaam]=Africa/Dar_es_Salaam,[Africa/Djibouti]=Africa/Djibouti,[Africa/Douala]=Africa/Douala,[Africa/El_Aaiun]=Africa/El_Aaiun,[Africa/Freetown]=Africa/Freetown,[Africa/Gaborone]=Africa/Gaborone,[Africa/Harare]=Africa/Harare,[Africa/Johannesburg]=Africa/Johannesburg,[Africa/Juba]=Africa/Juba,[Africa/Kampala]=Africa/Kampala,[Africa/Khartoum]=Africa/Khartoum,[Africa/Kigali]=Africa/Kigali,[Africa/Kinshasa]=Africa/Kinshasa,[Africa/Lagos]=Africa/Lagos,[Africa/Libreville]=Africa/Libreville,[Africa/Lome]=Africa/Lome,[Africa/Luanda]=Africa/Luanda,[Africa/Lubumbashi]=Africa/Lubumbashi,[Africa/Lusaka]=Africa/Lusaka,[Africa/Malabo]=Africa/Malabo,[Africa/Maputo]=Africa/Maputo,[Africa/Maseru]=Africa/Maseru,[Africa/Mbabane]=Africa/Mbabane,[Africa/Mogadishu]=Africa/Mogadishu,[Africa/Monrovia]=Africa/Monrovia,[Africa/Nairobi]=Africa/Nairobi,[Africa/Ndjamena]=Africa/Ndjamena,[Africa/Niamey]=Africa/Niamey,[Africa/Nouakchott]=Africa/Nouakchott,[Africa/Ouagadougou]=Africa/Ouagadougou,[Africa/Porto-Novo]=Africa/Porto-Novo,[Africa/Sao_Tome]=Africa/Sao_Tome,[Africa/Timbuktu]=Africa/Timbuktu,[Africa/Tripoli]=Africa/Tripoli,[Africa/Tunis]=Africa/Tunis,[Africa/Windhoek]=Africa/Windhoek,[America/Adak]=America/Adak,[America/Anchorage]=America/Anchorage,[America/Anguilla]=America/Anguilla,[America/Antigua]=America/Antigua,[America/Araguaina]=America/Araguaina,[America/Argentina/Buenos_Aires]=America/Argentina/Buenos_Aires,[America/Argentina/Catamarca]=America/Argentina/Catamarca,[America/Argentina/ComodRivadavia]=America/Argentina/ComodRivadavia,[America/Argentina/Cordoba]=America/Argentina/Cordoba,[America/Argentina/Jujuy]=America/Argentina/Jujuy,[America/Argentina/La_Rioja]=America/Argentina/La_Rioja,[America/Argentina/Mendoza]=America/Argentina/Mendoza,[America/Argentina/Rio_Gallegos]=America/Argentina/Rio_Gallegos,[America/Argentina/Salta]=America/Argentina/Salta,[America/Argentina/San_Juan]=America/Argentina/San_Juan,[America/Argentina/San_Luis]=America/Argentina/San_Luis,[America/Argentina/Tucuman]=America/Argentina/Tucuman,[America/Argentina/Ushuaia]=America/Argentina/Ushuaia,[America/Aruba]=America/Aruba,[America/Asuncion]=America/Asuncion,[America/Atikokan]=America/Atikokan,[America/Atka]=America/Atka,[America/Bahia]=America/Bahia,[America/Bahia_Banderas]=America/Bahia_Banderas,[America/Barbados]=America/Barbados,[America/Belem]=America/Belem,[America/Belize]=America/Belize,[America/Blanc-Sablon]=America/Blanc-Sablon,[America/Boa_Vista]=America/Boa_Vista,[America/Bogota]=America/Bogota,[America/Boise]=America/Boise,[America/Buenos_Aires]=America/Buenos_Aires,[America/Cambridge_Bay]=America/Cambridge_Bay,[America/Campo_Grande]=America/Campo_Grande,[America/Cancun]=America/Cancun,[America/Caracas]=America/Caracas,[America/Catamarca]=America/Catamarca,[America/Cayenne]=America/Cayenne,[America/Cayman]=America/Cayman,[America/Chicago]=America/Chicago,[America/Chihuahua]=America/Chihuahua,[America/Ciudad_Juarez]=America/Ciudad_Juarez,[America/Coral_Harbour]=America/Coral_Harbour,[America/Cordoba]=America/Cordoba,[America/Costa_Rica]=America/Costa_Rica,[America/Coyhaique]=America/Coyhaique,[America/Creston]=America/Creston,[America/Cuiaba]=America/Cuiaba,[America/Curacao]=America/Curacao,[America/Danmarkshavn]=America/Danmarkshavn,[America/Dawson]=America/Dawson,[America/Dawson_Creek]=America/Dawson_Creek,[America/Denver]=America/Denver,[America/Detroit]=America/Detroit,[America/Dominica]=America/Dominica,[America/Edmonton]=America/Edmonton,[America/Eirunepe]=America/Eirunepe,[America/El_Salvador]=America/El_Salvador,[America/Ensenada]=America/Ensenada,[America/Fort_Nelson]=America/Fort_Nelson,[America/Fort_Wayne]=America/Fort_Wayne,[America/Fortaleza]=America/Fortaleza,[America/Glace_Bay]=America/Glace_Bay,[America/Godthab]=America/Godthab,[America/Goose_Bay]=America/Goose_Bay,[America/Grand_Turk]=America/Grand_Turk,[America/Grenada]=America/Grenada,[America/Guadeloupe]=America/Guadeloupe,[America/Guatemala]=America/Guatemala,[America/Guayaquil]=America/Guayaquil,[America/Guyana]=America/Guyana,[America/Halifax]=America/Halifax,[America/Havana]=America/Havana,[America/Hermosillo]=America/Hermosillo,[America/Indiana/Indianapolis]=America/Indiana/Indianapolis,[America/Indiana/Knox]=America/Indiana/Knox,[America/Indiana/Marengo]=America/Indiana/Marengo,[America/Indiana/Petersburg]=America/Indiana/Petersburg,[America/Indiana/Tell_City]=America/Indiana/Tell_City,[America/Indiana/Vevay]=America/Indiana/Vevay,[America/Indiana/Vincennes]=America/Indiana/Vincennes,[America/Indiana/Winamac]=America/Indiana/Winamac,[America/Indianapolis]=America/Indianapolis,[America/Inuvik]=America/Inuvik,[America/Iqaluit]=America/Iqaluit,[America/Jamaica]=America/Jamaica,[America/Jujuy]=America/Jujuy,[America/Juneau]=America/Juneau,[America/Kentucky/Louisville]=America/Kentucky/Louisville,[America/Kentucky/Monticello]=America/Kentucky/Monticello,[America/Knox_IN]=America/Knox_IN,[America/Kralendijk]=America/Kralendijk,[America/La_Paz]=America/La_Paz,[America/Lima]=America/Lima,[America/Los_Angeles]=America/Los_Angeles,[America/Louisville]=America/Louisville,[America/Lower_Princes]=America/Lower_Princes,[America/Maceio]=America/Maceio,[America/Managua]=America/Managua,[America/Manaus]=America/Manaus,[America/Marigot]=America/Marigot,[America/Martinique]=America/Martinique,[America/Matamoros]=America/Matamoros,[America/Mazatlan]=America/Mazatlan,[America/Mendoza]=America/Mendoza,[America/Menominee]=America/Menominee,[America/Merida]=America/Merida,[America/Metlakatla]=America/Metlakatla,[America/Mexico_City]=America/Mexico_City,[America/Miquelon]=America/Miquelon,[America/Moncton]=America/Moncton,[America/Monterrey]=America/Monterrey,[America/Montevideo]=America/Montevideo,[America/Montreal]=America/Montreal,[America/Montserrat]=America/Montserrat,[America/Nassau]=America/Nassau,[America/New_York]=America/New_York,[America/Nipigon]=America/Nipigon,[America/Nome]=America/Nome,[America/Noronha]=America/Noronha,[America/North_Dakota/Beulah]=America/North_Dakota/Beulah,[America/North_Dakota/Center]=America/North_Dakota/Center,[America/North_Dakota/New_Salem]=America/North_Dakota/New_Salem,[America/Nuuk]=America/Nuuk,[America/Ojinaga]=America/Ojinaga,[America/Panama]=America/Panama,[America/Pangnirtung]=America/Pangnirtung,[America/Paramaribo]=America/Paramaribo,[America/Phoenix]=America/Phoenix,[America/Port-au-Prince]=America/Port-au-Prince,[America/Port_of_Spain]=America/Port_of_Spain,[America/Porto_Acre]=America/Porto_Acre,[America/Porto_Velho]=America/Porto_Velho,[America/Puerto_Rico]=America/Puerto_Rico,[America/Punta_Arenas]=America/Punta_Arenas,[America/Rainy_River]=America/Rainy_River,[America/Rankin_Inlet]=America/Rankin_Inlet,[America/Recife]=America/Recife,[America/Regina]=America/Regina,[America/Resolute]=America/Resolute,[America/Rio_Branco]=America/Rio_Branco,[America/Rosario]=America/Rosario,[America/Santa_Isabel]=America/Santa_Isabel,[America/Santarem]=America/Santarem,[America/Santiago]=America/Santiago,[America/Santo_Domingo]=America/Santo_Domingo,[America/Sao_Paulo]=America/Sao_Paulo,[America/Scoresbysund]=America/Scoresbysund,[America/Shiprock]=America/Shiprock,[America/Sitka]=America/Sitka,[America/St_Barthelemy]=America/St_Barthelemy,[America/St_Johns]=America/St_Johns,[America/St_Kitts]=America/St_Kitts,[America/St_Lucia]=America/St_Lucia,[America/St_Thomas]=America/St_Thomas,[America/St_Vincent]=America/St_Vincent,[America/Swift_Current]=America/Swift_Current,[America/Tegucigalpa]=America/Tegucigalpa,[America/Thule]=America/Thule,[America/Thunder_Bay]=America/Thunder_Bay,[America/Tijuana]=America/Tijuana,[America/Toronto]=America/Toronto,[America/Tortola]=America/Tortola,[America/Vancouver]=America/Vancouver,[America/Virgin]=America/Virgin,[America/Whitehorse]=America/Whitehorse,[America/Winnipeg]=America/Winnipeg,[America/Yakutat]=America/Yakutat,[America/Yellowknife]=America/Yellowknife,[Antarctica/Casey]=Antarctica/Casey,[Antarctica/Davis]=Antarctica/Davis,[Antarctica/DumontDUrville]=Antarctica/DumontDUrville,[Antarctica/Macquarie]=Antarctica/Macquarie,[Antarctica/Mawson]=Antarctica/Mawson,[Antarctica/McMurdo]=Antarctica/McMurdo,[Antarctica/Palmer]=Antarctica/Palmer,[Antarctica/Rothera]=Antarctica/Rothera,[Antarctica/South_Pole]=Antarctica/South_Pole,[Antarctica/Syowa]=Antarctica/Syowa,[Antarctica/Troll]=Antarctica/Troll,[Antarctica/Vostok]=Antarctica/Vostok,[Arctic/Longyearbyen]=Arctic/Longyearbyen,[Asia/Aden]=Asia/Aden,[Asia/Almaty]=Asia/Almaty,[Asia/Amman]=Asia/Amman,[Asia/Anadyr]=Asia/Anadyr,[Asia/Aqtau]=Asia/Aqtau,[Asia/Aqtobe]=Asia/Aqtobe,[Asia/Ashgabat]=Asia/Ashgabat,[Asia/Ashkhabad]=Asia/Ashkhabad,[Asia/Atyrau]=Asia/Atyrau,[Asia/Baghdad]=Asia/Baghdad,[Asia/Bahrain]=Asia/Bahrain,[Asia/Baku]=Asia/Baku,[Asia/Bangkok]=Asia/Bangkok,[Asia/Barnaul]=Asia/Barnaul,[Asia/Beirut]=Asia/Beirut,[Asia/Bishkek]=Asia/Bishkek,[Asia/Brunei]=Asia/Brunei,[Asia/Calcutta]=Asia/Calcutta,[Asia/Chita]=Asia/Chita,[Asia/Choibalsan]=Asia/Choibalsan,[Asia/Chongqing]=Asia/Chongqing,[Asia/Chungking]=Asia/Chungking,[Asia/Colombo]=Asia/Colombo,[Asia/Dacca]=Asia/Dacca,[Asia/Damascus]=Asia/Damascus,[Asia/Dhaka]=Asia/Dhaka,[Asia/Dili]=Asia/Dili,[Asia/Dubai]=Asia/Dubai,[Asia/Dushanbe]=Asia/Dushanbe,[Asia/Famagusta]=Asia/Famagusta,[Asia/Gaza]=Asia/Gaza,[Asia/Harbin]=Asia/Harbin,[Asia/Hebron]=Asia/Hebron,[Asia/Ho_Chi_Minh]=Asia/Ho_Chi_Minh,[Asia/Hong_Kong]=Asia/Hong_Kong,[Asia/Hovd]=Asia/Hovd,[Asia/Irkutsk]=Asia/Irkutsk,[Asia/Istanbul]=Asia/Istanbul,[Asia/Jakarta]=Asia/Jakarta,[Asia/Jayapura]=Asia/Jayapura,[Asia/Jerusalem]=Asia/Jerusalem,[Asia/Kabul]=Asia/Kabul,[Asia/Kamchatka]=Asia/Kamchatka,[Asia/Karachi]=Asia/Karachi,[Asia/Kashgar]=Asia/Kashgar,[Asia/Kathmandu]=Asia/Kathmandu,[Asia/Katmandu]=Asia/Katmandu,[Asia/Khandyga]=Asia/Khandyga,[Asia/Kolkata]=Asia/Kolkata,[Asia/Krasnoyarsk]=Asia/Krasnoyarsk,[Asia/Kuala_Lumpur]=Asia/Kuala_Lumpur,[Asia/Kuching]=Asia/Kuching,[Asia/Kuwait]=Asia/Kuwait,[Asia/Macao]=Asia/Macao,[Asia/Macau]=Asia/Macau,[Asia/Magadan]=Asia/Magadan,[Asia/Makassar]=Asia/Makassar,[Asia/Manila]=Asia/Manila,[Asia/Muscat]=Asia/Muscat,[Asia/Nicosia]=Asia/Nicosia,[Asia/Novokuznetsk]=Asia/Novokuznetsk,[Asia/Novosibirsk]=Asia/Novosibirsk,[Asia/Omsk]=Asia/Omsk,[Asia/Oral]=Asia/Oral,[Asia/Phnom_Penh]=Asia/Phnom_Penh,[Asia/Pontianak]=Asia/Pontianak,[Asia/Pyongyang]=Asia/Pyongyang,[Asia/Qatar]=Asia/Qatar,[Asia/Qostanay]=Asia/Qostanay,[Asia/Qyzylorda]=Asia/Qyzylorda,[Asia/Rangoon]=Asia/Rangoon,[Asia/Riyadh]=Asia/Riyadh,[Asia/Saigon]=Asia/Saigon,[Asia/Sakhalin]=Asia/Sakhalin,[Asia/Samarkand]=Asia/Samarkand,[Asia/Seoul]=Asia/Seoul,[Asia/Shanghai]=Asia/Shanghai,[Asia/Singapore]=Asia/Singapore,[Asia/Srednekolymsk]=Asia/Srednekolymsk,[Asia/Taipei]=Asia/Taipei,[Asia/Tashkent]=Asia/Tashkent,[Asia/Tbilisi]=Asia/Tbilisi,[Asia/Tehran]=Asia/Tehran,[Asia/Tel_Aviv]=Asia/Tel_Aviv,[Asia/Thimbu]=Asia/Thimbu,[Asia/Thimphu]=Asia/Thimphu,[Asia/Tokyo]=Asia/Tokyo,[Asia/Tomsk]=Asia/Tomsk,[Asia/Ujung_Pandang]=Asia/Ujung_Pandang,[Asia/Ulaanbaatar]=Asia/Ulaanbaatar,[Asia/Ulan_Bator]=Asia/Ulan_Bator,[Asia/Urumqi]=Asia/Urumqi,[Asia/Ust-Nera]=Asia/Ust-Nera,[Asia/Vientiane]=Asia/Vientiane,[Asia/Vladivostok]=Asia/Vladivostok,[Asia/Yakutsk]=Asia/Yakutsk,[Asia/Yangon]=Asia/Yangon,[Asia/Yekaterinburg]=Asia/Yekaterinburg,[Asia/Yerevan]=Asia/Yerevan,[Atlantic/Azores]=Atlantic/Azores,[Atlantic/Bermuda]=Atlantic/Bermuda,[Atlantic/Canary]=Atlantic/Canary,[Atlantic/Cape_Verde]=Atlantic/Cape_Verde,[Atlantic/Faeroe]=Atlantic/Faeroe,[Atlantic/Faroe]=Atlantic/Faroe,[Atlantic/Jan_Mayen]=Atlantic/Jan_Mayen,[Atlantic/Madeira]=Atlantic/Madeira,[Atlantic/Reykjavik]=Atlantic/Reykjavik,[Atlantic/South_Georgia]=Atlantic/South_Georgia,[Atlantic/St_Helena]=Atlantic/St_Helena,[Atlantic/Stanley]=Atlantic/Stanley,[Australia/ACT]=Australia/ACT,[Australia/Adelaide]=Australia/Adelaide,[Australia/Brisbane]=Australia/Brisbane,[Australia/Broken_Hill]=Australia/Broken_Hill,[Australia/Canberra]=Australia/Canberra,[Australia/Currie]=Australia/Currie,[Australia/Darwin]=Australia/Darwin,[Australia/Eucla]=Australia/Eucla,[Australia/Hobart]=Australia/Hobart,[Australia/LHI]=Australia/LHI,[Australia/Lindeman]=Australia/Lindeman,[Australia/Lord_Howe]=Australia/Lord_Howe,[Australia/Melbourne]=Australia/Melbourne,[Australia/NSW]=Australia/NSW,[Australia/North]=Australia/North,[Australia/Perth]=Australia/Perth,[Australia/Queensland]=Australia/Queensland,[Australia/South]=Australia/South,[Australia/Sydney]=Australia/Sydney,[Australia/Tasmania]=Australia/Tasmania,[Australia/Victoria]=Australia/Victoria,[Australia/West]=Australia/West,[Australia/Yancowinna]=Australia/Yancowinna,[Brazil/Acre]=Brazil/Acre,[Brazil/DeNoronha]=Brazil/DeNoronha,[Brazil/East]=Brazil/East,[Brazil/West]=Brazil/West,[CET]=CET,[CST6CDT]=CST6CDT,[Canada/Atlantic]=Canada/Atlantic,[Canada/Central]=Canada/Central,[Canada/Eastern]=Canada/Eastern,[Canada/Mountain]=Canada/Mountain,[Canada/Newfoundland]=Canada/Newfoundland,[Canada/Pacific]=Canada/Pacific,[Canada/Saskatchewan]=Canada/Saskatchewan,[Canada/Yukon]=Canada/Yukon,[Chile/Continental]=Chile/Continental,[Chile/EasterIsland]=Chile/EasterIsland,[Cuba]=Cuba,[EET]=EET,[EST]=EST,[EST5EDT]=EST5EDT,[Egypt]=Egypt,[Eire]=Eire,[Europe/Amsterdam]=Europe/Amsterdam,[Europe/Andorra]=Europe/Andorra,[Europe/Astrakhan]=Europe/Astrakhan,[Europe/Athens]=Europe/Athens,[Europe/Belfast]=Europe/Belfast,[Europe/Belgrade]=Europe/Belgrade,[Europe/Berlin]=Europe/Berlin,[Europe/Bratislava]=Europe/Bratislava,[Europe/Brussels]=Europe/Brussels,[Europe/Bucharest]=Europe/Bucharest,[Europe/Budapest]=Europe/Budapest,[Europe/Busingen]=Europe/Busingen,[Europe/Chisinau]=Europe/Chisinau,[Europe/Copenhagen]=Europe/Copenhagen,[Europe/Dublin]=Europe/Dublin,[Europe/Gibraltar]=Europe/Gibraltar,[Europe/Guernsey]=Europe/Guernsey,[Europe/Helsinki]=Europe/Helsinki,[Europe/Isle_of_Man]=Europe/Isle_of_Man,[Europe/Istanbul]=Europe/Istanbul,[Europe/Jersey]=Europe/Jersey,[Europe/Kaliningrad]=Europe/Kaliningrad,[Europe/Kiev]=Europe/Kiev,[Europe/Kirov]=Europe/Kirov,[Europe/Kyiv]=Europe/Kyiv,[Europe/Lisbon]=Europe/Lisbon,[Europe/Ljubljana]=Europe/Ljubljana,[Europe/London]=Europe/London,[Europe/Luxembourg]=Europe/Luxembourg,[Europe/Madrid]=Europe/Madrid,[Europe/Malta]=Europe/Malta,[Europe/Mariehamn]=Europe/Mariehamn,[Europe/Minsk]=Europe/Minsk,[Europe/Monaco]=Europe/Monaco,[Europe/Moscow]=Europe/Moscow,[Europe/Nicosia]=Europe/Nicosia,[Europe/Oslo]=Europe/Oslo,[Europe/Paris]=Europe/Paris,[Europe/Podgorica]=Europe/Podgorica,[Europe/Prague]=Europe/Prague,[Europe/Riga]=Europe/Riga,[Europe/Rome]=Europe/Rome,[Europe/Samara]=Europe/Samara,[Europe/San_Marino]=Europe/San_Marino,[Europe/Sarajevo]=Europe/Sarajevo,[Europe/Saratov]=Europe/Saratov,[Europe/Simferopol]=Europe/Simferopol,[Europe/Skopje]=Europe/Skopje,[Europe/Sofia]=Europe/Sofia,[Europe/Stockholm]=Europe/Stockholm,[Europe/Tallinn]=Europe/Tallinn,[Europe/Tirane]=Europe/Tirane,[Europe/Tiraspol]=Europe/Tiraspol,[Europe/Ulyanovsk]=Europe/Ulyanovsk,[Europe/Uzhgorod]=Europe/Uzhgorod,[Europe/Vaduz]=Europe/Vaduz,[Europe/Vatican]=Europe/Vatican,[Europe/Vienna]=Europe/Vienna,[Europe/Vilnius]=Europe/Vilnius,[Europe/Volgograd]=Europe/Volgograd,[Europe/Warsaw]=Europe/Warsaw,[Europe/Zagreb]=Europe/Zagreb,[Europe/Zaporozhye]=Europe/Zaporozhye,[Europe/Zurich]=Europe/Zurich,[GB]=GB,[GB-Eire]=GB-Eire,[GMT]=GMT,[GMT+0]=GMT+0,[GMT-0]=GMT-0,[GMT0]=GMT0,[Greenwich]=Greenwich,[HST]=HST,[Hongkong]=Hongkong,[Iceland]=Iceland,[Indian/Antananarivo]=Indian/Antananarivo,[Indian/Chagos]=Indian/Chagos,[Indian/Christmas]=Indian/Christmas,[Indian/Cocos]=Indian/Cocos,[Indian/Comoro]=Indian/Comoro,[Indian/Kerguelen]=Indian/Kerguelen,[Indian/Mahe]=Indian/Mahe,[Indian/Maldives]=Indian/Maldives,[Indian/Mauritius]=Indian/Mauritius,[Indian/Mayotte]=Indian/Mayotte,[Indian/Reunion]=Indian/Reunion,[Iran]=Iran,[Israel]=Israel,[Jamaica]=Jamaica,[Japan]=Japan,[Kwajalein]=Kwajalein,[Libya]=Libya,[MET]=MET,[MST]=MST,[MST7MDT]=MST7MDT,[Mexico/BajaNorte]=Mexico/BajaNorte,[Mexico/BajaSur]=Mexico/BajaSur,[Mexico/General]=Mexico/General,[NZ]=NZ,[NZ-CHAT]=NZ-CHAT,[Navajo]=Navajo,[PRC]=PRC,[PST8PDT]=PST8PDT,[Pacific/Apia]=Pacific/Apia,[Pacific/Auckland]=Pacific/Auckland,[Pacific/Bougainville]=Pacific/Bougainville,[Pacific/Chatham]=Pacific/Chatham,[Pacific/Chuuk]=Pacific/Chuuk,[Pacific/Easter]=Pacific/Easter,[Pacific/Efate]=Pacific/Efate,[Pacific/Enderbury]=Pacific/Enderbury,[Pacific/Fakaofo]=Pacific/Fakaofo,[Pacific/Fiji]=Pacific/Fiji,[Pacific/Funafuti]=Pacific/Funafuti,[Pacific/Galapagos]=Pacific/Galapagos,[Pacific/Gambier]=Pacific/Gambier,[Pacific/Guadalcanal]=Pacific/Guadalcanal,[Pacific/Guam]=Pacific/Guam,[Pacific/Honolulu]=Pacific/Honolulu,[Pacific/Johnston]=Pacific/Johnston,[Pacific/Kanton]=Pacific/Kanton,[Pacific/Kiritimati]=Pacific/Kiritimati,[Pacific/Kosrae]=Pacific/Kosrae,[Pacific/Kwajalein]=Pacific/Kwajalein,[Pacific/Majuro]=Pacific/Majuro,[Pacific/Marquesas]=Pacific/Marquesas,[Pacific/Midway]=Pacific/Midway,[Pacific/Nauru]=Pacific/Nauru,[Pacific/Niue]=Pacific/Niue,[Pacific/Norfolk]=Pacific/Norfolk,[Pacific/Noumea]=Pacific/Noumea,[Pacific/Pago_Pago]=Pacific/Pago_Pago,[Pacific/Palau]=Pacific/Palau,[Pacific/Pitcairn]=Pacific/Pitcairn,[Pacific/Pohnpei]=Pacific/Pohnpei,[Pacific/Ponape]=Pacific/Ponape,[Pacific/Port_Moresby]=Pacific/Port_Moresby,[Pacific/Rarotonga]=Pacific/Rarotonga,[Pacific/Saipan]=Pacific/Saipan,[Pacific/Samoa]=Pacific/Samoa,[Pacific/Tahiti]=Pacific/Tahiti,[Pacific/Tarawa]=Pacific/Tarawa,[Pacific/Tongatapu]=Pacific/Tongatapu,[Pacific/Truk]=Pacific/Truk,[Pacific/Wake]=Pacific/Wake,[Pacific/Wallis]=Pacific/Wallis,[Pacific/Yap]=Pacific/Yap,[Poland]=Poland,[Portugal]=Portugal,[ROC]=ROC,[ROK]=ROK,[Singapore]=Singapore,[Turkey]=Turkey,[UCT]=UCT,[US/Alaska]=US/Alaska,[US/Aleutian]=US/Aleutian,[US/Arizona]=US/Arizona,[US/Central]=US/Central,[US/East-Indiana]=US/East-Indiana,[US/Eastern]=US/Eastern,[US/Hawaii]=US/Hawaii,[US/Indiana-Starke]=US/Indiana-Starke,[US/Michigan]=US/Michigan,[US/Mountain]=US/Mountain,[US/Pacific]=US/Pacific,[US/Samoa]=US/Samoa,[UTC]=UTC,[Universal]=Universal,[W-SU]=W-SU,[WET]=WET,[Zulu]=Zulu,[Etc/GMT]=Etc/GMT,[Etc/GMT+0]=Etc/GMT+0,[Etc/GMT+1]=Etc/GMT+1,[Etc/GMT+10]=Etc/GMT+10,[Etc/GMT+11]=Etc/GMT+11,[Etc/GMT+12]=Etc/GMT+12,[Etc/GMT+2]=Etc/GMT+2,[Etc/GMT+3]=Etc/GMT+3,[Etc/GMT+4]=Etc/GMT+4,[Etc/GMT+5]=Etc/GMT+5,[Etc/GMT+6]=Etc/GMT+6,[Etc/GMT+7]=Etc/GMT+7,[Etc/GMT+8]=Etc/GMT+8,[Etc/GMT+9]=Etc/GMT+9,[Etc/GMT-0]=Etc/GMT-0,[Etc/GMT-1]=Etc/GMT-1,[Etc/GMT-10]=Etc/GMT-10,[Etc/GMT-11]=Etc/GMT-11,[Etc/GMT-12]=Etc/GMT-12,[Etc/GMT-13]=Etc/GMT-13,[Etc/GMT-14]=Etc/GMT-14,[Etc/GMT-2]=Etc/GMT-2,[Etc/GMT-3]=Etc/GMT-3,[Etc/GMT-4]=Etc/GMT-4,[Etc/GMT-5]=Etc/GMT-5,[Etc/GMT-6]=Etc/GMT-6,[Etc/GMT-7]=Etc/GMT-7,[Etc/GMT-8]=Etc/GMT-8,[Etc/GMT-9]=Etc/GMT-9,[Etc/GMT0]=Etc/GMT0,[Etc/Greenwich]=Etc/Greenwich,[Etc/UCT]=Etc/UCT,[Etc/UTC]=Etc/UTC,[Etc/Universal]=Etc/Universal,[Etc/Zulu]=Etc/Zulu</para>
        /// </summary>
        [JsonPropertyName("tz")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("tz")]
        public string Tz { get; set; }

        /// <summary>
        /// <para>Name: Salesperson</para>
        /// <para>Internal: user_id</para>
        /// <para>Store: no</para>
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
        /// <para>Name: Tax ID</para>
        /// <para>Internal: vat</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("vat")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("vat")]
        public string Vat { get; set; }

        /// <summary>
        /// <para>Name: Tax ID Label</para>
        /// <para>Internal: vat_label</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("vat_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("vat_label")]
        public string VatLabel { get; set; }

        /// <summary>
        /// <para>Name: Partner with same Tax ID</para>
        /// <para>Internal: same_vat_partner_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("same_vat_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("same_vat_partner_id")]
        public int? SameVatPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Partner with same Company Registry</para>
        /// <para>Internal: same_company_registry_partner_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("same_company_registry_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("same_company_registry_partner_id")]
        public int? SameCompanyRegistryPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Company ID</para>
        /// <para>Internal: company_registry</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("company_registry")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_registry")]
        public string CompanyRegistry { get; set; }

        /// <summary>
        /// <para>Name: Company ID Label</para>
        /// <para>Internal: company_registry_label</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("company_registry_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_registry_label")]
        public string CompanyRegistryLabel { get; set; }

        /// <summary>
        /// <para>Name: Company Registry Placeholder</para>
        /// <para>Internal: company_registry_placeholder</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("company_registry_placeholder")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_registry_placeholder")]
        public string CompanyRegistryPlaceholder { get; set; }

        /// <summary>
        /// <para>Name: Banks</para>
        /// <para>Internal: bank_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.partner.bank</para>
        /// </summary>
        [JsonPropertyName("bank_ids")]
        [OdooField("bank_ids")]
        public List<int> BankIds { get; set; }

        /// <summary>
        /// <para>Name: Website Link</para>
        /// <para>Internal: website</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website")]
        public string Website { get; set; }

        /// <summary>
        /// <para>Name: Notes</para>
        /// <para>Internal: comment</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("comment")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Name: Tags</para>
        /// <para>Internal: category_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.partner.category</para>
        /// </summary>
        [JsonPropertyName("category_id")]
        [OdooField("category_id")]
        public List<int> CategoryId { get; set; }

        /// <summary>
        /// <para>Name: Employee</para>
        /// <para>Internal: employee</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("employee")]
        [OdooField("employee")]
        public bool Employee { get; set; }

        /// <summary>
        /// <para>Name: Job Position</para>
        /// <para>Internal: function</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("function")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("function")]
        public string Function { get; set; }

        /// <summary>
        /// <para>Name: Address Type</para>
        /// <para>Internal: type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [contact]=Contact,[invoice]=Invoice,[delivery]=Delivery,[followup]=Follow-up Address,[other]=Other</para>
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("type")]
        public string Type { get; set; }

        /// <summary>
        /// <para>Name: Street</para>
        /// <para>Internal: street</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("street")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("street")]
        public string Street { get; set; }

        /// <summary>
        /// <para>Name: Street2</para>
        /// <para>Internal: street2</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("street2")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("street2")]
        public string Street2 { get; set; }

        /// <summary>
        /// <para>Name: Zip</para>
        /// <para>Internal: zip</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("zip")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// <para>Name: City</para>
        /// <para>Internal: city</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("city")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("city")]
        public string City { get; set; }

        /// <summary>
        /// <para>Name: State</para>
        /// <para>Internal: state_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country.state</para>
        /// </summary>
        [JsonPropertyName("state_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("state_id")]
        public int? StateId { get; set; }

        /// <summary>
        /// <para>Name: Country</para>
        /// <para>Internal: country_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("country_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("country_id")]
        public int? CountryId { get; set; }

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
        /// <para>Name: Geo Latitude</para>
        /// <para>Internal: partner_latitude</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("partner_latitude")]
        [OdooField("partner_latitude")]
        public double PartnerLatitude { get; set; }

        /// <summary>
        /// <para>Name: Geo Longitude</para>
        /// <para>Internal: partner_longitude</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("partner_longitude")]
        [OdooField("partner_longitude")]
        public double PartnerLongitude { get; set; }

        /// <summary>
        /// <para>Name: Formatted Email</para>
        /// <para>Internal: email_formatted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email_formatted")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("email_formatted")]
        public string EmailFormatted { get; set; }

        /// <summary>
        /// <para>Name: Is a Company</para>
        /// <para>Internal: is_company</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_company")]
        [OdooField("is_company")]
        public bool IsCompany { get; set; }

        /// <summary>
        /// <para>Name: Is Public</para>
        /// <para>Internal: is_public</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_public")]
        [OdooField("is_public")]
        public bool IsPublic { get; set; }

        /// <summary>
        /// <para>Name: Industry</para>
        /// <para>Internal: industry_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner.industry</para>
        /// </summary>
        [JsonPropertyName("industry_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("industry_id")]
        public int? IndustryId { get; set; }

        /// <summary>
        /// <para>Name: Company Type</para>
        /// <para>Internal: company_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [person]=Individual,[company]=Company</para>
        /// </summary>
        [JsonPropertyName("company_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// <para>Name: Color Index</para>
        /// <para>Internal: color</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("color")]
        [OdooField("color")]
        public int Color { get; set; }

        /// <summary>
        /// <para>Name: Users</para>
        /// <para>Internal: user_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("user_ids")]
        [OdooField("user_ids")]
        public List<int> UserIds { get; set; }

        /// <summary>
        /// <para>Name: Share Partner</para>
        /// <para>Internal: partner_share</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("partner_share")]
        [OdooField("partner_share")]
        public bool PartnerShare { get; set; }

        /// <summary>
        /// <para>Name: Complete Address</para>
        /// <para>Internal: contact_address</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("contact_address")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("contact_address")]
        public string ContactAddress { get; set; }

        /// <summary>
        /// <para>Name: Commercial Entity</para>
        /// <para>Internal: commercial_partner_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("commercial_partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("commercial_partner_id")]
        public int? CommercialPartnerId { get; set; }

        /// <summary>
        /// <para>Name: Company Name Entity</para>
        /// <para>Internal: commercial_company_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("commercial_company_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("commercial_company_name")]
        public string CommercialCompanyName { get; set; }

        /// <summary>
        /// <para>Name: Company Name</para>
        /// <para>Internal: company_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("company_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// <para>Name: Self</para>
        /// <para>Internal: self</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("self")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("self")]
        public int? Self { get; set; }

        /// <summary>
        /// <para>Name: Contact Address Complete</para>
        /// <para>Internal: contact_address_complete</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("contact_address_complete")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("contact_address_complete")]
        public string ContactAddressComplete { get; set; }

        /// <summary>
        /// <para>Name: Channels</para>
        /// <para>Internal: channel_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: discuss.channel</para>
        /// </summary>
        [JsonPropertyName("channel_ids")]
        [OdooField("channel_ids")]
        public List<int> ChannelIds { get; set; }

        /// <summary>
        /// <para>Name: Channel Member</para>
        /// <para>Internal: channel_member_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: discuss.channel.member</para>
        /// </summary>
        [JsonPropertyName("channel_member_ids")]
        [OdooField("channel_member_ids")]
        public List<int> ChannelMemberIds { get; set; }

        /// <summary>
        /// <para>Name: Inlined Complete Address</para>
        /// <para>Internal: contact_address_inline</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("contact_address_inline")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("contact_address_inline")]
        public string ContactAddressInline { get; set; }

        /// <summary>
        /// <para>Name: Starred Message</para>
        /// <para>Internal: starred_message_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: mail.message</para>
        /// </summary>
        [JsonPropertyName("starred_message_ids")]
        [OdooField("starred_message_ids")]
        public List<int> StarredMessageIds { get; set; }

        /// <summary>
        /// <para>Name: Medium-sized image</para>
        /// <para>Internal: image_medium</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_medium")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("image_medium")]
        public object ImageMedium { get; set; }

        /// <summary>
        /// <para>Name: Signup Token Type</para>
        /// <para>Internal: signup_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("signup_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("signup_type")]
        public string SignupType { get; set; }

        /// <summary>
        /// <para>Name: # Meetings</para>
        /// <para>Internal: meeting_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("meeting_count")]
        [OdooField("meeting_count")]
        public int MeetingCount { get; set; }

        /// <summary>
        /// <para>Name: Meetings</para>
        /// <para>Internal: meeting_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: calendar.event</para>
        /// </summary>
        [JsonPropertyName("meeting_ids")]
        [OdooField("meeting_ids")]
        public List<int> MeetingIds { get; set; }

        /// <summary>
        /// <para>Name: Last notification marked as read from base Calendar</para>
        /// <para>Internal: calendar_last_notif_ack</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("calendar_last_notif_ack")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("calendar_last_notif_ack")]
        public DateTime? CalendarLastNotifAck { get; set; }

        /// <summary>
        /// <para>Name: Sanitized Number</para>
        /// <para>Internal: phone_sanitized</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("phone_sanitized")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("phone_sanitized")]
        public string PhoneSanitized { get; set; }

        /// <summary>
        /// <para>Name: Phone Blacklisted</para>
        /// <para>Internal: phone_sanitized_blacklisted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("phone_sanitized_blacklisted")]
        [OdooField("phone_sanitized_blacklisted")]
        public bool PhoneSanitizedBlacklisted { get; set; }

        /// <summary>
        /// <para>Name: Blacklisted Phone is Phone</para>
        /// <para>Internal: phone_blacklisted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("phone_blacklisted")]
        [OdooField("phone_blacklisted")]
        public bool PhoneBlacklisted { get; set; }

        /// <summary>
        /// <para>Name: Phone Number</para>
        /// <para>Internal: phone_mobile_search</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("phone_mobile_search")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("phone_mobile_search")]
        public string PhoneMobileSearch { get; set; }

        /// <summary>
        /// <para>Name: Pricelist</para>
        /// <para>Internal: property_product_pricelist</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.pricelist</para>
        /// </summary>
        [JsonPropertyName("property_product_pricelist")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_product_pricelist")]
        public int? PropertyProductPricelist { get; set; }

        /// <summary>
        /// <para>Name: Specific Property Product Pricelist</para>
        /// <para>Internal: specific_property_product_pricelist</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.pricelist</para>
        /// </summary>
        [JsonPropertyName("specific_property_product_pricelist")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("specific_property_product_pricelist")]
        public int? SpecificPropertyProductPricelist { get; set; }

        /// <summary>
        /// <para>Name: OCN Token</para>
        /// <para>Internal: ocn_token</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("ocn_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("ocn_token")]
        public string OcnToken { get; set; }

        /// <summary>
        /// <para>Name: Company database ID</para>
        /// <para>Internal: partner_gid</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("partner_gid")]
        [OdooField("partner_gid")]
        public int PartnerGid { get; set; }

        /// <summary>
        /// <para>Name: Additional info</para>
        /// <para>Internal: additional_info</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("additional_info")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("additional_info")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// <para>Name: Certifications Count</para>
        /// <para>Internal: certifications_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("certifications_count")]
        [OdooField("certifications_count")]
        public int CertificationsCount { get; set; }

        /// <summary>
        /// <para>Name: Company Certifications Count</para>
        /// <para>Internal: certifications_company_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("certifications_company_count")]
        [OdooField("certifications_company_count")]
        public int CertificationsCompanyCount { get; set; }

        /// <summary>
        /// <para>Name: Upcoming Appointments</para>
        /// <para>Internal: upcoming_appointment_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: calendar.event</para>
        /// </summary>
        [JsonPropertyName("upcoming_appointment_ids")]
        [OdooField("upcoming_appointment_ids")]
        public List<int> UpcomingAppointmentIds { get; set; }

        /// <summary>
        /// <para>Name: Payment Tokens</para>
        /// <para>Internal: payment_token_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: payment.token</para>
        /// </summary>
        [JsonPropertyName("payment_token_ids")]
        [OdooField("payment_token_ids")]
        public List<int> PaymentTokenIds { get; set; }

        /// <summary>
        /// <para>Name: Payment Token Count</para>
        /// <para>Internal: payment_token_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("payment_token_count")]
        [OdooField("payment_token_count")]
        public int PaymentTokenCount { get; set; }

        /// <summary>
        /// <para>Name: # Signatures</para>
        /// <para>Internal: signature_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("signature_count")]
        [OdooField("signature_count")]
        public int SignatureCount { get; set; }

        /// <summary>
        /// <para>Name: Fiscal Country Codes</para>
        /// <para>Internal: fiscal_country_codes</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("fiscal_country_codes")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("fiscal_country_codes")]
        public string FiscalCountryCodes { get; set; }

        /// <summary>
        /// <para>Name: Partner Vat Placeholder</para>
        /// <para>Internal: partner_vat_placeholder</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_vat_placeholder")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_vat_placeholder")]
        public string PartnerVatPlaceholder { get; set; }

        /// <summary>
        /// <para>Name: Partner Company Registry Placeholder</para>
        /// <para>Internal: partner_company_registry_placeholder</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("partner_company_registry_placeholder")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("partner_company_registry_placeholder")]
        public string PartnerCompanyRegistryPlaceholder { get; set; }

        /// <summary>
        /// <para>Name: Total Receivable</para>
        /// <para>Internal: credit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("credit")]
        [OdooField("credit")]
        public decimal Credit { get; set; }

        /// <summary>
        /// <para>Name: Credit To Invoice</para>
        /// <para>Internal: credit_to_invoice</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("credit_to_invoice")]
        [OdooField("credit_to_invoice")]
        public decimal CreditToInvoice { get; set; }

        /// <summary>
        /// <para>Name: Credit Limit</para>
        /// <para>Internal: credit_limit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("credit_limit")]
        [OdooField("credit_limit")]
        public double CreditLimit { get; set; }

        /// <summary>
        /// <para>Name: Partner Limit</para>
        /// <para>Internal: use_partner_credit_limit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_partner_credit_limit")]
        [OdooField("use_partner_credit_limit")]
        public bool UsePartnerCreditLimit { get; set; }

        /// <summary>
        /// <para>Name: Show Credit Limit</para>
        /// <para>Internal: show_credit_limit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_credit_limit")]
        [OdooField("show_credit_limit")]
        public bool ShowCreditLimit { get; set; }

        /// <summary>
        /// <para>Name: Days Sales Outstanding (DSO)</para>
        /// <para>Internal: days_sales_outstanding</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("days_sales_outstanding")]
        [OdooField("days_sales_outstanding")]
        public double DaysSalesOutstanding { get; set; }

        /// <summary>
        /// <para>Name: Total Payable</para>
        /// <para>Internal: debit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("debit")]
        [OdooField("debit")]
        public decimal Debit { get; set; }

        /// <summary>
        /// <para>Name: Payable Limit</para>
        /// <para>Internal: debit_limit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("debit_limit")]
        [OdooField("debit_limit")]
        public decimal DebitLimit { get; set; }

        /// <summary>
        /// <para>Name: Total Invoiced</para>
        /// <para>Internal: total_invoiced</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("total_invoiced")]
        [OdooField("total_invoiced")]
        public decimal TotalInvoiced { get; set; }

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
        /// <para>Name: Journal Items</para>
        /// <para>Internal: journal_item_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("journal_item_count")]
        [OdooField("journal_item_count")]
        public int JournalItemCount { get; set; }

        /// <summary>
        /// <para>Name: Account Payable</para>
        /// <para>Internal: property_account_payable_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("property_account_payable_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_account_payable_id")]
        public int? PropertyAccountPayableId { get; set; }

        /// <summary>
        /// <para>Name: Account Receivable</para>
        /// <para>Internal: property_account_receivable_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("property_account_receivable_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_account_receivable_id")]
        public int? PropertyAccountReceivableId { get; set; }

        /// <summary>
        /// <para>Name: Fiscal Position</para>
        /// <para>Internal: property_account_position_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.fiscal.position</para>
        /// </summary>
        [JsonPropertyName("property_account_position_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_account_position_id")]
        public int? PropertyAccountPositionId { get; set; }

        /// <summary>
        /// <para>Name: Customer Payment Terms</para>
        /// <para>Internal: property_payment_term_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.payment.term</para>
        /// </summary>
        [JsonPropertyName("property_payment_term_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_payment_term_id")]
        public int? PropertyPaymentTermId { get; set; }

        /// <summary>
        /// <para>Name: Vendor Payment Terms</para>
        /// <para>Internal: property_supplier_payment_term_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.payment.term</para>
        /// </summary>
        [JsonPropertyName("property_supplier_payment_term_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_supplier_payment_term_id")]
        public int? PropertySupplierPaymentTermId { get; set; }

        /// <summary>
        /// <para>Name: Companies that refers to partner</para>
        /// <para>Internal: ref_company_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("ref_company_ids")]
        [OdooField("ref_company_ids")]
        public List<int> RefCompanyIds { get; set; }

        /// <summary>
        /// <para>Name: # Vendor Bills</para>
        /// <para>Internal: supplier_invoice_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("supplier_invoice_count")]
        [OdooField("supplier_invoice_count")]
        public int SupplierInvoiceCount { get; set; }

        /// <summary>
        /// <para>Name: Invoices</para>
        /// <para>Internal: invoice_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("invoice_ids")]
        [OdooField("invoice_ids")]
        public List<int> InvoiceIds { get; set; }

        /// <summary>
        /// <para>Name: Partner Contracts</para>
        /// <para>Internal: contract_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.analytic.account</para>
        /// </summary>
        [JsonPropertyName("contract_ids")]
        [OdooField("contract_ids")]
        public List<int> ContractIds { get; set; }

        /// <summary>
        /// <para>Name: Bank</para>
        /// <para>Internal: bank_account_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("bank_account_count")]
        [OdooField("bank_account_count")]
        public int BankAccountCount { get; set; }

        /// <summary>
        /// <para>Name: Degree of trust you have in this debtor</para>
        /// <para>Internal: trust</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [good]=Good Debtor,[normal]=Normal Debtor,[bad]=Bad Debtor</para>
        /// </summary>
        [JsonPropertyName("trust")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("trust")]
        public string Trust { get; set; }

        /// <summary>
        /// <para>Name: Ignore Abnormal Invoice Date</para>
        /// <para>Internal: ignore_abnormal_invoice_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("ignore_abnormal_invoice_date")]
        [OdooField("ignore_abnormal_invoice_date")]
        public bool IgnoreAbnormalInvoiceDate { get; set; }

        /// <summary>
        /// <para>Name: Ignore Abnormal Invoice Amount</para>
        /// <para>Internal: ignore_abnormal_invoice_amount</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("ignore_abnormal_invoice_amount")]
        [OdooField("ignore_abnormal_invoice_amount")]
        public bool IgnoreAbnormalInvoiceAmount { get; set; }

        /// <summary>
        /// <para>Name: Invoice</para>
        /// <para>Internal: invoice_warn</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no-message]=No Message,[warning]=Warning,[block]=Blocking Message</para>
        /// </summary>
        [JsonPropertyName("invoice_warn")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_warn")]
        public string InvoiceWarn { get; set; }

        /// <summary>
        /// <para>Name: Message for Invoice</para>
        /// <para>Internal: invoice_warn_msg</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("invoice_warn_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_warn_msg")]
        public string InvoiceWarnMsg { get; set; }

        /// <summary>
        /// <para>Name: Invoice sending</para>
        /// <para>Internal: invoice_sending_method</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [manual]=Manual,[email]=by Email,[snailmail]=by Post,[peppol]=by Peppol</para>
        /// </summary>
        [JsonPropertyName("invoice_sending_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_sending_method")]
        public string InvoiceSendingMethod { get; set; }

        /// <summary>
        /// <para>Name: eInvoice format</para>
        /// <para>Internal: invoice_edi_format</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [facturx]=Factur-X (CII),[ubl_bis3]=BIS Billing 3.0,[xrechnung]=XRechnung CIUS,[nlcius]=NLCIUS,[ubl_a_nz]=BIS Billing 3.0 A-NZ,[ubl_sg]=BIS Billing 3.0 SG</para>
        /// </summary>
        [JsonPropertyName("invoice_edi_format")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_edi_format")]
        public string InvoiceEdiFormat { get; set; }

        /// <summary>
        /// <para>Name: Invoice Edi Format Store</para>
        /// <para>Internal: invoice_edi_format_store</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("invoice_edi_format_store")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_edi_format_store")]
        public string InvoiceEdiFormatStore { get; set; }

        /// <summary>
        /// <para>Name: Display Invoice Edi Format</para>
        /// <para>Internal: display_invoice_edi_format</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_invoice_edi_format")]
        [OdooField("display_invoice_edi_format")]
        public bool DisplayInvoiceEdiFormat { get; set; }

        /// <summary>
        /// <para>Name: Invoice report</para>
        /// <para>Internal: invoice_template_pdf_report_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.actions.report</para>
        /// </summary>
        [JsonPropertyName("invoice_template_pdf_report_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("invoice_template_pdf_report_id")]
        public int? InvoiceTemplatePdfReportId { get; set; }

        /// <summary>
        /// <para>Name: Available Invoice Template Pdf Report</para>
        /// <para>Internal: available_invoice_template_pdf_report_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.actions.report</para>
        /// </summary>
        [JsonPropertyName("available_invoice_template_pdf_report_ids")]
        [OdooField("available_invoice_template_pdf_report_ids")]
        public List<int> AvailableInvoiceTemplatePdfReportIds { get; set; }

        /// <summary>
        /// <para>Name: Display Invoice Template Pdf Report</para>
        /// <para>Internal: display_invoice_template_pdf_report_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_invoice_template_pdf_report_id")]
        [OdooField("display_invoice_template_pdf_report_id")]
        public bool DisplayInvoiceTemplatePdfReportId { get; set; }

        /// <summary>
        /// <para>Name: Supplier Rank</para>
        /// <para>Internal: supplier_rank</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("supplier_rank")]
        [OdooField("supplier_rank")]
        public int SupplierRank { get; set; }

        /// <summary>
        /// <para>Name: Customer Rank</para>
        /// <para>Internal: customer_rank</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("customer_rank")]
        [OdooField("customer_rank")]
        public int CustomerRank { get; set; }

        /// <summary>
        /// <para>Name: Auto-post bills</para>
        /// <para>Internal: autopost_bills</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [always]=Always,[ask]=Ask after 3 validations without edits,[never]=Never</para>
        /// </summary>
        [JsonPropertyName("autopost_bills")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("autopost_bills")]
        public string AutopostBills { get; set; }

        /// <summary>
        /// <para>Name: Duplicated Bank Account Partners Count</para>
        /// <para>Internal: duplicated_bank_account_partners_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("duplicated_bank_account_partners_count")]
        [OdooField("duplicated_bank_account_partners_count")]
        public int DuplicatedBankAccountPartnersCount { get; set; }

        /// <summary>
        /// <para>Name: Is Coa Installed</para>
        /// <para>Internal: is_coa_installed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_coa_installed")]
        [OdooField("is_coa_installed")]
        public bool IsCoaInstalled { get; set; }

        /// <summary>
        /// <para>Name: Property Outbound Payment Method Line</para>
        /// <para>Internal: property_outbound_payment_method_line_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.payment.method.line</para>
        /// </summary>
        [JsonPropertyName("property_outbound_payment_method_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_outbound_payment_method_line_id")]
        public int? PropertyOutboundPaymentMethodLineId { get; set; }

        /// <summary>
        /// <para>Name: Property Inbound Payment Method Line</para>
        /// <para>Internal: property_inbound_payment_method_line_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.payment.method.line</para>
        /// </summary>
        [JsonPropertyName("property_inbound_payment_method_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_inbound_payment_method_line_id")]
        public int? PropertyInboundPaymentMethodLineId { get; set; }

        /// <summary>
        /// <para>Name: Opportunities</para>
        /// <para>Internal: opportunity_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: crm.lead</para>
        /// </summary>
        [JsonPropertyName("opportunity_ids")]
        [OdooField("opportunity_ids")]
        public List<int> OpportunityIds { get; set; }

        /// <summary>
        /// <para>Name: Opportunity Count</para>
        /// <para>Internal: opportunity_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("opportunity_count")]
        [OdooField("opportunity_count")]
        public int OpportunityCount { get; set; }

        /// <summary>
        /// <para>Name: Tickets</para>
        /// <para>Internal: ticket_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("ticket_count")]
        [OdooField("ticket_count")]
        public int TicketCount { get; set; }

        /// <summary>
        /// <para>Name: SLA Policies</para>
        /// <para>Internal: sla_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: helpdesk.sla</para>
        /// </summary>
        [JsonPropertyName("sla_ids")]
        [OdooField("sla_ids")]
        public List<int> SlaIds { get; set; }

        /// <summary>
        /// <para>Name: Employees Count</para>
        /// <para>Internal: employees_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("employees_count")]
        [OdooField("employees_count")]
        public int EmployeesCount { get; set; }

        /// <summary>
        /// <para>Name: Visitors</para>
        /// <para>Internal: visitor_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: website.visitor</para>
        /// </summary>
        [JsonPropertyName("visitor_ids")]
        [OdooField("visitor_ids")]
        public List<int> VisitorIds { get; set; }

        /// <summary>
        /// <para>Name: Is Ubl Format</para>
        /// <para>Internal: is_ubl_format</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_ubl_format")]
        [OdooField("is_ubl_format")]
        public bool IsUblFormat { get; set; }

        /// <summary>
        /// <para>Name: Is Peppol Edi Format</para>
        /// <para>Internal: is_peppol_edi_format</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_peppol_edi_format")]
        [OdooField("is_peppol_edi_format")]
        public bool IsPeppolEdiFormat { get; set; }

        /// <summary>
        /// <para>Name: Peppol Endpoint</para>
        /// <para>Internal: peppol_endpoint</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("peppol_endpoint")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("peppol_endpoint")]
        public string PeppolEndpoint { get; set; }

        /// <summary>
        /// <para>Name: Peppol e-address (EAS)</para>
        /// <para>Internal: peppol_eas</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [9923]=Albania VAT,[9922]=Andorra VAT,[0151]=Australia ABN,[9914]=Austria UID,[9915]=Austria VOKZ,[0208]=Belgian Company Registry,[9925]=Belgian VAT,[9924]=Bosnia and Herzegovina VAT,[9926]=Bulgaria VAT,[9934]=Croatia VAT,[9928]=Cyprus VAT,[9929]=Czech Republic VAT,[0096]=Denmark P,[0184]=Denmark CVR,[0198]=Denmark SE,[0191]=Estonia Company code,[9931]=Estonia VAT,[0037]=Finland LY-tunnus,[0216]=Finland OVT code,[0213]=Finland VAT,[0002]=France SIRENE,[0009]=France SIRET,[9957]=France VAT,[0204]=Germany Leitweg-ID,[9930]=Germany VAT,[9933]=Greece VAT,[9910]=Hungary VAT,[0196]=Iceland Kennitala,[9935]=Ireland VAT,[0211]=Italia Partita IVA,[0097]=Italia FTI,[0188]=Japan SST,[0221]=Japan IIN,[9939]=Latvia VAT,[9936]=Liechtenstein VAT,[0200]=Lithuania JAK,[9937]=Lithuania VAT,[9938]=Luxembourg VAT,[9942]=Macedonia VAT,[0230]=Malaysia,[9943]=Malta VAT,[9940]=Monaco VAT,[9941]=Montenegro VAT,[0106]=Netherlands KvK,[0190]=Netherlands OIN,[9944]=Netherlands VAT,[0192]=Norway Org.nr.,[9945]=Poland VAT,[9946]=Portugal VAT,[9947]=Romania VAT,[9948]=Serbia VAT,[0195]=Singapore UEN,[9949]=Slovenia VAT,[9950]=Slovakia VAT,[9920]=Spain VAT,[0007]=Sweden Org.nr.,[9955]=Sweden VAT,[9927]=Swiss VAT,[0183]=Swiss UIDB,[9952]=Turkey VAT,[9932]=United Kingdom VAT,[9959]=USA EIN,[0060]=DUNS Number,[0088]=EAN Location Code,[0130]=Directorates of the European Commission,[0135]=SIA Object Identifiers,[0142]=SECETI Object Identifiers,[0193]=UBL.BE party identifier,[0199]=Legal Entity Identifier (LEI),[0201]=Codice Univoco Unità Organizzativa iPA,[0202]=Indirizzo di Posta Elettronica Certificata,[0209]=GS1 identification keys,[0210]=Codice Fiscale,[9913]=Business Registers Network,[9918]=S.W.I.F.T,[9919]=Kennziffer des Unternehmensregisters,[9951]=San Marino VAT,[9953]=Vatican VAT</para>
        /// </summary>
        [JsonPropertyName("peppol_eas")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("peppol_eas")]
        public string PeppolEas { get; set; }

        /// <summary>
        /// <para>Name: Intra-Community Valid</para>
        /// <para>Internal: vies_valid</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("vies_valid")]
        [OdooField("vies_valid")]
        public bool ViesValid { get; set; }

        /// <summary>
        /// <para>Name: Perform Vies Validation</para>
        /// <para>Internal: perform_vies_validation</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("perform_vies_validation")]
        [OdooField("perform_vies_validation")]
        public bool PerformViesValidation { get; set; }

        /// <summary>
        /// <para>Name: Vies Vat To Check</para>
        /// <para>Internal: vies_vat_to_check</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("vies_vat_to_check")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("vies_vat_to_check")]
        public string ViesVatToCheck { get; set; }

        /// <summary>
        /// <para>Name: Supplier Currency</para>
        /// <para>Internal: property_purchase_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("property_purchase_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_purchase_currency_id")]
        public int? PropertyPurchaseCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order Count</para>
        /// <para>Internal: purchase_order_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("purchase_order_count")]
        [OdooField("purchase_order_count")]
        public int PurchaseOrderCount { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order Warning</para>
        /// <para>Internal: purchase_warn</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no-message]=No Message,[warning]=Warning,[block]=Blocking Message</para>
        /// </summary>
        [JsonPropertyName("purchase_warn")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("purchase_warn")]
        public string PurchaseWarn { get; set; }

        /// <summary>
        /// <para>Name: Message for Purchase Order</para>
        /// <para>Internal: purchase_warn_msg</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("purchase_warn_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("purchase_warn_msg")]
        public string PurchaseWarnMsg { get; set; }

        /// <summary>
        /// <para>Name: Receipt Reminder</para>
        /// <para>Internal: receipt_reminder_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("receipt_reminder_email")]
        [OdooField("receipt_reminder_email")]
        public bool ReceiptReminderEmail { get; set; }

        /// <summary>
        /// <para>Name: Days Before Receipt</para>
        /// <para>Internal: reminder_date_before_receipt</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("reminder_date_before_receipt")]
        [OdooField("reminder_date_before_receipt")]
        public int ReminderDateBeforeReceipt { get; set; }

        /// <summary>
        /// <para>Name: Buyer</para>
        /// <para>Internal: buyer_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("buyer_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("buyer_id")]
        public int? BuyerId { get; set; }

        /// <summary>
        /// <para>Name: Website Partner Full Description</para>
        /// <para>Internal: website_description</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("website_description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_description")]
        public string WebsiteDescription { get; set; }

        /// <summary>
        /// <para>Name: Website Partner Short Description</para>
        /// <para>Internal: website_short_description</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("website_short_description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website_short_description")]
        public string WebsiteShortDescription { get; set; }

        /// <summary>
        /// <para>Name: Online Partner Information</para>
        /// <para>Internal: online_partner_information</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("online_partner_information")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("online_partner_information")]
        public string OnlinePartnerInformation { get; set; }

        /// <summary>
        /// <para>Name: Available Peppol Sending Methods</para>
        /// <para>Internal: available_peppol_sending_methods</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("available_peppol_sending_methods")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("available_peppol_sending_methods")]
        public object AvailablePeppolSendingMethods { get; set; }

        /// <summary>
        /// <para>Name: Available Peppol Edi Formats</para>
        /// <para>Internal: available_peppol_edi_formats</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("available_peppol_edi_formats")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("available_peppol_edi_formats")]
        public object AvailablePeppolEdiFormats { get; set; }

        /// <summary>
        /// <para>Name: Peppol endpoint verification</para>
        /// <para>Internal: peppol_verification_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_verified]=Not verified yet,[not_valid]=Not on Peppol,[not_valid_format]=Cannot receive this format,[valid]=Valid</para>
        /// </summary>
        [JsonPropertyName("peppol_verification_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("peppol_verification_state")]
        public string PeppolVerificationState { get; set; }

        /// <summary>
        /// <para>Name: Account Represented Company</para>
        /// <para>Internal: account_represented_company_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("account_represented_company_ids")]
        [OdooField("account_represented_company_ids")]
        public List<int> AccountRepresentedCompanyIds { get; set; }

        /// <summary>
        /// <para>Name: Sale Order Count</para>
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
        /// <para>Name: Sales Order</para>
        /// <para>Internal: sale_order_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: sale.order</para>
        /// </summary>
        [JsonPropertyName("sale_order_ids")]
        [OdooField("sale_order_ids")]
        public List<int> SaleOrderIds { get; set; }

        /// <summary>
        /// <para>Name: Sales Warnings</para>
        /// <para>Internal: sale_warn</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no-message]=No Message,[warning]=Warning,[block]=Blocking Message</para>
        /// </summary>
        [JsonPropertyName("sale_warn")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sale_warn")]
        public string SaleWarn { get; set; }

        /// <summary>
        /// <para>Name: Message for Sales Order</para>
        /// <para>Internal: sale_warn_msg</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("sale_warn_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sale_warn_msg")]
        public string SaleWarnMsg { get; set; }

        /// <summary>
        /// <para>Name: Next reminder</para>
        /// <para>Internal: followup_next_action_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("followup_next_action_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("followup_next_action_date")]
        public DateTime? FollowupNextActionDate { get; set; }

        /// <summary>
        /// <para>Name: Unreconciled Aml</para>
        /// <para>Internal: unreconciled_aml_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.move.line</para>
        /// </summary>
        [JsonPropertyName("unreconciled_aml_ids")]
        [OdooField("unreconciled_aml_ids")]
        public List<int> UnreconciledAmlIds { get; set; }

        /// <summary>
        /// <para>Name: Unpaid Invoice</para>
        /// <para>Internal: unpaid_invoice_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("unpaid_invoice_ids")]
        [OdooField("unpaid_invoice_ids")]
        public List<int> UnpaidInvoiceIds { get; set; }

        /// <summary>
        /// <para>Name: Unpaid Invoices Count</para>
        /// <para>Internal: unpaid_invoices_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("unpaid_invoices_count")]
        [OdooField("unpaid_invoices_count")]
        public int UnpaidInvoicesCount { get; set; }

        /// <summary>
        /// <para>Name: Total Due</para>
        /// <para>Internal: total_due</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("total_due")]
        [OdooField("total_due")]
        public decimal TotalDue { get; set; }

        /// <summary>
        /// <para>Name: Total Overdue</para>
        /// <para>Internal: total_overdue</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("total_overdue")]
        [OdooField("total_overdue")]
        public decimal TotalOverdue { get; set; }

        /// <summary>
        /// <para>Name: Follow-up Status</para>
        /// <para>Internal: followup_status</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [in_need_of_action]=In need of action,[with_overdue_invoices]=With overdue invoices,[no_action_needed]=No action needed</para>
        /// </summary>
        [JsonPropertyName("followup_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("followup_status")]
        public string FollowupStatus { get; set; }

        /// <summary>
        /// <para>Name: Follow-up Level</para>
        /// <para>Internal: followup_line_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account_followup.followup.line</para>
        /// </summary>
        [JsonPropertyName("followup_line_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("followup_line_id")]
        public int? FollowupLineId { get; set; }

        /// <summary>
        /// <para>Name: Reminders</para>
        /// <para>Internal: followup_reminder_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [automatic]=Automatic,[manual]=Manual</para>
        /// </summary>
        [JsonPropertyName("followup_reminder_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("followup_reminder_type")]
        public string FollowupReminderType { get; set; }

        /// <summary>
        /// <para>Name: Responsible</para>
        /// <para>Internal: followup_responsible_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("followup_responsible_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("followup_responsible_id")]
        public int? FollowupResponsibleId { get; set; }

        /// <summary>
        /// <para>Name: Delivery Method</para>
        /// <para>Internal: property_delivery_carrier_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: delivery.carrier</para>
        /// </summary>
        [JsonPropertyName("property_delivery_carrier_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_delivery_carrier_id")]
        public int? PropertyDeliveryCarrierId { get; set; }

        /// <summary>
        /// <para>Name: Is Pickup Location</para>
        /// <para>Internal: is_pickup_location</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_pickup_location")]
        [OdooField("is_pickup_location")]
        public bool IsPickupLocation { get; set; }

        /// <summary>
        /// <para>Name: DateV Vendor</para>
        /// <para>Internal: l10n_de_datev_identifier</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("l10n_de_datev_identifier")]
        [OdooField("l10n_de_datev_identifier")]
        public int L10nDeDatevIdentifier { get; set; }

        /// <summary>
        /// <para>Name: DateV Customer</para>
        /// <para>Internal: l10n_de_datev_identifier_customer</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("l10n_de_datev_identifier_customer")]
        [OdooField("l10n_de_datev_identifier_customer")]
        public int L10nDeDatevIdentifierCustomer { get; set; }

        /// <summary>
        /// <para>Name: L10N Din5008 Date</para>
        /// <para>Internal: l10n_din5008_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("l10n_din5008_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("l10n_din5008_date")]
        public DateTime? L10nDin5008Date { get; set; }

    }
}
