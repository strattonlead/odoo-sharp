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
        [OdooField("department_id")]
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
        [OdooField("member_of_department")]
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
        [OdooField("job_id")]
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
        [OdooField("job_title")]
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
        [OdooField("company_id")]
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
        [OdooField("address_id")]
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
        [OdooField("work_phone")]
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
        [OdooField("phone")]
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
        [OdooField("mobile_phone")]
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
        [OdooField("work_email")]
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
        [OdooField("email")]
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
        [OdooField("work_contact_id")]
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
        [OdooField("user_id")]
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
        [OdooField("share")]
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
        [OdooField("resource_id")]
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
        [OdooField("resource_calendar_id")]
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
        [OdooField("is_flexible")]
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
        [OdooField("is_fully_flexible")]
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
        [OdooField("parent_id")]
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
        [OdooField("coach_id")]
        public int? CoachId { get; set; }

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
        /// <para>Name: Hr Icon Display</para>
        /// <para>Internal: hr_icon_display</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [presence_present]=Present,[presence_out_of_working_hour]=Out of Working hours,[presence_absent]=Absent,[presence_archive]=Archived,[presence_undetermined]=Undetermined</para>
        /// </summary>
        [JsonPropertyName("hr_icon_display")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("hr_icon_display")]
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
        [OdooField("show_hr_icon_display")]
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
        [OdooField("im_status")]
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
        [OdooField("newly_hired")]
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
        [OdooField("goal_ids")]
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
        [OdooField("badge_ids")]
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
        [OdooField("has_badges")]
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
        [OdooField("direct_badge_ids")]
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
        [OdooField("child_all_count")]
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
        [OdooField("department_color")]
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
        [OdooField("child_count")]
        public int ChildCount { get; set; }

    }
}
