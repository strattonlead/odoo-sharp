using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("hr.employee.base")]
    public partial class HrEmployeeBase
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
        /// <para>Name: Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Name { get; set; }

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
        /// <para>Name: Color Index</para>
        /// <para>Internal: color</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("color")]
        public int Color { get; set; }

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
        public int? DepartmentId { get; set; }

        /// <summary>
        /// <para>Name: Member of department</para>
        /// <para>Internal: member_of_department</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("member_of_department")]
        public bool MemberOfDepartment { get; set; }

        /// <summary>
        /// <para>Name: Job Position</para>
        /// <para>Internal: job_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.job</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? JobId { get; set; }

        /// <summary>
        /// <para>Name: Job Title</para>
        /// <para>Internal: job_title</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string JobTitle { get; set; }

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
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Work Address</para>
        /// <para>Internal: address_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Work Phone</para>
        /// <para>Internal: work_phone</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("work_phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string WorkPhone { get; set; }

        /// <summary>
        /// <para>Name: Phone</para>
        /// <para>Internal: phone</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("phone")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Phone { get; set; }

        /// <summary>
        /// <para>Name: Work Mobile</para>
        /// <para>Internal: mobile_phone</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("work_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string WorkEmail { get; set; }

        /// <summary>
        /// <para>Name: Email</para>
        /// <para>Internal: email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Email { get; set; }

        /// <summary>
        /// <para>Name: Work Contact</para>
        /// <para>Internal: work_contact_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: User</para>
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
        public int? UserId { get; set; }

        /// <summary>
        /// <para>Name: Share User</para>
        /// <para>Internal: share</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("share")]
        public bool Share { get; set; }

        /// <summary>
        /// <para>Name: Resource</para>
        /// <para>Internal: resource_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: resource.resource</para>
        /// </summary>
        [JsonPropertyName("resource_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ResourceId { get; set; }

        /// <summary>
        /// <para>Name: Resource Calendar</para>
        /// <para>Internal: resource_calendar_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Is Flexible</para>
        /// <para>Internal: is_flexible</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_flexible")]
        public bool IsFlexible { get; set; }

        /// <summary>
        /// <para>Name: Is Fully Flexible</para>
        /// <para>Internal: is_fully_flexible</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_fully_flexible")]
        public bool IsFullyFlexible { get; set; }

        /// <summary>
        /// <para>Name: Manager</para>
        /// <para>Internal: parent_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.employee</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ParentId { get; set; }

        /// <summary>
        /// <para>Name: Coach</para>
        /// <para>Internal: coach_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Hr Icon Display</para>
        /// <para>Internal: hr_icon_display</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("hr_icon_display")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string HrIconDisplay { get; set; }

        /// <summary>
        /// <para>Name: Show Hr Icon Display</para>
        /// <para>Internal: show_hr_icon_display</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_hr_icon_display")]
        public bool ShowHrIconDisplay { get; set; }

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
        /// <para>Name: Newly Hired</para>
        /// <para>Internal: newly_hired</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("newly_hired")]
        public bool NewlyHired { get; set; }

        /// <summary>
        /// <para>Name: Employee HR Goals</para>
        /// <para>Internal: goal_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: gamification.goal</para>
        /// </summary>
        [JsonPropertyName("goal_ids")]
        public List<int> GoalIds { get; set; }

        /// <summary>
        /// <para>Name: Employee Badges</para>
        /// <para>Internal: badge_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: gamification.badge.user</para>
        /// </summary>
        [JsonPropertyName("badge_ids")]
        public List<int> BadgeIds { get; set; }

        /// <summary>
        /// <para>Name: Has Badges</para>
        /// <para>Internal: has_badges</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_badges")]
        public bool HasBadges { get; set; }

        /// <summary>
        /// <para>Name: Direct Badge</para>
        /// <para>Internal: direct_badge_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: gamification.badge.user</para>
        /// </summary>
        [JsonPropertyName("direct_badge_ids")]
        public List<int> DirectBadgeIds { get; set; }

        /// <summary>
        /// <para>Name: Indirect Subordinates Count</para>
        /// <para>Internal: child_all_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("child_all_count")]
        public int ChildAllCount { get; set; }

        /// <summary>
        /// <para>Name: Department Color</para>
        /// <para>Internal: department_color</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("department_color")]
        public int DepartmentColor { get; set; }

        /// <summary>
        /// <para>Name: Direct Subordinates Count</para>
        /// <para>Internal: child_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("child_count")]
        public int ChildCount { get; set; }

    }
}
