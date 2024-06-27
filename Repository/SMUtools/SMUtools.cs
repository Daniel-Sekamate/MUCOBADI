using Microsoft.EntityFrameworkCore;
using MUCOBADI.Interfaces.SMUtools;
using MUCOBADI.Models;
using Syncfusion.Blazor.Data;
using Syncfusion.JavaScript.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using MUCOBADI.DTOs;
using System;
using BlazorStrap;
using Syncfusion.DocIO.DLS;
<<<<<<< HEAD
using Syncfusion.XlsIO;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.ExcelExport;
using Microsoft.AspNetCore.Hosting;
=======
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699

namespace MUCOBADI.Repository.SMUtools
{
    public class SMUtools : ISMUtools
    {
        private readonly MUCOBADIContext _context;
<<<<<<< HEAD
        private readonly IWebHostEnvironment _hostingEnvironment;
        public SMUtools(MUCOBADIContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
=======
        
        public SMUtools(MUCOBADIContext context)
        {
            _context = context;
                
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
        }

        public async Task<List<SmuClientRegistrationForm>> GetClientRegisteredByGroupId(int SMUGroupId)
        {
            var data = await _context.SmuClientRegistrationForm
                .AsNoTracking()
                .Where(std => std.SmuGroupId == SMUGroupId)
                .ToListAsync();
            return data;
        }
<<<<<<< HEAD
        public async Task<List<ViewSmuAssessmentGuide>> GetViewSmuAssessmentGuideListId(int SMUGroupId)
=======
       public async Task<List<ViewSmuAssessmentGuide>> GetViewSmuAssessmentGuideListId(int SMUGroupId)
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
        {
            var data = await _context.ViewSmuAssessmentGuide
               .AsNoTracking()
               .Where(std => std.SmuGroupId == SMUGroupId)
               .ToListAsync();
            return data;
        }
        public async Task<List<SmuAttendenceHeader>> GetClientAttendanceByGroupId(int SMUGroupId)
        {
            var data = await _context.SmuAttendenceHeader
               .AsNoTracking()
               .Where(std => std.SmuGroupId == SMUGroupId)
               .ToListAsync();
            return data;
        }
        public async Task<List<SmuAssessmentGuide>> GetClientAssessmentGuideByGroupId(int SMUGroupId)
        {
            var data = await _context.SmuAssessmentGuide
               .AsNoTracking()
               .Where(std => std.SmuGroupId == SMUGroupId)
               .ToListAsync();
            return data;
        }

        public async Task<List<SmuTerminantionGuide>> GetSmuTerminantionGuides(int SMUGroupId)
        {
            var data = await _context.SmuTerminantionGuide
              .AsNoTracking()
              .Where(std => std.SmuGroupId == SMUGroupId)
              .ToListAsync();
            return data;
        }
        public async Task<ViewSmuAssessmentGuide> GetListViewSmuAssessmentGuideId(int SelectedPreAssessmentGuideId)
        {
            var data = await _context.ViewSmuAssessmentGuide
             .AsNoTracking()
             .FirstOrDefaultAsync(std => std.AssementGuideId == SelectedPreAssessmentGuideId);
            return data;
        }

        public async Task<List<SmuTerminantionGuidePh9Questions>> GetSmuTerminantionGuidePh9Questions(int SelectedTerminationGuideId)
        {
            var data = await _context.SmuTerminantionGuidePh9Questions
           .AsNoTracking()
           .Where(std => std.SmuTerminantionGuideId == SelectedTerminationGuideId)
           .ToListAsync();
            return data;
        }
        public async Task<List<SmuAssessmentGuidePh9Questions>> GetSmuAssessmentGuidePh9Questions(int SelectedPreAssessmentGuideId)
        {
            var data = await _context.SmuAssessmentGuidePh9Questions
             .AsNoTracking()
             .Where(std => std.SmuAssessmentGuideId == SelectedPreAssessmentGuideId)
             .ToListAsync();
            return data;
        }
        public async Task<ViewSmuAssessmentGuide> GetViewSmuAssessmentGuideId(int SelectedPreAssessmentGuideId)
        {
            var data = await _context.ViewSmuAssessmentGuide
              .AsNoTracking()
              .FirstOrDefaultAsync(std => std.AssementGuideId == SelectedPreAssessmentGuideId);
            return data;
        }
        public async Task<List<SmuSucideAssementFormHeader>> GetSmuSucideAssementFormHeader(int SelectedAssementGuideId)
        {
            var data = await _context.SmuSucideAssementFormHeader
            .AsNoTracking()
            .Where(std => std.AssementGuideId == SelectedAssementGuideId)
            .ToListAsync();
            return data;
        }
        public async Task<List<SmuAttendenceFormDetail>> GetSmuAttendenceFormDetail(int SelectedAttendanceHeaderId)
        {
            var data = await _context.SmuAttendenceFormDetail
           .AsNoTracking()
           .Where(std => std.AttendenceFormHeaderId == SelectedAttendanceHeaderId)
           .ToListAsync();
            return data;

        }
        public async Task<List<SmuPreGroupGuidePh9Questions>> GetSmuPreGroupGuidePh9Questions(int SelectedPreGroupGuideId)
        {
            var data = await _context.SmuPreGroupGuidePh9Questions
          .AsNoTracking()
          .Where(std => std.SmuPreGroupGuideId == SelectedPreGroupGuideId)
          .ToListAsync();
            return data;
        }

        public async Task<List<SmuPreGroupGuide>> GetSmuPreGroupGuide(int SelectedGroupId)
        {
            var data = await _context.SmuPreGroupGuide
         .AsNoTracking()
         .Where(std => std.SmuGroupId == SelectedGroupId)
         .ToListAsync();
            return data;
        }
        public async Task<List<SmuSafetyPlanningForm>> GetSmuSafetyPlanningForm(int SelectedAssessmentGuideId)
        {
            var data = await _context.SmuSafetyPlanningForm
           .AsNoTracking()
           .Where(std => std.SmuAssementGuideId == SelectedAssessmentGuideId)
           .ToListAsync();
<<<<<<< HEAD
            return data;
=======
                return data;
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
        }
        public async Task<List<SmuSafetyPlanningFormWarningSigns>> GetSmuSafetyPlanningFormWarningSigns(int SelectedSafetyPlanningFormId)
        {
            var data = await _context.SmuSafetyPlanningFormWarningSigns
          .AsNoTracking()
          .Where(std => std.SafetyPlanningFormId == SelectedSafetyPlanningFormId)
          .ToListAsync();
            return data;
        }
        public async Task<List<SmuSafetyPlanningFormInternalCopingStrategies>> GetSmuSafetyPlanningFormInternalCopingStrategies(int SelectedSafetyPlanningFormId)
        {
            var data = await _context.SmuSafetyPlanningFormInternalCopingStrategies
        .AsNoTracking()
        .Where(std => std.SafetyPlanningFormId == SelectedSafetyPlanningFormId)
        .ToListAsync();
            return data;
        }
        public async Task<PagedResult<SmuGroup>> GetAllSMUGroups(int page = 1, int pageSize = 30, string? searchTerm = "")
        {
            var query = _context.SmuGroup
             .AsNoTracking()
             .OrderByDescending(p => p.SmuGroupId)
             .Where(p => p.SmuGroupId != null);
            //  Apply search filter based on the client name
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p => p.SmuGroupName.Contains(searchTerm));
            }
            var totalCount = await query.CountAsync();
            var data = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return new PagedResult<SmuGroup>(data, page, pageSize, totalCount);
        }
        public async Task<Response> SaveSMUGroup(SmuGroup data)
        {
            Response _data = new Response();
            try
            {
                // Your code to perform database operations using Entity Framework
                var GroupExists = await _context.SmuGroup.FirstOrDefaultAsync(o => o.SmuGroupId == data.SmuGroupId);
                if (GroupExists == null)
                {
                    int id = 1;
                    var lastGroup = await _context.SmuGroup.OrderByDescending(o => o.SmuGroupId).FirstOrDefaultAsync();
                    if (lastGroup != null)
                    {
                        id = (lastGroup.SmuGroupId + 1);
                    }
                    data.SmuGroupId = id;
                    SmuGroup group = new SmuGroup();
                    group.SmuGroupId = data.SmuGroupId;
                    group.SmuGroupName = data.SmuGroupName;
                    group.DateCreated = DateTime.Now;
                    group.CapturedBy = data.CapturedBy;
                    group.DistrictId = data.DistrictId;
                    group.RegionId = data.RegionId;
                    group.RegistartionDate = data.RegistartionDate;
                    group.SmuFacilitatorId = data.SmuFacilitatorId;
                    group.SmuOfficeId = data.SmuOfficeId;
                    group.SubcountyId = data.SubcountyId;
                    await _context.SmuGroup.AddAsync(group);
                    await _context.SaveChangesAsync();
                    _context.Entry(group).State = EntityState.Detached;
                    await _context.SaveChangesAsync();
                }
                else
                {
<<<<<<< HEAD
                  _context.Entry(GroupExists).CurrentValues.SetValues(data);
                  _context.Entry(GroupExists).State = EntityState.Modified;
                  await _context.SaveChangesAsync();
                  _context.Entry(GroupExists).State = EntityState.Detached;
                  await _context.SaveChangesAsync();
=======
                    if (
                        GroupExists.SmuGroupName != data.SmuGroupName ||
                        GroupExists.DistrictId != data.DistrictId ||
                        GroupExists.RegionId != data.RegionId ||
                        GroupExists.RegistartionDate != data.RegistartionDate ||
                        GroupExists.SmuFacilitatorId != data.SmuFacilitatorId ||
                        GroupExists.SmuOfficeId != data.SmuOfficeId ||
                        GroupExists.SubcountyId != data.SubcountyId
                        )
                    {
                        _context.Entry(GroupExists).CurrentValues.SetValues(data);
                        _context.Entry(GroupExists).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                        _context.Entry(GroupExists).State = EntityState.Detached;
                        await _context.SaveChangesAsync();
                    }
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699

                }
                if (data.SmuClientRegistrationForm != null && data.SmuClientRegistrationForm.Count > 0)
                {
                    foreach (var form in data.SmuClientRegistrationForm)
                    {
                        if ((!string.IsNullOrEmpty(form.SmuClientName) && form.ClientGenderId != null && form.SerialNumber != null) || form.ClientAgeRangeId != null)
                        {
                            var FormExists = await _context.SmuClientRegistrationForm.FirstOrDefaultAsync(o => o.ClientRegistrationFormId == form.ClientRegistrationFormId);
                            if (FormExists == null)
                            {
                                int id = 1;
                                var lastForm = await _context.SmuClientRegistrationForm.OrderByDescending(o => o.ClientRegistrationFormId).FirstOrDefaultAsync();
                                if (lastForm != null)
                                {
                                    id = (lastForm.ClientRegistrationFormId + 1);
                                }
                                form.ClientRegistrationFormId = id;
                                SmuClientRegistrationForm _form = new SmuClientRegistrationForm();
                                _form.ClientRegistrationFormId = form.ClientRegistrationFormId;
                                _form.DistrictId = data.DistrictId;
                                _form.RegionId = data.RegionId;
                                _form.SmuOfficeId = data.SmuOfficeId;
                                _form.RegistrationDate = form.RegistrationDate;
                                _form.SerialNumber = form.SerialNumber;
                                _form.SmuClientName = form.SmuClientName;
                                _form.ClientGenderId = form.ClientGenderId;
                                _form.ClientAgeRangeId = form.ClientAgeRangeId;
                                _form.ClientContact = form.ClientContact;
                                _form.SmuGroupId = data.SmuGroupId;
                                _form.SubCountyId = data.SubcountyId;
                                _form.DateCreated = DateTime.Now;
                                _form.CapturedBy = form.CapturedBy;
                                await _context.SmuClientRegistrationForm.AddAsync(_form);
                                await _context.SaveChangesAsync();
                                _context.Entry(_form).State = EntityState.Detached;
                                await _context.SaveChangesAsync();
                            }
                            else
                            {
                                if (
                                    FormExists.DistrictId != form.DistrictId ||
                                    FormExists.RegionId != form.RegionId ||
                                    FormExists.SmuOfficeId != form.SmuOfficeId ||
                                    FormExists.RegistrationDate != form.RegistrationDate ||
                                    FormExists.SerialNumber != form.SerialNumber ||
                                    FormExists.SmuClientName != form.SmuClientName ||
                                    FormExists.ClientGenderId != form.ClientGenderId ||
                                    FormExists.ClientAgeRangeId != form.ClientAgeRangeId ||
                                    FormExists.ClientContact != form.ClientContact
                                    )
                                {
                                    _context.Entry(FormExists).CurrentValues.SetValues(form);
                                    _context.Entry(FormExists).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                    _context.Entry(FormExists).State = EntityState.Detached;
                                    await _context.SaveChangesAsync();
                                }

                            }
<<<<<<< HEAD
                            //if (form.SmuAssessmentGuide != null && form.SmuAssessmentGuide.Count > 0)
                            //{
                            //    foreach (var guide in form.SmuAssessmentGuide)
                            //    {
                            //        var guideExists = await _context.SmuAssessmentGuide.FirstOrDefaultAsync(o => o.AssementGuideId == guide.AssementGuideId);
                            //        if (guideExists == null)
                            //        {
                            //            int id = 1;
                            //            var lastGuide = await _context.SmuAssessmentGuide.OrderByDescending(o => o.AssementGuideId).FirstOrDefaultAsync();
                            //            if (lastGuide != null)
                            //            {
                            //                id = (lastGuide.AssementGuideId + 1);
                            //            }
                            //            guide.AssementGuideId = id;
                            //            SmuAssessmentGuide mm = new SmuAssessmentGuide();
                            //            mm.AssementGuideId = guide.AssementGuideId;
                            //            mm.DateOfAssessment = guide.DateOfAssessment;
                            //            mm.StaffVolunteerName = guide.StaffVolunteerName;
                            //            mm.RespondantGenderId = guide.RespondantGenderId;
                            //            mm.RespondantAge = form.ClientAgeRangeId;
                            //            mm.SchoolNameOrPrisonName = guide.SchoolNameOrPrisonName;
                            //            mm.SubCountyId = form.SubCountyId;
                            //            mm.DistrictId = form.DistrictId;
                            //            mm.RegionId = form.RegionId;
                            //            mm.ExperiencedThoughtsOffDeadHurting = guide.ExperiencedThoughtsOffDeadHurting;
                            //            mm.ExperiencedGenderBasedViolence = guide.ExperiencedGenderBasedViolence;
                            //            mm.SmuGroupId = form.SmuGroupId;
                            //            mm.ClientRegistrationId = form.ClientRegistrationFormId;
                            //            mm.SuicideAssementQuestionOneResponse = guide.SuicideAssementQuestionOneResponse;
                            //            mm.SuicideAssementQuestionOneScore = guide.SuicideAssementQuestionOneScore;
                            //            mm.SuicideAssementQuestionTwoResponse = guide.SuicideAssementQuestionTwoResponse;
                            //            mm.SuicideAssementQuestionTwoScore = guide.SuicideAssementQuestionTwoScore;
                            //            mm.SuicideAssementQuestionThreeResponse = guide.SuicideAssementQuestionThreeResponse;
                            //            mm.SuicideAssementQuestionThreeScore = guide.SuicideAssementQuestionThreeScore;
                            //            mm.SuicideAssementQuestionFourResponse = guide.SuicideAssementQuestionFourResponse;
                            //            mm.SuicideAssementQuestionFourScore = guide.SuicideAssementQuestionFourScore;
                            //            mm.SuicideAssementQuestionFiveResponse = guide.SuicideAssementQuestionFiveResponse;
                            //            mm.SuicideAssementQuestionFiveScore = guide.SuicideAssementQuestionFiveScore;
                            //            mm.SuicideAssementQuestionSixResponse = guide.SuicideAssementQuestionSixResponse;
                            //            mm.SuicideAssementQuestionSixScore = guide.SuicideAssementQuestionSixScore;
                            //            mm.SuicideAssementQuestionSevenResponse = guide.SuicideAssementQuestionSevenResponse;
                            //            mm.SuicideAssementQuestionSevenScore = guide.SuicideAssementQuestionSevenScore;
                            //            mm.SuicideAssementQuestionEightResponse = guide.SuicideAssementQuestionEightResponse;
                            //            mm.SuicideAssementQuestionEightScore = guide.SuicideAssementQuestionEightScore;
                            //            mm.SuicideAssementQuestionNineResponse = guide.SuicideAssementQuestionNineResponse;
                            //            mm.SuicideAssementQuestionNineScore = guide.SuicideAssementQuestionNineScore;
                            //            mm.SuicideAssementQuestionTenResponse = guide.SuicideAssementQuestionTenResponse;
                            //            mm.SuicideAssementQuestionTenScore = guide.SuicideAssementQuestionTenScore;
                            //            mm.SuicideAssementTotalScore = guide.SuicideAssementTotalScore;
                            //            mm.ConsentObtainedYesNo = guide.ConsentObtainedYesNo;
                            //            mm.SmuProgramId = guide.SmuProgramId;
                            //        }
                            //        else
                            //        {
                            //            if
                            //         (
                            //         guideExists.DateOfAssessment != guide.DateOfAssessment ||
                            //         guideExists.StaffVolunteerName != guide.StaffVolunteerName ||
                            //         guideExists.RespondantGenderId != guide.RespondantGenderId ||
                            //         guideExists.RespondantAge != guide.RespondantAge ||
                            //         guideExists.SchoolNameOrPrisonName != guide.SchoolNameOrPrisonName ||
                            //         guideExists.SubCountyId != guide.SubCountyId ||
                            //         guideExists.DistrictId != guide.DistrictId ||
                            //         guideExists.RegionId != guide.RegionId ||
                            //         guideExists.ExperiencedThoughtsOffDeadHurting != guide.ExperiencedThoughtsOffDeadHurting ||
                            //         guideExists.ExperiencedGenderBasedViolence != guide.ExperiencedGenderBasedViolence ||
                            //         guideExists.SmuGroupId != guide.SmuGroupId ||
                            //         guideExists.ClientRegistrationId != guide.ClientRegistrationId ||
                            //         guideExists.SuicideAssementQuestionOneResponse != guide.SuicideAssementQuestionOneResponse ||
                            //         guideExists.SuicideAssementQuestionOneScore != guide.SuicideAssementQuestionOneScore ||
                            //         guideExists.SuicideAssementQuestionTwoResponse != guide.SuicideAssementQuestionTwoResponse ||
                            //         guideExists.SuicideAssementQuestionTwoScore != guide.SuicideAssementQuestionTwoScore ||
                            //         guideExists.SuicideAssementQuestionThreeResponse != guide.SuicideAssementQuestionThreeResponse ||
                            //         guideExists.SuicideAssementQuestionThreeScore != guide.SuicideAssementQuestionThreeScore ||
                            //         guideExists.SuicideAssementQuestionFourResponse != guide.SuicideAssementQuestionFourResponse ||
                            //         guideExists.SuicideAssementQuestionFourScore != guide.SuicideAssementQuestionFourScore ||
                            //         guideExists.SuicideAssementQuestionFiveResponse != guide.SuicideAssementQuestionFiveResponse ||
                            //         guideExists.SuicideAssementQuestionFiveScore != guide.SuicideAssementQuestionFiveScore ||
                            //         guideExists.SuicideAssementQuestionSixResponse != guide.SuicideAssementQuestionSixResponse ||
                            //         guideExists.SuicideAssementQuestionSixScore != guide.SuicideAssementQuestionSixScore ||
                            //         guideExists.SuicideAssementQuestionSevenResponse != guide.SuicideAssementQuestionSevenResponse ||
                            //         guideExists.SuicideAssementQuestionSevenScore != guide.SuicideAssementQuestionSevenScore ||
                            //         guideExists.SuicideAssementQuestionEightResponse != guide.SuicideAssementQuestionEightResponse ||
                            //         guideExists.SuicideAssementQuestionEightScore != guide.SuicideAssementQuestionEightScore ||
                            //         guideExists.SuicideAssementQuestionNineResponse != guide.SuicideAssementQuestionNineResponse ||
                            //         guideExists.SuicideAssementQuestionNineScore != guide.SuicideAssementQuestionNineScore ||
                            //         guideExists.SuicideAssementQuestionTenResponse != guide.SuicideAssementQuestionTenResponse ||
                            //         guideExists.SuicideAssementQuestionTenScore != guide.SuicideAssementQuestionTenScore ||
                            //         guideExists.SuicideAssementTotalScore != guide.SuicideAssementTotalScore ||
                            //         guideExists.ConsentObtainedYesNo != guide.ConsentObtainedYesNo ||
                            //         guideExists.SmuProgramId != guide.SmuProgramId ||
                            //         guideExists.SmuOfficeId != guide.SmuOfficeId
                            //         //guideExists.SMU
                            //         )
                            //            {
                            //                Console.WriteLine("we are reach save 1");
                            //                _context.Entry(guideExists).CurrentValues.SetValues(guide);
                            //                _context.Entry(guideExists).State = EntityState.Modified;
                            //                await _context.SaveChangesAsync();
                            //                _context.Entry(guideExists).State = EntityState.Detached;
                            //                await _context.SaveChangesAsync();
                            //            }
                            //        }
                            //        if (guide.SmuSucideAssementFormHeader != null && guide.SmuSucideAssementFormHeader.Count > 0)
                            //        {
                            //            foreach (var suicide in guide.SmuSucideAssementFormHeader)
                            //            {
                            //                var suicideExists = await _context.SmuSucideAssementFormHeader.FirstOrDefaultAsync(o => o.SucideAssessmentFormHeaderId == suicide.SucideAssessmentFormHeaderId);
                            //                if (suicideExists != null)
                            //                {
                            //                    if (
                            //                    suicideExists.SucideAssementResponseId != suicide.SucideAssementResponseId ||
                            //                    suicideExists.SuicideAssesmentScore != suicide.SuicideAssesmentScore
                            //                       )
                            //                    {
                            //                        Console.WriteLine("we are in the method");
                            //                        var entry = _context.ChangeTracker.Entries<SmuSucideAssementFormHeader>().FirstOrDefault(e => e.Entity.SucideAssessmentFormHeaderId == suicideExists.SucideAssessmentFormHeaderId);
                            //                        if (entry == null)
                            //                        {
                            //                            // Update the existing entity with the new values
                            //                            _context.Attach(suicideExists);
                            //                            _context.Entry(suicideExists).CurrentValues.SetValues(suicide);
                            //                            Console.WriteLine("we are reach save");
                            //                            await _context.SaveChangesAsync();
                            //                        }
                            //                        else
                            //                        {
                            //                            // If the entity is already tracked, you can directly modify its properties
                            //                            //  _context.Attach(fixedDepositExists);
                            //                            _context.Entry(suicideExists).CurrentValues.SetValues(suicide);
                            //                            await _context.SaveChangesAsync();
                            //                        }
                            //                    }

                            //                }
                            //            }
                            //        }
                            //    }
                            //}
                        }
                    }
                }

              

            }
            catch (DbUpdateException ex)
            {

=======
                            if (form.SmuAssessmentGuide != null && form.SmuAssessmentGuide.Count > 0)
                            {
                                foreach (var guide in form.SmuAssessmentGuide)
                                {
                                    var guideExists = await _context.SmuAssessmentGuide.FirstOrDefaultAsync(o => o.AssementGuideId == guide.AssementGuideId);
                                    if(guideExists == null)
                                    {
                                        int id = 1;
                                        var lastGuide = await _context.SmuAssessmentGuide.OrderByDescending(o => o.AssementGuideId).FirstOrDefaultAsync();
                                        if (lastGuide != null) 
                                        {
                                            id = (lastGuide.AssementGuideId + 1);
                                        }
                                        guide.AssementGuideId = id;
                                        SmuAssessmentGuide mm = new SmuAssessmentGuide();
                                        mm.AssementGuideId = guide.AssementGuideId;
                                        mm.DateOfAssessment = guide.DateOfAssessment;
                                        mm.StaffVolunteerName = guide.StaffVolunteerName;
                                        mm.RespondantGenderId = guide.RespondantGenderId;
                                        mm.RespondantAge = form.ClientAgeRangeId;
                                        mm.SchoolNameOrPrisonName = guide.SchoolNameOrPrisonName;
                                        mm.SubCountyId = form.SubCountyId;
                                        mm.DistrictId = form.DistrictId;
                                        mm.RegionId = form.RegionId;
                                        mm.ExperiencedThoughtsOffDeadHurting = guide.ExperiencedThoughtsOffDeadHurting;
                                        mm.ExperiencedGenderBasedViolence = guide.ExperiencedGenderBasedViolence;
                                        mm.SmuGroupId = form.SmuGroupId;
                                        mm.ClientRegistrationId = form.ClientRegistrationFormId;
                                        mm.SuicideAssementQuestionOneResponse = guide.SuicideAssementQuestionOneResponse;
                                        mm.SuicideAssementQuestionOneScore = guide.SuicideAssementQuestionOneScore;
                                        mm.SuicideAssementQuestionTwoResponse = guide.SuicideAssementQuestionTwoResponse;
                                        mm.SuicideAssementQuestionTwoScore = guide.SuicideAssementQuestionTwoScore;
                                        mm.SuicideAssementQuestionThreeResponse = guide.SuicideAssementQuestionThreeResponse;
                                        mm.SuicideAssementQuestionThreeScore = guide.SuicideAssementQuestionThreeScore;
                                        mm.SuicideAssementQuestionFourResponse = guide.SuicideAssementQuestionFourResponse;
                                        mm.SuicideAssementQuestionFourScore = guide.SuicideAssementQuestionFourScore;
                                        mm.SuicideAssementQuestionFiveResponse = guide.SuicideAssementQuestionFiveResponse;
                                        mm.SuicideAssementQuestionFiveScore = guide.SuicideAssementQuestionFiveScore;
                                        mm.SuicideAssementQuestionSixResponse = guide.SuicideAssementQuestionSixResponse;
                                        mm.SuicideAssementQuestionSixScore = guide.SuicideAssementQuestionSixScore;
                                        mm.SuicideAssementQuestionSevenResponse = guide.SuicideAssementQuestionSevenResponse;
                                        mm.SuicideAssementQuestionSevenScore = guide.SuicideAssementQuestionSevenScore;
                                        mm.SuicideAssementQuestionEightResponse = guide.SuicideAssementQuestionEightResponse;
                                        mm.SuicideAssementQuestionEightScore = guide.SuicideAssementQuestionEightScore;
                                        mm.SuicideAssementQuestionNineResponse = guide.SuicideAssementQuestionNineResponse;
                                        mm.SuicideAssementQuestionNineScore = guide.SuicideAssementQuestionNineScore;
                                        mm.SuicideAssementQuestionTenResponse = guide.SuicideAssementQuestionTenResponse;
                                        mm.SuicideAssementQuestionTenScore = guide.SuicideAssementQuestionTenScore;
                                        mm.SuicideAssementTotalScore = guide.SuicideAssementTotalScore;
                                        mm.ConsentObtainedYesNo = guide.ConsentObtainedYesNo;
                                        mm.SmuProgramId = guide.SmuProgramId;
                                    }
                                    else
                                    {
                                        if
                                     (
                                     guideExists.DateOfAssessment != guide.DateOfAssessment ||
                                     guideExists.StaffVolunteerName != guide.StaffVolunteerName ||
                                     guideExists.RespondantGenderId != guide.RespondantGenderId ||
                                     guideExists.RespondantAge != guide.RespondantAge ||
                                     guideExists.SchoolNameOrPrisonName != guide.SchoolNameOrPrisonName ||
                                     guideExists.SubCountyId != guide.SubCountyId ||
                                     guideExists.DistrictId != guide.DistrictId ||
                                     guideExists.RegionId != guide.RegionId ||
                                     guideExists.ExperiencedThoughtsOffDeadHurting != guide.ExperiencedThoughtsOffDeadHurting ||
                                     guideExists.ExperiencedGenderBasedViolence != guide.ExperiencedGenderBasedViolence ||
                                     guideExists.SmuGroupId != guide.SmuGroupId ||
                                     guideExists.ClientRegistrationId != guide.ClientRegistrationId ||
                                     guideExists.SuicideAssementQuestionOneResponse != guide.SuicideAssementQuestionOneResponse ||
                                     guideExists.SuicideAssementQuestionOneScore != guide.SuicideAssementQuestionOneScore ||
                                     guideExists.SuicideAssementQuestionTwoResponse != guide.SuicideAssementQuestionTwoResponse ||
                                     guideExists.SuicideAssementQuestionTwoScore != guide.SuicideAssementQuestionTwoScore ||
                                     guideExists.SuicideAssementQuestionThreeResponse != guide.SuicideAssementQuestionThreeResponse ||
                                     guideExists.SuicideAssementQuestionThreeScore != guide.SuicideAssementQuestionThreeScore ||
                                     guideExists.SuicideAssementQuestionFourResponse != guide.SuicideAssementQuestionFourResponse ||
                                     guideExists.SuicideAssementQuestionFourScore != guide.SuicideAssementQuestionFourScore ||
                                     guideExists.SuicideAssementQuestionFiveResponse != guide.SuicideAssementQuestionFiveResponse ||
                                     guideExists.SuicideAssementQuestionFiveScore != guide.SuicideAssementQuestionFiveScore ||
                                     guideExists.SuicideAssementQuestionSixResponse != guide.SuicideAssementQuestionSixResponse ||
                                     guideExists.SuicideAssementQuestionSixScore != guide.SuicideAssementQuestionSixScore ||
                                     guideExists.SuicideAssementQuestionSevenResponse != guide.SuicideAssementQuestionSevenResponse ||
                                     guideExists.SuicideAssementQuestionSevenScore != guide.SuicideAssementQuestionSevenScore ||
                                     guideExists.SuicideAssementQuestionEightResponse != guide.SuicideAssementQuestionEightResponse ||
                                     guideExists.SuicideAssementQuestionEightScore != guide.SuicideAssementQuestionEightScore ||
                                     guideExists.SuicideAssementQuestionNineResponse != guide.SuicideAssementQuestionNineResponse ||
                                     guideExists.SuicideAssementQuestionNineScore != guide.SuicideAssementQuestionNineScore ||
                                     guideExists.SuicideAssementQuestionTenResponse != guide.SuicideAssementQuestionTenResponse ||
                                     guideExists.SuicideAssementQuestionTenScore != guide.SuicideAssementQuestionTenScore ||
                                     guideExists.SuicideAssementTotalScore != guide.SuicideAssementTotalScore ||
                                     guideExists.ConsentObtainedYesNo != guide.ConsentObtainedYesNo ||
                                     guideExists.SmuProgramId != guide.SmuProgramId ||
                                     guideExists.SmuOfficeId != guide.SmuOfficeId
                                     //guideExists.SMU
                                     )
                                        {
                                            Console.WriteLine("we are reach save 1");
                                            _context.Entry(guideExists).CurrentValues.SetValues(guide);
                                            _context.Entry(guideExists).State = EntityState.Modified;
                                            await _context.SaveChangesAsync();
                                            _context.Entry(guideExists).State = EntityState.Detached;
                                            await _context.SaveChangesAsync();
                                        }
                                    }
                                    if(guide.SmuSucideAssementFormHeader != null && guide.SmuSucideAssementFormHeader.Count > 0)
                                    {
                                        foreach (var suicide in guide.SmuSucideAssementFormHeader)
                                        {
                                            var suicideExists = await _context.SmuSucideAssementFormHeader.FirstOrDefaultAsync(o=>o.SucideAssessmentFormHeaderId ==suicide.SucideAssessmentFormHeaderId);
                                            if(suicideExists != null)
                                            {
                                                if (
                                                suicideExists.SucideAssementResponseId != suicide.SucideAssementResponseId ||
                                                suicideExists.SuicideAssesmentScore != suicide.SuicideAssesmentScore
                                                   )
                                                {
                                                    Console.WriteLine("we are in the method");
                                                    var entry = _context.ChangeTracker.Entries<SmuSucideAssementFormHeader>().FirstOrDefault(e => e.Entity.SucideAssessmentFormHeaderId == suicideExists.SucideAssessmentFormHeaderId);
                                                    if (entry == null)
                                                    {
                                                        // Update the existing entity with the new values
                                                        _context.Attach(suicideExists);
                                                        _context.Entry(suicideExists).CurrentValues.SetValues(suicide);
                                                        Console.WriteLine("we are reach save");
                                                        await _context.SaveChangesAsync();
                                                    }
                                                    else
                                                    {
                                                        // If the entity is already tracked, you can directly modify its properties
                                                        //  _context.Attach(fixedDepositExists);
                                                        _context.Entry(suicideExists).CurrentValues.SetValues(suicide);
                                                        await _context.SaveChangesAsync();
                                                    }
                                                }
                                                
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (data.SmuAttendenceHeader != null && data.SmuAttendenceHeader.Count > 0)
                {
                    foreach (var attendanceHeader in data.SmuAttendenceHeader)
                    {
                        var attendanceHeaderExists = await _context.SmuAttendenceHeader.FirstOrDefaultAsync(o => o.AttendenceFormHeaderId == attendanceHeader.AttendenceFormHeaderId);
                        if (attendanceHeaderExists == null)
                        {
                            int id = 1;
                            var lastattendanceHeader = await _context.SmuAttendenceHeader.OrderByDescending(o => o.AttendenceFormHeaderId).FirstOrDefaultAsync();
                            if (lastattendanceHeader != null)
                            {
                                id = (lastattendanceHeader.AttendenceFormHeaderId + 1);
                            }
                            attendanceHeader.AttendenceFormHeaderId = id;
                            SmuAttendenceHeader m = new SmuAttendenceHeader();
                            m.AttendenceFormHeaderId = attendanceHeader.AttendenceFormHeaderId;
                            m.SmuGroupId = data.SmuGroupId;
                            m.AttendenceYearId = attendanceHeader.AttendenceYearId;
                            m.AttendenceCycleId = attendanceHeader.AttendenceCycleId;
                            m.DateCreated = DateTime.Now;
                            m.CapturedBy = attendanceHeader.CapturedBy;
                        }
                        else
                        {
                            if (
                               attendanceHeaderExists.SmuGroupId != attendanceHeader.SmuGroupId ||
                               attendanceHeaderExists.AttendenceYearId != attendanceHeader.AttendenceYearId ||
                               attendanceHeaderExists.AttendenceCycleId != attendanceHeader.AttendenceCycleId
                               )
                            {
                                Console.WriteLine("we are in the method");
                                var entry = _context.ChangeTracker.Entries<SmuSucideAssementFormHeader>().FirstOrDefault(e => e.Entity.SucideAssessmentFormHeaderId == attendanceHeaderExists.AttendenceFormHeaderId);
                                if (entry == null)
                                {
                                    // Update the existing entity with the new values
                                    _context.Attach(attendanceHeaderExists);
                                    _context.Entry(attendanceHeaderExists).CurrentValues.SetValues(attendanceHeader);
                                    Console.WriteLine("we are reach save");
                                    await _context.SaveChangesAsync();
                                }
                                else
                                {
                                  // If the entity is already tracked, you can directly modify its properties
                               //  .Attach(fixedDepositExists);
                                    _context.Entry(attendanceHeaderExists).CurrentValues.SetValues(attendanceHeader);
                                    await _context.SaveChangesAsync();
                                }
                            }

                        }
                    }
                }
              
            }
            catch (DbUpdateException ex)
            {
                //// Handle specific database update exceptions
                ////Console.WriteLine("Database update error: " + ex.Message);
                //int id = 1;
                //var lastGroup = await _context.ErrorLog.OrderByDescending(o => o.ErrorLogId).FirstOrDefaultAsync();
                //if (lastGroup != null)
                //{
                //    id = (lastGroup.ErrorLogId + 1);
                //}
                //data.SmuGroupId = id;
                //var errorLog = new ErrorLog
                //{
                //    ErrorLogId = id,
                //    ErrorDateTime = DateTime.Now,
                //    ErrorMessage = "Database update error: " + ex.Message
                //    // Other properties as needed
                //};
                //_context.ErrorLog.Add(errorLog);
                // await _context.SaveChangesAsync();
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
            }
            return _data;
        }
        public async Task<Response> SaveSmuAssessmentGuide(SmuAssessmentGuide data)
        {

            Response _data = new Response();
            try
            {
                var AssessmentExists = await _context.SmuAssessmentGuide.FirstOrDefaultAsync(o => o.AssementGuideId == data.AssementGuideId);
                if (AssessmentExists != null)
                {
                    if (
                       AssessmentExists.StaffVolunteerName != data.StaffVolunteerName ||
                       AssessmentExists.DateOfAssessment != data.DateOfAssessment ||
                       AssessmentExists.Ph9QuestionScore != data.Ph9QuestionScore ||
                       AssessmentExists.SuicideAssementTotalScore != data.SuicideAssementTotalScore ||
                       AssessmentExists.ConsentObtainedYesNo != data.ConsentObtainedYesNo ||
                       AssessmentExists.ExperiencedThoughtsOffDeadHurting != data.ExperiencedThoughtsOffDeadHurting ||
                       AssessmentExists.StressfulEventId != data.StressfulEventId ||
                       AssessmentExists.ExperiencedGenderBasedViolence != data.ExperiencedGenderBasedViolence
                       )
                    {
                        _context.Entry(AssessmentExists).CurrentValues.SetValues(data);
                        _context.Entry(AssessmentExists).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                        _context.Entry(AssessmentExists).State = EntityState.Detached;
                        await _context.SaveChangesAsync();
                    }
                }
<<<<<<< HEAD
                if (data.SmuAssessmentGuidePh9Questions != null && data.SmuAssessmentGuidePh9Questions.Count > 0)
=======
                if(data.SmuAssessmentGuidePh9Questions != null && data.SmuAssessmentGuidePh9Questions.Count > 0)
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
                {
                    foreach (var GuidePh9Questions in data.SmuAssessmentGuidePh9Questions)
                    {
                        if (GuidePh9Questions.SmuAssessmentGuidePh9QuestionsSored != null && GuidePh9Questions.Ph9QuestionHeaderId != null)
                        {
                            var GuidePh9QuestionsExists = await _context.SmuAssessmentGuidePh9Questions.FirstOrDefaultAsync(o => o.SmuAssessmentGuidePh9QuestionsId == GuidePh9Questions.SmuAssessmentGuidePh9QuestionsId);
                            if (GuidePh9QuestionsExists != null)
                            {
                                if (
                                    GuidePh9QuestionsExists.SmuAssessmentGuidePh9QuestionsSored != GuidePh9Questions.SmuAssessmentGuidePh9QuestionsSored ||
                                    GuidePh9QuestionsExists.Ph9QuestionHeaderId != GuidePh9Questions.Ph9QuestionHeaderId
                                    )
                                {
                                    _context.Entry(GuidePh9QuestionsExists).CurrentValues.SetValues(GuidePh9Questions);
                                    _context.Entry(GuidePh9QuestionsExists).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                    _context.Entry(GuidePh9QuestionsExists).State = EntityState.Detached;
                                    await _context.SaveChangesAsync();
                                }
                            }
                        }
                    }
                }
<<<<<<< HEAD
                if (data.SmuSucideAssementFormHeader != null && data.SmuSucideAssementFormHeader.Count > 0)
                {
                    foreach (var Suicide in data.SmuSucideAssementFormHeader)
                    {
                        if (Suicide.SuicideAssesmentScore != null && Suicide.SucideAssementResponseId != null)
=======
                if(data.SmuSucideAssementFormHeader != null && data.SmuSucideAssementFormHeader.Count > 0)
                {
                    foreach (var Suicide in data.SmuSucideAssementFormHeader)
                    {
                        if(Suicide.SuicideAssesmentScore != null && Suicide.SucideAssementResponseId != null)
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
                        {
                            var SuicideExists = await _context.SmuSucideAssementFormHeader.FirstOrDefaultAsync(o => o.SucideAssessmentFormHeaderId == Suicide.SucideAssessmentFormHeaderId);
                            if (SuicideExists != null)
                            {
                                if (
                                    SuicideExists.SuicideAssesmentScore != Suicide.SuicideAssesmentScore ||
                                    SuicideExists.SucideAssementResponseId != Suicide.SucideAssementResponseId
                                    )
                                {
                                    _context.Entry(SuicideExists).CurrentValues.SetValues(Suicide);
                                    _context.Entry(SuicideExists).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                    _context.Entry(SuicideExists).State = EntityState.Detached;
                                    await _context.SaveChangesAsync();
                                }
                            }
                        }
                    }
                }
            }
            catch (DbUpdateException ex)
            {
<<<<<<< HEAD

=======
                // Handle specific database update exceptions
                //Console.WriteLine("Database update error: " + ex.Message);
                //int id = 1;
                //var lastGroup = await _context.ErrorLog.OrderByDescending(o => o.ErrorLogId).FirstOrDefaultAsync();
                //if (lastGroup != null)
                //{
                //    id = (lastGroup.ErrorLogId + 1);
                //}
                //data.SmuGroupId = id;
                //var errorLog = new ErrorLog
                //{
                //    ErrorLogId = id,
                //    ErrorDateTime = DateTime.Now,
                //    ErrorMessage = "Database update error: " + ex.Message
                //    // Other properties as needed
                //};
                //_context.ErrorLog.Add(errorLog);
                //await _context.SaveChangesAsync();
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
            }
            return _data;
        }
        public async Task<Response> SaveSMUSafetyPlanningForm(SmuSafetyPlanningForm data)
        {
            Response _data = new Response();
            try
            {
                var SafetyPlanningExists = await _context.SmuSafetyPlanningForm.FirstOrDefaultAsync(o => o.SafetyPlanningFormId == data.SafetyPlanningFormId);
                if (SafetyPlanningExists != null)
                {
                    if (
                       SafetyPlanningExists.StaffVolunteerName != data.StaffVolunteerName ||
<<<<<<< HEAD
                       SafetyPlanningExists.InterviewDate != data.InterviewDate
=======
                       SafetyPlanningExists.InterviewDate != data.InterviewDate 
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
                       )
                    {
                        _context.Entry(SafetyPlanningExists).CurrentValues.SetValues(data);
                        _context.Entry(SafetyPlanningExists).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                        _context.Entry(SafetyPlanningExists).State = EntityState.Detached;
                        await _context.SaveChangesAsync();
                    }
                }
                if (data.SmuSafetyPlanningFormWarningSigns != null && data.SmuSafetyPlanningFormWarningSigns.Count > 0)
                {
                    foreach (var WarningSigns in data.SmuSafetyPlanningFormWarningSigns)
                    {
                        if (WarningSigns.WarningSignsNo != null && WarningSigns.WarningSignsDescription != null)
                        {
                            var WarningSignsExists = await _context.SmuSafetyPlanningFormWarningSigns.FirstOrDefaultAsync(o => o.WarningSignsId == WarningSigns.WarningSignsId);
                            if (WarningSignsExists != null)
                            {
                                if (
                                    WarningSignsExists.WarningSignsDescription != WarningSigns.WarningSignsDescription ||
                                    WarningSignsExists.WarningSignsNo != WarningSigns.WarningSignsNo
                                   )
                                {
                                    _context.Entry(WarningSignsExists).CurrentValues.SetValues(WarningSigns);
                                    _context.Entry(WarningSignsExists).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                    _context.Entry(WarningSignsExists).State = EntityState.Detached;
                                    await _context.SaveChangesAsync();
                                }
                            }
                            else
                            {
                                int id = 1;
                                var lastWarningSign = await _context.SmuSafetyPlanningFormWarningSigns.OrderByDescending(o => o.WarningSignsId).FirstOrDefaultAsync();
                                if (lastWarningSign != null)
                                {
                                    id = (lastWarningSign.WarningSignsId + 1);
                                }
                                WarningSigns.WarningSignsId = id;
                                SmuSafetyPlanningFormWarningSigns Wsigns = new SmuSafetyPlanningFormWarningSigns();
                                Wsigns.WarningSignsId = id;
                                Wsigns.SafetyPlanningFormId = data.SafetyPlanningFormId;
                                Wsigns.WarningSignsNo = WarningSigns.WarningSignsNo;
                                Wsigns.WarningSignsDescription = WarningSigns.WarningSignsDescription;
                                await _context.SmuSafetyPlanningFormWarningSigns.AddAsync(Wsigns);
                                await _context.SaveChangesAsync();
                                _context.Entry(Wsigns).State = EntityState.Detached;
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
                if (data.SmuSafetyPlanningFormPeopleProvideDistraction != null && data.SmuSafetyPlanningFormPeopleProvideDistraction.Count > 0)
                {
                    foreach (var Distractions in data.SmuSafetyPlanningFormPeopleProvideDistraction)
                    {
                        if (Distractions.PeopleProvideDistractionNo != null && Distractions.PeopleProvideDistractionName != null &&
                            Distractions.PeopleProvideDistractionPhone != null && Distractions.PeopleProvideDistractionPlace != null)
                        {
                            var DistractionsExists = await _context.SmuSafetyPlanningFormPeopleProvideDistraction.FirstOrDefaultAsync(o => o.PeopleProvideDistractionId == Distractions.PeopleProvideDistractionId);
                            if (DistractionsExists != null)
                            {
                                if (
                                    DistractionsExists.PeopleProvideDistractionNo != Distractions.PeopleProvideDistractionNo ||
                                    DistractionsExists.PeopleProvideDistractionPlace != Distractions.PeopleProvideDistractionPlace ||
                                    DistractionsExists.PeopleProvideDistractionName != Distractions.PeopleProvideDistractionName ||
                                    DistractionsExists.PeopleProvideDistractionPhone != Distractions.PeopleProvideDistractionPhone
                                    )
                                {
                                    _context.Entry(DistractionsExists).CurrentValues.SetValues(Distractions);
                                    _context.Entry(DistractionsExists).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                    _context.Entry(DistractionsExists).State = EntityState.Detached;
                                    await _context.SaveChangesAsync();
                                }
                            }
                            else
                            {
                                int id = 1;
                                var lastDistractions = await _context.SmuSafetyPlanningFormPeopleProvideDistraction.OrderByDescending(o => o.PeopleProvideDistractionId).FirstOrDefaultAsync();
                                if (lastDistractions != null)
                                {
                                    id = (lastDistractions.PeopleProvideDistractionId + 1);
                                }
                                Distractions.PeopleProvideDistractionId = id;
                                SmuSafetyPlanningFormPeopleProvideDistraction pDistraction = new SmuSafetyPlanningFormPeopleProvideDistraction();
                                pDistraction.PeopleProvideDistractionId = Distractions.PeopleProvideDistractionId;
                                pDistraction.SafetyPlanningFormId = data.SafetyPlanningFormId;
                                pDistraction.PeopleProvideDistractionNo = Distractions.PeopleProvideDistractionNo;
                                pDistraction.PeopleProvideDistractionName = Distractions.PeopleProvideDistractionName;
                                pDistraction.PeopleProvideDistractionPlace = Distractions.PeopleProvideDistractionPlace;
                                pDistraction.PeopleProvideDistractionPhone = Distractions.PeopleProvideDistractionPhone;
                                await _context.SmuSafetyPlanningFormPeopleProvideDistraction.AddAsync(pDistraction);
                                await _context.SaveChangesAsync();
                                _context.Entry(pDistraction).State = EntityState.Detached;
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
                if (data.SmuSafetyPlanningFormProfessionsAgenciesToContact != null && data.SmuSafetyPlanningFormProfessionsAgenciesToContact.Count > 0)
                {
                    foreach (var AgenciesToContact in data.SmuSafetyPlanningFormProfessionsAgenciesToContact)
                    {
                        if (AgenciesToContact.ClinicianName != null && AgenciesToContact.ClinicianName != null &&
                            AgenciesToContact.ClinicianPhoneNumber != null && AgenciesToContact.ClinicianPhoneNumber != null &&
                            AgenciesToContact.LocalUrgentCareServices != null && AgenciesToContact.LocalUrgentCareServices != null &&
                            AgenciesToContact.UrgentCareServicesAddress != null && AgenciesToContact.UrgentCareServicesAddress != null &&
                            AgenciesToContact.UrgentCareServicesPhone != null && AgenciesToContact.UrgentCareServicesPhone != null &&
                            AgenciesToContact.ProfessionalsAgenciesToContactDuringCrisisNo != null && AgenciesToContact.ProfessionalsAgenciesToContactDuringCrisisNo != null
                            )
                        {
                            var AgenciesToContactExists = await _context.SmuSafetyPlanningFormProfessionsAgenciesToContact.FirstOrDefaultAsync(o => o.ProfessionalsAgenciesToContactDuringCrisisId == AgenciesToContact.ProfessionalsAgenciesToContactDuringCrisisId);
                            if (AgenciesToContactExists != null)
                            {
                                if (
                                    AgenciesToContactExists.ClinicianName != AgenciesToContact.ClinicianName ||
                                    AgenciesToContactExists.ClinicianPhoneNumber != AgenciesToContact.ClinicianPhoneNumber ||
                                    AgenciesToContactExists.LocalUrgentCareServices != AgenciesToContact.LocalUrgentCareServices ||
                                    AgenciesToContactExists.UrgentCareServicesAddress != AgenciesToContact.UrgentCareServicesAddress ||
                                    AgenciesToContactExists.UrgentCareServicesPhone != AgenciesToContact.UrgentCareServicesPhone ||
                                    AgenciesToContactExists.ProfessionalsAgenciesToContactDuringCrisisNo != AgenciesToContact.ProfessionalsAgenciesToContactDuringCrisisNo
                                    )
                                {
                                    _context.Entry(AgenciesToContactExists).CurrentValues.SetValues(AgenciesToContact);
                                    _context.Entry(AgenciesToContactExists).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                    _context.Entry(AgenciesToContactExists).State = EntityState.Detached;
                                    await _context.SaveChangesAsync();
                                }
                            }
                            else
                            {
                                int id = 1;
                                var lastAgenciesToContact = await _context.SmuSafetyPlanningFormProfessionsAgenciesToContact.OrderByDescending(o => o.ProfessionalsAgenciesToContactDuringCrisisId).FirstOrDefaultAsync();
                                if (lastAgenciesToContact != null)
                                {
                                    id = (lastAgenciesToContact.ProfessionalsAgenciesToContactDuringCrisisId + 1);
                                }
                                AgenciesToContact.ProfessionalsAgenciesToContactDuringCrisisId = id;
                                SmuSafetyPlanningFormProfessionsAgenciesToContact _AgenciesToContact = new SmuSafetyPlanningFormProfessionsAgenciesToContact();
                                _AgenciesToContact.ProfessionalsAgenciesToContactDuringCrisisId = AgenciesToContact.ProfessionalsAgenciesToContactDuringCrisisId;
                                _AgenciesToContact.SafetyPlanningFormId = data.SafetyPlanningFormId;
                                _AgenciesToContact.ClinicianName = AgenciesToContact.ClinicianName;
                                _AgenciesToContact.ClinicianPhoneNumber = AgenciesToContact.ClinicianPhoneNumber;
                                _AgenciesToContact.LocalUrgentCareServices = AgenciesToContact.LocalUrgentCareServices;
                                _AgenciesToContact.UrgentCareServicesAddress = AgenciesToContact.UrgentCareServicesAddress;
                                _AgenciesToContact.UrgentCareServicesPhone = AgenciesToContact.UrgentCareServicesPhone;
                                _AgenciesToContact.ProfessionalsAgenciesToContactDuringCrisisNo = AgenciesToContact.ProfessionalsAgenciesToContactDuringCrisisNo;
                                await _context.SmuSafetyPlanningFormProfessionsAgenciesToContact.AddAsync(_AgenciesToContact);
                                await _context.SaveChangesAsync();
                                _context.Entry(_AgenciesToContact).State = EntityState.Detached;
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
                if (data.SmuSafetyPlanningFormPeopleToAskForHelp != null && data.SmuSafetyPlanningFormPeopleToAskForHelp.Count > 0)
                {
                    foreach (var AskForHelp in data.SmuSafetyPlanningFormPeopleToAskForHelp)
                    {
                        if (AskForHelp.PeopleToAskForHelpName != null && AskForHelp.PeopleToAskForHelpName != null &&
                            AskForHelp.PeopleToAskForHelpPhone != null && AskForHelp.PeopleToAskForHelpPhone != null &&
                            AskForHelp.PeopleToAskForHelpNo != null && AskForHelp.PeopleToAskForHelpNo != null
                            )
                        {
                            var AskForHelpExists = await _context.SmuSafetyPlanningFormPeopleToAskForHelp.FirstOrDefaultAsync(o => o.PeopleToAskForHelpId == AskForHelp.PeopleToAskForHelpId);
                            if (AskForHelpExists != null)
                            {
                                if (
                                    AskForHelpExists.PeopleToAskForHelpName != AskForHelp.PeopleToAskForHelpName ||
                                    AskForHelpExists.PeopleToAskForHelpPhone != AskForHelp.PeopleToAskForHelpPhone ||
                                    AskForHelpExists.PeopleToAskForHelpNo != AskForHelp.PeopleToAskForHelpNo
                                    )
                                {
                                    _context.Entry(AskForHelpExists).CurrentValues.SetValues(AskForHelp);
                                    _context.Entry(AskForHelpExists).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                    _context.Entry(AskForHelpExists).State = EntityState.Detached;
                                    await _context.SaveChangesAsync();
                                }
                            }
                            else
                            {
                                int id = 1;
                                var lastAskForHelp = await _context.SmuSafetyPlanningFormPeopleToAskForHelp.OrderByDescending(o => o.PeopleToAskForHelpId).FirstOrDefaultAsync();
                                if (lastAskForHelp != null)
                                {
                                    id = (lastAskForHelp.PeopleToAskForHelpId + 1);
                                }
                                AskForHelp.PeopleToAskForHelpId = id;
                                SmuSafetyPlanningFormPeopleToAskForHelp _AskForHelp = new SmuSafetyPlanningFormPeopleToAskForHelp();
                                _AskForHelp.PeopleToAskForHelpId = AskForHelp.PeopleToAskForHelpId;
                                _AskForHelp.SafetyPlanningFormId = data.SafetyPlanningFormId;
                                _AskForHelp.PeopleToAskForHelpName = AskForHelp.PeopleToAskForHelpName;
                                _AskForHelp.PeopleToAskForHelpPhone = AskForHelp.PeopleToAskForHelpPhone;
                                _AskForHelp.PeopleToAskForHelpNo = AskForHelp.PeopleToAskForHelpNo;
                                await _context.SmuSafetyPlanningFormPeopleToAskForHelp.AddAsync(_AskForHelp);
                                await _context.SaveChangesAsync();
                                _context.Entry(_AskForHelp).State = EntityState.Detached;
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
                if (data.SmuSafetyPlanningFormInternalCopingStrategies != null && data.SmuSafetyPlanningFormInternalCopingStrategies.Count > 0)
                {
                    foreach (var CopingStrategies in data.SmuSafetyPlanningFormInternalCopingStrategies)
                    {
                        if (CopingStrategies.InternalCopingStrategiesNo != null && CopingStrategies.InternalCopingStrategies != null)
                        {
                            var CopingStrategiesExists = await _context.SmuSafetyPlanningFormInternalCopingStrategies.FirstOrDefaultAsync(o => o.InternalCopingStrategiesId == CopingStrategies.InternalCopingStrategiesId);
                            if (CopingStrategiesExists != null)
                            {
                                if (
                                    CopingStrategiesExists.InternalCopingStrategiesNo != CopingStrategies.InternalCopingStrategiesNo ||
                                    CopingStrategiesExists.InternalCopingStrategies != CopingStrategies.InternalCopingStrategies
                                    )
                                {
                                    _context.Entry(CopingStrategiesExists).CurrentValues.SetValues(CopingStrategies);
                                    _context.Entry(CopingStrategiesExists).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                    _context.Entry(CopingStrategiesExists).State = EntityState.Detached;
                                    await _context.SaveChangesAsync();
                                }
                            }
                            else
                            {
                                int id = 1;
                                var lastWarningSign = await _context.SmuSafetyPlanningFormInternalCopingStrategies.OrderByDescending(o => o.InternalCopingStrategiesId).FirstOrDefaultAsync();
                                if (lastWarningSign != null)
                                {
                                    id = (lastWarningSign.InternalCopingStrategiesId + 1);
                                }
                                CopingStrategies.InternalCopingStrategiesId = id;
                                SmuSafetyPlanningFormInternalCopingStrategies Wsigns = new SmuSafetyPlanningFormInternalCopingStrategies();
                                Wsigns.InternalCopingStrategiesId = id;
                                CopingStrategies.SafetyPlanningFormId = data.SafetyPlanningFormId;
                                Wsigns.InternalCopingStrategiesNo = CopingStrategies.InternalCopingStrategiesNo;
                                Wsigns.InternalCopingStrategies = CopingStrategies.InternalCopingStrategies;
                                await _context.SmuSafetyPlanningFormInternalCopingStrategies.AddAsync(Wsigns);
                                await _context.SaveChangesAsync();
                                _context.Entry(Wsigns).State = EntityState.Detached;
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
            }
            catch (DbUpdateException ex)
            {
<<<<<<< HEAD

=======
                //int id = 1;
                //var lastGroup = await _context.ErrorLog.OrderByDescending(o => o.ErrorLogId).FirstOrDefaultAsync();
                //if (lastGroup != null)
                //{
                //    id = (lastGroup.ErrorLogId + 1);
                //}
                //data.SmuGroupId = id;
                //var errorLog = new ErrorLog
                //{
                //    ErrorLogId = id,
                //    ErrorDateTime = DateTime.Now,
                //    ErrorMessage = "Database update error: " + ex.Message
                //};
                //_context.ErrorLog.Add(errorLog);
                //await _context.SaveChangesAsync();
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
            }
            return _data;
        }
        public async Task<Response> SaveSmuPreGroupGuide(SmuPreGroupGuide data)
        {
            Response _data = new Response();
            try
            {
                var PreGroupGuideExists = await _context.SmuPreGroupGuide.FirstOrDefaultAsync(o => o.SmuPreGroupGuideId == data.SmuPreGroupGuideId);
                if (PreGroupGuideExists != null)
                {
                    if (
                       PreGroupGuideExists.NameOfVolunter != data.NameOfVolunter ||
                       PreGroupGuideExists.DateOfAssessment != data.DateOfAssessment
                       )
                    {
                        _context.Entry(PreGroupGuideExists).CurrentValues.SetValues(data);
                        _context.Entry(PreGroupGuideExists).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                        _context.Entry(PreGroupGuideExists).State = EntityState.Detached;
                        await _context.SaveChangesAsync();
                    }
                }
                if (data.SmuPreGroupGuidePh9Questions != null && data.SmuPreGroupGuidePh9Questions.Count > 0)
                {
                    foreach (var Ph9Questions in data.SmuPreGroupGuidePh9Questions)
                    {
<<<<<<< HEAD
                        if (Ph9Questions.Ph9QuestionHeaderId != null && Ph9Questions.SerialNumber != null && Ph9Questions.SmuPreGroupGuidePh9QuestionsSored != null)
=======
                        if (Ph9Questions.Ph9QuestionHeaderId != null &&  Ph9Questions.SerialNumber != null && Ph9Questions.SmuPreGroupGuidePh9QuestionsSored != null)
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
                        {
                            var Ph9QuestionsExists = await _context.SmuPreGroupGuidePh9Questions.FirstOrDefaultAsync(o => o.Ph9QuestionsId == Ph9Questions.Ph9QuestionsId);
                            if (Ph9QuestionsExists != null)
                            {
                                if (
                                    Ph9QuestionsExists.SmuPreGroupGuidePh9QuestionsSored != Ph9Questions.SmuPreGroupGuidePh9QuestionsSored ||
                                    Ph9QuestionsExists.Ph9QuestionHeaderId != Ph9Questions.Ph9QuestionHeaderId ||
                                     Ph9QuestionsExists.SerialNumber != Ph9Questions.SerialNumber
                                   )
                                {
                                    _context.Entry(Ph9QuestionsExists).CurrentValues.SetValues(Ph9Questions);
                                    _context.Entry(Ph9QuestionsExists).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                    _context.Entry(Ph9QuestionsExists).State = EntityState.Detached;
                                    await _context.SaveChangesAsync();
                                }
                            }
<<<<<<< HEAD

                        }
                    }
                }

            }
            catch (DbUpdateException ex)
            {

=======
                           
                        }
                    }
                }
              
            }
            catch (DbUpdateException ex)
            {
                //int id = 1;
                //var lastGroup = await _context.ErrorLog.OrderByDescending(o => o.ErrorLogId).FirstOrDefaultAsync();
                //if (lastGroup != null)
                //{
                //    id = (lastGroup.ErrorLogId + 1);
                //}
                //data.SmuGroupId = id;
                //var errorLog = new ErrorLog
                //{
                //    ErrorLogId = id,
                //    ErrorDateTime = DateTime.Now,
                //    ErrorMessage = "Database update error: " + ex.Message
                //};
                //_context.ErrorLog.Add(errorLog);
                //await _context.SaveChangesAsync();
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
            }
            return _data;
        }
        public async Task<Response> SaveSmuAttendenceHeader(SmuAttendenceHeader data)
        {
            Response _data = new Response();
            try
            {
                var AttendenceHeaderExists = await _context.SmuAttendenceHeader.FirstOrDefaultAsync(o => o.AttendenceFormHeaderId == data.AttendenceFormHeaderId);
                if (AttendenceHeaderExists != null)
                {
                    if (
                       AttendenceHeaderExists.AttendenceCycleId != data.AttendenceCycleId ||
                       AttendenceHeaderExists.AttendenceYearId != data.AttendenceYearId ||
                       AttendenceHeaderExists.SessionOneDate != data.SessionOneDate ||
                       AttendenceHeaderExists.SessionTwoDate != data.SessionTwoDate ||
                       AttendenceHeaderExists.SessionThreeDate != data.SessionThreeDate ||
                       AttendenceHeaderExists.SessionFourDate != data.SessionFourDate ||
                       AttendenceHeaderExists.SessionFiveDate != data.SessionFiveDate ||
                       AttendenceHeaderExists.SessionSixDate != data.SessionSixDate
                       )
                    {
                        _context.Entry(AttendenceHeaderExists).CurrentValues.SetValues(data);
                        _context.Entry(AttendenceHeaderExists).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                        _context.Entry(AttendenceHeaderExists).State = EntityState.Detached;
                        await _context.SaveChangesAsync();
                    }
                }
                if (data.SmuAttendenceFormDetail != null && data.SmuAttendenceFormDetail.Count > 0)
                {
                    foreach (var AttendenceFormDetail in data.SmuAttendenceFormDetail)
                    {
                        var AttendenceFormDetailExists = await _context.SmuAttendenceFormDetail.FirstOrDefaultAsync(o => o.AttendenceFormDetailId == AttendenceFormDetail.AttendenceFormDetailId);
                        if (AttendenceFormDetailExists != null)
                        {
                            if (
                                AttendenceFormDetailExists.KaguguIdSessionOne != AttendenceFormDetail.KaguguIdSessionOne ||
                                AttendenceFormDetailExists.KaguguIdSessionTwo != AttendenceFormDetail.KaguguIdSessionTwo ||
                                AttendenceFormDetailExists.KaguguIdSessionThree != AttendenceFormDetail.KaguguIdSessionThree ||
                                AttendenceFormDetailExists.KaguguIdSessionFour != AttendenceFormDetail.KaguguIdSessionFour ||
                                AttendenceFormDetailExists.KaguguIdSessionFive != AttendenceFormDetail.KaguguIdSessionFive ||
                                AttendenceFormDetailExists.KaguguIdSessionSix != AttendenceFormDetail.KaguguIdSessionSix ||
                                AttendenceFormDetailExists.OtherReasoneSessionOne != AttendenceFormDetail.OtherReasoneSessionOne ||
                                AttendenceFormDetailExists.OtherReasoneSessionTwo != AttendenceFormDetail.OtherReasoneSessionTwo ||
                                AttendenceFormDetailExists.OtherReasoneSessionThree != AttendenceFormDetail.OtherReasoneSessionThree ||
                                AttendenceFormDetailExists.OtherReasoneSessionFour != AttendenceFormDetail.OtherReasoneSessionFour ||
                                AttendenceFormDetailExists.OtherReasoneSessionFive != AttendenceFormDetail.OtherReasoneSessionFive ||
                                AttendenceFormDetailExists.OtherReasoneSessionSix != AttendenceFormDetail.OtherReasoneSessionSix ||
                                AttendenceFormDetailExists.ReasonSessionOne != AttendenceFormDetail.ReasonSessionOne ||
                                AttendenceFormDetailExists.ReasonSessionTwo != AttendenceFormDetail.ReasonSessionTwo ||
                                AttendenceFormDetailExists.ReasonSessionThree != AttendenceFormDetail.ReasonSessionThree ||
                                AttendenceFormDetailExists.ReasonSessionFour != AttendenceFormDetail.ReasonSessionFour ||
                                AttendenceFormDetailExists.ReasonSessionFive != AttendenceFormDetail.ReasonSessionFive ||
                                AttendenceFormDetailExists.ReasonSessionSix != AttendenceFormDetail.ReasonSessionSix ||
                                AttendenceFormDetailExists.AttendedIdSessionOne != AttendenceFormDetail.AttendedIdSessionOne ||
                                AttendenceFormDetailExists.AttendedIdSessionTwo != AttendenceFormDetail.AttendedIdSessionTwo ||
                                AttendenceFormDetailExists.AttendedIdSessionThree != AttendenceFormDetail.AttendedIdSessionThree ||
                                AttendenceFormDetailExists.AttendedIdSessionFour != AttendenceFormDetail.AttendedIdSessionFour ||
                                AttendenceFormDetailExists.AttendedIdSessionFive != AttendenceFormDetail.AttendedIdSessionFive ||
                                AttendenceFormDetailExists.AttendedIdSessionSix != AttendenceFormDetail.AttendedIdSessionSix ||
                                AttendenceFormDetailExists.SerialNumber != AttendenceFormDetail.SerialNumber
                               )
                            {
                                _context.Entry(AttendenceFormDetailExists).CurrentValues.SetValues(AttendenceFormDetail);
                                _context.Entry(AttendenceFormDetailExists).State = EntityState.Modified;
                                await _context.SaveChangesAsync();
                                _context.Entry(AttendenceFormDetailExists).State = EntityState.Detached;
                                await _context.SaveChangesAsync();
                            }
                        }

                    }
                }

            }
            catch (DbUpdateException ex)
            {
                //int id = 1;
                //var lastGroup = await _context.ErrorLog.OrderByDescending(o => o.ErrorLogId).FirstOrDefaultAsync();
                //if (lastGroup != null)
                //{
                //    id = (lastGroup.ErrorLogId + 1);
                //}
                //data.SmuGroupId = id;
                //var errorLog = new ErrorLog
                //{
                //    ErrorLogId = id,
                //    ErrorDateTime = DateTime.Now,
                //    ErrorMessage = "Database update error: " + ex.Message
                //};
                //_context.ErrorLog.Add(errorLog);
                //await _context.SaveChangesAsync();
            }
            return _data;
        }
        public async Task<Response> SaveSmuTerminantionGuide(SmuTerminantionGuide data)
        {
            Response _data = new Response();
            try
            {
                var TerminationExists = await _context.SmuTerminantionGuide.FirstOrDefaultAsync(o => o.SmuTerminantionGuideId == data.SmuTerminantionGuideId);
                if (TerminationExists != null)
                {
                    if (
                      TerminationExists.NameOfVolunter != data.NameOfVolunter ||
                      TerminationExists.DateOfAssessment != data.DateOfAssessment
                       )
                    {
                        _context.Entry(TerminationExists).CurrentValues.SetValues(data);
                        _context.Entry(TerminationExists).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                        _context.Entry(TerminationExists).State = EntityState.Detached;
                        await _context.SaveChangesAsync();
                    }
                }
                if (data.SmuTerminantionGuidePh9Questions != null && data.SmuTerminantionGuidePh9Questions.Count > 0)
                {
                    foreach (var TerminantionPh9Qns in data.SmuTerminantionGuidePh9Questions)
                    {
<<<<<<< HEAD
                        if (TerminantionPh9Qns.SmuTerminantionGuidePh9QuestionsSored != null && TerminantionPh9Qns.Ph9QuestionHeaderId != null)
=======
                        if(TerminantionPh9Qns.SmuTerminantionGuidePh9QuestionsSored != null && TerminantionPh9Qns.Ph9QuestionHeaderId != null)
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
                        {
                            var TerminantionPh9QnsExists = await _context.SmuTerminantionGuidePh9Questions.FirstOrDefaultAsync(o => o.SmuTerminantionGuidePh9QuestionsId == TerminantionPh9Qns.SmuTerminantionGuidePh9QuestionsId);
                            if (TerminantionPh9QnsExists != null)
                            {
                                if (
                                    TerminantionPh9QnsExists.SmuTerminantionGuidePh9QuestionsSored != TerminantionPh9Qns.SmuTerminantionGuidePh9QuestionsSored ||
                                    TerminantionPh9QnsExists.Ph9QuestionHeaderId != TerminantionPh9Qns.Ph9QuestionHeaderId
                                   )
                                {
                                    _context.Entry(TerminantionPh9QnsExists).CurrentValues.SetValues(TerminantionPh9Qns);
                                    _context.Entry(TerminantionPh9QnsExists).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                    _context.Entry(TerminantionPh9QnsExists).State = EntityState.Detached;
                                    await _context.SaveChangesAsync();
                                }
                            }
                        }
                    }
                }

            }
            catch (DbUpdateException ex)
            {
                //int id = 1;
                //var lastGroup = await _context.ErrorLog.OrderByDescending(o => o.ErrorLogId).FirstOrDefaultAsync();
                //if (lastGroup != null)
                //{
                //    id = (lastGroup.ErrorLogId + 1);
                //}
                //data.SmuGroupId = id;
                //var errorLog = new ErrorLog
                //{
                //    ErrorLogId = id,
                //    ErrorDateTime = DateTime.Now,
                //    ErrorMessage = "Database update error: " + ex.Message
                //};
                //_context.ErrorLog.Add(errorLog);
                //await _context.SaveChangesAsync();
            }
            return _data;
        }
<<<<<<< HEAD
        public async Task<byte[]> GenerateClientRegistrationReportAsync(DateTime? startDate, DateTime? endDate, string? smuGroupIds = "", string? regionIds = "", string? districtIds = "", string? subcountyIds = "", string? clientAgeRangeIds = "", string? smuOfficeIds = "", string? smuFacilitatorIds = "")
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;

                var data = _context.SmuViewClientRegistrationForm.AsQueryable();

                if (startDate.HasValue)
                    data = data.Where(p => p.RegistrationDate >= startDate.Value);
                if (endDate.HasValue)
                    data = data.Where(p => p.RegistrationDate <= endDate.Value);

                if (!string.IsNullOrEmpty(smuGroupIds))
                {
                    var groupIds = smuGroupIds.Split(',').Select(int.Parse).ToList();
                    data = data.Where(p => groupIds.Contains(p.SmuGroupId.Value));
                }
                if (!string.IsNullOrEmpty(regionIds))
                {
                    var regionIdList = regionIds.Split(',').Select(int.Parse).ToList();
                    data = data.Where(p => regionIdList.Contains(p.RegionId.Value));
                }
                if (!string.IsNullOrEmpty(districtIds))
                {
                    var districtIdList = districtIds.Split(',').Select(int.Parse).ToList();
                    data = data.Where(p => districtIdList.Contains(p.DistrictId.Value));
                }
                if (!string.IsNullOrEmpty(subcountyIds))
                {
                    var subcountyIdList = subcountyIds.Split(',').Select(int.Parse).ToList();
                    data = data.Where(p => subcountyIdList.Contains(p.SubCountyId.Value));
                }
                if (!string.IsNullOrEmpty(clientAgeRangeIds))
                {
                    var ageRangeIds = clientAgeRangeIds.Split(',').Select(int.Parse).ToList();
                    data = data.Where(p => ageRangeIds.Contains(p.ClientAgeRangeId.Value));
                }
                if (!string.IsNullOrEmpty(smuOfficeIds))
                {
                    var officeIds = smuOfficeIds.Split(',').Select(int.Parse).ToList();
                    data = data.Where(p => officeIds.Contains(p.SmuOfficeId.Value));
                }
                if (!string.IsNullOrEmpty(smuFacilitatorIds))
                {
                    var facilitatorIds = smuFacilitatorIds.Split(',').Select(int.Parse).ToList();
                    data = data.Where(p => facilitatorIds.Contains(p.SmuFacilitatorId.Value));
                }

                // Fetch data into a list asynchronously
                var groupedData = await data.OrderBy(o => o.SerialNumber).ToListAsync();

                // Perform the GroupBy operation on the fetched list
               // var groupedData = dataList.GroupBy(p => p.SmuGroupId);

                IWorkbook workbook = application.Workbooks.Create(groupedData.GroupBy(h=>h.SmuGroupName).Count());
                //application.Workbooks.Create(headerData.GroupBy(h => h.SmuGroupName).Count());
                int sheetIndex = 0;

                foreach (var group in groupedData.GroupBy(h => h.SmuGroupName))
                {
                    IWorksheet worksheet = workbook.Worksheets[sheetIndex];
                    worksheet.Name = group.Key.ToString();

                    string wwwRootPath = _hostingEnvironment.WebRootPath;
                    string imagePath1 = Path.Combine(wwwRootPath, "Login", "images", "smu.png");
                    string imagePath2 = Path.Combine(wwwRootPath, "Login", "images", "smu.png");
                    if (File.Exists(imagePath1))
                    {
                        using (FileStream imageStream = new FileStream(imagePath1, FileMode.Open, FileAccess.Read))
                        {
                            // Add image and fit it within A1:E2
                            worksheet.Pictures.AddPicture(1, 1, imageStream, 16, 4);
                        }
                    }

                    worksheet.Range["B3:D3"].Merge();
                    worksheet.Range["B3"].Text = "SM001 : CLIENT REGISTRATION FORM";
                    worksheet.Range["B3"].CellStyle.Font.Size = 20;
                    worksheet.Range["B3"].CellStyle.Font.Bold = true;
                    worksheet.Range["B3"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;

                    var firstItem = group.FirstOrDefault();
                    if (firstItem != null)
                    {
                        worksheet.Range["B4"].Text = $"District: {firstItem.DistrictDescription}";
                        worksheet.Range["B4"].CellStyle.Font.Bold = true;
                        worksheet.Range["C4"].Text = $"Region: {firstItem.RegionDescription}";
                        worksheet.Range["C4"].CellStyle.Font.Bold = true;
                        worksheet.Range["D4"].Text = $"Office: {firstItem.OfficeName}";
                        worksheet.Range["D4"].CellStyle.Font.Bold = true;

                        worksheet.Range["B5"].Text = $"Registration Date: {firstItem.RegistrationDate:dd/MM/yyyy}";
                        worksheet.Range["B5"].CellStyle.Font.Bold = true;
                        worksheet.Range["C5"].Text = $"Group: {firstItem.SmuGroupName}";
                        worksheet.Range["C5"].CellStyle.Font.Bold = true;
                        worksheet.Range["D5"].Text = $"Name of facilitator: {firstItem.SmuFacilitatorName}";
                        worksheet.Range["D5"].CellStyle.Font.Bold = true;
                    }

                    worksheet.Range["A7"].Text = "SN";
                    worksheet.Range["A7"].CellStyle.Font.Bold = true;
                    worksheet.Range["A7"].CellStyle.Color = Syncfusion.Drawing.Color.LightYellow;
                    worksheet.Range["B7"].Text = "CLIENT NAME";
                    worksheet.Range["B7"].CellStyle.Font.Bold = true;
                    worksheet.Range["B7"].CellStyle.Color = Syncfusion.Drawing.Color.LightYellow;
                    worksheet.Range["C7"].Text = "GENDER";
                    worksheet.Range["C7"].CellStyle.Color = Syncfusion.Drawing.Color.LightYellow;
                    worksheet.Range["C7"].CellStyle.Font.Bold = true;
                    worksheet.Range["D7"].Text = "AGE RANGE";
                    worksheet.Range["D7"].CellStyle.Font.Bold = true;
                    worksheet.Range["D7"].CellStyle.Color = Syncfusion.Drawing.Color.LightYellow;
                    worksheet.Range["E7"].Text = "CONTACT NUMBER";
                    worksheet.Range["E7"].CellStyle.Font.Bold = true;
                    worksheet.Range["E7"].CellStyle.Color = Syncfusion.Drawing.Color.LightYellow;

                    int row = 8;
                    foreach (var item in group)
                    {
                        worksheet.Range["A" + row].Text = item.SerialNumber.ToString();
                        worksheet.Range["B" + row].Text = item.SmuClientName;
                        worksheet.Range["C" + row].Text = item.ClientGenderId;
                        worksheet.Range["D" + row].Text = item.AgeGroup;
                        worksheet.Range["E" + row].Text = item.ClientContact;
                        row++;
                    }

                    worksheet.UsedRange.AutofitColumns();
                    sheetIndex++;
                }

                using (MemoryStream stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }
        public async Task<byte[]> GenerateTherapySessionReportAsync(DateTime? startDate, DateTime? endDate, string? smuGroupIds = "", string? regionIds = "", string? districtIds = "", string? subcountyIds = "", string? clientAgeRangeIds = "", string? smuOfficeIds = "", string? smuFacilitatorIds = "")
        {
            var datasource1 = _context.SmuViewAttendenceHeader.AsQueryable();
            var datasource2 = _context.SmuViewAttendenceFormDetail.AsQueryable();

            // Apply filters based on provided parameters
            if (startDate.HasValue)
                datasource1 = datasource1.Where(h => h.SessionOneDate >= startDate || h.SessionTwoDate >= startDate || h.SessionThreeDate >= startDate || h.SessionFourDate >= startDate || h.SessionFiveDate >= startDate || h.SessionSixDate >= startDate);

            if (endDate.HasValue)
                datasource1 = datasource1.Where(h => h.SessionOneDate <= endDate || h.SessionTwoDate <= endDate || h.SessionThreeDate <= endDate || h.SessionFourDate <= endDate || h.SessionFiveDate <= endDate || h.SessionSixDate <= endDate);

            if (!string.IsNullOrEmpty(smuGroupIds))
            {
                var smuGroupIdsList = smuGroupIds.Split(',').Select(int.Parse).ToList();
                datasource1 = datasource1.Where(h => smuGroupIdsList.Contains(h.SmuGroupId.Value));
            }
            if (!string.IsNullOrEmpty(regionIds))
            {
                var regionIdsList = regionIds.Split(',').Select(int.Parse).ToList();
                datasource1 = datasource1.Where(h => regionIdsList.Contains(h.RegionId.Value));
            }
            if (!string.IsNullOrEmpty(districtIds))
            {
                var districtIdsList = districtIds.Split(',').Select(int.Parse).ToList();
                datasource1 = datasource1.Where(h => districtIdsList.Contains(h.DistrictId.Value));
            }
            if (!string.IsNullOrEmpty(subcountyIds))
            {
                var subcountyIdsList = subcountyIds.Split(',').Select(int.Parse).ToList();
                datasource1 = datasource1.Where(h => subcountyIdsList.Contains(h.SubcountyId.Value));
            }
            if (!string.IsNullOrEmpty(smuOfficeIds))
            {
                var smuOfficeIdsList = smuOfficeIds.Split(',').Select(int.Parse).ToList();
                datasource1 = datasource1.Where(h => smuOfficeIdsList.Contains(h.SmuOfficeId.Value));
            }
            if (!string.IsNullOrEmpty(smuFacilitatorIds))
            {
                var smuFacilitatorIdsList = smuFacilitatorIds.Split(',').Select(int.Parse).ToList();
                datasource1 = datasource1.Where(h => smuFacilitatorIdsList.Contains(h.SmuFacilitatorId.Value));
            }
            var headerData = await datasource1.ToListAsync();
            var detailData = await datasource2.ToListAsync();

            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;

                // Create a new workbook with a worksheet
                IWorkbook workbook = application.Workbooks.Create(headerData.GroupBy(h => h.SmuGroupName).Count());
                int sheetIndex = 0;

                foreach (var group in headerData.GroupBy(h => h.SmuGroupName))
                {
                    IWorksheet worksheet = workbook.Worksheets[sheetIndex++];
                    worksheet.Name = group.Key;

                    string wwwRootPath = _hostingEnvironment.WebRootPath;
                    string imagePath1 = Path.Combine(wwwRootPath, "Login", "images", "smu.png");
                    if (File.Exists(imagePath1))
                    {
                        using (FileStream imageStream = new FileStream(imagePath1, FileMode.Open, FileAccess.Read))
                        {
                            // Add image and fit it within H1:R2
                            worksheet.Pictures.AddPicture(1, 8, imageStream, 16, 9);
                        }
                    }

                    // Header
                    worksheet.Range["B1"].Text = "Group Name: " + group.Key;
                    worksheet.Range["B2"].Text = "Year: " + group.First().FinancialYearDesc;
                    worksheet.Range["B3"].Text = "Cycle: " + group.First().CycleDescription;

                    // Column Headers
                    worksheet.Range["A5"].Text = "S/N";
                    worksheet.Range["B5"].Text = "CLIENT NAME";
                    worksheet.Range["C5"].Text = "Telephone NO.";
                    worksheet.Range["D5"].Text = "CLIENT CODE";
                    worksheet.Range["A5:D5"].CellStyle.Font.Bold = true;

                    // Session Headers
                    for (int session = 1; session <= 6; session++)
                    {
                        int baseCol = 5 + (session - 1) * 4;
                        worksheet.Range[4, baseCol + 1].Text = $"Session {session}";
                        worksheet.Range[4, baseCol + 1, 4, baseCol + 3].Merge();
                        worksheet.Range[4, baseCol + 1, 4, baseCol + 3].CellStyle.Font.Bold = true;

                        var sessionDateProp = group.First().GetType().GetProperty($"Session_{session}_Date");
                        var sessionDateValue = sessionDateProp?.GetValue(group.First())?.ToString();

                        worksheet.Range[5, baseCol + 1].Text = "Session Date:";
                        worksheet.Range[5, baseCol + 1, 5, baseCol + 3].Merge();
                        worksheet.Range[5, baseCol + 1, 5, baseCol + 3].Text = sessionDateValue;
                        worksheet.Range[5, baseCol + 1, 5, baseCol + 3].CellStyle.Font.Bold = true;

                        worksheet.Range[6, baseCol + 1].Text = "ATTENDED?";
                        worksheet.Range[6, baseCol + 2].Text = "KAGUGU";
                        worksheet.Range[6, baseCol + 3].Text = "REASONS";
                        worksheet.Range[6, baseCol + 1, 6, baseCol + 3].CellStyle.Font.Bold = true;
                    }

                    // Populate Data
                    int row = 7;
                    foreach (var detail in detailData.Where(d => d.AttendenceFormHeaderId == group.First().AttendenceFormHeaderId))
                    {
                        worksheet.Range[row, 1].Number = row - 6;
                        worksheet.Range[row, 2].Text = detail.SmuClientName;
                        worksheet.Range[row, 3].Text = detail.ClientPhoneContact;
                        worksheet.Range[row, 4].Text = detail.ClientCode;

                        for (int session = 1; session <= 6; session++)
                        {
                            int baseCol = 5 + (session - 1) * 4;

                            var attendedProp = detail.GetType().GetProperty($"AttendedId_Session_{session}");
                            var attendedValue = attendedProp?.GetValue(detail)?.ToString();

                            var kaguguProp = detail.GetType().GetProperty($"KaguguId_Session_{session}");
                            var kaguguValue = kaguguProp?.GetValue(detail)?.ToString();

                            var reasonProp = detail.GetType().GetProperty($"Reason_Session_{session}");
                            var reasonValue = reasonProp?.GetValue(detail)?.ToString();

                            worksheet.Range[row, baseCol + 1].Text = attendedValue;
                            worksheet.Range[row, baseCol + 2].Text = kaguguValue;
                            worksheet.Range[row, baseCol + 3].Text = reasonValue;
                        }
                        row++;
                    }

                    // Apply borders to the entire used range
                    worksheet.UsedRange.AutofitColumns();
                    worksheet.UsedRange.BorderInside(Syncfusion.XlsIO.ExcelLineStyle.Thin);
                    worksheet.UsedRange.BorderAround(Syncfusion.XlsIO.ExcelLineStyle.Thin);
                }

                // Save the workbook to a memory stream and return as byte array
                using (MemoryStream stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }

      
    }
}
=======
    }
}
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
