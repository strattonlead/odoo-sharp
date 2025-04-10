using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("website.controller.page")]
    public partial class WebsiteControllerPage
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
        /// <para>Name: Listing view</para>
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
        [OdooField("view_id")]
        public int? ViewId { get; set; }

        /// <summary>
        /// <para>Name: Record view</para>
        /// <para>Internal: record_view_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("record_view_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("record_view_id")]
        public int? RecordViewId { get; set; }

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
        [OdooField("menu_ids")]
        public List<int> MenuIds { get; set; }

        /// <summary>
        /// <para>Name: View Name</para>
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
        /// <para>Name: URL</para>
        /// <para>Internal: name_slugified</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name_slugified")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name_slugified")]
        public string NameSlugified { get; set; }

        /// <summary>
        /// <para>Name: Demo URL</para>
        /// <para>Internal: url_demo</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("url_demo")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("url_demo")]
        public string UrlDemo { get; set; }

        /// <summary>
        /// <para>Name: Domain</para>
        /// <para>Internal: record_domain</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("record_domain")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("record_domain")]
        public string RecordDomain { get; set; }

        /// <summary>
        /// <para>Name: Default Layout</para>
        /// <para>Internal: default_layout</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [grid]=Grid,[list]=List</para>
        /// </summary>
        [JsonPropertyName("default_layout")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("default_layout")]
        public string DefaultLayout { get; set; }

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
        /// <para>Name: Create Website Menu</para>
        /// <para>Internal: use_menu</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_menu")]
        [OdooField("use_menu")]
        public bool UseMenu { get; set; }

        /// <summary>
        /// <para>Name: Create Single Page</para>
        /// <para>Internal: auto_single_page</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("auto_single_page")]
        [OdooField("auto_single_page")]
        public bool AutoSinglePage { get; set; }

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
        [OdooField("model")]
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
        [OdooField("key")]
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
        [OdooField("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// <para>Name: View Type</para>
        /// <para>Internal: type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [list]=List,[form]=Form,[graph]=Graph,[pivot]=Pivot,[calendar]=Calendar,[kanban]=Kanban,[search]=Search,[qweb]=QWeb,[cohort]=Cohort,[gantt]=Gantt,[grid]=Grid,[hierarchy]=Hierarchy,[map]=Map,[activity]=Activity</para>
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("type")]
        public string Type { get; set; }

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
        [OdooField("arch")]
        public string Arch { get; set; }

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
        [OdooField("arch_base")]
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
        [OdooField("arch_db")]
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
        [OdooField("arch_fs")]
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
        [OdooField("arch_updated")]
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
        [OdooField("arch_prev")]
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
        [OdooField("inherit_id")]
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
        [OdooField("inherit_children_ids")]
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
        [OdooField("model_data_id")]
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
        [OdooField("xml_id")]
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
        [OdooField("group_ids")]
        public List<int> GroupIds { get; set; }

        /// <summary>
        /// <para>Name: View inheritance mode</para>
        /// <para>Internal: mode</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [primary]=Base view,[extension]=Extension View</para>
        /// </summary>
        [JsonPropertyName("mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("mode")]
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
        [OdooField("warning_info")]
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
        [OdooField("active")]
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
        [OdooField("model_id")]
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
        [OdooField("customize_show")]
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
        [OdooField("page_ids")]
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
        [OdooField("controller_page_ids")]
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
        [OdooField("first_page_id")]
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
        [OdooField("track")]
        public bool Track { get; set; }

        /// <summary>
        /// <para>Name: Visibility</para>
        /// <para>Internal: visibility</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: []=Public,[connected]=Signed In,[restricted_group]=Restricted Group,[password]=With Password</para>
        /// </summary>
        [JsonPropertyName("visibility")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("visibility")]
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
        [OdooField("visibility_password")]
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
        [OdooField("visibility_password_display")]
        public string VisibilityPasswordDisplay { get; set; }

        /// <summary>
        /// <para>Name: Theme Template</para>
        /// <para>Internal: theme_template_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: theme.ir.ui.view</para>
        /// </summary>
        [JsonPropertyName("theme_template_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("theme_template_id")]
        public int? ThemeTemplateId { get; set; }

    }
}
