using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("product.template")]
    public partial class ProductTemplate
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
        /// <para>Name: Image</para>
        /// <para>Internal: image_1920</para>
        /// <para>Store: yes</para>
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
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_1024")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("image_1024")]
        public byte[] Image1024 { get; set; }

        /// <summary>
        /// <para>Name: Image 512</para>
        /// <para>Internal: image_512</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_512")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("image_512")]
        public byte[] Image512 { get; set; }

        /// <summary>
        /// <para>Name: Image 256</para>
        /// <para>Internal: image_256</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_256")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("image_256")]
        public byte[] Image256 { get; set; }

        /// <summary>
        /// <para>Name: Image 128</para>
        /// <para>Internal: image_128</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("image_128")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("image_128")]
        public byte[] Image128 { get; set; }

        /// <summary>
        /// <para>Name: Activities</para>
        /// <para>Internal: activity_ids</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Name</para>
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
        /// <para>Name: Description</para>
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
        /// <para>Name: Purchase Description</para>
        /// <para>Internal: description_purchase</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("description_purchase")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("description_purchase")]
        public string DescriptionPurchase { get; set; }

        /// <summary>
        /// <para>Name: Sales Description</para>
        /// <para>Internal: description_sale</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("description_sale")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("description_sale")]
        public string DescriptionSale { get; set; }

        /// <summary>
        /// <para>Name: Product Type</para>
        /// <para>Internal: type</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [consu]=Goods,[service]=Service,[combo]=Combo</para>
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("type")]
        public string Type { get; set; }

        /// <summary>
        /// <para>Name: Combo Choices</para>
        /// <para>Internal: combo_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.combo</para>
        /// </summary>
        [JsonPropertyName("combo_ids")]
        [OdooField("combo_ids")]
        public List<int> ComboIds { get; set; }

        /// <summary>
        /// <para>Name: Create on Order</para>
        /// <para>Internal: service_tracking</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no]=Nothing</para>
        /// </summary>
        [JsonPropertyName("service_tracking")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("service_tracking")]
        public string ServiceTracking { get; set; }

        /// <summary>
        /// <para>Name: Product Category</para>
        /// <para>Internal: categ_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.category</para>
        /// </summary>
        [JsonPropertyName("categ_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("categ_id")]
        public int? CategId { get; set; }

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
        /// <para>Name: Cost Currency</para>
        /// <para>Internal: cost_currency_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.currency</para>
        /// </summary>
        [JsonPropertyName("cost_currency_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("cost_currency_id")]
        public int? CostCurrencyId { get; set; }

        /// <summary>
        /// <para>Name: Sales Price</para>
        /// <para>Internal: list_price</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("list_price")]
        [OdooField("list_price")]
        public double ListPrice { get; set; }

        /// <summary>
        /// <para>Name: Cost</para>
        /// <para>Internal: standard_price</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("standard_price")]
        [OdooField("standard_price")]
        public double StandardPrice { get; set; }

        /// <summary>
        /// <para>Name: Volume</para>
        /// <para>Internal: volume</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("volume")]
        [OdooField("volume")]
        public double Volume { get; set; }

        /// <summary>
        /// <para>Name: Volume unit of measure label</para>
        /// <para>Internal: volume_uom_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("volume_uom_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("volume_uom_name")]
        public string VolumeUomName { get; set; }

        /// <summary>
        /// <para>Name: Weight</para>
        /// <para>Internal: weight</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("weight")]
        [OdooField("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// <para>Name: Weight unit of measure label</para>
        /// <para>Internal: weight_uom_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("weight_uom_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("weight_uom_name")]
        public string WeightUomName { get; set; }

        /// <summary>
        /// <para>Name: Sales</para>
        /// <para>Internal: sale_ok</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("sale_ok")]
        [OdooField("sale_ok")]
        public bool SaleOk { get; set; }

        /// <summary>
        /// <para>Name: Purchase</para>
        /// <para>Internal: purchase_ok</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("purchase_ok")]
        [OdooField("purchase_ok")]
        public bool PurchaseOk { get; set; }

        /// <summary>
        /// <para>Name: Unit</para>
        /// <para>Internal: uom_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: uom.uom</para>
        /// </summary>
        [JsonPropertyName("uom_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("uom_id")]
        public int? UomId { get; set; }

        /// <summary>
        /// <para>Name: Packagings</para>
        /// <para>Internal: uom_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: uom.uom</para>
        /// </summary>
        [JsonPropertyName("uom_ids")]
        [OdooField("uom_ids")]
        public List<int> UomIds { get; set; }

        /// <summary>
        /// <para>Name: Unit Name</para>
        /// <para>Internal: uom_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("uom_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("uom_name")]
        public string UomName { get; set; }

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
        /// <para>Name: Vendors</para>
        /// <para>Internal: seller_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: product.supplierinfo</para>
        /// </summary>
        [JsonPropertyName("seller_ids")]
        [OdooField("seller_ids")]
        public List<int> SellerIds { get; set; }

        /// <summary>
        /// <para>Name: Variant Seller</para>
        /// <para>Internal: variant_seller_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: product.supplierinfo</para>
        /// </summary>
        [JsonPropertyName("variant_seller_ids")]
        [OdooField("variant_seller_ids")]
        public List<int> VariantSellerIds { get; set; }

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
        /// <para>Name: Is a product variant</para>
        /// <para>Internal: is_product_variant</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_product_variant")]
        [OdooField("is_product_variant")]
        public bool IsProductVariant { get; set; }

        /// <summary>
        /// <para>Name: Product Attributes</para>
        /// <para>Internal: attribute_line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: product.template.attribute.line</para>
        /// </summary>
        [JsonPropertyName("attribute_line_ids")]
        [OdooField("attribute_line_ids")]
        public List<int> AttributeLineIds { get; set; }

        /// <summary>
        /// <para>Name: Valid Product Attribute Lines</para>
        /// <para>Internal: valid_product_template_attribute_line_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.template.attribute.line</para>
        /// </summary>
        [JsonPropertyName("valid_product_template_attribute_line_ids")]
        [OdooField("valid_product_template_attribute_line_ids")]
        public List<int> ValidProductTemplateAttributeLineIds { get; set; }

        /// <summary>
        /// <para>Name: Products</para>
        /// <para>Internal: product_variant_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: product.product</para>
        /// </summary>
        [JsonPropertyName("product_variant_ids")]
        [OdooField("product_variant_ids")]
        public List<int> ProductVariantIds { get; set; }

        /// <summary>
        /// <para>Name: Product</para>
        /// <para>Internal: product_variant_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.product</para>
        /// </summary>
        [JsonPropertyName("product_variant_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("product_variant_id")]
        public int? ProductVariantId { get; set; }

        /// <summary>
        /// <para>Name: # Product Variants</para>
        /// <para>Internal: product_variant_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("product_variant_count")]
        [OdooField("product_variant_count")]
        public int ProductVariantCount { get; set; }

        /// <summary>
        /// <para>Name: Barcode</para>
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
        /// <para>Name: Internal Reference</para>
        /// <para>Internal: default_code</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("default_code")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("default_code")]
        public string DefaultCode { get; set; }

        /// <summary>
        /// <para>Name: Number of price rules</para>
        /// <para>Internal: pricelist_item_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("pricelist_item_count")]
        [OdooField("pricelist_item_count")]
        public int PricelistItemCount { get; set; }

        /// <summary>
        /// <para>Name: Documents</para>
        /// <para>Internal: product_document_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: product.document</para>
        /// </summary>
        [JsonPropertyName("product_document_ids")]
        [OdooField("product_document_ids")]
        public List<int> ProductDocumentIds { get; set; }

        /// <summary>
        /// <para>Name: Documents Count</para>
        /// <para>Internal: product_document_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("product_document_count")]
        [OdooField("product_document_count")]
        public int ProductDocumentCount { get; set; }

        /// <summary>
        /// <para>Name: Can Image 1024 be zoomed</para>
        /// <para>Internal: can_image_1024_be_zoomed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("can_image_1024_be_zoomed")]
        [OdooField("can_image_1024_be_zoomed")]
        public bool CanImage1024BeZoomed { get; set; }

        /// <summary>
        /// <para>Name: Is a configurable product</para>
        /// <para>Internal: has_configurable_attributes</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_configurable_attributes")]
        [OdooField("has_configurable_attributes")]
        public bool HasConfigurableAttributes { get; set; }

        /// <summary>
        /// <para>Name: Is Dynamically Created</para>
        /// <para>Internal: is_dynamically_created</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_dynamically_created")]
        [OdooField("is_dynamically_created")]
        public bool IsDynamicallyCreated { get; set; }

        /// <summary>
        /// <para>Name: Product Tooltip</para>
        /// <para>Internal: product_tooltip</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("product_tooltip")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("product_tooltip")]
        public string ProductTooltip { get; set; }

        /// <summary>
        /// <para>Name: Favorite</para>
        /// <para>Internal: is_favorite</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_favorite")]
        [OdooField("is_favorite")]
        public bool IsFavorite { get; set; }

        /// <summary>
        /// <para>Name: Tags</para>
        /// <para>Internal: product_tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.tag</para>
        /// </summary>
        [JsonPropertyName("product_tag_ids")]
        [OdooField("product_tag_ids")]
        public List<int> ProductTagIds { get; set; }

        /// <summary>
        /// <para>Name: Properties</para>
        /// <para>Internal: product_properties</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Unknown</para>
        /// </summary>
        [JsonPropertyName("product_properties")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("product_properties")]
        public object ProductProperties { get; set; }

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
        /// <para>Name: Sales Taxes</para>
        /// <para>Internal: taxes_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("taxes_id")]
        [OdooField("taxes_id")]
        public List<int> TaxesId { get; set; }

        /// <summary>
        /// <para>Name: Tax String</para>
        /// <para>Internal: tax_string</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("tax_string")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("tax_string")]
        public string TaxString { get; set; }

        /// <summary>
        /// <para>Name: Purchase Taxes</para>
        /// <para>Internal: supplier_taxes_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.tax</para>
        /// </summary>
        [JsonPropertyName("supplier_taxes_id")]
        [OdooField("supplier_taxes_id")]
        public List<int> SupplierTaxesId { get; set; }

        /// <summary>
        /// <para>Name: Income Account</para>
        /// <para>Internal: property_account_income_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: yes</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("property_account_income_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_account_income_id")]
        public int? PropertyAccountIncomeId { get; set; }

        /// <summary>
        /// <para>Name: Expense Account</para>
        /// <para>Internal: property_account_expense_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: yes</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.account</para>
        /// </summary>
        [JsonPropertyName("property_account_expense_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("property_account_expense_id")]
        public int? PropertyAccountExpenseId { get; set; }

        /// <summary>
        /// <para>Name: Account Tags</para>
        /// <para>Internal: account_tag_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.account.tag</para>
        /// </summary>
        [JsonPropertyName("account_tag_ids")]
        [OdooField("account_tag_ids")]
        public List<int> AccountTagIds { get; set; }

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
        /// <para>Name: Purchased</para>
        /// <para>Internal: purchased_product_qty</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("purchased_product_qty")]
        [OdooField("purchased_product_qty")]
        public double PurchasedProductQty { get; set; }

        /// <summary>
        /// <para>Name: Control Policy</para>
        /// <para>Internal: purchase_method</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [purchase]=On ordered quantities,[receive]=On received quantities</para>
        /// </summary>
        [JsonPropertyName("purchase_method")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("purchase_method")]
        public string PurchaseMethod { get; set; }

        /// <summary>
        /// <para>Name: Purchase Order Line Warning</para>
        /// <para>Internal: purchase_line_warn</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no-message]=No Message,[warning]=Warning,[block]=Blocking Message</para>
        /// </summary>
        [JsonPropertyName("purchase_line_warn")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("purchase_line_warn")]
        public string PurchaseLineWarn { get; set; }

        /// <summary>
        /// <para>Name: Message for Purchase Order Line</para>
        /// <para>Internal: purchase_line_warn_msg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("purchase_line_warn_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("purchase_line_warn_msg")]
        public string PurchaseLineWarnMsg { get; set; }

        /// <summary>
        /// <para>Name: Track Service</para>
        /// <para>Internal: service_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [manual]=Manually set quantities on order</para>
        /// </summary>
        [JsonPropertyName("service_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>Name: Sales Order Line</para>
        /// <para>Internal: sale_line_warn</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no-message]=No Message,[warning]=Warning,[block]=Blocking Message</para>
        /// </summary>
        [JsonPropertyName("sale_line_warn")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sale_line_warn")]
        public string SaleLineWarn { get; set; }

        /// <summary>
        /// <para>Name: Message for Sales Order Line</para>
        /// <para>Internal: sale_line_warn_msg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("sale_line_warn_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("sale_line_warn_msg")]
        public string SaleLineWarnMsg { get; set; }

        /// <summary>
        /// <para>Name: Re-Invoice Costs</para>
        /// <para>Internal: expense_policy</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no]=No,[cost]=At cost,[sales_price]=Sales price</para>
        /// </summary>
        [JsonPropertyName("expense_policy")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("expense_policy")]
        public string ExpensePolicy { get; set; }

        /// <summary>
        /// <para>Name: Re-Invoice Policy visible</para>
        /// <para>Internal: visible_expense_policy</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("visible_expense_policy")]
        [OdooField("visible_expense_policy")]
        public bool VisibleExpensePolicy { get; set; }

        /// <summary>
        /// <para>Name: Sold</para>
        /// <para>Internal: sales_count</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("sales_count")]
        [OdooField("sales_count")]
        public double SalesCount { get; set; }

        /// <summary>
        /// <para>Name: Invoicing Policy</para>
        /// <para>Internal: invoice_policy</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [order]=Ordered quantities,[delivery]=Delivered quantities</para>
        /// </summary>
        [JsonPropertyName("invoice_policy")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("invoice_policy")]
        public string InvoicePolicy { get; set; }

        /// <summary>
        /// <para>Name: Optional Products</para>
        /// <para>Internal: optional_product_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.template</para>
        /// </summary>
        [JsonPropertyName("optional_product_ids")]
        [OdooField("optional_product_ids")]
        public List<int> OptionalProductIds { get; set; }

        /// <summary>
        /// <para>Name: Subcontract Service</para>
        /// <para>Internal: service_to_purchase</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: yes</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("service_to_purchase")]
        [OdooField("service_to_purchase")]
        public bool ServiceToPurchase { get; set; }

        /// <summary>
        /// <para>Name: Rating Last Value</para>
        /// <para>Internal: rating_last_value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("rating_last_value")]
        [OdooField("rating_last_value")]
        public double RatingLastValue { get; set; }

        /// <summary>
        /// <para>Name: Rating Last Feedback</para>
        /// <para>Internal: rating_last_feedback</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("rating_last_feedback")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("rating_last_feedback")]
        public string RatingLastFeedback { get; set; }

        /// <summary>
        /// <para>Name: Rating Last Image</para>
        /// <para>Internal: rating_last_image</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("rating_last_image")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("rating_last_image")]
        public object RatingLastImage { get; set; }

        /// <summary>
        /// <para>Name: Rating count</para>
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
        /// <para>Name: Rating Avg Text</para>
        /// <para>Internal: rating_avg_text</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [top]=Satisfied,[ok]=Okay,[ko]=Dissatisfied,[none]=No Rating yet</para>
        /// </summary>
        [JsonPropertyName("rating_avg_text")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("rating_avg_text")]
        public string RatingAvgText { get; set; }

        /// <summary>
        /// <para>Name: Rating Satisfaction</para>
        /// <para>Internal: rating_percentage_satisfaction</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("rating_percentage_satisfaction")]
        [OdooField("rating_percentage_satisfaction")]
        public double RatingPercentageSatisfaction { get; set; }

        /// <summary>
        /// <para>Name: Rating Text</para>
        /// <para>Internal: rating_last_text</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [top]=Satisfied,[ok]=Okay,[ko]=Dissatisfied,[none]=No Rating yet</para>
        /// </summary>
        [JsonPropertyName("rating_last_text")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("rating_last_text")]
        public string RatingLastText { get; set; }

        /// <summary>
        /// <para>Name: Description for the website</para>
        /// <para>Internal: website_description</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: eCommerce Description</para>
        /// <para>Internal: description_ecommerce</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("description_ecommerce")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("description_ecommerce")]
        public string DescriptionEcommerce { get; set; }

        /// <summary>
        /// <para>Name: Alternative Products</para>
        /// <para>Internal: alternative_product_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.template</para>
        /// </summary>
        [JsonPropertyName("alternative_product_ids")]
        [OdooField("alternative_product_ids")]
        public List<int> AlternativeProductIds { get; set; }

        /// <summary>
        /// <para>Name: Accessory Products</para>
        /// <para>Internal: accessory_product_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.product</para>
        /// </summary>
        [JsonPropertyName("accessory_product_ids")]
        [OdooField("accessory_product_ids")]
        public List<int> AccessoryProductIds { get; set; }

        /// <summary>
        /// <para>Name: Size X</para>
        /// <para>Internal: website_size_x</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("website_size_x")]
        [OdooField("website_size_x")]
        public int WebsiteSizeX { get; set; }

        /// <summary>
        /// <para>Name: Size Y</para>
        /// <para>Internal: website_size_y</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("website_size_y")]
        [OdooField("website_size_y")]
        public int WebsiteSizeY { get; set; }

        /// <summary>
        /// <para>Name: Ribbon</para>
        /// <para>Internal: website_ribbon_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: product.ribbon</para>
        /// </summary>
        [JsonPropertyName("website_ribbon_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("website_ribbon_id")]
        public int? WebsiteRibbonId { get; set; }

        /// <summary>
        /// <para>Name: Website Sequence</para>
        /// <para>Internal: website_sequence</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("website_sequence")]
        [OdooField("website_sequence")]
        public int WebsiteSequence { get; set; }

        /// <summary>
        /// <para>Name: Website Product Category</para>
        /// <para>Internal: public_categ_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: product.public.category</para>
        /// </summary>
        [JsonPropertyName("public_categ_ids")]
        [OdooField("public_categ_ids")]
        public List<int> PublicCategIds { get; set; }

        /// <summary>
        /// <para>Name: Publish Date</para>
        /// <para>Internal: publish_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("publish_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("publish_date")]
        public DateTime? PublishDate { get; set; }

        /// <summary>
        /// <para>Name: Extra Product Media</para>
        /// <para>Internal: product_template_image_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: product.image</para>
        /// </summary>
        [JsonPropertyName("product_template_image_ids")]
        [OdooField("product_template_image_ids")]
        public List<int> ProductTemplateImageIds { get; set; }

        /// <summary>
        /// <para>Name: Base Unit Count</para>
        /// <para>Internal: base_unit_count</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("base_unit_count")]
        [OdooField("base_unit_count")]
        public double BaseUnitCount { get; set; }

        /// <summary>
        /// <para>Name: Custom Unit of Measure</para>
        /// <para>Internal: base_unit_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website.base.unit</para>
        /// </summary>
        [JsonPropertyName("base_unit_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("base_unit_id")]
        public int? BaseUnitId { get; set; }

        /// <summary>
        /// <para>Name: Price Per Unit</para>
        /// <para>Internal: base_unit_price</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("base_unit_price")]
        [OdooField("base_unit_price")]
        public decimal BaseUnitPrice { get; set; }

        /// <summary>
        /// <para>Name: Base Unit Name</para>
        /// <para>Internal: base_unit_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("base_unit_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("base_unit_name")]
        public string BaseUnitName { get; set; }

        /// <summary>
        /// <para>Name: Compare to Price</para>
        /// <para>Internal: compare_list_price</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Monetary</para>
        /// </summary>
        [JsonPropertyName("compare_list_price")]
        [OdooField("compare_list_price")]
        public decimal CompareListPrice { get; set; }

    }
}
