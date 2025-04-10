using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("survey.user_input.line")]
    public partial class SurveyUserInputLine
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
        /// <para>Name: User Input</para>
        /// <para>Internal: user_input_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: survey.user_input</para>
        /// </summary>
        [JsonPropertyName("user_input_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("user_input_id")]
        public int? UserInputId { get; set; }

        /// <summary>
        /// <para>Name: Survey</para>
        /// <para>Internal: survey_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: survey.survey</para>
        /// </summary>
        [JsonPropertyName("survey_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("survey_id")]
        public int? SurveyId { get; set; }

        /// <summary>
        /// <para>Name: Question</para>
        /// <para>Internal: question_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: survey.question</para>
        /// </summary>
        [JsonPropertyName("question_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("question_id")]
        public int? QuestionId { get; set; }

        /// <summary>
        /// <para>Name: Section</para>
        /// <para>Internal: page_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: survey.question</para>
        /// </summary>
        [JsonPropertyName("page_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("page_id")]
        public int? PageId { get; set; }

        /// <summary>
        /// <para>Name: Sequence</para>
        /// <para>Internal: question_sequence</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("question_sequence")]
        [OdooField("question_sequence")]
        public int QuestionSequence { get; set; }

        /// <summary>
        /// <para>Name: Language</para>
        /// <para>Internal: lang_id</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: res.lang</para>
        /// </summary>
        [JsonPropertyName("lang_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("lang_id")]
        public int? LangId { get; set; }

        /// <summary>
        /// <para>Name: Skipped</para>
        /// <para>Internal: skipped</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("skipped")]
        [OdooField("skipped")]
        public bool Skipped { get; set; }

        /// <summary>
        /// <para>Name: Answer Type</para>
        /// <para>Internal: answer_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [text_box]=Free Text,[char_box]=Text,[numerical_box]=Number,[scale]=Number,[date]=Date,[datetime]=Datetime,[suggestion]=Suggestion</para>
        /// </summary>
        [JsonPropertyName("answer_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("answer_type")]
        public string AnswerType { get; set; }

        /// <summary>
        /// <para>Name: Text answer</para>
        /// <para>Internal: value_char_box</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("value_char_box")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("value_char_box")]
        public string ValueCharBox { get; set; }

        /// <summary>
        /// <para>Name: Numerical answer</para>
        /// <para>Internal: value_numerical_box</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("value_numerical_box")]
        [OdooField("value_numerical_box")]
        public double ValueNumericalBox { get; set; }

        /// <summary>
        /// <para>Name: Scale value</para>
        /// <para>Internal: value_scale</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("value_scale")]
        [OdooField("value_scale")]
        public int ValueScale { get; set; }

        /// <summary>
        /// <para>Name: Date answer</para>
        /// <para>Internal: value_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("value_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("value_date")]
        public DateTime? ValueDate { get; set; }

        /// <summary>
        /// <para>Name: Datetime answer</para>
        /// <para>Internal: value_datetime</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("value_datetime")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("value_datetime")]
        public DateTime? ValueDatetime { get; set; }

        /// <summary>
        /// <para>Name: Free Text answer</para>
        /// <para>Internal: value_text_box</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Text</para>
        /// </summary>
        [JsonPropertyName("value_text_box")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("value_text_box")]
        public string ValueTextBox { get; set; }

        /// <summary>
        /// <para>Name: Suggested answer</para>
        /// <para>Internal: suggested_answer_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: survey.question.answer</para>
        /// </summary>
        [JsonPropertyName("suggested_answer_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("suggested_answer_id")]
        public int? SuggestedAnswerId { get; set; }

        /// <summary>
        /// <para>Name: Row answer</para>
        /// <para>Internal: matrix_row_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: survey.question.answer</para>
        /// </summary>
        [JsonPropertyName("matrix_row_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("matrix_row_id")]
        public int? MatrixRowId { get; set; }

        /// <summary>
        /// <para>Name: Score</para>
        /// <para>Internal: answer_score</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("answer_score")]
        [OdooField("answer_score")]
        public double AnswerScore { get; set; }

        /// <summary>
        /// <para>Name: Correct</para>
        /// <para>Internal: answer_is_correct</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("answer_is_correct")]
        [OdooField("answer_is_correct")]
        public bool AnswerIsCorrect { get; set; }

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
