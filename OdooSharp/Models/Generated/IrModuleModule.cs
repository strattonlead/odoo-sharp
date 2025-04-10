using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("ir.module.module")]
    public partial class IrModuleModule
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
        /// <para>Name: Technical Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: Category</para>
        /// <para>Internal: category_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.module.category</para>
        /// </summary>
        [JsonPropertyName("category_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("category_id")]
        public int? CategoryId { get; set; }

        /// <summary>
        /// <para>Name: Module Name</para>
        /// <para>Internal: shortdesc</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("shortdesc")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("shortdesc")]
        public string Shortdesc { get; set; }

        /// <summary>
        /// <para>Name: Summary</para>
        /// <para>Internal: summary</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("summary")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// <para>Name: Description</para>
        /// <para>Internal: description</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("description")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("description")]
        public string Description { get; set; }

        /// <summary>
        /// <para>Name: Description HTML</para>
        /// <para>Internal: description_html</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("description_html")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("description_html")]
        public string DescriptionHtml { get; set; }

        /// <summary>
        /// <para>Name: Author</para>
        /// <para>Internal: author</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("author")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("author")]
        public string Author { get; set; }

        /// <summary>
        /// <para>Name: Maintainer</para>
        /// <para>Internal: maintainer</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("maintainer")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("maintainer")]
        public string Maintainer { get; set; }

        /// <summary>
        /// <para>Name: Contributors</para>
        /// <para>Internal: contributors</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("contributors")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("contributors")]
        public string Contributors { get; set; }

        /// <summary>
        /// <para>Name: Website</para>
        /// <para>Internal: website</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("website")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("website")]
        public string Website { get; set; }

        /// <summary>
        /// <para>Name: Latest Version</para>
        /// <para>Internal: installed_version</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("installed_version")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("installed_version")]
        public string InstalledVersion { get; set; }

        /// <summary>
        /// <para>Name: Installed Version</para>
        /// <para>Internal: latest_version</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("latest_version")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("latest_version")]
        public string LatestVersion { get; set; }

        /// <summary>
        /// <para>Name: Published Version</para>
        /// <para>Internal: published_version</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("published_version")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("published_version")]
        public string PublishedVersion { get; set; }

        /// <summary>
        /// <para>Name: URL</para>
        /// <para>Internal: url</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("url")]
        public string Url { get; set; }

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
        /// <para>Name: Dependencies</para>
        /// <para>Internal: dependencies_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.module.module.dependency</para>
        /// </summary>
        [JsonPropertyName("dependencies_id")]
        [OdooField("dependencies_id")]
        public List<int> DependenciesId { get; set; }

        /// <summary>
        /// <para>Name: Country</para>
        /// <para>Internal: country_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("country_ids")]
        [OdooField("country_ids")]
        public List<int> CountryIds { get; set; }

        /// <summary>
        /// <para>Name: Exclusions</para>
        /// <para>Internal: exclusion_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.module.module.exclusion</para>
        /// </summary>
        [JsonPropertyName("exclusion_ids")]
        [OdooField("exclusion_ids")]
        public List<int> ExclusionIds { get; set; }

        /// <summary>
        /// <para>Name: Automatic Installation</para>
        /// <para>Internal: auto_install</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("auto_install")]
        [OdooField("auto_install")]
        public bool AutoInstall { get; set; }

        /// <summary>
        /// <para>Name: Status</para>
        /// <para>Internal: state</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [uninstallable]=Uninstallable,[uninstalled]=Not Installed,[installed]=Installed,[to upgrade]=To be upgraded,[to remove]=To be removed,[to install]=To be installed</para>
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("state")]
        public string State { get; set; }

        /// <summary>
        /// <para>Name: Demo Data</para>
        /// <para>Internal: demo</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("demo")]
        [OdooField("demo")]
        public bool Demo { get; set; }

        /// <summary>
        /// <para>Name: License</para>
        /// <para>Internal: license</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [GPL-2]=GPL Version 2,[GPL-2 or any later version]=GPL-2 or later version,[GPL-3]=GPL Version 3,[GPL-3 or any later version]=GPL-3 or later version,[AGPL-3]=Affero GPL-3,[LGPL-3]=LGPL Version 3,[Other OSI approved licence]=Other OSI Approved License,[OEEL-1]=Odoo Enterprise Edition License v1.0,[OPL-1]=Odoo Proprietary License v1.0,[Other proprietary]=Other Proprietary</para>
        /// </summary>
        [JsonPropertyName("license")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("license")]
        public string License { get; set; }

        /// <summary>
        /// <para>Name: Menus</para>
        /// <para>Internal: menus_by_module</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("menus_by_module")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("menus_by_module")]
        public string MenusByModule { get; set; }

        /// <summary>
        /// <para>Name: Reports</para>
        /// <para>Internal: reports_by_module</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("reports_by_module")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("reports_by_module")]
        public string ReportsByModule { get; set; }

        /// <summary>
        /// <para>Name: Views</para>
        /// <para>Internal: views_by_module</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("views_by_module")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("views_by_module")]
        public string ViewsByModule { get; set; }

        /// <summary>
        /// <para>Name: Application</para>
        /// <para>Internal: application</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("application")]
        [OdooField("application")]
        public bool Application { get; set; }

        /// <summary>
        /// <para>Name: Icon URL</para>
        /// <para>Internal: icon</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("icon")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// <para>Name: Icon</para>
        /// <para>Internal: icon_image</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("icon_image")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("icon_image")]
        public object IconImage { get; set; }

        /// <summary>
        /// <para>Name: Flag</para>
        /// <para>Internal: icon_flag</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("icon_flag")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("icon_flag")]
        public string IconFlag { get; set; }

        /// <summary>
        /// <para>Name: Odoo Enterprise Module</para>
        /// <para>Internal: to_buy</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("to_buy")]
        [OdooField("to_buy")]
        public bool ToBuy { get; set; }

        /// <summary>
        /// <para>Name: Has Iap</para>
        /// <para>Internal: has_iap</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_iap")]
        [OdooField("has_iap")]
        public bool HasIap { get; set; }

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
        /// <para>Name: Imported Module</para>
        /// <para>Internal: imported</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("imported")]
        [OdooField("imported")]
        public bool Imported { get; set; }

        /// <summary>
        /// <para>Name: Module Type</para>
        /// <para>Internal: module_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [official]=Official Apps,[industries]=Industries</para>
        /// </summary>
        [JsonPropertyName("module_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("module_type")]
        public string ModuleType { get; set; }

        /// <summary>
        /// <para>Name: Is Module Official</para>
        /// <para>Internal: is_module_official</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_module_official")]
        [OdooField("is_module_official")]
        public bool IsModuleOfficial { get; set; }

        /// <summary>
        /// <para>Name: Account Templates</para>
        /// <para>Internal: account_templates</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("account_templates")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("account_templates")]
        public object AccountTemplates { get; set; }

        /// <summary>
        /// <para>Name: Screenshots</para>
        /// <para>Internal: image_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.attachment</para>
        /// </summary>
        [JsonPropertyName("image_ids")]
        [OdooField("image_ids")]
        public List<int> ImageIds { get; set; }

        /// <summary>
        /// <para>Name: Is Installed On Current Website</para>
        /// <para>Internal: is_installed_on_current_website</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_installed_on_current_website")]
        [OdooField("is_installed_on_current_website")]
        public bool IsInstalledOnCurrentWebsite { get; set; }

    }
}
