using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("website.page.properties")]
    public partial class WebsitePageProperties
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
        /// <para>Name: Target Model</para>
        /// <para>Internal: target_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website.page</para>
        /// </summary>
        [JsonPropertyName("target_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? TargetModelId { get; set; }

        /// <summary>
        /// <para>Name: Website</para>
        /// <para>Internal: website_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: website</para>
        /// </summary>
        [JsonPropertyName("website_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        public int? WebsiteId { get; set; }

        /// <summary>
        /// <para>Name: Menu</para>
        /// <para>Internal: menu_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
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
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_in_menu")]
        public bool IsInMenu { get; set; }

        /// <summary>
        /// <para>Name: Page URL</para>
        /// <para>Internal: url</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string Url { get; set; }

        /// <summary>
        /// <para>Name: Homepage</para>
        /// <para>Internal: is_homepage</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_homepage")]
        public bool IsHomepage { get; set; }

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
        /// <para>Name: View Name</para>
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
        /// <para>Name: Publishing Date</para>
        /// <para>Internal: date_publish</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("date_publish")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        public DateTime? DatePublish { get; set; }

        /// <summary>
        /// <para>Name: Is Indexed</para>
        /// <para>Internal: website_indexed</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("website_indexed")]
        public bool WebsiteIndexed { get; set; }

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
        /// <para>Name: New Page Template</para>
        /// <para>Internal: is_new_page_template</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_new_page_template")]
        public bool IsNewPageTemplate { get; set; }

        /// <summary>
        /// <para>Name: Old Url</para>
        /// <para>Internal: old_url</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("old_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string OldUrl { get; set; }

        /// <summary>
        /// <para>Name: Redirect Old Url</para>
        /// <para>Internal: redirect_old_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("redirect_old_url")]
        public bool RedirectOldUrl { get; set; }

        /// <summary>
        /// <para>Name: Redirect Type</para>
        /// <para>Internal: redirect_type</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// </summary>
        [JsonPropertyName("redirect_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        public string RedirectType { get; set; }

    }
}
