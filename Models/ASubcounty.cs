using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ASubcounty
    {
        public ASubcounty()
        {
            AParish = new HashSet<AParish>();
            Avat = new HashSet<Avat>();
            BeneficiaryEnrolmentRegisterHeader = new HashSet<BeneficiaryEnrolmentRegisterHeader>();
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            BeneficiaryLinkageTrackingTool = new HashSet<BeneficiaryLinkageTrackingTool>();
            BeneficiaryLinkageTrackingToolNew = new HashSet<BeneficiaryLinkageTrackingToolNew>();
            BusinessPlanHeader = new HashSet<BusinessPlanHeader>();
            CaseCare = new HashSet<CaseCare>();
            CommunityTbSensitization = new HashSet<CommunityTbSensitization>();
            CommunityTrainingRegister = new HashSet<CommunityTrainingRegister>();
            EcdAttendenceRegister = new HashSet<EcdAttendenceRegister>();
            GraduationBenchMark = new HashSet<GraduationBenchMark>();
            HivTbRisKassessmentToolHeader = new HashSet<HivTbRisKassessmentToolHeader>();
            HivTbTrackingFormCurrentCarePointSubCounty = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormSubcounty = new HashSet<HivTbTrackingForm>();
            HomeVisitServiceReportingToolHeader = new HashSet<HomeVisitServiceReportingToolHeader>();
            Hvat = new HashSet<Hvat>();
            InterventionAttendanceForm = new HashSet<InterventionAttendanceForm>();
            Isvatheader = new HashSet<Isvatheader>();
            MonthlyCaseTrackingRegister = new HashSet<MonthlyCaseTrackingRegister>();
            Nmnquestionaire = new HashSet<Nmnquestionaire>();
            OvcSchoolAttendencyHeader = new HashSet<OvcSchoolAttendencyHeader>();
            ReferralForm = new HashSet<ReferralForm>();
            SinoParentingAttendenceRegister = new HashSet<SinoParentingAttendenceRegister>();
            SmuClientRegistrationForm = new HashSet<SmuClientRegistrationForm>();
            SmuGroup = new HashSet<SmuGroup>();
            VslaGroupComposition = new HashSet<VslaGroupComposition>();
            VslaGroupShareOutHeader = new HashSet<VslaGroupShareOutHeader>();
        }

        public int SubcountyId { get; set; }
        public int? DistrictId { get; set; }
        public string SubcountyDescription { get; set; }
        public string SubCountyCode { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual ICollection<AParish> AParish { get; set; }
        public virtual ICollection<Avat> Avat { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterHeader> BeneficiaryEnrolmentRegisterHeader { get; set; }
        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingTool> BeneficiaryLinkageTrackingTool { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolNew> BeneficiaryLinkageTrackingToolNew { get; set; }
        public virtual ICollection<BusinessPlanHeader> BusinessPlanHeader { get; set; }
        public virtual ICollection<CaseCare> CaseCare { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitization { get; set; }
        public virtual ICollection<CommunityTrainingRegister> CommunityTrainingRegister { get; set; }
        public virtual ICollection<EcdAttendenceRegister> EcdAttendenceRegister { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMark { get; set; }
        public virtual ICollection<HivTbRisKassessmentToolHeader> HivTbRisKassessmentToolHeader { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormCurrentCarePointSubCounty { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormSubcounty { get; set; }
        public virtual ICollection<HomeVisitServiceReportingToolHeader> HomeVisitServiceReportingToolHeader { get; set; }
        public virtual ICollection<Hvat> Hvat { get; set; }
        public virtual ICollection<InterventionAttendanceForm> InterventionAttendanceForm { get; set; }
        public virtual ICollection<Isvatheader> Isvatheader { get; set; }
        public virtual ICollection<MonthlyCaseTrackingRegister> MonthlyCaseTrackingRegister { get; set; }
        public virtual ICollection<Nmnquestionaire> Nmnquestionaire { get; set; }
        public virtual ICollection<OvcSchoolAttendencyHeader> OvcSchoolAttendencyHeader { get; set; }
        public virtual ICollection<ReferralForm> ReferralForm { get; set; }
        public virtual ICollection<SinoParentingAttendenceRegister> SinoParentingAttendenceRegister { get; set; }
        public virtual ICollection<SmuClientRegistrationForm> SmuClientRegistrationForm { get; set; }
        public virtual ICollection<SmuGroup> SmuGroup { get; set; }
        public virtual ICollection<VslaGroupComposition> VslaGroupComposition { get; set; }
        public virtual ICollection<VslaGroupShareOutHeader> VslaGroupShareOutHeader { get; set; }
    }
}
