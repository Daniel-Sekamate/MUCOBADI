using Microsoft.AspNetCore.Mvc;
using MUCOBADI.DTOs;
using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MUCOBADI.Interfaces.SMUtools
{
    public interface ISMUtools
    {
        Task<Response> SaveSMUGroup(SmuGroup data);
        Task<Response> SaveSmuAssessmentGuide(SmuAssessmentGuide data);
        Task<Response> SaveSMUSafetyPlanningForm(SmuSafetyPlanningForm data);
        Task<Response> SaveSmuPreGroupGuide(SmuPreGroupGuide data);
        Task<Response> SaveSmuAttendenceHeader(SmuAttendenceHeader data);
        Task<Response> SaveSmuTerminantionGuide(SmuTerminantionGuide data);
        Task<List<SmuClientRegistrationForm>> GetClientRegisteredByGroupId(int SMUGroupId);
        Task<List<SmuAttendenceHeader>> GetClientAttendanceByGroupId(int SMUGroupId);
        Task<List<SmuAssessmentGuide>> GetClientAssessmentGuideByGroupId(int SMUGroupId);
        Task<List<ViewSmuAssessmentGuide>> GetViewSmuAssessmentGuideListId(int SMUGroupId);
        Task<List<SmuTerminantionGuide>> GetSmuTerminantionGuides(int SMUGroupId);
        Task<ViewSmuAssessmentGuide> GetViewSmuAssessmentGuideId(int SelectedPreAssessmentGuideId);
        Task<ViewSmuAssessmentGuide> GetListViewSmuAssessmentGuideId(int SelectedPreAssessmentGuideId);
        Task<List<SmuAssessmentGuidePh9Questions>> GetSmuAssessmentGuidePh9Questions(int SelectedPreAssessmentGuideId);
        Task<List<SmuTerminantionGuidePh9Questions>> GetSmuTerminantionGuidePh9Questions(int SelectedTerminationGuideId);
        Task<List<SmuSucideAssementFormHeader>> GetSmuSucideAssementFormHeader(int SelectedAssementGuideId);
        Task<List<SmuAttendenceFormDetail>> GetSmuAttendenceFormDetail(int SelectedAttendanceHeaderId);
        Task<List<SmuPreGroupGuidePh9Questions>> GetSmuPreGroupGuidePh9Questions(int SelectedPreGroupGuideId);
        Task<List<SmuPreGroupGuide>> GetSmuPreGroupGuide(int SelectedGroupId);
        Task<List<SmuSafetyPlanningForm>> GetSmuSafetyPlanningForm(int SelectedAssessmentGuideId);
        Task<List<SmuSafetyPlanningFormWarningSigns>> GetSmuSafetyPlanningFormWarningSigns(int SelectedSafetyPlanningFormId);
        Task<List<SmuSafetyPlanningFormInternalCopingStrategies>> GetSmuSafetyPlanningFormInternalCopingStrategies(int SelectedSafetyPlanningFormId);
        Task<PagedResult<SmuGroup>> GetAllSMUGroups(int page = 1, int pageSize = 30, string? searchTerm = "");
        // Task<byte[]> GenerateClientRegistrationReport(DateTime? startDate, DateTime? endDate,string? smuGroupIds = "", string? regionIds = "", string? districtIds = "", string? subcountyIds = "", string? clientAgeRangeIds = "", string? smuOfficeIds = "", string? smuFacilitatorIds = "");
        Task<byte[]> GenerateClientRegistrationReportAsync(DateTime? startDate, DateTime? endDate, string? smuGroupIds = "", string? regionIds = "", string? districtIds = "", string? subcountyIds = "", string? clientAgeRangeIds = "", string? smuOfficeIds = "", string? smuFacilitatorIds = "");

        Task<byte[]> GenerateTherapySessionReportAsync(DateTime? startDate, DateTime? endDate, string? smuGroupIds = "", string? regionIds = "", string? districtIds = "", string? subcountyIds = "", string? clientAgeRangeIds = "", string? smuOfficeIds = "", string? smuFacilitatorIds = "");

    }
}
