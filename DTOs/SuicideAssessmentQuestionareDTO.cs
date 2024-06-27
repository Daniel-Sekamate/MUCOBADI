namespace MUCOBADI.DTOs
{
    public class SuicideAssessmentQuestionareDTO
    {
        public int? QuestionnaireId { get; set; }
        public string? Questionnaire { get; set; }
        public int? QuestionnaireResponseId { get; set; }
        public int?PreAssessmentGuideId { get; set; }
        public double? QuestionnaireResponseScore { get; set; }


    }
}
