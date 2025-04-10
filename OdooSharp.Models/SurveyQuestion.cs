using OdooSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OdooSharp.Models
{
    [OdooModel("survey.question")]
    public partial class SurveyQuestion
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
        /// <para>Name: Title</para>
        /// <para>Internal: title</para>
        /// <para>Store: yes</para>
        /// <para>Required: yes</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("title")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("title")]
        public string Title { get; set; }

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
        /// <para>Name: Placeholder</para>
        /// <para>Internal: question_placeholder</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("question_placeholder")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("question_placeholder")]
        public string QuestionPlaceholder { get; set; }

        /// <summary>
        /// <para>Name: Background Image</para>
        /// <para>Internal: background_image</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Binary</para>
        /// </summary>
        [JsonPropertyName("background_image")]
        [JsonConverter(typeof(OdooByteArrayConverter))]
        [OdooField("background_image")]
        public byte[] BackgroundImage { get; set; }

        /// <summary>
        /// <para>Name: Background Url</para>
        /// <para>Internal: background_image_url</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("background_image_url")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("background_image_url")]
        public string BackgroundImageUrl { get; set; }

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
        /// <para>Name: Scoring Type</para>
        /// <para>Internal: scoring_type</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [no_scoring]=No scoring,[scoring_with_answers_after_page]=Scoring with answers after each page,[scoring_with_answers]=Scoring with answers at the end,[scoring_without_answers]=Scoring without answers</para>
        /// </summary>
        [JsonPropertyName("scoring_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("scoring_type")]
        public string ScoringType { get; set; }

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
        /// <para>Name: Live Session available</para>
        /// <para>Internal: session_available</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("session_available")]
        [OdooField("session_available")]
        public bool SessionAvailable { get; set; }

        /// <summary>
        /// <para>Name: Is a page?</para>
        /// <para>Internal: is_page</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_page")]
        [OdooField("is_page")]
        public bool IsPage { get; set; }

        /// <summary>
        /// <para>Name: Questions</para>
        /// <para>Internal: question_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: survey.question</para>
        /// </summary>
        [JsonPropertyName("question_ids")]
        [OdooField("question_ids")]
        public List<int> QuestionIds { get; set; }

        /// <summary>
        /// <para>Name: Question Selection</para>
        /// <para>Internal: questions_selection</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [all]=All questions,[random]=Randomized per Section</para>
        /// </summary>
        [JsonPropertyName("questions_selection")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("questions_selection")]
        public string QuestionsSelection { get; set; }

        /// <summary>
        /// <para>Name: # Questions Randomly Picked</para>
        /// <para>Internal: random_questions_count</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("random_questions_count")]
        [OdooField("random_questions_count")]
        public int RandomQuestionsCount { get; set; }

        /// <summary>
        /// <para>Name: Page</para>
        /// <para>Internal: page_id</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2One</para>
        /// <para>Relation: survey.question</para>
        /// </summary>
        [JsonPropertyName("page_id")]
        [JsonConverter(typeof(OdooMany2OneIdConverter))]
        [OdooField("page_id")]
        public int? PageId { get; set; }

        /// <summary>
        /// <para>Name: Question Type</para>
        /// <para>Internal: question_type</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [simple_choice]=Multiple choice: only one answer,[multiple_choice]=Multiple choice: multiple answers allowed,[text_box]=Multiple Lines Text Box,[char_box]=Single Line Text Box,[numerical_box]=Numerical Value,[scale]=Scale,[date]=Date,[datetime]=Datetime,[matrix]=Matrix</para>
        /// </summary>
        [JsonPropertyName("question_type")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("question_type")]
        public string QuestionType { get; set; }

        /// <summary>
        /// <para>Name: Scored</para>
        /// <para>Internal: is_scored_question</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_scored_question")]
        [OdooField("is_scored_question")]
        public bool IsScoredQuestion { get; set; }

        /// <summary>
        /// <para>Name: Has image only suggested answer</para>
        /// <para>Internal: has_image_only_suggested_answer</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("has_image_only_suggested_answer")]
        [OdooField("has_image_only_suggested_answer")]
        public bool HasImageOnlySuggestedAnswer { get; set; }

        /// <summary>
        /// <para>Name: Correct numerical answer</para>
        /// <para>Internal: answer_numerical_box</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("answer_numerical_box")]
        [OdooField("answer_numerical_box")]
        public double AnswerNumericalBox { get; set; }

        /// <summary>
        /// <para>Name: Correct date answer</para>
        /// <para>Internal: answer_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("answer_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("answer_date")]
        public DateTime? AnswerDate { get; set; }

        /// <summary>
        /// <para>Name: Correct datetime answer</para>
        /// <para>Internal: answer_datetime</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("answer_datetime")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("answer_datetime")]
        public DateTime? AnswerDatetime { get; set; }

        /// <summary>
        /// <para>Name: Score</para>
        /// <para>Internal: answer_score</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("answer_score")]
        [OdooField("answer_score")]
        public double AnswerScore { get; set; }

        /// <summary>
        /// <para>Name: Save as user email</para>
        /// <para>Internal: save_as_email</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("save_as_email")]
        [OdooField("save_as_email")]
        public bool SaveAsEmail { get; set; }

        /// <summary>
        /// <para>Name: Save as user nickname</para>
        /// <para>Internal: save_as_nickname</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("save_as_nickname")]
        [OdooField("save_as_nickname")]
        public bool SaveAsNickname { get; set; }

        /// <summary>
        /// <para>Name: Types of answers</para>
        /// <para>Internal: suggested_answer_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: survey.question.answer</para>
        /// </summary>
        [JsonPropertyName("suggested_answer_ids")]
        [OdooField("suggested_answer_ids")]
        public List<int> SuggestedAnswerIds { get; set; }

        /// <summary>
        /// <para>Name: Matrix Type</para>
        /// <para>Internal: matrix_subtype</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Selection</para>
        /// <para>Allowed selection values: [simple]=One choice per row,[multiple]=Multiple choices per row</para>
        /// </summary>
        [JsonPropertyName("matrix_subtype")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("matrix_subtype")]
        public string MatrixSubtype { get; set; }

        /// <summary>
        /// <para>Name: Matrix Rows</para>
        /// <para>Internal: matrix_row_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: survey.question.answer</para>
        /// </summary>
        [JsonPropertyName("matrix_row_ids")]
        [OdooField("matrix_row_ids")]
        public List<int> MatrixRowIds { get; set; }

        /// <summary>
        /// <para>Name: Scale Minimum Value</para>
        /// <para>Internal: scale_min</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("scale_min")]
        [OdooField("scale_min")]
        public int ScaleMin { get; set; }

        /// <summary>
        /// <para>Name: Scale Maximum Value</para>
        /// <para>Internal: scale_max</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("scale_max")]
        [OdooField("scale_max")]
        public int ScaleMax { get; set; }

        /// <summary>
        /// <para>Name: Scale Minimum Label</para>
        /// <para>Internal: scale_min_label</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("scale_min_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("scale_min_label")]
        public string ScaleMinLabel { get; set; }

        /// <summary>
        /// <para>Name: Scale Middle Label</para>
        /// <para>Internal: scale_mid_label</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("scale_mid_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("scale_mid_label")]
        public string ScaleMidLabel { get; set; }

        /// <summary>
        /// <para>Name: Scale Maximum Label</para>
        /// <para>Internal: scale_max_label</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("scale_max_label")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("scale_max_label")]
        public string ScaleMaxLabel { get; set; }

        /// <summary>
        /// <para>Name: The question is limited in time</para>
        /// <para>Internal: is_time_limited</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_time_limited")]
        [OdooField("is_time_limited")]
        public bool IsTimeLimited { get; set; }

        /// <summary>
        /// <para>Name: Customized speed rewards</para>
        /// <para>Internal: is_time_customized</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_time_customized")]
        [OdooField("is_time_customized")]
        public bool IsTimeCustomized { get; set; }

        /// <summary>
        /// <para>Name: Time limit (seconds)</para>
        /// <para>Internal: time_limit</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("time_limit")]
        [OdooField("time_limit")]
        public int TimeLimit { get; set; }

        /// <summary>
        /// <para>Name: Show Comments Field</para>
        /// <para>Internal: comments_allowed</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("comments_allowed")]
        [OdooField("comments_allowed")]
        public bool CommentsAllowed { get; set; }

        /// <summary>
        /// <para>Name: Comment Message</para>
        /// <para>Internal: comments_message</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("comments_message")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("comments_message")]
        public string CommentsMessage { get; set; }

        /// <summary>
        /// <para>Name: Comment is an answer</para>
        /// <para>Internal: comment_count_as_answer</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("comment_count_as_answer")]
        [OdooField("comment_count_as_answer")]
        public bool CommentCountAsAnswer { get; set; }

        /// <summary>
        /// <para>Name: Validate entry</para>
        /// <para>Internal: validation_required</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("validation_required")]
        [OdooField("validation_required")]
        public bool ValidationRequired { get; set; }

        /// <summary>
        /// <para>Name: Input must be an email</para>
        /// <para>Internal: validation_email</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("validation_email")]
        [OdooField("validation_email")]
        public bool ValidationEmail { get; set; }

        /// <summary>
        /// <para>Name: Minimum Text Length</para>
        /// <para>Internal: validation_length_min</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("validation_length_min")]
        [OdooField("validation_length_min")]
        public int ValidationLengthMin { get; set; }

        /// <summary>
        /// <para>Name: Maximum Text Length</para>
        /// <para>Internal: validation_length_max</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Integer</para>
        /// </summary>
        [JsonPropertyName("validation_length_max")]
        [OdooField("validation_length_max")]
        public int ValidationLengthMax { get; set; }

        /// <summary>
        /// <para>Name: Minimum value</para>
        /// <para>Internal: validation_min_float_value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("validation_min_float_value")]
        [OdooField("validation_min_float_value")]
        public double ValidationMinFloatValue { get; set; }

        /// <summary>
        /// <para>Name: Maximum value</para>
        /// <para>Internal: validation_max_float_value</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Float</para>
        /// </summary>
        [JsonPropertyName("validation_max_float_value")]
        [OdooField("validation_max_float_value")]
        public double ValidationMaxFloatValue { get; set; }

        /// <summary>
        /// <para>Name: Minimum Date</para>
        /// <para>Internal: validation_min_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("validation_min_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("validation_min_date")]
        public DateTime? ValidationMinDate { get; set; }

        /// <summary>
        /// <para>Name: Maximum Date</para>
        /// <para>Internal: validation_max_date</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Date</para>
        /// </summary>
        [JsonPropertyName("validation_max_date")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("validation_max_date")]
        public DateTime? ValidationMaxDate { get; set; }

        /// <summary>
        /// <para>Name: Minimum Datetime</para>
        /// <para>Internal: validation_min_datetime</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("validation_min_datetime")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("validation_min_datetime")]
        public DateTime? ValidationMinDatetime { get; set; }

        /// <summary>
        /// <para>Name: Maximum Datetime</para>
        /// <para>Internal: validation_max_datetime</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: DateTime</para>
        /// </summary>
        [JsonPropertyName("validation_max_datetime")]
        [JsonConverter(typeof(OdooDateTimeConverter))]
        [OdooField("validation_max_datetime")]
        public DateTime? ValidationMaxDatetime { get; set; }

        /// <summary>
        /// <para>Name: Validation Error</para>
        /// <para>Internal: validation_error_msg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("validation_error_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("validation_error_msg")]
        public string ValidationErrorMsg { get; set; }

        /// <summary>
        /// <para>Name: Mandatory Answer</para>
        /// <para>Internal: constr_mandatory</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("constr_mandatory")]
        [OdooField("constr_mandatory")]
        public bool ConstrMandatory { get; set; }

        /// <summary>
        /// <para>Name: Error message</para>
        /// <para>Internal: constr_error_msg</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Char</para>
        /// </summary>
        [JsonPropertyName("constr_error_msg")]
        [JsonConverter(typeof(OdooFlexibleStringConverter))]
        [OdooField("constr_error_msg")]
        public string ConstrErrorMsg { get; set; }

        /// <summary>
        /// <para>Name: Answers</para>
        /// <para>Internal: user_input_line_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: One2Many</para>
        /// <para>Relation: survey.user_input.line</para>
        /// </summary>
        [JsonPropertyName("user_input_line_ids")]
        [OdooField("user_input_line_ids")]
        public List<int> UserInputLineIds { get; set; }

        /// <summary>
        /// <para>Name: Triggering Questions</para>
        /// <para>Internal: triggering_question_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: survey.question</para>
        /// </summary>
        [JsonPropertyName("triggering_question_ids")]
        [OdooField("triggering_question_ids")]
        public List<int> TriggeringQuestionIds { get; set; }

        /// <summary>
        /// <para>Name: Allowed Triggering Questions</para>
        /// <para>Internal: allowed_triggering_question_ids</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: survey.question</para>
        /// </summary>
        [JsonPropertyName("allowed_triggering_question_ids")]
        [OdooField("allowed_triggering_question_ids")]
        public List<int> AllowedTriggeringQuestionIds { get; set; }

        /// <summary>
        /// <para>Name: Is misplaced?</para>
        /// <para>Internal: is_placed_before_trigger</para>
        /// <para>Store: no</para>
        /// <para>Required: no</para>
        /// <para>Readonly: yes</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Boolean</para>
        /// </summary>
        [JsonPropertyName("is_placed_before_trigger")]
        [OdooField("is_placed_before_trigger")]
        public bool IsPlacedBeforeTrigger { get; set; }

        /// <summary>
        /// <para>Name: Triggering Answers</para>
        /// <para>Internal: triggering_answer_ids</para>
        /// <para>Store: yes</para>
        /// <para>Required: no</para>
        /// <para>Readonly: no</para>
        /// <para>Company Dependent: no</para>
        /// <para>Field type: Many2Many</para>
        /// <para>Relation: survey.question.answer</para>
        /// </summary>
        [JsonPropertyName("triggering_answer_ids")]
        [OdooField("triggering_answer_ids")]
        public List<int> TriggeringAnswerIds { get; set; }

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
