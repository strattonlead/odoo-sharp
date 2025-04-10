using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("hr.employee.skill.report")]
    public partial class HrEmployeeSkillReport
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
        /// <para>Name: Employee</para>
        /// <para>Internal: employee_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Has Department Manager Access</para>
        /// <para>Internal: has_department_manager_access</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_department_manager_access")]
        [OdooField("has_department_manager_access")]
        public bool HasDepartmentManagerAccess { get; set; }

        /// <summary>
        /// <para>Name: Company</para>
        /// <para>Internal: company_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("company_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// <para>Name: Department</para>
        /// <para>Internal: department_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.department</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("department_id")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// <para>Name: Skill</para>
        /// <para>Internal: skill_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.skill</para>
        /// </summary>
        [JsonPropertyName("skill_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("skill_id")]
        public int? SkillId { get; set; }

        /// <summary>
        /// <para>Name: Skill Type</para>
        /// <para>Internal: skill_type_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: hr.skill.type</para>
        /// </summary>
        [JsonPropertyName("skill_type_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("skill_type_id")]
        public int? SkillTypeId { get; set; }

        /// <summary>
        /// <para>Name: Skill Level</para>
        /// <para>Internal: skill_level</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("skill_level")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("skill_level")]
        public string SkillLevel { get; set; }

        /// <summary>
        /// <para>Name: Level Progress</para>
        /// <para>Internal: level_progress</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("level_progress")]
        [OdooField("level_progress")]
        public double LevelProgress { get; set; }

        /// <summary>
        /// <para>Name: Active</para>
        /// <para>Internal: active</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("active")]
        [OdooField("active")]
        public bool Active { get; set; }

    }
}
