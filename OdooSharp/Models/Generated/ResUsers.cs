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
        public bool TourEnabled { get; set; }

        /// <summary>
        /// <para>Name: Notification</para>
        /// <para>Internal: notification_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("notification_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string ImStatus { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Calendar Default Privacy</para>
        /// <para>Internal: calendar_default_privacy</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("calendar_default_privacy")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int? NextRankId { get; set; }

        /// <summary>
        /// <para>Name: OdooBot Status</para>
        /// <para>Internal: odoobot_state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("odoobot_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string WorkLocationName { get; set; }

        /// <summary>
        /// <para>Name: Work Location Type</para>
        /// <para>Internal: work_location_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("work_location_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string PrivateEmail { get; set; }

        /// <summary>
        /// <para>Name: Employee Lang</para>
        /// <para>Internal: private_lang</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("private_lang")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int DistanceHomeWork { get; set; }

        /// <summary>
        /// <para>Name: Home-Work Distance unit</para>
        /// <para>Internal: distance_home_work_unit</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("distance_home_work_unit")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string PassportId { get; set; }

        /// <summary>
        /// <para>Name: Gender</para>
        /// <para>Internal: gender</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("gender")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int? CountryOfBirth { get; set; }

        /// <summary>
        /// <para>Name: Marital Status</para>
        /// <para>Internal: marital</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("marital")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string Pin { get; set; }

        /// <summary>
        /// <para>Name: Certificate Level</para>
        /// <para>Internal: certificate</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("certificate")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int EmployeeCount { get; set; }

        /// <summary>
        /// <para>Name: Hr Presence State</para>
        /// <para>Internal: hr_presence_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("hr_presence_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string LastActivityTime { get; set; }

        /// <summary>
        /// <para>Name: Employee Type</para>
        /// <para>Internal: employee_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public List<int> ActivityIds { get; set; }

        /// <summary>
        /// <para>Name: Activity State</para>
        /// <para>Internal: activity_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("activity_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string ActivitySummary { get; set; }

        /// <summary>
        /// <para>Name: Activity Exception Decoration</para>
        /// <para>Internal: activity_exception_decoration</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("activity_exception_decoration")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string Ref { get; set; }

        /// <summary>
        /// <para>Name: Language</para>
        /// <para>Internal: lang</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("lang")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int ActiveLangCount { get; set; }

        /// <summary>
        /// <para>Name: Timezone</para>
        /// <para>Internal: tz</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("tz")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string Function { get; set; }

        /// <summary>
        /// <para>Name: Address Type</para>
        /// <para>Internal: type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int? IndustryId { get; set; }

        /// <summary>
        /// <para>Name: Company Type</para>
        /// <para>Internal: company_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("company_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int BankAccountCount { get; set; }

        /// <summary>
        /// <para>Name: Degree of trust you have in this debtor</para>
        /// <para>Internal: trust</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("trust")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public bool IgnoreAbnormalInvoiceAmount { get; set; }

        /// <summary>
        /// <para>Name: Invoice</para>
        /// <para>Internal: invoice_warn</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("invoice_warn")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string InvoiceWarnMsg { get; set; }

        /// <summary>
        /// <para>Name: Invoice sending</para>
        /// <para>Internal: invoice_sending_method</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("invoice_sending_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string InvoiceSendingMethod { get; set; }

        /// <summary>
        /// <para>Name: eInvoice format</para>
        /// <para>Internal: invoice_edi_format</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("invoice_edi_format")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int CustomerRank { get; set; }

        /// <summary>
        /// <para>Name: Auto-post bills</para>
        /// <para>Internal: autopost_bills</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("autopost_bills")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public string PeppolEndpoint { get; set; }

        /// <summary>
        /// <para>Name: Peppol e-address (EAS)</para>
        /// <para>Internal: peppol_eas</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("peppol_eas")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int PurchaseOrderCount { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order Warning</para>
        /// <para>Internal: purchase_warn</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("purchase_warn")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public object AvailablePeppolEdiFormats { get; set; }

        /// <summary>
        /// <para>Name: Peppol endpoint verification</para>
        /// <para>Internal: peppol_verification_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("peppol_verification_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public List<int> SaleOrderIds { get; set; }

        /// <summary>
        /// <para>Name: Sales Warnings</para>
        /// <para>Internal: sale_warn</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("sale_warn")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public decimal TotalOverdue { get; set; }

        /// <summary>
        /// <para>Name: Follow-up Status</para>
        /// <para>Internal: followup_status</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("followup_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public int? FollowupLineId { get; set; }

        /// <summary>
        /// <para>Name: Reminders</para>
        /// <para>Internal: followup_reminder_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("followup_reminder_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
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
        public DateTime? L10nDin5008Date { get; set; }

    }
}
