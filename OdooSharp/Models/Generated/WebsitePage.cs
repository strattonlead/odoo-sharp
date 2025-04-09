using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("website.page")]
    public partial class WebsitePage
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
        /// <para>Name: Header Visible</para>
        /// <para>Internal: header_visible</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("header_visible")]
        public bool HeaderVisible { get; set; }

        /// <summary>
        /// <para>Name: Footer Visible</para>
        /// <para>Internal: footer_visible</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("footer_visible")]
        public bool FooterVisible { get; set; }

        /// <summary>
        /// <para>Name: Header Overlay</para>
        /// <para>Internal: header_overlay</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("header_overlay")]
        public bool HeaderOverlay { get; set; }

        /// <summary>
        /// <para>Name: Header Color</para>
        /// <para>Internal: header_color</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("header_color")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string HeaderColor { get; set; }

        /// <summary>
        /// <para>Name: Header Text Color</para>
        /// <para>Internal: header_text_color</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("header_text_color")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string HeaderTextColor { get; set; }

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
        /// <para>Store: yes</para>
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
        /// <para>Name: Page URL</para>
        /// <para>Internal: url</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Url { get; set; }

        /// <summary>
        /// <para>Name: View</para>
        /// <para>Internal: view_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("view_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ViewId { get; set; }

        /// <summary>
        /// <para>Name: Is Indexed</para>
        /// <para>Internal: website_indexed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_indexed")]
        public bool WebsiteIndexed { get; set; }

        /// <summary>
        /// <para>Name: Publishing Date</para>
        /// <para>Internal: date_publish</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_publish")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? DatePublish { get; set; }

        /// <summary>
        /// <para>Name: Related Menus</para>
        /// <para>Internal: menu_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: website.menu</para>
        /// </summary>
        [JsonPropertyName("menu_ids")]
        public List<int> MenuIds { get; set; }

        /// <summary>
        /// <para>Name: Is In Menu</para>
        /// <para>Internal: is_in_menu</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_in_menu")]
        public bool IsInMenu { get; set; }

        /// <summary>
        /// <para>Name: Homepage</para>
        /// <para>Internal: is_homepage</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_homepage")]
        public bool IsHomepage { get; set; }

        /// <summary>
        /// <para>Name: Is Visible</para>
        /// <para>Internal: is_visible</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_visible")]
        public bool IsVisible { get; set; }

        /// <summary>
        /// <para>Name: New Page Template</para>
        /// <para>Internal: is_new_page_template</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_new_page_template")]
        public bool IsNewPageTemplate { get; set; }

        /// <summary>
        /// <para>Name: View Architecture</para>
        /// <para>Internal: arch</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("arch")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Arch { get; set; }

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
        /// <para>Name: Theme Template</para>
        /// <para>Internal: theme_template_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: theme.website.page</para>
        /// </summary>
        [JsonPropertyName("theme_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ThemeTemplateId { get; set; }

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
        /// <para>Name: View Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: Model</para>
        /// <para>Internal: model</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("model")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Model { get; set; }

        /// <summary>
        /// <para>Name: Key</para>
        /// <para>Internal: key</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("key")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Key { get; set; }

        /// <summary>
        /// <para>Name: Sequence</para>
        /// <para>Internal: priority</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// <para>Name: View Type</para>
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
        /// <para>Name: Base View Architecture</para>
        /// <para>Internal: arch_base</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("arch_base")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ArchBase { get; set; }

        /// <summary>
        /// <para>Name: Arch Blob</para>
        /// <para>Internal: arch_db</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("arch_db")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ArchDb { get; set; }

        /// <summary>
        /// <para>Name: Arch Filename</para>
        /// <para>Internal: arch_fs</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("arch_fs")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ArchFs { get; set; }

        /// <summary>
        /// <para>Name: Modified Architecture</para>
        /// <para>Internal: arch_updated</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("arch_updated")]
        public bool ArchUpdated { get; set; }

        /// <summary>
        /// <para>Name: Previous View Architecture</para>
        /// <para>Internal: arch_prev</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("arch_prev")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string ArchPrev { get; set; }

        /// <summary>
        /// <para>Name: Inherited View</para>
        /// <para>Internal: inherit_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("inherit_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? InheritId { get; set; }

        /// <summary>
        /// <para>Name: Views which inherit from this one</para>
        /// <para>Internal: inherit_children_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("inherit_children_ids")]
        public List<int> InheritChildrenIds { get; set; }

        /// <summary>
        /// <para>Name: Model Data</para>
        /// <para>Internal: model_data_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model.data</para>
        /// </summary>
        [JsonPropertyName("model_data_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ModelDataId { get; set; }

        /// <summary>
        /// <para>Name: External ID</para>
        /// <para>Internal: xml_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("xml_id")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string XmlId { get; set; }

        /// <summary>
        /// <para>Name: Groups</para>
        /// <para>Internal: group_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.groups</para>
        /// </summary>
        [JsonPropertyName("group_ids")]
        public List<int> GroupIds { get; set; }

        /// <summary>
        /// <para>Name: View inheritance mode</para>
        /// <para>Internal: mode</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Mode { get; set; }

        /// <summary>
        /// <para>Name: Warning information</para>
        /// <para>Internal: warning_info</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("warning_info")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string WarningInfo { get; set; }

        /// <summary>
        /// <para>Name: Active</para>
        /// <para>Internal: active</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>Name: Model of the view</para>
        /// <para>Internal: model_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? ModelId { get; set; }

        /// <summary>
        /// <para>Name: Show As Optional Inherit</para>
        /// <para>Internal: customize_show</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("customize_show")]
        public bool CustomizeShow { get; set; }

        /// <summary>
        /// <para>Name: Page</para>
        /// <para>Internal: page_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: website.page</para>
        /// </summary>
        [JsonPropertyName("page_ids")]
        public List<int> PageIds { get; set; }

        /// <summary>
        /// <para>Name: Controller Page</para>
        /// <para>Internal: controller_page_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: website.controller.page</para>
        /// </summary>
        [JsonPropertyName("controller_page_ids")]
        public List<int> ControllerPageIds { get; set; }

        /// <summary>
        /// <para>Name: Website Page</para>
        /// <para>Internal: first_page_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website.page</para>
        /// </summary>
        [JsonPropertyName("first_page_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? FirstPageId { get; set; }

        /// <summary>
        /// <para>Name: Track</para>
        /// <para>Internal: track</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("track")]
        public bool Track { get; set; }

        /// <summary>
        /// <para>Name: Visibility</para>
        /// <para>Internal: visibility</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("visibility")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>Name: Visibility Password</para>
        /// <para>Internal: visibility_password</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("visibility_password")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string VisibilityPassword { get; set; }

        /// <summary>
        /// <para>Name: Visibility Password Display</para>
        /// <para>Internal: visibility_password_display</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("visibility_password_display")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string VisibilityPasswordDisplay { get; set; }

    }
}
