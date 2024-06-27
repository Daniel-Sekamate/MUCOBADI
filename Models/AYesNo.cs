using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AYesNo
    {
        public AYesNo()
        {
            AvatAdolescentProgressingNavigation = new HashSet<Avat>();
            AvatAdolescentWithKnownHivstatusNavigation = new HashSet<Avat>();
            AvatAntiretroviralTherapyNavigation = new HashSet<Avat>();
            AvatFeelingWithdrawnNavigation = new HashSet<Avat>();
            AvatHadViralLoadBloodTestNavigation = new HashSet<Avat>();
            AvatHasAttendedSchoolNavigation = new HashSet<Avat>();
            AvatIsSavingsGroupMemberNavigation = new HashSet<Avat>();
            AvatIsViralloadSuppressedNavigation = new HashSet<Avat>();
            AvatLackofFoodNavigation = new HashSet<Avat>();
            AvatSameAdultPrimaryCareGiverNavigation = new HashSet<Avat>();
            BeneficiaryEnrolmentRegisterDetailsAssessedNotEligibleNavigation = new HashSet<BeneficiaryEnrolmentRegisterDetails>();
            BeneficiaryEnrolmentRegisterDetailsAssessedOfferedAcceptedNavigation = new HashSet<BeneficiaryEnrolmentRegisterDetails>();
            BeneficiaryEnrolmentRegisterDetailsAssessedOfferedRefusedNavigation = new HashSet<BeneficiaryEnrolmentRegisterDetails>();
            BeneficiaryEnrolmentRegisterDetailsNotAssessedNavigation = new HashSet<BeneficiaryEnrolmentRegisterDetails>();
            BeneficiaryEnrolmentRegisterDetailsOvcEnrollNavigation = new HashSet<BeneficiaryEnrolmentRegisterDetails>();
            BeneficiaryEnrolmentRegisterDetailsOvcOfferNavigation = new HashSet<BeneficiaryEnrolmentRegisterDetails>();
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            BeneficiaryLinkageTrackingToolDirectMember = new HashSet<BeneficiaryLinkageTrackingToolDirectMember>();
            BeneficiaryLinkageTrackingToolIndirectMember = new HashSet<BeneficiaryLinkageTrackingToolIndirectMember>();
            CommunityTbSensitizationClientReferedForEvaluationNavigation = new HashSet<CommunityTbSensitization>();
            CommunityTbSensitizationExcessiveNightSweatsNavigation = new HashSet<CommunityTbSensitization>();
            CommunityTbSensitizationHasFeverNavigation = new HashSet<CommunityTbSensitization>();
            CommunityTbSensitizationIsCoughingNavigation = new HashSet<CommunityTbSensitization>();
            CommunityTbSensitizationIsCoughingUpBloodNavigation = new HashSet<CommunityTbSensitization>();
            CommunityTbSensitizationIsSensitisedOnTbNavigation = new HashSet<CommunityTbSensitization>();
            CommunityTbSensitizationIsaclientapresumptiveTbcaseNavigation = new HashSet<CommunityTbSensitization>();
            CommunityTbSensitizationOtherSymptomsNavigation = new HashSet<CommunityTbSensitization>();
            CommunityTbSensitizationWeightLossNavigation = new HashSet<CommunityTbSensitization>();
            EcdDirectMemberDetailParentAttendedNavigation = new HashSet<EcdDirectMemberDetail>();
            EcdDirectMemberDetailTeenAttendedNavigation = new HashSet<EcdDirectMemberDetail>();
            EcdIndirectMemberDetailParentAttendedNavigation = new HashSet<EcdIndirectMemberDetail>();
            EcdIndirectMemberDetailTeenAttendedNavigation = new HashSet<EcdIndirectMemberDetail>();
            GraduationBenchMarkChildHeadedHouseholdAssessmentYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkChildrenInSchoolAssessmentYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkDetailAdolescentidentifiedatleastoneHivpreventionstrategyYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailAdolescentidentifiedatleasttwoHivrisksYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailAreenrolledinschoolYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailAttendedschoolregularlyoverthepastyearYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailBeneficiariesbeentakingantiretroviraltherapypillsasprescribedYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailChildMuacmorethan125cmYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailChildfreeofanysignsofbipedaledemaYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailDocumentedAsVirallySuppressedYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailHouseholdMembersbeenunderthecareofastableadultcaregiverYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailIsHouseholdMemberActiveYesNoNavigation = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailMemberHivStatusDocumentYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailPrimaryCareGiverHiveStatusDocumentedYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailProgressedtonextclassfromlastyeartothisschoolyearYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailRegularyAttendingArtAppointmentYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailRepeatedphysicalabuseYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkDetailSexuallyabusedYesNo = new HashSet<GraduationBenchMarkDetail>();
            GraduationBenchMarkHivpreventionKnowledgeAssessmentYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkImprovedfinancialstabilityAssessmentYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkImprovedfinancialstabilityScholashipYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkImprovedfinancialstabilitySellingIncomeGeneratingSomethingYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkKnownHiveStatusAssessmentYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkMedicalCostAssessmentYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkMedicalCostCashTransfertYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkMedicalCostSellingIncomeGeneratingSomethingYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkNoViolenceAssesmentYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkNotundernourishedAssessmentYesNo = new HashSet<GraduationBenchMark>();
            GraduationBenchMarkVirallySuppressedAssessmentYesNo = new HashSet<GraduationBenchMark>();
            GraduationChecklistDetail = new HashSet<GraduationChecklistDetail>();
            HivTbRisKassessmentToolBeenCoughingForTwoWeekNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildAdmittedToHospitalInSixMonthsNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildCoughingForTwoWeeksNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildDignosedWithTuberculosisNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildDrugAbuseOrAlcoholNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildExperiencedExcessiveNightSweetingNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildHadContactWithActiveTbdiseaseAdultNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildHadPersistentFeverHstoryNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildHasAccidentalExposureNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildHasPoorWeightGainNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildHasSexualAbuseHistoryNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildHivsymptomaticNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildLivesWithHivpositiveMotherOrFatherNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolChildMalnourishedNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolClientFallsInSexWorkersCategoryNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolClientHadUnprotectedSexInPastThreeMonthNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolClientHasHistoryOfIllnessNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolClientHasLossOfSexualPartnerHistoryNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolClientHasNewHepatitisBdiagnosisNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolClientHasPresumptiveActiveTbdiseaseNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolClientIsMaleOrFemaleWithnoHivtestNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolClientWithSexuallyTransmittedInfectionNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolExperiencedExcessiveNightSweatsNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolHaveYouLostWeightNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolHivnegativePartnerInDiscordantRelationshipNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolIsOnArtNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolIsVirallaodTestDoneNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbRisKassessmentToolPersistentFeverForTwoWeeksNavigation = new HashSet<HivTbRisKassessmentTool>();
            HivTbTrackingFormAnotherPersonContactedOnBehalfOfClientNavigation = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormClientAtTbinfectionRiskNavigation = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormClientHasPresumptiveOrActiveTbNavigation = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormClientReceivedTbscreeningSessionNavigation = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormClientSuccessfullyContactedOrSeenNavigation = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormExposedInfantsIsEnrolledOnArtNavigation = new HashSet<HivTbTrackingFormExposedInfants>();
            HivTbTrackingFormExposedInfantsIsTrackedAndReturnedToCareNavigation = new HashSet<HivTbTrackingFormExposedInfants>();
            HivTbTrackingFormExposedInfantsPmtctmotherProvidedWithTreatmentLiteracyNavigation = new HashSet<HivTbTrackingFormExposedInfants>();
            HivTbTrackingFormExposedInfantsSupportedToEnrollAndAdhereToPmtctNavigation = new HashSet<HivTbTrackingFormExposedInfants>();
            HivTbTrackingFormIsClientEligibleForViralloadNavigation = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormOnArtNavigation = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormOptimizedYesNoNavigation = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormSupportedToDiscloseHivStatusToFamilyYesNo = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormViralloadResultsReceivedNavigation = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormViralloadTestDoneNavigation = new HashSet<HivTbTrackingForm>();
            HouseHoldMembersCurrentlyonArtNavigation = new HashSet<HouseHoldMembers>();
            HouseHoldMembersDoesChildHaveBirthCertificateNavigation = new HashSet<HouseHoldMembers>();
            HouseHoldMembersHasanIgaNavigation = new HashSet<HouseHoldMembers>();
            HouseHoldMembersIsAttendingSchoolRegularlyNavigation = new HashSet<HouseHoldMembers>();
            HouseHoldMembersIsChildUnder5MalnourishedNavigation = new HashSet<HouseHoldMembers>();
            HouseHoldMembersIsDisabledNavigation = new HashSet<HouseHoldMembers>();
            HouseHoldMembersIsEnrolledInSchoolNavigation = new HashSet<HouseHoldMembers>();
            HouseHoldMembersIsOrphanedNavigation = new HashSet<HouseHoldMembers>();
            HouseHoldMembersIschildimmunisedNavigation = new HashSet<HouseHoldMembers>();
            HouseHoldMembersIsinSavingsGroupNavigation = new HashSet<HouseHoldMembers>();
            HouseHoldMembersIsinschoolcompletingapprenticeshipNavigation = new HashSet<HouseHoldMembers>();
            HvatChildrenChildProgressingNavigation = new HashSet<Hvat>();
            HvatChildrenaged617attendedInSchoolNavigation = new HashSet<Hvat>();
            HvatChildrenaged617enrolledInSchoolNavigation = new HashSet<Hvat>();
            HvatHaveLongTermIllnessNavigation = new HashSet<Hvat>();
            HvatHavePersonWithDisabilityNavigation = new HashSet<Hvat>();
            HvatIsSavingsGroupMemberNavigation = new HashSet<Hvat>();
            HvatLackofFoodNavigation = new HashSet<Hvat>();
            HvatSameAdultPrimaryCareGiverNavigation = new HashSet<Hvat>();
            InterventionAttendanceFormDetail = new HashSet<InterventionAttendanceFormDetail>();
            IsvatcurrentBusinessOpportunity = new HashSet<IsvatcurrentBusinessOpportunity>();
            IsvatincomeEarner = new HashSet<IsvatincomeEarner>();
            IsvatincomeOwnership = new HashSet<IsvatincomeOwnership>();
            MonthlyCaseTrackingRegisterDetailPendingNavigation = new HashSet<MonthlyCaseTrackingRegisterDetail>();
            MonthlyCaseTrackingRegisterDetailReferredNavigation = new HashSet<MonthlyCaseTrackingRegisterDetail>();
            MonthlyCaseTrackingRegisterDetailResolvedNavigation = new HashSet<MonthlyCaseTrackingRegisterDetail>();
            MonthlyCaseTrackingRegisterDetailTransferredNavigation = new HashSet<MonthlyCaseTrackingRegisterDetail>();
            ReferralFormCurrentlyonArtNavigation = new HashSet<ReferralForm>();
            ReferralFormHasCaseBeenReportedToUgandaChildHelplineNavigation = new HashSet<ReferralForm>();
            SinoParentingDirectMemberDetailParentAttendedNavigation = new HashSet<SinoParentingDirectMemberDetail>();
            SinoParentingDirectMemberDetailTeenAttendedNavigation = new HashSet<SinoParentingDirectMemberDetail>();
            SinoParentingIndirectMemberDetailParentAttendedNavigation = new HashSet<SinoParentingIndirectMemberDetail>();
            SinoParentingIndirectMemberDetailTeenAttendedNavigation = new HashSet<SinoParentingIndirectMemberDetail>();
            SmuAssessmentGuideConsentObtainedYesNoNavigation = new HashSet<SmuAssessmentGuide>();
            SmuAssessmentGuideExperiencedGenderBasedViolenceNavigation = new HashSet<SmuAssessmentGuide>();
            SmuAssessmentGuideExperiencedThoughtsOffDeadHurtingNavigation = new HashSet<SmuAssessmentGuide>();
            SmuAssessmentGuideStressfulEvent = new HashSet<SmuAssessmentGuide>();
            VslaTrackingToolLinkageToExternalCreditNavigation = new HashSet<VslaTrackingTool>();
            VslaTrackingToolLinkageToExternalSavingNavigation = new HashSet<VslaTrackingTool>();
        }

        public int YesNoId { get; set; }
        public string YesNoDescription { get; set; }

        public virtual ICollection<Avat> AvatAdolescentProgressingNavigation { get; set; }
        public virtual ICollection<Avat> AvatAdolescentWithKnownHivstatusNavigation { get; set; }
        public virtual ICollection<Avat> AvatAntiretroviralTherapyNavigation { get; set; }
        public virtual ICollection<Avat> AvatFeelingWithdrawnNavigation { get; set; }
        public virtual ICollection<Avat> AvatHadViralLoadBloodTestNavigation { get; set; }
        public virtual ICollection<Avat> AvatHasAttendedSchoolNavigation { get; set; }
        public virtual ICollection<Avat> AvatIsSavingsGroupMemberNavigation { get; set; }
        public virtual ICollection<Avat> AvatIsViralloadSuppressedNavigation { get; set; }
        public virtual ICollection<Avat> AvatLackofFoodNavigation { get; set; }
        public virtual ICollection<Avat> AvatSameAdultPrimaryCareGiverNavigation { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterDetails> BeneficiaryEnrolmentRegisterDetailsAssessedNotEligibleNavigation { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterDetails> BeneficiaryEnrolmentRegisterDetailsAssessedOfferedAcceptedNavigation { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterDetails> BeneficiaryEnrolmentRegisterDetailsAssessedOfferedRefusedNavigation { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterDetails> BeneficiaryEnrolmentRegisterDetailsNotAssessedNavigation { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterDetails> BeneficiaryEnrolmentRegisterDetailsOvcEnrollNavigation { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterDetails> BeneficiaryEnrolmentRegisterDetailsOvcOfferNavigation { get; set; }
        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolDirectMember> BeneficiaryLinkageTrackingToolDirectMember { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolIndirectMember> BeneficiaryLinkageTrackingToolIndirectMember { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitizationClientReferedForEvaluationNavigation { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitizationExcessiveNightSweatsNavigation { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitizationHasFeverNavigation { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitizationIsCoughingNavigation { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitizationIsCoughingUpBloodNavigation { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitizationIsSensitisedOnTbNavigation { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitizationIsaclientapresumptiveTbcaseNavigation { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitizationOtherSymptomsNavigation { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitizationWeightLossNavigation { get; set; }
        public virtual ICollection<EcdDirectMemberDetail> EcdDirectMemberDetailParentAttendedNavigation { get; set; }
        public virtual ICollection<EcdDirectMemberDetail> EcdDirectMemberDetailTeenAttendedNavigation { get; set; }
        public virtual ICollection<EcdIndirectMemberDetail> EcdIndirectMemberDetailParentAttendedNavigation { get; set; }
        public virtual ICollection<EcdIndirectMemberDetail> EcdIndirectMemberDetailTeenAttendedNavigation { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkChildHeadedHouseholdAssessmentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkChildrenInSchoolAssessmentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailAdolescentidentifiedatleastoneHivpreventionstrategyYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailAdolescentidentifiedatleasttwoHivrisksYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailAreenrolledinschoolYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailAttendedschoolregularlyoverthepastyearYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailBeneficiariesbeentakingantiretroviraltherapypillsasprescribedYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailChildMuacmorethan125cmYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailChildfreeofanysignsofbipedaledemaYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailDocumentedAsVirallySuppressedYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailHouseholdMembersbeenunderthecareofastableadultcaregiverYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailIsHouseholdMemberActiveYesNoNavigation { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailMemberHivStatusDocumentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailPrimaryCareGiverHiveStatusDocumentedYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailProgressedtonextclassfromlastyeartothisschoolyearYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailRegularyAttendingArtAppointmentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailRepeatedphysicalabuseYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetailSexuallyabusedYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkHivpreventionKnowledgeAssessmentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkImprovedfinancialstabilityAssessmentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkImprovedfinancialstabilityScholashipYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkImprovedfinancialstabilitySellingIncomeGeneratingSomethingYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkKnownHiveStatusAssessmentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkMedicalCostAssessmentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkMedicalCostCashTransfertYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkMedicalCostSellingIncomeGeneratingSomethingYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkNoViolenceAssesmentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkNotundernourishedAssessmentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMarkVirallySuppressedAssessmentYesNo { get; set; }
        public virtual ICollection<GraduationChecklistDetail> GraduationChecklistDetail { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolBeenCoughingForTwoWeekNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildAdmittedToHospitalInSixMonthsNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildCoughingForTwoWeeksNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildDignosedWithTuberculosisNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildDrugAbuseOrAlcoholNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildExperiencedExcessiveNightSweetingNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildHadContactWithActiveTbdiseaseAdultNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildHadPersistentFeverHstoryNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildHasAccidentalExposureNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildHasPoorWeightGainNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildHasSexualAbuseHistoryNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildHivsymptomaticNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildLivesWithHivpositiveMotherOrFatherNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolChildMalnourishedNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolClientFallsInSexWorkersCategoryNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolClientHadUnprotectedSexInPastThreeMonthNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolClientHasHistoryOfIllnessNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolClientHasLossOfSexualPartnerHistoryNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolClientHasNewHepatitisBdiagnosisNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolClientHasPresumptiveActiveTbdiseaseNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolClientIsMaleOrFemaleWithnoHivtestNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolClientWithSexuallyTransmittedInfectionNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolExperiencedExcessiveNightSweatsNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolHaveYouLostWeightNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolHivnegativePartnerInDiscordantRelationshipNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolIsOnArtNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolIsVirallaodTestDoneNavigation { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentToolPersistentFeverForTwoWeeksNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormAnotherPersonContactedOnBehalfOfClientNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormClientAtTbinfectionRiskNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormClientHasPresumptiveOrActiveTbNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormClientReceivedTbscreeningSessionNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormClientSuccessfullyContactedOrSeenNavigation { get; set; }
        public virtual ICollection<HivTbTrackingFormExposedInfants> HivTbTrackingFormExposedInfantsIsEnrolledOnArtNavigation { get; set; }
        public virtual ICollection<HivTbTrackingFormExposedInfants> HivTbTrackingFormExposedInfantsIsTrackedAndReturnedToCareNavigation { get; set; }
        public virtual ICollection<HivTbTrackingFormExposedInfants> HivTbTrackingFormExposedInfantsPmtctmotherProvidedWithTreatmentLiteracyNavigation { get; set; }
        public virtual ICollection<HivTbTrackingFormExposedInfants> HivTbTrackingFormExposedInfantsSupportedToEnrollAndAdhereToPmtctNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormIsClientEligibleForViralloadNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormOnArtNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormOptimizedYesNoNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormSupportedToDiscloseHivStatusToFamilyYesNo { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormViralloadResultsReceivedNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormViralloadTestDoneNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersCurrentlyonArtNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersDoesChildHaveBirthCertificateNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersHasanIgaNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersIsAttendingSchoolRegularlyNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersIsChildUnder5MalnourishedNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersIsDisabledNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersIsEnrolledInSchoolNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersIsOrphanedNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersIschildimmunisedNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersIsinSavingsGroupNavigation { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembersIsinschoolcompletingapprenticeshipNavigation { get; set; }
        public virtual ICollection<Hvat> HvatChildrenChildProgressingNavigation { get; set; }
        public virtual ICollection<Hvat> HvatChildrenaged617attendedInSchoolNavigation { get; set; }
        public virtual ICollection<Hvat> HvatChildrenaged617enrolledInSchoolNavigation { get; set; }
        public virtual ICollection<Hvat> HvatHaveLongTermIllnessNavigation { get; set; }
        public virtual ICollection<Hvat> HvatHavePersonWithDisabilityNavigation { get; set; }
        public virtual ICollection<Hvat> HvatIsSavingsGroupMemberNavigation { get; set; }
        public virtual ICollection<Hvat> HvatLackofFoodNavigation { get; set; }
        public virtual ICollection<Hvat> HvatSameAdultPrimaryCareGiverNavigation { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetail { get; set; }
        public virtual ICollection<IsvatcurrentBusinessOpportunity> IsvatcurrentBusinessOpportunity { get; set; }
        public virtual ICollection<IsvatincomeEarner> IsvatincomeEarner { get; set; }
        public virtual ICollection<IsvatincomeOwnership> IsvatincomeOwnership { get; set; }
        public virtual ICollection<MonthlyCaseTrackingRegisterDetail> MonthlyCaseTrackingRegisterDetailPendingNavigation { get; set; }
        public virtual ICollection<MonthlyCaseTrackingRegisterDetail> MonthlyCaseTrackingRegisterDetailReferredNavigation { get; set; }
        public virtual ICollection<MonthlyCaseTrackingRegisterDetail> MonthlyCaseTrackingRegisterDetailResolvedNavigation { get; set; }
        public virtual ICollection<MonthlyCaseTrackingRegisterDetail> MonthlyCaseTrackingRegisterDetailTransferredNavigation { get; set; }
        public virtual ICollection<ReferralForm> ReferralFormCurrentlyonArtNavigation { get; set; }
        public virtual ICollection<ReferralForm> ReferralFormHasCaseBeenReportedToUgandaChildHelplineNavigation { get; set; }
        public virtual ICollection<SinoParentingDirectMemberDetail> SinoParentingDirectMemberDetailParentAttendedNavigation { get; set; }
        public virtual ICollection<SinoParentingDirectMemberDetail> SinoParentingDirectMemberDetailTeenAttendedNavigation { get; set; }
        public virtual ICollection<SinoParentingIndirectMemberDetail> SinoParentingIndirectMemberDetailParentAttendedNavigation { get; set; }
        public virtual ICollection<SinoParentingIndirectMemberDetail> SinoParentingIndirectMemberDetailTeenAttendedNavigation { get; set; }
        public virtual ICollection<SmuAssessmentGuide> SmuAssessmentGuideConsentObtainedYesNoNavigation { get; set; }
        public virtual ICollection<SmuAssessmentGuide> SmuAssessmentGuideExperiencedGenderBasedViolenceNavigation { get; set; }
        public virtual ICollection<SmuAssessmentGuide> SmuAssessmentGuideExperiencedThoughtsOffDeadHurtingNavigation { get; set; }
        public virtual ICollection<SmuAssessmentGuide> SmuAssessmentGuideStressfulEvent { get; set; }
        public virtual ICollection<VslaTrackingTool> VslaTrackingToolLinkageToExternalCreditNavigation { get; set; }
        public virtual ICollection<VslaTrackingTool> VslaTrackingToolLinkageToExternalSavingNavigation { get; set; }
    }
}
