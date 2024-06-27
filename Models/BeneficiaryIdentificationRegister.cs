using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BeneficiaryIdentificationRegister
    {
        public BeneficiaryIdentificationRegister()
        {
            Avat = new HashSet<Avat>();
            BeneficiaryEnrolmentRegisterHeader = new HashSet<BeneficiaryEnrolmentRegisterHeader>();
            BeneficiaryIdentificationRegisterLog = new HashSet<BeneficiaryIdentificationRegisterLog>();
            BeneficiaryLinkageTrackingToolNew = new HashSet<BeneficiaryLinkageTrackingToolNew>();
            CaseCare = new HashSet<CaseCare>();
            GraduationBenchMark = new HashSet<GraduationBenchMark>();
            GraduationChecklistHeader = new HashSet<GraduationChecklistHeader>();
            HivTbRisKassessmentToolHeader = new HashSet<HivTbRisKassessmentToolHeader>();
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
            HomeVisitServiceReportingToolHeader = new HashSet<HomeVisitServiceReportingToolHeader>();
            HouseHoldMembers = new HashSet<HouseHoldMembers>();
            Hvat = new HashSet<Hvat>();
            MonthlyCaseTrackingRegister = new HashSet<MonthlyCaseTrackingRegister>();
            OvcSchoolAttendencyHeader = new HashSet<OvcSchoolAttendencyHeader>();
            ReferralForm = new HashSet<ReferralForm>();
        }

        public int HouseHoldId { get; set; }
        public string HouseHoldCode { get; set; }
        public DateTime? DateofIdentification { get; set; }
        public int? IdentificationId { get; set; }
        public string OtherIdentificationSource { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public string GenderId { get; set; }
        public DateTime? DoB { get; set; }
        public int? Age { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public int? HivstatusId { get; set; }
        public int? FacilityId { get; set; }
        public int? RegimenCategoryId { get; set; }
        public int? RegimenId { get; set; }
        public int? DispensingModelId { get; set; }
        public int? CurrentlyonArt { get; set; }
        public DateTime? Cohort { get; set; }
        public string Artnumber { get; set; }
        public string Copies { get; set; }
        public int? ViralLoadSuppressedId { get; set; }
        public int? SourceDocumentId { get; set; }
        public string OtherSourceDocument { get; set; }
        public string SourceDocumentUrl { get; set; }
        public string SourceDocumentExt { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedBy { get; set; }
        public string TelephoneContact { get; set; }
        public DateTime? VirallaodDate { get; set; }
        public int? OvcVlrId { get; set; }

        public virtual AYesNo CurrentlyonArtNavigation { get; set; }
        public virtual ADrugDispensingModel DispensingModel { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AFacility Facility { get; set; }
        public virtual AGender Gender { get; set; }
        public virtual AHivstatus Hivstatus { get; set; }
        public virtual ASourceofIdentification Identification { get; set; }
        public virtual AKnownRiskFactors KnownRiskFactor { get; set; }
        public virtual AOvcVlrAndOvcVls OvcVlr { get; set; }
        public virtual AParish Parish { get; set; }
        public virtual ARegimen Regimen { get; set; }
        public virtual ARegimenCategory RegimenCategory { get; set; }
        public virtual ASourceDocument SourceDocument { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual AVillage Village { get; set; }
        public virtual AViralLoadSuppressed ViralLoadSuppressed { get; set; }
        public virtual ICollection<Avat> Avat { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterHeader> BeneficiaryEnrolmentRegisterHeader { get; set; }
        public virtual ICollection<BeneficiaryIdentificationRegisterLog> BeneficiaryIdentificationRegisterLog { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolNew> BeneficiaryLinkageTrackingToolNew { get; set; }
        public virtual ICollection<CaseCare> CaseCare { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMark { get; set; }
        public virtual ICollection<GraduationChecklistHeader> GraduationChecklistHeader { get; set; }
        public virtual ICollection<HivTbRisKassessmentToolHeader> HivTbRisKassessmentToolHeader { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
        public virtual ICollection<HomeVisitServiceReportingToolHeader> HomeVisitServiceReportingToolHeader { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembers { get; set; }
        public virtual ICollection<Hvat> Hvat { get; set; }
        public virtual ICollection<MonthlyCaseTrackingRegister> MonthlyCaseTrackingRegister { get; set; }
        public virtual ICollection<OvcSchoolAttendencyHeader> OvcSchoolAttendencyHeader { get; set; }
        public virtual ICollection<ReferralForm> ReferralForm { get; set; }
    }
}
