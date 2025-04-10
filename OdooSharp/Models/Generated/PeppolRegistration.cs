using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("peppol.registration")]
    public partial class PeppolRegistration
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
        /// <para>Name: EDI mode</para>
        /// <para>Internal: edi_mode</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [demo]=Demo,[test]=Test,[prod]=Live</para>
        /// </summary>
        [JsonPropertyName("edi_mode")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("edi_mode")]
        public string EdiMode { get; set; }

        /// <summary>
        /// <para>Name: EDI user</para>
        /// <para>Internal: edi_user_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: account_edi_proxy_client.user</para>
        /// </summary>
        [JsonPropertyName("edi_user_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("edi_user_id")]
        public int? EdiUserId { get; set; }

        /// <summary>
        /// <para>Name: PEPPOL status</para>
        /// <para>Internal: account_peppol_proxy_state</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [not_registered]=Not registered,[sender]=Can send but not receive,[smp_registration]=Can send, pending registration to receive,[receiver]=Can send and receive,[rejected]=Rejected</para>
        /// </summary>
        [JsonPropertyName("account_peppol_proxy_state")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("account_peppol_proxy_state")]
        public string AccountPeppolProxyState { get; set; }

        /// <summary>
        /// <para>Name: Peppol warnings</para>
        /// <para>Internal: peppol_warnings</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Json</para>
        /// </summary>
        [JsonPropertyName("peppol_warnings")]
        [JsonConverter(typeof(OdooFlexibleJsonObjectConverter))]
        [OdooField("peppol_warnings")]
        public object PeppolWarnings { get; set; }

        /// <summary>
        /// <para>Name: Primary contact email</para>
        /// <para>Internal: contact_email</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("contact_email")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// <para>Name: Mobile number</para>
        /// <para>Internal: phone_number</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("phone_number")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>Name: Peppol e-address (EAS)</para>
        /// <para>Internal: peppol_eas</para>
        /// <para>Store: no</para>
        /// <para>Required: yes</para>
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
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("peppol_endpoint")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("peppol_endpoint")]
        public string PeppolEndpoint { get; set; }

        /// <summary>
        /// <para>Name: Register as a receiver</para>
        /// <para>Internal: smp_registration</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("smp_registration")]
        [OdooField("smp_registration")]
        public bool SmpRegistration { get; set; }

        /// <summary>
        /// <para>Name: Peppol External Provider</para>
        /// <para>Internal: peppol_external_provider</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("peppol_external_provider")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("peppol_external_provider")]
        public string PeppolExternalProvider { get; set; }

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
