using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("report.paperformat")]
    public partial class ReportPaperformat
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
        /// <para>Name: Default paper format?</para>
        /// <para>Internal: default</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("default")]
        [OdooField("default")]
        public bool Default { get; set; }

        /// <summary>
        /// <para>Name: Paper size</para>
        /// <para>Internal: format</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [A0]=A0  5   841 x 1189 mm,[A1]=A1  6   594 x 841 mm,[A2]=A2  7   420 x 594 mm,[A3]=A3  8   297 x 420 mm,[A4]=A4  0   210 x 297 mm, 8.26 x 11.69 inches,[A5]=A5  9   148 x 210 mm,[A6]=A6  10  105 x 148 mm,[A7]=A7  11  74 x 105 mm,[A8]=A8  12  52 x 74 mm,[A9]=A9  13  37 x 52 mm,[B0]=B0  14  1000 x 1414 mm,[B1]=B1  15  707 x 1000 mm,[B2]=B2  17  500 x 707 mm,[B3]=B3  18  353 x 500 mm,[B4]=B4  19  250 x 353 mm,[B5]=B5  1   176 x 250 mm, 6.93 x 9.84 inches,[B6]=B6  20  125 x 176 mm,[B7]=B7  21  88 x 125 mm,[B8]=B8  22  62 x 88 mm,[B9]=B9  23  33 x 62 mm,[B10]=B10    16  31 x 44 mm,[C5E]=C5E 24  163 x 229 mm,[Comm10E]=Comm10E 25  105 x 241 mm, U.S. Common 10 Envelope,[DLE]=DLE 26 110 x 220 mm,[Executive]=Executive 4   7.5 x 10 inches, 190.5 x 254 mm,[Folio]=Folio 27  210 x 330 mm,[Ledger]=Ledger  28  431.8 x 279.4 mm,[Legal]=Legal    3   8.5 x 14 inches, 215.9 x 355.6 mm,[Letter]=Letter 2 8.5 x 11 inches, 215.9 x 279.4 mm,[Tabloid]=Tabloid 29 279.4 x 431.8 mm,[custom]=Custom</para>
        /// </summary>
        [JsonPropertyName("format")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("format")]
        public string Format { get; set; }

        /// <summary>
        /// <para>Name: Top Margin (mm)</para>
        /// <para>Internal: margin_top</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("margin_top")]
        [OdooField("margin_top")]
        public double MarginTop { get; set; }

        /// <summary>
        /// <para>Name: Bottom Margin (mm)</para>
        /// <para>Internal: margin_bottom</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("margin_bottom")]
        [OdooField("margin_bottom")]
        public double MarginBottom { get; set; }

        /// <summary>
        /// <para>Name: Left Margin (mm)</para>
        /// <para>Internal: margin_left</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("margin_left")]
        [OdooField("margin_left")]
        public double MarginLeft { get; set; }

        /// <summary>
        /// <para>Name: Right Margin (mm)</para>
        /// <para>Internal: margin_right</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("margin_right")]
        [OdooField("margin_right")]
        public double MarginRight { get; set; }

        /// <summary>
        /// <para>Name: Page height (mm)</para>
        /// <para>Internal: page_height</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("page_height")]
        [OdooField("page_height")]
        public int PageHeight { get; set; }

        /// <summary>
        /// <para>Name: Page width (mm)</para>
        /// <para>Internal: page_width</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("page_width")]
        [OdooField("page_width")]
        public int PageWidth { get; set; }

        /// <summary>
        /// <para>Name: Orientation</para>
        /// <para>Internal: orientation</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [Landscape]=Landscape,[Portrait]=Portrait</para>
        /// </summary>
        [JsonPropertyName("orientation")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("orientation")]
        public string Orientation { get; set; }

        /// <summary>
        /// <para>Name: Display a header line</para>
        /// <para>Internal: header_line</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("header_line")]
        [OdooField("header_line")]
        public bool HeaderLine { get; set; }

        /// <summary>
        /// <para>Name: Header spacing</para>
        /// <para>Internal: header_spacing</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("header_spacing")]
        [OdooField("header_spacing")]
        public int HeaderSpacing { get; set; }

        /// <summary>
        /// <para>Name: Disable smart shrinking</para>
        /// <para>Internal: disable_shrinking</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("disable_shrinking")]
        [OdooField("disable_shrinking")]
        public bool DisableShrinking { get; set; }

        /// <summary>
        /// <para>Name: Output DPI</para>
        /// <para>Internal: dpi</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("dpi")]
        [OdooField("dpi")]
        public int Dpi { get; set; }

        /// <summary>
        /// <para>Name: Associated reports</para>
        /// <para>Internal: report_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: ir.actions.report</para>
        /// </summary>
        [JsonPropertyName("report_ids")]
        [OdooField("report_ids")]
        public List<int> ReportIds { get; set; }

        /// <summary>
        /// <para>Name: Print page width (mm)</para>
        /// <para>Internal: print_page_width</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("print_page_width")]
        [OdooField("print_page_width")]
        public double PrintPageWidth { get; set; }

        /// <summary>
        /// <para>Name: Print page height (mm)</para>
        /// <para>Internal: print_page_height</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("print_page_height")]
        [OdooField("print_page_height")]
        public double PrintPageHeight { get; set; }

        /// <summary>
        /// <para>Name: Use css margins</para>
        /// <para>Internal: css_margins</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("css_margins")]
        [OdooField("css_margins")]
        public bool CssMargins { get; set; }

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

    }
}
