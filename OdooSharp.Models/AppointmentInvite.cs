using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("appointment.invite")]
    public partial class AppointmentInvite
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Token</para>
        /// <para>Internal: access_token</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("access_token")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>Name: Short Code</para>
        /// <para>Internal: short_code</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("short_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("short_code")]
        public string ShortCode { get; set; }

        /// <summary>
        /// <para>Name: Short Code Format Warning</para>
        /// <para>Internal: short_code_format_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("short_code_format_warning")]
        [OdooField("short_code_format_warning")]
        public bool ShortCodeFormatWarning { get; set; }

        /// <summary>
        /// <para>Name: Short Code Unique Warning</para>
        /// <para>Internal: short_code_unique_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("short_code_unique_warning")]
        [OdooField("short_code_unique_warning")]
        public bool ShortCodeUniqueWarning { get; set; }

        /// <summary>
        /// <para>Name: Computes if alert is present</para>
        /// <para>Internal: disable_save_button</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("disable_save_button")]
        [OdooField("disable_save_button")]
        public bool DisableSaveButton { get; set; }

        /// <summary>
        /// <para>Name: Has Identical Config</para>
        /// <para>Internal: has_identical_config</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_identical_config")]
        [OdooField("has_identical_config")]
        public bool HasIdenticalConfig { get; set; }

        /// <summary>
        /// <para>Name: Base Link URL</para>
        /// <para>Internal: base_book_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("base_book_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("base_book_url")]
        public string BaseBookUrl { get; set; }

        /// <summary>
        /// <para>Name: Link URL</para>
        /// <para>Internal: book_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("book_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("book_url")]
        public string BookUrl { get; set; }

        /// <summary>
        /// <para>Name: Redirect URL</para>
        /// <para>Internal: redirect_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("redirect_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// <para>Name: Appointment Types</para>
        /// <para>Internal: appointment_type_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: appointment.type</para>
        /// </summary>
        [JsonPropertyName("appointment_type_ids")]
        [OdooField("appointment_type_ids")]
        public List<int> AppointmentTypeIds { get; set; }

        /// <summary>
        /// <para>Name: No User Assigned Message</para>
        /// <para>Internal: appointment_type_info_msg</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("appointment_type_info_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("appointment_type_info_msg")]
        public string AppointmentTypeInfoMsg { get; set; }

        /// <summary>
        /// <para>Name: Selected Appointments Count</para>
        /// <para>Internal: appointment_type_count</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("appointment_type_count")]
        [OdooField("appointment_type_count")]
        public int AppointmentTypeCount { get; set; }

        /// <summary>
        /// <para>Name: Schedule Based On</para>
        /// <para>Internal: schedule_based_on</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("schedule_based_on")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("schedule_based_on")]
        public string ScheduleBasedOn { get; set; }

        /// <summary>
        /// <para>Name: Possible resources</para>
        /// <para>Internal: suggested_resource_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: appointment.resource</para>
        /// </summary>
        [JsonPropertyName("suggested_resource_ids")]
        [OdooField("suggested_resource_ids")]
        public List<int> SuggestedResourceIds { get; set; }

        /// <summary>
        /// <para>Name: # Resources</para>
        /// <para>Internal: suggested_resource_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("suggested_resource_count")]
        [OdooField("suggested_resource_count")]
        public int SuggestedResourceCount { get; set; }

        /// <summary>
        /// <para>Name: Possible users</para>
        /// <para>Internal: suggested_staff_user_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("suggested_staff_user_ids")]
        [OdooField("suggested_staff_user_ids")]
        public List<int> SuggestedStaffUserIds { get; set; }

        /// <summary>
        /// <para>Name: # Staff Users</para>
        /// <para>Internal: suggested_staff_user_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("suggested_staff_user_count")]
        [OdooField("suggested_staff_user_count")]
        public int SuggestedStaffUserCount { get; set; }

        /// <summary>
        /// <para>Name: Assign to</para>
        /// <para>Internal: resources_choice</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [current_user]=Me,[all_assigned_resources]=Any User,[specific_resources]=Specific Users</para>
        /// </summary>
        [JsonPropertyName("resources_choice")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("resources_choice")]
        public string ResourcesChoice { get; set; }

        /// <summary>
        /// <para>Name: Resources Resource Choice</para>
        /// <para>Internal: resources_resource_choice</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [all_assigned_resources]=Any Resource,[specific_resources]=Specific Resources</para>
        /// </summary>
        [JsonPropertyName("resources_resource_choice")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("resources_resource_choice")]
        public string ResourcesResourceChoice { get; set; }

        /// <summary>
        /// <para>Name: Resources</para>
        /// <para>Internal: resource_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: appointment.resource</para>
        /// </summary>
        [JsonPropertyName("resource_ids")]
        [OdooField("resource_ids")]
        public List<int> ResourceIds { get; set; }

        /// <summary>
        /// <para>Name: Users</para>
        /// <para>Internal: staff_user_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("staff_user_ids")]
        [OdooField("staff_user_ids")]
        public List<int> StaffUserIds { get; set; }

        /// <summary>
        /// <para>Name: Booked Appointments</para>
        /// <para>Internal: calendar_event_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: calendar.event</para>
        /// </summary>
        [JsonPropertyName("calendar_event_ids")]
        [OdooField("calendar_event_ids")]
        public List<int> CalendarEventIds { get; set; }

        /// <summary>
        /// <para>Name: # Bookings</para>
        /// <para>Internal: calendar_event_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("calendar_event_count")]
        [OdooField("calendar_event_count")]
        public int CalendarEventCount { get; set; }

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
        /// <para>Name: Opportunity/Lead</para>
        /// <para>Internal: opportunity_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: crm.lead</para>
        /// </summary>
        [JsonPropertyName("opportunity_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("opportunity_id")]
        public int? OpportunityId { get; set; }

        /// <summary>
        /// <para>Name: Different Website Message</para>
        /// <para>Internal: appointment_type_warning_msg</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("appointment_type_warning_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("appointment_type_warning_msg")]
        public string AppointmentTypeWarningMsg { get; set; }

    }
}
