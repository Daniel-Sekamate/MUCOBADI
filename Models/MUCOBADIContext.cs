using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
<<<<<<< HEAD

=======
using Microsoft.Extensions.Configuration;
using System.IO;
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
#nullable disable

namespace MUCOBADI.Models
{
    public partial class MUCOBADIContext : DbContext
    {
        public MUCOBADIContext()
        {
        }

        public MUCOBADIContext(DbContextOptions<MUCOBADIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AActivityType> AActivityType { get; set; }
        public virtual DbSet<AAdministrationPhase> AAdministrationPhase { get; set; }
        public virtual DbSet<AAdolescentEnrolledAttendingSchool> AAdolescentEnrolledAttendingSchool { get; set; }
        public virtual DbSet<AAdolescentHealthServiceReferred> AAdolescentHealthServiceReferred { get; set; }
        public virtual DbSet<AAdolescentIssueOfAbuse> AAdolescentIssueOfAbuse { get; set; }
        public virtual DbSet<AAgeCategory> AAgeCategory { get; set; }
        public virtual DbSet<AAgreeDisagree> AAgreeDisagree { get; set; }
        public virtual DbSet<AAssetIncome> AAssetIncome { get; set; }
        public virtual DbSet<AAttendency> AAttendency { get; set; }
        public virtual DbSet<ABusinessPlanQuestion> ABusinessPlanQuestion { get; set; }
        public virtual DbSet<ABusinessVentureCapitalInvestment> ABusinessVentureCapitalInvestment { get; set; }
        public virtual DbSet<ACandidentClassCompleted> ACandidentClassCompleted { get; set; }
        public virtual DbSet<ACareGiver> ACareGiver { get; set; }
        public virtual DbSet<ACaseCategory> ACaseCategory { get; set; }
        public virtual DbSet<ACaseCategoryItem> ACaseCategoryItem { get; set; }
        public virtual DbSet<ACaseNatureReported> ACaseNatureReported { get; set; }
        public virtual DbSet<ACasePlan> ACasePlan { get; set; }
        public virtual DbSet<ACasePlanStaus> ACasePlanStaus { get; set; }
        public virtual DbSet<ACategoryofResidence> ACategoryofResidence { get; set; }
        public virtual DbSet<AChildAbuseOccurances> AChildAbuseOccurances { get; set; }
        public virtual DbSet<ACientClassification> ACientClassification { get; set; }
        public virtual DbSet<AClientCareModality> AClientCareModality { get; set; }
        public virtual DbSet<AClientMemberStatus> AClientMemberStatus { get; set; }
        public virtual DbSet<AContacts> AContacts { get; set; }
        public virtual DbSet<ACountry> ACountry { get; set; }
        public virtual DbSet<ACurrenBusinessOpportunity> ACurrenBusinessOpportunity { get; set; }
        public virtual DbSet<ACurrenBusinessRisk> ACurrenBusinessRisk { get; set; }
        public virtual DbSet<ACurrentClass> ACurrentClass { get; set; }
        public virtual DbSet<ADailyMeals> ADailyMeals { get; set; }
        public virtual DbSet<ADeliveryMethod> ADeliveryMethod { get; set; }
        public virtual DbSet<ADistrict> ADistrict { get; set; }
        public virtual DbSet<ADrugDispensingModality> ADrugDispensingModality { get; set; }
        public virtual DbSet<ADrugDispensingModel> ADrugDispensingModel { get; set; }
        public virtual DbSet<AEconomicActivity> AEconomicActivity { get; set; }
        public virtual DbSet<AEducationLevel> AEducationLevel { get; set; }
        public virtual DbSet<AEidCascade> AEidCascade { get; set; }
        public virtual DbSet<AEnrolledHouseholdStatus> AEnrolledHouseholdStatus { get; set; }
        public virtual DbSet<AExpensePayment> AExpensePayment { get; set; }
        public virtual DbSet<AFacility> AFacility { get; set; }
        public virtual DbSet<AFacilityMigrated> AFacilityMigrated { get; set; }
        public virtual DbSet<AFeedingStatus> AFeedingStatus { get; set; }
        public virtual DbSet<AFinancialYear> AFinancialYear { get; set; }
        public virtual DbSet<AFollowupMeans> AFollowupMeans { get; set; }
        public virtual DbSet<AFoodConsumedSource> AFoodConsumedSource { get; set; }
        public virtual DbSet<AFoodGroups> AFoodGroups { get; set; }
        public virtual DbSet<AGender> AGender { get; set; }
        public virtual DbSet<AGenderBasedViolence> AGenderBasedViolence { get; set; }
        public virtual DbSet<AGraduationCriteria> AGraduationCriteria { get; set; }
        public virtual DbSet<AGroupCycle> AGroupCycle { get; set; }
        public virtual DbSet<AGroupMemberStatus> AGroupMemberStatus { get; set; }
        public virtual DbSet<AGroupPosition> AGroupPosition { get; set; }
        public virtual DbSet<AGroupType> AGroupType { get; set; }
        public virtual DbSet<AGroups> AGroups { get; set; }
        public virtual DbSet<AHasDisability> AHasDisability { get; set; }
        public virtual DbSet<AHhBeneficiaryAgeCategory> AHhBeneficiaryAgeCategory { get; set; }
        public virtual DbSet<AHhapplicableOptions> AHhapplicableOptions { get; set; }
        public virtual DbSet<AHhassessmentStatus> AHhassessmentStatus { get; set; }
        public virtual DbSet<AHhassets> AHhassets { get; set; }
        public virtual DbSet<AHhchildAbuse> AHhchildAbuse { get; set; }
        public virtual DbSet<AHhchildrenComplications> AHhchildrenComplications { get; set; }
        public virtual DbSet<AHheducationLevel> AHheducationLevel { get; set; }
        public virtual DbSet<AHhincome> AHhincome { get; set; }
        public virtual DbSet<AHhincomeSource> AHhincomeSource { get; set; }
        public virtual DbSet<AHhincurredExpenses> AHhincurredExpenses { get; set; }
        public virtual DbSet<AHhknownHivstatus> AHhknownHivstatus { get; set; }
        public virtual DbSet<AHhpreSchoolNotEnrolled> AHhpreSchoolNotEnrolled { get; set; }
        public virtual DbSet<AHhtreatmentAdherance> AHhtreatmentAdherance { get; set; }
        public virtual DbSet<AHhviralLoadBloodTest> AHhviralLoadBloodTest { get; set; }
        public virtual DbSet<AHhviralLoadSuppressed> AHhviralLoadSuppressed { get; set; }
        public virtual DbSet<AHivstatus> AHivstatus { get; set; }
        public virtual DbSet<AHomeVisitReason> AHomeVisitReason { get; set; }
        public virtual DbSet<AHomeVisitServicesNeeded> AHomeVisitServicesNeeded { get; set; }
        public virtual DbSet<AImplementationMethod> AImplementationMethod { get; set; }
        public virtual DbSet<AImplementingPartner> AImplementingPartner { get; set; }
        public virtual DbSet<AIndicators> AIndicators { get; set; }
        public virtual DbSet<AInfectionWays> AInfectionWays { get; set; }
        public virtual DbSet<AInterventionAttendance> AInterventionAttendance { get; set; }
        public virtual DbSet<AInterventionType> AInterventionType { get; set; }
        public virtual DbSet<AJobCausedHarm> AJobCausedHarm { get; set; }
        public virtual DbSet<AKnownRiskFactors> AKnownRiskFactors { get; set; }
        public virtual DbSet<AKnownRiskFactors2> AKnownRiskFactors2 { get; set; }
        public virtual DbSet<AKnownRiskFactorsBinding> AKnownRiskFactorsBinding { get; set; }
        public virtual DbSet<ALinkageServiceCategory> ALinkageServiceCategory { get; set; }
        public virtual DbSet<AMalnutritionSigns> AMalnutritionSigns { get; set; }
        public virtual DbSet<AMaritalStatus> AMaritalStatus { get; set; }
        public virtual DbSet<AMemberBenefits> AMemberBenefits { get; set; }
        public virtual DbSet<AMonth> AMonth { get; set; }
        public virtual DbSet<ANatureofResidence> ANatureofResidence { get; set; }
        public virtual DbSet<ANmnSampledFor> ANmnSampledFor { get; set; }
        public virtual DbSet<ANmnSectionOneQuestion> ANmnSectionOneQuestion { get; set; }
        public virtual DbSet<ANmnSectionTwoAnswer> ANmnSectionTwoAnswer { get; set; }
        public virtual DbSet<ANmnSectionTwoQuestion> ANmnSectionTwoQuestion { get; set; }
        public virtual DbSet<ANonAdherence> ANonAdherence { get; set; }
        public virtual DbSet<ANotSuppressingReason> ANotSuppressingReason { get; set; }
        public virtual DbSet<AOvcVlrAndOvcVls> AOvcVlrAndOvcVls { get; set; }
        public virtual DbSet<AOvcserviceProvider> AOvcserviceProvider { get; set; }
        public virtual DbSet<AParentingGroupSession> AParentingGroupSession { get; set; }
        public virtual DbSet<AParentingGroupSessionType> AParentingGroupSessionType { get; set; }
        public virtual DbSet<AParish> AParish { get; set; }
        public virtual DbSet<APcrTest> APcrTest { get; set; }
        public virtual DbSet<APersonContacted> APersonContacted { get; set; }
        public virtual DbSet<APosition> APosition { get; set; }
        public virtual DbSet<APriorityArea> APriorityArea { get; set; }
        public virtual DbSet<APriorityAreaCodes> APriorityAreaCodes { get; set; }
        public virtual DbSet<AProgramParticipationStatus> AProgramParticipationStatus { get; set; }
        public virtual DbSet<AQuarter> AQuarter { get; set; }
        public virtual DbSet<AReasonForBorrowingLoan> AReasonForBorrowingLoan { get; set; }
        public virtual DbSet<AReasonForTreatmentInterruption> AReasonForTreatmentInterruption { get; set; }
        public virtual DbSet<AReasonsForNonOptimization> AReasonsForNonOptimization { get; set; }
        public virtual DbSet<AReferralServices> AReferralServices { get; set; }
        public virtual DbSet<AReferredDisability> AReferredDisability { get; set; }
        public virtual DbSet<ARegimen> ARegimen { get; set; }
        public virtual DbSet<ARegimenCategory> ARegimenCategory { get; set; }
        public virtual DbSet<ARegion> ARegion { get; set; }
        public virtual DbSet<ARegistrationStatus> ARegistrationStatus { get; set; }
        public virtual DbSet<ARelationship> ARelationship { get; set; }
        public virtual DbSet<ARequestedTestType> ARequestedTestType { get; set; }
        public virtual DbSet<AResults> AResults { get; set; }
        public virtual DbSet<ARiskLevelRating> ARiskLevelRating { get; set; }
        public virtual DbSet<ASavingScheme> ASavingScheme { get; set; }
        public virtual DbSet<ASchoolEnrolment> ASchoolEnrolment { get; set; }
        public virtual DbSet<ASchoolNotProgressingReason> ASchoolNotProgressingReason { get; set; }
        public virtual DbSet<ASelfProtection> ASelfProtection { get; set; }
        public virtual DbSet<AServiceCategory> AServiceCategory { get; set; }
        public virtual DbSet<AServiceLinkedTo> AServiceLinkedTo { get; set; }
        public virtual DbSet<AServiceProvided> AServiceProvided { get; set; }
        public virtual DbSet<AServiceProvider> AServiceProvider { get; set; }
        public virtual DbSet<AServiceReceived> AServiceReceived { get; set; }
        public virtual DbSet<ASourceDocument> ASourceDocument { get; set; }
        public virtual DbSet<ASourceofIdentification> ASourceofIdentification { get; set; }
        public virtual DbSet<ASpecialAgeClassification> ASpecialAgeClassification { get; set; }
        public virtual DbSet<AStableShelter> AStableShelter { get; set; }
        public virtual DbSet<AStartBusinessQuestion> AStartBusinessQuestion { get; set; }
        public virtual DbSet<AStrategiesForImprovingTreatmentContinuity> AStrategiesForImprovingTreatmentContinuity { get; set; }
        public virtual DbSet<ASubResults> ASubResults { get; set; }
        public virtual DbSet<ASubcounty> ASubcounty { get; set; }
        public virtual DbSet<ATargets> ATargets { get; set; }
        public virtual DbSet<ATargetsLog> ATargetsLog { get; set; }
        public virtual DbSet<ATbScreeningVenue> ATbScreeningVenue { get; set; }
        public virtual DbSet<ATbclientRefered> ATbclientRefered { get; set; }
        public virtual DbSet<ATbtestResult> ATbtestResult { get; set; }
        public virtual DbSet<ATbtreatment> ATbtreatment { get; set; }
        public virtual DbSet<ATbtreatmentDuration> ATbtreatmentDuration { get; set; }
        public virtual DbSet<ATerm> ATerm { get; set; }
        public virtual DbSet<ATrainingSession> ATrainingSession { get; set; }
        public virtual DbSet<ATrainningCurriculum> ATrainningCurriculum { get; set; }
        public virtual DbSet<ATuberclosisTreatment> ATuberclosisTreatment { get; set; }
        public virtual DbSet<AVillage> AVillage { get; set; }
        public virtual DbSet<AViralLoadLevel> AViralLoadLevel { get; set; }
        public virtual DbSet<AViralLoadResults> AViralLoadResults { get; set; }
        public virtual DbSet<AViralLoadSuppressed> AViralLoadSuppressed { get; set; }
        public virtual DbSet<AVslaGroupTrainer> AVslaGroupTrainer { get; set; }
        public virtual DbSet<AYesNo> AYesNo { get; set; }
        public virtual DbSet<AatestView> AatestView { get; set; }
        public virtual DbSet<Apiupload> Apiupload { get; set; }
        public virtual DbSet<AspNetEmailConfirmationCode> AspNetEmailConfirmationCode { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Avat> Avat { get; set; }
        public virtual DbSet<BeneficiaryEnrolmentRegisterDetails> BeneficiaryEnrolmentRegisterDetails { get; set; }
        public virtual DbSet<BeneficiaryEnrolmentRegisterHeader> BeneficiaryEnrolmentRegisterHeader { get; set; }
        public virtual DbSet<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual DbSet<BeneficiaryIdentificationRegisterLog> BeneficiaryIdentificationRegisterLog { get; set; }
        public virtual DbSet<BeneficiaryLinkageTrackingTool> BeneficiaryLinkageTrackingTool { get; set; }
        public virtual DbSet<BeneficiaryLinkageTrackingToolDirectMember> BeneficiaryLinkageTrackingToolDirectMember { get; set; }
        public virtual DbSet<BeneficiaryLinkageTrackingToolIndirectMember> BeneficiaryLinkageTrackingToolIndirectMember { get; set; }
        public virtual DbSet<BeneficiaryLinkageTrackingToolNew> BeneficiaryLinkageTrackingToolNew { get; set; }
        public virtual DbSet<BusinessPlanDetail> BusinessPlanDetail { get; set; }
        public virtual DbSet<BusinessPlanHeader> BusinessPlanHeader { get; set; }
        public virtual DbSet<BusinessTrackingLedger> BusinessTrackingLedger { get; set; }
        public virtual DbSet<BusinessTrackingLedgerMoc> BusinessTrackingLedgerMoc { get; set; }
        public virtual DbSet<BusinessTrackingLedgerSue> BusinessTrackingLedgerSue { get; set; }
        public virtual DbSet<CaseCare> CaseCare { get; set; }
        public virtual DbSet<CaseCareDetail> CaseCareDetail { get; set; }
        public virtual DbSet<CaseCareDetailPlan> CaseCareDetailPlan { get; set; }
        public virtual DbSet<CaseCareSummary> CaseCareSummary { get; set; }
        public virtual DbSet<CommunityTbSensitization> CommunityTbSensitization { get; set; }
        public virtual DbSet<CommunityTrainingRegister> CommunityTrainingRegister { get; set; }
        public virtual DbSet<CommunityTrainingRegisterDirectMember> CommunityTrainingRegisterDirectMember { get; set; }
        public virtual DbSet<CommunityTrainingRegisterIndirectMember> CommunityTrainingRegisterIndirectMember { get; set; }
        public virtual DbSet<EcdAttendenceRegister> EcdAttendenceRegister { get; set; }
        public virtual DbSet<EcdDirectMemberAttendence> EcdDirectMemberAttendence { get; set; }
        public virtual DbSet<EcdDirectMemberDetail> EcdDirectMemberDetail { get; set; }
        public virtual DbSet<EcdIndirectMemberAttendence> EcdIndirectMemberAttendence { get; set; }
        public virtual DbSet<EcdIndirectMemberDetail> EcdIndirectMemberDetail { get; set; }
        public virtual DbSet<Ecdgroups3> Ecdgroups3 { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<GraduationBenchMark> GraduationBenchMark { get; set; }
        public virtual DbSet<GraduationBenchMarkDetail> GraduationBenchMarkDetail { get; set; }
        public virtual DbSet<GraduationChecklistDetail> GraduationChecklistDetail { get; set; }
        public virtual DbSet<GraduationChecklistHeader> GraduationChecklistHeader { get; set; }
        public virtual DbSet<HivTbRisKassessmentTool> HivTbRisKassessmentTool { get; set; }
        public virtual DbSet<HivTbRisKassessmentToolHeader> HivTbRisKassessmentToolHeader { get; set; }
        public virtual DbSet<HivTbTrackingForm> HivTbTrackingForm { get; set; }
        public virtual DbSet<HivTbTrackingFormExposedInfants> HivTbTrackingFormExposedInfants { get; set; }
        public virtual DbSet<HomeVisitServiceReportingToolDetail> HomeVisitServiceReportingToolDetail { get; set; }
        public virtual DbSet<HomeVisitServiceReportingToolHeader> HomeVisitServiceReportingToolHeader { get; set; }
        public virtual DbSet<HouseHoldMembers> HouseHoldMembers { get; set; }
        public virtual DbSet<HouseHoldMembers1> HouseHoldMembers1 { get; set; }
        public virtual DbSet<HouseHoldMembersLog> HouseHoldMembersLog { get; set; }
        public virtual DbSet<Hvat> Hvat { get; set; }
        public virtual DbSet<InterventionAttendanceForm> InterventionAttendanceForm { get; set; }
        public virtual DbSet<InterventionAttendanceFormDetail> InterventionAttendanceFormDetail { get; set; }
        public virtual DbSet<InterventionAttendanceFormInstructor> InterventionAttendanceFormInstructor { get; set; }
        public virtual DbSet<IsvatcurrentBusinessOpportunity> IsvatcurrentBusinessOpportunity { get; set; }
        public virtual DbSet<IsvatcurrentBusinessRisk> IsvatcurrentBusinessRisk { get; set; }
        public virtual DbSet<IsvatgeneratedProfit> IsvatgeneratedProfit { get; set; }
        public virtual DbSet<Isvatheader> Isvatheader { get; set; }
        public virtual DbSet<IsvatincomeEarner> IsvatincomeEarner { get; set; }
        public virtual DbSet<IsvatincomeOwnership> IsvatincomeOwnership { get; set; }
        public virtual DbSet<Isvatloss> Isvatloss { get; set; }
        public virtual DbSet<IsvatstartBusinessAnswer> IsvatstartBusinessAnswer { get; set; }
        public virtual DbSet<IsvatworkingCapital> IsvatworkingCapital { get; set; }
        public virtual DbSet<JourneysGroups3> JourneysGroups3 { get; set; }
        public virtual DbSet<MonthlyCaseTrackingRegister> MonthlyCaseTrackingRegister { get; set; }
        public virtual DbSet<MonthlyCaseTrackingRegisterDetail> MonthlyCaseTrackingRegisterDetail { get; set; }
        public virtual DbSet<MonthlyHouseholdVisit> MonthlyHouseholdVisit { get; set; }
        public virtual DbSet<Nmnquestionaire> Nmnquestionaire { get; set; }
        public virtual DbSet<NmnquestionaireSectionOne> NmnquestionaireSectionOne { get; set; }
        public virtual DbSet<NmnquestionaireSectionTwo> NmnquestionaireSectionTwo { get; set; }
        public virtual DbSet<NonSupressingCalhiv> NonSupressingCalhiv { get; set; }
        public virtual DbSet<OvcSchoolAttendencyDetails> OvcSchoolAttendencyDetails { get; set; }
        public virtual DbSet<OvcSchoolAttendencyHeader> OvcSchoolAttendencyHeader { get; set; }
        public virtual DbSet<ProjectIndicatorTargetsDetails> ProjectIndicatorTargetsDetails { get; set; }
        public virtual DbSet<ProjectIndicatorTargetsHeader> ProjectIndicatorTargetsHeader { get; set; }
        public virtual DbSet<ReferralForm> ReferralForm { get; set; }
        public virtual DbSet<SinoParentingAttendenceRegister> SinoParentingAttendenceRegister { get; set; }
        public virtual DbSet<SinoParentingDirectMemberAttendence> SinoParentingDirectMemberAttendence { get; set; }
        public virtual DbSet<SinoParentingDirectMemberDetail> SinoParentingDirectMemberDetail { get; set; }
        public virtual DbSet<SinoParentingIndirectMemberAttendence> SinoParentingIndirectMemberAttendence { get; set; }
        public virtual DbSet<SinoParentingIndirectMemberDetail> SinoParentingIndirectMemberDetail { get; set; }
        public virtual DbSet<SinovuyoGroups2> SinovuyoGroups2 { get; set; }
        public virtual DbSet<SmuAgeGroup> SmuAgeGroup { get; set; }
        public virtual DbSet<SmuAssessmentGuide> SmuAssessmentGuide { get; set; }
        public virtual DbSet<SmuAssessmentGuidePh9Questions> SmuAssessmentGuidePh9Questions { get; set; }
        public virtual DbSet<SmuAttendanceKey> SmuAttendanceKey { get; set; }
        public virtual DbSet<SmuAttendenceFormDetail> SmuAttendenceFormDetail { get; set; }
        public virtual DbSet<SmuAttendenceHeader> SmuAttendenceHeader { get; set; }
        public virtual DbSet<SmuClientRegistrationForm> SmuClientRegistrationForm { get; set; }
        public virtual DbSet<SmuCycle> SmuCycle { get; set; }
        public virtual DbSet<SmuFacilitator> SmuFacilitator { get; set; }
        public virtual DbSet<SmuFormType> SmuFormType { get; set; }
        public virtual DbSet<SmuGroup> SmuGroup { get; set; }
        public virtual DbSet<SmuKaguguScore> SmuKaguguScore { get; set; }
        public virtual DbSet<SmuLevelOfDifficultyToCheckOffProblems> SmuLevelOfDifficultyToCheckOffProblems { get; set; }
        public virtual DbSet<SmuOffice> SmuOffice { get; set; }
        public virtual DbSet<SmuPh9Question> SmuPh9Question { get; set; }
        public virtual DbSet<SmuPh9QuestionHeader> SmuPh9QuestionHeader { get; set; }
        public virtual DbSet<SmuPreGroupGuide> SmuPreGroupGuide { get; set; }
        public virtual DbSet<SmuPreGroupGuidePh9Questions> SmuPreGroupGuidePh9Questions { get; set; }
        public virtual DbSet<SmuProgram> SmuProgram { get; set; }
        public virtual DbSet<SmuReasonsForSessionAbsence> SmuReasonsForSessionAbsence { get; set; }
        public virtual DbSet<SmuResidency> SmuResidency { get; set; }
        public virtual DbSet<SmuSafetyPlanningForm> SmuSafetyPlanningForm { get; set; }
        public virtual DbSet<SmuSafetyPlanningFormInternalCopingStrategies> SmuSafetyPlanningFormInternalCopingStrategies { get; set; }
        public virtual DbSet<SmuSafetyPlanningFormPeopleProvideDistraction> SmuSafetyPlanningFormPeopleProvideDistraction { get; set; }
        public virtual DbSet<SmuSafetyPlanningFormPeopleToAskForHelp> SmuSafetyPlanningFormPeopleToAskForHelp { get; set; }
        public virtual DbSet<SmuSafetyPlanningFormProfessionsAgenciesToContact> SmuSafetyPlanningFormProfessionsAgenciesToContact { get; set; }
        public virtual DbSet<SmuSafetyPlanningFormWarningSigns> SmuSafetyPlanningFormWarningSigns { get; set; }
        public virtual DbSet<SmuSucideAssementFormHeader> SmuSucideAssementFormHeader { get; set; }
        public virtual DbSet<SmuSucideAssementQuestion> SmuSucideAssementQuestion { get; set; }
        public virtual DbSet<SmuSucideAssementResponse> SmuSucideAssementResponse { get; set; }
        public virtual DbSet<SmuSucideAssementScore> SmuSucideAssementScore { get; set; }
        public virtual DbSet<SmuTerminantionGuide> SmuTerminantionGuide { get; set; }
        public virtual DbSet<SmuTerminantionGuidePh9Questions> SmuTerminantionGuidePh9Questions { get; set; }
<<<<<<< HEAD
        public virtual DbSet<SmuViewAttendenceFormDetail> SmuViewAttendenceFormDetail { get; set; }
        public virtual DbSet<SmuViewAttendenceHeader> SmuViewAttendenceHeader { get; set; }
        public virtual DbSet<SmuViewClientRegistrationForm> SmuViewClientRegistrationForm { get; set; }
=======
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
        public virtual DbSet<StakeHolderDataCapture> StakeHolderDataCapture { get; set; }
        public virtual DbSet<SubcountyCodes> SubcountyCodes { get; set; }
        public virtual DbSet<TableVillage> TableVillage { get; set; }
        public virtual DbSet<TblErrorLog> TblErrorLog { get; set; }
        public virtual DbSet<UploadUpdateHouseholdData1> UploadUpdateHouseholdData1 { get; set; }
        public virtual DbSet<ViewAContacts> ViewAContacts { get; set; }
        public virtual DbSet<ViewADistrict> ViewADistrict { get; set; }
        public virtual DbSet<ViewAFacility> ViewAFacility { get; set; }
        public virtual DbSet<ViewAHomeVisitServicesNeeded> ViewAHomeVisitServicesNeeded { get; set; }
        public virtual DbSet<ViewAParentingGroupSession> ViewAParentingGroupSession { get; set; }
        public virtual DbSet<ViewAParish> ViewAParish { get; set; }
        public virtual DbSet<ViewAPriorityAreaCodes> ViewAPriorityAreaCodes { get; set; }
        public virtual DbSet<ViewASubcounty> ViewASubcounty { get; set; }
        public virtual DbSet<ViewATargets> ViewATargets { get; set; }
        public virtual DbSet<ViewAVillage> ViewAVillage { get; set; }
        public virtual DbSet<ViewAdminUnits> ViewAdminUnits { get; set; }
        public virtual DbSet<ViewAserviceLinkedToCategory> ViewAserviceLinkedToCategory { get; set; }
        public virtual DbSet<ViewAtrainingSession> ViewAtrainingSession { get; set; }
        public virtual DbSet<ViewBeneficiaryEnrolmentRegisterDetails> ViewBeneficiaryEnrolmentRegisterDetails { get; set; }
        public virtual DbSet<ViewBeneficiaryIdentificationRegister> ViewBeneficiaryIdentificationRegister { get; set; }
        public virtual DbSet<ViewDashboardBeneficiariesonIcare> ViewDashboardBeneficiariesonIcare { get; set; }
        public virtual DbSet<ViewDashboardBeneficiariesonIcarenoFilter> ViewDashboardBeneficiariesonIcarenoFilter { get; set; }
        public virtual DbSet<ViewDashboardBeneficiariesonIcarepivot> ViewDashboardBeneficiariesonIcarepivot { get; set; }
        public virtual DbSet<ViewDashboardBeneficiariesonIcarepivotNoFilter> ViewDashboardBeneficiariesonIcarepivotNoFilter { get; set; }
        public virtual DbSet<ViewDashboardBeneficiaryIdentificationRegister> ViewDashboardBeneficiaryIdentificationRegister { get; set; }
        public virtual DbSet<ViewDashboardGraduationBenchMark> ViewDashboardGraduationBenchMark { get; set; }
        public virtual DbSet<ViewDashboardHhvisitedCurrentQuarter> ViewDashboardHhvisitedCurrentQuarter { get; set; }
        public virtual DbSet<ViewDashboardHivstatus> ViewDashboardHivstatus { get; set; }
        public virtual DbSet<ViewDashboardHivtbrisKassessmentTool> ViewDashboardHivtbrisKassessmentTool { get; set; }
        public virtual DbSet<ViewDashboardHouseHoldNoVisits> ViewDashboardHouseHoldNoVisits { get; set; }
        public virtual DbSet<ViewDashboardOvcHiv> ViewDashboardOvcHiv { get; set; }
        public virtual DbSet<ViewDashboardOvcHivHei> ViewDashboardOvcHivHei { get; set; }
        public virtual DbSet<ViewDashboardOvcHivStat2023> ViewDashboardOvcHivStat2023 { get; set; }
        public virtual DbSet<ViewDashboardOvcServeIdentification> ViewDashboardOvcServeIdentification { get; set; }
        public virtual DbSet<ViewDashboardOvcServeSinovuyoSessions> ViewDashboardOvcServeSinovuyoSessions { get; set; }
        public virtual DbSet<ViewDashboardOvcServiceJourneysPlusSessions> ViewDashboardOvcServiceJourneysPlusSessions { get; set; }
        public virtual DbSet<ViewDashboardOvcServiceReportingTool> ViewDashboardOvcServiceReportingTool { get; set; }
        public virtual DbSet<ViewDashboardOvcServiceReportingToolDetail> ViewDashboardOvcServiceReportingToolDetail { get; set; }
        public virtual DbSet<ViewDashboardOvcserveVsTarget> ViewDashboardOvcserveVsTarget { get; set; }
        public virtual DbSet<ViewDashboardRiskFactorBinding> ViewDashboardRiskFactorBinding { get; set; }
        public virtual DbSet<ViewDashboardStakeholderTargets> ViewDashboardStakeholderTargets { get; set; }
        public virtual DbSet<ViewDashboardStakeholderTargetsOverrall> ViewDashboardStakeholderTargetsOverrall { get; set; }
        public virtual DbSet<ViewDashboardStakeholderTargetsPivoted> ViewDashboardStakeholderTargetsPivoted { get; set; }
        public virtual DbSet<ViewDashboardStakeholderTargetsPivotedOverrall> ViewDashboardStakeholderTargetsPivotedOverrall { get; set; }
        public virtual DbSet<ViewDashboardTargetDatasource> ViewDashboardTargetDatasource { get; set; }
        public virtual DbSet<ViewDashboardTnrhivstatus> ViewDashboardTnrhivstatus { get; set; }
        public virtual DbSet<ViewDashboardVleligible> ViewDashboardVleligible { get; set; }
        public virtual DbSet<ViewGroupCode> ViewGroupCode { get; set; }
        public virtual DbSet<ViewGroupComposition> ViewGroupComposition { get; set; }
        public virtual DbSet<ViewGroups> ViewGroups { get; set; }
        public virtual DbSet<ViewHouseHoldMembers> ViewHouseHoldMembers { get; set; }
        public virtual DbSet<ViewIsCareGiver> ViewIsCareGiver { get; set; }
        public virtual DbSet<ViewLastHouseholdCode> ViewLastHouseholdCode { get; set; }
        public virtual DbSet<ViewProjectIndicatorTargetsDatasource> ViewProjectIndicatorTargetsDatasource { get; set; }
        public virtual DbSet<ViewProjectIndicatorTargetsHeader> ViewProjectIndicatorTargetsHeader { get; set; }
        public virtual DbSet<ViewReportProjectIndicatorTargetsDetails> ViewReportProjectIndicatorTargetsDetails { get; set; }
        public virtual DbSet<ViewReportStakeHolderDataCapture> ViewReportStakeHolderDataCapture { get; set; }
        public virtual DbSet<ViewReportVslaTrackingToolDirectMember> ViewReportVslaTrackingToolDirectMember { get; set; }
        public virtual DbSet<ViewServiceRecieved> ViewServiceRecieved { get; set; }
        public virtual DbSet<ViewSlrGraduationCheckList> ViewSlrGraduationCheckList { get; set; }
        public virtual DbSet<ViewSlrHomeVisit> ViewSlrHomeVisit { get; set; }
        public virtual DbSet<ViewSmuAssessmentGuide> ViewSmuAssessmentGuide { get; set; }
        public virtual DbSet<ViewSplitDistrict> ViewSplitDistrict { get; set; }
        public virtual DbSet<ViewStakeHolderDataCapture> ViewStakeHolderDataCapture { get; set; }
        public virtual DbSet<ViewTbNonAdherence> ViewTbNonAdherence { get; set; }
        public virtual DbSet<ViewTreatmentInterruptions> ViewTreatmentInterruptions { get; set; }
        public virtual DbSet<ViewUploadHivTbTrackingForm> ViewUploadHivTbTrackingForm { get; set; }
        public virtual DbSet<ViewUserManagement> ViewUserManagement { get; set; }
        public virtual DbSet<ViewVlrVlcVlsDashboard> ViewVlrVlcVlsDashboard { get; set; }
        public virtual DbSet<ViewVslaGroupDirectMembers> ViewVslaGroupDirectMembers { get; set; }
        public virtual DbSet<ViewVslaGroupIndirectMember> ViewVslaGroupIndirectMember { get; set; }
        public virtual DbSet<ViewVslaTrackingToolDirectMember> ViewVslaTrackingToolDirectMember { get; set; }
        public virtual DbSet<VillageMoved> VillageMoved { get; set; }
        public virtual DbSet<ViralLoadUpload1> ViralLoadUpload1 { get; set; }
        public virtual DbSet<ViralLoadUpload3> ViralLoadUpload3 { get; set; }
        public virtual DbSet<VslaGroupCommittee> VslaGroupCommittee { get; set; }
        public virtual DbSet<VslaGroupComposition> VslaGroupComposition { get; set; }
        public virtual DbSet<VslaGroupDirectMembers> VslaGroupDirectMembers { get; set; }
        public virtual DbSet<VslaGroupIndirectMember> VslaGroupIndirectMember { get; set; }
        public virtual DbSet<VslaGroupShareOutDirectMember> VslaGroupShareOutDirectMember { get; set; }
        public virtual DbSet<VslaGroupShareOutHeader> VslaGroupShareOutHeader { get; set; }
        public virtual DbSet<VslaGroupShareOutIndirectMember> VslaGroupShareOutIndirectMember { get; set; }
        public virtual DbSet<VslaTrackingTool> VslaTrackingTool { get; set; }
        public virtual DbSet<VslaTrackingToolDirectMember> VslaTrackingToolDirectMember { get; set; }
        public virtual DbSet<VslaTrackingToolInDirectMember> VslaTrackingToolInDirectMember { get; set; }
        public virtual DbSet<Vslagroups2> Vslagroups2 { get; set; }
        public virtual DbSet<VslatrackerDirect> VslatrackerDirect { get; set; }
        public virtual DbSet<VslatrackerDirect1> VslatrackerDirect1 { get; set; }
        public virtual DbSet<VslatrackerDirect2> VslatrackerDirect2 { get; set; }
        public virtual DbSet<VslatrackerIndirect> VslatrackerIndirect { get; set; }
        public virtual DbSet<VslatrackerIndirect1> VslatrackerIndirect1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-KOVCOUM\\DSOFT;Database=Ver1_MUCOBADI;User Id=sa;password=**Root@85;Trusted_Connection=False;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AActivityType>(entity =>
            {
                entity.HasKey(e => e.ActivityTypeId);

                entity.ToTable("A_ActivityType");

                entity.Property(e => e.ActivityTypeId).ValueGeneratedNever();

                entity.Property(e => e.ActivityTypeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AAdministrationPhase>(entity =>
            {
                entity.HasKey(e => e.AdministrationPhaseId);

                entity.ToTable("A_AdministrationPhase");

                entity.Property(e => e.AdministrationPhaseId).ValueGeneratedNever();

                entity.Property(e => e.AdministrationPhaseDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AAdolescentEnrolledAttendingSchool>(entity =>
            {
                entity.HasKey(e => e.EnrolledId);

                entity.ToTable("A_ADolescent_Enrolled_Attending_School");

                entity.Property(e => e.EnrolledId).ValueGeneratedNever();

                entity.Property(e => e.EnrolledDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Enrolled_Desc");
            });

            modelBuilder.Entity<AAdolescentHealthServiceReferred>(entity =>
            {
                entity.HasKey(e => e.ReferredId);

                entity.ToTable("A_Adolescent_HealthServiceReferred");

                entity.Property(e => e.ReferredId).ValueGeneratedNever();

                entity.Property(e => e.ReferredDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AAdolescentIssueOfAbuse>(entity =>
            {
                entity.HasKey(e => e.IssueOfAbuseId);

                entity.ToTable("A_Adolescent_IssueOfAbuse");

                entity.Property(e => e.IssueOfAbuseId).ValueGeneratedNever();

                entity.Property(e => e.IssueOfAbuseIdDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AAgeCategory>(entity =>
            {
                entity.HasKey(e => e.AgeCategoryId);

                entity.ToTable("A_AgeCategory");

                entity.Property(e => e.AgeCategoryId).ValueGeneratedNever();

                entity.Property(e => e.AgeCategoryDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AAgreeDisagree>(entity =>
            {
                entity.HasKey(e => e.AgreeDisagreeId);

                entity.ToTable("A_AgreeDisagree");

                entity.Property(e => e.AgreeDisagreeId).ValueGeneratedNever();

                entity.Property(e => e.AgreeDisagreeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AAssetIncome>(entity =>
            {
                entity.HasKey(e => e.AssetIncomeId);

                entity.ToTable("A_AssetIncome");

                entity.Property(e => e.AssetIncomeId).ValueGeneratedNever();

                entity.Property(e => e.AssetIncomeDesc).HasMaxLength(2000);
            });

            modelBuilder.Entity<AAttendency>(entity =>
            {
                entity.HasKey(e => e.AttendencyId);

                entity.ToTable("A_Attendency");

                entity.Property(e => e.AttendencyId).ValueGeneratedNever();

                entity.Property(e => e.AttendencyDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ABusinessPlanQuestion>(entity =>
            {
                entity.HasKey(e => e.BusinessPlanQuestionId);

                entity.ToTable("A_BusinessPlanQuestion");

                entity.Property(e => e.BusinessPlanQuestionId).ValueGeneratedNever();

                entity.Property(e => e.QuestionCategory).HasMaxLength(3000);

                entity.Property(e => e.QuestionClassification).HasMaxLength(3000);
            });

            modelBuilder.Entity<ABusinessVentureCapitalInvestment>(entity =>
            {
                entity.HasKey(e => e.BusinessVentureCapitalInvestmentId);

                entity.ToTable("A_BusinessVentureCapitalInvestment");

                entity.Property(e => e.BusinessVentureCapitalInvestmentId).ValueGeneratedNever();

                entity.Property(e => e.BusinessVentureCapitalInvestmentDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACandidentClassCompleted>(entity =>
            {
                entity.HasKey(e => e.CandidentClassCompletedId);

                entity.ToTable("A_CandidentClassCompleted");

                entity.Property(e => e.CandidentClassCompletedId).ValueGeneratedNever();

                entity.Property(e => e.CandidentClassCompletedDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACareGiver>(entity =>
            {
                entity.HasKey(e => e.CareGiverId);

                entity.ToTable("A_CareGiver");

                entity.Property(e => e.CareGiverId).ValueGeneratedNever();

                entity.Property(e => e.CareGiverDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACaseCategory>(entity =>
            {
                entity.HasKey(e => e.CaseCategoryId);

                entity.ToTable("A_CaseCategory");

                entity.Property(e => e.CaseCategoryId).ValueGeneratedNever();

                entity.Property(e => e.CaseCategoryDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACaseCategoryItem>(entity =>
            {
                entity.HasKey(e => e.CaseCategoryItemId);

                entity.ToTable("A_CaseCategoryItem");

                entity.Property(e => e.CaseCategoryItemId).ValueGeneratedNever();

                entity.Property(e => e.CaseCategoryItemDesc).HasMaxLength(3000);

                entity.HasOne(d => d.CaseCategory)
                    .WithMany(p => p.ACaseCategoryItem)
                    .HasForeignKey(d => d.CaseCategoryId)
                    .HasConstraintName("FK_A_CaseCategoryItem_A_CaseCategory");
            });

            modelBuilder.Entity<ACaseNatureReported>(entity =>
            {
                entity.HasKey(e => e.CaseNatureReportedId);

                entity.ToTable("A_CaseNatureReported");

                entity.Property(e => e.CaseNatureReportedId).ValueGeneratedNever();

                entity.Property(e => e.CaseNatureReportedDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACasePlan>(entity =>
            {
                entity.HasKey(e => e.CasePlanId);

                entity.ToTable("A_CasePlan");

                entity.Property(e => e.CasePlanId).ValueGeneratedNever();

                entity.Property(e => e.CasePlanDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACasePlanStaus>(entity =>
            {
                entity.HasKey(e => e.CasePlanStausId);

                entity.ToTable("A_CasePLanStaus");

                entity.Property(e => e.CasePlanStausId)
                    .ValueGeneratedNever()
                    .HasColumnName("CasePLanStausId");

                entity.Property(e => e.CasePlanStausDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("CasePLanStausDesc");
            });

            modelBuilder.Entity<ACategoryofResidence>(entity =>
            {
                entity.HasKey(e => e.CategoryofResidenceId);

                entity.ToTable("A_CategoryofResidence");

                entity.Property(e => e.CategoryofResidenceId).ValueGeneratedNever();

                entity.Property(e => e.CategoryofResidenceDesc).HasMaxLength(2000);
            });

            modelBuilder.Entity<AChildAbuseOccurances>(entity =>
            {
                entity.HasKey(e => e.OccuranceId);

                entity.ToTable("A_ChildAbuseOccurances");

                entity.Property(e => e.OccuranceId).ValueGeneratedNever();

                entity.Property(e => e.OccuranceDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACientClassification>(entity =>
            {
                entity.HasKey(e => e.CientClassificationId);

                entity.ToTable("A_CientClassification");

                entity.Property(e => e.CientClassificationId).ValueGeneratedNever();

                entity.Property(e => e.CientClassificationDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AClientCareModality>(entity =>
            {
                entity.HasKey(e => e.ClientCareModalityId);

                entity.ToTable("A_ClientCareModality");

                entity.Property(e => e.ClientCareModalityId).ValueGeneratedNever();

                entity.Property(e => e.ClientCareModalityDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AClientMemberStatus>(entity =>
            {
                entity.HasKey(e => e.ClientMemberStatusId);

                entity.ToTable("A_ClientMemberStatus");

                entity.Property(e => e.ClientMemberStatusId).ValueGeneratedNever();

                entity.Property(e => e.ClientMemberStatusDes).HasMaxLength(3000);
            });

            modelBuilder.Entity<AContacts>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("A_Contacts");

                entity.Property(e => e.ContactId).ValueGeneratedNever();

                entity.Property(e => e.AddedBy).HasMaxLength(3000);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ContactEmail).HasMaxLength(3000);

                entity.Property(e => e.ContactFirstName).HasMaxLength(3000);

                entity.Property(e => e.ContactLastName).HasMaxLength(3000);

                entity.Property(e => e.ContactMiddleName).HasMaxLength(3000);

                entity.Property(e => e.ContactPhoneNumber).HasMaxLength(3000);

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OperationDistrict).HasMaxLength(500);

                entity.Property(e => e.OperationSubCounty).HasMaxLength(500);

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AContacts)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_A_Contacts_A_Country");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.AContacts)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK_A_Contacts_A_Facility");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.AContacts)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_A_Contacts_A_Gender");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.AContacts)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_A_Contacts_A_Position");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.AContacts)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK_A_Contacts_A_Service_Provider");
            });

            modelBuilder.Entity<ACountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("A_Country");

                entity.Property(e => e.CountryId)
                    .ValueGeneratedNever()
                    .HasColumnName("Country_id");

                entity.Property(e => e.CountryDesc).HasMaxLength(2000);

                entity.Property(e => e.DialCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ACurrenBusinessOpportunity>(entity =>
            {
                entity.HasKey(e => e.CurrenBusinessOpportunityId);

                entity.ToTable("A_CurrenBusinessOpportunity");

                entity.Property(e => e.CurrenBusinessOpportunityId).ValueGeneratedNever();

                entity.Property(e => e.CurrenBusinessOpportunityDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACurrenBusinessRisk>(entity =>
            {
                entity.HasKey(e => e.CurrenBusinessRiskId);

                entity.ToTable("A_CurrenBusinessRisk");

                entity.Property(e => e.CurrenBusinessRiskId).ValueGeneratedNever();

                entity.Property(e => e.CurrenBusinessRiskDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACurrentClass>(entity =>
            {
                entity.HasKey(e => e.CurrentClassId);

                entity.ToTable("A_CurrentClass");

                entity.Property(e => e.CurrentClassId).ValueGeneratedNever();

                entity.Property(e => e.CurrentClassDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ADailyMeals>(entity =>
            {
                entity.HasKey(e => e.MealId);

                entity.ToTable("A_DailyMeals");

                entity.Property(e => e.MealId).ValueGeneratedNever();

                entity.Property(e => e.MealDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<ADeliveryMethod>(entity =>
            {
                entity.HasKey(e => e.DeliveryMethodId);

                entity.ToTable("A_DeliveryMethod");

                entity.Property(e => e.DeliveryMethodId).ValueGeneratedNever();

                entity.Property(e => e.DeliveryMethodDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ADistrict>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.ToTable("A_District");

                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.DistricCode).HasMaxLength(100);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.ADistrict)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_A_District_A_Region");
            });

            modelBuilder.Entity<ADrugDispensingModality>(entity =>
            {
                entity.HasKey(e => e.DrugDispensingModalityId);

                entity.ToTable("A_DrugDispensingModality");

                entity.Property(e => e.DrugDispensingModalityId).ValueGeneratedNever();

                entity.Property(e => e.DrugDispensingModalityDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ADrugDispensingModel>(entity =>
            {
                entity.HasKey(e => e.DispensingModelId);

                entity.ToTable("A_DrugDispensingModel");

                entity.Property(e => e.DispensingModelId).ValueGeneratedNever();

                entity.Property(e => e.DispensingModelDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AEconomicActivity>(entity =>
            {
                entity.HasKey(e => e.EconomicActivityId);

                entity.ToTable("A_EconomicActivity");

                entity.Property(e => e.EconomicActivityId).ValueGeneratedNever();

                entity.Property(e => e.EconomicActivityDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AEducationLevel>(entity =>
            {
                entity.HasKey(e => e.EducationLevelId);

                entity.ToTable("A_EducationLevel");

                entity.Property(e => e.EducationLevelId).ValueGeneratedNever();

                entity.Property(e => e.EducationLevelDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AEidCascade>(entity =>
            {
                entity.HasKey(e => e.EidCascadeId);

                entity.ToTable("A_EID_Cascade");

                entity.Property(e => e.EidCascadeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EID_Cascade_Id");

                entity.Property(e => e.EidCascadeDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("EID_Cascade_Desc");
            });

            modelBuilder.Entity<AEnrolledHouseholdStatus>(entity =>
            {
                entity.HasKey(e => e.HouseholdStatusId);

                entity.ToTable("A_EnrolledHouseholdStatus");

                entity.Property(e => e.HouseholdStatusId).ValueGeneratedNever();

                entity.Property(e => e.HouseholdStatusDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<AExpensePayment>(entity =>
            {
                entity.HasKey(e => e.ExpensePaymentId)
                    .HasName("PK_A_EconomicStability");

                entity.ToTable("A_ExpensePayment");

                entity.Property(e => e.ExpensePaymentId).ValueGeneratedNever();

                entity.Property(e => e.ExpensePaymentDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AFacility>(entity =>
            {
                entity.HasKey(e => e.FacilityId);

                entity.ToTable("A_Facility");

                entity.Property(e => e.FacilityId).ValueGeneratedNever();

                entity.Property(e => e.FacilityName).HasMaxLength(1000);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.AFacility)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_A_Facility_A_District");
            });

            modelBuilder.Entity<AFacilityMigrated>(entity =>
            {
                entity.HasKey(e => e.FacilityId);

                entity.ToTable("A_Facility_Migrated");

                entity.Property(e => e.FacilityId).ValueGeneratedNever();

                entity.Property(e => e.FacilityName).HasMaxLength(1000);
            });

            modelBuilder.Entity<AFeedingStatus>(entity =>
            {
                entity.HasKey(e => e.FeedingStatusId);

                entity.ToTable("A_FeedingStatus");

                entity.Property(e => e.FeedingStatusId).ValueGeneratedNever();

                entity.Property(e => e.FeedingStatusDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AFinancialYear>(entity =>
            {
                entity.HasKey(e => e.FinancialYearId);

                entity.ToTable("A_FinancialYear");

                entity.Property(e => e.FinancialYearId).ValueGeneratedNever();

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AFollowupMeans>(entity =>
            {
                entity.HasKey(e => e.FollowupMeansId);

                entity.ToTable("A_FollowupMeans");

                entity.Property(e => e.FollowupMeansId).ValueGeneratedNever();

                entity.Property(e => e.FollowupMeansDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<AFoodConsumedSource>(entity =>
            {
                entity.HasKey(e => e.FoodConsumedId);

                entity.ToTable("A_FoodConsumedSource");

                entity.Property(e => e.FoodConsumedId).ValueGeneratedNever();

                entity.Property(e => e.FoodConsumedDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AFoodGroups>(entity =>
            {
                entity.HasKey(e => e.FoodGroupId);

                entity.ToTable("A_FoodGroups");

                entity.Property(e => e.FoodGroupId).ValueGeneratedNever();

                entity.Property(e => e.FoodGroupDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AGender>(entity =>
            {
                entity.HasKey(e => e.GenderId);

                entity.ToTable("A_Gender");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GenderDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AGenderBasedViolence>(entity =>
            {
                entity.HasKey(e => e.ViolenceId);

                entity.ToTable("A_GenderBasedViolence");

                entity.Property(e => e.ViolenceId).ValueGeneratedNever();

                entity.Property(e => e.ViolenceDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AGraduationCriteria>(entity =>
            {
                entity.HasKey(e => e.GraduationCriteriaId);

                entity.ToTable("A_GraduationCriteria");

                entity.Property(e => e.GraduationCriteriaId).ValueGeneratedNever();

                entity.Property(e => e.GraduationCriteriaCategory).HasMaxLength(1000);

                entity.Property(e => e.GraduationCriteriaDesc).HasMaxLength(3000);

                entity.Property(e => e.GraduationCriteriaGuidline).HasMaxLength(3000);
            });

            modelBuilder.Entity<AGroupCycle>(entity =>
            {
                entity.HasKey(e => e.GroupCycleId);

                entity.ToTable("A_GroupCycle");

                entity.Property(e => e.GroupCycleId).ValueGeneratedNever();

                entity.Property(e => e.GroupCycleDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AGroupMemberStatus>(entity =>
            {
                entity.HasKey(e => e.MemberStausId);

                entity.ToTable("A_Group_Member_Status");

                entity.Property(e => e.MemberStausId).ValueGeneratedNever();

                entity.Property(e => e.MemberStatusDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AGroupPosition>(entity =>
            {
                entity.HasKey(e => e.GroupPositionId);

                entity.ToTable("A_Group_Position");

                entity.Property(e => e.GroupPositionId)
                    .ValueGeneratedNever()
                    .HasColumnName("Group_Position_Id");

                entity.Property(e => e.GroupPositionDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Group_Position_Desc");
            });

            modelBuilder.Entity<AGroupType>(entity =>
            {
                entity.HasKey(e => e.GroupTypeId);

                entity.ToTable("A_GroupType");

                entity.Property(e => e.GroupTypeId).ValueGeneratedNever();

                entity.Property(e => e.GroupTypeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("A_Groups");

                entity.Property(e => e.GroupId).ValueGeneratedNever();

                entity.Property(e => e.GroupName).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHasDisability>(entity =>
            {
                entity.HasKey(e => e.DisabilityId);

                entity.ToTable("A_HasDisability");

                entity.Property(e => e.DisabilityId).ValueGeneratedNever();

                entity.Property(e => e.DisabilityDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHhBeneficiaryAgeCategory>(entity =>
            {
                entity.HasKey(e => e.HhBeneficiaryAgeCategoryId);

                entity.ToTable("A_HH_Beneficiary_Age_Category");

                entity.Property(e => e.HhBeneficiaryAgeCategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("HH_Beneficiary_Age_Category_Id");

                entity.Property(e => e.HhBeneficiaryAgeCategoryDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("HH_Beneficiary_Age_Category_Desc");
            });

            modelBuilder.Entity<AHhapplicableOptions>(entity =>
            {
                entity.HasKey(e => e.ApplicableOptionId);

                entity.ToTable("A_HHApplicableOptions");

                entity.Property(e => e.ApplicableOptionId).ValueGeneratedNever();

                entity.Property(e => e.ApplicableOptionDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHhassessmentStatus>(entity =>
            {
                entity.HasKey(e => e.AssessmentStatusId);

                entity.ToTable("A_HHAssessmentStatus");

                entity.Property(e => e.AssessmentStatusId).ValueGeneratedNever();

                entity.Property(e => e.AssessmentStatusDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHhassets>(entity =>
            {
                entity.HasKey(e => e.HhassetsId);

                entity.ToTable("A_HHAssets");

                entity.Property(e => e.HhassetsId)
                    .ValueGeneratedNever()
                    .HasColumnName("HHAssetsId");

                entity.Property(e => e.HhassetsDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HHAssetsDescription");
            });

            modelBuilder.Entity<AHhchildAbuse>(entity =>
            {
                entity.HasKey(e => e.ChildAbuseId);

                entity.ToTable("A_HHChildAbuse");

                entity.Property(e => e.ChildAbuseId).ValueGeneratedNever();

                entity.Property(e => e.ChildAbuseDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHhchildrenComplications>(entity =>
            {
                entity.HasKey(e => e.ComplicationsId);

                entity.ToTable("A_HHChildrenComplications");

                entity.Property(e => e.ComplicationsId).ValueGeneratedNever();

                entity.Property(e => e.ComplicationsDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHheducationLevel>(entity =>
            {
                entity.HasKey(e => e.HheducationLevelId);

                entity.ToTable("A_HHEducationLevel");

                entity.Property(e => e.HheducationLevelId)
                    .ValueGeneratedNever()
                    .HasColumnName("HHEducationLevelId");

                entity.Property(e => e.HheducationLevelDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HHEducationLevelDescription");
            });

            modelBuilder.Entity<AHhincome>(entity =>
            {
                entity.HasKey(e => e.HouseHoldIncomeId);

                entity.ToTable("A_HHIncome");

                entity.Property(e => e.HouseHoldIncomeId).ValueGeneratedNever();

                entity.Property(e => e.HouseHoldIncomeDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AHhincomeSource>(entity =>
            {
                entity.HasKey(e => e.IncomeSourceId);

                entity.ToTable("A_HHIncomeSource");

                entity.Property(e => e.IncomeSourceId).ValueGeneratedNever();

                entity.Property(e => e.IncomeSourceDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AHhincurredExpenses>(entity =>
            {
                entity.HasKey(e => e.IncurredExpensesId);

                entity.ToTable("A_HHIncurredExpenses");

                entity.Property(e => e.IncurredExpensesId).ValueGeneratedNever();

                entity.Property(e => e.IncurredExpensesDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHhknownHivstatus>(entity =>
            {
                entity.HasKey(e => e.KnownHivstatusId);

                entity.ToTable("A_HHKnownHIVStatus");

                entity.Property(e => e.KnownHivstatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("KnownHIVStatusId");

                entity.Property(e => e.KnownHivstatusDescription)
                    .HasMaxLength(3000)
                    .HasColumnName("KnownHIVStatusDescription");

                entity.Property(e => e.KnownHivstatusScores).HasColumnName("KnownHIVStatusScores");
            });

            modelBuilder.Entity<AHhpreSchoolNotEnrolled>(entity =>
            {
                entity.HasKey(e => e.PreSchoolNotEnrolledId);

                entity.ToTable("A_HHPreSchoolNotEnrolled");

                entity.Property(e => e.PreSchoolNotEnrolledId).ValueGeneratedNever();

                entity.Property(e => e.PreSchoolNotEnrolledDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHhtreatmentAdherance>(entity =>
            {
                entity.HasKey(e => e.TreatmentAdheranceId)
                    .HasName("PK_A_TreatmentAdherance");

                entity.ToTable("A_HHTreatmentAdherance");

                entity.Property(e => e.TreatmentAdheranceId).ValueGeneratedNever();

                entity.Property(e => e.TreatmentAdheranceDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHhviralLoadBloodTest>(entity =>
            {
                entity.HasKey(e => e.BloodTestId);

                entity.ToTable("A_HHViralLoadBloodTest");

                entity.Property(e => e.BloodTestId).ValueGeneratedNever();

                entity.Property(e => e.BloodTestDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHhviralLoadSuppressed>(entity =>
            {
                entity.HasKey(e => e.HhviralLoadSuppresedId);

                entity.ToTable("A_HHViralLoadSuppressed");

                entity.Property(e => e.HhviralLoadSuppresedId)
                    .ValueGeneratedNever()
                    .HasColumnName("HHViralLoadSuppresedId");

                entity.Property(e => e.HhviralLoadSuppresedDescription)
                    .HasMaxLength(3000)
                    .HasColumnName("HHViralLoadSuppresedDescription");

                entity.Property(e => e.HhviralLoadSuppresedScores).HasColumnName("HHViralLoadSuppresedScores");
            });

            modelBuilder.Entity<AHivstatus>(entity =>
            {
                entity.HasKey(e => e.HivstatusId);

                entity.ToTable("A_HIVStatus");

                entity.Property(e => e.HivstatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("HIVStatusId");

                entity.Property(e => e.HivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");
            });

            modelBuilder.Entity<AHomeVisitReason>(entity =>
            {
                entity.HasKey(e => e.HomeVisitReasonId);

                entity.ToTable("A_HomeVisitReason");

                entity.Property(e => e.HomeVisitReasonId).ValueGeneratedNever();

                entity.Property(e => e.HomeVisitReasonDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AHomeVisitServicesNeeded>(entity =>
            {
                entity.HasKey(e => e.ServiceNeededId);

                entity.ToTable("A_Home_Visit_Services_Needed");

                entity.Property(e => e.ServiceNeededId)
                    .ValueGeneratedNever()
                    .HasColumnName("Service_Needed_Id");

                entity.Property(e => e.ServiceClassiffication).HasMaxLength(3000);

                entity.Property(e => e.ServiceNeededDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Needed_Desc");

                entity.HasOne(d => d.ServiceCategory)
                    .WithMany(p => p.AHomeVisitServicesNeeded)
                    .HasForeignKey(d => d.ServiceCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_Home_Visit_Services_Needed_A_ServiceCategory");
            });

            modelBuilder.Entity<AImplementationMethod>(entity =>
            {
                entity.HasKey(e => e.ImplementationMethodId);

                entity.ToTable("A_ImplementationMethod");

                entity.Property(e => e.ImplementationMethodId).ValueGeneratedNever();

                entity.Property(e => e.ImplementationMethodDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AImplementingPartner>(entity =>
            {
                entity.HasKey(e => e.ImplementingPartnerId);

                entity.ToTable("A_ImplementingPartner");

                entity.Property(e => e.ImplementingPartnerId).ValueGeneratedNever();

                entity.Property(e => e.ImplementingPartnerName).HasMaxLength(3000);
            });

            modelBuilder.Entity<AIndicators>(entity =>
            {
                entity.HasKey(e => e.IndicatorId);

                entity.ToTable("A_Indicators");

                entity.Property(e => e.IndicatorId).ValueGeneratedNever();

                entity.Property(e => e.AddedBy).HasMaxLength(3000);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Denominator).HasMaxLength(3000);

                entity.Property(e => e.IndicatorCode).HasMaxLength(3000);

                entity.Property(e => e.IndicatorDescription).HasMaxLength(3000);

                entity.Property(e => e.Numerator).HasMaxLength(3000);

                entity.Property(e => e.ServiceProviderId)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<AInfectionWays>(entity =>
            {
                entity.HasKey(e => e.InfectionWayId);

                entity.ToTable("A_InfectionWays");

                entity.Property(e => e.InfectionWayId).ValueGeneratedNever();

                entity.Property(e => e.InfectionWayDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AInterventionAttendance>(entity =>
            {
                entity.HasKey(e => e.InterventionAttendanceId);

                entity.ToTable("A_InterventionAttendance");

                entity.Property(e => e.InterventionAttendanceId).ValueGeneratedNever();

                entity.Property(e => e.InterventionAttendanceDesc).HasMaxLength(2000);
            });

            modelBuilder.Entity<AInterventionType>(entity =>
            {
                entity.HasKey(e => e.InterventionTypeId);

                entity.ToTable("A_InterventionType");

                entity.Property(e => e.InterventionTypeId).ValueGeneratedNever();

                entity.Property(e => e.InterventionTypeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AJobCausedHarm>(entity =>
            {
                entity.HasKey(e => e.HarmfulId);

                entity.ToTable("A_JobCausedHarm");

                entity.Property(e => e.HarmfulId).ValueGeneratedNever();

                entity.Property(e => e.HarmfulDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AKnownRiskFactors>(entity =>
            {
                entity.HasKey(e => e.KnownRiskFactorId);

                entity.ToTable("A_KnownRiskFactors");

                entity.Property(e => e.KnownRiskFactorId).ValueGeneratedNever();

                entity.Property(e => e.KnownRiskFactorDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AKnownRiskFactors2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("A_KnownRiskFactors2");

                entity.Property(e => e.KnownRiskFactorDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AKnownRiskFactorsBinding>(entity =>
            {
                entity.HasKey(e => e.RiskFactorBindingId);

                entity.ToTable("A_KnownRiskFactorsBinding");

                entity.Property(e => e.RiskFactorBindingId).ValueGeneratedNever();

                entity.Property(e => e.RiskFactorsBinding).HasMaxLength(3000);

                entity.Property(e => e.RiskFactorsDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ALinkageServiceCategory>(entity =>
            {
                entity.HasKey(e => e.LinkageServiceCategoryId);

                entity.ToTable("A_LinkageServiceCategory");

                entity.Property(e => e.LinkageServiceCategoryId).ValueGeneratedNever();

                entity.Property(e => e.LinkageServiceCategoryDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AMalnutritionSigns>(entity =>
            {
                entity.HasKey(e => e.MalnutritionSignId);

                entity.ToTable("A_MalnutritionSigns");

                entity.Property(e => e.MalnutritionSignId).ValueGeneratedNever();

                entity.Property(e => e.MalnutritionSignDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AMaritalStatus>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusId);

                entity.ToTable("A_MaritalStatus");

                entity.Property(e => e.MaritalStatusId).ValueGeneratedNever();

                entity.Property(e => e.MaritalStatusDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AMemberBenefits>(entity =>
            {
                entity.HasKey(e => e.MemberBenefitsId);

                entity.ToTable("A_MemberBenefits");

                entity.Property(e => e.MemberBenefitsId).ValueGeneratedNever();

                entity.Property(e => e.MemberBenefitsDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AMonth>(entity =>
            {
                entity.HasKey(e => e.MonthId);

                entity.ToTable("A_Month");

                entity.Property(e => e.MonthId).ValueGeneratedNever();

                entity.Property(e => e.MonthDesc).HasMaxLength(2000);
            });

            modelBuilder.Entity<ANatureofResidence>(entity =>
            {
                entity.HasKey(e => e.NatureofResidenceId);

                entity.ToTable("A_NatureofResidence");

                entity.Property(e => e.NatureofResidenceId).ValueGeneratedNever();

                entity.Property(e => e.NatureofResidenceDesc).HasMaxLength(2000);
            });

            modelBuilder.Entity<ANmnSampledFor>(entity =>
            {
                entity.HasKey(e => e.SampledForId);

                entity.ToTable("A_NMN_SampledFor");

                entity.Property(e => e.SampledForId).ValueGeneratedNever();

                entity.Property(e => e.SampledForDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ANmnSectionOneQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("A_NMN_Section_One_Question");

                entity.Property(e => e.QuestionId).ValueGeneratedNever();

                entity.Property(e => e.QuestionDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ANmnSectionTwoAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId);

                entity.ToTable("A_NMN_Section_Two_Answer");

                entity.Property(e => e.AnswerId).ValueGeneratedNever();

                entity.Property(e => e.AnswerDesc).HasMaxLength(3000);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ANmnSectionTwoAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_A_NMN_Section_Two_Answer_A_NMN_Section_Two_Question");
            });

            modelBuilder.Entity<ANmnSectionTwoQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("A_NMN_Section_Two_Question");

                entity.Property(e => e.QuestionId).ValueGeneratedNever();

                entity.Property(e => e.QuestionDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ANonAdherence>(entity =>
            {
                entity.HasKey(e => e.NonAdherenceId);

                entity.ToTable("A_Non_Adherence");

                entity.Property(e => e.NonAdherenceId)
                    .ValueGeneratedNever()
                    .HasColumnName("Non_Adherence_Id");

                entity.Property(e => e.NonAdherenceDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Non_Adherence_Desc");
            });

            modelBuilder.Entity<ANotSuppressingReason>(entity =>
            {
                entity.HasKey(e => e.NotSuppressingReasonId);

                entity.ToTable("A_NotSuppressingReason");

                entity.Property(e => e.NotSuppressingReasonId).ValueGeneratedNever();

                entity.Property(e => e.NotSuppressingReasonDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AOvcVlrAndOvcVls>(entity =>
            {
                entity.HasKey(e => e.OvcVlrId);

                entity.ToTable("A_OVC_VLR_and_OVC_VLS");

                entity.Property(e => e.OvcVlrId)
                    .ValueGeneratedNever()
                    .HasColumnName("OVC_VLR_Id");

                entity.Property(e => e.OvcVlrDescription)
                    .HasMaxLength(3000)
                    .HasColumnName("OVC_VLR_Description");
            });

            modelBuilder.Entity<AOvcserviceProvider>(entity =>
            {
                entity.HasKey(e => e.OvcserviceProviderId);

                entity.ToTable("A_OVCServiceProvider");

                entity.Property(e => e.OvcserviceProviderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OVCServiceProviderId");

                entity.Property(e => e.OvcserviceProviderName)
                    .HasMaxLength(3000)
                    .HasColumnName("OVCServiceProviderName");
            });

            modelBuilder.Entity<AParentingGroupSession>(entity =>
            {
                entity.HasKey(e => e.ParentingGroupSessionId);

                entity.ToTable("A_ParentingGroupSession");

                entity.Property(e => e.ParentingGroupSessionId).ValueGeneratedNever();

                entity.Property(e => e.ParentingGroupSessionDesc).HasMaxLength(3000);

                entity.HasOne(d => d.ParentingGroupSessionType)
                    .WithMany(p => p.AParentingGroupSession)
                    .HasForeignKey(d => d.ParentingGroupSessionTypeId)
                    .HasConstraintName("FK_A_ParentingGroupSession_A_ParentingGroupSessionType");
            });

            modelBuilder.Entity<AParentingGroupSessionType>(entity =>
            {
                entity.HasKey(e => e.ParentingGroupSessionTypeId);

                entity.ToTable("A_ParentingGroupSessionType");

                entity.Property(e => e.ParentingGroupSessionTypeId).ValueGeneratedNever();

                entity.Property(e => e.ParentingGroupSessionTypedesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AParish>(entity =>
            {
                entity.HasKey(e => e.ParishId);

                entity.ToTable("A_Parish");

                entity.Property(e => e.ParishId).ValueGeneratedNever();

                entity.Property(e => e.ParishDescription).HasMaxLength(2000);

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.AParish)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_A_Parish_A_Subcounty");
            });

            modelBuilder.Entity<APcrTest>(entity =>
            {
                entity.HasKey(e => e.PcrTestId);

                entity.ToTable("A_PCR_Test");

                entity.Property(e => e.PcrTestId)
                    .ValueGeneratedNever()
                    .HasColumnName("PCR_Test_Id");

                entity.Property(e => e.PcrTestDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("PCR_Test_Desc");
            });

            modelBuilder.Entity<APersonContacted>(entity =>
            {
                entity.HasKey(e => e.PersonContactedId);

                entity.ToTable("A_PersonContacted");

                entity.Property(e => e.PersonContactedId).ValueGeneratedNever();

                entity.Property(e => e.PersonContactedDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<APosition>(entity =>
            {
                entity.HasKey(e => e.PositionId);

                entity.ToTable("A_Position");

                entity.Property(e => e.PositionId).ValueGeneratedNever();

                entity.Property(e => e.PositionDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<APriorityArea>(entity =>
            {
                entity.HasKey(e => e.PriorityAreaId);

                entity.ToTable("A_Priority_Area");

                entity.Property(e => e.PriorityAreaId).ValueGeneratedNever();

                entity.Property(e => e.PriorityAreaDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<APriorityAreaCodes>(entity =>
            {
                entity.HasKey(e => e.PriorityAreaCodeId);

                entity.ToTable("A_PriorityAreaCodes");

                entity.Property(e => e.PriorityAreaCodeId).ValueGeneratedNever();

                entity.Property(e => e.PriorityAreaCodeDesc).HasMaxLength(3000);

                entity.HasOne(d => d.PriorityArea)
                    .WithMany(p => p.APriorityAreaCodes)
                    .HasForeignKey(d => d.PriorityAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_PriorityAreaCodes_A_Priority_Area");
            });

            modelBuilder.Entity<AProgramParticipationStatus>(entity =>
            {
                entity.HasKey(e => e.ProgramParticipationId);

                entity.ToTable("A_ProgramParticipationStatus");

                entity.Property(e => e.ProgramParticipationId).ValueGeneratedNever();

                entity.Property(e => e.ProgramParticipationDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AQuarter>(entity =>
            {
                entity.HasKey(e => e.QuarterId);

                entity.ToTable("A_Quarter");

                entity.Property(e => e.QuarterId).ValueGeneratedNever();

                entity.Property(e => e.QuarterName).HasMaxLength(2000);

                entity.HasOne(d => d.EndMonth)
                    .WithMany(p => p.AQuarterEndMonth)
                    .HasForeignKey(d => d.EndMonthId)
                    .HasConstraintName("FK_A_Quarter_A_Month1");

                entity.HasOne(d => d.StartMonth)
                    .WithMany(p => p.AQuarterStartMonth)
                    .HasForeignKey(d => d.StartMonthId)
                    .HasConstraintName("FK_A_Quarter_A_Month");
            });

            modelBuilder.Entity<AReasonForBorrowingLoan>(entity =>
            {
                entity.HasKey(e => e.ReasonForBorrowingId);

                entity.ToTable("A_Reason_For_Borrowing_Loan");

                entity.Property(e => e.ReasonForBorrowingId)
                    .ValueGeneratedNever()
                    .HasColumnName("Reason_For_Borrowing_Id");

                entity.Property(e => e.ReasonForBorrowingDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Reason_For_Borrowing_Desc");
            });

            modelBuilder.Entity<AReasonForTreatmentInterruption>(entity =>
            {
                entity.HasKey(e => e.ReasonForTreatmentInterruptionId);

                entity.ToTable("A_Reason_For_Treatment_Interruption");

                entity.Property(e => e.ReasonForTreatmentInterruptionId)
                    .ValueGeneratedNever()
                    .HasColumnName("Reason_For_Treatment_InterruptionId");

                entity.Property(e => e.ReasonForTreatmentInterruption)
                    .HasMaxLength(1000)
                    .HasColumnName("Reason_For_Treatment_Interruption");
            });

            modelBuilder.Entity<AReasonsForNonOptimization>(entity =>
            {
                entity.HasKey(e => e.ReasonsForNonOptimizationId);

                entity.ToTable("A_Reasons_For_Non_Optimization");

                entity.Property(e => e.ReasonsForNonOptimizationId)
                    .ValueGeneratedNever()
                    .HasColumnName("Reasons_For_Non_OptimizationId");

                entity.Property(e => e.ReasonsForNonOptimization)
                    .HasMaxLength(1000)
                    .HasColumnName("Reasons_For_Non_Optimization");
            });

            modelBuilder.Entity<AReferralServices>(entity =>
            {
                entity.HasKey(e => e.ReferralServiceId);

                entity.ToTable("A_ReferralServices");

                entity.Property(e => e.ReferralServiceId).ValueGeneratedNever();

                entity.Property(e => e.ReferralServiceDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AReferredDisability>(entity =>
            {
                entity.HasKey(e => e.ReferredDisabilityId);

                entity.ToTable("A_ReferredDisability");

                entity.Property(e => e.ReferredDisabilityId).ValueGeneratedNever();

                entity.Property(e => e.ReferredDisabilityDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ARegimen>(entity =>
            {
                entity.HasKey(e => e.RegimenId);

                entity.ToTable("A_Regimen");

                entity.Property(e => e.RegimenId).ValueGeneratedNever();

                entity.Property(e => e.RegimenDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<ARegimenCategory>(entity =>
            {
                entity.HasKey(e => e.RegimenCategoryId);

                entity.ToTable("A_RegimenCategory");

                entity.Property(e => e.RegimenCategoryId).ValueGeneratedNever();

                entity.Property(e => e.RegimenCategoryDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<ARegion>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.ToTable("A_Region");

                entity.Property(e => e.RegionId).ValueGeneratedNever();

                entity.Property(e => e.RegionDescription).HasMaxLength(100);
            });

            modelBuilder.Entity<ARegistrationStatus>(entity =>
            {
                entity.HasKey(e => e.RegistrationStatusId);

                entity.ToTable("A_RegistrationStatus");

                entity.Property(e => e.RegistrationStatusId).ValueGeneratedNever();

                entity.Property(e => e.RegistrationStatusDesc).HasMaxLength(2000);
            });

            modelBuilder.Entity<ARelationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipId);

                entity.ToTable("A_Relationship");

                entity.Property(e => e.RelationshipId).ValueGeneratedNever();

                entity.Property(e => e.RelationshipName).HasMaxLength(1000);
            });

            modelBuilder.Entity<ARequestedTestType>(entity =>
            {
                entity.HasKey(e => e.RequestedTestTypeId);

                entity.ToTable("A_RequestedTestType");

                entity.Property(e => e.RequestedTestTypeId).ValueGeneratedNever();

                entity.Property(e => e.RequestedTestTypeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AResults>(entity =>
            {
                entity.HasKey(e => e.ResultId);

                entity.ToTable("A_Results");

                entity.Property(e => e.ResultId).ValueGeneratedNever();

                entity.Property(e => e.ResultDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ARiskLevelRating>(entity =>
            {
                entity.HasKey(e => e.RiskLevelRatingId);

                entity.ToTable("A_RiskLevelRating");

                entity.Property(e => e.RiskLevelRatingId).ValueGeneratedNever();

                entity.Property(e => e.RiskLevelRatingDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ASavingScheme>(entity =>
            {
                entity.HasKey(e => e.SavingSchemeId);

                entity.ToTable("A_SavingScheme");

                entity.Property(e => e.SavingSchemeId).ValueGeneratedNever();

                entity.Property(e => e.SavingSchemeDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ASchoolEnrolment>(entity =>
            {
                entity.HasKey(e => e.SchoolEnrolmentId);

                entity.ToTable("A_SchoolEnrolment");

                entity.Property(e => e.SchoolEnrolmentId).ValueGeneratedNever();

                entity.Property(e => e.SchoolEnrolmentDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ASchoolNotProgressingReason>(entity =>
            {
                entity.HasKey(e => e.ProgressingReasonId)
                    .HasName("PK_A_SchoolProgressingReason");

                entity.ToTable("A_SchoolNotProgressingReason");

                entity.Property(e => e.ProgressingReasonId).ValueGeneratedNever();

                entity.Property(e => e.ProgressingReasonDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ASelfProtection>(entity =>
            {
                entity.HasKey(e => e.SelfProtectionId);

                entity.ToTable("A_SelfProtection");

                entity.Property(e => e.SelfProtectionId).ValueGeneratedNever();

                entity.Property(e => e.SelfProtectionDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AServiceCategory>(entity =>
            {
                entity.HasKey(e => e.ServiceCategoryId);

                entity.ToTable("A_ServiceCategory");

                entity.Property(e => e.ServiceCategoryId).ValueGeneratedNever();

                entity.Property(e => e.ServiceCategoryDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AServiceLinkedTo>(entity =>
            {
                entity.HasKey(e => e.ServiceLinkedToId);

                entity.ToTable("A_ServiceLinkedTo");

                entity.Property(e => e.ServiceLinkedToId).ValueGeneratedNever();

                entity.Property(e => e.ServiceLinkedToDesc).HasMaxLength(3000);

                entity.HasOne(d => d.LinkageServiceCategory)
                    .WithMany(p => p.AServiceLinkedTo)
                    .HasForeignKey(d => d.LinkageServiceCategoryId)
                    .HasConstraintName("FK_A_ServiceLinkedTo_A_LinkageServiceCategory");
            });

            modelBuilder.Entity<AServiceProvided>(entity =>
            {
                entity.HasKey(e => e.ServiceProvidedId);

                entity.ToTable("A_Service_Provided");

                entity.Property(e => e.ServiceProvidedId).ValueGeneratedNever();

                entity.Property(e => e.ServiceProvidedDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AServiceProvider>(entity =>
            {
                entity.HasKey(e => e.ServiceProviderId);

                entity.ToTable("A_Service_Provider");

                entity.Property(e => e.ServiceProviderId)
                    .ValueGeneratedNever()
                    .HasColumnName("Service_Provider_Id");

                entity.Property(e => e.OperatingDistrict).HasMaxLength(3000);

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");
            });

            modelBuilder.Entity<AServiceReceived>(entity =>
            {
                entity.HasKey(e => e.ServiceReceivedId);

                entity.ToTable("A_Service_Received");

                entity.Property(e => e.ServiceReceivedId).ValueGeneratedNever();

                entity.Property(e => e.ServiceClassiffication).HasMaxLength(3000);

                entity.Property(e => e.ServiceReceivedDesc).HasMaxLength(3000);

                entity.HasOne(d => d.ServiceCategory)
                    .WithMany(p => p.AServiceReceived)
                    .HasForeignKey(d => d.ServiceCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_Service_Received_A_ServiceCategory");
            });

            modelBuilder.Entity<ASourceDocument>(entity =>
            {
                entity.HasKey(e => e.SourceDocumentId);

                entity.ToTable("A_SourceDocument");

                entity.Property(e => e.SourceDocumentId).ValueGeneratedNever();

                entity.Property(e => e.SourceDocumentDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<ASourceofIdentification>(entity =>
            {
                entity.HasKey(e => e.IdentificationId);

                entity.ToTable("A_SourceofIdentification");

                entity.Property(e => e.IdentificationId).ValueGeneratedNever();

                entity.Property(e => e.IdentificationDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<ASpecialAgeClassification>(entity =>
            {
                entity.HasKey(e => e.SpecialAgeClassificationId);

                entity.ToTable("A_Special_Age_Classification");

                entity.Property(e => e.SpecialAgeClassificationId)
                    .ValueGeneratedNever()
                    .HasColumnName("Special_Age_classification_Id");

                entity.Property(e => e.SpecialAgeClassificationDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Special_Age_Classification_Desc");
            });

            modelBuilder.Entity<AStableShelter>(entity =>
            {
                entity.HasKey(e => e.ShelterId);

                entity.ToTable("A_StableShelter");

                entity.Property(e => e.ShelterId).ValueGeneratedNever();

                entity.Property(e => e.ShelterDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AStartBusinessQuestion>(entity =>
            {
                entity.HasKey(e => e.StartBusinessQuestionId);

                entity.ToTable("A_StartBusinessQuestion");

                entity.Property(e => e.StartBusinessQuestionId).ValueGeneratedNever();

                entity.Property(e => e.StartBusinessQuestionDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AStrategiesForImprovingTreatmentContinuity>(entity =>
            {
                entity.HasKey(e => e.StrategiesForImprovingTreatmentContinuityId);

                entity.ToTable("A_Strategies_For_Improving_Treatment_Continuity");

                entity.Property(e => e.StrategiesForImprovingTreatmentContinuityId)
                    .ValueGeneratedNever()
                    .HasColumnName("Strategies_For_Improving_Treatment_ContinuityId");

                entity.Property(e => e.StrategiesForImprovingTreatmentContinuity)
                    .HasMaxLength(1000)
                    .HasColumnName("Strategies_For_Improving_Treatment_Continuity");
            });

            modelBuilder.Entity<ASubResults>(entity =>
            {
                entity.HasKey(e => e.SubResultId);

                entity.ToTable("A_SubResults");

                entity.Property(e => e.SubResultId).ValueGeneratedNever();

                entity.Property(e => e.SubResultDescription).HasMaxLength(3000);

                entity.HasOne(d => d.Result)
                    .WithMany(p => p.ASubResults)
                    .HasForeignKey(d => d.ResultId)
                    .HasConstraintName("FK_A_SubResults_A_Results");
            });

            modelBuilder.Entity<ASubcounty>(entity =>
            {
                entity.HasKey(e => e.SubcountyId);

                entity.ToTable("A_Subcounty");

                entity.Property(e => e.SubcountyId).ValueGeneratedNever();

                entity.Property(e => e.SubCountyCode).HasMaxLength(100);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.ASubcounty)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_A_Subcounty_A_District");
            });

            modelBuilder.Entity<ATargets>(entity =>
            {
                entity.HasKey(e => e.TargetId);

                entity.ToTable("A_Targets");

                entity.Property(e => e.TargetId).ValueGeneratedNever();

                entity.Property(e => e.AddedBy).HasMaxLength(3000);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.ATargets)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_A_Targets_A_District");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.ATargets)
                    .HasForeignKey(d => d.FinancialYearId)
                    .HasConstraintName("FK_A_Targets_A_FinancialYear");
            });

            modelBuilder.Entity<ATargetsLog>(entity =>
            {
                entity.HasKey(e => e.TargetsLogId);

                entity.ToTable("A_TargetsLog");

                entity.Property(e => e.TargetsLogId).ValueGeneratedNever();

                entity.Property(e => e.UpdatedBy).HasMaxLength(3000);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Target)
                    .WithMany(p => p.ATargetsLog)
                    .HasForeignKey(d => d.TargetId)
                    .HasConstraintName("FK_A_TargetsLog_A_Targets");
            });

            modelBuilder.Entity<ATbScreeningVenue>(entity =>
            {
                entity.HasKey(e => e.TbScreeningVenueId);

                entity.ToTable("A_TbScreeningVenue");

                entity.Property(e => e.TbScreeningVenueId).ValueGeneratedNever();

                entity.Property(e => e.TbScreeningVenueDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ATbclientRefered>(entity =>
            {
                entity.HasKey(e => e.TbreferedId);

                entity.ToTable("A_TBClientRefered");

                entity.Property(e => e.TbreferedId)
                    .ValueGeneratedNever()
                    .HasColumnName("TBReferedId");

                entity.Property(e => e.TbreferedDesc)
                    .HasMaxLength(2000)
                    .HasColumnName("TBReferedDesc");
            });

            modelBuilder.Entity<ATbtestResult>(entity =>
            {
                entity.HasKey(e => e.TbtestResultId);

                entity.ToTable("A_TBTestResult");

                entity.Property(e => e.TbtestResultId)
                    .ValueGeneratedNever()
                    .HasColumnName("TBTestResultId");

                entity.Property(e => e.TbtestResultDesc)
                    .HasMaxLength(2000)
                    .HasColumnName("TBTestResultDesc");
            });

            modelBuilder.Entity<ATbtreatment>(entity =>
            {
                entity.HasKey(e => e.TbtreatmentId);

                entity.ToTable("A_TBTreatment");

                entity.Property(e => e.TbtreatmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("TBTreatmentId");

                entity.Property(e => e.TbtreatmentDesc)
                    .HasMaxLength(2000)
                    .HasColumnName("TBTreatmentDesc");
            });

            modelBuilder.Entity<ATbtreatmentDuration>(entity =>
            {
                entity.HasKey(e => e.TbtreatmentDurationId);

                entity.ToTable("A_TBTReatmentDuration");

                entity.Property(e => e.TbtreatmentDurationId)
                    .ValueGeneratedNever()
                    .HasColumnName("TBTreatmentDurationId");

                entity.Property(e => e.TbtreatmentDurationDesc)
                    .HasMaxLength(2000)
                    .HasColumnName("TBTreatmentDurationDesc");
            });

            modelBuilder.Entity<ATerm>(entity =>
            {
                entity.HasKey(e => e.TermId);

                entity.ToTable("A_Term");

                entity.Property(e => e.TermId)
                    .ValueGeneratedNever()
                    .HasColumnName("Term_Id");

                entity.Property(e => e.TermDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ATrainingSession>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.ToTable("A_Training_Session");

                entity.Property(e => e.SessionId).ValueGeneratedNever();

                entity.Property(e => e.CurriculumId).HasColumnName("Curriculum_Id");

                entity.Property(e => e.SessionCategory)
                    .HasMaxLength(3000)
                    .HasColumnName("Session_Category");

                entity.Property(e => e.SessionDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Session_Desc");

                entity.HasOne(d => d.Curriculum)
                    .WithMany(p => p.ATrainingSession)
                    .HasForeignKey(d => d.CurriculumId)
                    .HasConstraintName("FK_A_Training_Session_A_Trainning_Curriculum");
            });

            modelBuilder.Entity<ATrainningCurriculum>(entity =>
            {
                entity.HasKey(e => e.CurriculumId);

                entity.ToTable("A_Trainning_Curriculum");

                entity.Property(e => e.CurriculumId)
                    .ValueGeneratedNever()
                    .HasColumnName("Curriculum_Id");

                entity.Property(e => e.CurriculumDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Curriculum_Desc");
            });

            modelBuilder.Entity<ATuberclosisTreatment>(entity =>
            {
                entity.HasKey(e => e.TreatmentId);

                entity.ToTable("A_TuberclosisTreatment");

                entity.Property(e => e.TreatmentId).ValueGeneratedNever();

                entity.Property(e => e.TreatmentDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AVillage>(entity =>
            {
                entity.HasKey(e => e.VillageId);

                entity.ToTable("A_Village");

                entity.Property(e => e.VillageId).ValueGeneratedNever();

                entity.Property(e => e.VillageDescription).HasMaxLength(2000);

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.AVillage)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_A_Village_A_Parish");
            });

            modelBuilder.Entity<AViralLoadLevel>(entity =>
            {
                entity.HasKey(e => e.ViralLoadLevelId);

                entity.ToTable("A_ViralLoadLevel");

                entity.Property(e => e.ViralLoadLevelId).ValueGeneratedNever();

                entity.Property(e => e.ViralLoadLevelDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AViralLoadResults>(entity =>
            {
                entity.HasKey(e => e.ViralLoadId)
                    .HasName("PK_A_ViralLoad");

                entity.ToTable("A_ViralLoadResults");

                entity.Property(e => e.ViralLoadId)
                    .ValueGeneratedNever()
                    .HasColumnName("ViralLoadID");

                entity.Property(e => e.ViralLoadDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<AViralLoadSuppressed>(entity =>
            {
                entity.HasKey(e => e.ViralLoadSuppressedId);

                entity.ToTable("A_ViralLoadSuppressed");

                entity.Property(e => e.ViralLoadSuppressedId).ValueGeneratedNever();

                entity.Property(e => e.ViralLoadSuppressedDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<AVslaGroupTrainer>(entity =>
            {
                entity.HasKey(e => e.VslaGroupTrainerId);

                entity.ToTable("A_VSLA_Group_Trainer");

                entity.Property(e => e.VslaGroupTrainerId)
                    .ValueGeneratedNever()
                    .HasColumnName("VSLA_Group_Trainer_Id");

                entity.Property(e => e.VslaGroupTrainerDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("VSLA_Group_Trainer_Desc");
            });

            modelBuilder.Entity<AYesNo>(entity =>
            {
                entity.HasKey(e => e.YesNoId);

                entity.ToTable("A_YesNo");

                entity.Property(e => e.YesNoId).ValueGeneratedNever();

                entity.Property(e => e.YesNoDescription).HasMaxLength(100);
            });

            modelBuilder.Entity<AatestView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AATestView");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);
            });

            modelBuilder.Entity<Apiupload>(entity =>
            {
                entity.ToTable("APIUpload");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AgeGroup)
                    .HasMaxLength(3000)
                    .HasColumnName("age_group");

                entity.Property(e => e.Agency)
                    .HasMaxLength(3000)
                    .HasColumnName("agency");

                entity.Property(e => e.ChildDob)
                    .HasMaxLength(3000)
                    .HasColumnName("child_dob");

                entity.Property(e => e.ChildName).HasMaxLength(3000);

                entity.Property(e => e.DistrictName)
                    .HasMaxLength(3000)
                    .HasColumnName("district_name");

                entity.Property(e => e.Dreams).HasMaxLength(3000);

                entity.Property(e => e.EnrollmentFyr)
                    .HasMaxLength(3000)
                    .HasColumnName("enrollment_fyr");

                entity.Property(e => e.EnrollmentQtr)
                    .HasMaxLength(3000)
                    .HasColumnName("enrollment_qtr");

                entity.Property(e => e.Fyear)
                    .HasMaxLength(3000)
                    .HasColumnName("fyear");

                entity.Property(e => e.HhNameorCaregiverNin)
                    .HasMaxLength(3000)
                    .HasColumnName("hh_nameorCaregiverNIN");

                entity.Property(e => e.HivStatus)
                    .HasMaxLength(3000)
                    .HasColumnName("hiv_status");

                entity.Property(e => e.HouseHoldStatus).HasMaxLength(3000);

                entity.Property(e => e.IpreferenceIdorChildNin)
                    .HasMaxLength(3000)
                    .HasColumnName("ipreferenceIDorChildNIN");

                entity.Property(e => e.LastUploadDate).HasColumnType("datetime");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(3000)
                    .HasColumnName("org_name");

                entity.Property(e => e.Parish)
                    .HasMaxLength(3000)
                    .HasColumnName("parish");

                entity.Property(e => e.ReportingPeriod)
                    .HasMaxLength(3000)
                    .HasColumnName("reportingPeriod");

                entity.Property(e => e.Response1).HasMaxLength(3000);

                entity.Property(e => e.Response10).HasMaxLength(3000);

                entity.Property(e => e.Response11).HasMaxLength(3000);

                entity.Property(e => e.Response12).HasMaxLength(3000);

                entity.Property(e => e.Response13).HasMaxLength(3000);

                entity.Property(e => e.Response14).HasMaxLength(3000);

                entity.Property(e => e.Response15).HasMaxLength(3000);

                entity.Property(e => e.Response16).HasMaxLength(3000);

                entity.Property(e => e.Response17).HasMaxLength(3000);

                entity.Property(e => e.Response18).HasMaxLength(3000);

                entity.Property(e => e.Response19).HasMaxLength(3000);

                entity.Property(e => e.Response2).HasMaxLength(3000);

                entity.Property(e => e.Response20).HasMaxLength(3000);

                entity.Property(e => e.Response21).HasMaxLength(3000);

                entity.Property(e => e.Response22).HasMaxLength(3000);

                entity.Property(e => e.Response23).HasMaxLength(3000);

                entity.Property(e => e.Response24).HasMaxLength(3000);

                entity.Property(e => e.Response25).HasMaxLength(3000);

                entity.Property(e => e.Response26).HasMaxLength(3000);

                entity.Property(e => e.Response27).HasMaxLength(3000);

                entity.Property(e => e.Response28).HasMaxLength(3000);

                entity.Property(e => e.Response29).HasMaxLength(3000);

                entity.Property(e => e.Response3).HasMaxLength(3000);

                entity.Property(e => e.Response30).HasMaxLength(3000);

                entity.Property(e => e.Response31).HasMaxLength(3000);

                entity.Property(e => e.Response32).HasMaxLength(3000);

                entity.Property(e => e.Response33).HasMaxLength(3000);

                entity.Property(e => e.Response34).HasMaxLength(3000);

                entity.Property(e => e.Response35).HasMaxLength(3000);

                entity.Property(e => e.Response36).HasMaxLength(3000);

                entity.Property(e => e.Response37).HasMaxLength(3000);

                entity.Property(e => e.Response38).HasMaxLength(3000);

                entity.Property(e => e.Response39).HasMaxLength(3000);

                entity.Property(e => e.Response4).HasMaxLength(3000);

                entity.Property(e => e.Response40).HasMaxLength(3000);

                entity.Property(e => e.Response41).HasMaxLength(3000);

                entity.Property(e => e.Response42).HasMaxLength(3000);

                entity.Property(e => e.Response43).HasMaxLength(3000);

                entity.Property(e => e.Response44).HasMaxLength(3000);

                entity.Property(e => e.Response45).HasMaxLength(3000);

                entity.Property(e => e.Response46).HasMaxLength(3000);

                entity.Property(e => e.Response47).HasMaxLength(3000);

                entity.Property(e => e.Response48).HasMaxLength(3000);

                entity.Property(e => e.Response49).HasMaxLength(3000);

                entity.Property(e => e.Response5).HasMaxLength(3000);

                entity.Property(e => e.Response50).HasMaxLength(3000);

                entity.Property(e => e.Response51).HasMaxLength(3000);

                entity.Property(e => e.Response52).HasMaxLength(3000);

                entity.Property(e => e.Response53).HasMaxLength(3000);

                entity.Property(e => e.Response54).HasMaxLength(3000);

                entity.Property(e => e.Response55).HasMaxLength(3000);

                entity.Property(e => e.Response56).HasMaxLength(3000);

                entity.Property(e => e.Response57).HasMaxLength(3000);

                entity.Property(e => e.Response58).HasMaxLength(3000);

                entity.Property(e => e.Response59).HasMaxLength(3000);

                entity.Property(e => e.Response6).HasMaxLength(3000);

                entity.Property(e => e.Response60).HasMaxLength(3000);

                entity.Property(e => e.Response61).HasMaxLength(3000);

                entity.Property(e => e.Response62).HasMaxLength(3000);

                entity.Property(e => e.Response63).HasMaxLength(3000);

                entity.Property(e => e.Response64).HasMaxLength(3000);

                entity.Property(e => e.Response65).HasMaxLength(3000);

                entity.Property(e => e.Response66).HasMaxLength(3000);

                entity.Property(e => e.Response67).HasMaxLength(3000);

                entity.Property(e => e.Response68).HasMaxLength(3000);

                entity.Property(e => e.Response69).HasMaxLength(3000);

                entity.Property(e => e.Response7).HasMaxLength(3000);

                entity.Property(e => e.Response70).HasMaxLength(3000);

                entity.Property(e => e.Response71).HasMaxLength(3000);

                entity.Property(e => e.Response72).HasMaxLength(3000);

                entity.Property(e => e.Response73).HasMaxLength(3000);

                entity.Property(e => e.Response74).HasMaxLength(3000);

                entity.Property(e => e.Response75).HasMaxLength(3000);

                entity.Property(e => e.Response76).HasMaxLength(3000);

                entity.Property(e => e.Response77).HasMaxLength(3000);

                entity.Property(e => e.Response78).HasMaxLength(3000);

                entity.Property(e => e.Response79).HasMaxLength(3000);

                entity.Property(e => e.Response8).HasMaxLength(3000);

                entity.Property(e => e.Response80).HasMaxLength(3000);

                entity.Property(e => e.Response81).HasMaxLength(3000);

                entity.Property(e => e.Response82).HasMaxLength(3000);

                entity.Property(e => e.Response9).HasMaxLength(3000);

                entity.Property(e => e.Sex)
                    .HasMaxLength(3000)
                    .HasColumnName("sex");

                entity.Property(e => e.SubcountyName)
                    .HasMaxLength(3000)
                    .HasColumnName("subcounty_name");

                entity.Property(e => e.Village)
                    .HasMaxLength(3000)
                    .HasColumnName("village");
            });

            modelBuilder.Entity<AspNetEmailConfirmationCode>(entity =>
            {
                entity.HasKey(e => e.ConfirmationId);

                entity.Property(e => e.ConfirmationCode)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(3000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.AccountHolderName).HasMaxLength(3000);

                entity.Property(e => e.DistrictId).HasMaxLength(2000);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.SubCountyId).HasMaxLength(2000);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK_AspNetUsers_A_Facility");
            });

            modelBuilder.Entity<Avat>(entity =>
            {
                entity.ToTable("AVAT");

                entity.Property(e => e.AvatId)
                    .ValueGeneratedNever()
                    .HasColumnName("Avat_Id");

                entity.Property(e => e.AdolescentWithKnownHivstatus).HasColumnName("AdolescentWithKnownHIVStatus");

                entity.Property(e => e.AdolescentWithKnownHivstatusScore).HasColumnName("AdolescentWithKnownHIVStatusScore");

                entity.Property(e => e.AssessmentDate).HasColumnType("date");

                entity.Property(e => e.AssessorContact).HasMaxLength(1000);

                entity.Property(e => e.AssessorName).HasMaxLength(3000);

                entity.Property(e => e.AssessorTitle).HasMaxLength(2000);

                entity.Property(e => e.Cdocontact)
                    .HasMaxLength(1000)
                    .HasColumnName("CDOContact");

                entity.Property(e => e.Cdoname)
                    .HasMaxLength(3000)
                    .HasColumnName("CDOName");

                entity.Property(e => e.HarmfulId).HasMaxLength(1000);

                entity.Property(e => e.HhtotalScore).HasColumnName("HHTotalScore");

                entity.Property(e => e.InfectionWayId)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.InterviewDate).HasColumnType("date");

                entity.Property(e => e.IssueOfAbuseId).HasMaxLength(1000);

                entity.Property(e => e.MemberBenefitsId).HasMaxLength(1000);

                entity.Property(e => e.ProgressingReasonId).HasMaxLength(1000);

                entity.Property(e => e.SelfProtectionId)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ViolenceId).HasMaxLength(1000);

                entity.HasOne(d => d.AdministrationPhase)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.AdministrationPhaseId)
                    .HasConstraintName("FK_AVAT_A_AdministrationPhase");

                entity.HasOne(d => d.AdolescentProgressingNavigation)
                    .WithMany(p => p.AvatAdolescentProgressingNavigation)
                    .HasForeignKey(d => d.AdolescentProgressing)
                    .HasConstraintName("FK_AVAT_A_YesNo7");

                entity.HasOne(d => d.AdolescentWithKnownHivstatusNavigation)
                    .WithMany(p => p.AvatAdolescentWithKnownHivstatusNavigation)
                    .HasForeignKey(d => d.AdolescentWithKnownHivstatus)
                    .HasConstraintName("FK_AVAT_A_YesNo2");

                entity.HasOne(d => d.AntiretroviralTherapyNavigation)
                    .WithMany(p => p.AvatAntiretroviralTherapyNavigation)
                    .HasForeignKey(d => d.AntiretroviralTherapy)
                    .HasConstraintName("FK_AVAT_A_YesNo3");

                entity.HasOne(d => d.AssessmentStatus)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.AssessmentStatusId)
                    .HasConstraintName("FK_AVAT_A_HHAssessmentStatus");

                entity.HasOne(d => d.ChildAbuse)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.ChildAbuseId)
                    .HasConstraintName("FK_AVAT_A_HHChildAbuse");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_AVAT_A_District");

                entity.HasOne(d => d.EconomicActivity)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.EconomicActivityId)
                    .HasConstraintName("FK_AVAT_A_EconomicActivity");

                entity.HasOne(d => d.Enrolled)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.EnrolledId)
                    .HasConstraintName("FK_AVAT_A_ADolescent_Enrolled_Attending_School");

                entity.HasOne(d => d.FeelingWithdrawnNavigation)
                    .WithMany(p => p.AvatFeelingWithdrawnNavigation)
                    .HasForeignKey(d => d.FeelingWithdrawn)
                    .HasConstraintName("FK_AVAT_A_YesNo9");

                entity.HasOne(d => d.HadViralLoadBloodTestNavigation)
                    .WithMany(p => p.AvatHadViralLoadBloodTestNavigation)
                    .HasForeignKey(d => d.HadViralLoadBloodTest)
                    .HasConstraintName("FK_AVAT_A_YesNo4");

                entity.HasOne(d => d.HasAttendedSchoolNavigation)
                    .WithMany(p => p.AvatHasAttendedSchoolNavigation)
                    .HasForeignKey(d => d.HasAttendedSchool)
                    .HasConstraintName("FK_AVAT_A_YesNo6");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_AVAT_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_AVAT_HouseHoldMembers");

                entity.HasOne(d => d.IsSavingsGroupMemberNavigation)
                    .WithMany(p => p.AvatIsSavingsGroupMemberNavigation)
                    .HasForeignKey(d => d.IsSavingsGroupMember)
                    .HasConstraintName("FK_AVAT_A_YesNo");

                entity.HasOne(d => d.IsViralloadSuppressedNavigation)
                    .WithMany(p => p.AvatIsViralloadSuppressedNavigation)
                    .HasForeignKey(d => d.IsViralloadSuppressed)
                    .HasConstraintName("FK_AVAT_A_YesNo5");

                entity.HasOne(d => d.LackofFoodNavigation)
                    .WithMany(p => p.AvatLackofFoodNavigation)
                    .HasForeignKey(d => d.LackofFood)
                    .HasConstraintName("FK_AVAT_A_YesNo1");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_AVAT_A_MaritalStatus");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_AVAT_A_DailyMeals");

                entity.HasOne(d => d.Referred)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.ReferredId)
                    .HasConstraintName("FK_AVAT_A_Adolescent_HealthServiceReferred");

                entity.HasOne(d => d.SameAdultPrimaryCareGiverNavigation)
                    .WithMany(p => p.AvatSameAdultPrimaryCareGiverNavigation)
                    .HasForeignKey(d => d.SameAdultPrimaryCareGiver)
                    .HasConstraintName("FK_AVAT_A_YesNo8");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.Avat)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_AVAT_A_Subcounty");
            });

            modelBuilder.Entity<BeneficiaryEnrolmentRegisterDetails>(entity =>
            {
                entity.HasKey(e => e.EnrolmentRegisterDetailsId);

                entity.Property(e => e.EnrolmentRegisterDetailsId).ValueGeneratedNever();

                entity.Property(e => e.AssessedNotEligible).HasColumnName("Assessed_NotEligible");

                entity.Property(e => e.AssessedOfferedAccepted).HasColumnName("Assessed_Offered_Accepted");

                entity.Property(e => e.AssessedOfferedRefused).HasColumnName("Assessed_Offered_Refused");

                entity.Property(e => e.NotAssessed).HasColumnName("Not_Assessed");

                entity.Property(e => e.OvcEnroll).HasColumnName("OVC_Enroll");

                entity.Property(e => e.OvcOffer).HasColumnName("OVC_Offer");

                entity.HasOne(d => d.AssessedNotEligibleNavigation)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterDetailsAssessedNotEligibleNavigation)
                    .HasForeignKey(d => d.AssessedNotEligible)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterDetails_A_YesNo3");

                entity.HasOne(d => d.AssessedOfferedAcceptedNavigation)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterDetailsAssessedOfferedAcceptedNavigation)
                    .HasForeignKey(d => d.AssessedOfferedAccepted)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterDetails_A_YesNo4");

                entity.HasOne(d => d.AssessedOfferedRefusedNavigation)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterDetailsAssessedOfferedRefusedNavigation)
                    .HasForeignKey(d => d.AssessedOfferedRefused)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterDetails_A_YesNo5");

                entity.HasOne(d => d.EnrolmentRegisterHeader)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterDetails)
                    .HasForeignKey(d => d.EnrolmentRegisterHeaderId)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterDetails_BeneficiaryEnrolmentRegisterHeader");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterDetails)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterDetails_HouseHoldMembers");

                entity.HasOne(d => d.NotAssessedNavigation)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterDetailsNotAssessedNavigation)
                    .HasForeignKey(d => d.NotAssessed)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterDetails_A_YesNo");

                entity.HasOne(d => d.OvcEnrollNavigation)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterDetailsOvcEnrollNavigation)
                    .HasForeignKey(d => d.OvcEnroll)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterDetails_A_YesNo1");

                entity.HasOne(d => d.OvcOfferNavigation)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterDetailsOvcOfferNavigation)
                    .HasForeignKey(d => d.OvcOffer)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterDetails_A_YesNo2");
            });

            modelBuilder.Entity<BeneficiaryEnrolmentRegisterHeader>(entity =>
            {
                entity.HasKey(e => e.EnrolmentRegisterHeaderId);

                entity.Property(e => e.EnrolmentRegisterHeaderId).ValueGeneratedNever();

                entity.Property(e => e.CollectedBy).HasMaxLength(3000);

                entity.Property(e => e.CollectedByTele).HasMaxLength(100);

                entity.Property(e => e.CollectedDate).HasColumnType("date");

                entity.Property(e => e.EnrolmentDate).HasColumnType("date");

                entity.Property(e => e.OvcserviceProviderId).HasColumnName("OVCServiceProviderId");

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.ReviewedByTele).HasMaxLength(100);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterHeader)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterHeader_A_District");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterHeader)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterHeader_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterHeader)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterHeader_HouseHoldMembers");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterHeader)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterHeader_A_ImplementingPartner");

                entity.HasOne(d => d.OvcserviceProvider)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterHeader)
                    .HasForeignKey(d => d.OvcserviceProviderId)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterHeader_A_OVCServiceProvider");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.BeneficiaryEnrolmentRegisterHeader)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_BeneficiaryEnrolmentRegisterHeader_A_Subcounty");
            });

            modelBuilder.Entity<BeneficiaryIdentificationRegister>(entity =>
            {
                entity.HasKey(e => e.HouseHoldId);

                entity.Property(e => e.HouseHoldId).ValueGeneratedNever();

                entity.Property(e => e.AddedBy).HasMaxLength(3000);

                entity.Property(e => e.Artnumber)
                    .HasMaxLength(1000)
                    .HasColumnName("ARTNumber");

                entity.Property(e => e.Cohort).HasColumnType("date");

                entity.Property(e => e.Copies).HasMaxLength(1000);

                entity.Property(e => e.CurrentlyonArt).HasColumnName("CurrentlyonART");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateofIdentification).HasColumnType("date");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GivenName).HasMaxLength(3000);

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.OtherIdentificationSource).HasMaxLength(3000);

                entity.Property(e => e.OtherSourceDocument).HasMaxLength(3000);

                entity.Property(e => e.OvcVlrId).HasColumnName("OVC_VLR_Id");

                entity.Property(e => e.SourceDocumentExt).HasMaxLength(50);

                entity.Property(e => e.SourceDocumentUrl)
                    .HasMaxLength(3000)
                    .HasColumnName("SourceDocumentURL");

                entity.Property(e => e.Surname).HasMaxLength(3000);

                entity.Property(e => e.TelephoneContact).HasMaxLength(1000);

                entity.Property(e => e.VirallaodDate).HasColumnType("date");

                entity.HasOne(d => d.CurrentlyonArtNavigation)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.CurrentlyonArt)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_YesNo");

                entity.HasOne(d => d.DispensingModel)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.DispensingModelId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_DrugDispensingModel");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_District");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_Facility");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_Gender");

                entity.HasOne(d => d.Hivstatus)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.HivstatusId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_HIVStatus");

                entity.HasOne(d => d.Identification)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.IdentificationId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_SourceofIdentification");

                entity.HasOne(d => d.KnownRiskFactor)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.KnownRiskFactorId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_KnownRiskFactors");

                entity.HasOne(d => d.OvcVlr)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.OvcVlrId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_OVC_VLR_and_OVC_VLS");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_Parish");

                entity.HasOne(d => d.RegimenCategory)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.RegimenCategoryId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_RegimenCategory");

                entity.HasOne(d => d.Regimen)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.RegimenId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_Regimen");

                entity.HasOne(d => d.SourceDocument)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.SourceDocumentId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_SourceDocument");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_Subcounty");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_Village");

                entity.HasOne(d => d.ViralLoadSuppressed)
                    .WithMany(p => p.BeneficiaryIdentificationRegister)
                    .HasForeignKey(d => d.ViralLoadSuppressedId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegister_A_ViralLoadSuppressed");
            });

            modelBuilder.Entity<BeneficiaryIdentificationRegisterLog>(entity =>
            {
                entity.HasKey(e => e.HouseHoldLogId);

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionMadeBy).HasMaxLength(3000);

                entity.Property(e => e.ActionTaken).HasMaxLength(1000);

                entity.Property(e => e.ColumnEdited).HasMaxLength(3000);

                entity.Property(e => e.NewValue).HasMaxLength(3000);

                entity.Property(e => e.PreviousValue).HasMaxLength(3000);

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.BeneficiaryIdentificationRegisterLog)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_BeneficiaryIdentificationRegisterLog_BeneficiaryIdentificationRegister");
            });

            modelBuilder.Entity<BeneficiaryLinkageTrackingTool>(entity =>
            {
                entity.HasKey(e => e.LinkageTrackingToolId);

                entity.Property(e => e.LinkageTrackingToolId).ValueGeneratedNever();

                entity.Property(e => e.DateProvidingService).HasColumnType("date");

                entity.Property(e => e.LinkageDate).HasColumnType("date");

                entity.Property(e => e.OtherGroupType).HasMaxLength(3000);

                entity.Property(e => e.PersonProvidingService).HasMaxLength(3000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewTitle).HasMaxLength(2000);

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");

                entity.Property(e => e.SubmittedBy).HasMaxLength(3000);

                entity.Property(e => e.SubmittedDate).HasColumnType("date");

                entity.Property(e => e.SubmittedTitle).HasMaxLength(2000);

                entity.Property(e => e.TitlePersonProvidingService).HasMaxLength(2000);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.BeneficiaryLinkageTrackingTool)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingTool_A_District");

                entity.HasOne(d => d.GroupCompositionCodeNavigation)
                    .WithMany(p => p.BeneficiaryLinkageTrackingTool)
                    .HasForeignKey(d => d.GroupCompositionCode)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingTool_VSLA_Group_Composition");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.BeneficiaryLinkageTrackingTool)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingTool_A_Groups");

                entity.HasOne(d => d.GroupType)
                    .WithMany(p => p.BeneficiaryLinkageTrackingTool)
                    .HasForeignKey(d => d.GroupTypeId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingTool_A_GroupType");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.BeneficiaryLinkageTrackingTool)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingTool_A_ImplementingPartner");

                entity.HasOne(d => d.LinkageServiceCategory)
                    .WithMany(p => p.BeneficiaryLinkageTrackingTool)
                    .HasForeignKey(d => d.LinkageServiceCategoryId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingTool_A_LinkageServiceCategory");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.BeneficiaryLinkageTrackingTool)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingTool_A_Service_Provider");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.BeneficiaryLinkageTrackingTool)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingTool_A_Subcounty");
            });

            modelBuilder.Entity<BeneficiaryLinkageTrackingToolDirectMember>(entity =>
            {
                entity.HasKey(e => e.LinkageTrackingToolDirectMemberId);

                entity.Property(e => e.LinkageTrackingToolDirectMemberId).ValueGeneratedNever();

                entity.Property(e => e.IteamCost).HasMaxLength(3000);

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.HasOne(d => d.LinkageTrackingTool)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolDirectMember)
                    .HasForeignKey(d => d.LinkageTrackingToolId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingToolDirectMember_BeneficiaryLinkageTrackingTool");

                entity.HasOne(d => d.ServiceLinkedTo)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolDirectMember)
                    .HasForeignKey(d => d.ServiceLinkedToId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingToolDirectMember_A_ServiceLinkedTo");

                entity.HasOne(d => d.ServiceReceivedNavigation)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolDirectMember)
                    .HasForeignKey(d => d.ServiceReceived)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingToolDirectMember_A_YesNo");

                entity.HasOne(d => d.VslaGroupDirectMember)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolDirectMember)
                    .HasForeignKey(d => d.VslaGroupDirectMemberId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingToolDirectMember_HouseHoldMembers");
            });

            modelBuilder.Entity<BeneficiaryLinkageTrackingToolIndirectMember>(entity =>
            {
                entity.HasKey(e => e.LinkageTrackingToolIndirectMemberId)
                    .HasName("PK_Table_1");

                entity.Property(e => e.LinkageTrackingToolIndirectMemberId).ValueGeneratedNever();

                entity.Property(e => e.IteamCost).HasMaxLength(3000);

                entity.Property(e => e.VslaGroupIndirectMemberId).HasColumnName("VSLA_Group_Indirect_Member_Id");

                entity.HasOne(d => d.LinkageTrackingTool)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolIndirectMember)
                    .HasForeignKey(d => d.LinkageTrackingToolId)
                    .HasConstraintName("FK_Table_1_BeneficiaryLinkageTrackingTool");

                entity.HasOne(d => d.ServiceLinkedTo)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolIndirectMember)
                    .HasForeignKey(d => d.ServiceLinkedToId)
                    .HasConstraintName("FK_Table_1_A_ServiceLinkedTo");

                entity.HasOne(d => d.ServiceReceivedNavigation)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolIndirectMember)
                    .HasForeignKey(d => d.ServiceReceived)
                    .HasConstraintName("FK_Table_1_A_YesNo");

                entity.HasOne(d => d.VslaGroupIndirectMember)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolIndirectMember)
                    .HasForeignKey(d => d.VslaGroupIndirectMemberId)
                    .HasConstraintName("FK_BeneficiaryLinkageTrackingToolIndirectMember_VSLA_Group_Indirect_Member");
            });

            modelBuilder.Entity<BeneficiaryLinkageTrackingToolNew>(entity =>
            {
                entity.HasKey(e => e.LinkageTrackingToolId)
                    .HasName("PK_VSLA_Tracking_Tool_New");

                entity.Property(e => e.LinkageTrackingToolId).ValueGeneratedNever();

                entity.Property(e => e.DateProvidingService).HasColumnType("date");

                entity.Property(e => e.IteamCost).HasMaxLength(3000);

                entity.Property(e => e.LinkageDate).HasColumnType("date");

                entity.Property(e => e.PersonProvidingService).HasMaxLength(3000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewTitle).HasMaxLength(2000);

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");

                entity.Property(e => e.SubmittedBy).HasMaxLength(3000);

                entity.Property(e => e.SubmittedDate).HasColumnType("date");

                entity.Property(e => e.SubmittedTitle).HasMaxLength(2000);

                entity.Property(e => e.TitlePersonProvidingService).HasMaxLength(2000);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolNew)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_New_A_District");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolNew)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_New_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolNew)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_New_HouseHoldMembers");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolNew)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_New_A_ImplementingPartner");

                entity.HasOne(d => d.LinkageServiceCategory)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolNew)
                    .HasForeignKey(d => d.LinkageServiceCategoryId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_New_A_LinkageServiceCategory");

                entity.HasOne(d => d.ServiceLinkedTo)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolNew)
                    .HasForeignKey(d => d.ServiceLinkedToId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_New_A_ServiceLinkedTo");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolNew)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_New_A_Service_Provider");

                entity.HasOne(d => d.ServiceReceivedNavigation)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolNew)
                    .HasForeignKey(d => d.ServiceReceived)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_New_A_Service_Received");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.BeneficiaryLinkageTrackingToolNew)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_New_A_Subcounty");
            });

            modelBuilder.Entity<BusinessPlanDetail>(entity =>
            {
                entity.Property(e => e.BusinessPlanDetailId).ValueGeneratedNever();

                entity.HasOne(d => d.BusinessPlanHeader)
                    .WithMany(p => p.BusinessPlanDetail)
                    .HasForeignKey(d => d.BusinessPlanHeaderId)
                    .HasConstraintName("FK_BusinessPlanDetail_BusinessPlanHeader");

                entity.HasOne(d => d.BusinessPlanQuestion)
                    .WithMany(p => p.BusinessPlanDetail)
                    .HasForeignKey(d => d.BusinessPlanQuestionId)
                    .HasConstraintName("FK_BusinessPlanDetail_A_BusinessPlanQuestion");
            });

            modelBuilder.Entity<BusinessPlanHeader>(entity =>
            {
                entity.Property(e => e.BusinessPlanHeaderId).ValueGeneratedNever();

                entity.Property(e => e.DataCollectionDate).HasColumnType("date");

                entity.Property(e => e.DataCollectorName).HasMaxLength(3000);

                entity.Property(e => e.DataCollectorTitle).HasMaxLength(2000);

                entity.Property(e => e.DataReviewDate).HasColumnType("date");

                entity.Property(e => e.DataReviewerName).HasMaxLength(3000);

                entity.Property(e => e.DataReviewerTitle).HasMaxLength(2000);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.CategoryofResidence)
                    .WithMany(p => p.BusinessPlanHeader)
                    .HasForeignKey(d => d.CategoryofResidenceId)
                    .HasConstraintName("FK_BusinessPlanHeader_A_CategoryofResidence");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.BusinessPlanHeader)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_BusinessPlanHeader_A_District");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.BusinessPlanHeader)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_BusinessPlanHeader_A_Gender");

                entity.HasOne(d => d.Household)
                    .WithMany(p => p.BusinessPlanHeader)
                    .HasForeignKey(d => d.HouseholdId)
                    .HasConstraintName("FK_BusinessPlanHeader_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseholdMember)
                    .WithMany(p => p.BusinessPlanHeader)
                    .HasForeignKey(d => d.HouseholdMemberId)
                    .HasConstraintName("FK_BusinessPlanHeader_HouseHoldMembers");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.BusinessPlanHeader)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_BusinessPlanHeader_A_MaritalStatus");

                entity.HasOne(d => d.NatureofResidence)
                    .WithMany(p => p.BusinessPlanHeader)
                    .HasForeignKey(d => d.NatureofResidenceId)
                    .HasConstraintName("FK_BusinessPlanHeader_A_NatureofResidence");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.BusinessPlanHeader)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_BusinessPlanHeader_A_Parish");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.BusinessPlanHeader)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_BusinessPlanHeader_A_Subcounty");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.BusinessPlanHeader)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("FK_BusinessPlanHeader_A_Village");
            });

            modelBuilder.Entity<BusinessTrackingLedger>(entity =>
            {
                entity.Property(e => e.BusinessTrackingLedgerId).ValueGeneratedNever();

                entity.Property(e => e.DataCollectionDate).HasColumnType("date");

                entity.Property(e => e.DataCollectorName).HasMaxLength(3000);

                entity.Property(e => e.DataCollectorTitle).HasMaxLength(2000);

                entity.Property(e => e.DataReviewDate).HasColumnType("date");

                entity.Property(e => e.DataReviewerName).HasMaxLength(3000);

                entity.Property(e => e.DataReviewerTitle).HasMaxLength(2000);

                entity.Property(e => e.ProposedBusinessName).HasMaxLength(3000);
            });

            modelBuilder.Entity<BusinessTrackingLedgerMoc>(entity =>
            {
                entity.HasKey(e => e.MonthlyOperationalCostsId);

                entity.ToTable("BusinessTrackingLedgerMOC");

                entity.Property(e => e.MonthlyOperationalCostsId).ValueGeneratedNever();

                entity.Property(e => e.Item).HasMaxLength(3000);

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(3000);

                entity.HasOne(d => d.BusinessTrackingLedger)
                    .WithMany(p => p.BusinessTrackingLedgerMoc)
                    .HasForeignKey(d => d.BusinessTrackingLedgerId)
                    .HasConstraintName("FK_BusinessTrackingLedgerMOC_BusinessTrackingLedger");
            });

            modelBuilder.Entity<BusinessTrackingLedgerSue>(entity =>
            {
                entity.HasKey(e => e.StartUpExpensesId);

                entity.ToTable("BusinessTrackingLedgerSUE");

                entity.Property(e => e.StartUpExpensesId).ValueGeneratedNever();

                entity.Property(e => e.AvailableResources).HasMaxLength(3000);

                entity.Property(e => e.Item).HasMaxLength(3000);

                entity.Property(e => e.SourceofResources).HasMaxLength(3000);

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(3000);

                entity.HasOne(d => d.BusinessTrackingLedger)
                    .WithMany(p => p.BusinessTrackingLedgerSue)
                    .HasForeignKey(d => d.BusinessTrackingLedgerId)
                    .HasConstraintName("FK_BusinessTrackingLedgerSUE_BusinessTrackingLedger");
            });

            modelBuilder.Entity<CaseCare>(entity =>
            {
                entity.ToTable("Case_Care");

                entity.Property(e => e.CaseCareId)
                    .ValueGeneratedNever()
                    .HasColumnName("Case_Care_Id");

                entity.Property(e => e.AdministeringDate).HasColumnType("date");

                entity.Property(e => e.AdministeringPersonName).HasMaxLength(3000);

                entity.Property(e => e.AdministeringPersonPhoneNumber).HasMaxLength(2000);

                entity.Property(e => e.AdministeringPersonTitle).HasMaxLength(3000);

                entity.Property(e => e.AssessedBy).HasMaxLength(2000);

                entity.Property(e => e.AssessedDate).HasColumnType("date");

                entity.Property(e => e.HouseHoldPhoneNumber).HasMaxLength(50);

                entity.Property(e => e.InstitutionPriorityAreaCodeId).HasMaxLength(2000);

                entity.Property(e => e.NoFemale18Above).HasColumnName("No_Female18Above");

                entity.Property(e => e.NoFemale18Below).HasColumnName("No_Female18Below");

                entity.Property(e => e.NoMale18Above).HasColumnName("No_Male18Above");

                entity.Property(e => e.NoMale18Below).HasColumnName("No_Male18Below");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.CaseCare)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Case_Care_A_District");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.CaseCare)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_Case_Care_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.CaseCare)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_Case_Care_HouseHoldMembers");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.CaseCare)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_Case_Care_A_ImplementingPartner");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.CaseCare)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK_Case_Care_A_Service_Provider");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.CaseCare)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_Case_Care_A_Subcounty");
            });

            modelBuilder.Entity<CaseCareDetail>(entity =>
            {
                entity.HasKey(e => e.CaseCareDetailsId);

                entity.ToTable("Case_Care_Detail");

                entity.Property(e => e.CaseCareDetailsId).ValueGeneratedNever();

                entity.Property(e => e.CaseCareId).HasColumnName("Case_Care_Id");

                entity.HasOne(d => d.CaseCare)
                    .WithMany(p => p.CaseCareDetail)
                    .HasForeignKey(d => d.CaseCareId)
                    .HasConstraintName("FK_Case_Care_Detail_Case_Care");

                entity.HasOne(d => d.CasePlan)
                    .WithMany(p => p.CaseCareDetail)
                    .HasForeignKey(d => d.CasePlanId)
                    .HasConstraintName("FK_Case_Care_Detail_A_CasePlan");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.CaseCareDetail)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_Case_Care_Detail_HouseHoldMembers");
            });

            modelBuilder.Entity<CaseCareDetailPlan>(entity =>
            {
                entity.ToTable("Case_Care_Detail_Plan");

                entity.Property(e => e.CaseCareDetailPlanId)
                    .ValueGeneratedNever()
                    .HasColumnName("Case_Care_Detail_Plan_id");

                entity.Property(e => e.ActionCompletionActualDate).HasColumnType("date");

                entity.Property(e => e.ActionCompletionPlannedDate).HasColumnType("date");

                entity.Property(e => e.CasePlanStausId).HasColumnName("CasePLanStausId");

                entity.Property(e => e.PriorityAreaCodeId).HasMaxLength(2000);

                entity.Property(e => e.RefferalPriorityAreaCodeId).HasMaxLength(2000);

                entity.Property(e => e.ResponsiblePerson).HasMaxLength(3000);

                entity.HasOne(d => d.CaseCareDetails)
                    .WithMany(p => p.CaseCareDetailPlan)
                    .HasForeignKey(d => d.CaseCareDetailsId)
                    .HasConstraintName("FK_Case_Care_Detail_Plan_Case_Care_Detail");

                entity.HasOne(d => d.CasePlanStaus)
                    .WithMany(p => p.CaseCareDetailPlan)
                    .HasForeignKey(d => d.CasePlanStausId)
                    .HasConstraintName("FK_Case_Care_Detail_Plan_A_CasePLanStaus");

                entity.HasOne(d => d.PriorityArea)
                    .WithMany(p => p.CaseCareDetailPlan)
                    .HasForeignKey(d => d.PriorityAreaId)
                    .HasConstraintName("FK_Case_Care_Detail_Plan_A_Priority_Area");
            });

            modelBuilder.Entity<CaseCareSummary>(entity =>
            {
                entity.ToTable("Case_Care_Summary");

                entity.Property(e => e.CaseCareSummaryId).ValueGeneratedNever();

                entity.Property(e => e.AgencyContact).HasMaxLength(2000);

                entity.Property(e => e.CaseCareId).HasColumnName("Case_Care_Id");

                entity.Property(e => e.OrganisationName).HasMaxLength(3000);

                entity.Property(e => e.RefferalServiceReceivedId).HasMaxLength(2000);

                entity.HasOne(d => d.CaseCare)
                    .WithMany(p => p.CaseCareSummary)
                    .HasForeignKey(d => d.CaseCareId)
                    .HasConstraintName("FK_Case_Care_Summary_Case_Care");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.CaseCareSummary)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_Case_Care_Summary_HouseHoldMembers");
            });

            modelBuilder.Entity<CommunityTbSensitization>(entity =>
            {
                entity.HasKey(e => e.SensitizationId);

                entity.ToTable("Community_TB_Sensitization");

                entity.Property(e => e.SensitizationId).ValueGeneratedNever();

                entity.Property(e => e.ActivityDate).HasColumnType("date");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(3000)
                    .HasColumnName("Client_Name");

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IsSensitisedOnTb).HasColumnName("IsSensitisedOnTB");

                entity.Property(e => e.IsaclientapresumptiveTbcase).HasColumnName("IsaclientapresumptiveTBcase");

                entity.Property(e => e.PhoneNumber).HasMaxLength(1000);

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.CommunityTbSensitization)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_ActivityType");

                entity.HasOne(d => d.ClientReferedForEvaluationNavigation)
                    .WithMany(p => p.CommunityTbSensitizationClientReferedForEvaluationNavigation)
                    .HasForeignKey(d => d.ClientReferedForEvaluation)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_YesNo8");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.CommunityTbSensitization)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_District");

                entity.HasOne(d => d.ExcessiveNightSweatsNavigation)
                    .WithMany(p => p.CommunityTbSensitizationExcessiveNightSweatsNavigation)
                    .HasForeignKey(d => d.ExcessiveNightSweats)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_YesNo5");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.CommunityTbSensitization)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_Gender");

                entity.HasOne(d => d.HasFeverNavigation)
                    .WithMany(p => p.CommunityTbSensitizationHasFeverNavigation)
                    .HasForeignKey(d => d.HasFever)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_YesNo3");

                entity.HasOne(d => d.IsCoughingNavigation)
                    .WithMany(p => p.CommunityTbSensitizationIsCoughingNavigation)
                    .HasForeignKey(d => d.IsCoughing)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_YesNo1");

                entity.HasOne(d => d.IsCoughingUpBloodNavigation)
                    .WithMany(p => p.CommunityTbSensitizationIsCoughingUpBloodNavigation)
                    .HasForeignKey(d => d.IsCoughingUpBlood)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_YesNo2");

                entity.HasOne(d => d.IsSensitisedOnTbNavigation)
                    .WithMany(p => p.CommunityTbSensitizationIsSensitisedOnTbNavigation)
                    .HasForeignKey(d => d.IsSensitisedOnTb)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_YesNo");

                entity.HasOne(d => d.IsaclientapresumptiveTbcaseNavigation)
                    .WithMany(p => p.CommunityTbSensitizationIsaclientapresumptiveTbcaseNavigation)
                    .HasForeignKey(d => d.IsaclientapresumptiveTbcase)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_YesNo7");

                entity.HasOne(d => d.OtherSymptomsNavigation)
                    .WithMany(p => p.CommunityTbSensitizationOtherSymptomsNavigation)
                    .HasForeignKey(d => d.OtherSymptoms)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_YesNo6");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.CommunityTbSensitization)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_Parish");

                entity.HasOne(d => d.RequestedTestType)
                    .WithMany(p => p.CommunityTbSensitization)
                    .HasForeignKey(d => d.RequestedTestTypeId)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_RequestedTestType");

                entity.HasOne(d => d.SubCounty)
                    .WithMany(p => p.CommunityTbSensitization)
                    .HasForeignKey(d => d.SubCountyId)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_Subcounty");

                entity.HasOne(d => d.TbScreeningVenue)
                    .WithMany(p => p.CommunityTbSensitization)
                    .HasForeignKey(d => d.TbScreeningVenueId)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_TbScreeningVenue");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.CommunityTbSensitization)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_Village");

                entity.HasOne(d => d.WeightLossNavigation)
                    .WithMany(p => p.CommunityTbSensitizationWeightLossNavigation)
                    .HasForeignKey(d => d.WeightLoss)
                    .HasConstraintName("FK_Community_TB_Sensitization_A_YesNo4");
            });

            modelBuilder.Entity<CommunityTrainingRegister>(entity =>
            {
                entity.Property(e => e.CommunityTrainingRegisterId).ValueGeneratedNever();

                entity.Property(e => e.CoodinatedBy).HasMaxLength(3000);

                entity.Property(e => e.CoordinatorDate).HasColumnType("date");

                entity.Property(e => e.CoordinatorPhoneNumber).HasMaxLength(1000);

                entity.Property(e => e.CurriculumId).HasColumnName("Curriculum_Id");

                entity.Property(e => e.GroupCode).HasMaxLength(2000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.ReviewerPhoneNumber).HasMaxLength(1000);

                entity.Property(e => e.Trainer).HasMaxLength(3000);

                entity.Property(e => e.TrainingEndDate).HasColumnType("date");

                entity.Property(e => e.TrainingStartDate).HasColumnType("date");

                entity.Property(e => e.TrainingVenue).HasMaxLength(3000);

                entity.HasOne(d => d.Curriculum)
                    .WithMany(p => p.CommunityTrainingRegister)
                    .HasForeignKey(d => d.CurriculumId)
                    .HasConstraintName("FK_CommunityTrainingRegister_A_Trainning_Curriculum");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.CommunityTrainingRegister)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_CommunityTrainingRegister_A_District");

                entity.HasOne(d => d.GroupCompositionCodeNavigation)
                    .WithMany(p => p.CommunityTrainingRegister)
                    .HasForeignKey(d => d.GroupCompositionCode)
                    .HasConstraintName("FK_CommunityTrainingRegister_VSLA_Group_Composition");

                entity.HasOne(d => d.GroupCycle)
                    .WithMany(p => p.CommunityTrainingRegister)
                    .HasForeignKey(d => d.GroupCycleId)
                    .HasConstraintName("FK_CommunityTrainingRegister_A_GroupCycle");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CommunityTrainingRegister)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_CommunityTrainingRegister_A_Groups");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.CommunityTrainingRegister)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_CommunityTrainingRegister_A_ImplementingPartner");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.CommunityTrainingRegister)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_CommunityTrainingRegister_A_Subcounty");
            });

            modelBuilder.Entity<CommunityTrainingRegisterDirectMember>(entity =>
            {
                entity.Property(e => e.CommunityTrainingRegisterDirectMemberId).ValueGeneratedNever();

                entity.Property(e => e.SessionDate).HasColumnType("date");

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.HasOne(d => d.CommunityTrainingRegister)
                    .WithMany(p => p.CommunityTrainingRegisterDirectMember)
                    .HasForeignKey(d => d.CommunityTrainingRegisterId)
                    .HasConstraintName("FK_CommunityTrainingRegisterDirectMember_CommunityTrainingRegister");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.CommunityTrainingRegisterDirectMember)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_CommunityTrainingRegisterDirectMember_A_Training_Session");

                entity.HasOne(d => d.VslaGroupDirectMember)
                    .WithMany(p => p.CommunityTrainingRegisterDirectMember)
                    .HasForeignKey(d => d.VslaGroupDirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CommunityTrainingRegisterDirectMember_HouseHoldMembers");
            });

            modelBuilder.Entity<CommunityTrainingRegisterIndirectMember>(entity =>
            {
                entity.Property(e => e.CommunityTrainingRegisterIndirectMemberId).ValueGeneratedNever();

                entity.Property(e => e.SessionDate).HasColumnType("date");

                entity.Property(e => e.VslaGroupIndirectMemberId).HasColumnName("VSLA_Group_Indirect_Member_Id");

                entity.HasOne(d => d.CommunityTrainingRegister)
                    .WithMany(p => p.CommunityTrainingRegisterIndirectMember)
                    .HasForeignKey(d => d.CommunityTrainingRegisterId)
                    .HasConstraintName("FK_CommunityTrainingRegisterIndirectMember_CommunityTrainingRegister");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.CommunityTrainingRegisterIndirectMember)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_CommunityTrainingRegisterIndirectMember_A_Training_Session");

                entity.HasOne(d => d.VslaGroupIndirectMember)
                    .WithMany(p => p.CommunityTrainingRegisterIndirectMember)
                    .HasForeignKey(d => d.VslaGroupIndirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CommunityTrainingRegisterIndirectMember_VSLA_Group_Indirect_Member");
            });

            modelBuilder.Entity<EcdAttendenceRegister>(entity =>
            {
                entity.HasKey(e => e.SinoParentingId);

                entity.ToTable("ECD_Attendence_Register");

                entity.Property(e => e.SinoParentingId).ValueGeneratedNever();

                entity.Property(e => e.FacilitatorOne).HasMaxLength(3000);

                entity.Property(e => e.FacilitatorOneCode).HasMaxLength(1000);

                entity.Property(e => e.FacilitatorTwo).HasMaxLength(3000);

                entity.Property(e => e.FacilitatorTwoCode).HasMaxLength(1000);

                entity.Property(e => e.MotherSpace).HasMaxLength(3000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewTitle).HasMaxLength(2000);

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.SubmittedBy).HasMaxLength(3000);

                entity.Property(e => e.SubmittedDate).HasColumnType("date");

                entity.Property(e => e.SubmittedTitle).HasMaxLength(2000);

                entity.Property(e => e.Venue).HasMaxLength(3000);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.EcdAttendenceRegister)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_ECD_Attendence_Register_A_District");

                entity.HasOne(d => d.GroupCompositionCodeNavigation)
                    .WithMany(p => p.EcdAttendenceRegister)
                    .HasForeignKey(d => d.GroupCompositionCode)
                    .HasConstraintName("FK_ECD_Attendence_Register_VSLA_Group_Composition");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.EcdAttendenceRegister)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_ECD_Attendence_Register_A_Groups");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.EcdAttendenceRegister)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_ECD_Attendence_Register_A_ImplementingPartner");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.EcdAttendenceRegister)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_ECD_Attendence_Register_A_Parish");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.EcdAttendenceRegister)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_ECD_Attendence_Register_A_Subcounty");
            });

            modelBuilder.Entity<EcdDirectMemberAttendence>(entity =>
            {
                entity.HasKey(e => e.SinoParentingDirectMemberId);

                entity.ToTable("ECD_DirectMember_Attendence");

                entity.Property(e => e.SinoParentingDirectMemberId).ValueGeneratedNever();

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.HasOne(d => d.CareTakerHouseholdMember)
                    .WithMany(p => p.EcdDirectMemberAttendence)
                    .HasForeignKey(d => d.CareTakerHouseholdMemberId)
                    .HasConstraintName("FK_ECD_DirectMember_Attendence_HouseHoldMembers");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.EcdDirectMemberAttendence)
                    .HasForeignKey(d => d.RelationshipId)
                    .HasConstraintName("FK_ECD_DirectMember_Attendence_A_Relationship");

                entity.HasOne(d => d.SinoParenting)
                    .WithMany(p => p.EcdDirectMemberAttendence)
                    .HasForeignKey(d => d.SinoParentingId)
                    .HasConstraintName("FK_ECD_DirectMember_Attendence_ECD_Attendence_Register");

                entity.HasOne(d => d.VslaGroupDirectMember)
                    .WithMany(p => p.EcdDirectMemberAttendence)
                    .HasForeignKey(d => d.VslaGroupDirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ECD_DirectMember_Attendence_VSLA_Group_Direct_Members");
            });

            modelBuilder.Entity<EcdDirectMemberDetail>(entity =>
            {
                entity.HasKey(e => e.SinoParentingDirectMemberDetailId);

                entity.ToTable("ECD_DirectMember_Detail");

                entity.Property(e => e.SinoParentingDirectMemberDetailId).ValueGeneratedNever();

                entity.Property(e => e.ParentAttended).HasColumnName("Parent_Attended");

                entity.Property(e => e.SessionDate).HasColumnType("datetime");

                entity.Property(e => e.TeenAttended).HasColumnName("Teen_Attended");

                entity.HasOne(d => d.ParentAttendedNavigation)
                    .WithMany(p => p.EcdDirectMemberDetailParentAttendedNavigation)
                    .HasForeignKey(d => d.ParentAttended)
                    .HasConstraintName("FK_ECD_DirectMember_Detail_A_YesNo1");

                entity.HasOne(d => d.ParentingGroupSession)
                    .WithMany(p => p.EcdDirectMemberDetail)
                    .HasForeignKey(d => d.ParentingGroupSessionId)
                    .HasConstraintName("FK_ECD_DirectMember_Detail_A_ParentingGroupSession");

                entity.HasOne(d => d.SinoParentingDirectMember)
                    .WithMany(p => p.EcdDirectMemberDetail)
                    .HasForeignKey(d => d.SinoParentingDirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ECD_DirectMember_Detail_ECD_DirectMember_Attendence");

                entity.HasOne(d => d.TeenAttendedNavigation)
                    .WithMany(p => p.EcdDirectMemberDetailTeenAttendedNavigation)
                    .HasForeignKey(d => d.TeenAttended)
                    .HasConstraintName("FK_ECD_DirectMember_Detail_A_YesNo");
            });

            modelBuilder.Entity<EcdIndirectMemberAttendence>(entity =>
            {
                entity.HasKey(e => e.SinoParentingIndirectMemberId);

                entity.ToTable("ECD_IndirectMember_Attendence");

                entity.Property(e => e.SinoParentingIndirectMemberId).ValueGeneratedNever();

                entity.Property(e => e.CareTakerGenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CareTakerHouseholdMemberCode).HasMaxLength(1000);

                entity.Property(e => e.CareTakerName).HasMaxLength(3000);

                entity.Property(e => e.VslaGroupIndirectMemberId).HasColumnName("VSLA_Group_Indirect_Member_Id");

                entity.HasOne(d => d.CareTakerGender)
                    .WithMany(p => p.EcdIndirectMemberAttendence)
                    .HasForeignKey(d => d.CareTakerGenderId)
                    .HasConstraintName("FK_ECD_IndirectMember_Attendence_A_Gender");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.EcdIndirectMemberAttendence)
                    .HasForeignKey(d => d.RelationshipId)
                    .HasConstraintName("FK_ECD_IndirectMember_Attendence_A_Relationship");

                entity.HasOne(d => d.SinoParenting)
                    .WithMany(p => p.EcdIndirectMemberAttendence)
                    .HasForeignKey(d => d.SinoParentingId)
                    .HasConstraintName("FK_ECD_IndirectMember_Attendence_ECD_Attendence_Register");

                entity.HasOne(d => d.VslaGroupIndirectMember)
                    .WithMany(p => p.EcdIndirectMemberAttendence)
                    .HasForeignKey(d => d.VslaGroupIndirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ECD_IndirectMember_Attendence_VSLA_Group_Indirect_Member");
            });

            modelBuilder.Entity<EcdIndirectMemberDetail>(entity =>
            {
                entity.HasKey(e => e.SinoParentingIndirectMemberDetailId);

                entity.ToTable("ECD_IndirectMember_Detail");

                entity.Property(e => e.SinoParentingIndirectMemberDetailId).ValueGeneratedNever();

                entity.Property(e => e.ParentAttended).HasColumnName("Parent_Attended");

                entity.Property(e => e.SessionDate).HasColumnType("datetime");

                entity.Property(e => e.TeenAttended).HasColumnName("Teen_Attended");

                entity.HasOne(d => d.ParentAttendedNavigation)
                    .WithMany(p => p.EcdIndirectMemberDetailParentAttendedNavigation)
                    .HasForeignKey(d => d.ParentAttended)
                    .HasConstraintName("FK_ECD_IndirectMember_Detail_A_YesNo");

                entity.HasOne(d => d.ParentingGroupSession)
                    .WithMany(p => p.EcdIndirectMemberDetail)
                    .HasForeignKey(d => d.ParentingGroupSessionId)
                    .HasConstraintName("FK_ECD_IndirectMember_Detail_A_ParentingGroupSession");

                entity.HasOne(d => d.SinoParentingIndirectMember)
                    .WithMany(p => p.EcdIndirectMemberDetail)
                    .HasForeignKey(d => d.SinoParentingIndirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ECD_IndirectMember_Detail_ECD_IndirectMember_Attendence");

                entity.HasOne(d => d.TeenAttendedNavigation)
                    .WithMany(p => p.EcdIndirectMemberDetailTeenAttendedNavigation)
                    .HasForeignKey(d => d.TeenAttended)
                    .HasConstraintName("FK_ECD_IndirectMember_Detail_A_YesNo1");
            });

            modelBuilder.Entity<Ecdgroups3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ECDGroups_3");

                entity.Property(e => e.Age).HasColumnName("Age  ");

                entity.Property(e => e.CheckedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Checked by");

                entity.Property(e => e.Date)
                    .HasMaxLength(255)
                    .HasColumnName("DATE");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(2101)
                    .HasColumnName("Group Code");

                entity.Property(e => e.HhIndividualCode)
                    .HasMaxLength(255)
                    .HasColumnName("HH individual Code");

                entity.Property(e => e.MeetingTime)
                    .HasMaxLength(255)
                    .HasColumnName("Meeting Time");

                entity.Property(e => e.MeetingVenue)
                    .HasMaxLength(255)
                    .HasColumnName("Meeting Venue");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("Name ");

                entity.Property(e => e.SexMF)
                    .HasMaxLength(255)
                    .HasColumnName("Sex M/F ");

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Verified by");

                entity.Property(e => e.Village)
                    .HasMaxLength(255)
                    .HasColumnName("Village ");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.Property(e => e.ErrorDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GraduationBenchMark>(entity =>
            {
                entity.Property(e => e.GraduationBenchMarkId).ValueGeneratedNever();

                entity.Property(e => e.AdministeringPersonName).HasMaxLength(3000);

                entity.Property(e => e.AdministeringPersonPhoneNumber).HasMaxLength(100);

                entity.Property(e => e.AssessmentDate).HasColumnType("date");

                entity.Property(e => e.AssessorCode).HasMaxLength(1000);

                entity.Property(e => e.AssessorTitle).HasMaxLength(2000);

                entity.Property(e => e.HivpreventionKnowledgeAssessmentYesNoId).HasColumnName("HIVPreventionKnowledgeAssessmentYesNoId");

                entity.Property(e => e.NameofAssessor).HasMaxLength(3000);

                entity.HasOne(d => d.ChildHeadedHouseholdAssessmentYesNo)
                    .WithMany(p => p.GraduationBenchMarkChildHeadedHouseholdAssessmentYesNo)
                    .HasForeignKey(d => d.ChildHeadedHouseholdAssessmentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo11");

                entity.HasOne(d => d.ChildrenInSchoolAssessmentYesNo)
                    .WithMany(p => p.GraduationBenchMarkChildrenInSchoolAssessmentYesNo)
                    .HasForeignKey(d => d.ChildrenInSchoolAssessmentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo12");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.GraduationBenchMark)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_GraduationBenchMark_A_District");

                entity.HasOne(d => d.HivpreventionKnowledgeAssessmentYesNo)
                    .WithMany(p => p.GraduationBenchMarkHivpreventionKnowledgeAssessmentYesNo)
                    .HasForeignKey(d => d.HivpreventionKnowledgeAssessmentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo2");

                entity.HasOne(d => d.Household)
                    .WithMany(p => p.GraduationBenchMark)
                    .HasForeignKey(d => d.HouseholdId)
                    .HasConstraintName("FK_GraduationBenchMark_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseholdStatus)
                    .WithMany(p => p.GraduationBenchMark)
                    .HasForeignKey(d => d.HouseholdStatusId)
                    .HasConstraintName("FK_GraduationBenchMark_A_EnrolledHouseholdStatus");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.GraduationBenchMark)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_GraduationBenchMark_A_ImplementingPartner");

                entity.HasOne(d => d.ImprovedfinancialstabilityAssessmentYesNo)
                    .WithMany(p => p.GraduationBenchMarkImprovedfinancialstabilityAssessmentYesNo)
                    .HasForeignKey(d => d.ImprovedfinancialstabilityAssessmentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo4");

                entity.HasOne(d => d.ImprovedfinancialstabilityScholashipYesNo)
                    .WithMany(p => p.GraduationBenchMarkImprovedfinancialstabilityScholashipYesNo)
                    .HasForeignKey(d => d.ImprovedfinancialstabilityScholashipYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo5");

                entity.HasOne(d => d.ImprovedfinancialstabilitySellingIncomeGeneratingSomethingYesNo)
                    .WithMany(p => p.GraduationBenchMarkImprovedfinancialstabilitySellingIncomeGeneratingSomethingYesNo)
                    .HasForeignKey(d => d.ImprovedfinancialstabilitySellingIncomeGeneratingSomethingYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo6");

                entity.HasOne(d => d.KnownHiveStatusAssessmentYesNo)
                    .WithMany(p => p.GraduationBenchMarkKnownHiveStatusAssessmentYesNo)
                    .HasForeignKey(d => d.KnownHiveStatusAssessmentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo");

                entity.HasOne(d => d.MedicalCostAssessmentYesNo)
                    .WithMany(p => p.GraduationBenchMarkMedicalCostAssessmentYesNo)
                    .HasForeignKey(d => d.MedicalCostAssessmentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo7");

                entity.HasOne(d => d.MedicalCostCashTransfertYesNo)
                    .WithMany(p => p.GraduationBenchMarkMedicalCostCashTransfertYesNo)
                    .HasForeignKey(d => d.MedicalCostCashTransfertYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo8");

                entity.HasOne(d => d.MedicalCostSellingIncomeGeneratingSomethingYesNo)
                    .WithMany(p => p.GraduationBenchMarkMedicalCostSellingIncomeGeneratingSomethingYesNo)
                    .HasForeignKey(d => d.MedicalCostSellingIncomeGeneratingSomethingYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo9");

                entity.HasOne(d => d.NoViolenceAssesmentYesNo)
                    .WithMany(p => p.GraduationBenchMarkNoViolenceAssesmentYesNo)
                    .HasForeignKey(d => d.NoViolenceAssesmentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo10");

                entity.HasOne(d => d.NotundernourishedAssessmentYesNo)
                    .WithMany(p => p.GraduationBenchMarkNotundernourishedAssessmentYesNo)
                    .HasForeignKey(d => d.NotundernourishedAssessmentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo3");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.GraduationBenchMark)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_GraduationBenchMark_A_Parish");

                entity.HasOne(d => d.SubCounty)
                    .WithMany(p => p.GraduationBenchMark)
                    .HasForeignKey(d => d.SubCountyId)
                    .HasConstraintName("FK_GraduationBenchMark_A_Subcounty");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.GraduationBenchMark)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("FK_GraduationBenchMark_A_Village");

                entity.HasOne(d => d.VirallySuppressedAssessmentYesNo)
                    .WithMany(p => p.GraduationBenchMarkVirallySuppressedAssessmentYesNo)
                    .HasForeignKey(d => d.VirallySuppressedAssessmentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMark_A_YesNo1");
            });

            modelBuilder.Entity<GraduationBenchMarkDetail>(entity =>
            {
                entity.Property(e => e.GraduationBenchMarkDetailId).ValueGeneratedNever();

                entity.Property(e => e.AdolescentidentifiedatleastoneHivpreventionstrategyYesNoId).HasColumnName("AdolescentidentifiedatleastoneHIVpreventionstrategyYesNoId");

                entity.Property(e => e.AdolescentidentifiedatleasttwoHivrisksYesNoId).HasColumnName("AdolescentidentifiedatleasttwoHIVrisksYesNoId");

                entity.Property(e => e.ChildMuacmorethan125cmYesNoId).HasColumnName("ChildMuacmorethan12_5cmYesNoId");

                entity.HasOne(d => d.AdolescentidentifiedatleastoneHivpreventionstrategyYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailAdolescentidentifiedatleastoneHivpreventionstrategyYesNo)
                    .HasForeignKey(d => d.AdolescentidentifiedatleastoneHivpreventionstrategyYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo6");

                entity.HasOne(d => d.AdolescentidentifiedatleasttwoHivrisksYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailAdolescentidentifiedatleasttwoHivrisksYesNo)
                    .HasForeignKey(d => d.AdolescentidentifiedatleasttwoHivrisksYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo7");

                entity.HasOne(d => d.AreenrolledinschoolYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailAreenrolledinschoolYesNo)
                    .HasForeignKey(d => d.AreenrolledinschoolYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo13");

                entity.HasOne(d => d.AttendedschoolregularlyoverthepastyearYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailAttendedschoolregularlyoverthepastyearYesNo)
                    .HasForeignKey(d => d.AttendedschoolregularlyoverthepastyearYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo14");

                entity.HasOne(d => d.BeneficiariesbeentakingantiretroviraltherapypillsasprescribedYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailBeneficiariesbeentakingantiretroviraltherapypillsasprescribedYesNo)
                    .HasForeignKey(d => d.BeneficiariesbeentakingantiretroviraltherapypillsasprescribedYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo5");

                entity.HasOne(d => d.ChildMuacmorethan125cmYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailChildMuacmorethan125cmYesNo)
                    .HasForeignKey(d => d.ChildMuacmorethan125cmYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo9");

                entity.HasOne(d => d.ChildfreeofanysignsofbipedaledemaYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailChildfreeofanysignsofbipedaledemaYesNo)
                    .HasForeignKey(d => d.ChildfreeofanysignsofbipedaledemaYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo8");

                entity.HasOne(d => d.DocumentedAsVirallySuppressedYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailDocumentedAsVirallySuppressedYesNo)
                    .HasForeignKey(d => d.DocumentedAsVirallySuppressedYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo3");

                entity.HasOne(d => d.GraduationBenchMark)
                    .WithMany(p => p.GraduationBenchMarkDetail)
                    .HasForeignKey(d => d.GraduationBenchMarkId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_GraduationBenchMark");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.GraduationBenchMarkDetail)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_HouseHoldMembers");

                entity.HasOne(d => d.HouseholdMembersbeenunderthecareofastableadultcaregiverYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailHouseholdMembersbeenunderthecareofastableadultcaregiverYesNo)
                    .HasForeignKey(d => d.HouseholdMembersbeenunderthecareofastableadultcaregiverYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo12");

                entity.HasOne(d => d.IsHouseholdMemberActiveYesNoNavigation)
                    .WithMany(p => p.GraduationBenchMarkDetailIsHouseholdMemberActiveYesNoNavigation)
                    .HasForeignKey(d => d.IsHouseholdMemberActiveYesNo)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo");

                entity.HasOne(d => d.MemberHivStatusDocumentYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailMemberHivStatusDocumentYesNo)
                    .HasForeignKey(d => d.MemberHivStatusDocumentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo1");

                entity.HasOne(d => d.PrimaryCareGiverHiveStatusDocumentedYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailPrimaryCareGiverHiveStatusDocumentedYesNo)
                    .HasForeignKey(d => d.PrimaryCareGiverHiveStatusDocumentedYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo2");

                entity.HasOne(d => d.ProgressedtonextclassfromlastyeartothisschoolyearYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailProgressedtonextclassfromlastyeartothisschoolyearYesNo)
                    .HasForeignKey(d => d.ProgressedtonextclassfromlastyeartothisschoolyearYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo15");

                entity.HasOne(d => d.RegularyAttendingArtAppointmentYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailRegularyAttendingArtAppointmentYesNo)
                    .HasForeignKey(d => d.RegularyAttendingArtAppointmentYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo4");

                entity.HasOne(d => d.RepeatedphysicalabuseYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailRepeatedphysicalabuseYesNo)
                    .HasForeignKey(d => d.RepeatedphysicalabuseYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo10");

                entity.HasOne(d => d.SexuallyabusedYesNo)
                    .WithMany(p => p.GraduationBenchMarkDetailSexuallyabusedYesNo)
                    .HasForeignKey(d => d.SexuallyabusedYesNoId)
                    .HasConstraintName("FK_GraduationBenchMarkDetail_A_YesNo11");
            });

            modelBuilder.Entity<GraduationChecklistDetail>(entity =>
            {
                entity.Property(e => e.GraduationChecklistDetailId).ValueGeneratedNever();

                entity.Property(e => e.ResponseYesNoId)
                    .HasColumnName("Response_YesNoId")
                    .HasDefaultValueSql("((3))");

                entity.HasOne(d => d.GraduationChecklist)
                    .WithMany(p => p.GraduationChecklistDetail)
                    .HasForeignKey(d => d.GraduationChecklistId)
                    .HasConstraintName("FK_GraduationChecklistDetail_GraduationChecklistHeader");

                entity.HasOne(d => d.GraduationCriteria)
                    .WithMany(p => p.GraduationChecklistDetail)
                    .HasForeignKey(d => d.GraduationCriteriaId)
                    .HasConstraintName("FK_GraduationChecklistDetail_A_GraduationCriteria");

                entity.HasOne(d => d.ResponseYesNo)
                    .WithMany(p => p.GraduationChecklistDetail)
                    .HasForeignKey(d => d.ResponseYesNoId)
                    .HasConstraintName("FK_GraduationChecklistDetail_A_YesNo");
            });

            modelBuilder.Entity<GraduationChecklistHeader>(entity =>
            {
                entity.HasKey(e => e.GraduationChecklistId);

                entity.Property(e => e.GraduationChecklistId).ValueGeneratedNever();

                entity.Property(e => e.AssessmentDate).HasColumnType("date");

                entity.Property(e => e.AssessorName).HasMaxLength(3000);

                entity.Property(e => e.AssessorTel).HasMaxLength(3000);

                entity.Property(e => e.AssessorTitle).HasMaxLength(3000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewerName).HasMaxLength(3000);

                entity.Property(e => e.ReviewerTitle).HasMaxLength(3000);

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.GraduationChecklistHeader)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_GraduationChecklistHeader_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.GraduationChecklistHeader)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_GraduationChecklistHeader_HouseHoldMembers");
            });

            modelBuilder.Entity<HivTbRisKassessmentTool>(entity =>
            {
                entity.HasKey(e => e.TbriskAssessmentId);

                entity.ToTable("HIV_TB_RisKAssessmentTool");

                entity.Property(e => e.TbriskAssessmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("TBRiskAssessmentId");

                entity.Property(e => e.ArtNumber)
                    .HasMaxLength(2000)
                    .HasColumnName("Art_Number");

                entity.Property(e => e.ChildHadContactWithActiveTbdiseaseAdult).HasColumnName("ChildHadContactWithActiveTBDiseaseAdult");

                entity.Property(e => e.ChildHivsymptomatic).HasColumnName("ChildHIVSymptomatic");

                entity.Property(e => e.ChildLivesWithHivpositiveMotherOrFather).HasColumnName("ChildLivesWithHIVPositiveMotherOrFather");

                entity.Property(e => e.ClientHasNewHepatitisBdiagnosis).HasColumnName("ClientHasNewHepatitisBDiagnosis");

                entity.Property(e => e.ClientHasPresumptiveActiveTbdisease).HasColumnName("ClientHasPresumptiveActiveTBDisease");

                entity.Property(e => e.ClientIsMaleOrFemaleWithnoHivtest).HasColumnName("ClientIsMaleOrFemaleWithnoHIVTest");

                entity.Property(e => e.HivnegativePartnerInDiscordantRelationship).HasColumnName("HIVNegativePartnerInDiscordantRelationship");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.TbriskAssessmentHeaderId).HasColumnName("TBRiskAssessmentHeaderId");

                entity.HasOne(d => d.BeenCoughingForTwoWeekNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolBeenCoughingForTwoWeekNavigation)
                    .HasForeignKey(d => d.BeenCoughingForTwoWeek)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo11");

                entity.HasOne(d => d.ChildAdmittedToHospitalInSixMonthsNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildAdmittedToHospitalInSixMonthsNavigation)
                    .HasForeignKey(d => d.ChildAdmittedToHospitalInSixMonths)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo15");

                entity.HasOne(d => d.ChildCoughingForTwoWeeksNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildCoughingForTwoWeeksNavigation)
                    .HasForeignKey(d => d.ChildCoughingForTwoWeeks)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo23");

                entity.HasOne(d => d.ChildDignosedWithTuberculosisNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildDignosedWithTuberculosisNavigation)
                    .HasForeignKey(d => d.ChildDignosedWithTuberculosis)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo19");

                entity.HasOne(d => d.ChildDrugAbuseOrAlcoholNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildDrugAbuseOrAlcoholNavigation)
                    .HasForeignKey(d => d.ChildDrugAbuseOrAlcohol)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo22");

                entity.HasOne(d => d.ChildExperiencedExcessiveNightSweetingNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildExperiencedExcessiveNightSweetingNavigation)
                    .HasForeignKey(d => d.ChildExperiencedExcessiveNightSweeting)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo27");

                entity.HasOne(d => d.ChildHadContactWithActiveTbdiseaseAdultNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildHadContactWithActiveTbdiseaseAdultNavigation)
                    .HasForeignKey(d => d.ChildHadContactWithActiveTbdiseaseAdult)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo26");

                entity.HasOne(d => d.ChildHadPersistentFeverHstoryNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildHadPersistentFeverHstoryNavigation)
                    .HasForeignKey(d => d.ChildHadPersistentFeverHstory)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo24");

                entity.HasOne(d => d.ChildHasAccidentalExposureNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildHasAccidentalExposureNavigation)
                    .HasForeignKey(d => d.ChildHasAccidentalExposure)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo21");

                entity.HasOne(d => d.ChildHasPoorWeightGainNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildHasPoorWeightGainNavigation)
                    .HasForeignKey(d => d.ChildHasPoorWeightGain)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo25");

                entity.HasOne(d => d.ChildHasSexualAbuseHistoryNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildHasSexualAbuseHistoryNavigation)
                    .HasForeignKey(d => d.ChildHasSexualAbuseHistory)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo20");

                entity.HasOne(d => d.ChildHivsymptomaticNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildHivsymptomaticNavigation)
                    .HasForeignKey(d => d.ChildHivsymptomatic)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo17");

                entity.HasOne(d => d.ChildLivesWithHivpositiveMotherOrFatherNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildLivesWithHivpositiveMotherOrFatherNavigation)
                    .HasForeignKey(d => d.ChildLivesWithHivpositiveMotherOrFather)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo16");

                entity.HasOne(d => d.ChildMalnourishedNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolChildMalnourishedNavigation)
                    .HasForeignKey(d => d.ChildMalnourished)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo18");

                entity.HasOne(d => d.ClientFallsInSexWorkersCategoryNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolClientFallsInSexWorkersCategoryNavigation)
                    .HasForeignKey(d => d.ClientFallsInSexWorkersCategory)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo3");

                entity.HasOne(d => d.ClientHadUnprotectedSexInPastThreeMonthNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolClientHadUnprotectedSexInPastThreeMonthNavigation)
                    .HasForeignKey(d => d.ClientHadUnprotectedSexInPastThreeMonth)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo2");

                entity.HasOne(d => d.ClientHasHistoryOfIllnessNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolClientHasHistoryOfIllnessNavigation)
                    .HasForeignKey(d => d.ClientHasHistoryOfIllness)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo8");

                entity.HasOne(d => d.ClientHasLossOfSexualPartnerHistoryNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolClientHasLossOfSexualPartnerHistoryNavigation)
                    .HasForeignKey(d => d.ClientHasLossOfSexualPartnerHistory)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo9");

                entity.HasOne(d => d.ClientHasNewHepatitisBdiagnosisNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolClientHasNewHepatitisBdiagnosisNavigation)
                    .HasForeignKey(d => d.ClientHasNewHepatitisBdiagnosis)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo7");

                entity.HasOne(d => d.ClientHasPresumptiveActiveTbdiseaseNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolClientHasPresumptiveActiveTbdiseaseNavigation)
                    .HasForeignKey(d => d.ClientHasPresumptiveActiveTbdisease)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo6");

                entity.HasOne(d => d.ClientIsMaleOrFemaleWithnoHivtestNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolClientIsMaleOrFemaleWithnoHivtestNavigation)
                    .HasForeignKey(d => d.ClientIsMaleOrFemaleWithnoHivtest)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo10");

                entity.HasOne(d => d.ClientWithSexuallyTransmittedInfectionNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolClientWithSexuallyTransmittedInfectionNavigation)
                    .HasForeignKey(d => d.ClientWithSexuallyTransmittedInfection)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo5");

                entity.HasOne(d => d.ExperiencedExcessiveNightSweatsNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolExperiencedExcessiveNightSweatsNavigation)
                    .HasForeignKey(d => d.ExperiencedExcessiveNightSweats)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo14");

                entity.HasOne(d => d.HaveYouLostWeightNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolHaveYouLostWeightNavigation)
                    .HasForeignKey(d => d.HaveYouLostWeight)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo13");

                entity.HasOne(d => d.HivnegativePartnerInDiscordantRelationshipNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolHivnegativePartnerInDiscordantRelationshipNavigation)
                    .HasForeignKey(d => d.HivnegativePartnerInDiscordantRelationship)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo4");

                entity.HasOne(d => d.Hivstatus)
                    .WithMany(p => p.HivTbRisKassessmentTool)
                    .HasForeignKey(d => d.HivstatusId)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_HIVStatus");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.HivTbRisKassessmentTool)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_HouseHoldMembers");

                entity.HasOne(d => d.IsOnArtNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolIsOnArtNavigation)
                    .HasForeignKey(d => d.IsOnArt)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo");

                entity.HasOne(d => d.IsVirallaodTestDoneNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolIsVirallaodTestDoneNavigation)
                    .HasForeignKey(d => d.IsVirallaodTestDone)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo1");

                entity.HasOne(d => d.PersistentFeverForTwoWeeksNavigation)
                    .WithMany(p => p.HivTbRisKassessmentToolPersistentFeverForTwoWeeksNavigation)
                    .HasForeignKey(d => d.PersistentFeverForTwoWeeks)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_YesNo12");

                entity.HasOne(d => d.TbriskAssessmentHeader)
                    .WithMany(p => p.HivTbRisKassessmentTool)
                    .HasForeignKey(d => d.TbriskAssessmentHeaderId)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_HIV_TB_RisKAssessmentToolHeader");

                entity.HasOne(d => d.ViralLoadLevel)
                    .WithMany(p => p.HivTbRisKassessmentTool)
                    .HasForeignKey(d => d.ViralLoadLevelId)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentTool_A_ViralLoadLevel");
            });

            modelBuilder.Entity<HivTbRisKassessmentToolHeader>(entity =>
            {
                entity.HasKey(e => e.TbriskAssessmentHeaderId);

                entity.ToTable("HIV_TB_RisKAssessmentToolHeader");

                entity.Property(e => e.TbriskAssessmentHeaderId)
                    .ValueGeneratedNever()
                    .HasColumnName("TBRiskAssessmentHeaderId");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.HivTbRisKassessmentToolHeader)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentToolHeader_A_District");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.HivTbRisKassessmentToolHeader)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentToolHeader_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.HivTbRisKassessmentToolHeader)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_HIV_TB_RisKAssessmentToolHeader_A_Subcounty");
            });

            modelBuilder.Entity<HivTbTrackingForm>(entity =>
            {
                entity.ToTable("HIV_TB_TrackingForm");

                entity.Property(e => e.HivTbTrackingFormId)
                    .ValueGeneratedNever()
                    .HasColumnName("HIV_TB_TrackingFormId");

                entity.Property(e => e.Artnumber)
                    .HasMaxLength(3000)
                    .HasColumnName("ARTNumber");

                entity.Property(e => e.ClientAtTbinfectionRisk).HasColumnName("ClientAtTBInfectionRisk");

                entity.Property(e => e.ClientCareModalityIdOther).HasMaxLength(3000);

                entity.Property(e => e.ClientHasPresumptiveOrActiveTb).HasColumnName("ClientHasPresumptiveOrActiveTB");

                entity.Property(e => e.ClientMemberStatusOther).HasMaxLength(3000);

                entity.Property(e => e.ClientReceivedTbscreeningSession).HasColumnName("ClientReceivedTBScreeningSession");

                entity.Property(e => e.ClientRefferedTestedForTb).HasColumnName("ClientReffered_TestedForTB");

                entity.Property(e => e.CohortNo).HasColumnType("date");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.IsOnTbpreventiveTreatment).HasColumnName("IsOnTBPreventiveTreatment");

                entity.Property(e => e.IsOnTbtreatment).HasColumnName("IsOnTBTreatment");

                entity.Property(e => e.LastAppointmentDate).HasColumnType("date");

                entity.Property(e => e.LastViralloadTestDate).HasColumnType("date");

                entity.Property(e => e.NextAppointmentDate).HasColumnType("date");

                entity.Property(e => e.NextViralloadTestDate).HasColumnType("date");

                entity.Property(e => e.NonAdherenceId)
                    .HasMaxLength(3000)
                    .HasColumnName("Non_Adherence_Id");

                entity.Property(e => e.NonAdherenceOther)
                    .HasMaxLength(3000)
                    .HasColumnName("Non_Adherence_Other");

                entity.Property(e => e.NotSuppressingReasonId).HasMaxLength(1000);

                entity.Property(e => e.OnArt).HasColumnName("OnART");

                entity.Property(e => e.OtherNotSuppressingReason).HasMaxLength(3000);

                entity.Property(e => e.OtherPersonContacted).HasMaxLength(3000);

                entity.Property(e => e.OtherServiceProvided).HasMaxLength(3000);

                entity.Property(e => e.PhoneNumber).HasMaxLength(1000);

                entity.Property(e => e.ReasonForTreatmentInterruptionId)
                    .HasMaxLength(2000)
                    .HasColumnName("Reason_For_Treatment_InterruptionId");

                entity.Property(e => e.ReasonsForNonOptimizationId)
                    .HasMaxLength(2000)
                    .HasColumnName("Reasons_For_Non_OptimizationId");

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.ReviewedContact).HasMaxLength(1000);

                entity.Property(e => e.ReviewedTitle).HasMaxLength(3000);

                entity.Property(e => e.ServiceProvidedId).HasMaxLength(1000);

                entity.Property(e => e.SocialWorkerContact).HasMaxLength(1000);

                entity.Property(e => e.SocialWorkerEntryDate).HasColumnType("date");

                entity.Property(e => e.SocialWorkerName).HasMaxLength(3000);

                entity.Property(e => e.SocialWorkerTitle).HasMaxLength(3000);

                entity.Property(e => e.StrategiesForImprovingTreatmentContinuityId)
                    .HasMaxLength(2000)
                    .HasColumnName("Strategies_For_Improving_Treatment_ContinuityId");

                entity.Property(e => e.SupportedToDiscloseHivStatusToFamilyYesNoId).HasColumnName("Supported_To_Disclose_HIV_Status_To_FamilyYesNoId");

                entity.Property(e => e.TbtestResultId).HasColumnName("TBTestResultId");

                entity.Property(e => e.TbtreatmentDuration).HasColumnName("TBTreatmentDuration");

                entity.Property(e => e.TptTreatmentDuration).HasColumnName("TPT_Treatment_Duration");

                entity.Property(e => e.ViralloadTestResults).HasMaxLength(2000);

                entity.HasOne(d => d.AnotherPersonContactedOnBehalfOfClientNavigation)
                    .WithMany(p => p.HivTbTrackingFormAnotherPersonContactedOnBehalfOfClientNavigation)
                    .HasForeignKey(d => d.AnotherPersonContactedOnBehalfOfClient)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo10");

                entity.HasOne(d => d.CientClassification)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.CientClassificationId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_CientClassification");

                entity.HasOne(d => d.ClientAtTbinfectionRiskNavigation)
                    .WithMany(p => p.HivTbTrackingFormClientAtTbinfectionRiskNavigation)
                    .HasForeignKey(d => d.ClientAtTbinfectionRisk)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo6");

                entity.HasOne(d => d.ClientCareModality)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.ClientCareModalityId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_ClientCareModality");

                entity.HasOne(d => d.ClientHasPresumptiveOrActiveTbNavigation)
                    .WithMany(p => p.HivTbTrackingFormClientHasPresumptiveOrActiveTbNavigation)
                    .HasForeignKey(d => d.ClientHasPresumptiveOrActiveTb)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo4");

                entity.HasOne(d => d.ClientMemberStatus)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.ClientMemberStatusId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_ClientMemberStatus");

                entity.HasOne(d => d.ClientReceivedTbscreeningSessionNavigation)
                    .WithMany(p => p.HivTbTrackingFormClientReceivedTbscreeningSessionNavigation)
                    .HasForeignKey(d => d.ClientReceivedTbscreeningSession)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo5");

                entity.HasOne(d => d.ClientRefferedTestedForTbNavigation)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.ClientRefferedTestedForTb)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_TBClientRefered");

                entity.HasOne(d => d.ClientSuccessfullyContactedOrSeenNavigation)
                    .WithMany(p => p.HivTbTrackingFormClientSuccessfullyContactedOrSeenNavigation)
                    .HasForeignKey(d => d.ClientSuccessfullyContactedOrSeen)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo9");

                entity.HasOne(d => d.CurrentCarePointDistrict)
                    .WithMany(p => p.HivTbTrackingFormCurrentCarePointDistrict)
                    .HasForeignKey(d => d.CurrentCarePointDistrictId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_District");

                entity.HasOne(d => d.CurrentCarePointSubCounty)
                    .WithMany(p => p.HivTbTrackingFormCurrentCarePointSubCounty)
                    .HasForeignKey(d => d.CurrentCarePointSubCountyId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_Subcounty");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.HivTbTrackingFormDistrict)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_District1");

                entity.HasOne(d => d.DrugDispensingModality)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.DrugDispensingModalityId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_DrugDispensingModality");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_Facility");

                entity.HasOne(d => d.FollowupMeans)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.FollowupMeansId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_FollowupMeans");

                entity.HasOne(d => d.Hivstatus)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.HivstatusId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_HIVStatus");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_HouseHoldMembers");

                entity.HasOne(d => d.IsClientEligibleForViralloadNavigation)
                    .WithMany(p => p.HivTbTrackingFormIsClientEligibleForViralloadNavigation)
                    .HasForeignKey(d => d.IsClientEligibleForViralload)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo1");

                entity.HasOne(d => d.IsOnTbpreventiveTreatmentNavigation)
                    .WithMany(p => p.HivTbTrackingFormIsOnTbpreventiveTreatmentNavigation)
                    .HasForeignKey(d => d.IsOnTbpreventiveTreatment)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_TBTreatment");

                entity.HasOne(d => d.IsOnTbtreatmentNavigation)
                    .WithMany(p => p.HivTbTrackingFormIsOnTbtreatmentNavigation)
                    .HasForeignKey(d => d.IsOnTbtreatment)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo8");

                entity.HasOne(d => d.OnArtNavigation)
                    .WithMany(p => p.HivTbTrackingFormOnArtNavigation)
                    .HasForeignKey(d => d.OnArt)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo");

                entity.HasOne(d => d.OptimizedYesNoNavigation)
                    .WithMany(p => p.HivTbTrackingFormOptimizedYesNoNavigation)
                    .HasForeignKey(d => d.OptimizedYesNo)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo7");

                entity.HasOne(d => d.PersonContacted)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.PersonContactedId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_PersonContacted");

                entity.HasOne(d => d.RegimenCategory)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.RegimenCategoryId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_RegimenCategory");

                entity.HasOne(d => d.Regimen)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.RegimenId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_Regimen");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.HivTbTrackingFormSubcounty)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_Subcounty1");

                entity.HasOne(d => d.SupportedToDiscloseHivStatusToFamilyYesNo)
                    .WithMany(p => p.HivTbTrackingFormSupportedToDiscloseHivStatusToFamilyYesNo)
                    .HasForeignKey(d => d.SupportedToDiscloseHivStatusToFamilyYesNoId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo11");

                entity.HasOne(d => d.TbtestResult)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.TbtestResultId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_TBTestResult");

                entity.HasOne(d => d.TbtreatmentDurationNavigation)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.TbtreatmentDuration)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_TBTReatmentDuration");

                entity.HasOne(d => d.ViralLoadSuppressed)
                    .WithMany(p => p.HivTbTrackingForm)
                    .HasForeignKey(d => d.ViralLoadSuppressedId)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_ViralLoadSuppressed");

                entity.HasOne(d => d.ViralloadResultsReceivedNavigation)
                    .WithMany(p => p.HivTbTrackingFormViralloadResultsReceivedNavigation)
                    .HasForeignKey(d => d.ViralloadResultsReceived)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo3");

                entity.HasOne(d => d.ViralloadTestDoneNavigation)
                    .WithMany(p => p.HivTbTrackingFormViralloadTestDoneNavigation)
                    .HasForeignKey(d => d.ViralloadTestDone)
                    .HasConstraintName("FK_HIV_TB_TrackingForm_A_YesNo2");
            });

            modelBuilder.Entity<HivTbTrackingFormExposedInfants>(entity =>
            {
                entity.ToTable("HIV_TB_TrackingFormExposedInfants");

                entity.Property(e => e.HivTbTrackingFormExposedInfantsId)
                    .ValueGeneratedNever()
                    .HasColumnName("HIV_TB_TrackingFormExposedInfantsId");

                entity.Property(e => e.ArtNumber)
                    .HasMaxLength(3000)
                    .HasColumnName("ART_Number");

                entity.Property(e => e.EidCascadeId).HasColumnName("EID_Cascade_Id");

                entity.Property(e => e.EidCascadeTransferred)
                    .HasMaxLength(3000)
                    .HasColumnName("EID_Cascade_Transferred");

                entity.Property(e => e.ExposedInfantsNo).HasMaxLength(3000);

                entity.Property(e => e.HivTbTrackingFormId).HasColumnName("HIV_TB_TrackingFormId");

                entity.Property(e => e.IsEnrolledOnArt).HasColumnName("IsEnrolledOnART");

                entity.Property(e => e.PcrTestId)
                    .HasMaxLength(1000)
                    .HasColumnName("PCR_Test_Id");

                entity.Property(e => e.PmtctmotherProvidedWithTreatmentLiteracy).HasColumnName("PMTCTMotherProvidedWithTreatmentLiteracy");

                entity.Property(e => e.RegistrationDate).HasColumnType("date");

                entity.Property(e => e.SupportedToEnrollAndAdhereToPmtct).HasColumnName("SupportedToEnrollAndAdhereToPMTCT");

                entity.HasOne(d => d.EidCascade)
                    .WithMany(p => p.HivTbTrackingFormExposedInfants)
                    .HasForeignKey(d => d.EidCascadeId)
                    .HasConstraintName("FK_HIV_TB_TrackingFormExposedInfants_A_EID_Cascade");

                entity.HasOne(d => d.FeedingStatus)
                    .WithMany(p => p.HivTbTrackingFormExposedInfants)
                    .HasForeignKey(d => d.FeedingStatusId)
                    .HasConstraintName("FK_HIV_TB_TrackingFormExposedInfants_A_FeedingStatus");

                entity.HasOne(d => d.HivTbTrackingForm)
                    .WithMany(p => p.HivTbTrackingFormExposedInfants)
                    .HasForeignKey(d => d.HivTbTrackingFormId)
                    .HasConstraintName("FK_HIV_TB_TrackingFormExposedInfants_HIV_TB_TrackingForm");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.HivTbTrackingFormExposedInfants)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_HIV_TB_TrackingFormExposedInfants_HouseHoldMembers");

                entity.HasOne(d => d.IsEnrolledOnArtNavigation)
                    .WithMany(p => p.HivTbTrackingFormExposedInfantsIsEnrolledOnArtNavigation)
                    .HasForeignKey(d => d.IsEnrolledOnArt)
                    .HasConstraintName("FK_HIV_TB_TrackingFormExposedInfants_A_YesNo2");

                entity.HasOne(d => d.IsTrackedAndReturnedToCareNavigation)
                    .WithMany(p => p.HivTbTrackingFormExposedInfantsIsTrackedAndReturnedToCareNavigation)
                    .HasForeignKey(d => d.IsTrackedAndReturnedToCare)
                    .HasConstraintName("FK_HIV_TB_TrackingFormExposedInfants_A_YesNo3");

                entity.HasOne(d => d.PmtctmotherProvidedWithTreatmentLiteracyNavigation)
                    .WithMany(p => p.HivTbTrackingFormExposedInfantsPmtctmotherProvidedWithTreatmentLiteracyNavigation)
                    .HasForeignKey(d => d.PmtctmotherProvidedWithTreatmentLiteracy)
                    .HasConstraintName("FK_HIV_TB_TrackingFormExposedInfants_A_YesNo1");

                entity.HasOne(d => d.RegistrationStatus)
                    .WithMany(p => p.HivTbTrackingFormExposedInfants)
                    .HasForeignKey(d => d.RegistrationStatusId)
                    .HasConstraintName("FK_HIV_TB_TrackingFormExposedInfants_A_RegistrationStatus");

                entity.HasOne(d => d.SupportedToEnrollAndAdhereToPmtctNavigation)
                    .WithMany(p => p.HivTbTrackingFormExposedInfantsSupportedToEnrollAndAdhereToPmtctNavigation)
                    .HasForeignKey(d => d.SupportedToEnrollAndAdhereToPmtct)
                    .HasConstraintName("FK_HIV_TB_TrackingFormExposedInfants_A_YesNo");
            });

            modelBuilder.Entity<HomeVisitServiceReportingToolDetail>(entity =>
            {
                entity.HasKey(e => e.VisitServiceReportingToolDetailId);

                entity.Property(e => e.VisitServiceReportingToolDetailId).ValueGeneratedNever();

                entity.Property(e => e.EmergingNeedHealthy)
                    .HasMaxLength(1000)
                    .HasColumnName("Emerging_Need_Healthy");

                entity.Property(e => e.EmergingNeedSafe)
                    .HasMaxLength(1000)
                    .HasColumnName("Emerging_Need_Safe");

                entity.Property(e => e.EmergingNeedSchooled)
                    .HasMaxLength(1000)
                    .HasColumnName("Emerging_Need_Schooled");

                entity.Property(e => e.EmergingNeedStable)
                    .HasMaxLength(1000)
                    .HasColumnName("Emerging_Need_Stable");

                entity.Property(e => e.GapNeededHealthy)
                    .HasMaxLength(1000)
                    .HasColumnName("Gap_Needed_Healthy");

                entity.Property(e => e.GapNeededSafe)
                    .HasMaxLength(1000)
                    .HasColumnName("Gap_Needed_Safe");

                entity.Property(e => e.GapNeededSchooled)
                    .HasMaxLength(1000)
                    .HasColumnName("Gap_Needed_Schooled");

                entity.Property(e => e.GapNeededStable)
                    .HasMaxLength(1000)
                    .HasColumnName("Gap_Needed_Stable");

                entity.Property(e => e.Healthy).HasMaxLength(1000);

                entity.Property(e => e.HealthyOther).HasMaxLength(3000);

                entity.Property(e => e.IssuesIdentified).HasColumnName("Issues_Identified");

                entity.Property(e => e.Safe).HasMaxLength(1000);

                entity.Property(e => e.SafeOther).HasMaxLength(3000);

                entity.Property(e => e.Schooled).HasMaxLength(1000);

                entity.Property(e => e.SchooledOther).HasMaxLength(3000);

                entity.Property(e => e.Stable).HasMaxLength(1000);

                entity.Property(e => e.StableOther).HasMaxLength(3000);

                entity.Property(e => e.UnmetNeedHealthy)
                    .HasMaxLength(1000)
                    .HasColumnName("Unmet_Need_Healthy");

                entity.Property(e => e.UnmetNeedSafe)
                    .HasMaxLength(1000)
                    .HasColumnName("Unmet_Need_Safe");

                entity.Property(e => e.UnmetNeedSchooled)
                    .HasMaxLength(1000)
                    .HasColumnName("Unmet_Need_Schooled");

                entity.Property(e => e.UnmetNeedStable)
                    .HasMaxLength(1000)
                    .HasColumnName("Unmet_Need_Stable");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.HomeVisitServiceReportingToolDetail)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_HomeVisitServiceReportingToolDetail_HouseHoldMembers");

                entity.HasOne(d => d.ProgramParticipation)
                    .WithMany(p => p.HomeVisitServiceReportingToolDetail)
                    .HasForeignKey(d => d.ProgramParticipationId)
                    .HasConstraintName("FK_HomeVisitServiceReportingToolDetail_A_ProgramParticipationStatus");

                entity.HasOne(d => d.VisitServiceReportingToolHeader)
                    .WithMany(p => p.HomeVisitServiceReportingToolDetail)
                    .HasForeignKey(d => d.VisitServiceReportingToolHeaderId)
                    .HasConstraintName("FK_HomeVisitServiceReportingToolDetail_HomeVisitServiceReportingToolHeader");
            });

            modelBuilder.Entity<HomeVisitServiceReportingToolHeader>(entity =>
            {
                entity.HasKey(e => e.VisitServiceReportingToolHeaderId);

                entity.Property(e => e.VisitServiceReportingToolHeaderId).ValueGeneratedNever();

                entity.Property(e => e.HomeVisitReasonId).HasMaxLength(1000);

                entity.Property(e => e.HomeVisitReasonOther).HasMaxLength(3000);

                entity.Property(e => e.HomeVisitorName).HasMaxLength(3000);

                entity.Property(e => e.HouseHoldMembersTalkedTo).HasMaxLength(1000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewerName).HasMaxLength(3000);

                entity.Property(e => e.ReviewerTitle).HasMaxLength(3000);

                entity.Property(e => e.VisitationDate).HasColumnType("date");

                entity.Property(e => e.VisitorTitle).HasMaxLength(3000);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.HomeVisitServiceReportingToolHeader)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_HomeVisitServiceReportingToolHeader_A_District");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.HomeVisitServiceReportingToolHeader)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_HomeVisitServiceReportingToolHeader_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.ProgramParticipation)
                    .WithMany(p => p.HomeVisitServiceReportingToolHeader)
                    .HasForeignKey(d => d.ProgramParticipationId)
                    .HasConstraintName("FK_HomeVisitServiceReportingToolHeader_A_ProgramParticipationStatus");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.HomeVisitServiceReportingToolHeader)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_HomeVisitServiceReportingToolHeader_A_Subcounty");
            });

            modelBuilder.Entity<HouseHoldMembers>(entity =>
            {
                entity.HasKey(e => e.HouseHoldMemberId);

                entity.Property(e => e.HouseHoldMemberId).ValueGeneratedNever();

                entity.Property(e => e.Artnumber)
                    .HasMaxLength(1000)
                    .HasColumnName("ARTNumber");

                entity.Property(e => e.Cohort).HasColumnType("date");

                entity.Property(e => e.CurrentlyonArt).HasColumnName("CurrentlyonART");

                entity.Property(e => e.DisabilityDescription).HasMaxLength(3000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.EnrollmentDate).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Givenname).HasMaxLength(3000);

                entity.Property(e => e.HasanIga).HasColumnName("HasanIGA");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.NameofSchool).HasMaxLength(3000);

                entity.Property(e => e.Surname).HasMaxLength(3000);

                entity.HasOne(d => d.CurrentlyonArtNavigation)
                    .WithMany(p => p.HouseHoldMembersCurrentlyonArtNavigation)
                    .HasForeignKey(d => d.CurrentlyonArt)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo8");

                entity.HasOne(d => d.DoesChildHaveBirthCertificateNavigation)
                    .WithMany(p => p.HouseHoldMembersDoesChildHaveBirthCertificateNavigation)
                    .HasForeignKey(d => d.DoesChildHaveBirthCertificate)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo5");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.HouseHoldMembers)
                    .HasForeignKey(d => d.EducationLevelId)
                    .HasConstraintName("FK_HouseHoldMembers_A_EducationLevel");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.HouseHoldMembers)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_HouseHoldMembers_A_Gender");

                entity.HasOne(d => d.HasanIgaNavigation)
                    .WithMany(p => p.HouseHoldMembersHasanIgaNavigation)
                    .HasForeignKey(d => d.HasanIga)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo9");

                entity.HasOne(d => d.Hivstatus)
                    .WithMany(p => p.HouseHoldMembers)
                    .HasForeignKey(d => d.HivstatusId)
                    .HasConstraintName("FK_HouseHoldMembers_A_HIVStatus");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.HouseHoldMembers)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_HouseHoldMembers_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.IsAttendingSchoolRegularlyNavigation)
                    .WithMany(p => p.HouseHoldMembersIsAttendingSchoolRegularlyNavigation)
                    .HasForeignKey(d => d.IsAttendingSchoolRegularly)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo2");

                entity.HasOne(d => d.IsCareGiverNavigation)
                    .WithMany(p => p.HouseHoldMembers)
                    .HasForeignKey(d => d.IsCareGiver)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo");

                entity.HasOne(d => d.IsChildUnder5MalnourishedNavigation)
                    .WithMany(p => p.HouseHoldMembersIsChildUnder5MalnourishedNavigation)
                    .HasForeignKey(d => d.IsChildUnder5Malnourished)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo4");

                entity.HasOne(d => d.IsDisabledNavigation)
                    .WithMany(p => p.HouseHoldMembersIsDisabledNavigation)
                    .HasForeignKey(d => d.IsDisabled)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo6");

                entity.HasOne(d => d.IsEnrolledInSchoolNavigation)
                    .WithMany(p => p.HouseHoldMembersIsEnrolledInSchoolNavigation)
                    .HasForeignKey(d => d.IsEnrolledInSchool)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo1");

                entity.HasOne(d => d.IsOrphanedNavigation)
                    .WithMany(p => p.HouseHoldMembersIsOrphanedNavigation)
                    .HasForeignKey(d => d.IsOrphaned)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo3");

                entity.HasOne(d => d.IschildimmunisedNavigation)
                    .WithMany(p => p.HouseHoldMembersIschildimmunisedNavigation)
                    .HasForeignKey(d => d.Ischildimmunised)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo7");

                entity.HasOne(d => d.IsinSavingsGroupNavigation)
                    .WithMany(p => p.HouseHoldMembersIsinSavingsGroupNavigation)
                    .HasForeignKey(d => d.IsinSavingsGroup)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo10");

                entity.HasOne(d => d.IsinschoolcompletingapprenticeshipNavigation)
                    .WithMany(p => p.HouseHoldMembersIsinschoolcompletingapprenticeshipNavigation)
                    .HasForeignKey(d => d.Isinschoolcompletingapprenticeship)
                    .HasConstraintName("FK_HouseHoldMembers_A_YesNo11");

                entity.HasOne(d => d.KnownRiskFactor)
                    .WithMany(p => p.HouseHoldMembers)
                    .HasForeignKey(d => d.KnownRiskFactorId)
                    .HasConstraintName("FK_HouseHoldMembers_A_KnownRiskFactors");

                entity.HasOne(d => d.ProgramParticipation)
                    .WithMany(p => p.HouseHoldMembers)
                    .HasForeignKey(d => d.ProgramParticipationId)
                    .HasConstraintName("FK_HouseHoldMembers_A_ProgramParticipationStatus");
            });

            modelBuilder.Entity<HouseHoldMembers1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HouseHoldMembers_1");

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.HouseholdId).HasColumnName("householdId");
            });

            modelBuilder.Entity<HouseHoldMembersLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionMadeBy).HasMaxLength(3000);

                entity.Property(e => e.ActionTaken).HasMaxLength(1000);

                entity.Property(e => e.ColumnEdited).HasMaxLength(3000);

                entity.Property(e => e.NewValue).HasMaxLength(3000);

                entity.Property(e => e.PreviousValue).HasMaxLength(3000);
            });

            modelBuilder.Entity<Hvat>(entity =>
            {
                entity.ToTable("HVAT");

                entity.Property(e => e.Hvatid)
                    .ValueGeneratedNever()
                    .HasColumnName("HVATId");

                entity.Property(e => e.ApplicableOptionId).HasMaxLength(1000);

                entity.Property(e => e.AssessmentDate).HasColumnType("date");

                entity.Property(e => e.AssessorContact).HasMaxLength(1000);

                entity.Property(e => e.AssessorName).HasMaxLength(3000);

                entity.Property(e => e.AssessorTitle).HasMaxLength(2000);

                entity.Property(e => e.Cdocontact)
                    .HasMaxLength(1000)
                    .HasColumnName("CDOContact");

                entity.Property(e => e.Cdoname)
                    .HasMaxLength(3000)
                    .HasColumnName("CDOName");

                entity.Property(e => e.ChildrenChildProgressing).HasColumnName("Children_ChildProgressing");

                entity.Property(e => e.ChildrenChildProgressingScore).HasColumnName("Children_ChildProgressingScore");

                entity.Property(e => e.Childrenaged617attendedInSchool).HasColumnName("Childrenaged6_17AttendedInSchool");

                entity.Property(e => e.Childrenaged617attendedInSchoolScore).HasColumnName("Childrenaged6_17AttendedInSchoolScore");

                entity.Property(e => e.Childrenaged617enrolledInSchool).HasColumnName("Childrenaged6_17EnrolledInSchool");

                entity.Property(e => e.Childrenaged617enrolledInSchoolScore).HasColumnName("Childrenaged6_17EnrolledInSchoolScore");

                entity.Property(e => e.FoodGroupId).HasMaxLength(1000);

                entity.Property(e => e.HhassetsId)
                    .HasMaxLength(1000)
                    .HasColumnName("HHAssetsId");

                entity.Property(e => e.HhassetsScore).HasColumnName("HHAssetsScore");

                entity.Property(e => e.HheducationLevelId).HasColumnName("HHEducationLevelId");

                entity.Property(e => e.Hhnin)
                    .HasMaxLength(3000)
                    .HasColumnName("HHNIN");

                entity.Property(e => e.HhtotalScore).HasColumnName("HHTotalScore");

                entity.Property(e => e.HhviralLoadSuppresedId).HasColumnName("HHViralLoadSuppresedId");

                entity.Property(e => e.HhviralLoadSuppresedScore).HasColumnName("HHViralLoadSuppresedScore");

                entity.Property(e => e.IncurredExpensesId).HasMaxLength(1000);

                entity.Property(e => e.KnownHivstatusId).HasColumnName("KnownHIVStatusId");

                entity.Property(e => e.KnownHivstatusScore).HasColumnName("KnownHIVStatusScore");

                entity.Property(e => e.MemberBenefitsId).HasMaxLength(1000);

                entity.Property(e => e.ProgressingReasonId).HasMaxLength(1000);

                entity.Property(e => e.ServiceProviderContact).HasMaxLength(1000);

                entity.Property(e => e.ServiceProviderName).HasMaxLength(3000);

                entity.Property(e => e.ViolenceId).HasMaxLength(1000);

                entity.HasOne(d => d.AssessmentStatus)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.AssessmentStatusId)
                    .HasConstraintName("FK_HVAT_A_HHAssessmentStatus");

                entity.HasOne(d => d.BloodTest)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.BloodTestId)
                    .HasConstraintName("FK_HVAT_A_AdministrationPhase");

                entity.HasOne(d => d.ChildAbuse)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.ChildAbuseId)
                    .HasConstraintName("FK_HVAT_A_HHChildAbuse");

                entity.HasOne(d => d.ChildrenChildProgressingNavigation)
                    .WithMany(p => p.HvatChildrenChildProgressingNavigation)
                    .HasForeignKey(d => d.ChildrenChildProgressing)
                    .HasConstraintName("FK_HVAT_A_YesNo6");

                entity.HasOne(d => d.Childrenaged617attendedInSchoolNavigation)
                    .WithMany(p => p.HvatChildrenaged617attendedInSchoolNavigation)
                    .HasForeignKey(d => d.Childrenaged617attendedInSchool)
                    .HasConstraintName("FK_HVAT_A_YesNo5");

                entity.HasOne(d => d.Childrenaged617enrolledInSchoolNavigation)
                    .WithMany(p => p.HvatChildrenaged617enrolledInSchoolNavigation)
                    .HasForeignKey(d => d.Childrenaged617enrolledInSchool)
                    .HasConstraintName("FK_HVAT_A_YesNo4");

                entity.HasOne(d => d.Complications)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.ComplicationsId)
                    .HasConstraintName("FK_HVAT_A_HHChildrenComplications");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_HVAT_A_District");

                entity.HasOne(d => d.ExpensePayment)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.ExpensePaymentId)
                    .HasConstraintName("FK_HVAT_A_ExpensePayment");

                entity.HasOne(d => d.FoodConsumed)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.FoodConsumedId)
                    .HasConstraintName("FK_HVAT_A_FoodConsumedSource");

                entity.HasOne(d => d.HaveLongTermIllnessNavigation)
                    .WithMany(p => p.HvatHaveLongTermIllnessNavigation)
                    .HasForeignKey(d => d.HaveLongTermIllness)
                    .HasConstraintName("FK_HVAT_A_YesNo3");

                entity.HasOne(d => d.HavePersonWithDisabilityNavigation)
                    .WithMany(p => p.HvatHavePersonWithDisabilityNavigation)
                    .HasForeignKey(d => d.HavePersonWithDisability)
                    .HasConstraintName("FK_HVAT_A_YesNo2");

                entity.HasOne(d => d.HheducationLevel)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.HheducationLevelId)
                    .HasConstraintName("FK_HVAT_A_HHEducationLevel");

                entity.HasOne(d => d.HhviralLoadSuppresed)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.HhviralLoadSuppresedId)
                    .HasConstraintName("FK_HVAT_A_HHViralLoadSuppressed");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_HVAT_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseHoldIncome)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.HouseHoldIncomeId)
                    .HasConstraintName("FK_HVAT_A_HHIncome");

                entity.HasOne(d => d.IncomeSource)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.IncomeSourceId)
                    .HasConstraintName("FK_HVAT_A_HHIncomeSource");

                entity.HasOne(d => d.IsSavingsGroupMemberNavigation)
                    .WithMany(p => p.HvatIsSavingsGroupMemberNavigation)
                    .HasForeignKey(d => d.IsSavingsGroupMember)
                    .HasConstraintName("FK_HVAT_A_YesNo");

                entity.HasOne(d => d.KnownHivstatus)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.KnownHivstatusId)
                    .HasConstraintName("FK_HVAT_A_HHKnownHIVStatus");

                entity.HasOne(d => d.LackofFoodNavigation)
                    .WithMany(p => p.HvatLackofFoodNavigation)
                    .HasForeignKey(d => d.LackofFood)
                    .HasConstraintName("FK_HVAT_A_YesNo1");

                entity.HasOne(d => d.MalnutritionSign)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.MalnutritionSignId)
                    .HasConstraintName("FK_HVAT_A_MalnutritionSigns");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_HVAT_A_MaritalStatus");

                entity.HasOne(d => d.Meal)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK_HVAT_A_DailyMeals");

                entity.HasOne(d => d.Occurance)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.OccuranceId)
                    .HasConstraintName("FK_HVAT_A_ChildAbuseOccurances");

                entity.HasOne(d => d.PreSchoolNotEnrolled)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.PreSchoolNotEnrolledId)
                    .HasConstraintName("FK_HVAT_A_HHPreSchoolNotEnrolled");

                entity.HasOne(d => d.ReferredDisability)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.ReferredDisabilityId)
                    .HasConstraintName("FK_HVAT_A_ReferredDisability");

                entity.HasOne(d => d.SameAdultPrimaryCareGiverNavigation)
                    .WithMany(p => p.HvatSameAdultPrimaryCareGiverNavigation)
                    .HasForeignKey(d => d.SameAdultPrimaryCareGiver)
                    .HasConstraintName("FK_HVAT_A_YesNo7");

                entity.HasOne(d => d.SavingScheme)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.SavingSchemeId)
                    .HasConstraintName("FK_HVAT_A_SavingScheme");

                entity.HasOne(d => d.Shelter)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.ShelterId)
                    .HasConstraintName("FK_HVAT_A_StableShelter");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_HVAT_A_Subcounty");

                entity.HasOne(d => d.TreatmentAdherance)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.TreatmentAdheranceId)
                    .HasConstraintName("FK_HVAT_A_HHTreatmentAdherance");

                entity.HasOne(d => d.Treatment)
                    .WithMany(p => p.Hvat)
                    .HasForeignKey(d => d.TreatmentId)
                    .HasConstraintName("FK_HVAT_A_TuberclosisTreatment");
            });

            modelBuilder.Entity<InterventionAttendanceForm>(entity =>
            {
                entity.Property(e => e.InterventionAttendanceFormId).ValueGeneratedNever();

                entity.Property(e => e.AttendenceEndDate).HasColumnType("date");

                entity.Property(e => e.AttendenceStartDate).HasColumnType("date");

                entity.Property(e => e.GroupName).HasMaxLength(3000);

                entity.Property(e => e.ReviewdBy).HasMaxLength(3000);

                entity.Property(e => e.SerialNo).HasMaxLength(3000);

                entity.Property(e => e.Venue).HasMaxLength(3000);

                entity.HasOne(d => d.DeliveryMethod)
                    .WithMany(p => p.InterventionAttendanceForm)
                    .HasForeignKey(d => d.DeliveryMethodId)
                    .HasConstraintName("FK_InterventionAttendanceForm_A_DeliveryMethod");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.InterventionAttendanceForm)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_InterventionAttendanceForm_A_District");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.InterventionAttendanceForm)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_InterventionAttendanceForm_A_ImplementingPartner");

                entity.HasOne(d => d.InterventionType)
                    .WithMany(p => p.InterventionAttendanceForm)
                    .HasForeignKey(d => d.InterventionTypeId)
                    .HasConstraintName("FK_InterventionAttendanceForm_A_InterventionType");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.InterventionAttendanceForm)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_InterventionAttendanceForm_A_Parish");

                entity.HasOne(d => d.SampledFor)
                    .WithMany(p => p.InterventionAttendanceForm)
                    .HasForeignKey(d => d.SampledForId)
                    .HasConstraintName("FK_InterventionAttendanceForm_A_NMN_SampledFor");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.InterventionAttendanceForm)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_InterventionAttendanceForm_A_Subcounty");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.InterventionAttendanceForm)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("FK_InterventionAttendanceForm_A_Village");
            });

            modelBuilder.Entity<InterventionAttendanceFormDetail>(entity =>
            {
                entity.Property(e => e.InterventionAttendanceFormDetailId).ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasMaxLength(3000);

                entity.Property(e => e.LastName).HasMaxLength(3000);

                entity.Property(e => e.ModuleEightDate).HasColumnType("date");

                entity.Property(e => e.ModuleFiveDate).HasColumnType("date");

                entity.Property(e => e.ModuleFourDate).HasColumnType("date");

                entity.Property(e => e.ModuleNineDate).HasColumnType("date");

                entity.Property(e => e.ModuleOneDate).HasColumnType("date");

                entity.Property(e => e.ModuleSevenDate).HasColumnType("date");

                entity.Property(e => e.ModuleSixDate).HasColumnType("date");

                entity.Property(e => e.ModuleTenDate).HasColumnType("date");

                entity.Property(e => e.ModuleThreeDate).HasColumnType("date");

                entity.Property(e => e.ModuleTwoDate).HasColumnType("date");

                entity.Property(e => e.UniqueId).HasMaxLength(3000);

                entity.HasOne(d => d.GraduatedYesNo)
                    .WithMany(p => p.InterventionAttendanceFormDetail)
                    .HasForeignKey(d => d.GraduatedYesNoId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_YesNo");

                entity.HasOne(d => d.InterventionAttendanceForm)
                    .WithMany(p => p.InterventionAttendanceFormDetail)
                    .HasForeignKey(d => d.InterventionAttendanceFormId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_InterventionAttendanceForm");

                entity.HasOne(d => d.ModuleEightInterventionAttendance)
                    .WithMany(p => p.InterventionAttendanceFormDetailModuleEightInterventionAttendance)
                    .HasForeignKey(d => d.ModuleEightInterventionAttendanceId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_InterventionAttendance7");

                entity.HasOne(d => d.ModuleFiveInterventionAttendance)
                    .WithMany(p => p.InterventionAttendanceFormDetailModuleFiveInterventionAttendance)
                    .HasForeignKey(d => d.ModuleFiveInterventionAttendanceId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_InterventionAttendance4");

                entity.HasOne(d => d.ModuleFourInterventionAttendance)
                    .WithMany(p => p.InterventionAttendanceFormDetailModuleFourInterventionAttendance)
                    .HasForeignKey(d => d.ModuleFourInterventionAttendanceId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_InterventionAttendance3");

                entity.HasOne(d => d.ModuleNineInterventionAttendance)
                    .WithMany(p => p.InterventionAttendanceFormDetailModuleNineInterventionAttendance)
                    .HasForeignKey(d => d.ModuleNineInterventionAttendanceId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_InterventionAttendance8");

                entity.HasOne(d => d.ModuleOneInterventionAttendance)
                    .WithMany(p => p.InterventionAttendanceFormDetailModuleOneInterventionAttendance)
                    .HasForeignKey(d => d.ModuleOneInterventionAttendanceId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_InterventionAttendance");

                entity.HasOne(d => d.ModuleSevenInterventionAttendance)
                    .WithMany(p => p.InterventionAttendanceFormDetailModuleSevenInterventionAttendance)
                    .HasForeignKey(d => d.ModuleSevenInterventionAttendanceId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_InterventionAttendance6");

                entity.HasOne(d => d.ModuleSixInterventionAttendance)
                    .WithMany(p => p.InterventionAttendanceFormDetailModuleSixInterventionAttendance)
                    .HasForeignKey(d => d.ModuleSixInterventionAttendanceId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_InterventionAttendance5");

                entity.HasOne(d => d.ModuleTenInterventionAttendance)
                    .WithMany(p => p.InterventionAttendanceFormDetailModuleTenInterventionAttendance)
                    .HasForeignKey(d => d.ModuleTenInterventionAttendanceId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_InterventionAttendance9");

                entity.HasOne(d => d.ModuleThreeInterventionAttendance)
                    .WithMany(p => p.InterventionAttendanceFormDetailModuleThreeInterventionAttendance)
                    .HasForeignKey(d => d.ModuleThreeInterventionAttendanceId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_InterventionAttendance2");

                entity.HasOne(d => d.ModuleTwoInterventionAttendance)
                    .WithMany(p => p.InterventionAttendanceFormDetailModuleTwoInterventionAttendance)
                    .HasForeignKey(d => d.ModuleTwoInterventionAttendanceId)
                    .HasConstraintName("FK_InterventionAttendanceFormDetail_A_InterventionAttendance1");
            });

            modelBuilder.Entity<InterventionAttendanceFormInstructor>(entity =>
            {
                entity.Property(e => e.InterventionAttendanceFormInstructorId).ValueGeneratedNever();

                entity.Property(e => e.InstructorName).HasMaxLength(3000);

                entity.HasOne(d => d.InterventionAttendanceForm)
                    .WithMany(p => p.InterventionAttendanceFormInstructor)
                    .HasForeignKey(d => d.InterventionAttendanceFormId)
                    .HasConstraintName("FK_InterventionAttendanceFormInstructor_InterventionAttendanceForm");
            });

            modelBuilder.Entity<IsvatcurrentBusinessOpportunity>(entity =>
            {
                entity.ToTable("ISVATCurrentBusinessOpportunity");

                entity.Property(e => e.IsvatcurrentBusinessOpportunityId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATCurrentBusinessOpportunityId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.Property(e => e.OtherCurrenBusinessOpportunity).HasMaxLength(3000);

                entity.HasOne(d => d.CurrenBusinessOpportunity)
                    .WithMany(p => p.IsvatcurrentBusinessOpportunity)
                    .HasForeignKey(d => d.CurrenBusinessOpportunityId)
                    .HasConstraintName("FK_ISVATCurrentBusinessOpportunity_A_CurrenBusinessOpportunity");

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatcurrentBusinessOpportunity)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATCurrentBusinessOpportunity_ISVATHeader");

                entity.HasOne(d => d.YesNo)
                    .WithMany(p => p.IsvatcurrentBusinessOpportunity)
                    .HasForeignKey(d => d.YesNoId)
                    .HasConstraintName("FK_ISVATCurrentBusinessOpportunity_A_YesNo");
            });

            modelBuilder.Entity<IsvatcurrentBusinessRisk>(entity =>
            {
                entity.ToTable("ISVATCurrentBusinessRisk");

                entity.Property(e => e.IsvatcurrentBusinessRiskId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATCurrentBusinessRiskId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.Property(e => e.OtherCurrenBusinessRisk).HasMaxLength(3000);

                entity.HasOne(d => d.CurrenBusinessRisk)
                    .WithMany(p => p.IsvatcurrentBusinessRisk)
                    .HasForeignKey(d => d.CurrenBusinessRiskId)
                    .HasConstraintName("FK_ISVATCurrentBusinessRisk_A_CurrenBusinessRisk");

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatcurrentBusinessRisk)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATCurrentBusinessRisk_ISVATHeader");

                entity.HasOne(d => d.RiskLevelRating)
                    .WithMany(p => p.IsvatcurrentBusinessRisk)
                    .HasForeignKey(d => d.RiskLevelRatingId)
                    .HasConstraintName("FK_ISVATCurrentBusinessRisk_A_RiskLevelRating");
            });

            modelBuilder.Entity<IsvatgeneratedProfit>(entity =>
            {
                entity.ToTable("ISVATGeneratedProfit");

                entity.Property(e => e.IsvatgeneratedProfitId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATGeneratedProfitId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.Property(e => e.OtherAssetIncome).HasMaxLength(3000);

                entity.HasOne(d => d.AssetIncome)
                    .WithMany(p => p.IsvatgeneratedProfit)
                    .HasForeignKey(d => d.AssetIncomeId)
                    .HasConstraintName("FK_ISVATGeneratedProfit_A_AssetIncome");

                entity.HasOne(d => d.BusinessVentureCapitalInvestment)
                    .WithMany(p => p.IsvatgeneratedProfit)
                    .HasForeignKey(d => d.BusinessVentureCapitalInvestmentId)
                    .HasConstraintName("FK_ISVATGeneratedProfit_A_BusinessVentureCapitalInvestment");

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatgeneratedProfit)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATGeneratedProfit_ISVATHeader");
            });

            modelBuilder.Entity<Isvatheader>(entity =>
            {
                entity.ToTable("ISVATHeader");

                entity.Property(e => e.IsvatheaderId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATHeaderId");

                entity.Property(e => e.DataCollectionDate).HasColumnType("date");

                entity.Property(e => e.DataCollectorName).HasMaxLength(3000);

                entity.Property(e => e.DataCollectorTitle).HasMaxLength(2000);

                entity.Property(e => e.DataReviewDate).HasColumnType("date");

                entity.Property(e => e.DataReviewerName).HasMaxLength(3000);

                entity.Property(e => e.DataReviewerTitle).HasMaxLength(2000);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.CategoryofResidence)
                    .WithMany(p => p.Isvatheader)
                    .HasForeignKey(d => d.CategoryofResidenceId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolHeader_A_CategoryofResidence");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Isvatheader)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolHeader_A_District");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Isvatheader)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolHeader_A_Gender");

                entity.HasOne(d => d.Household)
                    .WithMany(p => p.Isvatheader)
                    .HasForeignKey(d => d.HouseholdId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolHeader_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseholdMember)
                    .WithMany(p => p.Isvatheader)
                    .HasForeignKey(d => d.HouseholdMemberId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolHeader_HouseHoldMembers");

                entity.HasOne(d => d.NatureofResidence)
                    .WithMany(p => p.Isvatheader)
                    .HasForeignKey(d => d.NatureofResidenceId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolHeader_A_NatureofResidence");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.Isvatheader)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolHeader_A_Parish");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.Isvatheader)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolHeader_A_Subcounty");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.Isvatheader)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolHeader_A_Village");
            });

            modelBuilder.Entity<IsvatincomeEarner>(entity =>
            {
                entity.ToTable("ISVATIncomeEarner");

                entity.Property(e => e.IsvatincomeEarnerId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATIncomeEarnerId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.IsvatincomeEarner)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolIncomeEarner_HouseHoldMembers");

                entity.HasOne(d => d.IncomeEarnerYesNo)
                    .WithMany(p => p.IsvatincomeEarner)
                    .HasForeignKey(d => d.IncomeEarnerYesNoId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolIncomeEarner_A_YesNo");

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatincomeEarner)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolIncomeEarner_IncomeSourceViabilityAssessmentToolHeader");
            });

            modelBuilder.Entity<IsvatincomeOwnership>(entity =>
            {
                entity.ToTable("ISVATIncomeOwnership");

                entity.Property(e => e.IsvatincomeOwnershipId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATIncomeOwnershipId");

                entity.Property(e => e.IsvatincomeEarnerId).HasColumnName("ISVATIncomeEarnerId");

                entity.Property(e => e.OtherAssetIncome).HasMaxLength(3000);

                entity.HasOne(d => d.AssetIncome)
                    .WithMany(p => p.IsvatincomeOwnership)
                    .HasForeignKey(d => d.AssetIncomeId)
                    .HasConstraintName("FK_ISVATIncomeOwnership_A_AssetIncome");

                entity.HasOne(d => d.AssetIncomeYesNo)
                    .WithMany(p => p.IsvatincomeOwnership)
                    .HasForeignKey(d => d.AssetIncomeYesNoId)
                    .HasConstraintName("FK_ISVATIncomeOwnership_A_YesNo");

                entity.HasOne(d => d.IsvatincomeEarner)
                    .WithMany(p => p.IsvatincomeOwnership)
                    .HasForeignKey(d => d.IsvatincomeEarnerId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolIncomeOwnership_IncomeSourceViabilityAssessmentToolIncomeEarner");
            });

            modelBuilder.Entity<Isvatloss>(entity =>
            {
                entity.ToTable("ISVATLoss");

                entity.Property(e => e.IsvatlossId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATLossId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.Property(e => e.OtherAssetIncome).HasMaxLength(3000);

                entity.HasOne(d => d.AssetIncome)
                    .WithMany(p => p.Isvatloss)
                    .HasForeignKey(d => d.AssetIncomeId)
                    .HasConstraintName("FK_ISVATLoss_A_AssetIncome");

                entity.HasOne(d => d.BusinessVentureCapitalInvestment)
                    .WithMany(p => p.Isvatloss)
                    .HasForeignKey(d => d.BusinessVentureCapitalInvestmentId)
                    .HasConstraintName("FK_ISVATLoss_A_BusinessVentureCapitalInvestment");

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.Isvatloss)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATLoss_ISVATHeader");
            });

            modelBuilder.Entity<IsvatstartBusinessAnswer>(entity =>
            {
                entity.ToTable("ISVATStartBusinessAnswer");

                entity.Property(e => e.IsvatstartBusinessAnswerId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATStartBusinessAnswerId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatstartBusinessAnswer)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATStartBusinessAnswer_ISVATHeader");

                entity.HasOne(d => d.StartBusinessQuestion)
                    .WithMany(p => p.IsvatstartBusinessAnswer)
                    .HasForeignKey(d => d.StartBusinessQuestionId)
                    .HasConstraintName("FK_ISVATStartBusinessAnswer_A_StartBusinessQuestion");
            });

            modelBuilder.Entity<IsvatworkingCapital>(entity =>
            {
                entity.ToTable("ISVATWorkingCapital");

                entity.Property(e => e.IsvatworkingCapitalId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATWorkingCapitalId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.Property(e => e.OtherAssetIncome).HasMaxLength(3000);

                entity.HasOne(d => d.AssetIncome)
                    .WithMany(p => p.IsvatworkingCapital)
                    .HasForeignKey(d => d.AssetIncomeId)
                    .HasConstraintName("FK_ISVATWorkingCapital_A_AssetIncome");

                entity.HasOne(d => d.BusinessVentureCapitalInvestment)
                    .WithMany(p => p.IsvatworkingCapital)
                    .HasForeignKey(d => d.BusinessVentureCapitalInvestmentId)
                    .HasConstraintName("FK_ISVATWorkingCapital_A_BusinessVentureCapitalInvestment");

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatworkingCapital)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATWorkingCapital_ISVATHeader");
            });

            modelBuilder.Entity<JourneysGroups3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JourneysGroups_3");

                entity.Property(e => e.Age).HasColumnName("Age  ");

                entity.Property(e => e.CheckedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Checked by");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(2104)
                    .HasColumnName("Group Code");

                entity.Property(e => e.HhIndividualCode)
                    .HasMaxLength(255)
                    .HasColumnName("HH individual Code");

                entity.Property(e => e.MeetingTime)
                    .HasMaxLength(255)
                    .HasColumnName("Meeting Time");

                entity.Property(e => e.MeetingVenue)
                    .HasMaxLength(255)
                    .HasColumnName("Meeting Venue");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("Name ");

                entity.Property(e => e.SexMF)
                    .HasMaxLength(255)
                    .HasColumnName("Sex M/F ");

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Verified by");

                entity.Property(e => e.Village)
                    .HasMaxLength(255)
                    .HasColumnName("Village ");
            });

            modelBuilder.Entity<MonthlyCaseTrackingRegister>(entity =>
            {
                entity.HasKey(e => e.CaseTrackingRegisterId);

                entity.Property(e => e.CaseTrackingRegisterId).ValueGeneratedNever();

                entity.Property(e => e.DataCollectionDate).HasColumnType("date");

                entity.Property(e => e.OfficerName).HasMaxLength(3000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewTitle).HasMaxLength(3000);

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.SubmissionDate).HasColumnType("date");

                entity.Property(e => e.SubmittedBy).HasMaxLength(3000);

                entity.Property(e => e.SubmittedTitle).HasMaxLength(3000);

                entity.Property(e => e.TermId).HasColumnName("Term_Id");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.MonthlyCaseTrackingRegister)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegister_A_District");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.MonthlyCaseTrackingRegister)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegister_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.MonthlyCaseTrackingRegister)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegister_A_ImplementingPartner");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.MonthlyCaseTrackingRegister)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegister_A_Subcounty");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.MonthlyCaseTrackingRegister)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegister_A_Term");
            });

            modelBuilder.Entity<MonthlyCaseTrackingRegisterDetail>(entity =>
            {
                entity.HasKey(e => e.CaseTrackingRegisterDetailId);

                entity.Property(e => e.CaseTrackingRegisterDetailId).ValueGeneratedNever();

                entity.Property(e => e.EmotionalCaseCategoryItemId).HasMaxLength(1000);

                entity.Property(e => e.HealthServiceProvided).HasMaxLength(1000);

                entity.Property(e => e.HivrelatedCaseCategoryItemId)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVRelatedCaseCategoryItemId");

                entity.Property(e => e.NeglectCaseCategoryItemId).HasMaxLength(1000);

                entity.Property(e => e.OtherFormsCaseCategoryItemId).HasMaxLength(1000);

                entity.Property(e => e.PhysicalCaseCategoryItemId).HasMaxLength(1000);

                entity.Property(e => e.SafeServiceProvided).HasMaxLength(1000);

                entity.Property(e => e.SchooledServiceProvided).HasMaxLength(1000);

                entity.Property(e => e.SexualCaseCategoryItemId).HasMaxLength(1000);

                entity.Property(e => e.StableServiceProvided).HasMaxLength(1000);

                entity.HasOne(d => d.CaseTrackingRegister)
                    .WithMany(p => p.MonthlyCaseTrackingRegisterDetail)
                    .HasForeignKey(d => d.CaseTrackingRegisterId)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegisterDetail_MonthlyCaseTrackingRegister");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.MonthlyCaseTrackingRegisterDetail)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegisterDetail_HouseHoldMembers");

                entity.HasOne(d => d.PendingNavigation)
                    .WithMany(p => p.MonthlyCaseTrackingRegisterDetailPendingNavigation)
                    .HasForeignKey(d => d.Pending)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegisterDetail_A_YesNo2");

                entity.HasOne(d => d.ReferredNavigation)
                    .WithMany(p => p.MonthlyCaseTrackingRegisterDetailReferredNavigation)
                    .HasForeignKey(d => d.Referred)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegisterDetail_A_YesNo");

                entity.HasOne(d => d.ResolvedNavigation)
                    .WithMany(p => p.MonthlyCaseTrackingRegisterDetailResolvedNavigation)
                    .HasForeignKey(d => d.Resolved)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegisterDetail_A_YesNo1");

                entity.HasOne(d => d.TransferredNavigation)
                    .WithMany(p => p.MonthlyCaseTrackingRegisterDetailTransferredNavigation)
                    .HasForeignKey(d => d.Transferred)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegisterDetail_A_YesNo3");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.MonthlyCaseTrackingRegisterDetail)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("FK_MonthlyCaseTrackingRegisterDetail_A_Village");
            });

            modelBuilder.Entity<MonthlyHouseholdVisit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Monthly_Household_Visit");

                entity.Property(e => e.GenderDescription).HasMaxLength(1000);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Nmnquestionaire>(entity =>
            {
                entity.HasKey(e => e.Nmnid);

                entity.ToTable("NMNQuestionaire");

                entity.Property(e => e.Nmnid)
                    .ValueGeneratedNever()
                    .HasColumnName("NMNId");

                entity.Property(e => e.GroupName).HasMaxLength(3000);

                entity.Property(e => e.InstructorNames).HasMaxLength(3000);

                entity.Property(e => e.QuestionairDate).HasColumnType("date");

                entity.Property(e => e.SampledForId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SerialNo).HasMaxLength(3000);

                entity.HasOne(d => d.DeliveryMethod)
                    .WithMany(p => p.Nmnquestionaire)
                    .HasForeignKey(d => d.DeliveryMethodId)
                    .HasConstraintName("FK_NMNQuestionaire_A_DeliveryMethod");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Nmnquestionaire)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_NMNQuestionaire_A_District");

                entity.HasOne(d => d.ImplementationMethod)
                    .WithMany(p => p.Nmnquestionaire)
                    .HasForeignKey(d => d.ImplementationMethodId)
                    .HasConstraintName("FK_NMNQuestionaire_A_ImplementationMethod");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.Nmnquestionaire)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_NMNQuestionaire_A_ImplementingPartner");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.Nmnquestionaire)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_NMNQuestionaire_A_Parish");

                entity.HasOne(d => d.SampledFor)
                    .WithMany(p => p.Nmnquestionaire)
                    .HasForeignKey(d => d.SampledForId)
                    .HasConstraintName("FK_NMNQuestionaire_A_NMN_SampledFor");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.Nmnquestionaire)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_NMNQuestionaire_A_Subcounty");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.Nmnquestionaire)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("FK_NMNQuestionaire_A_Village");
            });

            modelBuilder.Entity<NmnquestionaireSectionOne>(entity =>
            {
                entity.HasKey(e => e.NmnsectionOneId);

                entity.ToTable("NMNQuestionaireSectionOne");

                entity.Property(e => e.NmnsectionOneId)
                    .ValueGeneratedNever()
                    .HasColumnName("NMNSectionOneId");

                entity.Property(e => e.Nmnid).HasColumnName("NMNId");

                entity.HasOne(d => d.AgreeDisagree)
                    .WithMany(p => p.NmnquestionaireSectionOne)
                    .HasForeignKey(d => d.AgreeDisagreeId)
                    .HasConstraintName("FK_NMNQuestionaireSectionOne_A_AgreeDisagree");

                entity.HasOne(d => d.Nmn)
                    .WithMany(p => p.NmnquestionaireSectionOne)
                    .HasForeignKey(d => d.Nmnid)
                    .HasConstraintName("FK_NMNQuestionaireSectionOne_NMNQuestionaire");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.NmnquestionaireSectionOne)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_NMNQuestionaireSectionOne_A_NMN_Section_One_Question");
            });

            modelBuilder.Entity<NmnquestionaireSectionTwo>(entity =>
            {
                entity.HasKey(e => e.NmnsectionTwoId);

                entity.ToTable("NMNQuestionaireSectionTwo");

                entity.Property(e => e.NmnsectionTwoId)
                    .ValueGeneratedNever()
                    .HasColumnName("NMNSectionTwoId");

                entity.Property(e => e.Nmnid).HasColumnName("NMNId");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.NmnquestionaireSectionTwo)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK_NMNQuestionaireSectionTwo_A_NMN_Section_Two_Answer");

                entity.HasOne(d => d.Nmn)
                    .WithMany(p => p.NmnquestionaireSectionTwo)
                    .HasForeignKey(d => d.Nmnid)
                    .HasConstraintName("FK_NMNQuestionaireSectionTwo_NMNQuestionaire");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.NmnquestionaireSectionTwo)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_NMNQuestionaireSectionTwo_A_NMN_Section_Two_Question");
            });

            modelBuilder.Entity<NonSupressingCalhiv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NonSupressing_CALHIV");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ViralloadTestResults)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OvcSchoolAttendencyDetails>(entity =>
            {
                entity.HasKey(e => e.SchoolAttendencyDetailsId);

                entity.ToTable("OVC_School_Attendency_Details");

                entity.Property(e => e.SchoolAttendencyDetailsId).ValueGeneratedNever();

                entity.Property(e => e.CandidentClassCompletedId).HasMaxLength(1000);

                entity.Property(e => e.ClassatEnrolmentId).HasComment("This one picks from the A_CurrentClass Table");

                entity.Property(e => e.SchoolName).HasMaxLength(3000);

                entity.HasOne(d => d.Attendency)
                    .WithMany(p => p.OvcSchoolAttendencyDetails)
                    .HasForeignKey(d => d.AttendencyId)
                    .HasConstraintName("FK_OVC_School_Attendency_Details_A_Attendency");

                entity.HasOne(d => d.ClassatEnrolment)
                    .WithMany(p => p.OvcSchoolAttendencyDetailsClassatEnrolment)
                    .HasForeignKey(d => d.ClassatEnrolmentId)
                    .HasConstraintName("FK_OVC_School_Attendency_Details_A_CurrentClass1");

                entity.HasOne(d => d.CurrentClass)
                    .WithMany(p => p.OvcSchoolAttendencyDetailsCurrentClass)
                    .HasForeignKey(d => d.CurrentClassId)
                    .HasConstraintName("FK_OVC_School_Attendency_Details_A_CurrentClass");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.OvcSchoolAttendencyDetails)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_OVC_School_Attendency_Details_HouseHoldMembers");

                entity.HasOne(d => d.SchoolAttendencyHeader)
                    .WithMany(p => p.OvcSchoolAttendencyDetails)
                    .HasForeignKey(d => d.SchoolAttendencyHeaderId)
                    .HasConstraintName("FK_OVC_School_Attendency_Details_OVC_School_Attendency_Header");
            });

            modelBuilder.Entity<OvcSchoolAttendencyHeader>(entity =>
            {
                entity.HasKey(e => e.SchoolAttendencyHeaderId);

                entity.ToTable("OVC_School_Attendency_Header");

                entity.Property(e => e.SchoolAttendencyHeaderId).ValueGeneratedNever();

                entity.Property(e => e.Csoname)
                    .HasMaxLength(3000)
                    .HasColumnName("CSOName");

                entity.Property(e => e.DatacollectionDate).HasColumnType("date");

                entity.Property(e => e.OfficeName).HasMaxLength(3000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.ReviewedByTitle).HasMaxLength(3000);

                entity.Property(e => e.SubmittedBy).HasMaxLength(3000);

                entity.Property(e => e.SubmittedByTitle).HasMaxLength(3000);

                entity.Property(e => e.SubmittedDate).HasColumnType("date");

                entity.Property(e => e.TermId).HasColumnName("Term_Id");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.OvcSchoolAttendencyHeader)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_OVC_School_Attendency_Header_A_District");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.OvcSchoolAttendencyHeader)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_OVC_School_Attendency_Header_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.OvcSchoolAttendencyHeader)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_OVC_School_Attendency_Header_A_Subcounty");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.OvcSchoolAttendencyHeader)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_OVC_School_Attendency_Header_A_Term");
            });

            modelBuilder.Entity<ProjectIndicatorTargetsDetails>(entity =>
            {
                entity.HasKey(e => e.IndicatorTargetValueId)
                    .HasName("PK_A_IndicatorTargetValue");

                entity.Property(e => e.IndicatorTargetValueId).ValueGeneratedNever();

                entity.Property(e => e.CapturedBy).HasMaxLength(3000);

                entity.Property(e => e.DateCaptured).HasColumnType("datetime");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.ProjectIndicatorTargetsDetails)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_A_IndicatorTargetValue_A_District");

                entity.HasOne(d => d.ProjectTargetValueHeader)
                    .WithMany(p => p.ProjectIndicatorTargetsDetails)
                    .HasForeignKey(d => d.ProjectTargetValueHeaderId)
                    .HasConstraintName("FK_ProjectIndicatorTargetsDetails_ProjectIndicatorTargetsHeader");
            });

            modelBuilder.Entity<ProjectIndicatorTargetsHeader>(entity =>
            {
                entity.HasKey(e => e.ProjectTargetValueHeaderId);

                entity.Property(e => e.ProjectTargetValueHeaderId).ValueGeneratedNever();

                entity.Property(e => e.CapturedBy).HasMaxLength(3000);

                entity.Property(e => e.DateCaptured).HasColumnType("datetime");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.ProjectIndicatorTargetsHeader)
                    .HasForeignKey(d => d.FinancialYearId)
                    .HasConstraintName("FK_ProjectIndicatorTargetsHeader_A_FinancialYear");

                entity.HasOne(d => d.Indicator)
                    .WithMany(p => p.ProjectIndicatorTargetsHeader)
                    .HasForeignKey(d => d.IndicatorId)
                    .HasConstraintName("FK_ProjectIndicatorTargetsHeader_A_Indicators");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.ProjectIndicatorTargetsHeader)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK_ProjectIndicatorTargetsHeader_A_Service_Provider");
            });

            modelBuilder.Entity<ReferralForm>(entity =>
            {
                entity.ToTable("Referral_Form");

                entity.Property(e => e.ReferralFormId).ValueGeneratedNever();

                entity.Property(e => e.ArtNumber)
                    .HasMaxLength(3000)
                    .HasColumnName("ART_Number");

                entity.Property(e => e.CaseNatureReportedId).HasMaxLength(3000);

                entity.Property(e => e.CaseNumber)
                    .HasMaxLength(3000)
                    .HasColumnName("Case_Number");

                entity.Property(e => e.CaseWorkerReferringChildDate).HasColumnType("date");

                entity.Property(e => e.CaseWorkerReferringChildEmail).HasMaxLength(3000);

                entity.Property(e => e.CaseWorkerReferringChildName).HasMaxLength(3000);

                entity.Property(e => e.CaseWorkerReferringChildPhoneNumber).HasMaxLength(3000);

                entity.Property(e => e.CaseWorkerReferringChildTitle).HasMaxLength(3000);

                entity.Property(e => e.Cohort).HasColumnType("date");

                entity.Property(e => e.ConsentName)
                    .HasMaxLength(3000)
                    .HasColumnName("Consent_Name");

                entity.Property(e => e.CurrentlyonArt).HasColumnName("CurrentlyonART");

                entity.Property(e => e.DateofOccurancy).HasColumnType("date");

                entity.Property(e => e.DocumentsSupportingReferralEnclosed).HasColumnName("Documents_Supporting_Referral_Enclosed");

                entity.Property(e => e.EmailOfPersonAccompanyingTheChild).HasMaxLength(3000);

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.NameOfPersonAccompanyingTheChild).HasMaxLength(3000);

                entity.Property(e => e.OtherRisk).HasColumnName("Other_Risk");

                entity.Property(e => e.PhoneNumberOfPersonAccompanyingTheChild).HasMaxLength(3000);

                entity.Property(e => e.ReferredToAgencyContactPersonName).HasMaxLength(3000);

                entity.Property(e => e.ReferredToAgencyEmail).HasMaxLength(3000);

                entity.Property(e => e.ReferredToAgencyLocation).HasMaxLength(3000);

                entity.Property(e => e.ReferredToAgencyName).HasMaxLength(3000);

                entity.Property(e => e.ReferredToAgencyPhoneNumber).HasMaxLength(2000);

                entity.Property(e => e.ReferringAgencyEmail).HasMaxLength(3000);

                entity.Property(e => e.ReferringAgencyLocation).HasMaxLength(3000);

                entity.Property(e => e.ReferringAgencyName).HasMaxLength(3000);

                entity.Property(e => e.ReferringAgencyPhoneNumber).HasMaxLength(3000);

                entity.Property(e => e.ResidenceOfPersonAccompanyingTheChild).HasMaxLength(3000);

                entity.Property(e => e.SerialNo).HasMaxLength(3000);

                entity.Property(e => e.ServicePointAgencyName).HasMaxLength(3000);

                entity.Property(e => e.ServicePointArrivalDate).HasColumnType("date");

                entity.Property(e => e.ServicePointCaseNo).HasMaxLength(3000);

                entity.Property(e => e.ServicePointContactPerson).HasMaxLength(3000);

                entity.Property(e => e.ServicePointPersonPrividingFeedbackDate).HasColumnType("date");

                entity.Property(e => e.ServicePointPersonPrividingFeedbackEmail).HasMaxLength(3000);

                entity.Property(e => e.ServicePointPersonPrividingFeedbackName).HasMaxLength(3000);

                entity.Property(e => e.ServicePointPersonPrividingFeedbackPhoneNumber).HasMaxLength(3000);

                entity.Property(e => e.ServicePointPersonPrividingFeedbackTitle).HasMaxLength(3000);

                entity.Property(e => e.ServicesProvidedBeforeReferal).HasMaxLength(3000);

                entity.HasOne(d => d.CareGiverHouseHoldMember)
                    .WithMany(p => p.ReferralFormCareGiverHouseHoldMember)
                    .HasForeignKey(d => d.CareGiverHouseHoldMemberId)
                    .HasConstraintName("FK_Referral_Form_HouseHoldMembers1");

                entity.HasOne(d => d.CurrentlyonArtNavigation)
                    .WithMany(p => p.ReferralFormCurrentlyonArtNavigation)
                    .HasForeignKey(d => d.CurrentlyonArt)
                    .HasConstraintName("FK_Referral_Form_A_YesNo1");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.ReferralForm)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Referral_Form_A_District");

                entity.HasOne(d => d.HasCaseBeenReportedToUgandaChildHelplineNavigation)
                    .WithMany(p => p.ReferralFormHasCaseBeenReportedToUgandaChildHelplineNavigation)
                    .HasForeignKey(d => d.HasCaseBeenReportedToUgandaChildHelpline)
                    .HasConstraintName("FK_Referral_Form_A_YesNo");

                entity.HasOne(d => d.Hivstatus)
                    .WithMany(p => p.ReferralForm)
                    .HasForeignKey(d => d.HivstatusId)
                    .HasConstraintName("FK_Referral_Form_A_HIVStatus");

                entity.HasOne(d => d.HouseHold)
                    .WithMany(p => p.ReferralForm)
                    .HasForeignKey(d => d.HouseHoldId)
                    .HasConstraintName("FK_Referral_Form_BeneficiaryIdentificationRegister");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.ReferralFormHouseHoldMember)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_Referral_Form_HouseHoldMembers");

                entity.HasOne(d => d.RelationshipToChildNavigation)
                    .WithMany(p => p.ReferralForm)
                    .HasForeignKey(d => d.RelationshipToChild)
                    .HasConstraintName("FK_Referral_Form_A_Relationship");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.ReferralForm)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_Referral_Form_A_Subcounty");
            });

            modelBuilder.Entity<SinoParentingAttendenceRegister>(entity =>
            {
                entity.HasKey(e => e.SinoParentingId);

                entity.ToTable("SINO_Parenting_Attendence_Register");

                entity.Property(e => e.SinoParentingId).ValueGeneratedNever();

                entity.Property(e => e.FacilitatorOne).HasMaxLength(3000);

                entity.Property(e => e.FacilitatorOneCode).HasMaxLength(1000);

                entity.Property(e => e.FacilitatorTwo).HasMaxLength(3000);

                entity.Property(e => e.FacilitatorTwoCode).HasMaxLength(1000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewTitle).HasMaxLength(2000);

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.SubmittedBy).HasMaxLength(3000);

                entity.Property(e => e.SubmittedDate).HasColumnType("date");

                entity.Property(e => e.SubmittedTitle).HasMaxLength(2000);

                entity.Property(e => e.Venue).HasMaxLength(3000);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.SinoParentingAttendenceRegister)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_SINO_Parenting_Attendence_Register_A_District");

                entity.HasOne(d => d.GroupCompositionCodeNavigation)
                    .WithMany(p => p.SinoParentingAttendenceRegister)
                    .HasForeignKey(d => d.GroupCompositionCode)
                    .HasConstraintName("FK_SINO_Parenting_Attendence_Register_VSLA_Group_Composition");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SinoParentingAttendenceRegister)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_SINO_Parenting_Attendence_Register_A_Groups");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.SinoParentingAttendenceRegister)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_SINO_Parenting_Attendence_Register_A_ImplementingPartner");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.SinoParentingAttendenceRegister)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_SINO_Parenting_Attendence_Register_A_Parish");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.SinoParentingAttendenceRegister)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_SINO_Parenting_Attendence_Register_A_Subcounty");
            });

            modelBuilder.Entity<SinoParentingDirectMemberAttendence>(entity =>
            {
                entity.HasKey(e => e.SinoParentingDirectMemberId);

                entity.ToTable("SINO_Parenting_DirectMember_Attendence");

                entity.Property(e => e.SinoParentingDirectMemberId).ValueGeneratedNever();

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.HasOne(d => d.CareTakerHouseholdMember)
                    .WithMany(p => p.SinoParentingDirectMemberAttendence)
                    .HasForeignKey(d => d.CareTakerHouseholdMemberId)
                    .HasConstraintName("FK_SINO_Parenting_DirectMember_Attendence_HouseHoldMembers");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.SinoParentingDirectMemberAttendence)
                    .HasForeignKey(d => d.RelationshipId)
                    .HasConstraintName("FK_SINO_Parenting_DirectMember_Attendence_A_Relationship");

                entity.HasOne(d => d.SinoParenting)
                    .WithMany(p => p.SinoParentingDirectMemberAttendence)
                    .HasForeignKey(d => d.SinoParentingId)
                    .HasConstraintName("FK_SINO_Parenting_DirectMember_Attendence_SINO_Parenting_Attendence_Register");

                entity.HasOne(d => d.VslaGroupDirectMember)
                    .WithMany(p => p.SinoParentingDirectMemberAttendence)
                    .HasForeignKey(d => d.VslaGroupDirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SINO_Parenting_DirectMember_Attendence_VSLA_Group_Direct_Members");
            });

            modelBuilder.Entity<SinoParentingDirectMemberDetail>(entity =>
            {
                entity.ToTable("SINO_Parenting_DirectMember_Detail");

                entity.Property(e => e.SinoParentingDirectMemberDetailId).ValueGeneratedNever();

                entity.Property(e => e.ParentAttended).HasColumnName("Parent_Attended");

                entity.Property(e => e.SessionDate).HasColumnType("datetime");

                entity.Property(e => e.TeenAttended).HasColumnName("Teen_Attended");

                entity.HasOne(d => d.ParentAttendedNavigation)
                    .WithMany(p => p.SinoParentingDirectMemberDetailParentAttendedNavigation)
                    .HasForeignKey(d => d.ParentAttended)
                    .HasConstraintName("FK_SINO_Parenting_DirectMember_Detail_A_YesNo1");

                entity.HasOne(d => d.ParentingGroupSession)
                    .WithMany(p => p.SinoParentingDirectMemberDetail)
                    .HasForeignKey(d => d.ParentingGroupSessionId)
                    .HasConstraintName("FK_SINO_Parenting_DirectMember_Detail_A_ParentingGroupSession");

                entity.HasOne(d => d.SinoParentingDirectMember)
                    .WithMany(p => p.SinoParentingDirectMemberDetail)
                    .HasForeignKey(d => d.SinoParentingDirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SINO_Parenting_DirectMember_Detail_SINO_Parenting_DirectMember_Attendence");

                entity.HasOne(d => d.TeenAttendedNavigation)
                    .WithMany(p => p.SinoParentingDirectMemberDetailTeenAttendedNavigation)
                    .HasForeignKey(d => d.TeenAttended)
                    .HasConstraintName("FK_SINO_Parenting_DirectMember_Detail_A_YesNo");
            });

            modelBuilder.Entity<SinoParentingIndirectMemberAttendence>(entity =>
            {
                entity.HasKey(e => e.SinoParentingIndirectMemberId);

                entity.ToTable("SINO_Parenting_IndirectMember_Attendence");

                entity.Property(e => e.SinoParentingIndirectMemberId).ValueGeneratedNever();

                entity.Property(e => e.CareTakerGenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CareTakerHouseholdMemberCode).HasMaxLength(1000);

                entity.Property(e => e.CareTakerName).HasMaxLength(3000);

                entity.Property(e => e.VslaGroupIndirectMemberId).HasColumnName("VSLA_Group_Indirect_Member_Id");

                entity.HasOne(d => d.CareTakerGender)
                    .WithMany(p => p.SinoParentingIndirectMemberAttendence)
                    .HasForeignKey(d => d.CareTakerGenderId)
                    .HasConstraintName("FK_SINO_Parenting_IndirectMember_Attendence_A_Gender");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.SinoParentingIndirectMemberAttendence)
                    .HasForeignKey(d => d.RelationshipId)
                    .HasConstraintName("FK_SINO_Parenting_IndirectMember_Attendence_A_Relationship");

                entity.HasOne(d => d.SinoParenting)
                    .WithMany(p => p.SinoParentingIndirectMemberAttendence)
                    .HasForeignKey(d => d.SinoParentingId)
                    .HasConstraintName("FK_SINO_Parenting_IndirectMember_Attendence_SINO_Parenting_Attendence_Register");

                entity.HasOne(d => d.VslaGroupIndirectMember)
                    .WithMany(p => p.SinoParentingIndirectMemberAttendence)
                    .HasForeignKey(d => d.VslaGroupIndirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SINO_Parenting_IndirectMember_Attendence_VSLA_Group_Indirect_Member");
            });

            modelBuilder.Entity<SinoParentingIndirectMemberDetail>(entity =>
            {
                entity.ToTable("SINO_Parenting_IndirectMember_Detail");

                entity.Property(e => e.SinoParentingIndirectMemberDetailId).ValueGeneratedNever();

                entity.Property(e => e.ParentAttended).HasColumnName("Parent_Attended");

                entity.Property(e => e.SessionDate).HasColumnType("datetime");

                entity.Property(e => e.TeenAttended).HasColumnName("Teen_Attended");

                entity.HasOne(d => d.ParentAttendedNavigation)
                    .WithMany(p => p.SinoParentingIndirectMemberDetailParentAttendedNavigation)
                    .HasForeignKey(d => d.ParentAttended)
                    .HasConstraintName("FK_SINO_Parenting_IndirectMember_Detail_A_YesNo");

                entity.HasOne(d => d.ParentingGroupSession)
                    .WithMany(p => p.SinoParentingIndirectMemberDetail)
                    .HasForeignKey(d => d.ParentingGroupSessionId)
                    .HasConstraintName("FK_SINO_Parenting_IndirectMember_Detail_A_ParentingGroupSession");

                entity.HasOne(d => d.SinoParentingIndirectMember)
                    .WithMany(p => p.SinoParentingIndirectMemberDetail)
                    .HasForeignKey(d => d.SinoParentingIndirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SINO_Parenting_IndirectMember_Detail_SINO_Parenting_IndirectMember_Attendence");

                entity.HasOne(d => d.TeenAttendedNavigation)
                    .WithMany(p => p.SinoParentingIndirectMemberDetailTeenAttendedNavigation)
                    .HasForeignKey(d => d.TeenAttended)
                    .HasConstraintName("FK_SINO_Parenting_IndirectMember_Detail_A_YesNo1");
            });

            modelBuilder.Entity<SinovuyoGroups2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SinovuyoGroups_2");

                entity.Property(e => e.Age).HasColumnName("Age  ");

                entity.Property(e => e.CheckedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Checked by");

                entity.Property(e => e.Date)
                    .HasMaxLength(255)
                    .HasColumnName("DATE");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(2106)
                    .HasColumnName("Group Code");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .HasColumnName("Group Name");

                entity.Property(e => e.HhIndividualCode)
                    .HasMaxLength(255)
                    .HasColumnName("HH individual Code");

                entity.Property(e => e.MeetingTime)
                    .HasMaxLength(255)
                    .HasColumnName("Meeting Time");

                entity.Property(e => e.MeetingVenue)
                    .HasMaxLength(255)
                    .HasColumnName("Meeting Venue");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("Name ");

                entity.Property(e => e.SexMF)
                    .HasMaxLength(255)
                    .HasColumnName("Sex M/F ");

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Verified by");

                entity.Property(e => e.Village)
                    .HasMaxLength(255)
                    .HasColumnName("Village ");
            });

            modelBuilder.Entity<SmuAgeGroup>(entity =>
            {
                entity.HasKey(e => e.AgeGroupId);

                entity.ToTable("SMU_Age_Group");

                entity.Property(e => e.AgeGroupId).ValueGeneratedNever();

                entity.Property(e => e.AgeGroup).HasMaxLength(1000);
            });

            modelBuilder.Entity<SmuAssessmentGuide>(entity =>
            {
                entity.HasKey(e => e.AssementGuideId);

                entity.ToTable("SMU_Assessment_Guide");

                entity.Property(e => e.AssementGuideId).HasColumnName("Assement_Guide_Id");

                entity.Property(e => e.ClientRegistrationId).HasColumnName("Client_RegistrationId");

                entity.Property(e => e.ConsentObtainedYesNo).HasColumnName("ConsentObtained_YesNo");

                entity.Property(e => e.DateOfAssessment)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_Assessment");

                entity.Property(e => e.ExperiencedGenderBasedViolence).HasColumnName("Experienced_Gender_Based_Violence");

                entity.Property(e => e.ExperiencedThoughtsOffDeadHurting).HasColumnName("Experienced_Thoughts_Off_Dead_Hurting");

                entity.Property(e => e.Ph9QuestionScore).HasColumnName("PH9_QuestionScore");

                entity.Property(e => e.RespondantAge).HasColumnName("Respondant_Age");

                entity.Property(e => e.RespondantGenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Respondant_GenderId")
                    .IsFixedLength(true);

                entity.Property(e => e.SchoolNameOrPrisonName)
                    .HasMaxLength(1000)
                    .HasColumnName("School_Name_OR_Prison_Name");

                entity.Property(e => e.SmuGroupId).HasColumnName("SMU_GroupId");

                entity.Property(e => e.SmuOfficeId).HasColumnName("SMU_OfficeId");

                entity.Property(e => e.SmuProgramId).HasColumnName("SMU_ProgramId");

                entity.Property(e => e.StaffVolunteerName)
                    .HasMaxLength(1000)
                    .HasColumnName("Staff_Volunteer_Name");

                entity.Property(e => e.StressfulEventId).HasColumnName("Stressful_EventId");

                entity.Property(e => e.SuicideAssementQuestionEightResponse).HasColumnName("Suicide_Assement_Question_Eight_Response");

                entity.Property(e => e.SuicideAssementQuestionEightScore).HasColumnName("Suicide_Assement_Question_Eight_Score");

                entity.Property(e => e.SuicideAssementQuestionFiveResponse).HasColumnName("Suicide_Assement_Question_Five_Response");

                entity.Property(e => e.SuicideAssementQuestionFiveScore).HasColumnName("Suicide_Assement_Question_Five_Score");

                entity.Property(e => e.SuicideAssementQuestionFourResponse).HasColumnName("Suicide_Assement_Question_Four_Response");

                entity.Property(e => e.SuicideAssementQuestionFourScore).HasColumnName("Suicide_Assement_Question_Four_Score");

                entity.Property(e => e.SuicideAssementQuestionNineResponse).HasColumnName("Suicide_Assement_Question_Nine_Response");

                entity.Property(e => e.SuicideAssementQuestionNineScore).HasColumnName("Suicide_Assement_Question_Nine_Score");

                entity.Property(e => e.SuicideAssementQuestionOneResponse).HasColumnName("Suicide_Assement_Question_One_Response");

                entity.Property(e => e.SuicideAssementQuestionOneScore).HasColumnName("Suicide_Assement_Question_One_Score");

                entity.Property(e => e.SuicideAssementQuestionSevenResponse).HasColumnName("Suicide_Assement_Question_Seven_Response");

                entity.Property(e => e.SuicideAssementQuestionSevenScore).HasColumnName("Suicide_Assement_Question_Seven_Score");

                entity.Property(e => e.SuicideAssementQuestionSixResponse).HasColumnName("Suicide_Assement_Question_Six_Response");

                entity.Property(e => e.SuicideAssementQuestionSixScore).HasColumnName("Suicide_Assement_Question_Six_Score");

                entity.Property(e => e.SuicideAssementQuestionTenResponse).HasColumnName("Suicide_Assement_Question_Ten_Response");

                entity.Property(e => e.SuicideAssementQuestionTenScore).HasColumnName("Suicide_Assement_Question_Ten_Score");

                entity.Property(e => e.SuicideAssementQuestionThreeResponse).HasColumnName("Suicide_Assement_Question_Three_Response");

                entity.Property(e => e.SuicideAssementQuestionThreeScore).HasColumnName("Suicide_Assement_Question_Three_Score");

                entity.Property(e => e.SuicideAssementQuestionTwoResponse).HasColumnName("Suicide_Assement_Question_Two_Response");

                entity.Property(e => e.SuicideAssementQuestionTwoScore).HasColumnName("Suicide_Assement_Question_Two_Score");

                entity.Property(e => e.SuicideAssementTotalScore).HasColumnName("Suicide_Assement_Total_Score");

                entity.Property(e => e.SuicideAssessmentScore).HasColumnName("Suicide_Assessment_Score");

                entity.HasOne(d => d.ClientRegistration)
                    .WithMany(p => p.SmuAssessmentGuide)
                    .HasForeignKey(d => d.ClientRegistrationId)
                    .HasConstraintName("FK_SMU_Assessment_Guide_SMU_Client_Registration_Form");

                entity.HasOne(d => d.ConsentObtainedYesNoNavigation)
                    .WithMany(p => p.SmuAssessmentGuideConsentObtainedYesNoNavigation)
                    .HasForeignKey(d => d.ConsentObtainedYesNo)
                    .HasConstraintName("FK_SMU_Assessment_Guide_A_YesNo");

                entity.HasOne(d => d.ExperiencedGenderBasedViolenceNavigation)
                    .WithMany(p => p.SmuAssessmentGuideExperiencedGenderBasedViolenceNavigation)
                    .HasForeignKey(d => d.ExperiencedGenderBasedViolence)
                    .HasConstraintName("FK_SMU_Assessment_Guide_A_YesNo1");

                entity.HasOne(d => d.ExperiencedThoughtsOffDeadHurtingNavigation)
                    .WithMany(p => p.SmuAssessmentGuideExperiencedThoughtsOffDeadHurtingNavigation)
                    .HasForeignKey(d => d.ExperiencedThoughtsOffDeadHurting)
                    .HasConstraintName("FK_SMU_Assessment_Guide_A_YesNo2");

                entity.HasOne(d => d.SmuGroup)
                    .WithMany(p => p.SmuAssessmentGuide)
                    .HasForeignKey(d => d.SmuGroupId)
                    .HasConstraintName("FK_SMU_Assessment_Guide_SMU_Group");

                entity.HasOne(d => d.SmuProgram)
                    .WithMany(p => p.SmuAssessmentGuide)
                    .HasForeignKey(d => d.SmuProgramId)
                    .HasConstraintName("FK_SMU_Assessment_Guide_SMU_Program");

                entity.HasOne(d => d.StressfulEvent)
                    .WithMany(p => p.SmuAssessmentGuideStressfulEvent)
                    .HasForeignKey(d => d.StressfulEventId)
                    .HasConstraintName("FK_SMU_Assessment_Guide_A_YesNo3");
            });

            modelBuilder.Entity<SmuAssessmentGuidePh9Questions>(entity =>
            {
                entity.ToTable("SMU_Assessment_Guide_PH9_Questions");

                entity.Property(e => e.SmuAssessmentGuidePh9QuestionsId).HasColumnName("SMU_Assessment_Guide_PH9_QuestionsId");

                entity.Property(e => e.Ph9QuestionHeaderId).HasColumnName("PH9_Question_HeaderId");

                entity.Property(e => e.Ph9QuestionsId).HasColumnName("PH9_QuestionsId");

                entity.Property(e => e.SmuAssessmentGuideId).HasColumnName("SMU_Assessment_GuideId");

                entity.Property(e => e.SmuAssessmentGuidePh9QuestionsSored).HasColumnName("SMU_Assessment_Guide_PH9_Questions_Sored");

                entity.HasOne(d => d.Ph9Questions)
                    .WithMany(p => p.SmuAssessmentGuidePh9Questions)
                    .HasForeignKey(d => d.Ph9QuestionsId)
                    .HasConstraintName("FK_SMU_Assessment_Guide_PH9_Questions_SMU_PH9_Question");

                entity.HasOne(d => d.SmuAssessmentGuide)
                    .WithMany(p => p.SmuAssessmentGuidePh9Questions)
                    .HasForeignKey(d => d.SmuAssessmentGuideId)
                    .HasConstraintName("FK_SMU_Assessment_Guide_PH9_Questions_SMU_Assessment_Guide");
            });

            modelBuilder.Entity<SmuAttendanceKey>(entity =>
            {
                entity.HasKey(e => e.AttendenceKeyId);

                entity.ToTable("SMU_Attendance_Key");

                entity.Property(e => e.AttendenceKeyId)
                    .ValueGeneratedNever()
                    .HasColumnName("Attendence_Key_Id");

                entity.Property(e => e.AttendenceKey)
                    .HasMaxLength(1000)
                    .HasColumnName("Attendence_Key");
            });

            modelBuilder.Entity<SmuAttendenceFormDetail>(entity =>
            {
                entity.HasKey(e => e.AttendenceFormDetailId);

                entity.ToTable("SMU_Attendence_Form_Detail");

                entity.Property(e => e.AttendenceFormDetailId).HasColumnName("Attendence_Form_DetailId");

                entity.Property(e => e.AttendedIdSessionFive).HasColumnName("AttendedId_Session_Five");

                entity.Property(e => e.AttendedIdSessionFour).HasColumnName("AttendedId_Session_Four");

                entity.Property(e => e.AttendedIdSessionOne).HasColumnName("AttendedId_Session_One");

                entity.Property(e => e.AttendedIdSessionSix).HasColumnName("AttendedId_Session_Six");

                entity.Property(e => e.AttendedIdSessionThree).HasColumnName("AttendedId_Session_Three");

                entity.Property(e => e.AttendedIdSessionTwo).HasColumnName("AttendedId_Session_Two");

                entity.Property(e => e.AttendenceFormHeaderId).HasColumnName("Attendence_Form_HeaderId");

                entity.Property(e => e.ClientAttendenceId).HasColumnName("Client_AttendenceId");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(1000)
                    .HasColumnName("Client_Code");

                entity.Property(e => e.ClientPhoneContact)
                    .HasMaxLength(1000)
                    .HasColumnName("Client_Phone_Contact");

                entity.Property(e => e.CreatedBy).HasMaxLength(1000);

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.KaguguIdSessionFive).HasColumnName("KaguguId_Session_Five");

                entity.Property(e => e.KaguguIdSessionFour).HasColumnName("KaguguId_Session_Four");

                entity.Property(e => e.KaguguIdSessionOne).HasColumnName("KaguguId_Session_One");

                entity.Property(e => e.KaguguIdSessionSix).HasColumnName("KaguguId_Session_Six");

                entity.Property(e => e.KaguguIdSessionThree).HasColumnName("KaguguId_Session_Three");

                entity.Property(e => e.KaguguIdSessionTwo).HasColumnName("KaguguId_Session_Two");

                entity.Property(e => e.OtherReasoneSessionFive)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_Five");

                entity.Property(e => e.OtherReasoneSessionFour)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_Four");

                entity.Property(e => e.OtherReasoneSessionOne)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_One");

                entity.Property(e => e.OtherReasoneSessionSix)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_Six");

                entity.Property(e => e.OtherReasoneSessionThree)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_Three");

                entity.Property(e => e.OtherReasoneSessionTwo)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_Two");

                entity.Property(e => e.ReasonSessionFive).HasColumnName("Reason_Session_Five");

                entity.Property(e => e.ReasonSessionFour).HasColumnName("Reason_Session_Four");

                entity.Property(e => e.ReasonSessionOne).HasColumnName("Reason_Session_One");

                entity.Property(e => e.ReasonSessionSix).HasColumnName("Reason_Session_Six");

                entity.Property(e => e.ReasonSessionThree).HasColumnName("Reason_Session_Three");

                entity.Property(e => e.ReasonSessionTwo).HasColumnName("Reason_Session_Two");

                entity.Property(e => e.SessionFiveDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Five_Date");

                entity.Property(e => e.SessionFourDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Four_Date");

                entity.Property(e => e.SessionOneDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_One_Date");

                entity.Property(e => e.SessionSixDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Six_Date");

                entity.Property(e => e.SessionThreeDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Three_Date");

                entity.Property(e => e.SessionTwoDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Two_Date");

                entity.HasOne(d => d.AttendedIdSessionFiveNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailAttendedIdSessionFiveNavigation)
                    .HasForeignKey(d => d.AttendedIdSessionFive)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Attendance_Key");

                entity.HasOne(d => d.AttendedIdSessionFourNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailAttendedIdSessionFourNavigation)
                    .HasForeignKey(d => d.AttendedIdSessionFour)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Attendance_Key1");

                entity.HasOne(d => d.AttendedIdSessionOneNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailAttendedIdSessionOneNavigation)
                    .HasForeignKey(d => d.AttendedIdSessionOne)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Attendance_Key2");

                entity.HasOne(d => d.AttendedIdSessionSixNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailAttendedIdSessionSixNavigation)
                    .HasForeignKey(d => d.AttendedIdSessionSix)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Attendance_Key3");

                entity.HasOne(d => d.AttendedIdSessionThreeNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailAttendedIdSessionThreeNavigation)
                    .HasForeignKey(d => d.AttendedIdSessionThree)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Attendance_Key4");

                entity.HasOne(d => d.AttendedIdSessionTwoNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailAttendedIdSessionTwoNavigation)
                    .HasForeignKey(d => d.AttendedIdSessionTwo)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Attendance_Key5");

                entity.HasOne(d => d.AttendenceFormHeader)
                    .WithMany(p => p.SmuAttendenceFormDetail)
                    .HasForeignKey(d => d.AttendenceFormHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Attendence_Header");

                entity.HasOne(d => d.KaguguIdSessionFiveNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailKaguguIdSessionFiveNavigation)
                    .HasForeignKey(d => d.KaguguIdSessionFive)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Kagugu_Score");

                entity.HasOne(d => d.KaguguIdSessionFourNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailKaguguIdSessionFourNavigation)
                    .HasForeignKey(d => d.KaguguIdSessionFour)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Kagugu_Score1");

                entity.HasOne(d => d.KaguguIdSessionOneNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailKaguguIdSessionOneNavigation)
                    .HasForeignKey(d => d.KaguguIdSessionOne)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Kagugu_Score2");

                entity.HasOne(d => d.KaguguIdSessionSixNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailKaguguIdSessionSixNavigation)
                    .HasForeignKey(d => d.KaguguIdSessionSix)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Kagugu_Score3");

                entity.HasOne(d => d.KaguguIdSessionThreeNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailKaguguIdSessionThreeNavigation)
                    .HasForeignKey(d => d.KaguguIdSessionThree)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Kagugu_Score4");

                entity.HasOne(d => d.KaguguIdSessionTwoNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailKaguguIdSessionTwoNavigation)
                    .HasForeignKey(d => d.KaguguIdSessionTwo)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Kagugu_Score5");

                entity.HasOne(d => d.ReasonSessionFiveNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailReasonSessionFiveNavigation)
                    .HasForeignKey(d => d.ReasonSessionFive)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Absence");

                entity.HasOne(d => d.ReasonSessionFourNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailReasonSessionFourNavigation)
                    .HasForeignKey(d => d.ReasonSessionFour)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Absence1");

                entity.HasOne(d => d.ReasonSessionOneNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailReasonSessionOneNavigation)
                    .HasForeignKey(d => d.ReasonSessionOne)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Absence2");

                entity.HasOne(d => d.ReasonSessionSixNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailReasonSessionSixNavigation)
                    .HasForeignKey(d => d.ReasonSessionSix)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Absence3");

                entity.HasOne(d => d.ReasonSessionThreeNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailReasonSessionThreeNavigation)
                    .HasForeignKey(d => d.ReasonSessionThree)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Absence4");

                entity.HasOne(d => d.ReasonSessionTwoNavigation)
                    .WithMany(p => p.SmuAttendenceFormDetailReasonSessionTwoNavigation)
                    .HasForeignKey(d => d.ReasonSessionTwo)
                    .HasConstraintName("FK_SMU_Attendence_Form_Detail_SMU_Absence5");
            });

            modelBuilder.Entity<SmuAttendenceHeader>(entity =>
            {
                entity.HasKey(e => e.AttendenceFormHeaderId)
                    .HasName("PK_SMU_Attendence");

                entity.ToTable("SMU_Attendence_Header");

                entity.Property(e => e.AttendenceFormHeaderId).HasColumnName("Attendence_Form_HeaderId");

                entity.Property(e => e.AttendenceCycleId).HasColumnName("Attendence_CycleId");

                entity.Property(e => e.AttendenceYearId).HasColumnName("Attendence_YearId");

                entity.Property(e => e.CapturedBy).HasMaxLength(1000);

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.SessionFiveDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Five_Date");

                entity.Property(e => e.SessionFourDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Four_Date");

                entity.Property(e => e.SessionOneDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_One_Date");

                entity.Property(e => e.SessionSixDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Six_Date");

                entity.Property(e => e.SessionThreeDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Three_Date");

                entity.Property(e => e.SessionTwoDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Two_Date");

                entity.Property(e => e.SmuGroupId).HasColumnName("SMU_GroupId");

                entity.HasOne(d => d.AttendenceCycle)
                    .WithMany(p => p.SmuAttendenceHeader)
                    .HasForeignKey(d => d.AttendenceCycleId)
                    .HasConstraintName("FK_SMU_Attendence_Header_SMU_Cycle");

                entity.HasOne(d => d.AttendenceYear)
                    .WithMany(p => p.SmuAttendenceHeader)
                    .HasForeignKey(d => d.AttendenceYearId)
                    .HasConstraintName("FK_SMU_Attendence_Header_A_FinancialYear");

                entity.HasOne(d => d.SmuGroup)
                    .WithMany(p => p.SmuAttendenceHeader)
                    .HasForeignKey(d => d.SmuGroupId)
                    .HasConstraintName("FK_SMU_Attendence_Header_SMU_Group");
            });

            modelBuilder.Entity<SmuClientRegistrationForm>(entity =>
            {
                entity.HasKey(e => e.ClientRegistrationFormId);

                entity.ToTable("SMU_Client_Registration_Form");

                entity.Property(e => e.ClientRegistrationFormId)
                    .ValueGeneratedNever()
                    .HasColumnName("Client_Registration_FormId");

                entity.Property(e => e.CapturedBy).HasMaxLength(1000);

                entity.Property(e => e.ClientAgeRangeId).HasColumnName("Client_Age_RangeId");

                entity.Property(e => e.ClientContact)
                    .HasMaxLength(1000)
                    .HasColumnName("Client_Contact");

                entity.Property(e => e.ClientGenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Client_GenderId")
                    .IsFixedLength(true);

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.RegistrationDate).HasColumnType("date");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(500)
                    .HasColumnName("Serial_Number");

                entity.Property(e => e.SmuClientName)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Client_Name");

                entity.Property(e => e.SmuGroupId).HasColumnName("SMU_GroupId");

                entity.Property(e => e.SmuOfficeId).HasColumnName("SMU_OfficeId");

                entity.HasOne(d => d.ClientAgeRange)
                    .WithMany(p => p.SmuClientRegistrationForm)
                    .HasForeignKey(d => d.ClientAgeRangeId)
                    .HasConstraintName("FK_SMU_Client_Registration_Form_SMU_Age_Group");

                entity.HasOne(d => d.ClientGender)
                    .WithMany(p => p.SmuClientRegistrationForm)
                    .HasForeignKey(d => d.ClientGenderId)
                    .HasConstraintName("FK_SMU_Client_Registration_Form_A_Gender");

                entity.HasOne(d => d.SmuGroup)
                    .WithMany(p => p.SmuClientRegistrationForm)
                    .HasForeignKey(d => d.SmuGroupId)
                    .HasConstraintName("FK_SMU_Client_Registration_Form_SMU_Group");

                entity.HasOne(d => d.SubCounty)
                    .WithMany(p => p.SmuClientRegistrationForm)
                    .HasForeignKey(d => d.SubCountyId)
                    .HasConstraintName("FK_SMU_Client_Registration_Form_A_Subcounty");
            });

            modelBuilder.Entity<SmuCycle>(entity =>
            {
                entity.HasKey(e => e.CycleId);

                entity.ToTable("SMU_Cycle");

                entity.Property(e => e.CycleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Cycle_Id");

                entity.Property(e => e.CycleDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("Cycle_Description");
            });

            modelBuilder.Entity<SmuFacilitator>(entity =>
            {
                entity.ToTable("SMU_Facilitator");

                entity.Property(e => e.SmuFacilitatorId)
                    .ValueGeneratedNever()
                    .HasColumnName("SMU_FacilitatorId");

                entity.Property(e => e.CapturedBy).HasMaxLength(1000);

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.SmuFacilitatorEmail)
                    .HasMaxLength(500)
                    .HasColumnName("SMU_Facilitator_Email");

                entity.Property(e => e.SmuFacilitatorName)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Facilitator_Name");

                entity.Property(e => e.SmuFacilitatorPhoneNumber)
                    .HasMaxLength(500)
                    .HasColumnName("SMU_Facilitator_PhoneNumber");
            });

            modelBuilder.Entity<SmuFormType>(entity =>
            {
                entity.HasKey(e => e.FormTypeId);

                entity.ToTable("SMU_Form_Type");

                entity.Property(e => e.FormTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Form_TypeId");

                entity.Property(e => e.FormTypeDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("Form_TypeDescription");
            });

            modelBuilder.Entity<SmuGroup>(entity =>
            {
                entity.ToTable("SMU_Group");

                entity.Property(e => e.SmuGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("SMU_GroupId");

                entity.Property(e => e.CapturedBy).HasMaxLength(1000);

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.RegistartionDate).HasColumnType("date");

                entity.Property(e => e.SmuFacilitatorId).HasColumnName("SMU_FacilitatorId");

                entity.Property(e => e.SmuGroupName)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Group_Name");

                entity.Property(e => e.SmuOfficeId).HasColumnName("SMU_OfficeId");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.SmuGroup)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_SMU_Group_A_District");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.SmuGroup)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_SMU_Group_A_Region");

                entity.HasOne(d => d.SmuFacilitator)
                    .WithMany(p => p.SmuGroup)
                    .HasForeignKey(d => d.SmuFacilitatorId)
                    .HasConstraintName("FK_SMU_Group_SMU_Facilitator");

                entity.HasOne(d => d.SmuOffice)
                    .WithMany(p => p.SmuGroup)
                    .HasForeignKey(d => d.SmuOfficeId)
                    .HasConstraintName("FK_SMU_Group_SMU_Office");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.SmuGroup)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_SMU_Group_A_Subcounty");
            });

            modelBuilder.Entity<SmuKaguguScore>(entity =>
            {
                entity.HasKey(e => e.KaguguScoreId);

                entity.ToTable("SMU_Kagugu_Score");

                entity.Property(e => e.KaguguScoreId)
                    .ValueGeneratedNever()
                    .HasColumnName("Kagugu_ScoreId");

                entity.Property(e => e.KaguguScore)
                    .HasMaxLength(1000)
                    .HasColumnName("Kagugu_Score");
            });

            modelBuilder.Entity<SmuLevelOfDifficultyToCheckOffProblems>(entity =>
            {
                entity.HasKey(e => e.LevelOfDifficultyId);

                entity.ToTable("SMU_Level_of_Difficulty_To_Check_Off_Problems");

                entity.Property(e => e.LevelOfDifficultyId)
                    .ValueGeneratedNever()
                    .HasColumnName("Level_of_DifficultyId");

                entity.Property(e => e.LevelOfDifficulty)
                    .HasMaxLength(1000)
                    .HasColumnName("Level_of_Difficulty");
            });

            modelBuilder.Entity<SmuOffice>(entity =>
            {
                entity.HasKey(e => e.OfficeId)
                    .HasName("PK_SMU_Offfice");

                entity.ToTable("SMU_Office");

                entity.Property(e => e.OfficeId).ValueGeneratedNever();

                entity.Property(e => e.OfficeName)
                    .HasMaxLength(1000)
                    .HasColumnName("Office_Name");
            });

            modelBuilder.Entity<SmuPh9Question>(entity =>
            {
                entity.HasKey(e => e.Ph9QuestionId);

                entity.ToTable("SMU_PH9_Question");

                entity.Property(e => e.Ph9QuestionId)
                    .ValueGeneratedNever()
                    .HasColumnName("PH9_QuestionId");

                entity.Property(e => e.FormTypeId)
                    .HasMaxLength(1000)
                    .HasColumnName("Form_TypeId");

                entity.Property(e => e.IsPh9QuestionVisible).HasColumnName("IsPH9_Question_Visible");

                entity.Property(e => e.Ph9Question)
                    .HasMaxLength(1000)
                    .HasColumnName("PH9_Question");

                entity.Property(e => e.SmuFormId).HasColumnName("SMU_FormId");
            });

            modelBuilder.Entity<SmuPh9QuestionHeader>(entity =>
            {
                entity.HasKey(e => e.Ph9QuestionHeaderId);

                entity.ToTable("SMU_PH9_Question_Header");

                entity.Property(e => e.Ph9QuestionHeaderId)
                    .ValueGeneratedNever()
                    .HasColumnName("PH9_Question_HeaderId");

                entity.Property(e => e.Ph9QuestionDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("PH9_Question_Description");

                entity.Property(e => e.Ph9QuestionDescriptionIsVisible).HasColumnName("PH9_Question_Description_IsVisible");

                entity.Property(e => e.Ph9QuestionScore).HasColumnName("PH9_Question_Score");
            });

            modelBuilder.Entity<SmuPreGroupGuide>(entity =>
            {
                entity.ToTable("SMU_Pre_Group_Guide");

                entity.Property(e => e.SmuPreGroupGuideId).HasColumnName("SMU_Pre_Group_GuideId");

                entity.Property(e => e.ClientRegistrationId).HasColumnName("Client_RegistrationId");

                entity.Property(e => e.DateOfAssessment)
                    .HasColumnType("date")
                    .HasColumnName("Date_Of_Assessment");

                entity.Property(e => e.LevelOfDifficultyId).HasColumnName("Level_of_DifficultyId");

                entity.Property(e => e.MaritalStatusId).HasColumnName("Marital_StatusId");

                entity.Property(e => e.NameOfVolunter)
                    .HasMaxLength(1000)
                    .HasColumnName("Name_Of_Volunter");

                entity.Property(e => e.OverallPh9Score).HasColumnName("Overall_PH9_Score");

                entity.Property(e => e.PrisionName)
                    .HasMaxLength(1000)
                    .HasColumnName("Prision_Name");

                entity.Property(e => e.ResidencyStatusId).HasColumnName("Residency_StatusId");

                entity.Property(e => e.RespondantAge).HasColumnName("Respondant_Age");

                entity.Property(e => e.RespondantGenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Respondant_GenderId")
                    .IsFixedLength(true);

                entity.Property(e => e.SchoolClassId).HasColumnName("School_ClassId");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(1000)
                    .HasColumnName("School_Name");

                entity.Property(e => e.SmuGroupId).HasColumnName("SMU_GroupId");

                entity.Property(e => e.SmuOfficeId).HasColumnName("SMU_OfficeId");

                entity.Property(e => e.SmuProgramId).HasColumnName("SMU_ProgramId");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.SmuPreGroupGuide)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_SMU_Pre_Group_Guide_A_MaritalStatus");

                entity.HasOne(d => d.ResidencyStatus)
                    .WithMany(p => p.SmuPreGroupGuide)
                    .HasForeignKey(d => d.ResidencyStatusId)
                    .HasConstraintName("FK_SMU_Pre_Group_Guide_SMU_Residency");

                entity.HasOne(d => d.SmuGroup)
                    .WithMany(p => p.SmuPreGroupGuide)
                    .HasForeignKey(d => d.SmuGroupId)
                    .HasConstraintName("FK_SMU_Pre_Group_Guide_SMU_Group");
            });

            modelBuilder.Entity<SmuPreGroupGuidePh9Questions>(entity =>
            {
                entity.ToTable("SMU_Pre_Group_Guide_PH9_Questions");

                entity.Property(e => e.SmuPreGroupGuidePh9QuestionsId).HasColumnName("SMU_Pre_Group_Guide_PH9_QuestionsId");

                entity.Property(e => e.Ph9QuestionHeaderId).HasColumnName("PH9_Question_HeaderId");

                entity.Property(e => e.Ph9QuestionsId).HasColumnName("PH9_QuestionsId");

                entity.Property(e => e.SmuPreGroupGuideId).HasColumnName("SMU_Pre_Group_GuideId");

                entity.Property(e => e.SmuPreGroupGuidePh9QuestionsSored).HasColumnName("SMU_Pre_Group_Guide_PH9_Questions_Sored");

                entity.HasOne(d => d.SmuPreGroupGuide)
                    .WithMany(p => p.SmuPreGroupGuidePh9Questions)
                    .HasForeignKey(d => d.SmuPreGroupGuideId)
                    .HasConstraintName("FK_SMU_Pre_Group_Guide_PH9_Questions_SMU_Pre_Group_Guide");
            });

            modelBuilder.Entity<SmuProgram>(entity =>
            {
                entity.ToTable("SMU_Program");

                entity.Property(e => e.SmuProgramId)
                    .ValueGeneratedNever()
                    .HasColumnName("SMU_ProgramId");

                entity.Property(e => e.SmuProgramDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Program_Description");
            });

            modelBuilder.Entity<SmuReasonsForSessionAbsence>(entity =>
            {
                entity.HasKey(e => e.ReasonForAbsenceId)
                    .HasName("PK_SMU_Absence");

                entity.ToTable("SMU_Reasons_For_Session_Absence");

                entity.Property(e => e.ReasonForAbsenceId)
                    .ValueGeneratedNever()
                    .HasColumnName("Reason_For_AbsenceId");

                entity.Property(e => e.ReasonForAbsenceDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("Reason_For_Absence_Description");
            });

            modelBuilder.Entity<SmuResidency>(entity =>
            {
                entity.HasKey(e => e.ResidencyId);

                entity.ToTable("SMU_Residency");

                entity.Property(e => e.ResidencyId).ValueGeneratedNever();

                entity.Property(e => e.ResidencyDescription)
                    .HasMaxLength(500)
                    .HasColumnName("Residency_Description");
            });

            modelBuilder.Entity<SmuSafetyPlanningForm>(entity =>
            {
                entity.HasKey(e => e.SafetyPlanningFormId);

                entity.ToTable("SMU_Safety_Planning_Form");

                entity.Property(e => e.InterviewDate)
                    .HasColumnType("date")
                    .HasColumnName("Interview_Date");

                entity.Property(e => e.SmuAssementGuideId).HasColumnName("SMU_Assement_GuideId");

                entity.Property(e => e.StaffVolunteerName)
                    .HasMaxLength(1000)
                    .HasColumnName("Staff_Volunteer_Name");

                entity.HasOne(d => d.SmuAssementGuide)
                    .WithMany(p => p.SmuSafetyPlanningForm)
                    .HasForeignKey(d => d.SmuAssementGuideId)
                    .HasConstraintName("FK_SMU_Safety_Planning_Form_SMU_Assessment_Guide");

                entity.HasOne(d => d.SmuGroup)
                    .WithMany(p => p.SmuSafetyPlanningForm)
                    .HasForeignKey(d => d.SmuGroupId)
                    .HasConstraintName("FK_SMU_Safety_Planning_Form_SMU_Group");
            });

            modelBuilder.Entity<SmuSafetyPlanningFormInternalCopingStrategies>(entity =>
            {
                entity.HasKey(e => e.InternalCopingStrategiesId);

                entity.ToTable("SMU_Safety_Planning_Form_Internal_Coping_Strategies");

                entity.Property(e => e.InternalCopingStrategiesId)
                    .ValueGeneratedNever()
                    .HasColumnName("Internal_Coping_StrategiesId");

                entity.Property(e => e.InternalCopingStrategies)
                    .HasMaxLength(1000)
                    .HasColumnName("Internal_Coping_Strategies");

                entity.Property(e => e.InternalCopingStrategiesNo)
                    .HasMaxLength(500)
                    .HasColumnName("Internal_Coping_Strategies_No");

                entity.Property(e => e.IsPlaceholder).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.SafetyPlanningForm)
                    .WithMany(p => p.SmuSafetyPlanningFormInternalCopingStrategies)
                    .HasForeignKey(d => d.SafetyPlanningFormId)
                    .HasConstraintName("FK_SMU_Safety_Planning_Form_Internal_Coping_Strategies_SMU_Safety_Planning_Form");
            });

            modelBuilder.Entity<SmuSafetyPlanningFormPeopleProvideDistraction>(entity =>
            {
                entity.HasKey(e => e.PeopleProvideDistractionId);

                entity.ToTable("SMU_Safety_Planning_Form_People_Provide_Distraction");

                entity.Property(e => e.PeopleProvideDistractionId)
                    .ValueGeneratedNever()
                    .HasColumnName("People_Provide_DistractionId");

                entity.Property(e => e.PeopleProvideDistractionName)
                    .HasMaxLength(1000)
                    .HasColumnName("People_Provide_Distraction_Name");

                entity.Property(e => e.PeopleProvideDistractionNo)
                    .HasMaxLength(500)
                    .HasColumnName("People_Provide_Distraction_No");

                entity.Property(e => e.PeopleProvideDistractionPhone)
                    .HasMaxLength(1000)
                    .HasColumnName("People_Provide_Distraction_Phone");

                entity.Property(e => e.PeopleProvideDistractionPlace)
                    .HasMaxLength(1000)
                    .HasColumnName("People_Provide_Distraction_Place");

                entity.HasOne(d => d.SafetyPlanningForm)
                    .WithMany(p => p.SmuSafetyPlanningFormPeopleProvideDistraction)
                    .HasForeignKey(d => d.SafetyPlanningFormId)
                    .HasConstraintName("FK_SMU_Safety_Planning_Form_People_Provide_Distraction_SMU_Safety_Planning_Form");
            });

            modelBuilder.Entity<SmuSafetyPlanningFormPeopleToAskForHelp>(entity =>
            {
                entity.HasKey(e => e.PeopleToAskForHelpId);

                entity.ToTable("SMU_Safety_Planning_Form_People_To_Ask_For_Help");

                entity.Property(e => e.PeopleToAskForHelpId)
                    .ValueGeneratedNever()
                    .HasColumnName("People_To_Ask_For_Help_Id");

                entity.Property(e => e.PeopleToAskForHelpName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("People_To_Ask_For_Help_Name");

                entity.Property(e => e.PeopleToAskForHelpNo)
                    .HasMaxLength(500)
                    .HasColumnName("People_To_Ask_For_Help_No");

                entity.Property(e => e.PeopleToAskForHelpPhone)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("People_To_Ask_For_Help_Phone");

                entity.HasOne(d => d.SafetyPlanningForm)
                    .WithMany(p => p.SmuSafetyPlanningFormPeopleToAskForHelp)
                    .HasForeignKey(d => d.SafetyPlanningFormId)
                    .HasConstraintName("FK_SMU_Safety_Planning_Form_People_To_Ask_For_Help_SMU_Safety_Planning_Form");
            });

            modelBuilder.Entity<SmuSafetyPlanningFormProfessionsAgenciesToContact>(entity =>
            {
                entity.HasKey(e => e.ProfessionalsAgenciesToContactDuringCrisisId);

                entity.ToTable("SMU_Safety_Planning_Form_Professions_Agencies_To_Contact");

                entity.Property(e => e.ProfessionalsAgenciesToContactDuringCrisisId)
                    .ValueGeneratedNever()
                    .HasColumnName("Professionals_Agencies_To_Contact_During_CrisisId");

                entity.Property(e => e.ClinicianName)
                    .HasMaxLength(1000)
                    .HasColumnName("Clinician_Name");

                entity.Property(e => e.ClinicianPhoneNumber)
                    .HasMaxLength(1000)
                    .HasColumnName("Clinician_Phone_Number");

                entity.Property(e => e.LocalUrgentCareServices)
                    .HasMaxLength(1000)
                    .HasColumnName("Local_Urgent_Care_Services");

                entity.Property(e => e.NameOfClinic)
                    .HasMaxLength(1000)
                    .HasColumnName("Name_of_Clinic");

                entity.Property(e => e.ProfessionalsAgenciesToContactDuringCrisisNo)
                    .HasMaxLength(500)
                    .HasColumnName("Professionals_Agencies_To_Contact_During_Crisis_No");

                entity.Property(e => e.UrgentCareServicesAddress)
                    .HasMaxLength(1000)
                    .HasColumnName("Urgent_Care_Services_Address");

                entity.Property(e => e.UrgentCareServicesPhone)
                    .HasMaxLength(1000)
                    .HasColumnName("Urgent_Care_Services_Phone");

                entity.HasOne(d => d.SafetyPlanningForm)
                    .WithMany(p => p.SmuSafetyPlanningFormProfessionsAgenciesToContact)
                    .HasForeignKey(d => d.SafetyPlanningFormId)
                    .HasConstraintName("FK_SMU_Safety_Planning_Form_Professions_Agencies_To_Contact_SMU_Safety_Planning_Form");
            });

            modelBuilder.Entity<SmuSafetyPlanningFormWarningSigns>(entity =>
            {
                entity.HasKey(e => e.WarningSignsId);

                entity.ToTable("SMU_Safety_Planning_Form_Warning_Signs");

                entity.Property(e => e.WarningSignsId)
                    .ValueGeneratedNever()
                    .HasColumnName("Warning_SignsId");

                entity.Property(e => e.WarningSignsDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("Warning_Signs_Description");

                entity.Property(e => e.WarningSignsNo)
                    .HasMaxLength(500)
                    .HasColumnName("Warning_Signs_No");

                entity.HasOne(d => d.SafetyPlanningForm)
                    .WithMany(p => p.SmuSafetyPlanningFormWarningSigns)
                    .HasForeignKey(d => d.SafetyPlanningFormId)
                    .HasConstraintName("FK_SMU_Safety_Planning_Form_Warning_Signs_SMU_Safety_Planning_Form");
            });

            modelBuilder.Entity<SmuSucideAssementFormHeader>(entity =>
            {
                entity.HasKey(e => e.SucideAssessmentFormHeaderId)
                    .HasName("PK_Sucide_Assement_Form_Header");

                entity.ToTable("SMU_Sucide_Assement_Form_Header");

                entity.Property(e => e.SucideAssessmentFormHeaderId).HasColumnName("Sucide_Assessment_Form_HeaderId");

                entity.Property(e => e.AssementGuideId).HasColumnName("Assement_Guide_Id");

                entity.Property(e => e.ClientRegistrationId).HasColumnName("Client_RegistrationId");

                entity.Property(e => e.SmuGroupId).HasColumnName("SMU_GroupId");

                entity.Property(e => e.SmuOfficeId).HasColumnName("Smu_OfficeId");

                entity.Property(e => e.SucideAssementQuestionId).HasColumnName("Sucide_Assement_QuestionId");

                entity.Property(e => e.SucideAssementResponseId).HasColumnName("Sucide_Assement_ResponseId");

                entity.Property(e => e.SuicideAssesmentScore).HasColumnName("Suicide_Assesment_Score");

                entity.HasOne(d => d.AssementGuide)
                    .WithMany(p => p.SmuSucideAssementFormHeader)
                    .HasForeignKey(d => d.AssementGuideId)
                    .HasConstraintName("FK_SMU_Sucide_Assement_Form_Header_SMU_Assessment_Guide");

                entity.HasOne(d => d.SucideAssementQuestion)
                    .WithMany(p => p.SmuSucideAssementFormHeader)
                    .HasForeignKey(d => d.SucideAssementQuestionId)
                    .HasConstraintName("FK_SMU_Sucide_Assement_Form_Header_SMU_Sucide_Assement_Question");

                entity.HasOne(d => d.SucideAssementResponse)
                    .WithMany(p => p.SmuSucideAssementFormHeader)
                    .HasForeignKey(d => d.SucideAssementResponseId)
                    .HasConstraintName("FK_SMU_Sucide_Assement_Form_Header_SMU_Sucide_Assement_Response");
            });

            modelBuilder.Entity<SmuSucideAssementQuestion>(entity =>
            {
                entity.HasKey(e => e.SucideAssementQuestionId);

                entity.ToTable("SMU_Sucide_Assement_Question");

                entity.Property(e => e.SucideAssementQuestionId)
                    .ValueGeneratedNever()
                    .HasColumnName("Sucide_Assement_QuestionId");

                entity.Property(e => e.SucideAssementQuestion).HasColumnName("Sucide_Assement_Question");
            });

            modelBuilder.Entity<SmuSucideAssementResponse>(entity =>
            {
                entity.HasKey(e => e.SucideAssementResponseId);

                entity.ToTable("SMU_Sucide_Assement_Response");

                entity.Property(e => e.SucideAssementResponseId)
                    .ValueGeneratedNever()
                    .HasColumnName("Sucide_Assement_ResponseId");

                entity.Property(e => e.SucideAssementResponse)
                    .HasMaxLength(1000)
                    .HasColumnName("Sucide_Assement_Response");
            });

            modelBuilder.Entity<SmuSucideAssementScore>(entity =>
            {
                entity.HasKey(e => e.SucideAssementScoreId);

                entity.ToTable("SMU_Sucide_Assement_Score");

                entity.Property(e => e.SucideAssementScoreId)
                    .ValueGeneratedNever()
                    .HasColumnName("Sucide_Assement_ScoreId");

                entity.Property(e => e.SucideAssementQuestionId).HasColumnName("Sucide_Assement_QuestionId");

                entity.Property(e => e.SucideAssementResponseId).HasColumnName("Sucide_Assement_ResponseId");

                entity.Property(e => e.SucideAssementScore).HasColumnName("Sucide_Assement_Score");

                entity.HasOne(d => d.SucideAssementQuestion)
                    .WithMany(p => p.SmuSucideAssementScore)
                    .HasForeignKey(d => d.SucideAssementQuestionId)
                    .HasConstraintName("FK_SMU_Sucide_Assement_Score_SMU_Sucide_Assement_Question");
            });

            modelBuilder.Entity<SmuTerminantionGuide>(entity =>
            {
                entity.ToTable("SMU_Terminantion_Guide");

                entity.Property(e => e.SmuTerminantionGuideId).HasColumnName("SMU_Terminantion_GuideId");

                entity.Property(e => e.ClientRegistrationId).HasColumnName("Client_RegistrationId");

                entity.Property(e => e.DateOfAssessment)
                    .HasColumnType("date")
                    .HasColumnName("Date_Of_Assessment");

                entity.Property(e => e.EncourageFriendsFamily).HasColumnName("Encourage_Friends_Family");

                entity.Property(e => e.LevelOfDifficultyId).HasColumnName("Level_of_DifficultyId");

                entity.Property(e => e.NameOfVolunter)
                    .HasMaxLength(1000)
                    .HasColumnName("Name_Of_Volunter");

                entity.Property(e => e.OverallPh9Score).HasColumnName("Overall_PH9_Score");

                entity.Property(e => e.RespondantAge).HasColumnName("Respondant_Age");

                entity.Property(e => e.RespondantGenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Respondant_GenderId")
                    .IsFixedLength(true);

                entity.Property(e => e.SmuGroupId).HasColumnName("SMU_GroupId");

                entity.Property(e => e.SmuOfficeId).HasColumnName("SMU_OfficeId");

                entity.Property(e => e.SmuProgramId).HasColumnName("SMU_ProgramId");

                entity.HasOne(d => d.LevelOfDifficulty)
                    .WithMany(p => p.SmuTerminantionGuide)
                    .HasForeignKey(d => d.LevelOfDifficultyId)
                    .HasConstraintName("FK_SMU_Terminantion_Guide_SMU_Level_of_Difficulty_To_Check_Off_Problems");

                entity.HasOne(d => d.SmuGroup)
                    .WithMany(p => p.SmuTerminantionGuide)
                    .HasForeignKey(d => d.SmuGroupId)
                    .HasConstraintName("FK_SMU_Terminantion_Guide_SMU_Group");
            });

            modelBuilder.Entity<SmuTerminantionGuidePh9Questions>(entity =>
            {
                entity.ToTable("SMU_Terminantion_Guide_PH9_Questions");

                entity.Property(e => e.SmuTerminantionGuidePh9QuestionsId).HasColumnName("SMU_Terminantion_Guide_PH9_QuestionsId");

                entity.Property(e => e.Ph9QuestionHeaderId).HasColumnName("PH9_Question_HeaderId");

                entity.Property(e => e.Ph9QuestionsId).HasColumnName("PH9_QuestionsId");

                entity.Property(e => e.SmuTerminantionGuideId).HasColumnName("SMU_Terminantion_GuideId");

                entity.Property(e => e.SmuTerminantionGuidePh9QuestionsSored).HasColumnName("SMU_Terminantion_Guide_PH9_Questions_Sored");

                entity.HasOne(d => d.Ph9QuestionHeader)
                    .WithMany(p => p.SmuTerminantionGuidePh9Questions)
                    .HasForeignKey(d => d.Ph9QuestionHeaderId)
                    .HasConstraintName("FK_SMU_Terminantion_Guide_PH9_Questions_SMU_PH9_Question_Header");

                entity.HasOne(d => d.Ph9Questions)
                    .WithMany(p => p.SmuTerminantionGuidePh9Questions)
                    .HasForeignKey(d => d.Ph9QuestionsId)
                    .HasConstraintName("FK_SMU_Terminantion_Guide_PH9_Questions_SMU_PH9_Question");

                entity.HasOne(d => d.SmuTerminantionGuide)
                    .WithMany(p => p.SmuTerminantionGuidePh9Questions)
                    .HasForeignKey(d => d.SmuTerminantionGuideId)
                    .HasConstraintName("FK_SMU_Terminantion_Guide_PH9_Questions_SMU_Terminantion_Guide");
            });

<<<<<<< HEAD
            modelBuilder.Entity<SmuViewAttendenceFormDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Smu_View_Attendence_Form_Detail");

                entity.Property(e => e.AttendedIdSessionFive).HasColumnName("AttendedId_Session_Five");

                entity.Property(e => e.AttendedIdSessionFour).HasColumnName("AttendedId_Session_Four");

                entity.Property(e => e.AttendedIdSessionOne).HasColumnName("AttendedId_Session_One");

                entity.Property(e => e.AttendedIdSessionSix).HasColumnName("AttendedId_Session_Six");

                entity.Property(e => e.AttendedIdSessionThree).HasColumnName("AttendedId_Session_Three");

                entity.Property(e => e.AttendedIdSessionTwo).HasColumnName("AttendedId_Session_Two");

                entity.Property(e => e.AttendenceFormDetailId).HasColumnName("Attendence_Form_DetailId");

                entity.Property(e => e.AttendenceFormHeaderId).HasColumnName("Attendence_Form_HeaderId");

                entity.Property(e => e.AttendenceKeyFive)
                    .HasMaxLength(1000)
                    .HasColumnName("Attendence_Key_Five");

                entity.Property(e => e.AttendenceKeyFour)
                    .HasMaxLength(1000)
                    .HasColumnName("Attendence_Key_Four");

                entity.Property(e => e.AttendenceKeyOne)
                    .HasMaxLength(1000)
                    .HasColumnName("Attendence_Key_One");

                entity.Property(e => e.AttendenceKeySix)
                    .HasMaxLength(1000)
                    .HasColumnName("Attendence_Key_Six");

                entity.Property(e => e.AttendenceKeyThree)
                    .HasMaxLength(1000)
                    .HasColumnName("Attendence_Key_Three");

                entity.Property(e => e.AttendenceKeyTwo)
                    .HasMaxLength(1000)
                    .HasColumnName("Attendence_Key_Two");

                entity.Property(e => e.ClientAttendenceId).HasColumnName("Client_AttendenceId");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(1000)
                    .HasColumnName("Client_Code");

                entity.Property(e => e.ClientPhoneContact)
                    .HasMaxLength(1000)
                    .HasColumnName("Client_Phone_Contact");

                entity.Property(e => e.KaguguIdSessionFive).HasColumnName("KaguguId_Session_Five");

                entity.Property(e => e.KaguguIdSessionFour).HasColumnName("KaguguId_Session_Four");

                entity.Property(e => e.KaguguIdSessionOne).HasColumnName("KaguguId_Session_One");

                entity.Property(e => e.KaguguIdSessionSix).HasColumnName("KaguguId_Session_Six");

                entity.Property(e => e.KaguguIdSessionThree).HasColumnName("KaguguId_Session_Three");

                entity.Property(e => e.KaguguIdSessionTwo).HasColumnName("KaguguId_Session_Two");

                entity.Property(e => e.KaguguScoreFive)
                    .HasMaxLength(1000)
                    .HasColumnName("Kagugu_Score_Five");

                entity.Property(e => e.KaguguScoreFour)
                    .HasMaxLength(1000)
                    .HasColumnName("Kagugu_Score_Four");

                entity.Property(e => e.KaguguScoreOne)
                    .HasMaxLength(1000)
                    .HasColumnName("Kagugu_Score_One");

                entity.Property(e => e.KaguguScoreSix)
                    .HasMaxLength(1000)
                    .HasColumnName("Kagugu_Score_Six");

                entity.Property(e => e.KaguguScoreThree)
                    .HasMaxLength(1000)
                    .HasColumnName("Kagugu_Score_Three");

                entity.Property(e => e.KaguguScoreTwo)
                    .HasMaxLength(1000)
                    .HasColumnName("Kagugu_Score_Two");

                entity.Property(e => e.OtherReasoneSessionFive)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_Five");

                entity.Property(e => e.OtherReasoneSessionFour)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_Four");

                entity.Property(e => e.OtherReasoneSessionOne)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_One");

                entity.Property(e => e.OtherReasoneSessionSix)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_Six");

                entity.Property(e => e.OtherReasoneSessionThree)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_Three");

                entity.Property(e => e.OtherReasoneSessionTwo)
                    .HasMaxLength(1000)
                    .HasColumnName("Other_Reasone_Session_Two");

                entity.Property(e => e.ReasonForAbsenceDescriptionFive)
                    .HasMaxLength(1000)
                    .HasColumnName("Reason_For_Absence_Description_Five");

                entity.Property(e => e.ReasonForAbsenceDescriptionFour)
                    .HasMaxLength(1000)
                    .HasColumnName("Reason_For_Absence_Description_Four");

                entity.Property(e => e.ReasonForAbsenceDescriptionOne)
                    .HasMaxLength(1000)
                    .HasColumnName("Reason_For_Absence_Description_One");

                entity.Property(e => e.ReasonForAbsenceDescriptionSix)
                    .HasMaxLength(1000)
                    .HasColumnName("Reason_For_Absence_Description_Six");

                entity.Property(e => e.ReasonForAbsenceDescriptionThree)
                    .HasMaxLength(1000)
                    .HasColumnName("Reason_For_Absence_Description_Three");

                entity.Property(e => e.ReasonForAbsenceDescriptionTwo)
                    .HasMaxLength(1000)
                    .HasColumnName("Reason_For_Absence_Description_Two");

                entity.Property(e => e.ReasonSessionFive).HasColumnName("Reason_Session_Five");

                entity.Property(e => e.ReasonSessionFour).HasColumnName("Reason_Session_Four");

                entity.Property(e => e.ReasonSessionOne).HasColumnName("Reason_Session_One");

                entity.Property(e => e.ReasonSessionSix).HasColumnName("Reason_Session_Six");

                entity.Property(e => e.ReasonSessionThree).HasColumnName("Reason_Session_Three");

                entity.Property(e => e.ReasonSessionTwo).HasColumnName("Reason_Session_Two");

                entity.Property(e => e.SmuClientName)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Client_Name");
            });

            modelBuilder.Entity<SmuViewAttendenceHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Smu_View_Attendence_Header");

                entity.Property(e => e.AttendenceCycleId).HasColumnName("Attendence_CycleId");

                entity.Property(e => e.AttendenceFormHeaderId).HasColumnName("Attendence_Form_HeaderId");

                entity.Property(e => e.AttendenceYearId).HasColumnName("Attendence_YearId");

                entity.Property(e => e.CycleDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("Cycle_Description");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);

                entity.Property(e => e.OfficeName)
                    .HasMaxLength(1000)
                    .HasColumnName("Office_Name");

                entity.Property(e => e.RegionDescription).HasMaxLength(100);

                entity.Property(e => e.SessionFiveDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Five_Date");

                entity.Property(e => e.SessionFourDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Four_Date");

                entity.Property(e => e.SessionOneDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_One_Date");

                entity.Property(e => e.SessionSixDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Six_Date");

                entity.Property(e => e.SessionThreeDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Three_Date");

                entity.Property(e => e.SessionTwoDate)
                    .HasColumnType("date")
                    .HasColumnName("Session_Two_Date");

                entity.Property(e => e.SmuFacilitatorId).HasColumnName("SMU_FacilitatorId");

                entity.Property(e => e.SmuFacilitatorName)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Facilitator_Name");

                entity.Property(e => e.SmuGroupId).HasColumnName("SMU_GroupId");

                entity.Property(e => e.SmuGroupName)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Group_Name");

                entity.Property(e => e.SmuOfficeId).HasColumnName("SMU_OfficeId");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<SmuViewClientRegistrationForm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Smu_View_Client_Registration_Form");

                entity.Property(e => e.AgeGroup).HasMaxLength(1000);

                entity.Property(e => e.ClientAgeRangeId).HasColumnName("Client_Age_RangeId");

                entity.Property(e => e.ClientContact)
                    .HasMaxLength(1000)
                    .HasColumnName("Client_Contact");

                entity.Property(e => e.ClientGenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Client_GenderId")
                    .IsFixedLength(true);

                entity.Property(e => e.ClientRegistrationFormId).HasColumnName("Client_Registration_FormId");

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.OfficeName)
                    .HasMaxLength(1000)
                    .HasColumnName("Office_Name");

                entity.Property(e => e.RegionDescription).HasMaxLength(100);

                entity.Property(e => e.RegistrationDate).HasColumnType("date");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(500)
                    .HasColumnName("Serial_Number");

                entity.Property(e => e.SmuClientName)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Client_Name");

                entity.Property(e => e.SmuFacilitatorId).HasColumnName("SMU_FacilitatorId");

                entity.Property(e => e.SmuFacilitatorName)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Facilitator_Name");

                entity.Property(e => e.SmuGroupId).HasColumnName("SMU_GroupId");

                entity.Property(e => e.SmuGroupName)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Group_Name");

                entity.Property(e => e.SmuOfficeId).HasColumnName("SMU_OfficeId");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

=======
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
            modelBuilder.Entity<StakeHolderDataCapture>(entity =>
            {
                entity.HasKey(e => e.StakeHolderValueId);

                entity.Property(e => e.StakeHolderValueId).ValueGeneratedNever();

                entity.Property(e => e.CapturedBy).HasMaxLength(3000);

                entity.Property(e => e.DateCaptured).HasColumnType("datetime");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.StakeHolderDataCapture)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_StakeHolderDataCapture_A_District");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.StakeHolderDataCapture)
                    .HasForeignKey(d => d.FinancialYearId)
                    .HasConstraintName("FK_StakeHolderDataCapture_A_FinancialYear");

                entity.HasOne(d => d.Indicator)
                    .WithMany(p => p.StakeHolderDataCapture)
                    .HasForeignKey(d => d.IndicatorId)
                    .HasConstraintName("FK_StakeHolderDataCapture_A_Indicators");

                entity.HasOne(d => d.Quarter)
                    .WithMany(p => p.StakeHolderDataCapture)
                    .HasForeignKey(d => d.QuarterId)
                    .HasConstraintName("FK_StakeHolderDataCapture_A_Quarter");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.StakeHolderDataCapture)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK_StakeHolderDataCapture_A_Service_Provider");
            });

            modelBuilder.Entity<SubcountyCodes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Column5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 5");

                entity.Property(e => e.Column6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 6");

                entity.Property(e => e.CorrectSubCountyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Correct Sub county Code");

                entity.Property(e => e.DistrictDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCountyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubcountyDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubcountyId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableVillage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_Village");

                entity.Property(e => e.ParishDesc).HasMaxLength(3000);

                entity.Property(e => e.VillageDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<TblErrorLog>(entity =>
            {
                entity.ToTable("tblErrorLog");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UploadUpdateHouseholdData1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UploadUpdateHouseholdData_1");

                entity.Property(e => e.AdjustedHivStatus)
                    .HasMaxLength(255)
                    .HasColumnName("Adjusted HIV Status");

                entity.Property(e => e.AdjustedRiskFactorQ3Final)
                    .HasMaxLength(255)
                    .HasColumnName("Adjusted Risk Factor_Q3_Final");

                entity.Property(e => e.AgeCategory)
                    .HasMaxLength(255)
                    .HasColumnName("Age Category");

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.Givenname).HasMaxLength(128);

                entity.Property(e => e.HibridSubcounty)
                    .HasMaxLength(255)
                    .HasColumnName("HIBRID Subcounty");

                entity.Property(e => e.HouseholdCode)
                    .HasMaxLength(255)
                    .HasColumnName("Household Code");

                entity.Property(e => e.HouseholdMemberCode)
                    .HasMaxLength(255)
                    .HasColumnName("Household Member Code");

                entity.Property(e => e.HouseholdMemberName)
                    .HasMaxLength(255)
                    .HasColumnName("Household Member Name");

                entity.Property(e => e.Iscaregiver)
                    .HasMaxLength(255)
                    .HasColumnName("ISCAREGIVER");

                entity.Property(e => e.Parish).HasMaxLength(255);

                entity.Property(e => e.ProgramParticipationStatus)
                    .HasMaxLength(255)
                    .HasColumnName("Program Participation Status");

                entity.Property(e => e.Sex)
                    .HasMaxLength(255)
                    .HasColumnName("Sex ");

                entity.Property(e => e.Surname).HasMaxLength(128);

                entity.Property(e => e.Village).HasMaxLength(255);
            });

            modelBuilder.Entity<ViewAContacts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_A_Contacts");

                entity.Property(e => e.ContactEmail).HasMaxLength(3000);

                entity.Property(e => e.ContactFirstName).HasMaxLength(3000);

                entity.Property(e => e.ContactLastName).HasMaxLength(3000);

                entity.Property(e => e.ContactMiddleName).HasMaxLength(3000);

                entity.Property(e => e.ContactPhoneNumber).HasMaxLength(3000);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<ViewADistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_A_District");

                entity.Property(e => e.DistricCode).HasMaxLength(100);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.RegionDescription).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewAFacility>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_A_Facility");

                entity.Property(e => e.DistricCode).HasMaxLength(100);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.FacilityName).HasMaxLength(1000);
            });

            modelBuilder.Entity<ViewAHomeVisitServicesNeeded>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_A_Home_Visit_Services_Needed");

                entity.Property(e => e.ServiceCategoryDesc).HasMaxLength(3000);

                entity.Property(e => e.ServiceClassiffication).HasMaxLength(3000);

                entity.Property(e => e.ServiceNeededDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Needed_Desc");

                entity.Property(e => e.ServiceNeededId).HasColumnName("Service_Needed_Id");
            });

            modelBuilder.Entity<ViewAParentingGroupSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_A_ParentingGroupSession");

                entity.Property(e => e.ParentingGroupSessionDesc).HasMaxLength(3000);

                entity.Property(e => e.ParentingGroupSessionTypedesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewAParish>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_A_Parish");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.ParishDescription).HasMaxLength(2000);

                entity.Property(e => e.RegionDescription).HasMaxLength(100);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewAPriorityAreaCodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_A_PriorityAreaCodes");

                entity.Property(e => e.PriorityAreaCodeDesc).HasMaxLength(3000);

                entity.Property(e => e.PriorityAreaDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewASubcounty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_A_Subcounty");

                entity.Property(e => e.DistricCode).HasMaxLength(100);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.RegionDescription).HasMaxLength(100);

                entity.Property(e => e.SubCountyCode).HasMaxLength(100);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewATargets>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_A_Targets");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewAVillage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_A_Village");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.ParishDescription).HasMaxLength(2000);

                entity.Property(e => e.RegionDescription).HasMaxLength(100);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.VillageDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewAdminUnits>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AdminUnits");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.RegionDescription).HasMaxLength(100);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewAserviceLinkedToCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewAServiceLinkedToCategory");

                entity.Property(e => e.LinkageServiceCategoryDesc).HasMaxLength(3000);

                entity.Property(e => e.ServiceLinkedToDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewAtrainingSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewATrainingSession");

                entity.Property(e => e.CurriculumDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Curriculum_Desc");

                entity.Property(e => e.CurriculumId).HasColumnName("Curriculum_Id");

                entity.Property(e => e.SessionCategory)
                    .HasMaxLength(3000)
                    .HasColumnName("Session_Category");

                entity.Property(e => e.SessionDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Session_Desc");
            });

            modelBuilder.Entity<ViewBeneficiaryEnrolmentRegisterDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_BeneficiaryEnrolmentRegisterDetails");

                entity.Property(e => e.AddedBy).HasMaxLength(3000);

                entity.Property(e => e.Artnumber)
                    .HasMaxLength(1000)
                    .HasColumnName("ARTNumber");

                entity.Property(e => e.CareGiverDesc).HasMaxLength(3000);

                entity.Property(e => e.Cohort).HasColumnType("date");

                entity.Property(e => e.Copies).HasMaxLength(1000);

                entity.Property(e => e.CurrentlyonArt).HasColumnName("CurrentlyonART");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateofIdentification).HasColumnType("date");

                entity.Property(e => e.DisabilityDescription).HasMaxLength(3000);

                entity.Property(e => e.DispensingModelDescription).HasMaxLength(1000);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.EducationLevelDescription).HasMaxLength(3000);

                entity.Property(e => e.EnrollmentDate).HasColumnType("date");

                entity.Property(e => e.FacilityName).HasMaxLength(1000);

                entity.Property(e => e.GenderDescription).HasMaxLength(1000);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GivenName).HasMaxLength(3000);

                entity.Property(e => e.HasanIga).HasColumnName("HasanIGA");

                entity.Property(e => e.HivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberArtnumber)
                    .HasMaxLength(1000)
                    .HasColumnName("HouseHoldMemberARTNumber");

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.HouseHoldMemberCohort).HasColumnType("date");

                entity.Property(e => e.HouseHoldMemberCurrentlyonArt).HasColumnName("HouseHoldMemberCurrentlyonART");

                entity.Property(e => e.HouseHoldMemberDoB).HasColumnType("date");

                entity.Property(e => e.HouseHoldMemberGenderDescription).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberGenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HouseHoldMemberGivenname).HasMaxLength(3000);

                entity.Property(e => e.HouseHoldMemberHivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HouseHoldMemberHIVStatusDescription");

                entity.Property(e => e.HouseHoldMemberHivstatusId).HasColumnName("HouseHoldMemberHIVStatusId");

                entity.Property(e => e.HouseHoldMemberKnownRiskFactorDescription).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberSurname).HasMaxLength(3000);

                entity.Property(e => e.IdentificationDescription).HasMaxLength(1000);

                entity.Property(e => e.KnownRiskFactorDescription).HasMaxLength(1000);

                entity.Property(e => e.NameofSchool).HasMaxLength(3000);

                entity.Property(e => e.OtherIdentificationSource).HasMaxLength(3000);

                entity.Property(e => e.OtherSourceDocument).HasMaxLength(3000);

                entity.Property(e => e.ParishDescription).HasMaxLength(2000);

                entity.Property(e => e.ProgramParticipationDescription).HasMaxLength(3000);

                entity.Property(e => e.RegimenCategoryDescription).HasMaxLength(1000);

                entity.Property(e => e.RegimenDescription).HasMaxLength(1000);

                entity.Property(e => e.SourceDocumentDescription).HasMaxLength(1000);

                entity.Property(e => e.SourceDocumentExt).HasMaxLength(50);

                entity.Property(e => e.SourceDocumentUrl)
                    .HasMaxLength(3000)
                    .HasColumnName("SourceDocumentURL");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.Surname).HasMaxLength(3000);

                entity.Property(e => e.TelephoneContact).HasMaxLength(1000);

                entity.Property(e => e.VillageDescription).HasMaxLength(2000);

                entity.Property(e => e.ViralLoadSuppressedDescription).HasMaxLength(50);

                entity.Property(e => e.VirallaodDate).HasColumnType("date");
            });

            modelBuilder.Entity<ViewBeneficiaryIdentificationRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_BeneficiaryIdentificationRegister");

                entity.Property(e => e.AddedBy).HasMaxLength(3000);

                entity.Property(e => e.Artnumber)
                    .HasMaxLength(1000)
                    .HasColumnName("ARTNumber");

                entity.Property(e => e.Cohort).HasColumnType("date");

                entity.Property(e => e.Copies).HasMaxLength(1000);

                entity.Property(e => e.CurrentlyonArt).HasColumnName("CurrentlyonART");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateofIdentification).HasColumnType("date");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.FacilityName).HasMaxLength(1000);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GivenName).HasMaxLength(3000);

                entity.Property(e => e.HivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.KnownRiskFactorDescription).HasMaxLength(1000);

                entity.Property(e => e.OtherIdentificationSource).HasMaxLength(3000);

                entity.Property(e => e.OtherSourceDocument).HasMaxLength(3000);

                entity.Property(e => e.SourceDocumentExt).HasMaxLength(50);

                entity.Property(e => e.SourceDocumentUrl)
                    .HasMaxLength(3000)
                    .HasColumnName("SourceDocumentURL");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.Surname).HasMaxLength(3000);

                entity.Property(e => e.TelephoneContact).HasMaxLength(1000);

                entity.Property(e => e.VirallaodDate).HasColumnType("date");
            });

            modelBuilder.Entity<ViewDashboardBeneficiariesonIcare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardBeneficiariesonICARE");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.RiskFactorsDescription).HasMaxLength(3000);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewDashboardBeneficiariesonIcarenoFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardBeneficiariesonICARENoFilter");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.RiskFactorsDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewDashboardBeneficiariesonIcarepivot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardBeneficiariesonICAREPivot");

                entity.Property(e => e.Calhiv).HasColumnName("CALHIV");

                entity.Property(e => e.ChildofFsw).HasColumnName("ChildofFSW");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.Fsw).HasColumnName("FSW");

                entity.Property(e => e.Hei).HasColumnName("HEI");

                entity.Property(e => e.LivinginHhwithAdolescentMother).HasColumnName("LivinginHHwithAdolescentMother");

                entity.Property(e => e.LivinginHhwithFsw).HasColumnName("LivinginHHwithFSW");

                entity.Property(e => e.LivinginHhwithHei).HasColumnName("LivinginHHwithHEI");

                entity.Property(e => e.LivinginHhwithPlhiv).HasColumnName("LivinginHHwithPLHIV");

                entity.Property(e => e.LivinginHhwithSvac).HasColumnName("LivinginHHwithSVAC");

                entity.Property(e => e.Plhiv).HasColumnName("PLHIV");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.Svac).HasColumnName("SVAC");
            });

            modelBuilder.Entity<ViewDashboardBeneficiariesonIcarepivotNoFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardBeneficiariesonICAREPivotNoFilter");

                entity.Property(e => e.Calhiv).HasColumnName("CALHIV");

                entity.Property(e => e.ChildofFsw).HasColumnName("ChildofFSW");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.Fsw).HasColumnName("FSW");

                entity.Property(e => e.Hei).HasColumnName("HEI");

                entity.Property(e => e.LivinginHhwithAdolescentMother).HasColumnName("LivinginHHwithAdolescentMother");

                entity.Property(e => e.LivinginHhwithFsw).HasColumnName("LivinginHHwithFSW");

                entity.Property(e => e.LivinginHhwithHei).HasColumnName("LivinginHHwithHEI");

                entity.Property(e => e.LivinginHhwithPlhiv).HasColumnName("LivinginHHwithPLHIV");

                entity.Property(e => e.LivinginHhwithSvac).HasColumnName("LivinginHHwithSVAC");

                entity.Property(e => e.Plhiv).HasColumnName("PLHIV");

                entity.Property(e => e.Svac).HasColumnName("SVAC");
            });

            modelBuilder.Entity<ViewDashboardBeneficiaryIdentificationRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardBeneficiaryIdentificationRegister");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewDashboardGraduationBenchMark>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardGraduationBenchMark");

                entity.Property(e => e.AssessmentDate).HasColumnType("date");
            });

            modelBuilder.Entity<ViewDashboardHhvisitedCurrentQuarter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardHHVisitedCurrentQuarter");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewDashboardHivstatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardHIVStatus");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Givenname).HasMaxLength(3000);

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.Surname).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewDashboardHivtbrisKassessmentTool>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardHIVTBRisKAssessmentTool");

                entity.Property(e => e.ArtNumber)
                    .HasMaxLength(2000)
                    .HasColumnName("Art_Number");

                entity.Property(e => e.ChildHadContactWithActiveTbdiseaseAdult).HasColumnName("ChildHadContactWithActiveTBDiseaseAdult");

                entity.Property(e => e.ChildHivsymptomatic).HasColumnName("ChildHIVSymptomatic");

                entity.Property(e => e.ChildLivesWithHivpositiveMotherOrFather).HasColumnName("ChildLivesWithHIVPositiveMotherOrFather");

                entity.Property(e => e.ClientHasNewHepatitisBdiagnosis).HasColumnName("ClientHasNewHepatitisBDiagnosis");

                entity.Property(e => e.ClientHasPresumptiveActiveTbdisease).HasColumnName("ClientHasPresumptiveActiveTBDisease");

                entity.Property(e => e.ClientIsMaleOrFemaleWithnoHivtest).HasColumnName("ClientIsMaleOrFemaleWithnoHIVTest");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.HivnegativePartnerInDiscordantRelationship).HasColumnName("HIVNegativePartnerInDiscordantRelationship");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.ParishDescription).HasMaxLength(2000);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.TbriskAssessmentId).HasColumnName("TBRiskAssessmentId");

                entity.Property(e => e.VillageDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewDashboardHouseHoldNoVisits>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardHouseHoldNoVisits");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.Qtr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewDashboardOvcHiv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardOvcHiv");

                entity.Property(e => e.AgeBands)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AgeCategory)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Artnumber)
                    .HasMaxLength(3000)
                    .HasColumnName("ARTNumber");

                entity.Property(e => e.ClientAtTbinfectionRisk).HasColumnName("ClientAtTBInfectionRisk");

                entity.Property(e => e.ClientCareModalityIdOther).HasMaxLength(3000);

                entity.Property(e => e.ClientHasPresumptiveOrActiveTb).HasColumnName("ClientHasPresumptiveOrActiveTB");

                entity.Property(e => e.ClientMemberStatusOther).HasMaxLength(3000);

                entity.Property(e => e.ClientReceivedTbscreeningSession).HasColumnName("ClientReceivedTBScreeningSession");

                entity.Property(e => e.ClientRefferedTestedForTb).HasColumnName("ClientReffered_TestedForTB");

                entity.Property(e => e.CohortNo).HasColumnType("date");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.GenderDescription)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HivTbTrackingFormId).HasColumnName("HIV_TB_TrackingFormId");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.IsOnTbpreventiveTreatment).HasColumnName("IsOnTBPreventiveTreatment");

                entity.Property(e => e.IsOnTbtreatment).HasColumnName("IsOnTBTreatment");

                entity.Property(e => e.LastAppointmentDate).HasColumnType("date");

                entity.Property(e => e.LastViralloadTestDate).HasColumnType("date");

                entity.Property(e => e.NextAppointmentDate).HasColumnType("date");

                entity.Property(e => e.NextViralloadTestDate).HasColumnType("date");

                entity.Property(e => e.NonAdherenceId)
                    .HasMaxLength(3000)
                    .HasColumnName("Non_Adherence_Id");

                entity.Property(e => e.NonAdherenceOther)
                    .HasMaxLength(3000)
                    .HasColumnName("Non_Adherence_Other");

                entity.Property(e => e.NotSuppressingReasonId).HasMaxLength(1000);

                entity.Property(e => e.OnArt).HasColumnName("OnART");

                entity.Property(e => e.OtherNotSuppressingReason).HasMaxLength(3000);

                entity.Property(e => e.OtherPersonContacted).HasMaxLength(3000);

                entity.Property(e => e.OtherServiceProvided).HasMaxLength(3000);

                entity.Property(e => e.PhoneNumber).HasMaxLength(1000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.ReviewedContact).HasMaxLength(1000);

                entity.Property(e => e.ReviewedTitle).HasMaxLength(3000);

                entity.Property(e => e.ServiceProvidedId).HasMaxLength(1000);

                entity.Property(e => e.SocialWorkerContact).HasMaxLength(1000);

                entity.Property(e => e.SocialWorkerEntryDate).HasColumnType("date");

                entity.Property(e => e.SocialWorkerName).HasMaxLength(3000);

                entity.Property(e => e.SocialWorkerTitle).HasMaxLength(3000);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.TbtestResultId).HasColumnName("TBTestResultId");

                entity.Property(e => e.TbtreatmentDuration).HasColumnName("TBTreatmentDuration");

                entity.Property(e => e.TptTreatmentDuration).HasColumnName("TPT_Treatment_Duration");

                entity.Property(e => e.ViralloadTestResults).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewDashboardOvcHivHei>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardOvcHivHEI");

                entity.Property(e => e.ArtNumber)
                    .HasMaxLength(3000)
                    .HasColumnName("ART_Number");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.EidCascadeId).HasColumnName("EID_Cascade_Id");

                entity.Property(e => e.EidCascadeTransferred)
                    .HasMaxLength(3000)
                    .HasColumnName("EID_Cascade_Transferred");

                entity.Property(e => e.ExposedInfantsNo).HasMaxLength(3000);

                entity.Property(e => e.HivTbTrackingFormExposedInfantsId).HasColumnName("HIV_TB_TrackingFormExposedInfantsId");

                entity.Property(e => e.HivTbTrackingFormId).HasColumnName("HIV_TB_TrackingFormId");

                entity.Property(e => e.HivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.IsEnrolledOnArt).HasColumnName("IsEnrolledOnART");

                entity.Property(e => e.PcrTestId)
                    .HasMaxLength(1000)
                    .HasColumnName("PCR_Test_Id");

                entity.Property(e => e.PcrtestDesc)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PCRTestDesc");

                entity.Property(e => e.PmtctmotherProvidedWithTreatmentLiteracy).HasColumnName("PMTCTMotherProvidedWithTreatmentLiteracy");

                entity.Property(e => e.RegistrationDate).HasColumnType("date");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.SupportedToEnrollAndAdhereToPmtct).HasColumnName("SupportedToEnrollAndAdhereToPMTCT");
            });

            modelBuilder.Entity<ViewDashboardOvcHivStat2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardOvcHivStat2023");

                entity.Property(e => e.AgeCategory)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.HivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.VisitationDate).HasColumnType("date");
            });

            modelBuilder.Entity<ViewDashboardOvcServeIdentification>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardOvcServeIdentification");

                entity.Property(e => e.AddedBy).HasMaxLength(3000);

                entity.Property(e => e.AgeBands)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AgeCategory)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Artnumber)
                    .HasMaxLength(1000)
                    .HasColumnName("ARTNumber");

                entity.Property(e => e.Cohort).HasColumnType("date");

                entity.Property(e => e.Copies).HasMaxLength(1000);

                entity.Property(e => e.CurrentlyonArt).HasColumnName("CurrentlyonART");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.DateofIdentification).HasColumnType("date");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.GenderDescription)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GivenName).HasMaxLength(3000);

                entity.Property(e => e.HivstatusDescription)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.KnownRiskFactorDescription).HasMaxLength(1000);

                entity.Property(e => e.OtherIdentificationSource).HasMaxLength(3000);

                entity.Property(e => e.OtherSourceDocument).HasMaxLength(3000);

                entity.Property(e => e.OvcVlrId).HasColumnName("OVC_VLR_Id");

                entity.Property(e => e.ProgramParticipationDescription).HasMaxLength(3000);

                entity.Property(e => e.SourceDocumentExt).HasMaxLength(50);

                entity.Property(e => e.SourceDocumentUrl)
                    .HasMaxLength(3000)
                    .HasColumnName("SourceDocumentURL");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.Surname).HasMaxLength(3000);

                entity.Property(e => e.TelephoneContact).HasMaxLength(1000);

                entity.Property(e => e.ViralLoadSuppressedDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VirallaodDate).HasColumnType("date");

                entity.Property(e => e.VisitationDate).HasColumnType("date");
            });

            modelBuilder.Entity<ViewDashboardOvcServeSinovuyoSessions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardOvcServeSinovuyoSessions");

                entity.Property(e => e.AgeCategory)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.GenderDescription)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GroupSessionCount).HasColumnType("numeric(12, 1)");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewDashboardOvcServiceJourneysPlusSessions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardOvcServiceJourneysPlusSessions");

                entity.Property(e => e.AgeCategory)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CurriculumCalculation).HasColumnType("numeric(12, 1)");

                entity.Property(e => e.CurriculumId).HasColumnName("Curriculum_Id");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.GenderDescription)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");
            });

            modelBuilder.Entity<ViewDashboardOvcServiceReportingTool>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardOvcServiceReportingTool");

                entity.Property(e => e.AgeCategory)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.GenderDescription)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HomeVisitReasonId).HasMaxLength(1000);

                entity.Property(e => e.HomeVisitReasonOther).HasMaxLength(3000);

                entity.Property(e => e.HomeVisitorName).HasMaxLength(3000);

                entity.Property(e => e.HouseHoldMembersTalkedTo).HasMaxLength(1000);

                entity.Property(e => e.ProgramParticipationDescription).HasMaxLength(3000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewerName).HasMaxLength(3000);

                entity.Property(e => e.ReviewerTitle).HasMaxLength(3000);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.VisitationDate).HasColumnType("date");

                entity.Property(e => e.VisitorTitle).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewDashboardOvcServiceReportingToolDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardOvcServiceReportingToolDetail");

                entity.Property(e => e.AgeBands)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AgeCategory)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ChildProtectionServiceReceived)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.EconomicStabilityServiceReceived)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EducationReceived)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmergingNeedHealthy)
                    .HasMaxLength(1000)
                    .HasColumnName("Emerging_Need_Healthy");

                entity.Property(e => e.EmergingNeedSafe)
                    .HasMaxLength(1000)
                    .HasColumnName("Emerging_Need_Safe");

                entity.Property(e => e.EmergingNeedSchooled)
                    .HasMaxLength(1000)
                    .HasColumnName("Emerging_Need_Schooled");

                entity.Property(e => e.EmergingNeedStable)
                    .HasMaxLength(1000)
                    .HasColumnName("Emerging_Need_Stable");

                entity.Property(e => e.FoodSecurityNutritionReceived)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GapNeededHealthy)
                    .HasMaxLength(1000)
                    .HasColumnName("Gap_Needed_Healthy");

                entity.Property(e => e.GapNeededSafe)
                    .HasMaxLength(1000)
                    .HasColumnName("Gap_Needed_Safe");

                entity.Property(e => e.GapNeededSchooled)
                    .HasMaxLength(1000)
                    .HasColumnName("Gap_Needed_Schooled");

                entity.Property(e => e.GapNeededStable)
                    .HasMaxLength(1000)
                    .HasColumnName("Gap_Needed_Stable");

                entity.Property(e => e.GenderDescription)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HealthServiceReceived)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Healthy).HasMaxLength(1000);

                entity.Property(e => e.HealthyOther).HasMaxLength(3000);

                entity.Property(e => e.HivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.IssuesIdentified).HasColumnName("Issues_Identified");

                entity.Property(e => e.Pssreceived)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PSSReceived");

                entity.Property(e => e.Qtr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Safe).HasMaxLength(1000);

                entity.Property(e => e.SafeOther).HasMaxLength(3000);

                entity.Property(e => e.Schooled).HasMaxLength(1000);

                entity.Property(e => e.SchooledOther).HasMaxLength(3000);

                entity.Property(e => e.Stable).HasMaxLength(1000);

                entity.Property(e => e.StableOther).HasMaxLength(3000);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.UnmetNeedHealthy)
                    .HasMaxLength(1000)
                    .HasColumnName("Unmet_Need_Healthy");

                entity.Property(e => e.UnmetNeedSafe)
                    .HasMaxLength(1000)
                    .HasColumnName("Unmet_Need_Safe");

                entity.Property(e => e.UnmetNeedSchooled)
                    .HasMaxLength(1000)
                    .HasColumnName("Unmet_Need_Schooled");

                entity.Property(e => e.UnmetNeedStable)
                    .HasMaxLength(1000)
                    .HasColumnName("Unmet_Need_Stable");

                entity.Property(e => e.VisitationDate).HasColumnType("date");
            });

            modelBuilder.Entity<ViewDashboardOvcserveVsTarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardOVCServeVsTarget");

                entity.Property(e => e.AgeCategory)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AssessmentDate).HasColumnType("date");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.HivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.RowNum).HasColumnName("row_num");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.VisitationDate).HasColumnType("date");
            });

            modelBuilder.Entity<ViewDashboardRiskFactorBinding>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardRiskFactorBinding");

                entity.Property(e => e.KnownRiskFactorDescription).HasMaxLength(1000);

                entity.Property(e => e.RiskFactorsDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewDashboardStakeholderTargets>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardStakeholderTargets");

                entity.Property(e => e.CapturedBy).HasMaxLength(3000);

                entity.Property(e => e.DateCaptured).HasColumnType("datetime");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);

                entity.Property(e => e.IndicatorDescription).HasMaxLength(3000);

                entity.Property(e => e.QuarterName).HasMaxLength(2000);

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<ViewDashboardStakeholderTargetsOverrall>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardStakeholderTargetsOverrall");

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);

                entity.Property(e => e.IndicatorDescription).HasMaxLength(3000);

                entity.Property(e => e.QuarterName).HasMaxLength(2000);

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<ViewDashboardStakeholderTargetsPivoted>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardStakeholderTargetsPivoted");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);

                entity.Property(e => e.IndicatorDescription).HasMaxLength(3000);

                entity.Property(e => e.QuarterFour).HasColumnName("Quarter Four");

                entity.Property(e => e.QuarterOne).HasColumnName("Quarter One");

                entity.Property(e => e.QuarterThree).HasColumnName("Quarter Three");

                entity.Property(e => e.QuarterTwo).HasColumnName("Quarter Two");

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<ViewDashboardStakeholderTargetsPivotedOverrall>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardStakeholderTargetsPivotedOverrall");

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);

                entity.Property(e => e.IndicatorDescription).HasMaxLength(3000);

                entity.Property(e => e.QuarterFour).HasColumnName("Quarter Four");

                entity.Property(e => e.QuarterOne).HasColumnName("Quarter One");

                entity.Property(e => e.QuarterThree).HasColumnName("Quarter Three");

                entity.Property(e => e.QuarterTwo).HasColumnName("Quarter Two");

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<ViewDashboardTargetDatasource>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardTargetDatasource");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.OperatingDistrict).HasMaxLength(3000);

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<ViewDashboardTnrhivstatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DashboardTNRHIVStatus");

                entity.Property(e => e.AgeCategory)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.EnrollmentDate).HasColumnType("date");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewDashboardVleligible>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Dashboard_VLEligible");

                entity.Property(e => e.DateofOccurancy).HasColumnType("date");

                entity.Property(e => e.HivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.ServicesProvided).HasMaxLength(4000);

                entity.Property(e => e.SplitServicesProvided).HasColumnName("Split_ServicesProvided");
            });

            modelBuilder.Entity<ViewGroupCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GroupCode");

                entity.Property(e => e.GroupCode).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewGroupComposition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GroupComposition");

                entity.Property(e => e.GroupCode).HasMaxLength(2000);

                entity.Property(e => e.GroupCycleDesc).HasMaxLength(3000);

                entity.Property(e => e.GroupName).HasMaxLength(3000);

                entity.Property(e => e.GroupTypeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewGroups>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Groups");

                entity.Property(e => e.GroupCode).HasMaxLength(2000);

                entity.Property(e => e.GroupName).HasMaxLength(3000);

                entity.Property(e => e.GroupTypeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewHouseHoldMembers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_HouseHoldMembers");

                entity.Property(e => e.Artnumber)
                    .HasMaxLength(1000)
                    .HasColumnName("ARTNumber");

                entity.Property(e => e.Cohort).HasColumnType("date");

                entity.Property(e => e.CurrentlyonArt).HasColumnName("CurrentlyonART");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.GenderDescription).HasMaxLength(1000);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Givenname).HasMaxLength(3000);

                entity.Property(e => e.HivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.KnownRiskFactorDescription).HasMaxLength(1000);

                entity.Property(e => e.ProgramParticipationDescription).HasMaxLength(3000);

                entity.Property(e => e.Surname).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewIsCareGiver>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_IsCareGiver");

                entity.Property(e => e.Artnumber)
                    .HasMaxLength(1000)
                    .HasColumnName("ARTNumber");

                entity.Property(e => e.Cohort).HasColumnType("date");

                entity.Property(e => e.CurrentlyonArt).HasColumnName("CurrentlyonART");

                entity.Property(e => e.DisabilityDescription).HasMaxLength(3000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.EnrollmentDate).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Givenname).HasMaxLength(3000);

                entity.Property(e => e.HasanIga).HasColumnName("HasanIGA");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.NameofSchool).HasMaxLength(3000);

                entity.Property(e => e.Surname).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewLastHouseholdCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_LastHouseholdCode");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);
            });

            modelBuilder.Entity<ViewProjectIndicatorTargetsDatasource>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ProjectIndicatorTargetsDatasource");

                entity.Property(e => e.CapturedBy).HasMaxLength(3000);

                entity.Property(e => e.DateCaptured).HasColumnType("datetime");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);

                entity.Property(e => e.IndicatorDescription).HasMaxLength(3000);

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<ViewProjectIndicatorTargetsHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ProjectIndicatorTargetsHeader");

                entity.Property(e => e.CapturedBy).HasMaxLength(3000);

                entity.Property(e => e.DateCaptured).HasColumnType("datetime");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);

                entity.Property(e => e.IndicatorDescription).HasMaxLength(3000);

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<ViewReportProjectIndicatorTargetsDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ReportProjectIndicatorTargetsDetails");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);

                entity.Property(e => e.IndicatorDescription).HasMaxLength(3000);

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<ViewReportStakeHolderDataCapture>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ReportStakeHolderDataCapture");

                entity.Property(e => e.CapturedBy).HasMaxLength(3000);

                entity.Property(e => e.DateCaptured).HasColumnType("datetime");

                entity.Property(e => e.Denominator).HasMaxLength(3000);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);

                entity.Property(e => e.IndicatorDescription).HasMaxLength(3000);

                entity.Property(e => e.Numerator).HasMaxLength(3000);

                entity.Property(e => e.QuarterName).HasMaxLength(2000);

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<ViewReportVslaTrackingToolDirectMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Report_VSLA_Tracking_Tool_Direct_Member");

                entity.Property(e => e.BorrowedLf).HasColumnName("Borrowed_LF");

                entity.Property(e => e.BorrowedWf).HasColumnName("Borrowed_WF");

                entity.Property(e => e.LfReasonForBorrowingId).HasColumnName("LF_Reason_For_Borrowing_Id");

                entity.Property(e => e.RepaidLf).HasColumnName("Repaid_LF");

                entity.Property(e => e.RepaidWf).HasColumnName("Repaid_WF");

                entity.Property(e => e.SavedLf).HasColumnName("Saved_LF");

                entity.Property(e => e.SavedOf).HasColumnName("Saved_OF");

                entity.Property(e => e.SavedWf).HasColumnName("Saved_WF");

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.Property(e => e.WfReasonForBorrowingId).HasColumnName("WF_Reason_For_Borrowing_Id");
            });

            modelBuilder.Entity<ViewServiceRecieved>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewServiceRecieved");

                entity.Property(e => e.ServiceCategoryDesc).HasMaxLength(3000);

                entity.Property(e => e.ServiceClassiffication).HasMaxLength(3000);

                entity.Property(e => e.ServiceReceivedDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewSlrGraduationCheckList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SLR_GraduationCheckList");

                entity.Property(e => e.AssessmentDate).HasColumnType("date");

                entity.Property(e => e.Nacount).HasColumnName("NACount");
            });

            modelBuilder.Entity<ViewSlrHomeVisit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SLR_HomeVisit");

                entity.Property(e => e.VisitationDate).HasColumnType("date");
            });

            modelBuilder.Entity<ViewSmuAssessmentGuide>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SMU_Assessment_Guide");

                entity.Property(e => e.AgeGroup).HasMaxLength(1000);

                entity.Property(e => e.AssementGuideId).HasColumnName("Assement_Guide_Id");

                entity.Property(e => e.ClientContact)
                    .HasMaxLength(1000)
                    .HasColumnName("Client_Contact");

                entity.Property(e => e.ClientRegistrationId).HasColumnName("Client_RegistrationId");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.GenderDescription).HasMaxLength(1000);

                entity.Property(e => e.RegionDescription).HasMaxLength(100);

                entity.Property(e => e.RespondantAge).HasColumnName("Respondant_Age");

                entity.Property(e => e.RespondantGenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Respondant_GenderId")
                    .IsFixedLength(true);

                entity.Property(e => e.SmuClientName)
                    .HasMaxLength(1000)
                    .HasColumnName("SMU_Client_Name");

                entity.Property(e => e.SmuGroupId).HasColumnName("SMU_GroupId");

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewSplitDistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Split_District");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");

                entity.Property(e => e.SplitDistricts)
                    .HasMaxLength(3000)
                    .HasColumnName("Split_Districts");
            });

            modelBuilder.Entity<ViewStakeHolderDataCapture>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_StakeHolderDataCapture");

                entity.Property(e => e.CapturedBy).HasMaxLength(3000);

                entity.Property(e => e.DateCaptured).HasColumnType("datetime");

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.FinancialYearDesc).HasMaxLength(3000);

                entity.Property(e => e.IndicatorDescription).HasMaxLength(3000);

                entity.Property(e => e.QuarterName).HasMaxLength(2000);

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");
            });

            modelBuilder.Entity<ViewTbNonAdherence>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TB_NonAdherence");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<ViewTreatmentInterruptions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIew_Treatment_Interruptions");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<ViewUploadHivTbTrackingForm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Upload_HIV_TB_TrackingForm");

                entity.Property(e => e.Artnumber)
                    .HasMaxLength(3000)
                    .HasColumnName("ARTNumber");

                entity.Property(e => e.ClientAtTbinfectionRisk).HasColumnName("ClientAtTBInfectionRisk");

                entity.Property(e => e.ClientCareModalityIdOther).HasMaxLength(3000);

                entity.Property(e => e.ClientHasPresumptiveOrActiveTb).HasColumnName("ClientHasPresumptiveOrActiveTB");

                entity.Property(e => e.ClientMemberStatusOther).HasMaxLength(3000);

                entity.Property(e => e.ClientReceivedTbscreeningSession).HasColumnName("ClientReceivedTBScreeningSession");

                entity.Property(e => e.ClientRefferedTestedForTb).HasColumnName("ClientReffered_TestedForTB");

                entity.Property(e => e.Cohort).HasColumnType("date");

                entity.Property(e => e.CohortNo).HasColumnType("date");

                entity.Property(e => e.CurrentlyonArt).HasColumnName("CurrentlyonART");

                entity.Property(e => e.DisabilityDescription).HasMaxLength(3000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.EnrollmentDate).HasColumnType("date");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Givenname).HasMaxLength(3000);

                entity.Property(e => e.HasanIga).HasColumnName("HasanIGA");

                entity.Property(e => e.HivTbTrackingFormId).HasColumnName("HIV_TB_TrackingFormId");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.IsOnTbpreventiveTreatment).HasColumnName("IsOnTBPreventiveTreatment");

                entity.Property(e => e.IsOnTbtreatment).HasColumnName("IsOnTBTreatment");

                entity.Property(e => e.LastAppointmentDate).HasColumnType("date");

                entity.Property(e => e.LastViralloadTestDate).HasColumnType("date");

                entity.Property(e => e.NameofSchool).HasMaxLength(3000);

                entity.Property(e => e.NextAppointmentDate).HasColumnType("date");

                entity.Property(e => e.NextViralloadTestDate).HasColumnType("date");

                entity.Property(e => e.NonAdherenceId)
                    .HasMaxLength(3000)
                    .HasColumnName("Non_Adherence_Id");

                entity.Property(e => e.NonAdherenceOther)
                    .HasMaxLength(3000)
                    .HasColumnName("Non_Adherence_Other");

                entity.Property(e => e.NotSuppressingReasonId).HasMaxLength(1000);

                entity.Property(e => e.OnArt).HasColumnName("OnART");

                entity.Property(e => e.OtherNotSuppressingReason).HasMaxLength(3000);

                entity.Property(e => e.OtherPersonContacted).HasMaxLength(3000);

                entity.Property(e => e.OtherServiceProvided).HasMaxLength(3000);

                entity.Property(e => e.PhoneNumber).HasMaxLength(1000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.ReviewedContact).HasMaxLength(1000);

                entity.Property(e => e.ReviewedTitle).HasMaxLength(3000);

                entity.Property(e => e.ServiceProvidedId).HasMaxLength(1000);

                entity.Property(e => e.SocialWorkerContact).HasMaxLength(1000);

                entity.Property(e => e.SocialWorkerEntryDate).HasColumnType("date");

                entity.Property(e => e.SocialWorkerName).HasMaxLength(3000);

                entity.Property(e => e.SocialWorkerTitle).HasMaxLength(3000);

                entity.Property(e => e.Surname).HasMaxLength(3000);

                entity.Property(e => e.TbtestResultId).HasColumnName("TBTestResultId");

                entity.Property(e => e.TbtreatmentDuration).HasColumnName("TBTreatmentDuration");

                entity.Property(e => e.TptTreatmentDuration).HasColumnName("TPT_Treatment_Duration");

                entity.Property(e => e.ViralloadTestResults).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewUserManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewUserManagement");

                entity.Property(e => e.AccountHolderName).HasMaxLength(3000);

                entity.Property(e => e.DistrictDescription).HasMaxLength(4000);

                entity.Property(e => e.DistrictId).HasMaxLength(2000);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.NormalizedRoleName).HasMaxLength(256);

                entity.Property(e => e.RoleId).HasMaxLength(450);

                entity.Property(e => e.RoleName).HasMaxLength(256);

                entity.Property(e => e.ServiceProviderDesc)
                    .HasMaxLength(3000)
                    .HasColumnName("Service_Provider_Desc");

                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_Id");

                entity.Property(e => e.SubCountyId).HasMaxLength(2000);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(4000);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<ViewVlrVlcVlsDashboard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VLR_VLC_VLS_Dashboard");

                entity.Property(e => e.AgeCategory)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictDescription).HasMaxLength(2000);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.FollowUpDate).HasColumnType("date");

                entity.Property(e => e.HivTbTrackingFormId).HasColumnName("HIV_TB_TrackingFormId");

                entity.Property(e => e.Qtr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubcountyDescription).HasMaxLength(2000);

                entity.Property(e => e.ViralLoadDescription).HasMaxLength(50);

                entity.Property(e => e.ViralLoadSuppressedDescription).HasMaxLength(50);

                entity.Property(e => e.ViralloadTestResults).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViewVslaGroupDirectMembers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VSLA_Group_Direct_Members");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.GenderDescription).HasMaxLength(1000);

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Givenname).HasMaxLength(3000);

                entity.Property(e => e.GroupCode).HasMaxLength(2000);

                entity.Property(e => e.HivstatusDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("HIVStatusDescription");

                entity.Property(e => e.HivstatusId).HasColumnName("HIVStatusId");

                entity.Property(e => e.HouseHoldCode).HasMaxLength(1000);

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(3000);

                entity.Property(e => e.KnownRiskFactorDescription).HasMaxLength(1000);

                entity.Property(e => e.Surname).HasMaxLength(3000);

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");
            });

            modelBuilder.Entity<ViewVslaGroupIndirectMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VSLA_Group_Indirect_Member");

                entity.Property(e => e.Cbtcode)
                    .HasMaxLength(2000)
                    .HasColumnName("CBTCode");

                entity.Property(e => e.CheckedBy).HasMaxLength(3000);

                entity.Property(e => e.CheckerPosition).HasMaxLength(3000);

                entity.Property(e => e.DateChecked).HasColumnType("date");

                entity.Property(e => e.DateofVerification).HasColumnType("date");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GroupCode).HasMaxLength(2000);

                entity.Property(e => e.IndirectMemberCode).HasMaxLength(2000);

                entity.Property(e => e.MeetingDate).HasColumnType("date");

                entity.Property(e => e.MeetingTime).HasColumnType("datetime");

                entity.Property(e => e.MeetingVenue).HasMaxLength(3000);

                entity.Property(e => e.MemberName).HasMaxLength(3000);

                entity.Property(e => e.OfficerIncharge).HasMaxLength(3000);

                entity.Property(e => e.PhoneNumber).HasMaxLength(3000);

                entity.Property(e => e.VerifiedBy).HasMaxLength(3000);

                entity.Property(e => e.VerifierPosition).HasMaxLength(3000);

                entity.Property(e => e.VslaGroupIndirectMemberId).HasColumnName("VSLA_Group_Indirect_Member_Id");
            });

            modelBuilder.Entity<ViewVslaTrackingToolDirectMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VSLA_Tracking_Tool_Direct_Member");

                entity.Property(e => e.BorrowedLf).HasColumnName("Borrowed_LF");

                entity.Property(e => e.BorrowedWf).HasColumnName("Borrowed_WF");

                entity.Property(e => e.LfReasonForBorrowingId).HasColumnName("LF_Reason_For_Borrowing_Id");

                entity.Property(e => e.PhoneNumber).HasMaxLength(2000);

                entity.Property(e => e.RepaidLf).HasColumnName("Repaid_LF");

                entity.Property(e => e.RepaidWf).HasColumnName("Repaid_WF");

                entity.Property(e => e.SavedLf).HasColumnName("Saved_LF");

                entity.Property(e => e.SavedOf).HasColumnName("Saved_OF");

                entity.Property(e => e.SavedWf).HasColumnName("Saved_WF");

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.Property(e => e.VslatrackingToolDirectMemberId).HasColumnName("VSLATrackingToolDirectMemberId");

                entity.Property(e => e.WfReasonForBorrowingId).HasColumnName("WF_Reason_For_Borrowing_Id");
            });

            modelBuilder.Entity<VillageMoved>(entity =>
            {
                entity.HasKey(e => e.VillageId);

                entity.ToTable("Village_Moved");

                entity.Property(e => e.VillageId).ValueGeneratedNever();

                entity.Property(e => e.VillageDescription).HasMaxLength(2000);
            });

            modelBuilder.Entity<ViralLoadUpload1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ViralLoadUpload_1");

                entity.Property(e => e.AnyoneelsecontactedId).HasColumnName("anyoneelsecontactedID");

                entity.Property(e => e.ArtCohort)
                    .HasColumnType("datetime")
                    .HasColumnName("ART Cohort");

                entity.Property(e => e.ArtNo).HasColumnName("ART No#");

                entity.Property(e => e.ClientArtRegimen)
                    .HasMaxLength(255)
                    .HasColumnName("Client ART Regimen");

                entity.Property(e => e.ClientIsAtRiskOfTbInfection)
                    .HasMaxLength(255)
                    .HasColumnName("Client is at risk of TB infection#");

                entity.Property(e => e.ClientLineOfTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("Client Line of Treatment");

                entity.Property(e => e.ClientMemberStatusOnArt)
                    .HasMaxLength(255)
                    .HasColumnName("Client Member Status on ART");

                entity.Property(e => e.ClientReferredAndTestedForTb)
                    .HasMaxLength(255)
                    .HasColumnName("Client Referred and Tested for TB: ");

                entity.Property(e => e.ClientTbTestResults)
                    .HasMaxLength(255)
                    .HasColumnName("Client TB test Results:");

                entity.Property(e => e.ClientsClassification)
                    .HasMaxLength(255)
                    .HasColumnName("Clients Classification ");

                entity.Property(e => e.ClientsuccessfullycontactedId).HasColumnName("clientsuccessfullycontactedID");

                entity.Property(e => e.DataEnteredBy)
                    .HasMaxLength(255)
                    .HasColumnName("Data entered By");

                entity.Property(e => e.DateOfFollowUp)
                    .HasColumnType("datetime")
                    .HasColumnName("Date of Follow up");

                entity.Property(e => e.DateWhenLastVlTestWasDone)
                    .HasColumnType("datetime")
                    .HasColumnName("Date when last VL test was done");

                entity.Property(e => e.DateWhenNextVlWillBeDne)
                    .HasColumnType("datetime")
                    .HasColumnName("Date when next VL will be dne");

                entity.Property(e => e.DoesTheClientHaveAPresumptiveOrActiveTbDisease)
                    .HasMaxLength(255)
                    .HasColumnName("Does the client have a presumptive or active TB Disease?");

                entity.Property(e => e.DurationOnTbTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("Duration on TB Treatment");

                entity.Property(e => e.DurationOnTptTreatment).HasColumnName("Duration on TPT Treatment");

                entity.Property(e => e.DurationOnTreatmentInMonths).HasColumnName("Duration On Treatment (In months");

                entity.Property(e => e.HasTheClientReceivedATbScreeningSession)
                    .HasMaxLength(255)
                    .HasColumnName("Has the Client received a TB Screening Session?");

                entity.Property(e => e.HhUiD)
                    .HasMaxLength(255)
                    .HasColumnName("HH UiD");

                entity.Property(e => e.HivStatusAfterFollowUp)
                    .HasMaxLength(255)
                    .HasColumnName("HIV Status after Follow Up");

                entity.Property(e => e.IfClientReturnedANegativeResultOnTbPreventiveTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("If Client returned a Negative Result, on TB Preventive Treatment");

                entity.Property(e => e.IfClientReturnedAPositiveResultOnTbTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("If Client returned a Positive Result, on TB Treatment?");

                entity.Property(e => e.IfHivOnArt)
                    .HasMaxLength(255)
                    .HasColumnName("If HIV+, on ART?");

                entity.Property(e => e.IfYesToOthersSpecifyReasonHere)
                    .HasMaxLength(255)
                    .HasColumnName("If Yes to Others, Specify Reason Here");

                entity.Property(e => e.IfYesWhoWasContactedAFamilyMemberBTreatmentSuppo)
                    .HasMaxLength(255)
                    .HasColumnName("If Yes, Who was contacted? (a) Family member (b) Treatment suppo");

                entity.Property(e => e.IndividualUiD)
                    .HasMaxLength(255)
                    .HasColumnName("Individual UiD");

                entity.Property(e => e.IsClientEligibleForViralLoad)
                    .HasMaxLength(255)
                    .HasColumnName("Is Client Eligible for Viral Load");

                entity.Property(e => e.LastArtAppointmnetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Last ART Appointmnet Date");

                entity.Property(e => e.MeansOfFollowUp)
                    .HasMaxLength(255)
                    .HasColumnName("Means of Follow up");

                entity.Property(e => e.ModalityOfCareAndTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("Modality of care and treatment");

                entity.Property(e => e.ModalityOfDrugDispensing)
                    .HasMaxLength(255)
                    .HasColumnName("Modality of Drug Dispensing");

                entity.Property(e => e.NameOfSocialWorker)
                    .HasMaxLength(255)
                    .HasColumnName("Name Of Social Worker");

                entity.Property(e => e.NextArtAppointmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Next ART Appointment Date");

                entity.Property(e => e.ReviewDate)
                    .HasMaxLength(255)
                    .HasColumnName("Review Date");

                entity.Property(e => e.ReviewedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Reviewed By");

                entity.Property(e => e.SocialWorkerTel)
                    .HasMaxLength(255)
                    .HasColumnName("Social Worker Tel#");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Title1)
                    .HasMaxLength(255)
                    .HasColumnName(" Title");

                entity.Property(e => e.ViralLoadResults)
                    .HasMaxLength(255)
                    .HasColumnName("Viral Load Results");

                entity.Property(e => e.ViralLoadTestCopiesMl)
                    .HasMaxLength(255)
                    .HasColumnName("Viral load test Copies/ML");

                entity.Property(e => e.ViralLoadTestDoneId).HasColumnName("ViralLoadTestDoneID");

                entity.Property(e => e.ViralLoadtestresultsreceivedId).HasColumnName("ViralLoadtestresultsreceivedID");

                entity.Property(e => e.WeightInKgs).HasColumnName("Weight in Kgs");

                entity.Property(e => e._10ADrugResistance)
                    .HasMaxLength(255)
                    .HasColumnName("10# A) Drug Resistance");

                entity.Property(e => e._10B10Depression).HasColumnName("10# (B-10) Depression");

                entity.Property(e => e._10B11SubstanceAbuse).HasColumnName("10#(B-11) Substance Abuse  ");

                entity.Property(e => e._10B12Gbv).HasColumnName("10# (B-12) GBV");

                entity.Property(e => e._10B13OthersSpecify).HasColumnName("10# (B-13) Others: Specify; ");

                entity.Property(e => e._10B1PillBurdenTreatmentFatigue).HasColumnName("10# B-1) Pill Burden/Treatment Fatigue");

                entity.Property(e => e._10B2LackOfFood).HasColumnName("10# (B-2) Lack of food");

                entity.Property(e => e._10B3SideEffects).HasColumnName("10# (B-3) Side effects");

                entity.Property(e => e._10B4ForgetToTake).HasColumnName("10# (B-4) Forget to take");

                entity.Property(e => e._10B5NonDisclosureOfStatus).HasColumnName("10# (B-5) Non-disclosure of status ");

                entity.Property(e => e._10B6StigmaAndDiscrimination).HasColumnName("10# (B-6) Stigma and discrimination ");

                entity.Property(e => e._10B7LowSelfEsteem).HasColumnName("10# (B-7) Low self-esteem    ");

                entity.Property(e => e._10B8PovertyLackOfBasicResources).HasColumnName("10# (B-8) Poverty/lack of basic resources");

                entity.Property(e => e._10B9PeerPressure).HasColumnName("10# (B-9) Peer pressure ");

                entity.Property(e => e._11NextActionToBeTakenBySocialWorkerBasedOnCarePlan)
                    .HasMaxLength(255)
                    .HasColumnName("11# Next Action to be taken by social worker (based on care plan");

                entity.Property(e => e._9aIntensiveAdherenceCounselingIac)
                    .HasMaxLength(255)
                    .HasColumnName("9a) Intensive Adherence Counseling (IAC)");

                entity.Property(e => e._9bLinkageToArtServices)
                    .HasMaxLength(255)
                    .HasColumnName("9b) Linkage to ART services");

                entity.Property(e => e._9cLinkageToPeerSupportGroupsForYoungPositives)
                    .HasMaxLength(255)
                    .HasColumnName("9c) Linkage to Peer Support Groups for Young Positives");

                entity.Property(e => e._9dNutritionEducationAndSupport)
                    .HasMaxLength(255)
                    .HasColumnName("9d) Nutrition Education and Support");

                entity.Property(e => e._9eCompletedReferralForServicesIncludingCareAndTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("9e) Completed Referral for services including care and treatment");

                entity.Property(e => e._9fTransportFacilitation)
                    .HasMaxLength(255)
                    .HasColumnName("9f) Transport Facilitation");

                entity.Property(e => e._9gTemporaryConsumptionSupport)
                    .HasMaxLength(255)
                    .HasColumnName("9g) Temporary consumption support");

                entity.Property(e => e._9hPsychosocialSupport)
                    .HasMaxLength(255)
                    .HasColumnName("9h) Psychosocial Support");

                entity.Property(e => e._9iSupportedToReceiveViralLoadTest)
                    .HasMaxLength(255)
                    .HasColumnName("9i) Supported to receive Viral load test");
            });

            modelBuilder.Entity<ViralLoadUpload3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ViralLoadUpload_3");

                entity.Property(e => e.AnyoneelsecontactedId).HasColumnName("anyoneelsecontactedID");

                entity.Property(e => e.ArtCohort)
                    .HasColumnType("datetime")
                    .HasColumnName("ART Cohort");

                entity.Property(e => e.ArtNo).HasColumnName("ART No#");

                entity.Property(e => e.ClientArtRegimen)
                    .HasMaxLength(255)
                    .HasColumnName("Client ART Regimen");

                entity.Property(e => e.ClientIsAtRiskOfTbInfection)
                    .HasMaxLength(255)
                    .HasColumnName("Client is at risk of TB infection#");

                entity.Property(e => e.ClientLineOfTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("Client Line of Treatment");

                entity.Property(e => e.ClientMemberStatusOnArt)
                    .HasMaxLength(255)
                    .HasColumnName("Client Member Status on ART");

                entity.Property(e => e.ClientReferredAndTestedForTb)
                    .HasMaxLength(255)
                    .HasColumnName("Client Referred and Tested for TB: ");

                entity.Property(e => e.ClientTbTestResults)
                    .HasMaxLength(255)
                    .HasColumnName("Client TB test Results:");

                entity.Property(e => e.ClientsClassification)
                    .HasMaxLength(255)
                    .HasColumnName("Clients Classification ");

                entity.Property(e => e.ClientsuccessfullycontactedId).HasColumnName("clientsuccessfullycontactedID");

                entity.Property(e => e.DataEnteredBy)
                    .HasMaxLength(255)
                    .HasColumnName("Data entered By");

                entity.Property(e => e.DateOfFollowUp)
                    .HasColumnType("datetime")
                    .HasColumnName("Date of Follow up");

                entity.Property(e => e.DateWhenLastVlTestWasDone)
                    .HasColumnType("datetime")
                    .HasColumnName("Date when last VL test was done");

                entity.Property(e => e.DateWhenNextVlWillBeDne)
                    .HasColumnType("datetime")
                    .HasColumnName("Date when next VL will be dne");

                entity.Property(e => e.DoesTheClientHaveAPresumptiveOrActiveTbDisease)
                    .HasMaxLength(255)
                    .HasColumnName("Does the client have a presumptive or active TB Disease?");

                entity.Property(e => e.DurationOnTbTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("Duration on TB Treatment");

                entity.Property(e => e.DurationOnTptTreatment).HasColumnName("Duration on TPT Treatment");

                entity.Property(e => e.DurationOnTreatmentInMonths).HasColumnName("Duration On Treatment (In months");

                entity.Property(e => e.HasTheClientReceivedATbScreeningSession)
                    .HasMaxLength(255)
                    .HasColumnName("Has the Client received a TB Screening Session?");

                entity.Property(e => e.HhUiD)
                    .HasMaxLength(255)
                    .HasColumnName("HH UiD");

                entity.Property(e => e.HivStatusAfterFollowUp)
                    .HasMaxLength(255)
                    .HasColumnName("HIV Status after Follow Up");

                entity.Property(e => e.IfClientReturnedANegativeResultOnTbPreventiveTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("If Client returned a Negative Result, on TB Preventive Treatment");

                entity.Property(e => e.IfClientReturnedAPositiveResultOnTbTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("If Client returned a Positive Result, on TB Treatment?");

                entity.Property(e => e.IfHivOnArt)
                    .HasMaxLength(255)
                    .HasColumnName("If HIV+, on ART?");

                entity.Property(e => e.IfYesToOthersSpecifyReasonHere)
                    .HasMaxLength(255)
                    .HasColumnName("If Yes to Others, Specify Reason Here");

                entity.Property(e => e.IfYesWhoWasContactedAFamilyMemberBTreatmentSuppo)
                    .HasMaxLength(255)
                    .HasColumnName("If Yes, Who was contacted? (a) Family member (b) Treatment suppo");

                entity.Property(e => e.IndividualUiD)
                    .HasMaxLength(255)
                    .HasColumnName("Individual UiD");

                entity.Property(e => e.IsClientEligibleForViralLoad)
                    .HasMaxLength(255)
                    .HasColumnName("Is Client Eligible for Viral Load");

                entity.Property(e => e.LastArtAppointmnetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Last ART Appointmnet Date");

                entity.Property(e => e.MeansOfFollowUp)
                    .HasMaxLength(255)
                    .HasColumnName("Means of Follow up");

                entity.Property(e => e.ModalityOfCareAndTreatment)
                    .HasMaxLength(255)
                    .HasColumnName("Modality of care and treatment");

                entity.Property(e => e.ModalityOfDrugDispensing)
                    .HasMaxLength(255)
                    .HasColumnName("Modality of Drug Dispensing");

                entity.Property(e => e.NameOfSocialWorker)
                    .HasMaxLength(255)
                    .HasColumnName("Name Of Social Worker");

                entity.Property(e => e.NextArtAppointmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Next ART Appointment Date");

                entity.Property(e => e.NonAdheranceReason)
                    .HasMaxLength(403)
                    .IsUnicode(false)
                    .HasColumnName("Non_Adherance_Reason");

                entity.Property(e => e.NotSuppressingReason).HasMaxLength(257);

                entity.Property(e => e.ReviewDate)
                    .HasMaxLength(255)
                    .HasColumnName("Review Date");

                entity.Property(e => e.ReviewedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Reviewed By");

                entity.Property(e => e.Servicesprovided)
                    .HasMaxLength(2047)
                    .HasColumnName("SERVICESPROVIDED");

                entity.Property(e => e.SocialWorkerTel)
                    .HasMaxLength(255)
                    .HasColumnName("Social Worker Tel#");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Title1)
                    .HasMaxLength(255)
                    .HasColumnName(" Title");

                entity.Property(e => e.ViralLoadResults)
                    .HasMaxLength(255)
                    .HasColumnName("Viral Load Results");

                entity.Property(e => e.ViralLoadTestCopiesMl)
                    .HasMaxLength(255)
                    .HasColumnName("Viral load test Copies/ML");

                entity.Property(e => e.ViralLoadTestDoneId).HasColumnName("ViralLoadTestDoneID");

                entity.Property(e => e.ViralLoadtestresultsreceivedId).HasColumnName("ViralLoadtestresultsreceivedID");

                entity.Property(e => e.WeightInKgs).HasColumnName("Weight in Kgs");

                entity.Property(e => e._11NextActionToBeTakenBySocialWorkerBasedOnCarePlan)
                    .HasMaxLength(255)
                    .HasColumnName("11# Next Action to be taken by social worker (based on care plan");
            });

            modelBuilder.Entity<VslaGroupCommittee>(entity =>
            {
                entity.ToTable("VSLA_Group_Committee");

                entity.Property(e => e.VslagroupCommitteeId)
                    .ValueGeneratedNever()
                    .HasColumnName("VSLAGroup_Committee_Id");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GroupPositionId).HasColumnName("Group_Position_Id");

                entity.Property(e => e.MemberName).HasMaxLength(3000);

                entity.Property(e => e.PhoneNumber).HasMaxLength(1000);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.VslaGroupCommittee)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_VSLA_Group_Committee_A_Gender");

                entity.HasOne(d => d.GroupCompositionCodeNavigation)
                    .WithMany(p => p.VslaGroupCommittee)
                    .HasForeignKey(d => d.GroupCompositionCode)
                    .HasConstraintName("FK_VSLA_Group_Committee_VSLA_Group_Composition");

                entity.HasOne(d => d.GroupPosition)
                    .WithMany(p => p.VslaGroupCommittee)
                    .HasForeignKey(d => d.GroupPositionId)
                    .HasConstraintName("FK_VSLA_Group_Committee_A_Group_Position");
            });

            modelBuilder.Entity<VslaGroupComposition>(entity =>
            {
                entity.HasKey(e => e.GroupCompositionCode);

                entity.ToTable("VSLA_Group_Composition");

                entity.Property(e => e.GroupCompositionCode).ValueGeneratedNever();

                entity.Property(e => e.Cbtcode)
                    .HasMaxLength(2000)
                    .HasColumnName("CBTCode");

                entity.Property(e => e.CheckedBy).HasMaxLength(3000);

                entity.Property(e => e.CheckerPosition).HasMaxLength(3000);

                entity.Property(e => e.DateChecked).HasColumnType("date");

                entity.Property(e => e.DateofVerification).HasColumnType("date");

                entity.Property(e => e.GroupCode).HasMaxLength(2000);

                entity.Property(e => e.MeetingDate).HasColumnType("date");

                entity.Property(e => e.MeetingTime).HasColumnType("datetime");

                entity.Property(e => e.MeetingVenue).HasMaxLength(3000);

                entity.Property(e => e.OfficerIncharge).HasMaxLength(3000);

                entity.Property(e => e.VerifiedBy).HasMaxLength(3000);

                entity.Property(e => e.VerifierPosition).HasMaxLength(3000);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.VslaGroupComposition)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_VSLA_Group_Composition_A_District");

                entity.HasOne(d => d.GroupCycle)
                    .WithMany(p => p.VslaGroupComposition)
                    .HasForeignKey(d => d.GroupCycleId)
                    .HasConstraintName("FK_VSLA_Group_Composition_A_GroupCycle");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.VslaGroupComposition)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_VSLA_Group_Composition_A_Groups");

                entity.HasOne(d => d.GroupType)
                    .WithMany(p => p.VslaGroupComposition)
                    .HasForeignKey(d => d.GroupTypeId)
                    .HasConstraintName("FK_VSLA_Group_Composition_A_GroupType");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.VslaGroupComposition)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_VSLA_Group_Composition_A_Parish");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.VslaGroupComposition)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_VSLA_Group_Composition_A_Subcounty");
            });

            modelBuilder.Entity<VslaGroupDirectMembers>(entity =>
            {
                entity.HasKey(e => e.VslaGroupDirectMemberId);

                entity.ToTable("VSLA_Group_Direct_Members");

                entity.Property(e => e.VslaGroupDirectMemberId)
                    .ValueGeneratedNever()
                    .HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.Property(e => e.PhoneNumber).HasMaxLength(2000);

                entity.HasOne(d => d.GroupCompositionCodeNavigation)
                    .WithMany(p => p.VslaGroupDirectMembers)
                    .HasForeignKey(d => d.GroupCompositionCode)
                    .HasConstraintName("FK_VSLA_Group_Direct_Members_VSLA_Group_Composition");

                entity.HasOne(d => d.HouseHoldMember)
                    .WithMany(p => p.VslaGroupDirectMembers)
                    .HasForeignKey(d => d.HouseHoldMemberId)
                    .HasConstraintName("FK_VSLA_Group_Direct_Members_HouseHoldMembers");
            });

            modelBuilder.Entity<VslaGroupIndirectMember>(entity =>
            {
                entity.ToTable("VSLA_Group_Indirect_Member");

                entity.Property(e => e.VslaGroupIndirectMemberId)
                    .ValueGeneratedNever()
                    .HasColumnName("VSLA_Group_Indirect_Member_Id");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IndirectMemberCode).HasMaxLength(2000);

                entity.Property(e => e.MemberName).HasMaxLength(3000);

                entity.Property(e => e.PhoneNumber).HasMaxLength(3000);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.VslaGroupIndirectMember)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_VSLA_Group_Indirect_Member_A_Gender");

                entity.HasOne(d => d.GroupCompositionCodeNavigation)
                    .WithMany(p => p.VslaGroupIndirectMember)
                    .HasForeignKey(d => d.GroupCompositionCode)
                    .HasConstraintName("FK_VSLA_Group_Indirect_Member_VSLA_Group_Composition");

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.VslaGroupIndirectMember)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_VSLA_Group_Indirect_Member_A_Parish");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.VslaGroupIndirectMember)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("FK_VSLA_Group_Indirect_Member_A_Village");
            });

            modelBuilder.Entity<VslaGroupShareOutDirectMember>(entity =>
            {
                entity.HasKey(e => e.VslashareOutDirectMemberId);

                entity.ToTable("VSLA_Group_ShareOut_Direct_Member");

                entity.Property(e => e.VslashareOutDirectMemberId)
                    .ValueGeneratedNever()
                    .HasColumnName("VSLAShareOutDirectMemberId");

                entity.Property(e => e.ActualAmountShared).HasColumnName("Actual_amount_shared");

                entity.Property(e => e.CalculatedAmountToBeSharedOut).HasColumnName("Calculated_amount_to_be_shared_out");

                entity.Property(e => e.NewShareValue).HasColumnName("New_share_Value");

                entity.Property(e => e.TotalNumberOfSharesBought).HasColumnName("Total_number_of_shares_bought");

                entity.Property(e => e.TotalSaving).HasColumnName("Total_Saving");

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.Property(e => e.VslashareOutHeaderId).HasColumnName("VSLAShareOutHeaderId");

                entity.HasOne(d => d.VslaGroupDirectMember)
                    .WithMany(p => p.VslaGroupShareOutDirectMember)
                    .HasForeignKey(d => d.VslaGroupDirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VSLA_Group_ShareOut_Direct_Member_HouseHoldMembers");

                entity.HasOne(d => d.VslashareOutHeader)
                    .WithMany(p => p.VslaGroupShareOutDirectMember)
                    .HasForeignKey(d => d.VslashareOutHeaderId)
                    .HasConstraintName("FK_VSLA_Group_ShareOut_Direct_Member_VSLA_Group_ShareOut_Header");
            });

            modelBuilder.Entity<VslaGroupShareOutHeader>(entity =>
            {
                entity.HasKey(e => e.VslashareOutHeaderId);

                entity.ToTable("VSLA_Group_ShareOut_Header");

                entity.Property(e => e.VslashareOutHeaderId)
                    .ValueGeneratedNever()
                    .HasColumnName("VSLAShareOutHeaderId");

                entity.Property(e => e.Cbtname)
                    .HasMaxLength(3000)
                    .HasColumnName("CBTName");

                entity.Property(e => e.ChairPersonName).HasMaxLength(3000);

                entity.Property(e => e.ChairPersonTele).HasMaxLength(1000);

                entity.Property(e => e.CycleSavingStartDate).HasColumnType("date");

                entity.Property(e => e.GroupCode).HasMaxLength(2000);

                entity.Property(e => e.SecretaryName).HasMaxLength(3000);

                entity.Property(e => e.SecretaryTele).HasMaxLength(1000);

                entity.Property(e => e.ShareOutDate).HasColumnType("date");

                entity.Property(e => e.TotalCashAvailableToBeShared).HasColumnName("Total_cash_available_to_be_shared");

                entity.Property(e => e.TreasurerName).HasMaxLength(3000);

                entity.Property(e => e.TreasurerTele).HasMaxLength(1000);

                entity.Property(e => e.WriteOfThisCycle).HasMaxLength(3000);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.VslaGroupShareOutHeader)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_VSLA_Group_ShareOut_Header_A_District");

                entity.HasOne(d => d.GroupCompositionCodeNavigation)
                    .WithMany(p => p.VslaGroupShareOutHeader)
                    .HasForeignKey(d => d.GroupCompositionCode)
                    .HasConstraintName("FK_VSLA_Group_ShareOut_Header_VSLA_Group_Composition");

                entity.HasOne(d => d.GroupCycle)
                    .WithMany(p => p.VslaGroupShareOutHeader)
                    .HasForeignKey(d => d.GroupCycleId)
                    .HasConstraintName("FK_VSLA_Group_ShareOut_Header_A_GroupCycle");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.VslaGroupShareOutHeader)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_VSLA_Group_ShareOut_Header_A_Groups");

                entity.HasOne(d => d.Subcounty)
                    .WithMany(p => p.VslaGroupShareOutHeader)
                    .HasForeignKey(d => d.SubcountyId)
                    .HasConstraintName("FK_VSLA_Group_ShareOut_Header_A_Subcounty");
            });

            modelBuilder.Entity<VslaGroupShareOutIndirectMember>(entity =>
            {
                entity.HasKey(e => e.VslashareOutInDirectMemberId);

                entity.ToTable("VSLA_Group_ShareOut_Indirect_Member");

                entity.Property(e => e.VslashareOutInDirectMemberId)
                    .ValueGeneratedNever()
                    .HasColumnName("VSLAShareOutInDirectMemberId");

                entity.Property(e => e.ActualAmountShared).HasColumnName("Actual_amount_shared");

                entity.Property(e => e.CalculatedAmountToBeSharedOut).HasColumnName("Calculated_amount_to_be_shared_out");

                entity.Property(e => e.NewShareValue).HasColumnName("New_share_Value");

                entity.Property(e => e.TotalNumberOfSharesBought).HasColumnName("Total_number_of_shares_bought");

                entity.Property(e => e.TotalSaving).HasColumnName("Total_Saving");

                entity.Property(e => e.VslaGroupIndirectMemberId).HasColumnName("VSLA_Group_Indirect_Member_Id");

                entity.Property(e => e.VslashareOutHeaderId).HasColumnName("VSLAShareOutHeaderId");

                entity.HasOne(d => d.VslaGroupIndirectMember)
                    .WithMany(p => p.VslaGroupShareOutIndirectMember)
                    .HasForeignKey(d => d.VslaGroupIndirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VSLA_Group_ShareOut_Indirect_Member_VSLA_Group_Indirect_Member");

                entity.HasOne(d => d.VslashareOutHeader)
                    .WithMany(p => p.VslaGroupShareOutIndirectMember)
                    .HasForeignKey(d => d.VslashareOutHeaderId)
                    .HasConstraintName("FK_VSLA_Group_ShareOut_Indirect_Member_VSLA_Group_ShareOut_Header");
            });

            modelBuilder.Entity<VslaTrackingTool>(entity =>
            {
                entity.HasKey(e => e.TrackingToolId)
                    .HasName("PK_VSLA_TRacking_Tool");

                entity.ToTable("VSLA_Tracking_Tool");

                entity.Property(e => e.TrackingToolId).ValueGeneratedNever();

                entity.Property(e => e.AmountSavingDepositedToFfi).HasColumnName("Amount_Saving_Deposited_To_FFI");

                entity.Property(e => e.CashBalanceInOvcFund).HasColumnName("Cash_Balance_In_Ovc_Fund");

                entity.Property(e => e.CashInWelfareFund).HasColumnName("Cash_In_welfare_Fund");

                entity.Property(e => e.CollectedBy).HasMaxLength(3000);

                entity.Property(e => e.CollectedDeignation).HasMaxLength(3000);

                entity.Property(e => e.CollectionDate).HasColumnType("date");

                entity.Property(e => e.CummValueOfPropertyNow).HasColumnName("Cumm_Value_of_Property_Now");

                entity.Property(e => e.CummValueOfSavingsThisCycle).HasColumnName("Cumm_Value_of_Savings_this_Cycle");

                entity.Property(e => e.CumulativeNoOvcAccessingTcs).HasColumnName("Cumulative_No_OVC_Accessing_TCS");

                entity.Property(e => e.CycleSavingStartDate)
                    .HasColumnType("date")
                    .HasColumnName("Cycle_Saving_Start_Date");

                entity.Property(e => e.GroupCode).HasMaxLength(2000);

                entity.Property(e => e.GroupFoundation).HasColumnType("date");

                entity.Property(e => e.LinkageToExternalCredit).HasColumnName("Linkage_To_External_Credit");

                entity.Property(e => e.LoanCashInBoxBank).HasColumnName("Loan_Cash_In_Box_Bank");

                entity.Property(e => e.NameLinkageToExternalCredit)
                    .HasMaxLength(3000)
                    .HasColumnName("Name_Linkage_To_External_Credit");

                entity.Property(e => e.NameLinkageToExternalSaving).HasMaxLength(3000);

                entity.Property(e => e.NoMemberAttendingMeeting).HasColumnName("No_Member_attending_Meeting");

                entity.Property(e => e.NoMembersAtStartOfCycle).HasColumnName("No_Members_At_Start_of_Cycle");

                entity.Property(e => e.NoOfBensTrainedFl).HasColumnName("No_of_Bens_Trained_FL");

                entity.Property(e => e.NoOfBensTrainedSpm).HasColumnName("No_of_Bens_Trained_SPM");

                entity.Property(e => e.NoOfMembersRunningIgas).HasColumnName("No_of_members_running_IGAs");

                entity.Property(e => e.NoOfOutstandingLoan).HasColumnName("No_Of_Outstanding_Loan");

                entity.Property(e => e.ReportingMonth).HasMaxLength(2000);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ReviewDesignation).HasMaxLength(3000);

                entity.Property(e => e.ReviewedBy).HasMaxLength(3000);

                entity.Property(e => e.TotalCumulativeCashPayoutOvcFund).HasColumnName("Total_Cumulative_cash_payout_OVC_Fund");

                entity.Property(e => e.UnpaidBalanceOfLateLoan).HasColumnName("Unpaid_Balance_Of_Late_Loan");

                entity.Property(e => e.ValeOfOutstandingLoansAtFfi).HasColumnName("Vale_of_Outstanding_Loans_at_FFI");

                entity.Property(e => e.ValueOfLoanOutStanding).HasColumnName("Value_of_loan_outStanding");

                entity.Property(e => e.VslaGroupTrainerId).HasColumnName("VSLA_Group_Trainer_Id");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.VslaTrackingTool)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_A_District");

                entity.HasOne(d => d.GroupCompositionCodeNavigation)
                    .WithMany(p => p.VslaTrackingTool)
                    .HasForeignKey(d => d.GroupCompositionCode)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_VSLA_Group_Composition");

                entity.HasOne(d => d.GroupCycle)
                    .WithMany(p => p.VslaTrackingTool)
                    .HasForeignKey(d => d.GroupCycleId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_A_GroupCycle");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.VslaTrackingTool)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_A_Groups");

                entity.HasOne(d => d.ImplementingPartner)
                    .WithMany(p => p.VslaTrackingTool)
                    .HasForeignKey(d => d.ImplementingPartnerId)
                    .HasConstraintName("FK_VSLA_TRacking_Tool_A_ImplementingPartner");

                entity.HasOne(d => d.LinkageToExternalCreditNavigation)
                    .WithMany(p => p.VslaTrackingToolLinkageToExternalCreditNavigation)
                    .HasForeignKey(d => d.LinkageToExternalCredit)
                    .HasConstraintName("FK_VSLA_TRacking_Tool_A_YesNo1");

                entity.HasOne(d => d.LinkageToExternalSavingNavigation)
                    .WithMany(p => p.VslaTrackingToolLinkageToExternalSavingNavigation)
                    .HasForeignKey(d => d.LinkageToExternalSaving)
                    .HasConstraintName("FK_VSLA_TRacking_Tool_A_YesNo");

                entity.HasOne(d => d.VslaGroupTrainer)
                    .WithMany(p => p.VslaTrackingTool)
                    .HasForeignKey(d => d.VslaGroupTrainerId)
                    .HasConstraintName("FK_VSLA_TRacking_Tool_A_VSLA_Group_Trainer");
            });

            modelBuilder.Entity<VslaTrackingToolDirectMember>(entity =>
            {
                entity.ToTable("VSLA_Tracking_Tool_Direct_Member");

                entity.Property(e => e.VslatrackingToolDirectMemberId)
                    .ValueGeneratedNever()
                    .HasColumnName("VSLATrackingToolDirectMemberId");

                entity.Property(e => e.BorrowedLf).HasColumnName("Borrowed_LF");

                entity.Property(e => e.BorrowedWf).HasColumnName("Borrowed_WF");

                entity.Property(e => e.LfReasonForBorrowingId).HasColumnName("LF_Reason_For_Borrowing_Id");

                entity.Property(e => e.RepaidLf).HasColumnName("Repaid_LF");

                entity.Property(e => e.RepaidWf).HasColumnName("Repaid_WF");

                entity.Property(e => e.SavedLf).HasColumnName("Saved_LF");

                entity.Property(e => e.SavedOf).HasColumnName("Saved_OF");

                entity.Property(e => e.SavedWf).HasColumnName("Saved_WF");

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.Property(e => e.WfReasonForBorrowingId).HasColumnName("WF_Reason_For_Borrowing_Id");

                entity.HasOne(d => d.LfReasonForBorrowing)
                    .WithMany(p => p.VslaTrackingToolDirectMemberLfReasonForBorrowing)
                    .HasForeignKey(d => d.LfReasonForBorrowingId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_Direct_Member_A_Reason_For_Borrowing_Loan1");

                entity.HasOne(d => d.MemberStaus)
                    .WithMany(p => p.VslaTrackingToolDirectMember)
                    .HasForeignKey(d => d.MemberStausId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_Direct_Member_A_Group_Member_Status");

                entity.HasOne(d => d.Month)
                    .WithMany(p => p.VslaTrackingToolDirectMember)
                    .HasForeignKey(d => d.MonthId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_Direct_Member_A_Month");

                entity.HasOne(d => d.TrackingTool)
                    .WithMany(p => p.VslaTrackingToolDirectMember)
                    .HasForeignKey(d => d.TrackingToolId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_Detail_VSLA_Tracking_Tool");

                entity.HasOne(d => d.VslaGroupDirectMember)
                    .WithMany(p => p.VslaTrackingToolDirectMember)
                    .HasForeignKey(d => d.VslaGroupDirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_Direct_Member_HouseHoldMembers");

                entity.HasOne(d => d.WfReasonForBorrowing)
                    .WithMany(p => p.VslaTrackingToolDirectMemberWfReasonForBorrowing)
                    .HasForeignKey(d => d.WfReasonForBorrowingId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_Direct_Member_A_Reason_For_Borrowing_Loan");
            });

            modelBuilder.Entity<VslaTrackingToolInDirectMember>(entity =>
            {
                entity.ToTable("VSLA_Tracking_Tool_InDirect_Member");

                entity.Property(e => e.VslatrackingToolInDirectMemberId)
                    .ValueGeneratedNever()
                    .HasColumnName("VSLATrackingToolInDirectMemberId");

                entity.Property(e => e.BorrowedLf).HasColumnName("Borrowed_LF");

                entity.Property(e => e.BorrowedWf).HasColumnName("Borrowed_WF");

                entity.Property(e => e.LfReasonForBorrowingId).HasColumnName("LF_Reason_For_Borrowing_Id");

                entity.Property(e => e.RepaidLf).HasColumnName("Repaid_LF");

                entity.Property(e => e.RepaidWf).HasColumnName("Repaid_WF");

                entity.Property(e => e.SavedLf).HasColumnName("Saved_LF");

                entity.Property(e => e.SavedOf).HasColumnName("Saved_OF");

                entity.Property(e => e.SavedWf).HasColumnName("Saved_WF");

                entity.Property(e => e.VslaGroupIndirectMemberId).HasColumnName("VSLA_Group_Indirect_Member_Id");

                entity.Property(e => e.WfReasonForBorrowingId).HasColumnName("WF_Reason_For_Borrowing_Id");

                entity.HasOne(d => d.LfReasonForBorrowing)
                    .WithMany(p => p.VslaTrackingToolInDirectMemberLfReasonForBorrowing)
                    .HasForeignKey(d => d.LfReasonForBorrowingId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_InDirect_Member_A_Reason_For_Borrowing_Loan");

                entity.HasOne(d => d.MemberStaus)
                    .WithMany(p => p.VslaTrackingToolInDirectMember)
                    .HasForeignKey(d => d.MemberStausId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_InDirect_Member_A_Group_Member_Status");

                entity.HasOne(d => d.Month)
                    .WithMany(p => p.VslaTrackingToolInDirectMember)
                    .HasForeignKey(d => d.MonthId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_InDirect_Member_A_Month");

                entity.HasOne(d => d.TrackingTool)
                    .WithMany(p => p.VslaTrackingToolInDirectMember)
                    .HasForeignKey(d => d.TrackingToolId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_InDirect_Member_VSLA_Tracking_Tool");

                entity.HasOne(d => d.VslaGroupIndirectMember)
                    .WithMany(p => p.VslaTrackingToolInDirectMember)
                    .HasForeignKey(d => d.VslaGroupIndirectMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_InDirect_Member_VSLA_Group_Indirect_Member");

                entity.HasOne(d => d.WfReasonForBorrowing)
                    .WithMany(p => p.VslaTrackingToolInDirectMemberWfReasonForBorrowing)
                    .HasForeignKey(d => d.WfReasonForBorrowingId)
                    .HasConstraintName("FK_VSLA_Tracking_Tool_InDirect_Member_A_NotSuppressingReason");
            });

            modelBuilder.Entity<Vslagroups2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VSLAGroups_2");

                entity.Property(e => e.Age).HasColumnName("Age  ");

                entity.Property(e => e.CheckedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Checked by");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(2106)
                    .HasColumnName("Group Code");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .HasColumnName("Group Name");

                entity.Property(e => e.HhIndividualCode)
                    .HasMaxLength(255)
                    .HasColumnName("HH individual Code");

                entity.Property(e => e.MeetingTime)
                    .HasMaxLength(255)
                    .HasColumnName("Meeting Time");

                entity.Property(e => e.MeetingVenue)
                    .HasMaxLength(255)
                    .HasColumnName("Meeting Venue");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("Name ");

                entity.Property(e => e.SexMF)
                    .HasMaxLength(255)
                    .HasColumnName("Sex M/F ");

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.VerifiedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Verified by");

                entity.Property(e => e.Village)
                    .HasMaxLength(255)
                    .HasColumnName("Village ");
            });

            modelBuilder.Entity<VslatrackerDirect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VSLATrackerDirect");

                entity.Property(e => e.AmountSavingDepositedToFfi)
                    .HasMaxLength(255)
                    .HasColumnName("Amount_Saving_Deposited_To_FFI");

                entity.Property(e => e.BorrowedLf).HasColumnName("Borrowed_LF");

                entity.Property(e => e.BorrowedWf)
                    .HasMaxLength(255)
                    .HasColumnName("Borrowed_WF");

                entity.Property(e => e.CashBalanceInOvcFund)
                    .HasMaxLength(255)
                    .HasColumnName("Cash_Balance_In_Ovc_Fund");

                entity.Property(e => e.CashInWelfareFund)
                    .HasMaxLength(255)
                    .HasColumnName("Cash_In_welfare_Fund");

                entity.Property(e => e.CollectedBy).HasMaxLength(255);

                entity.Property(e => e.CollectedDeignation).HasMaxLength(255);

                entity.Property(e => e.CollectionDate).HasMaxLength(255);

                entity.Property(e => e.CummValueOfPropertyNow)
                    .HasMaxLength(255)
                    .HasColumnName("Cumm_Value_of_Property_Now");

                entity.Property(e => e.CummValueOfSavingsThisCycle)
                    .HasMaxLength(255)
                    .HasColumnName("Cumm_Value_of_Savings_this_Cycle");

                entity.Property(e => e.CumulativeNoOvcAccessingTcs)
                    .HasMaxLength(255)
                    .HasColumnName("Cumulative_No_OVC_Accessing_TCS");

                entity.Property(e => e.CycleSavingStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cycle_Saving_Start_Date");

                entity.Property(e => e.GroupCode).HasMaxLength(255);

                entity.Property(e => e.GroupFoundation).HasColumnType("datetime");

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(255);

                entity.Property(e => e.LfReasonForBorrowingId)
                    .HasMaxLength(255)
                    .HasColumnName("LF_Reason_For_Borrowing_Id");

                entity.Property(e => e.LinkageToExternalCredit)
                    .HasMaxLength(255)
                    .HasColumnName("Linkage_To_External_Credit");

                entity.Property(e => e.LinkageToExternalSaving).HasMaxLength(255);

                entity.Property(e => e.LoanCashInBoxBank)
                    .HasMaxLength(255)
                    .HasColumnName("Loan_Cash_In_Box_Bank");

                entity.Property(e => e.MemberStausId).HasMaxLength(255);

                entity.Property(e => e.NameLinkageToExternalCredit)
                    .HasMaxLength(255)
                    .HasColumnName("Name_Linkage_To_External_Credit");

                entity.Property(e => e.NameLinkageToExternalSaving).HasMaxLength(255);

                entity.Property(e => e.NoMemberAttendingMeeting)
                    .HasMaxLength(255)
                    .HasColumnName("No_Member_attending_Meeting");

                entity.Property(e => e.NoMembersAtStartOfCycle)
                    .HasMaxLength(255)
                    .HasColumnName("No_Members_At_Start_of_Cycle");

                entity.Property(e => e.NoOfBensTrainedFl)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_Bens_Trained_FL");

                entity.Property(e => e.NoOfBensTrainedSpm)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_Bens_Trained_SPM");

                entity.Property(e => e.NoOfMembersRunningIgas)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_members_running_IGAs");

                entity.Property(e => e.NoOfOutstandingLoan)
                    .HasMaxLength(255)
                    .HasColumnName("No_Of_Outstanding_Loan");

                entity.Property(e => e.ParishId).HasMaxLength(255);

                entity.Property(e => e.RepaidLf)
                    .HasMaxLength(255)
                    .HasColumnName("Repaid_LF");

                entity.Property(e => e.RepaidWf)
                    .HasMaxLength(255)
                    .HasColumnName("Repaid_WF");

                entity.Property(e => e.ReportingMonth).HasMaxLength(255);

                entity.Property(e => e.ReviewDate).HasMaxLength(255);

                entity.Property(e => e.ReviewDesignation).HasMaxLength(255);

                entity.Property(e => e.ReviewedBy).HasMaxLength(255);

                entity.Property(e => e.SavedLf).HasColumnName("Saved_LF");

                entity.Property(e => e.SavedOf).HasColumnName("Saved_OF");

                entity.Property(e => e.SavedWf).HasColumnName("Saved_WF");

                entity.Property(e => e.TotalCumulativeCashPayoutOvcFund)
                    .HasMaxLength(255)
                    .HasColumnName("Total_Cumulative_cash_payout_OVC_Fund");

                entity.Property(e => e.UnpaidBalanceOfLateLoan)
                    .HasMaxLength(255)
                    .HasColumnName("Unpaid_Balance_Of_Late_Loan");

                entity.Property(e => e.ValeOfOutstandingLoansAtFfi)
                    .HasMaxLength(255)
                    .HasColumnName("Vale_of_Outstanding_Loans_at_FFI");

                entity.Property(e => e.ValueOfLoanOutStanding)
                    .HasMaxLength(255)
                    .HasColumnName("Value_of_loan_outStanding");

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.Property(e => e.VslaGroupTrainerId)
                    .HasMaxLength(255)
                    .HasColumnName("VSLA_Group_Trainer_Id");

                entity.Property(e => e.VslatrackingToolDirectMemberId).HasColumnName("VSLATrackingToolDirectMemberId");

                entity.Property(e => e.WfReasonForBorrowingId)
                    .HasMaxLength(255)
                    .HasColumnName("WF_Reason_For_Borrowing_Id");
            });

            modelBuilder.Entity<VslatrackerDirect1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VSLATrackerDirect_1");

                entity.Property(e => e.AmountSavingDepositedToFfi)
                    .HasMaxLength(255)
                    .HasColumnName("Amount_Saving_Deposited_To_FFI");

                entity.Property(e => e.BorrowedLf).HasColumnName("Borrowed_LF");

                entity.Property(e => e.BorrowedWf)
                    .HasMaxLength(255)
                    .HasColumnName("Borrowed_WF");

                entity.Property(e => e.CashBalanceInOvcFund)
                    .HasMaxLength(255)
                    .HasColumnName("Cash_Balance_In_Ovc_Fund");

                entity.Property(e => e.CashInWelfareFund)
                    .HasMaxLength(255)
                    .HasColumnName("Cash_In_welfare_Fund");

                entity.Property(e => e.CollectedBy).HasMaxLength(255);

                entity.Property(e => e.CollectedDeignation).HasMaxLength(255);

                entity.Property(e => e.CollectionDate).HasMaxLength(255);

                entity.Property(e => e.CummValueOfPropertyNow)
                    .HasMaxLength(255)
                    .HasColumnName("Cumm_Value_of_Property_Now");

                entity.Property(e => e.CummValueOfSavingsThisCycle)
                    .HasMaxLength(255)
                    .HasColumnName("Cumm_Value_of_Savings_this_Cycle");

                entity.Property(e => e.CumulativeNoOvcAccessingTcs)
                    .HasMaxLength(255)
                    .HasColumnName("Cumulative_No_OVC_Accessing_TCS");

                entity.Property(e => e.CycleSavingStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cycle_Saving_Start_Date");

                entity.Property(e => e.GroupCode).HasMaxLength(255);

                entity.Property(e => e.GroupFoundation).HasColumnType("datetime");

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(255);

                entity.Property(e => e.LfReasonForBorrowingId)
                    .HasMaxLength(255)
                    .HasColumnName("LF_Reason_For_Borrowing_Id");

                entity.Property(e => e.LinkageToExternalCredit)
                    .HasMaxLength(255)
                    .HasColumnName("Linkage_To_External_Credit");

                entity.Property(e => e.LinkageToExternalSaving).HasMaxLength(255);

                entity.Property(e => e.LoanCashInBoxBank)
                    .HasMaxLength(255)
                    .HasColumnName("Loan_Cash_In_Box_Bank");

                entity.Property(e => e.MemberStausId).HasMaxLength(255);

                entity.Property(e => e.NameLinkageToExternalCredit)
                    .HasMaxLength(255)
                    .HasColumnName("Name_Linkage_To_External_Credit");

                entity.Property(e => e.NameLinkageToExternalSaving).HasMaxLength(255);

                entity.Property(e => e.NoMemberAttendingMeeting)
                    .HasMaxLength(255)
                    .HasColumnName("No_Member_attending_Meeting");

                entity.Property(e => e.NoMembersAtStartOfCycle)
                    .HasMaxLength(255)
                    .HasColumnName("No_Members_At_Start_of_Cycle");

                entity.Property(e => e.NoOfBensTrainedFl)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_Bens_Trained_FL");

                entity.Property(e => e.NoOfBensTrainedSpm)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_Bens_Trained_SPM");

                entity.Property(e => e.NoOfMembersRunningIgas)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_members_running_IGAs");

                entity.Property(e => e.NoOfOutstandingLoan)
                    .HasMaxLength(255)
                    .HasColumnName("No_Of_Outstanding_Loan");

                entity.Property(e => e.ParishId).HasMaxLength(255);

                entity.Property(e => e.RepaidLf)
                    .HasMaxLength(255)
                    .HasColumnName("Repaid_LF");

                entity.Property(e => e.RepaidWf)
                    .HasMaxLength(255)
                    .HasColumnName("Repaid_WF");

                entity.Property(e => e.ReportingMonth).HasMaxLength(255);

                entity.Property(e => e.ReviewDate).HasMaxLength(255);

                entity.Property(e => e.ReviewDesignation).HasMaxLength(255);

                entity.Property(e => e.ReviewedBy).HasMaxLength(255);

                entity.Property(e => e.SavedLf).HasColumnName("Saved_LF");

                entity.Property(e => e.SavedOf).HasColumnName("Saved_OF");

                entity.Property(e => e.SavedWf).HasColumnName("Saved_WF");

                entity.Property(e => e.TotalCumulativeCashPayoutOvcFund)
                    .HasMaxLength(255)
                    .HasColumnName("Total_Cumulative_cash_payout_OVC_Fund");

                entity.Property(e => e.UnpaidBalanceOfLateLoan)
                    .HasMaxLength(255)
                    .HasColumnName("Unpaid_Balance_Of_Late_Loan");

                entity.Property(e => e.ValeOfOutstandingLoansAtFfi)
                    .HasMaxLength(255)
                    .HasColumnName("Vale_of_Outstanding_Loans_at_FFI");

                entity.Property(e => e.ValueOfLoanOutStanding)
                    .HasMaxLength(255)
                    .HasColumnName("Value_of_loan_outStanding");

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.Property(e => e.VslaGroupTrainerId)
                    .HasMaxLength(255)
                    .HasColumnName("VSLA_Group_Trainer_Id");

                entity.Property(e => e.VslatrackingToolDirectMemberId).HasColumnName("VSLATrackingToolDirectMemberId");

                entity.Property(e => e.WfReasonForBorrowingId)
                    .HasMaxLength(255)
                    .HasColumnName("WF_Reason_For_Borrowing_Id");
            });

            modelBuilder.Entity<VslatrackerDirect2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VSLATrackerDirect_2");

                entity.Property(e => e.AmountSavingDepositedToFfi)
                    .HasMaxLength(255)
                    .HasColumnName("Amount_Saving_Deposited_To_FFI");

                entity.Property(e => e.BorrowedLf).HasColumnName("Borrowed_LF");

                entity.Property(e => e.BorrowedWf)
                    .HasMaxLength(255)
                    .HasColumnName("Borrowed_WF");

                entity.Property(e => e.CashBalanceInOvcFund)
                    .HasMaxLength(255)
                    .HasColumnName("Cash_Balance_In_Ovc_Fund");

                entity.Property(e => e.CashInWelfareFund)
                    .HasMaxLength(255)
                    .HasColumnName("Cash_In_welfare_Fund");

                entity.Property(e => e.CollectedBy).HasMaxLength(255);

                entity.Property(e => e.CollectedDeignation).HasMaxLength(255);

                entity.Property(e => e.CollectionDate).HasMaxLength(255);

                entity.Property(e => e.CummValueOfPropertyNow)
                    .HasMaxLength(255)
                    .HasColumnName("Cumm_Value_of_Property_Now");

                entity.Property(e => e.CummValueOfSavingsThisCycle)
                    .HasMaxLength(255)
                    .HasColumnName("Cumm_Value_of_Savings_this_Cycle");

                entity.Property(e => e.CumulativeNoOvcAccessingTcs)
                    .HasMaxLength(255)
                    .HasColumnName("Cumulative_No_OVC_Accessing_TCS");

                entity.Property(e => e.CycleSavingStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cycle_Saving_Start_Date");

                entity.Property(e => e.GroupCode).HasMaxLength(2000);

                entity.Property(e => e.GroupFoundation).HasColumnType("datetime");

                entity.Property(e => e.HouseHoldMemberCode).HasMaxLength(255);

                entity.Property(e => e.LfReasonForBorrowingId)
                    .HasMaxLength(255)
                    .HasColumnName("LF_Reason_For_Borrowing_Id");

                entity.Property(e => e.LinkageToExternalCredit)
                    .HasMaxLength(255)
                    .HasColumnName("Linkage_To_External_Credit");

                entity.Property(e => e.LinkageToExternalSaving).HasMaxLength(255);

                entity.Property(e => e.LoanCashInBoxBank)
                    .HasMaxLength(255)
                    .HasColumnName("Loan_Cash_In_Box_Bank");

                entity.Property(e => e.MemberStausId).HasMaxLength(255);

                entity.Property(e => e.NameLinkageToExternalCredit)
                    .HasMaxLength(255)
                    .HasColumnName("Name_Linkage_To_External_Credit");

                entity.Property(e => e.NameLinkageToExternalSaving).HasMaxLength(255);

                entity.Property(e => e.NoMemberAttendingMeeting)
                    .HasMaxLength(255)
                    .HasColumnName("No_Member_attending_Meeting");

                entity.Property(e => e.NoMembersAtStartOfCycle)
                    .HasMaxLength(255)
                    .HasColumnName("No_Members_At_Start_of_Cycle");

                entity.Property(e => e.NoOfBensTrainedFl)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_Bens_Trained_FL");

                entity.Property(e => e.NoOfBensTrainedSpm)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_Bens_Trained_SPM");

                entity.Property(e => e.NoOfMembersRunningIgas)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_members_running_IGAs");

                entity.Property(e => e.NoOfOutstandingLoan)
                    .HasMaxLength(255)
                    .HasColumnName("No_Of_Outstanding_Loan");

                entity.Property(e => e.ParishId).HasMaxLength(255);

                entity.Property(e => e.RepaidLf)
                    .HasMaxLength(255)
                    .HasColumnName("Repaid_LF");

                entity.Property(e => e.RepaidWf)
                    .HasMaxLength(255)
                    .HasColumnName("Repaid_WF");

                entity.Property(e => e.ReportingMonth).HasMaxLength(255);

                entity.Property(e => e.ReviewDate).HasMaxLength(255);

                entity.Property(e => e.ReviewDesignation).HasMaxLength(255);

                entity.Property(e => e.ReviewedBy).HasMaxLength(255);

                entity.Property(e => e.SavedLf).HasColumnName("Saved_LF");

                entity.Property(e => e.SavedOf).HasColumnName("Saved_OF");

                entity.Property(e => e.SavedWf).HasColumnName("Saved_WF");

                entity.Property(e => e.TotalCumulativeCashPayoutOvcFund)
                    .HasMaxLength(255)
                    .HasColumnName("Total_Cumulative_cash_payout_OVC_Fund");

                entity.Property(e => e.UnpaidBalanceOfLateLoan)
                    .HasMaxLength(255)
                    .HasColumnName("Unpaid_Balance_Of_Late_Loan");

                entity.Property(e => e.ValeOfOutstandingLoansAtFfi)
                    .HasMaxLength(255)
                    .HasColumnName("Vale_of_Outstanding_Loans_at_FFI");

                entity.Property(e => e.ValueOfLoanOutStanding)
                    .HasMaxLength(255)
                    .HasColumnName("Value_of_loan_outStanding");

                entity.Property(e => e.VslaGroupDirectMemberId).HasColumnName("VSLA_Group_Direct_Member_Id");

                entity.Property(e => e.VslaGroupTrainerId)
                    .HasMaxLength(255)
                    .HasColumnName("VSLA_Group_Trainer_Id");

                entity.Property(e => e.VslatrackingToolDirectMemberId).HasColumnName("VSLATrackingToolDirectMemberId");

                entity.Property(e => e.WfReasonForBorrowingId)
                    .HasMaxLength(255)
                    .HasColumnName("WF_Reason_For_Borrowing_Id");
            });

            modelBuilder.Entity<VslatrackerIndirect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VSLATrackerIndirect");

                entity.Property(e => e.AmountSavingDepositedToFfi)
                    .HasMaxLength(255)
                    .HasColumnName("Amount_Saving_Deposited_To_FFI");

                entity.Property(e => e.BorrowedLf).HasColumnName("Borrowed_LF");

                entity.Property(e => e.BorrowedWf)
                    .HasMaxLength(255)
                    .HasColumnName("Borrowed_WF");

                entity.Property(e => e.CashBalanceInOvcFund)
                    .HasMaxLength(255)
                    .HasColumnName("Cash_Balance_In_Ovc_Fund");

                entity.Property(e => e.CashInWelfareFund)
                    .HasMaxLength(255)
                    .HasColumnName("Cash_In_welfare_Fund");

                entity.Property(e => e.CollectedBy).HasMaxLength(255);

                entity.Property(e => e.CollectedDeignation).HasMaxLength(255);

                entity.Property(e => e.CollectionDate).HasMaxLength(255);

                entity.Property(e => e.CummValueOfPropertyNow)
                    .HasMaxLength(255)
                    .HasColumnName("Cumm_Value_of_Property_Now");

                entity.Property(e => e.CummValueOfSavingsThisCycle)
                    .HasMaxLength(255)
                    .HasColumnName("Cumm_Value_of_Savings_this_Cycle");

                entity.Property(e => e.CumulativeNoOvcAccessingTcs)
                    .HasMaxLength(255)
                    .HasColumnName("Cumulative_No_OVC_Accessing_TCS");

                entity.Property(e => e.CycleSavingStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cycle_Saving_Start_Date");

                entity.Property(e => e.GroupCode).HasMaxLength(255);

                entity.Property(e => e.GroupFoundation).HasColumnType("datetime");

                entity.Property(e => e.IndirectMemberCode).HasMaxLength(255);

                entity.Property(e => e.LfReasonForBorrowingId)
                    .HasMaxLength(255)
                    .HasColumnName("LF_Reason_For_Borrowing_Id");

                entity.Property(e => e.LinkageToExternalCredit)
                    .HasMaxLength(255)
                    .HasColumnName("Linkage_To_External_Credit");

                entity.Property(e => e.LinkageToExternalSaving).HasMaxLength(255);

                entity.Property(e => e.LoanCashInBoxBank)
                    .HasMaxLength(255)
                    .HasColumnName("Loan_Cash_In_Box_Bank");

                entity.Property(e => e.MemberName).HasMaxLength(255);

                entity.Property(e => e.MemberStausId).HasMaxLength(255);

                entity.Property(e => e.NameLinkageToExternalCredit)
                    .HasMaxLength(255)
                    .HasColumnName("Name_Linkage_To_External_Credit");

                entity.Property(e => e.NameLinkageToExternalSaving).HasMaxLength(255);

                entity.Property(e => e.NoMemberAttendingMeeting)
                    .HasMaxLength(255)
                    .HasColumnName("No_Member_attending_Meeting");

                entity.Property(e => e.NoMembersAtStartOfCycle)
                    .HasMaxLength(255)
                    .HasColumnName("No_Members_At_Start_of_Cycle");

                entity.Property(e => e.NoOfBensTrainedFl)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_Bens_Trained_FL");

                entity.Property(e => e.NoOfBensTrainedSpm)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_Bens_Trained_SPM");

                entity.Property(e => e.NoOfMembersRunningIgas)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_members_running_IGAs");

                entity.Property(e => e.NoOfOutstandingLoan)
                    .HasMaxLength(255)
                    .HasColumnName("No_Of_Outstanding_Loan");

                entity.Property(e => e.ParishId).HasMaxLength(255);

                entity.Property(e => e.RepaidLf)
                    .HasMaxLength(255)
                    .HasColumnName("Repaid_LF");

                entity.Property(e => e.RepaidWf)
                    .HasMaxLength(255)
                    .HasColumnName("Repaid_WF");

                entity.Property(e => e.ReportingMonth).HasMaxLength(255);

                entity.Property(e => e.ReviewDate).HasMaxLength(255);

                entity.Property(e => e.ReviewDesignation).HasMaxLength(255);

                entity.Property(e => e.ReviewedBy).HasMaxLength(255);

                entity.Property(e => e.SavedLf).HasColumnName("Saved_LF");

                entity.Property(e => e.SavedOf).HasColumnName("Saved_OF");

                entity.Property(e => e.SavedWf).HasColumnName("Saved_WF");

                entity.Property(e => e.TotalCumulativeCashPayoutOvcFund)
                    .HasMaxLength(255)
                    .HasColumnName("Total_Cumulative_cash_payout_OVC_Fund");

                entity.Property(e => e.UnpaidBalanceOfLateLoan)
                    .HasMaxLength(255)
                    .HasColumnName("Unpaid_Balance_Of_Late_Loan");

                entity.Property(e => e.ValeOfOutstandingLoansAtFfi)
                    .HasMaxLength(255)
                    .HasColumnName("Vale_of_Outstanding_Loans_at_FFI");

                entity.Property(e => e.ValueOfLoanOutStanding)
                    .HasMaxLength(255)
                    .HasColumnName("Value_of_loan_outStanding");

                entity.Property(e => e.VslaGroupIndirectMemberId).HasColumnName("VSLA_Group_Indirect_Member_Id");

                entity.Property(e => e.VslaGroupTrainerId)
                    .HasMaxLength(255)
                    .HasColumnName("VSLA_Group_Trainer_Id");

                entity.Property(e => e.VslatrackingToolInDirectMemberId).HasColumnName("VSLATrackingToolInDirectMemberId");

                entity.Property(e => e.WfReasonForBorrowingId)
                    .HasMaxLength(255)
                    .HasColumnName("WF_Reason_For_Borrowing_Id");
            });

            modelBuilder.Entity<VslatrackerIndirect1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VSLATrackerIndirect_1");

                entity.Property(e => e.AmountSavingDepositedToFfi)
                    .HasMaxLength(255)
                    .HasColumnName("Amount_Saving_Deposited_To_FFI");

                entity.Property(e => e.BorrowedLf).HasColumnName("Borrowed_LF");

                entity.Property(e => e.BorrowedWf)
                    .HasMaxLength(255)
                    .HasColumnName("Borrowed_WF");

                entity.Property(e => e.CashBalanceInOvcFund)
                    .HasMaxLength(255)
                    .HasColumnName("Cash_Balance_In_Ovc_Fund");

                entity.Property(e => e.CashInWelfareFund)
                    .HasMaxLength(255)
                    .HasColumnName("Cash_In_welfare_Fund");

                entity.Property(e => e.CollectedBy).HasMaxLength(255);

                entity.Property(e => e.CollectedDeignation).HasMaxLength(255);

                entity.Property(e => e.CollectionDate).HasMaxLength(255);

                entity.Property(e => e.CummValueOfPropertyNow)
                    .HasMaxLength(255)
                    .HasColumnName("Cumm_Value_of_Property_Now");

                entity.Property(e => e.CummValueOfSavingsThisCycle)
                    .HasMaxLength(255)
                    .HasColumnName("Cumm_Value_of_Savings_this_Cycle");

                entity.Property(e => e.CumulativeNoOvcAccessingTcs)
                    .HasMaxLength(255)
                    .HasColumnName("Cumulative_No_OVC_Accessing_TCS");

                entity.Property(e => e.CycleSavingStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cycle_Saving_Start_Date");

                entity.Property(e => e.GroupCode).HasMaxLength(255);

                entity.Property(e => e.GroupFoundation).HasColumnType("datetime");

                entity.Property(e => e.IndirectMemberCode).HasMaxLength(255);

                entity.Property(e => e.LfReasonForBorrowingId)
                    .HasMaxLength(255)
                    .HasColumnName("LF_Reason_For_Borrowing_Id");

                entity.Property(e => e.LinkageToExternalCredit)
                    .HasMaxLength(255)
                    .HasColumnName("Linkage_To_External_Credit");

                entity.Property(e => e.LinkageToExternalSaving).HasMaxLength(255);

                entity.Property(e => e.LoanCashInBoxBank)
                    .HasMaxLength(255)
                    .HasColumnName("Loan_Cash_In_Box_Bank");

                entity.Property(e => e.MemberName).HasMaxLength(255);

                entity.Property(e => e.MemberStausId).HasMaxLength(255);

                entity.Property(e => e.NameLinkageToExternalCredit)
                    .HasMaxLength(255)
                    .HasColumnName("Name_Linkage_To_External_Credit");

                entity.Property(e => e.NameLinkageToExternalSaving).HasMaxLength(255);

                entity.Property(e => e.NoMemberAttendingMeeting)
                    .HasMaxLength(255)
                    .HasColumnName("No_Member_attending_Meeting");

                entity.Property(e => e.NoMembersAtStartOfCycle)
                    .HasMaxLength(255)
                    .HasColumnName("No_Members_At_Start_of_Cycle");

                entity.Property(e => e.NoOfBensTrainedFl)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_Bens_Trained_FL");

                entity.Property(e => e.NoOfBensTrainedSpm)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_Bens_Trained_SPM");

                entity.Property(e => e.NoOfMembersRunningIgas)
                    .HasMaxLength(255)
                    .HasColumnName("No_of_members_running_IGAs");

                entity.Property(e => e.NoOfOutstandingLoan)
                    .HasMaxLength(255)
                    .HasColumnName("No_Of_Outstanding_Loan");

                entity.Property(e => e.ParishId).HasMaxLength(255);

                entity.Property(e => e.RepaidLf)
                    .HasMaxLength(255)
                    .HasColumnName("Repaid_LF");

                entity.Property(e => e.RepaidWf)
                    .HasMaxLength(255)
                    .HasColumnName("Repaid_WF");

                entity.Property(e => e.ReportingMonth).HasMaxLength(255);

                entity.Property(e => e.ReviewDate).HasMaxLength(255);

                entity.Property(e => e.ReviewDesignation).HasMaxLength(255);

                entity.Property(e => e.ReviewedBy).HasMaxLength(255);

                entity.Property(e => e.SavedLf).HasColumnName("Saved_LF");

                entity.Property(e => e.SavedOf).HasColumnName("Saved_OF");

                entity.Property(e => e.SavedWf).HasColumnName("Saved_WF");

                entity.Property(e => e.TotalCumulativeCashPayoutOvcFund)
                    .HasMaxLength(255)
                    .HasColumnName("Total_Cumulative_cash_payout_OVC_Fund");

                entity.Property(e => e.UnpaidBalanceOfLateLoan)
                    .HasMaxLength(255)
                    .HasColumnName("Unpaid_Balance_Of_Late_Loan");

                entity.Property(e => e.ValeOfOutstandingLoansAtFfi)
                    .HasMaxLength(255)
                    .HasColumnName("Vale_of_Outstanding_Loans_at_FFI");

                entity.Property(e => e.ValueOfLoanOutStanding)
                    .HasMaxLength(255)
                    .HasColumnName("Value_of_loan_outStanding");

                entity.Property(e => e.VslaGroupIndirectMemberId).HasColumnName("VSLA_Group_Indirect_Member_Id");

                entity.Property(e => e.VslaGroupTrainerId)
                    .HasMaxLength(255)
                    .HasColumnName("VSLA_Group_Trainer_Id");

                entity.Property(e => e.VslatrackingToolInDirectMemberId).HasColumnName("VSLATrackingToolInDirectMemberId");

                entity.Property(e => e.WfReasonForBorrowingId)
                    .HasMaxLength(255)
                    .HasColumnName("WF_Reason_For_Borrowing_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
