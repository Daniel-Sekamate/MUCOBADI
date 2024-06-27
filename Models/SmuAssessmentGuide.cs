using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuAssessmentGuide
    {
        public SmuAssessmentGuide()
        {
            SmuAssessmentGuidePh9Questions = new HashSet<SmuAssessmentGuidePh9Questions>();
            SmuSafetyPlanningForm = new HashSet<SmuSafetyPlanningForm>();
            SmuSucideAssementFormHeader = new HashSet<SmuSucideAssementFormHeader>();
        }

        public int AssementGuideId { get; set; }
        public DateTime? DateOfAssessment { get; set; }
        public string StaffVolunteerName { get; set; }
        public string RespondantGenderId { get; set; }
        public int? RespondantAge { get; set; }
        public string SchoolNameOrPrisonName { get; set; }
        public int? SubCountyId { get; set; }
        public int? DistrictId { get; set; }
        public int? RegionId { get; set; }
        public int? ExperiencedThoughtsOffDeadHurting { get; set; }
        public int? ExperiencedGenderBasedViolence { get; set; }
        public int? StressfulEventId { get; set; }
        public int? SmuGroupId { get; set; }
        public int? ClientRegistrationId { get; set; }
        public int? SuicideAssementQuestionOneResponse { get; set; }
        public double? SuicideAssementQuestionOneScore { get; set; }
        public int? SuicideAssementQuestionTwoResponse { get; set; }
        public double? SuicideAssementQuestionTwoScore { get; set; }
        public int? SuicideAssementQuestionThreeResponse { get; set; }
        public double? SuicideAssementQuestionThreeScore { get; set; }
        public int? SuicideAssementQuestionFourResponse { get; set; }
        public double? SuicideAssementQuestionFourScore { get; set; }
        public int? SuicideAssementQuestionFiveResponse { get; set; }
        public double? SuicideAssementQuestionFiveScore { get; set; }
        public int? SuicideAssementQuestionSixResponse { get; set; }
        public double? SuicideAssementQuestionSixScore { get; set; }
        public int? SuicideAssementQuestionSevenResponse { get; set; }
        public double? SuicideAssementQuestionSevenScore { get; set; }
        public int? SuicideAssementQuestionEightResponse { get; set; }
        public double? SuicideAssementQuestionEightScore { get; set; }
        public int? SuicideAssementQuestionNineResponse { get; set; }
        public double? SuicideAssementQuestionNineScore { get; set; }
        public int? SuicideAssementQuestionTenResponse { get; set; }
        public double? SuicideAssementQuestionTenScore { get; set; }
        public double? SuicideAssementTotalScore { get; set; }
        public int? ConsentObtainedYesNo { get; set; }
        public int? SmuProgramId { get; set; }
        public int? SmuOfficeId { get; set; }
        public double? Ph9QuestionScore { get; set; }
        public double? SuicideAssessmentScore { get; set; }

        public virtual SmuClientRegistrationForm ClientRegistration { get; set; }
        public virtual AYesNo ConsentObtainedYesNoNavigation { get; set; }
        public virtual AYesNo ExperiencedGenderBasedViolenceNavigation { get; set; }
        public virtual AYesNo ExperiencedThoughtsOffDeadHurtingNavigation { get; set; }
        public virtual SmuGroup SmuGroup { get; set; }
        public virtual SmuProgram SmuProgram { get; set; }
        public virtual AYesNo StressfulEvent { get; set; }
        public virtual ICollection<SmuAssessmentGuidePh9Questions> SmuAssessmentGuidePh9Questions { get; set; }
        public virtual ICollection<SmuSafetyPlanningForm> SmuSafetyPlanningForm { get; set; }
        public virtual ICollection<SmuSucideAssementFormHeader> SmuSucideAssementFormHeader { get; set; }
    }
}
