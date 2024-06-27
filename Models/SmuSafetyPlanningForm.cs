using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuSafetyPlanningForm
    {
        public SmuSafetyPlanningForm()
        {
            SmuSafetyPlanningFormInternalCopingStrategies = new HashSet<SmuSafetyPlanningFormInternalCopingStrategies>();
            SmuSafetyPlanningFormPeopleProvideDistraction = new HashSet<SmuSafetyPlanningFormPeopleProvideDistraction>();
            SmuSafetyPlanningFormPeopleToAskForHelp = new HashSet<SmuSafetyPlanningFormPeopleToAskForHelp>();
            SmuSafetyPlanningFormProfessionsAgenciesToContact = new HashSet<SmuSafetyPlanningFormProfessionsAgenciesToContact>();
            SmuSafetyPlanningFormWarningSigns = new HashSet<SmuSafetyPlanningFormWarningSigns>();
        }

        public int SafetyPlanningFormId { get; set; }
        public int? OfficeId { get; set; }
        public int? ClientRegistrationId { get; set; }
        public int? SmuGroupId { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string StaffVolunteerName { get; set; }
        public int? SmuAssementGuideId { get; set; }

        public virtual SmuAssessmentGuide SmuAssementGuide { get; set; }
        public virtual SmuGroup SmuGroup { get; set; }
        public virtual ICollection<SmuSafetyPlanningFormInternalCopingStrategies> SmuSafetyPlanningFormInternalCopingStrategies { get; set; }
        public virtual ICollection<SmuSafetyPlanningFormPeopleProvideDistraction> SmuSafetyPlanningFormPeopleProvideDistraction { get; set; }
        public virtual ICollection<SmuSafetyPlanningFormPeopleToAskForHelp> SmuSafetyPlanningFormPeopleToAskForHelp { get; set; }
        public virtual ICollection<SmuSafetyPlanningFormProfessionsAgenciesToContact> SmuSafetyPlanningFormProfessionsAgenciesToContact { get; set; }
        public virtual ICollection<SmuSafetyPlanningFormWarningSigns> SmuSafetyPlanningFormWarningSigns { get; set; }
    }
}
