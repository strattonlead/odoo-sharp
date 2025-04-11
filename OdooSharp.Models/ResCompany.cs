using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("res.company")]
    public partial class ResCompany
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Company Name</para>
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
        /// <para>Name: Sequence</para>
        /// <para>Internal: sequence</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sequence")]
        [OdooField("sequence")]
        public int Sequence { get; set; }

        /// <summary>
        /// <para>Name: Parent Company</para>
        /// <para>Internal: parent_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("parent_id")]
        public int? ParentId { get; set; }

        /// <summary>
        /// <para>Name: Branches</para>
        /// <para>Internal: child_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("child_ids")]
        [OdooField("child_ids")]
        public List<int> ChildIds { get; set; }

        /// <summary>
        /// <para>Name: All Child</para>
        /// <para>Internal: all_child_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("all_child_ids")]
        [OdooField("all_child_ids")]
        public List<int> AllChildIds { get; set; }

        /// <summary>
        /// <para>Name: Parent Path</para>
        /// <para>Internal: parent_path</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("parent_path")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("parent_path")]
        public string ParentPath { get; set; }

        /// <summary>
        /// <para>Name: Parent</para>
        /// <para>Internal: parent_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("parent_ids")]
        [OdooField("parent_ids")]
        public List<int> ParentIds { get; set; }

        /// <summary>
        /// <para>Name: Root</para>
        /// <para>Internal: root_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.company</para>
        /// </summary>
        [JsonPropertyName("root_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("root_id")]
        public int? RootId { get; set; }

        /// <summary>
        /// <para>Name: Partner</para>
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
        /// <para>Name: Company Tagline</para>
        /// <para>Internal: report_header</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("report_header")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("report_header")]
        public string ReportHeader { get; set; }

        /// <summary>
        /// <para>Name: Report Footer</para>
        /// <para>Internal: report_footer</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Company Details</para>
        /// <para>Internal: company_details</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("company_details")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_details")]
        public string CompanyDetails { get; set; }

        /// <summary>
        /// <para>Name: Is Company Details Empty</para>
        /// <para>Internal: is_company_details_empty</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_company_details_empty")]
        [OdooField("is_company_details_empty")]
        public bool IsCompanyDetailsEmpty { get; set; }

        /// <summary>
        /// <para>Name: Company Logo</para>
        /// <para>Internal: logo</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("logo")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("logo")]
        public byte[] Logo { get; set; }

        /// <summary>
        /// <para>Name: Logo Web</para>
        /// <para>Internal: logo_web</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("logo_web")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("logo_web")]
        public byte[] LogoWeb { get; set; }

        /// <summary>
        /// <para>Name: Uses Default Logo</para>
        /// <para>Internal: uses_default_logo</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("uses_default_logo")]
        [OdooField("uses_default_logo")]
        public bool UsesDefaultLogo { get; set; }

        /// <summary>
        /// <para>Name: Currency</para>
        /// <para>Internal: currency_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Accepted Users</para>
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
        /// <para>Name: Fed. State</para>
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
        /// <para>Name: Email</para>
        /// <para>Internal: email</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Paper format</para>
        /// <para>Internal: paperformat_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: report.paperformat</para>
        /// </summary>
        [JsonPropertyName("paperformat_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("paperformat_id")]
        public int? PaperformatId { get; set; }

        /// <summary>
        /// <para>Name: Document Template</para>
        /// <para>Internal: external_report_layout_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("external_report_layout_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("external_report_layout_id")]
        public int? ExternalReportLayoutId { get; set; }

        /// <summary>
        /// <para>Name: Font</para>
        /// <para>Internal: font</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [Lato]=Lato,[Roboto]=Roboto,[Open_Sans]=Open Sans,[Montserrat]=Montserrat,[Oswald]=Oswald,[Raleway]=Raleway,[Tajawal]=Tajawal,[Fira_Mono]=Fira Mono</para>
        /// </summary>
        [JsonPropertyName("font")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("font")]
        public string Font { get; set; }

        /// <summary>
        /// <para>Name: Primary Color</para>
        /// <para>Internal: primary_color</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("primary_color")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("primary_color")]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// <para>Name: Secondary Color</para>
        /// <para>Internal: secondary_color</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("secondary_color")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("secondary_color")]
        public string SecondaryColor { get; set; }

        /// <summary>
        /// <para>Name: Color</para>
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
        /// <para>Name: Layout Background</para>
        /// <para>Internal: layout_background</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [Blank]=Blank,[Demo logo]=Demo logo,[Custom]=Custom</para>
        /// </summary>
        [JsonPropertyName("layout_background")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("layout_background")]
        public string LayoutBackground { get; set; }

        /// <summary>
        /// <para>Name: Background Image</para>
        /// <para>Internal: layout_background_image</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("layout_background_image")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("layout_background_image")]
        public byte[] LayoutBackgroundImage { get; set; }

        /// <summary>
        /// <para>Name: Uninstalled L10N Module</para>
        /// <para>Internal: uninstalled_l10n_module_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: ir.module.module</para>
        /// </summary>
        [JsonPropertyName("uninstalled_l10n_module_ids")]
        [OdooField("uninstalled_l10n_module_ids")]
        public List<int> UninstalledL10nModuleIds { get; set; }

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
        [OdooField("social_twitter")]
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
        [OdooField("social_facebook")]
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
        [OdooField("social_github")]
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
        [OdooField("social_linkedin")]
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
        [OdooField("social_youtube")]
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
        [OdooField("social_instagram")]
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
        [OdooField("social_tiktok")]
        public string SocialTiktok { get; set; }

        /// <summary>
        /// <para>Name: Nomenclature</para>
        /// <para>Internal: nomenclature_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: barcode.nomenclature</para>
        /// </summary>
        [JsonPropertyName("nomenclature_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("nomenclature_id")]
        public int? NomenclatureId { get; set; }

        /// <summary>
        /// <para>Name: Working Hours</para>
        /// <para>Internal: resource_calendar_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: resource.calendar</para>
        /// </summary>
        [JsonPropertyName("resource_calendar_ids")]
        [OdooField("resource_calendar_ids")]
        public List<int> ResourceCalendarIds { get; set; }

        /// <summary>
        /// <para>Name: Default Working Hours</para>
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
        /// <para>Name: Email Domain</para>
        /// <para>Internal: alias_domain_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Bounce Email</para>
        /// <para>Internal: bounce_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("bounce_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("bounce_email")]
        public string BounceEmail { get; set; }

        /// <summary>
        /// <para>Name: Bounce</para>
        /// <para>Internal: bounce_formatted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("bounce_formatted")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("bounce_formatted")]
        public string BounceFormatted { get; set; }

        /// <summary>
        /// <para>Name: Catchall Email</para>
        /// <para>Internal: catchall_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("catchall_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("catchall_email")]
        public string CatchallEmail { get; set; }

        /// <summary>
        /// <para>Name: Catchall</para>
        /// <para>Internal: catchall_formatted</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("catchall_formatted")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("catchall_formatted")]
        public string CatchallFormatted { get; set; }

        /// <summary>
        /// <para>Name: Default From</para>
        /// <para>Internal: default_from_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("default_from_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("default_from_email")]
        public string DefaultFromEmail { get; set; }

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
        /// <para>Name: Email Header Color</para>
        /// <para>Internal: email_primary_color</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Company database ID</para>
        /// <para>Internal: partner_gid</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("partner_gid")]
        [OdooField("partner_gid")]
        public int PartnerGid { get; set; }

        /// <summary>
        /// <para>Name: Enrich Done</para>
        /// <para>Internal: iap_enrich_auto_done</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("iap_enrich_auto_done")]
        [OdooField("iap_enrich_auto_done")]
        public bool IapEnrichAutoDone { get; set; }

        /// <summary>
        /// <para>Name: Snailmail Color</para>
        /// <para>Internal: snailmail_color</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("snailmail_cover")]
        [OdooField("snailmail_cover")]
        public bool SnailmailCover { get; set; }

        /// <summary>
        /// <para>Name: Both sides</para>
        /// <para>Internal: snailmail_duplex</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("snailmail_duplex")]
        [OdooField("snailmail_duplex")]
        public bool SnailmailDuplex { get; set; }

        /// <summary>
        /// <para>Name: Selected onboarding payment method</para>
        /// <para>Internal: payment_onboarding_payment_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [paypal]=PayPal,[stripe]=Stripe,[manual]=Manual,[other]=Other</para>
        /// </summary>
        [JsonPropertyName("payment_onboarding_payment_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("payment_onboarding_payment_method")]
        public string PaymentOnboardingPaymentMethod { get; set; }

        /// <summary>
        /// <para>Name: Sign Default Terms and Conditions</para>
        /// <para>Internal: sign_terms</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Sign Terms & Conditions format</para>
        /// <para>Internal: sign_terms_type</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Sign Default Terms and Conditions as a Web page</para>
        /// <para>Internal: sign_terms_html</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Signing Certificate</para>
        /// <para>Internal: signing_certificate_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Fiscalyear Last Day</para>
        /// <para>Internal: fiscalyear_last_day</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Global Lock Date</para>
        /// <para>Internal: fiscalyear_lock_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("fiscalyear_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("fiscalyear_lock_date")]
        public DateTime? FiscalyearLockDate { get; set; }

        /// <summary>
        /// <para>Name: Tax Return Lock Date</para>
        /// <para>Internal: tax_lock_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("tax_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("tax_lock_date")]
        public DateTime? TaxLockDate { get; set; }

        /// <summary>
        /// <para>Name: Sales Lock Date</para>
        /// <para>Internal: sale_lock_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("sale_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("sale_lock_date")]
        public DateTime? SaleLockDate { get; set; }

        /// <summary>
        /// <para>Name: Purchase Lock date</para>
        /// <para>Internal: purchase_lock_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("purchase_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("purchase_lock_date")]
        public DateTime? PurchaseLockDate { get; set; }

        /// <summary>
        /// <para>Name: Hard Lock Date</para>
        /// <para>Internal: hard_lock_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("hard_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("hard_lock_date")]
        public DateTime? HardLockDate { get; set; }

        /// <summary>
        /// <para>Name: User Fiscalyear Lock Date</para>
        /// <para>Internal: user_fiscalyear_lock_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("user_fiscalyear_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("user_fiscalyear_lock_date")]
        public DateTime? UserFiscalyearLockDate { get; set; }

        /// <summary>
        /// <para>Name: User Tax Lock Date</para>
        /// <para>Internal: user_tax_lock_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("user_tax_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("user_tax_lock_date")]
        public DateTime? UserTaxLockDate { get; set; }

        /// <summary>
        /// <para>Name: User Sale Lock Date</para>
        /// <para>Internal: user_sale_lock_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("user_sale_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("user_sale_lock_date")]
        public DateTime? UserSaleLockDate { get; set; }

        /// <summary>
        /// <para>Name: User Purchase Lock Date</para>
        /// <para>Internal: user_purchase_lock_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("user_purchase_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("user_purchase_lock_date")]
        public DateTime? UserPurchaseLockDate { get; set; }

        /// <summary>
        /// <para>Name: User Hard Lock Date</para>
        /// <para>Internal: user_hard_lock_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("user_hard_lock_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("user_hard_lock_date")]
        public DateTime? UserHardLockDate { get; set; }

        /// <summary>
        /// <para>Name: Inter-Banks Transfer Account</para>
        /// <para>Internal: transfer_account_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Expects a Chart of Accounts</para>
        /// <para>Internal: expects_chart_of_accounts</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("expects_chart_of_accounts")]
        [OdooField("expects_chart_of_accounts")]
        public bool ExpectsChartOfAccounts { get; set; }

        /// <summary>
        /// <para>Name: Chart Template</para>
        /// <para>Internal: chart_template</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [generic_coa]=Vereinigte Staaten von Amerika (Generisch),[ae]=🇦🇪 United Arab Emirates,[ar_base]=🇦🇷 Argentina - Generic Chart of Accounts Argentina Single Taxpayer / Basis,[ar_ex]=🇦🇷 Argentina - Argentine Generic Chart of Accounts for Exempt Individuals,[ar_ri]=🇦🇷 Argentina - Argentine Generic Chart of Accounts for Registered Accountants,[at]=🇦🇹 Austria,[au]=🇦🇺 Australia,[bd]=🇧🇩 Bangladesh,[be_comp]=🇧🇪 Belgium - Unternehmen,[be_asso]=🇧🇪 Belgium - Vereinigungen und Stiftungen,[bf]=🇧🇫 Burkina Faso - SYSCOHADA for Companies,[bf_syscebnl]=🇧🇫 Burkina Faso - SYSCEBNL for Associations,[bg]=🇧🇬 Bulgaria,[bh]=🇧🇭 Bahrain,[bj]=🇧🇯 Benin - SYSCOHADA for Companies,[bj_syscebnl]=🇧🇯 Benin - SYSCEBNL for Associations,[bo]=🇧🇴 Bolivia,[br]=🇧🇷 Brazil,[ca_2023]=🇨🇦 Canada,[cd]=🇨🇩 Congo (DRC) - SYSCOHADA for Companies,[cd_syscebnl]=🇨🇩 Congo (DRC) - SYSCEBNL for Associations,[cf]=🇨🇫 Central African Republic - SYSCOHADA for Companies,[cf_syscebnl]=🇨🇫 Central African Republic - SYSCEBNL for Associations,[cg]=🇨🇬 Congo (Republic) - SYSCOHADA for Companies,[cg_syscebnl]=🇨🇬 Congo (Republic) - SYSCEBNL for Associations,[ch]=🇨🇭 Switzerland,[ci]=🇨🇮 Côte d'Ivoire - SYSCOHADA for Companies,[ci_syscebnl]=🇨🇮 Côte d'Ivoire - SYSCEBNL for Associations,[cl]=🇨🇱 Chile,[cm]=🇨🇲 Cameroon - SYSCOHADA for Companies,[cm_syscebnl]=🇨🇲 Cameroon - SYSCEBNL for Associations,[cn]=🇨🇳 China,[cn_large_bis]=🇨🇳 China - Large Business,[co]=🇨🇴 Colombia,[cr]=🇨🇷 Costa Rica,[cy]=🇨🇾 Cyprus,[cz]=🇨🇿 Czech Republic,[de_skr03]=🇩🇪 Germany - German Chart of Accounts SKR03,[de_skr04]=🇩🇪 Germany - German chart of accounts SKR04,[dk]=🇩🇰 Denmark,[do]=🇩🇴 Dominican Republic,[dz]=🇩🇿 Algeria,[ec]=🇪🇨 Ecuador,[ee]=🇪🇪 Estonia,[eg]=🇪🇬 Egypt,[es_pymes]=🇪🇸 Spain - SMEs (2008),[es_assec]=🇪🇸 Spain - Non-profit entities (2008),[es_canary_assoc]=🇪🇸 Spain - Canary Islands - PGCE non-profit entities (2008),[es_canary_full]=🇪🇸 Spain - Canary Islands - Complete (2008),[es_canary_pymes]=🇪🇸 Spain - Canary Islands - SMEs (2008),[es_coop_full]=🇪🇸 Spain - Cooperatives - Complete (2008),[es_coop_pymes]=🇪🇸 Spain - Cooperatives - SMEs (2008),[es_full]=🇪🇸 Spain - Complete (2008),[et]=🇪🇹 Ethiopia,[fi]=🇫🇮 Finland,[fr]=🇫🇷 France,[mc]=🇲🇨 Monaco,[ga]=🇬🇦 Gabon - SYSCOHADA for Companies,[ga_syscebnl]=🇬🇦 Gabon - SYSCEBNL for Associations,[gn]=🇬🇳 Guinea - SYSCOHADA for Companies,[gn_syscebnl]=🇬🇳 Guinea - SYSCEBNL for Associations,[gq]=🇬🇶 Equatorial Guinea - SYSCOHADA for Companies,[gq_syscebnl]=🇬🇶 Equatorial Guinea - SYSCEBNL for Associations,[gr]=🇬🇷 Greece,[gt]=🇬🇹 Guatemala,[gw]=🇬🇼 Guinea-Bissau - SYSCOHADA for Companies,[gw_syscebnl]=🇬🇼 Guinea-Bissau - SYSCEBNL for Associations,[hk]=🇭🇰 Hong Kong,[hn]=🇭🇳 Honduras,[hr]=🇭🇷 Croatia,[hr_kuna]=🇭🇷 Croatia - RRIF-ov računski plan za poduzetnike,[hu]=🇭🇺 Hungary,[id]=🇮🇩 Indonesia,[ie]=🇮🇪 Ireland,[il]=🇮🇱 Israel,[in]=🇮🇳 India,[iq]=🇮🇶 Iraq,[it]=🇮🇹 Italy,[jo_standard]=🇯🇴 Jordan,[jp]=🇯🇵 Japan,[ke]=🇰🇪 Kenya,[km]=🇰🇲 Comoros - SYSCOHADA for Companies,[km_syscebnl]=🇰🇲 Comoros - SYSCEBNL for Associations,[kr]=🇰🇷 South Korea,[kw]=🇰🇼 Kuwait,[kz]=🇰🇿 Kazakhstan,[lb]=🇱🇧 Lebanon,[lt]=🇱🇹 Lithuania,[lu]=🇱🇺 Luxembourg,[lv]=🇱🇻 Latvia,[ma]=🇲🇦 Morocco,[ml]=🇲🇱 Mali - SYSCOHADA for Companies,[ml_syscebnl]=🇲🇱 Mali - SYSCEBNL for Associations,[mn]=🇲🇳 Mongolia,[mt]=🇲🇹 Malta,[mu]=🇲🇺 Mauritius,[mx]=🇲🇽 Mexico,[my]=🇲🇾 Malaysia,[mz]=🇲🇿 Mozambique,[ne]=🇳🇪 Niger - SYSCOHADA for Companies,[ne_syscebnl]=🇳🇪 Niger - SYSCEBNL for Associations,[ng]=🇳🇬 Nigeria,[nl]=🇳🇱 Netherlands,[no]=🇳🇴 Norway,[nz]=🇳🇿 New Zealand,[pa]=🇵🇦 Panama,[pe]=🇵🇪 Peru,[ph]=🇵🇭 Philippines,[pk]=🇵🇰 Pakistan,[pl]=🇵🇱 Poland,[pt]=🇵🇹 Portugal,[qa]=🇶🇦 Qatar,[ro]=🇷🇴 Romania,[rs]=🇷🇸 Serbia,[rw]=🇷🇼 Rwanda,[sa]=🇸🇦 Saudi Arabia,[se]=🇸🇪 Sweden,[se_K2]=🇸🇪 Sweden - Swedish BAS Chart of Account complete K2,[se_K3]=🇸🇪 Sweden - Swedish BAS Chart of Account complete K3,[sg]=🇸🇬 Singapore,[si]=🇸🇮 Slovenia,[sk]=🇸🇰 Slovakia,[sn]=🇸🇳 Senegal - SYSCOHADA for Companies,[sn_syscebnl]=🇸🇳 Senegal - SYSCEBNL for Associations,[syscebnl]=SYSCEBNL,[syscohada]=SYSCOHADA - Revised,[td]=🇹🇩 Chad - SYSCOHADA for Companies,[td_syscebnl]=🇹🇩 Chad - SYSCEBNL for Associations,[tg]=🇹🇬 Togo - SYSCOHADA for Companies,[tg_syscebnl]=🇹🇬 Togo - SYSCEBNL for Associations,[th]=🇹🇭 Thailand,[tn]=🇹🇳 Tunisia,[tr]=🇹🇷 Türkiye,[tw]=🇹🇼 Taiwan,[tz]=🇹🇿 Tanzania,[ua_psbo]=🇺🇦 Ukraine - IFRS Chart of Accounts,[ug]=🇺🇬 Uganda - Uganda Generic Chart of Accounts,[uk]=🇬🇧 United Kingdom,[uy]=🇺🇾 Uruguay - Uruguayan Generic Chart of Accounts,[ve]=🇻🇪 Venezuela,[vn]=🇻🇳 Vietnam,[za]=🇿🇦 South Africa,[zm]=🇿🇲 Zambia</para>
        /// </summary>
        [JsonPropertyName("chart_template")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("chart_template")]
        public string ChartTemplate { get; set; }

        /// <summary>
        /// <para>Name: Prefix of the bank accounts</para>
        /// <para>Internal: bank_account_code_prefix</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("bank_account_code_prefix")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("bank_account_code_prefix")]
        public string BankAccountCodePrefix { get; set; }

        /// <summary>
        /// <para>Name: Prefix of the cash accounts</para>
        /// <para>Internal: cash_account_code_prefix</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("cash_account_code_prefix")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("cash_account_code_prefix")]
        public string CashAccountCodePrefix { get; set; }

        /// <summary>
        /// <para>Name: Cash Difference Income</para>
        /// <para>Internal: default_cash_difference_income_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("default_cash_difference_income_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("default_cash_difference_income_account_id")]
        public int? DefaultCashDifferenceIncomeAccountId { get; set; }

        /// <summary>
        /// <para>Name: Cash Difference Expense</para>
        /// <para>Internal: default_cash_difference_expense_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("default_cash_difference_expense_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("default_cash_difference_expense_account_id")]
        public int? DefaultCashDifferenceExpenseAccountId { get; set; }

        /// <summary>
        /// <para>Name: Journal Suspense Account</para>
        /// <para>Internal: account_journal_suspense_account_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Cash Discount Write-Off Gain Account</para>
        /// <para>Internal: account_journal_early_pay_discount_gain_account_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Cash Discount Write-Off Loss Account</para>
        /// <para>Internal: account_journal_early_pay_discount_loss_account_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Prefix of the transfer accounts</para>
        /// <para>Internal: transfer_account_code_prefix</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("transfer_account_code_prefix")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("transfer_account_code_prefix")]
        public string TransferAccountCodePrefix { get; set; }

        /// <summary>
        /// <para>Name: Default Sale Tax</para>
        /// <para>Internal: account_sale_tax_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("account_sale_tax_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_sale_tax_id")]
        public int? AccountSaleTaxId { get; set; }

        /// <summary>
        /// <para>Name: Default Purchase Tax</para>
        /// <para>Internal: account_purchase_tax_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("account_purchase_tax_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_purchase_tax_id")]
        public int? AccountPurchaseTaxId { get; set; }

        /// <summary>
        /// <para>Name: Tax Calculation Rounding Method</para>
        /// <para>Internal: tax_calculation_rounding_method</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Exchange Gain or Loss Journal</para>
        /// <para>Internal: currency_exchange_journal_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Use anglo-saxon accounting</para>
        /// <para>Internal: anglo_saxon_accounting</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("anglo_saxon_accounting")]
        [OdooField("anglo_saxon_accounting")]
        public bool AngloSaxonAccounting { get; set; }

        /// <summary>
        /// <para>Name: Bank Journals</para>
        /// <para>Internal: bank_journal_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("bank_journal_ids")]
        [OdooField("bank_journal_ids")]
        public List<int> BankJournalIds { get; set; }

        /// <summary>
        /// <para>Name: Default incoterm</para>
        /// <para>Internal: incoterm_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Display QR-code on invoices</para>
        /// <para>Internal: qr_code</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("qr_code")]
        [OdooField("qr_code")]
        public bool QrCode { get; set; }

        /// <summary>
        /// <para>Name: Total amount of invoice in letters</para>
        /// <para>Internal: display_invoice_amount_total_words</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("display_invoice_tax_company_currency")]
        [OdooField("display_invoice_tax_company_currency")]
        public bool DisplayInvoiceTaxCompanyCurrency { get; set; }

        /// <summary>
        /// <para>Name: Sales Credit Limit</para>
        /// <para>Internal: account_use_credit_limit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("account_use_credit_limit")]
        [OdooField("account_use_credit_limit")]
        public bool AccountUseCreditLimit { get; set; }

        /// <summary>
        /// <para>Name: Batch Payment Sequence</para>
        /// <para>Internal: batch_payment_sequence_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.sequence</para>
        /// </summary>
        [JsonPropertyName("batch_payment_sequence_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("batch_payment_sequence_id")]
        public int? BatchPaymentSequenceId { get; set; }

        /// <summary>
        /// <para>Name: Opening Journal Entry</para>
        /// <para>Internal: account_opening_move_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.move</para>
        /// </summary>
        [JsonPropertyName("account_opening_move_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_opening_move_id")]
        public int? AccountOpeningMoveId { get; set; }

        /// <summary>
        /// <para>Name: Opening Journal</para>
        /// <para>Internal: account_opening_journal_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("account_opening_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_opening_journal_id")]
        public int? AccountOpeningJournalId { get; set; }

        /// <summary>
        /// <para>Name: Opening Entry</para>
        /// <para>Internal: account_opening_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("account_opening_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("account_opening_date")]
        public DateTime? AccountOpeningDate { get; set; }

        /// <summary>
        /// <para>Name: Default Terms and Conditions</para>
        /// <para>Internal: invoice_terms</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Terms & Conditions format</para>
        /// <para>Internal: terms_type</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Default Terms and Conditions as a Web page</para>
        /// <para>Internal: invoice_terms_html</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Default PoS Receivable Account</para>
        /// <para>Internal: account_default_pos_receivable_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_default_pos_receivable_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_default_pos_receivable_account_id")]
        public int? AccountDefaultPosReceivableAccountId { get; set; }

        /// <summary>
        /// <para>Name: Expense Accrual Account</para>
        /// <para>Internal: expense_accrual_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("expense_accrual_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("expense_accrual_account_id")]
        public int? ExpenseAccrualAccountId { get; set; }

        /// <summary>
        /// <para>Name: Revenue Accrual Account</para>
        /// <para>Internal: revenue_accrual_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("revenue_accrual_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("revenue_accrual_account_id")]
        public int? RevenueAccrualAccountId { get; set; }

        /// <summary>
        /// <para>Name: Automatic Entry Default Journal</para>
        /// <para>Internal: automatic_entry_default_journal_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("automatic_entry_default_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("automatic_entry_default_journal_id")]
        public int? AutomaticEntryDefaultJournalId { get; set; }

        /// <summary>
        /// <para>Name: Fiscal Country</para>
        /// <para>Internal: account_fiscal_country_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: l10n-used countries</para>
        /// <para>Internal: account_enabled_tax_country_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("account_enabled_tax_country_ids")]
        [OdooField("account_enabled_tax_country_ids")]
        public List<int> AccountEnabledTaxCountryIds { get; set; }

        /// <summary>
        /// <para>Name: Use Cash Basis</para>
        /// <para>Internal: tax_exigibility</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("tax_exigibility")]
        [OdooField("tax_exigibility")]
        public bool TaxExigibility { get; set; }

        /// <summary>
        /// <para>Name: Cash Basis Journal</para>
        /// <para>Internal: tax_cash_basis_journal_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Storno accounting</para>
        /// <para>Internal: account_storno</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("account_storno")]
        [OdooField("account_storno")]
        public bool AccountStorno { get; set; }

        /// <summary>
        /// <para>Name: Fiscal Position</para>
        /// <para>Internal: fiscal_position_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.fiscal.position</para>
        /// </summary>
        [JsonPropertyName("fiscal_position_ids")]
        [OdooField("fiscal_position_ids")]
        public List<int> FiscalPositionIds { get; set; }

        /// <summary>
        /// <para>Name: Foreign VAT countries</para>
        /// <para>Internal: multi_vat_foreign_country_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("multi_vat_foreign_country_ids")]
        [OdooField("multi_vat_foreign_country_ids")]
        public List<int> MultiVatForeignCountryIds { get; set; }

        /// <summary>
        /// <para>Name: Quick encoding</para>
        /// <para>Internal: quick_edit_mode</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Separate account for income discount</para>
        /// <para>Internal: account_discount_income_allocation_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Separate account for expense discount</para>
        /// <para>Internal: account_discount_expense_allocation_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Audit Trail</para>
        /// <para>Internal: check_account_audit_trail</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("autopost_bills")]
        [OdooField("autopost_bills")]
        public bool AutopostBills { get; set; }

        /// <summary>
        /// <para>Name: Default Sales Price Include</para>
        /// <para>Internal: account_price_include</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Company Vat Placeholder</para>
        /// <para>Internal: company_vat_placeholder</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("company_vat_placeholder")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_vat_placeholder")]
        public string CompanyVatPlaceholder { get; set; }

        /// <summary>
        /// <para>Name: Income Account</para>
        /// <para>Internal: income_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("income_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("income_account_id")]
        public int? IncomeAccountId { get; set; }

        /// <summary>
        /// <para>Name: Expense Account</para>
        /// <para>Internal: expense_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("expense_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("expense_account_id")]
        public int? ExpenseAccountId { get; set; }

        /// <summary>
        /// <para>Name: # emails to send</para>
        /// <para>Internal: hr_presence_control_email_amount</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Employee Properties</para>
        /// <para>Internal: employee_properties_definition</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Unknown</para>
        /// </summary>
        [JsonPropertyName("employee_properties_definition")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("employee_properties_definition")]
        public object EmployeePropertiesDefinition { get; set; }

        /// <summary>
        /// <para>Name: Based on user status in system</para>
        /// <para>Internal: hr_presence_control_login</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Internal: hr_presence_control_attendance</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("hr_presence_control_attendance")]
        [OdooField("hr_presence_control_attendance")]
        public bool HrPresenceControlAttendance { get; set; }

        /// <summary>
        /// <para>Name: Website</para>
        /// <para>Internal: website_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website</para>
        /// </summary>
        [JsonPropertyName("website_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("website_id")]
        public int? WebsiteId { get; set; }

        /// <summary>
        /// <para>Name: Invoicing Switch Threshold</para>
        /// <para>Internal: invoicing_switch_threshold</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Predict Bill Product</para>
        /// <para>Internal: predict_bill_product</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("predict_bill_product")]
        [OdooField("predict_bill_product")]
        public bool PredictBillProduct { get; set; }

        /// <summary>
        /// <para>Name: Display signing field on invoices</para>
        /// <para>Internal: sign_invoice</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sign_invoice")]
        [OdooField("sign_invoice")]
        public bool SignInvoice { get; set; }

        /// <summary>
        /// <para>Name: Signing User</para>
        /// <para>Internal: signing_user</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Deferred Expense Journal</para>
        /// <para>Internal: deferred_expense_journal_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Account Edi Proxy Client</para>
        /// <para>Internal: account_edi_proxy_client_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account_edi_proxy_client.user</para>
        /// </summary>
        [JsonPropertyName("account_edi_proxy_client_ids")]
        [OdooField("account_edi_proxy_client_ids")]
        public List<int> AccountEdiProxyClientIds { get; set; }

        /// <summary>
        /// <para>Name: Verify VAT Numbers</para>
        /// <para>Internal: vat_check_vies</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
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
        /// <para>Name: Next Execution Date</para>
        /// <para>Internal: currency_next_execution_date</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Service Provider</para>
        /// <para>Internal: currency_provider</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Documents Hr Settings</para>
        /// <para>Internal: documents_hr_settings</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("documents_hr_settings")]
        [OdooField("documents_hr_settings")]
        public bool DocumentsHrSettings { get; set; }

        /// <summary>
        /// <para>Name: HR Folder</para>
        /// <para>Internal: documents_hr_folder</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: documents.document</para>
        /// </summary>
        [JsonPropertyName("documents_hr_folder")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("documents_hr_folder")]
        public int? DocumentsHrFolder { get; set; }

        /// <summary>
        /// <para>Name: Documents Product Settings</para>
        /// <para>Internal: documents_product_settings</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("documents_product_settings")]
        [OdooField("documents_product_settings")]
        public bool DocumentsProductSettings { get; set; }

        /// <summary>
        /// <para>Name: Product Folder</para>
        /// <para>Internal: product_folder_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: documents.document</para>
        /// </summary>
        [JsonPropertyName("product_folder_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("product_folder_id")]
        public int? ProductFolderId { get; set; }

        /// <summary>
        /// <para>Name: Product Tag</para>
        /// <para>Internal: product_tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: documents.tag</para>
        /// </summary>
        [JsonPropertyName("product_tag_ids")]
        [OdooField("product_tag_ids")]
        public List<int> ProductTagIds { get; set; }

        /// <summary>
        /// <para>Name: Purchase Lead Time</para>
        /// <para>Internal: po_lead</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("po_lead")]
        [OdooField("po_lead")]
        public double PoLead { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order Modification</para>
        /// <para>Internal: po_lock</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Levels of Approvals</para>
        /// <para>Internal: po_double_validation</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Double validation amount</para>
        /// <para>Internal: po_double_validation_amount</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("po_double_validation_amount")]
        [OdooField("po_double_validation_amount")]
        public decimal PoDoubleValidationAmount { get; set; }

        /// <summary>
        /// <para>Name: Home Menu Background Image</para>
        /// <para>Internal: background_image</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("background_image")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("background_image")]
        public byte[] BackgroundImage { get; set; }

        /// <summary>
        /// <para>Name: Primary contact email</para>
        /// <para>Internal: account_peppol_contact_email</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Migration Key</para>
        /// <para>Internal: account_peppol_migration_key</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
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
        /// <para>Name: Peppol Purchase Journal</para>
        /// <para>Internal: peppol_purchase_journal_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("peppol_purchase_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("peppol_purchase_journal_id")]
        public int? PeppolPurchaseJournalId { get; set; }

        /// <summary>
        /// <para>Name: Peppol External Provider</para>
        /// <para>Internal: peppol_external_provider</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("totals_below_sections")]
        [OdooField("totals_below_sections")]
        public bool TotalsBelowSections { get; set; }

        /// <summary>
        /// <para>Name: Delay units</para>
        /// <para>Internal: account_tax_periodicity</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Start from</para>
        /// <para>Internal: account_tax_periodicity_reminder_day</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Account Revaluation Journal</para>
        /// <para>Internal: account_revaluation_journal_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.journal</para>
        /// </summary>
        [JsonPropertyName("account_revaluation_journal_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_revaluation_journal_id")]
        public int? AccountRevaluationJournalId { get; set; }

        /// <summary>
        /// <para>Name: Expense Provision Account</para>
        /// <para>Internal: account_revaluation_expense_provision_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_revaluation_expense_provision_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_revaluation_expense_provision_account_id")]
        public int? AccountRevaluationExpenseProvisionAccountId { get; set; }

        /// <summary>
        /// <para>Name: Income Provision Account</para>
        /// <para>Internal: account_revaluation_income_provision_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("account_revaluation_income_provision_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_revaluation_income_provision_account_id")]
        public int? AccountRevaluationIncomeProvisionAccountId { get; set; }

        /// <summary>
        /// <para>Name: Tax Units</para>
        /// <para>Internal: account_tax_unit_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.tax.unit</para>
        /// </summary>
        [JsonPropertyName("account_tax_unit_ids")]
        [OdooField("account_tax_unit_ids")]
        public List<int> AccountTaxUnitIds { get; set; }

        /// <summary>
        /// <para>Name: Accounting Firm</para>
        /// <para>Internal: account_representative_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("account_representative_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_representative_id")]
        public int? AccountRepresentativeId { get; set; }

        /// <summary>
        /// <para>Name: Account Display Representative Field</para>
        /// <para>Internal: account_display_representative_field</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("account_display_representative_field")]
        [OdooField("account_display_representative_field")]
        public bool AccountDisplayRepresentativeField { get; set; }

        /// <summary>
        /// <para>Name: St.-Nr.</para>
        /// <para>Internal: l10n_de_stnr</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("l10n_de_stnr")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("l10n_de_stnr")]
        public string L10nDeStnr { get; set; }

        /// <summary>
        /// <para>Name: W-IdNr.</para>
        /// <para>Internal: l10n_de_widnr</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("l10n_de_widnr")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("l10n_de_widnr")]
        public string L10nDeWidnr { get; set; }

        /// <summary>
        /// <para>Name: Online Signature</para>
        /// <para>Internal: portal_confirmation_sign</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("prepayment_percent")]
        [OdooField("prepayment_percent")]
        public double PrepaymentPercent { get; set; }

        /// <summary>
        /// <para>Name: Default Quotation Validity</para>
        /// <para>Internal: quotation_validity_days</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("quotation_validity_days")]
        [OdooField("quotation_validity_days")]
        public int QuotationValidityDays { get; set; }

        /// <summary>
        /// <para>Name: Discount Product</para>
        /// <para>Internal: sale_discount_product_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.product</para>
        /// </summary>
        [JsonPropertyName("sale_discount_product_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sale_discount_product_id")]
        public int? SaleDiscountProductId { get; set; }

        /// <summary>
        /// <para>Name: Sale onboarding selected payment method</para>
        /// <para>Internal: sale_onboarding_payment_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [digital_signature]=Sign online,[paypal]=PayPal,[stripe]=Stripe,[other]=Pay with another payment provider,[manual]=Manual Payment</para>
        /// </summary>
        [JsonPropertyName("sale_onboarding_payment_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sale_onboarding_payment_method")]
        public string SaleOnboardingPaymentMethod { get; set; }

        /// <summary>
        /// <para>Name: Documents Account Settings</para>
        /// <para>Internal: documents_account_settings</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("documents_account_settings")]
        [OdooField("documents_account_settings")]
        public bool DocumentsAccountSettings { get; set; }

        /// <summary>
        /// <para>Name: Accounting Folder</para>
        /// <para>Internal: account_folder_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: documents.document</para>
        /// </summary>
        [JsonPropertyName("account_folder_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_folder_id")]
        public int? AccountFolderId { get; set; }

        /// <summary>
        /// <para>Name: Peppol Reception Mode</para>
        /// <para>Internal: peppol_reception_mode</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [journal]=Receive in Journal,[documents]=Receive in Documents</para>
        /// </summary>
        [JsonPropertyName("peppol_reception_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("peppol_reception_mode")]
        public string PeppolReceptionMode { get; set; }

        /// <summary>
        /// <para>Name: Document Workspace</para>
        /// <para>Internal: documents_account_peppol_folder_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: documents.document</para>
        /// </summary>
        [JsonPropertyName("documents_account_peppol_folder_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("documents_account_peppol_folder_id")]
        public int? DocumentsAccountPeppolFolderId { get; set; }

        /// <summary>
        /// <para>Name: Document Tags</para>
        /// <para>Internal: documents_account_peppol_tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: documents.tag</para>
        /// </summary>
        [JsonPropertyName("documents_account_peppol_tag_ids")]
        [OdooField("documents_account_peppol_tag_ids")]
        public List<int> DocumentsAccountPeppolTagIds { get; set; }

        /// <summary>
        /// <para>Name: L10N De Datev Consultant Number</para>
        /// <para>Internal: l10n_de_datev_consultant_number</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: yes</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("l10n_de_datev_consultant_number")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("l10n_de_datev_consultant_number")]
        public string L10nDeDatevConsultantNumber { get; set; }

        /// <summary>
        /// <para>Name: L10N De Datev Client Number</para>
        /// <para>Internal: l10n_de_datev_client_number</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: yes</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("l10n_de_datev_client_number")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("l10n_de_datev_client_number")]
        public string L10nDeDatevClientNumber { get; set; }

        /// <summary>
        /// <para>Name: DateV G/L account length</para>
        /// <para>Internal: l10n_de_datev_account_length</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("l10n_de_datev_account_length")]
        [OdooField("l10n_de_datev_account_length")]
        public int L10nDeDatevAccountLength { get; set; }

        /// <summary>
        /// <para>Name: Default Sale Template</para>
        /// <para>Internal: sale_order_template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: sale.order.template</para>
        /// </summary>
        [JsonPropertyName("sale_order_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("sale_order_template_id")]
        public int? SaleOrderTemplateId { get; set; }

        /// <summary>
        /// <para>Name: Gain Account</para>
        /// <para>Internal: gain_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("gain_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("gain_account_id")]
        public int? GainAccountId { get; set; }

        /// <summary>
        /// <para>Name: Loss Account</para>
        /// <para>Internal: loss_account_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("loss_account_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("loss_account_id")]
        public int? LossAccountId { get; set; }

        /// <summary>
        /// <para>Name: Digitization mode on bank statements</para>
        /// <para>Internal: extract_bank_statement_digitalization_mode</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Digitization mode on vendor bills</para>
        /// <para>Internal: extract_in_invoice_digitalization_mode</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Digitization mode on customer invoices</para>
        /// <para>Internal: extract_out_invoice_digitalization_mode</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("extract_single_line_per_tax")]
        [OdooField("extract_single_line_per_tax")]
        public bool ExtractSingleLinePerTax { get; set; }

    }
}
