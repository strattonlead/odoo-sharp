using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("helpdesk.team")]
    public partial class HelpdeskTeam
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
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
        /// <para>Name: Rating Satisfaction</para>
        /// <para>Internal: rating_percentage_satisfaction</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("rating_percentage_satisfaction")]
        [OdooField("rating_percentage_satisfaction")]
        public int RatingPercentageSatisfaction { get; set; }

        /// <summary>
        /// <para>Name: # Ratings</para>
        /// <para>Internal: rating_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("rating_count")]
        [OdooField("rating_count")]
        public int RatingCount { get; set; }

        /// <summary>
        /// <para>Name: Average Rating</para>
        /// <para>Internal: rating_avg</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("rating_avg")]
        [OdooField("rating_avg")]
        public double RatingAvg { get; set; }

        /// <summary>
        /// <para>Name: Average Rating (%)</para>
        /// <para>Internal: rating_avg_percentage</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("rating_avg_percentage")]
        [OdooField("rating_avg_percentage")]
        public double RatingAvgPercentage { get; set; }

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
        /// <para>Name: Alias</para>
        /// <para>Internal: alias_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: mail.alias</para>
        /// </summary>
        [JsonPropertyName("alias_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_id")]
        public int? AliasId { get; set; }

        /// <summary>
        /// <para>Name: Alias Name</para>
        /// <para>Internal: alias_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_name")]
        public string AliasName { get; set; }

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
        /// <para>Name: Alias Domain Name</para>
        /// <para>Internal: alias_domain</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_domain")]
        public string AliasDomain { get; set; }

        /// <summary>
        /// <para>Name: Default Values</para>
        /// <para>Internal: alias_defaults</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("alias_defaults")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_defaults")]
        public string AliasDefaults { get; set; }

        /// <summary>
        /// <para>Name: Email Alias</para>
        /// <para>Internal: alias_email</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_email")]
        public string AliasEmail { get; set; }

        /// <summary>
        /// <para>Name: Helpdesk Team</para>
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
        /// <para>Name: About Team</para>
        /// <para>Internal: description</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("description")]
        public string Description { get; set; }

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
        /// <para>Name: Ticket Properties</para>
        /// <para>Internal: ticket_properties</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Unknown</para>
        /// </summary>
        [JsonPropertyName("ticket_properties")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("ticket_properties")]
        public object TicketProperties { get; set; }

        /// <summary>
        /// <para>Name: Stages</para>
        /// <para>Internal: stage_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: helpdesk.stage</para>
        /// </summary>
        [JsonPropertyName("stage_ids")]
        [OdooField("stage_ids")]
        public List<int> StageIds { get; set; }

        /// <summary>
        /// <para>Name: Automatic Assignment</para>
        /// <para>Internal: auto_assignment</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("auto_assignment")]
        [OdooField("auto_assignment")]
        public bool AutoAssignment { get; set; }

        /// <summary>
        /// <para>Name: Assignment Method</para>
        /// <para>Internal: assign_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [randomly]=Each user is assigned an equal number of tickets,[balanced]=Each user has an equal number of open tickets,[tags]=Dispatch tickets based on tags</para>
        /// </summary>
        [JsonPropertyName("assign_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("assign_method")]
        public string AssignMethod { get; set; }

        /// <summary>
        /// <para>Name: Team Members</para>
        /// <para>Internal: member_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.users</para>
        /// </summary>
        [JsonPropertyName("member_ids")]
        [OdooField("member_ids")]
        public List<int> MemberIds { get; set; }

        /// <summary>
        /// <para>Name: Visibility</para>
        /// <para>Internal: privacy_visibility</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [invited_internal]=Invited internal users (private),[internal]=All internal users (company),[portal]=Invited portal users and all internal users (public)</para>
        /// </summary>
        [JsonPropertyName("privacy_visibility")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("privacy_visibility")]
        public string PrivacyVisibility { get; set; }

        /// <summary>
        /// <para>Name: Privacy Visibility Warning</para>
        /// <para>Internal: privacy_visibility_warning</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("privacy_visibility_warning")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("privacy_visibility_warning")]
        public string PrivacyVisibilityWarning { get; set; }

        /// <summary>
        /// <para>Name: Access Instruction Message</para>
        /// <para>Internal: access_instruction_message</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("access_instruction_message")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("access_instruction_message")]
        public string AccessInstructionMessage { get; set; }

        /// <summary>
        /// <para>Name: Tickets</para>
        /// <para>Internal: ticket_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: helpdesk.ticket</para>
        /// </summary>
        [JsonPropertyName("ticket_ids")]
        [OdooField("ticket_ids")]
        public List<int> TicketIds { get; set; }

        /// <summary>
        /// <para>Name: Use Alias</para>
        /// <para>Internal: use_alias</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_alias")]
        [OdooField("use_alias")]
        public bool UseAlias { get; set; }

        /// <summary>
        /// <para>Name: Has External Mail Server</para>
        /// <para>Internal: has_external_mail_server</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_external_mail_server")]
        [OdooField("has_external_mail_server")]
        public bool HasExternalMailServer { get; set; }

        /// <summary>
        /// <para>Name: Closure by Customers</para>
        /// <para>Internal: allow_portal_ticket_closing</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("allow_portal_ticket_closing")]
        [OdooField("allow_portal_ticket_closing")]
        public bool AllowPortalTicketClosing { get; set; }

        /// <summary>
        /// <para>Name: Website Form</para>
        /// <para>Internal: use_website_helpdesk_form</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_website_helpdesk_form")]
        [OdooField("use_website_helpdesk_form")]
        public bool UseWebsiteHelpdeskForm { get; set; }

        /// <summary>
        /// <para>Name: Live Chat</para>
        /// <para>Internal: use_website_helpdesk_livechat</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_website_helpdesk_livechat")]
        [OdooField("use_website_helpdesk_livechat")]
        public bool UseWebsiteHelpdeskLivechat { get; set; }

        /// <summary>
        /// <para>Name: Community Forum</para>
        /// <para>Internal: use_website_helpdesk_forum</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_website_helpdesk_forum")]
        [OdooField("use_website_helpdesk_forum")]
        public bool UseWebsiteHelpdeskForum { get; set; }

        /// <summary>
        /// <para>Name: eLearning</para>
        /// <para>Internal: use_website_helpdesk_slides</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_website_helpdesk_slides")]
        [OdooField("use_website_helpdesk_slides")]
        public bool UseWebsiteHelpdeskSlides { get; set; }

        /// <summary>
        /// <para>Name: Knowledge</para>
        /// <para>Internal: use_website_helpdesk_knowledge</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_website_helpdesk_knowledge")]
        [OdooField("use_website_helpdesk_knowledge")]
        public bool UseWebsiteHelpdeskKnowledge { get; set; }

        /// <summary>
        /// <para>Name: Timesheets</para>
        /// <para>Internal: use_helpdesk_timesheet</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_helpdesk_timesheet")]
        [OdooField("use_helpdesk_timesheet")]
        public bool UseHelpdeskTimesheet { get; set; }

        /// <summary>
        /// <para>Name: Show Knowledge Base</para>
        /// <para>Internal: show_knowledge_base</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_knowledge_base")]
        [OdooField("show_knowledge_base")]
        public bool ShowKnowledgeBase { get; set; }

        /// <summary>
        /// <para>Name: Time Billing</para>
        /// <para>Internal: use_helpdesk_sale_timesheet</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_helpdesk_sale_timesheet")]
        [OdooField("use_helpdesk_sale_timesheet")]
        public bool UseHelpdeskSaleTimesheet { get; set; }

        /// <summary>
        /// <para>Name: Refunds</para>
        /// <para>Internal: use_credit_notes</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_credit_notes")]
        [OdooField("use_credit_notes")]
        public bool UseCreditNotes { get; set; }

        /// <summary>
        /// <para>Name: Coupons</para>
        /// <para>Internal: use_coupons</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_coupons")]
        [OdooField("use_coupons")]
        public bool UseCoupons { get; set; }

        /// <summary>
        /// <para>Name: Field Service</para>
        /// <para>Internal: use_fsm</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_fsm")]
        [OdooField("use_fsm")]
        public bool UseFsm { get; set; }

        /// <summary>
        /// <para>Name: Returns</para>
        /// <para>Internal: use_product_returns</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_product_returns")]
        [OdooField("use_product_returns")]
        public bool UseProductReturns { get; set; }

        /// <summary>
        /// <para>Name: Repairs</para>
        /// <para>Internal: use_product_repairs</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_product_repairs")]
        [OdooField("use_product_repairs")]
        public bool UseProductRepairs { get; set; }

        /// <summary>
        /// <para>Name: X</para>
        /// <para>Internal: use_twitter</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_twitter")]
        [OdooField("use_twitter")]
        public bool UseTwitter { get; set; }

        /// <summary>
        /// <para>Name: Customer Ratings</para>
        /// <para>Internal: use_rating</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_rating")]
        [OdooField("use_rating")]
        public bool UseRating { get; set; }

        /// <summary>
        /// <para>Name: SLA Policies</para>
        /// <para>Internal: use_sla</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_sla")]
        [OdooField("use_sla")]
        public bool UseSla { get; set; }

        /// <summary>
        /// <para>Name: Unassigned Tickets</para>
        /// <para>Internal: unassigned_tickets</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("unassigned_tickets")]
        [OdooField("unassigned_tickets")]
        public int UnassignedTickets { get; set; }

        /// <summary>
        /// <para>Name: Working Hours</para>
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
        /// <para>Name: # Open Tickets</para>
        /// <para>Internal: open_ticket_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("open_ticket_count")]
        [OdooField("open_ticket_count")]
        public int OpenTicketCount { get; set; }

        /// <summary>
        /// <para>Name: # SLA Policy</para>
        /// <para>Internal: sla_policy_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sla_policy_count")]
        [OdooField("sla_policy_count")]
        public int SlaPolicyCount { get; set; }

        /// <summary>
        /// <para>Name: Ticket Closed</para>
        /// <para>Internal: ticket_closed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("ticket_closed")]
        [OdooField("ticket_closed")]
        public int TicketClosed { get; set; }

        /// <summary>
        /// <para>Name: Success Rate</para>
        /// <para>Internal: success_rate</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("success_rate")]
        [OdooField("success_rate")]
        public double SuccessRate { get; set; }

        /// <summary>
        /// <para>Name: # Urgent Ticket</para>
        /// <para>Internal: urgent_ticket</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("urgent_ticket")]
        [OdooField("urgent_ticket")]
        public int UrgentTicket { get; set; }

        /// <summary>
        /// <para>Name: Failed SLA Ticket</para>
        /// <para>Internal: sla_failed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("sla_failed")]
        [OdooField("sla_failed")]
        public int SlaFailed { get; set; }

        /// <summary>
        /// <para>Name: Automatic Closing</para>
        /// <para>Internal: auto_close_ticket</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("auto_close_ticket")]
        [OdooField("auto_close_ticket")]
        public bool AutoCloseTicket { get; set; }

        /// <summary>
        /// <para>Name: Inactive Period(days)</para>
        /// <para>Internal: auto_close_day</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("auto_close_day")]
        [OdooField("auto_close_day")]
        public int AutoCloseDay { get; set; }

        /// <summary>
        /// <para>Name: In Stages</para>
        /// <para>Internal: from_stage_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: helpdesk.stage</para>
        /// </summary>
        [JsonPropertyName("from_stage_ids")]
        [OdooField("from_stage_ids")]
        public List<int> FromStageIds { get; set; }

        /// <summary>
        /// <para>Name: Move to Stage</para>
        /// <para>Internal: to_stage_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: helpdesk.stage</para>
        /// </summary>
        [JsonPropertyName("to_stage_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("to_stage_id")]
        public int? ToStageId { get; set; }

        /// <summary>
        /// <para>Name: Alias Email From</para>
        /// <para>Internal: alias_email_from</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_email_from")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_email_from")]
        public string AliasEmailFrom { get; set; }

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
        /// <para>Name: URL to Submit Issue</para>
        /// <para>Internal: feature_form_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("feature_form_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("feature_form_url")]
        public string FeatureFormUrl { get; set; }

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
        /// <para>Name: Website Menu</para>
        /// <para>Internal: website_menu_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website.menu</para>
        /// </summary>
        [JsonPropertyName("website_menu_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("website_menu_id")]
        public int? WebsiteMenuId { get; set; }

        /// <summary>
        /// <para>Name: Website Form View</para>
        /// <para>Internal: website_form_view_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("website_form_view_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("website_form_view_id")]
        public int? WebsiteFormViewId { get; set; }

        /// <summary>
        /// <para>Name: Show Knowledge Base Article</para>
        /// <para>Internal: show_knowledge_base_article</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("show_knowledge_base_article")]
        [OdooField("show_knowledge_base_article")]
        public bool ShowKnowledgeBaseArticle { get; set; }

        /// <summary>
        /// <para>Name: Article</para>
        /// <para>Internal: website_article_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: knowledge.article</para>
        /// </summary>
        [JsonPropertyName("website_article_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("website_article_id")]
        public int? WebsiteArticleId { get; set; }

        /// <summary>
        /// <para>Name: Latest Articles</para>
        /// <para>Internal: website_latest_articles</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: knowledge.article</para>
        /// </summary>
        [JsonPropertyName("website_latest_articles")]
        [OdooField("website_latest_articles")]
        public List<int> WebsiteLatestArticles { get; set; }

        /// <summary>
        /// <para>Name: Alias Email</para>
        /// <para>Internal: alias_full_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("alias_full_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_full_name")]
        public string AliasFullName { get; set; }

        /// <summary>
        /// <para>Name: Aliased Model</para>
        /// <para>Internal: alias_model_id</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("alias_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_model_id")]
        public int? AliasModelId { get; set; }

        /// <summary>
        /// <para>Name: Record Thread ID</para>
        /// <para>Internal: alias_force_thread_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("alias_force_thread_id")]
        [OdooField("alias_force_thread_id")]
        public int AliasForceThreadId { get; set; }

        /// <summary>
        /// <para>Name: Parent Model</para>
        /// <para>Internal: alias_parent_model_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("alias_parent_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("alias_parent_model_id")]
        public int? AliasParentModelId { get; set; }

        /// <summary>
        /// <para>Name: Parent Record Thread ID</para>
        /// <para>Internal: alias_parent_thread_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("alias_parent_thread_id")]
        [OdooField("alias_parent_thread_id")]
        public int AliasParentThreadId { get; set; }

        /// <summary>
        /// <para>Name: Alias Contact Security</para>
        /// <para>Internal: alias_contact</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [everyone]=Everyone,[partners]=Authenticated Partners,[followers]=Followers only,[employees]=Authenticated Employees</para>
        /// </summary>
        [JsonPropertyName("alias_contact")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_contact")]
        public string AliasContact { get; set; }

        /// <summary>
        /// <para>Name: Local-part based incoming detection</para>
        /// <para>Internal: alias_incoming_local</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("alias_incoming_local")]
        [OdooField("alias_incoming_local")]
        public bool AliasIncomingLocal { get; set; }

        /// <summary>
        /// <para>Name: Custom Bounced Message</para>
        /// <para>Internal: alias_bounced_content</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("alias_bounced_content")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_bounced_content")]
        public string AliasBouncedContent { get; set; }

        /// <summary>
        /// <para>Name: Alias Status</para>
        /// <para>Internal: alias_status</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_tested]=Not Tested,[valid]=Valid,[invalid]=Invalid</para>
        /// </summary>
        [JsonPropertyName("alias_status")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("alias_status")]
        public string AliasStatus { get; set; }

    }
}
