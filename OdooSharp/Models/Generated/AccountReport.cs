using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("account.report")]
    public partial class AccountReport
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
        /// <para>Name: Lines</para>
        /// <para>Internal: line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.report.line</para>
        /// </summary>
        [JsonPropertyName("line_ids")]
        [OdooField("line_ids")]
        public List<int> LineIds { get; set; }

        /// <summary>
        /// <para>Name: Columns</para>
        /// <para>Internal: column_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.report.column</para>
        /// </summary>
        [JsonPropertyName("column_ids")]
        [OdooField("column_ids")]
        public List<int> ColumnIds { get; set; }

        /// <summary>
        /// <para>Name: Root Report</para>
        /// <para>Internal: root_report_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account.report</para>
        /// </summary>
        [JsonPropertyName("root_report_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("root_report_id")]
        public int? RootReportId { get; set; }

        /// <summary>
        /// <para>Name: Variants</para>
        /// <para>Internal: variant_report_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.report</para>
        /// </summary>
        [JsonPropertyName("variant_report_ids")]
        [OdooField("variant_report_ids")]
        public List<int> VariantReportIds { get; set; }

        /// <summary>
        /// <para>Name: Sections</para>
        /// <para>Internal: section_report_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.report</para>
        /// </summary>
        [JsonPropertyName("section_report_ids")]
        [OdooField("section_report_ids")]
        public List<int> SectionReportIds { get; set; }

        /// <summary>
        /// <para>Name: Section Of</para>
        /// <para>Internal: section_main_report_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.report</para>
        /// </summary>
        [JsonPropertyName("section_main_report_ids")]
        [OdooField("section_main_report_ids")]
        public List<int> SectionMainReportIds { get; set; }

        /// <summary>
        /// <para>Name: Composite Report</para>
        /// <para>Internal: use_sections</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("use_sections")]
        [OdooField("use_sections")]
        public bool UseSections { get; set; }

        /// <summary>
        /// <para>Name: Chart of Accounts</para>
        /// <para>Internal: chart_template</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [de_skr03]=🇩🇪 Germany - German Chart of Accounts SKR03,[de_skr04]=🇩🇪 Germany - German chart of accounts SKR04,[generic_coa]=Vereinigte Staaten von Amerika (Generisch),[ae]=🇦🇪 United Arab Emirates,[ar_base]=🇦🇷 Argentina - Generic Chart of Accounts Argentina Single Taxpayer / Basis,[ar_ex]=🇦🇷 Argentina - Argentine Generic Chart of Accounts for Exempt Individuals,[ar_ri]=🇦🇷 Argentina - Argentine Generic Chart of Accounts for Registered Accountants,[at]=🇦🇹 Austria,[au]=🇦🇺 Australia,[bd]=🇧🇩 Bangladesh,[be_comp]=🇧🇪 Belgium - Unternehmen,[be_asso]=🇧🇪 Belgium - Vereinigungen und Stiftungen,[bf]=🇧🇫 Burkina Faso - SYSCOHADA for Companies,[bf_syscebnl]=🇧🇫 Burkina Faso - SYSCEBNL for Associations,[bg]=🇧🇬 Bulgaria,[bh]=🇧🇭 Bahrain,[bj]=🇧🇯 Benin - SYSCOHADA for Companies,[bj_syscebnl]=🇧🇯 Benin - SYSCEBNL for Associations,[bo]=🇧🇴 Bolivia,[br]=🇧🇷 Brazil,[ca_2023]=🇨🇦 Canada,[cd]=🇨🇩 Congo (DRC) - SYSCOHADA for Companies,[cd_syscebnl]=🇨🇩 Congo (DRC) - SYSCEBNL for Associations,[cf]=🇨🇫 Central African Republic - SYSCOHADA for Companies,[cf_syscebnl]=🇨🇫 Central African Republic - SYSCEBNL for Associations,[cg]=🇨🇬 Congo (Republic) - SYSCOHADA for Companies,[cg_syscebnl]=🇨🇬 Congo (Republic) - SYSCEBNL for Associations,[ch]=🇨🇭 Switzerland,[ci]=🇨🇮 Côte d'Ivoire - SYSCOHADA for Companies,[ci_syscebnl]=🇨🇮 Côte d'Ivoire - SYSCEBNL for Associations,[cl]=🇨🇱 Chile,[cm]=🇨🇲 Cameroon - SYSCOHADA for Companies,[cm_syscebnl]=🇨🇲 Cameroon - SYSCEBNL for Associations,[cn]=🇨🇳 China,[cn_large_bis]=🇨🇳 China - Large Business,[co]=🇨🇴 Colombia,[cr]=🇨🇷 Costa Rica,[cy]=🇨🇾 Cyprus,[cz]=🇨🇿 Czech Republic,[dk]=🇩🇰 Denmark,[do]=🇩🇴 Dominican Republic,[dz]=🇩🇿 Algeria,[ec]=🇪🇨 Ecuador,[ee]=🇪🇪 Estonia,[eg]=🇪🇬 Egypt,[es_pymes]=🇪🇸 Spain - SMEs (2008),[es_assec]=🇪🇸 Spain - Non-profit entities (2008),[es_canary_assoc]=🇪🇸 Spain - Canary Islands - PGCE non-profit entities (2008),[es_canary_full]=🇪🇸 Spain - Canary Islands - Complete (2008),[es_canary_pymes]=🇪🇸 Spain - Canary Islands - SMEs (2008),[es_coop_full]=🇪🇸 Spain - Cooperatives - Complete (2008),[es_coop_pymes]=🇪🇸 Spain - Cooperatives - SMEs (2008),[es_full]=🇪🇸 Spain - Complete (2008),[et]=🇪🇹 Ethiopia,[fi]=🇫🇮 Finland,[fr]=🇫🇷 France,[mc]=🇲🇨 Monaco,[ga]=🇬🇦 Gabon - SYSCOHADA for Companies,[ga_syscebnl]=🇬🇦 Gabon - SYSCEBNL for Associations,[gn]=🇬🇳 Guinea - SYSCOHADA for Companies,[gn_syscebnl]=🇬🇳 Guinea - SYSCEBNL for Associations,[gq]=🇬🇶 Equatorial Guinea - SYSCOHADA for Companies,[gq_syscebnl]=🇬🇶 Equatorial Guinea - SYSCEBNL for Associations,[gr]=🇬🇷 Greece,[gt]=🇬🇹 Guatemala,[gw]=🇬🇼 Guinea-Bissau - SYSCOHADA for Companies,[gw_syscebnl]=🇬🇼 Guinea-Bissau - SYSCEBNL for Associations,[hk]=🇭🇰 Hong Kong,[hn]=🇭🇳 Honduras,[hr]=🇭🇷 Croatia,[hr_kuna]=🇭🇷 Croatia - RRIF-ov računski plan za poduzetnike,[hu]=🇭🇺 Hungary,[id]=🇮🇩 Indonesia,[ie]=🇮🇪 Ireland,[il]=🇮🇱 Israel,[in]=🇮🇳 India,[iq]=🇮🇶 Iraq,[it]=🇮🇹 Italy,[jo_standard]=🇯🇴 Jordan,[jp]=🇯🇵 Japan,[ke]=🇰🇪 Kenya,[km]=🇰🇲 Comoros - SYSCOHADA for Companies,[km_syscebnl]=🇰🇲 Comoros - SYSCEBNL for Associations,[kr]=🇰🇷 South Korea,[kw]=🇰🇼 Kuwait,[kz]=🇰🇿 Kazakhstan,[lb]=🇱🇧 Lebanon,[lt]=🇱🇹 Lithuania,[lu]=🇱🇺 Luxembourg,[lv]=🇱🇻 Latvia,[ma]=🇲🇦 Morocco,[ml]=🇲🇱 Mali - SYSCOHADA for Companies,[ml_syscebnl]=🇲🇱 Mali - SYSCEBNL for Associations,[mn]=🇲🇳 Mongolia,[mt]=🇲🇹 Malta,[mu]=🇲🇺 Mauritius,[mx]=🇲🇽 Mexico,[my]=🇲🇾 Malaysia,[mz]=🇲🇿 Mozambique,[ne]=🇳🇪 Niger - SYSCOHADA for Companies,[ne_syscebnl]=🇳🇪 Niger - SYSCEBNL for Associations,[ng]=🇳🇬 Nigeria,[nl]=🇳🇱 Netherlands,[no]=🇳🇴 Norway,[nz]=🇳🇿 New Zealand,[pa]=🇵🇦 Panama,[pe]=🇵🇪 Peru,[ph]=🇵🇭 Philippines,[pk]=🇵🇰 Pakistan,[pl]=🇵🇱 Poland,[pt]=🇵🇹 Portugal,[qa]=🇶🇦 Qatar,[ro]=🇷🇴 Romania,[rs]=🇷🇸 Serbia,[rw]=🇷🇼 Rwanda,[sa]=🇸🇦 Saudi Arabia,[se]=🇸🇪 Sweden,[se_K2]=🇸🇪 Sweden - Swedish BAS Chart of Account complete K2,[se_K3]=🇸🇪 Sweden - Swedish BAS Chart of Account complete K3,[sg]=🇸🇬 Singapore,[si]=🇸🇮 Slovenia,[sk]=🇸🇰 Slovakia,[sn]=🇸🇳 Senegal - SYSCOHADA for Companies,[sn_syscebnl]=🇸🇳 Senegal - SYSCEBNL for Associations,[syscebnl]=SYSCEBNL,[syscohada]=SYSCOHADA - Revised,[td]=🇹🇩 Chad - SYSCOHADA for Companies,[td_syscebnl]=🇹🇩 Chad - SYSCEBNL for Associations,[tg]=🇹🇬 Togo - SYSCOHADA for Companies,[tg_syscebnl]=🇹🇬 Togo - SYSCEBNL for Associations,[th]=🇹🇭 Thailand,[tn]=🇹🇳 Tunisia,[tr]=🇹🇷 Türkiye,[tw]=🇹🇼 Taiwan,[tz]=🇹🇿 Tanzania,[ua_psbo]=🇺🇦 Ukraine - IFRS Chart of Accounts,[ug]=🇺🇬 Uganda - Uganda Generic Chart of Accounts,[uk]=🇬🇧 United Kingdom,[uy]=🇺🇾 Uruguay - Uruguayan Generic Chart of Accounts,[ve]=🇻🇪 Venezuela,[vn]=🇻🇳 Vietnam,[za]=🇿🇦 South Africa,[zm]=🇿🇲 Zambia</para>
        /// </summary>
        [JsonPropertyName("chart_template")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("chart_template")]
        public string ChartTemplate { get; set; }

        /// <summary>
        /// <para>Name: Country</para>
        /// <para>Internal: country_id</para>
        /// <para>Store: yes</para>
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
        /// <para>Name: Only Tax Exigible Lines</para>
        /// <para>Internal: only_tax_exigible</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("only_tax_exigible")]
        [OdooField("only_tax_exigible")]
        public bool OnlyTaxExigible { get; set; }

        /// <summary>
        /// <para>Name: Availability</para>
        /// <para>Internal: availability_condition</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [country]=Country Matches,[coa]=Chart of Accounts Matches,[always]=Always</para>
        /// </summary>
        [JsonPropertyName("availability_condition")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("availability_condition")]
        public string AvailabilityCondition { get; set; }

        /// <summary>
        /// <para>Name: Load More Limit</para>
        /// <para>Internal: load_more_limit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("load_more_limit")]
        [OdooField("load_more_limit")]
        public int LoadMoreLimit { get; set; }

        /// <summary>
        /// <para>Name: Search Bar</para>
        /// <para>Internal: search_bar</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("search_bar")]
        [OdooField("search_bar")]
        public bool SearchBar { get; set; }

        /// <summary>
        /// <para>Name: Prefix Groups Threshold</para>
        /// <para>Internal: prefix_groups_threshold</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("prefix_groups_threshold")]
        [OdooField("prefix_groups_threshold")]
        public int PrefixGroupsThreshold { get; set; }

        /// <summary>
        /// <para>Name: Integer Rounding</para>
        /// <para>Internal: integer_rounding</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [HALF-UP]=Nearest,[UP]=Up,[DOWN]=Down</para>
        /// </summary>
        [JsonPropertyName("integer_rounding")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("integer_rounding")]
        public string IntegerRounding { get; set; }

        /// <summary>
        /// <para>Name: Default Opening</para>
        /// <para>Internal: default_opening_date_filter</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [this_year]=This Year,[this_quarter]=This Quarter,[this_month]=This Month,[today]=Today,[previous_month]=Last Month,[previous_quarter]=Last Quarter,[previous_year]=Last Year,[this_tax_period]=This Tax Period,[previous_tax_period]=Last Tax Period</para>
        /// </summary>
        [JsonPropertyName("default_opening_date_filter")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("default_opening_date_filter")]
        public string DefaultOpeningDateFilter { get; set; }

        /// <summary>
        /// <para>Name: Currency Translation</para>
        /// <para>Internal: currency_translation</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [current]=Use the most recent rate at the date of the report,[cta]=Use CTA</para>
        /// </summary>
        [JsonPropertyName("currency_translation")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("currency_translation")]
        public string CurrencyTranslation { get; set; }

        /// <summary>
        /// <para>Name: Multi-Company</para>
        /// <para>Internal: filter_multi_company</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [selector]=Use Company Selector,[tax_units]=Use Tax Units</para>
        /// </summary>
        [JsonPropertyName("filter_multi_company")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("filter_multi_company")]
        public string FilterMultiCompany { get; set; }

        /// <summary>
        /// <para>Name: Date Range</para>
        /// <para>Internal: filter_date_range</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_date_range")]
        [OdooField("filter_date_range")]
        public bool FilterDateRange { get; set; }

        /// <summary>
        /// <para>Name: Draft Entries</para>
        /// <para>Internal: filter_show_draft</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_show_draft")]
        [OdooField("filter_show_draft")]
        public bool FilterShowDraft { get; set; }

        /// <summary>
        /// <para>Name: Unreconciled Entries</para>
        /// <para>Internal: filter_unreconciled</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_unreconciled")]
        [OdooField("filter_unreconciled")]
        public bool FilterUnreconciled { get; set; }

        /// <summary>
        /// <para>Name: Unfold All</para>
        /// <para>Internal: filter_unfold_all</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_unfold_all")]
        [OdooField("filter_unfold_all")]
        public bool FilterUnfoldAll { get; set; }

        /// <summary>
        /// <para>Name: Hide lines at 0</para>
        /// <para>Internal: filter_hide_0_lines</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [by_default]=Enabled by Default,[optional]=Optional,[never]=Never</para>
        /// </summary>
        [JsonPropertyName("filter_hide_0_lines")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("filter_hide_0_lines")]
        public string FilterHide0Lines { get; set; }

        /// <summary>
        /// <para>Name: Period Comparison</para>
        /// <para>Internal: filter_period_comparison</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_period_comparison")]
        [OdooField("filter_period_comparison")]
        public bool FilterPeriodComparison { get; set; }

        /// <summary>
        /// <para>Name: Growth Comparison</para>
        /// <para>Internal: filter_growth_comparison</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_growth_comparison")]
        [OdooField("filter_growth_comparison")]
        public bool FilterGrowthComparison { get; set; }

        /// <summary>
        /// <para>Name: Journals</para>
        /// <para>Internal: filter_journals</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_journals")]
        [OdooField("filter_journals")]
        public bool FilterJournals { get; set; }

        /// <summary>
        /// <para>Name: Analytic Filter</para>
        /// <para>Internal: filter_analytic</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_analytic")]
        [OdooField("filter_analytic")]
        public bool FilterAnalytic { get; set; }

        /// <summary>
        /// <para>Name: Account Groups</para>
        /// <para>Internal: filter_hierarchy</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [by_default]=Enabled by Default,[optional]=Optional,[never]=Never</para>
        /// </summary>
        [JsonPropertyName("filter_hierarchy")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("filter_hierarchy")]
        public string FilterHierarchy { get; set; }

        /// <summary>
        /// <para>Name: Account Types</para>
        /// <para>Internal: filter_account_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [both]=Payable and receivable,[payable]=Payable,[receivable]=Receivable,[disabled]=Disabled</para>
        /// </summary>
        [JsonPropertyName("filter_account_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("filter_account_type")]
        public string FilterAccountType { get; set; }

        /// <summary>
        /// <para>Name: Partners</para>
        /// <para>Internal: filter_partner</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_partner")]
        [OdooField("filter_partner")]
        public bool FilterPartner { get; set; }

        /// <summary>
        /// <para>Name: Filter Multivat</para>
        /// <para>Internal: filter_fiscal_position</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_fiscal_position")]
        [OdooField("filter_fiscal_position")]
        public bool FilterFiscalPosition { get; set; }

        /// <summary>
        /// <para>Name: Favorite Filters</para>
        /// <para>Internal: filter_aml_ir_filters</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_aml_ir_filters")]
        [OdooField("filter_aml_ir_filters")]
        public bool FilterAmlIrFilters { get; set; }

        /// <summary>
        /// <para>Name: Budgets</para>
        /// <para>Internal: filter_budgets</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_budgets")]
        [OdooField("filter_budgets")]
        public bool FilterBudgets { get; set; }

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
        /// <para>Name: Horizontal Groups</para>
        /// <para>Internal: horizontal_group_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: account.report.horizontal.group</para>
        /// </summary>
        [JsonPropertyName("horizontal_group_ids")]
        [OdooField("horizontal_group_ids")]
        public List<int> HorizontalGroupIds { get; set; }

        /// <summary>
        /// <para>Name: Annotations</para>
        /// <para>Internal: annotations_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: account.report.annotation</para>
        /// </summary>
        [JsonPropertyName("annotations_ids")]
        [OdooField("annotations_ids")]
        public List<int> AnnotationsIds { get; set; }

        /// <summary>
        /// <para>Name: Custom Handler Model</para>
        /// <para>Internal: custom_handler_model_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: ir.model</para>
        /// </summary>
        [JsonPropertyName("custom_handler_model_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("custom_handler_model_id")]
        public int? CustomHandlerModelId { get; set; }

        /// <summary>
        /// <para>Name: Custom Handler Model Name</para>
        /// <para>Internal: custom_handler_model_name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("custom_handler_model_name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("custom_handler_model_name")]
        public string CustomHandlerModelName { get; set; }

        /// <summary>
        /// <para>Name: Is Account Coverage Report Available</para>
        /// <para>Internal: is_account_coverage_report_available</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_account_coverage_report_available")]
        [OdooField("is_account_coverage_report_available")]
        public bool IsAccountCoverageReportAvailable { get; set; }

        /// <summary>
        /// <para>Name: Start Date</para>
        /// <para>Internal: tax_closing_start_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: yes</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("tax_closing_start_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("tax_closing_start_date")]
        public DateTime? TaxClosingStartDate { get; set; }

        /// <summary>
        /// <para>Name: Send And Print Values</para>
        /// <para>Internal: send_and_print_values</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("send_and_print_values")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("send_and_print_values")]
        public object SendAndPrintValues { get; set; }

        /// <summary>
        /// <para>Name: Analytic Group By</para>
        /// <para>Internal: filter_analytic_groupby</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_analytic_groupby")]
        [OdooField("filter_analytic_groupby")]
        public bool FilterAnalyticGroupby { get; set; }

        /// <summary>
        /// <para>Name: Cash Basis</para>
        /// <para>Internal: filter_cash_basis</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("filter_cash_basis")]
        [OdooField("filter_cash_basis")]
        public bool FilterCashBasis { get; set; }

    }
}
