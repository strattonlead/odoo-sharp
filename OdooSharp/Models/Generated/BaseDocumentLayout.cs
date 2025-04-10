using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("base.document.layout")]
    public partial class BaseDocumentLayout
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
        /// <para>Name: Preview logo</para>
        /// <para>Internal: preview_logo</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("preview_logo")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("preview_logo")]
        public object PreviewLogo { get; set; }

        /// <summary>
        /// <para>Name: Company Tagline</para>
        /// <para>Internal: report_header</para>
        /// <para>Store: no</para>
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
        /// <para>Store: no</para>
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
        /// <para>Store: no</para>
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
        /// <para>Name: Paper format</para>
        /// <para>Internal: paperformat_id</para>
        /// <para>Store: no</para>
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
        /// <para>Store: no</para>
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
        /// <para>Store: no</para>
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
        /// <para>Store: no</para>
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
        /// <para>Store: no</para>
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
        /// <para>Name: Custom Colors</para>
        /// <para>Internal: custom_colors</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("custom_colors")]
        [OdooField("custom_colors")]
        public bool CustomColors { get; set; }

        /// <summary>
        /// <para>Name: Logo Primary Color</para>
        /// <para>Internal: logo_primary_color</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("logo_primary_color")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("logo_primary_color")]
        public string LogoPrimaryColor { get; set; }

        /// <summary>
        /// <para>Name: Logo Secondary Color</para>
        /// <para>Internal: logo_secondary_color</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("logo_secondary_color")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("logo_secondary_color")]
        public string LogoSecondaryColor { get; set; }

        /// <summary>
        /// <para>Name: Layout Background</para>
        /// <para>Internal: layout_background</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
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
        /// <para>Store: no</para>
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
        /// <para>Name: Report Layout</para>
        /// <para>Internal: report_layout_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: report.layout</para>
        /// </summary>
        [JsonPropertyName("report_layout_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("report_layout_id")]
        public int? ReportLayoutId { get; set; }

        /// <summary>
        /// <para>Name: Preview</para>
        /// <para>Internal: preview</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Html</para>
        /// </summary>
        [JsonPropertyName("preview")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("preview")]
        public string Preview { get; set; }

        /// <summary>
        /// <para>Name: Partner</para>
        /// <para>Internal: partner_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.partner</para>
        /// </summary>
        [JsonPropertyName("partner_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("partner_id")]
        public int? PartnerId { get; set; }

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
        /// <para>Name: Website Link</para>
        /// <para>Internal: website</para>
        /// <para>Store: no</para>
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
        /// <para>Name: Company Name</para>
        /// <para>Internal: name</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Name: Country</para>
        /// <para>Internal: country_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("country_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("country_id")]
        public int? CountryId { get; set; }

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
        /// <para>Name: From Invoice</para>
        /// <para>Internal: from_invoice</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("from_invoice")]
        [OdooField("from_invoice")]
        public bool FromInvoice { get; set; }

        /// <summary>
        /// <para>Name: Display QR-code on invoices</para>
        /// <para>Internal: qr_code</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("qr_code")]
        [OdooField("qr_code")]
        public bool QrCode { get; set; }

        /// <summary>
        /// <para>Name: Account Number</para>
        /// <para>Internal: account_number</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("account_number")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// <para>Name: Street</para>
        /// <para>Internal: street</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
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
        /// <para>Readonly: yes</para>
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
        /// <para>Readonly: yes</para>
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
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("city")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("city")]
        public string City { get; set; }

        /// <summary>
        /// <para>Name: Company ID</para>
        /// <para>Internal: company_registry</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("company_registry")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("company_registry")]
        public string CompanyRegistry { get; set; }

        /// <summary>
        /// <para>Name: Banks</para>
        /// <para>Internal: bank_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: res.partner.bank</para>
        /// </summary>
        [JsonPropertyName("bank_ids")]
        [OdooField("bank_ids")]
        public List<int> BankIds { get; set; }

        /// <summary>
        /// <para>Name: Fiscal Country</para>
        /// <para>Internal: account_fiscal_country_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.country</para>
        /// </summary>
        [JsonPropertyName("account_fiscal_country_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("account_fiscal_country_id")]
        public int? AccountFiscalCountryId { get; set; }

        /// <summary>
        /// <para>Name: L10N Din5008 Invoice Date</para>
        /// <para>Internal: l10n_din5008_invoice_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("l10n_din5008_invoice_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("l10n_din5008_invoice_date")]
        public DateTime? L10nDin5008InvoiceDate { get; set; }

        /// <summary>
        /// <para>Name: L10N Din5008 Due Date</para>
        /// <para>Internal: l10n_din5008_due_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("l10n_din5008_due_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("l10n_din5008_due_date")]
        public DateTime? L10nDin5008DueDate { get; set; }

        /// <summary>
        /// <para>Name: L10N Din5008 Delivery Date</para>
        /// <para>Internal: l10n_din5008_delivery_date</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("l10n_din5008_delivery_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("l10n_din5008_delivery_date")]
        public DateTime? L10nDin5008DeliveryDate { get; set; }

    }
}
