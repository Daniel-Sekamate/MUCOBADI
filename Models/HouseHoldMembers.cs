using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class HouseHoldMembers
    {
        public HouseHoldMembers()
        {
            Avat = new HashSet<Avat>();
            BeneficiaryEnrolmentRegisterDetails = new HashSet<BeneficiaryEnrolmentRegisterDetails>();
            BeneficiaryEnrolmentRegisterHeader = new HashSet<BeneficiaryEnrolmentRegisterHeader>();
            BeneficiaryLinkageTrackingToolNew = new HashSet<BeneficiaryLinkageTrackingToolNew>();
            BusinessPlanHeader = new HashSet<BusinessPlanHeader>();
            CaseCare = new HashSet<CaseCare>();
            CaseCareDetail = new HashSet<CaseCareDetail>();
            CaseCareSummary = new HashSet<CaseCareSummary>();
            EcdDirectMemberAttendence = new HashSet<EcdDirectMemberAttendence>();
            GraduationBenchMarkDetail = new HashSet<GraduationBenchMarkDetail>();
            GraduationChecklistHeader = new HashSet<GraduationChecklistHeader>();
            HivTbRisKassessmentTool = new HashSet<HivTbRisKassessmentTool>();
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormExposedInfants = new HashSet<HivTbTrackingFormExposedInfants>();
            HomeVisitServiceReportingToolDetail = new HashSet<HomeVisitServiceReportingToolDetail>();
            Isvatheader = new HashSet<Isvatheader>();
            IsvatincomeEarner = new HashSet<IsvatincomeEarner>();
            MonthlyCaseTrackingRegisterDetail = new HashSet<MonthlyCaseTrackingRegisterDetail>();
            OvcSchoolAttendencyDetails = new HashSet<OvcSchoolAttendencyDetails>();
            ReferralFormCareGiverHouseHoldMember = new HashSet<ReferralForm>();
            ReferralFormHouseHoldMember = new HashSet<ReferralForm>();
            SinoParentingDirectMemberAttendence = new HashSet<SinoParentingDirectMemberAttendence>();
            VslaGroupDirectMembers = new HashSet<VslaGroupDirectMembers>();
        }

        public int HouseHoldMemberId { get; set; }
        public int? HouseHoldId { get; set; }
        public string HouseHoldMemberCode { get; set; }
        public string Surname { get; set; }
        public string Givenname { get; set; }
        public string GenderId { get; set; }
        public DateTime? DoB { get; set; }
        public int? Age { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public int? ProgramParticipationId { get; set; }
        public int? IsCareGiver { get; set; }
        public int? IsEnrolledInSchool { get; set; }
        public int? IsAttendingSchoolRegularly { get; set; }
        public int? EducationLevelId { get; set; }
        public string NameofSchool { get; set; }
        public int? IsOrphaned { get; set; }
        public int? IsChildUnder5Malnourished { get; set; }
        public int? DoesChildHaveBirthCertificate { get; set; }
        public int? IsDisabled { get; set; }
        public string DisabilityDescription { get; set; }
        public int? Ischildimmunised { get; set; }
        public int? HivstatusId { get; set; }
        public int? CurrentlyonArt { get; set; }
        public DateTime? Cohort { get; set; }
        public string Artnumber { get; set; }
        public int? HasanIga { get; set; }
        public int? IsinSavingsGroup { get; set; }
        public int? Isinschoolcompletingapprenticeship { get; set; }
        public DateTime? EnrollmentDate { get; set; }

        public virtual AYesNo CurrentlyonArtNavigation { get; set; }
        public virtual AYesNo DoesChildHaveBirthCertificateNavigation { get; set; }
        public virtual AEducationLevel EducationLevel { get; set; }
        public virtual AGender Gender { get; set; }
        public virtual AYesNo HasanIgaNavigation { get; set; }
        public virtual AHivstatus Hivstatus { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual AYesNo IsAttendingSchoolRegularlyNavigation { get; set; }
        public virtual ACareGiver IsCareGiverNavigation { get; set; }
        public virtual AYesNo IsChildUnder5MalnourishedNavigation { get; set; }
        public virtual AYesNo IsDisabledNavigation { get; set; }
        public virtual AYesNo IsEnrolledInSchoolNavigation { get; set; }
        public virtual AYesNo IsOrphanedNavigation { get; set; }
        public virtual AYesNo IschildimmunisedNavigation { get; set; }
        public virtual AYesNo IsinSavingsGroupNavigation { get; set; }
        public virtual AYesNo IsinschoolcompletingapprenticeshipNavigation { get; set; }
        public virtual AKnownRiskFactors KnownRiskFactor { get; set; }
        public virtual AProgramParticipationStatus ProgramParticipation { get; set; }
        public virtual ICollection<Avat> Avat { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterDetails> BeneficiaryEnrolmentRegisterDetails { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterHeader> BeneficiaryEnrolmentRegisterHeader { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolNew> BeneficiaryLinkageTrackingToolNew { get; set; }
        public virtual ICollection<BusinessPlanHeader> BusinessPlanHeader { get; set; }
        public virtual ICollection<CaseCare> CaseCare { get; set; }
        public virtual ICollection<CaseCareDetail> CaseCareDetail { get; set; }
        public virtual ICollection<CaseCareSummary> CaseCareSummary { get; set; }
        public virtual ICollection<EcdDirectMemberAttendence> EcdDirectMemberAttendence { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetail { get; set; }
        public virtual ICollection<GraduationChecklistHeader> GraduationChecklistHeader { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentTool { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
        public virtual ICollection<HivTbTrackingFormExposedInfants> HivTbTrackingFormExposedInfants { get; set; }
        public virtual ICollection<HomeVisitServiceReportingToolDetail> HomeVisitServiceReportingToolDetail { get; set; }
        public virtual ICollection<Isvatheader> Isvatheader { get; set; }
        public virtual ICollection<IsvatincomeEarner> IsvatincomeEarner { get; set; }
        public virtual ICollection<MonthlyCaseTrackingRegisterDetail> MonthlyCaseTrackingRegisterDetail { get; set; }
        public virtual ICollection<OvcSchoolAttendencyDetails> OvcSchoolAttendencyDetails { get; set; }
        public virtual ICollection<ReferralForm> ReferralFormCareGiverHouseHoldMember { get; set; }
        public virtual ICollection<ReferralForm> ReferralFormHouseHoldMember { get; set; }
        public virtual ICollection<SinoParentingDirectMemberAttendence> SinoParentingDirectMemberAttendence { get; set; }
        public virtual ICollection<VslaGroupDirectMembers> VslaGroupDirectMembers { get; set; }
    }
}
