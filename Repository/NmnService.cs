using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MUCOBADI.Data;
using MUCOBADI.DTOs;
using MUCOBADI.Interfaces;
using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MUCOBADI.Repository
{
    public class NmnService : INmnService
    {
        private readonly MUCOBADIContext _context;
        private readonly ILogger<NmnService> _logger;
        public NmnService(MUCOBADIContext context, ILogger<NmnService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<List<InterventionAttendanceForm>?> GetInterventionAttendanceForm(int? InterventionTypeId, string? DistrictId, string? SubcountyId, int? SampledForId, int? DeliveryMethodId, string? Startdate, string? Enddate)
        {
            List<InterventionAttendanceForm>? data = new List<InterventionAttendanceForm>();
            try
            {
                DateTime? startdate = null;
                if (!string.IsNullOrEmpty(Startdate))
                {
                    DateTime date = DateTime.Now;
                    if (DateTime.TryParseExact(Startdate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                    {
                        startdate = date;
                    }
                }

                DateTime? enddate = null;
                if (!string.IsNullOrEmpty(Enddate))
                {
                    DateTime date = DateTime.Now;
                    if (DateTime.TryParseExact(Enddate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                    {
                        enddate = date;
                    }
                }

                data = (await _context.InterventionAttendanceForm.AsNoTracking().ToListAsync()).Where(o => (InterventionTypeId.HasValue == false || o.InterventionTypeId == InterventionTypeId)
                && (string.IsNullOrEmpty(DistrictId) || (o.DistrictId.HasValue && (DistrictId.Split(",").Any(x => x == o.DistrictId.ToString()))))
                && (string.IsNullOrEmpty(SubcountyId) || (o.SubcountyId.HasValue && (SubcountyId.Split(",").Any(x => x == o.SubcountyId.ToString()))))
                && (SampledForId.HasValue == false || o.SampledForId == SampledForId)
                && (DeliveryMethodId.HasValue == false || o.DeliveryMethodId == DeliveryMethodId)
                && ((startdate.HasValue == false && enddate.HasValue == false) || (startdate.HasValue == true && enddate.HasValue == false && o.AttendenceStartDate.HasValue == true && o.AttendenceStartDate.Value.Date == startdate.Value.Date)
                || (startdate.HasValue == false && enddate.HasValue == true && o.AttendenceStartDate.HasValue == true && o.AttendenceStartDate.Value.Date == enddate.Value.Date)
                || (startdate.HasValue == true && enddate.HasValue == true && o.AttendenceStartDate.HasValue == true && o.AttendenceStartDate.Value.Date >= startdate.Value.Date && o.AttendenceStartDate.Value.Date <= enddate.Value.Date))
                ).ToList();

                if (data != null && data.Any())
                {
                    var InterventionAttendanceFormDetailData = _context.InterventionAttendanceFormDetail.AsNoTracking().ToList().Where(o => data.Any(x => x.InterventionAttendanceFormId == o.InterventionAttendanceFormId)).ToList();
                    var InterventionAttendanceFormInstructorData = _context.InterventionAttendanceFormInstructor.AsNoTracking().ToList().Where(o => data.Any(x => x.InterventionAttendanceFormId == o.InterventionAttendanceFormId)).ToList();
                    foreach (var item in data)
                    {
                        if (InterventionAttendanceFormDetailData != null && InterventionAttendanceFormDetailData.Any())
                        {
                            item.InterventionAttendanceFormDetail = InterventionAttendanceFormDetailData.Where(o => o.InterventionAttendanceFormId == item.InterventionAttendanceFormId).ToList();
                        }
                        if (InterventionAttendanceFormInstructorData != null && InterventionAttendanceFormInstructorData.Any())
                        {
                            item.InterventionAttendanceFormInstructor = InterventionAttendanceFormInstructorData.Where(o => o.InterventionAttendanceFormId == item.InterventionAttendanceFormId).ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return data;
        }

        public async Task<List<Nmnquestionaire>?> GetNmnquestionaire(string? DistrictId, string? SubcountyId, int? SampledForId, int? DeliveryMethodId, int? ImplementationMethodId, string? Startdate, string? Enddate)
        {
            List<Nmnquestionaire>? data = new List<Nmnquestionaire>();
            try
            {
                DateTime? startdate = null;
                if (!string.IsNullOrEmpty(Startdate))
                {
                    DateTime date = DateTime.Now;
                    if (DateTime.TryParseExact(Startdate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                    {
                        startdate = date;
                    }
                }

                DateTime? enddate = null;
                if (!string.IsNullOrEmpty(Enddate))
                {
                    DateTime date = DateTime.Now;
                    if (DateTime.TryParseExact(Enddate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                    {
                        enddate = date;
                    }
                }

                data = (await _context.Nmnquestionaire.AsNoTracking().ToListAsync()).Where(o => (ImplementationMethodId.HasValue == false || o.ImplementationMethodId == ImplementationMethodId)
                && (string.IsNullOrEmpty(DistrictId) || (o.DistrictId.HasValue && (DistrictId.Split(",").Any(x => x == o.DistrictId.ToString()))))
                && (string.IsNullOrEmpty(SubcountyId) || (o.SubcountyId.HasValue && (SubcountyId.Split(",").Any(x => x == o.SubcountyId.ToString()))))
                && (SampledForId.HasValue == false || o.SampledForId == SampledForId)
                && (DeliveryMethodId.HasValue == false || o.DeliveryMethodId == DeliveryMethodId)
                && ((startdate.HasValue == false && enddate.HasValue == false) || (startdate.HasValue == true && enddate.HasValue == false && o.QuestionairDate.HasValue == true && o.QuestionairDate.Value.Date == startdate.Value.Date)
                || (startdate.HasValue == false && enddate.HasValue == true && o.QuestionairDate.HasValue == true && o.QuestionairDate.Value.Date == enddate.Value.Date)
                || (startdate.HasValue == true && enddate.HasValue == true && o.QuestionairDate.HasValue == true && o.QuestionairDate.Value.Date >= startdate.Value.Date && o.QuestionairDate.Value.Date <= enddate.Value.Date))
                ).ToList();

                if (data != null && data.Any())
                {
                    var NmnquestionaireSectionOneData = _context.NmnquestionaireSectionOne.AsNoTracking().ToList().Where(o => data.Any(x => x.Nmnid == o.Nmnid)).ToList();
                    var NmnquestionaireSectionTwoData = _context.NmnquestionaireSectionTwo.AsNoTracking().ToList().Where(o => data.Any(x => x.Nmnid == o.Nmnid)).ToList();
                    foreach (var item in data)
                    {
                        if (NmnquestionaireSectionOneData != null && NmnquestionaireSectionOneData.Any())
                        {
                            item.NmnquestionaireSectionOne = NmnquestionaireSectionOneData.Where(o => o.Nmnid == item.Nmnid).ToList();
                        }
                        if (NmnquestionaireSectionTwoData != null && NmnquestionaireSectionTwoData.Any())
                        {
                            item.NmnquestionaireSectionTwo = NmnquestionaireSectionTwoData.Where(o => o.Nmnid == item.Nmnid).ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return data;
        }

        public async Task<NmnPrimaryData?> GetPrimaryData()
        {
            NmnPrimaryData? data = new NmnPrimaryData();
            try
            {
                data.ImplementingPartnerData = await _context.AImplementingPartner.AsNoTracking().ToListAsync();
                data.InterventionTypeData = await _context.AInterventionType.AsNoTracking().ToListAsync();
                data.DistrictData = await _context.ADistrict.AsNoTracking().ToListAsync();
                data.SubcountyData = await _context.ASubcounty.AsNoTracking().ToListAsync();
                data.ParishData = await _context.AParish.AsNoTracking().ToListAsync();
                data.VillageData = await _context.AVillage.AsNoTracking().ToListAsync();
                data.NmnSampledForData = await _context.ANmnSampledFor.AsNoTracking().ToListAsync();
                data.DeliveryMethodData = await _context.ADeliveryMethod.AsNoTracking().ToListAsync();
                data.ImplementationMethodData = await _context.AImplementationMethod.AsNoTracking().ToListAsync();
                data.NmnSectionOneQuestionData = await _context.ANmnSectionOneQuestion.AsNoTracking().ToListAsync();
                data.NmnSectionTwoQuestionData = await _context.ANmnSectionTwoQuestion.AsNoTracking().ToListAsync();
                data.AgreeDisagreeData = await _context.AAgreeDisagree.AsNoTracking().ToListAsync();
                data.InterventionAttendanceData = await _context.AInterventionAttendance.AsNoTracking().ToListAsync();
                data.NmnSectionTwoAnswerData = await _context.ANmnSectionTwoAnswer.AsNoTracking().ToListAsync();
                data.YesNoData = await _context.AYesNo.AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return data;
        }

        public async Task<Response?> SaveInterventionAttendanceForm(InterventionAttendanceForm Record)
        {
            Response? data = new Response();
            try
            {
                var exists = await _context.InterventionAttendanceForm.FirstOrDefaultAsync(o => o.InterventionAttendanceFormId == Record.InterventionAttendanceFormId);
                if (exists != null)
                {
                    _context.Entry(exists).CurrentValues.SetValues(Record);
                    _context.Entry(exists).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    _context.Entry(exists).State = EntityState.Detached;
                    await _context.SaveChangesAsync();

                }
                else
                {
                    int Id = 1;

                    var lastrecord = _context.InterventionAttendanceForm.OrderBy(o => o.InterventionAttendanceFormId).ToList().LastOrDefault();
                    if (lastrecord != null)
                    {
                        Id = (lastrecord.InterventionAttendanceFormId + 1);
                    }
                    Record.InterventionAttendanceFormId = Id;
                    InterventionAttendanceForm m = new InterventionAttendanceForm();
                    m.InterventionAttendanceFormId = Record.InterventionAttendanceFormId;
                    m.ImplementingPartnerId = Record.ImplementingPartnerId;
                    m.InterventionTypeId = Record.InterventionTypeId;
                    m.AttendenceStartDate = Record.AttendenceStartDate;
                    m.AttendenceEndDate = Record.AttendenceEndDate;
                    m.DistrictId = Record.DistrictId;
                    m.SubcountyId = Record.SubcountyId;
                    m.ParishId = Record.ParishId;
                    m.VillageId = Record.VillageId;
                    m.SampledForId = Record.SampledForId;
                    m.GroupName = Record.GroupName;
                    m.DeliveryMethodId = Record.DeliveryMethodId;
                    m.Venue = Record.Venue;
                    m.NumberDisclosingSexualViolence = Record.NumberDisclosingSexualViolence;
                    m.NumberRefered = Record.NumberRefered;
                    m.SerialNo = Record.SerialNo;
                    m.ReviewdBy = Record.ReviewdBy;

                    _context.Add(m);
                    await _context.SaveChangesAsync();
                    _context.Entry(m).State = EntityState.Detached;
                    await _context.SaveChangesAsync();
                }

                if (Record.InterventionAttendanceFormInstructor != null && Record.InterventionAttendanceFormInstructor.Any())
                {
                    foreach (var item in Record.InterventionAttendanceFormInstructor)
                    {
                        var _exists = _context.InterventionAttendanceFormInstructor.ToList().FirstOrDefault(o => o.InterventionAttendanceFormInstructorId == item.InterventionAttendanceFormInstructorId
                        || (o.InterventionAttendanceFormId == Record.InterventionAttendanceFormId && !string.IsNullOrEmpty(o.InstructorName) &&
                        !string.IsNullOrEmpty(item.InstructorName) && Regex.Replace(o.InstructorName, @"\s", "") == Regex.Replace(item.InstructorName, @"\s", "")));
                        if (_exists != null)
                        {
                            item.InterventionAttendanceFormInstructorId = _exists.InterventionAttendanceFormInstructorId;
                            item.InterventionAttendanceFormId = _exists.InterventionAttendanceFormId;
                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                            _context.Entry(_exists).State = EntityState.Detached;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int Id = 1;

                            var lastrecord = _context.InterventionAttendanceFormInstructor.OrderBy(o => o.InterventionAttendanceFormInstructorId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                Id = (lastrecord.InterventionAttendanceFormInstructorId + 1);
                            }
                            item.InterventionAttendanceFormInstructorId = Id;
                            item.InterventionAttendanceFormId = Record.InterventionAttendanceFormId;

                            _context.Add(item);
                            await _context.SaveChangesAsync();
                            _context.Entry(item).State = EntityState.Detached;
                            await _context.SaveChangesAsync();
                        }
                    }
                }
                if (Record.InterventionAttendanceFormDetail != null && Record.InterventionAttendanceFormDetail.Any())
                {
                    foreach (var item in Record.InterventionAttendanceFormDetail)
                    {
                        var _exists = _context.InterventionAttendanceFormDetail.ToList().FirstOrDefault(o => o.InterventionAttendanceFormDetailId == item.InterventionAttendanceFormDetailId
                        || (o.InterventionAttendanceFormId == Record.InterventionAttendanceFormId && !string.IsNullOrEmpty(o.UniqueId) &&
                        !string.IsNullOrEmpty(item.UniqueId) && Regex.Replace(o.UniqueId, @"\s", "") == Regex.Replace(item.UniqueId, @"\s", "")));
                        if (_exists != null)
                        {
                            item.InterventionAttendanceFormDetailId = _exists.InterventionAttendanceFormDetailId;
                            item.InterventionAttendanceFormId = _exists.InterventionAttendanceFormId;
                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                            _context.Entry(_exists).State = EntityState.Detached;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int Id = 1;

                            var lastrecord = _context.InterventionAttendanceFormDetail.OrderBy(o => o.InterventionAttendanceFormDetailId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                Id = (lastrecord.InterventionAttendanceFormDetailId + 1);
                            }
                            item.InterventionAttendanceFormDetailId = Id;
                            item.InterventionAttendanceFormId = Record.InterventionAttendanceFormId;

                            _context.Add(item);
                            await _context.SaveChangesAsync();
                            _context.Entry(item).State = EntityState.Detached;
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                data = new Response() { IsSuccess = true, Message = "Record was successfully saved/Updated.", Status = "Success!" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                data = new Response() { IsSuccess = false, Message = ex.Message, Status = "Error!" };
            }
            return data;
        }

        public async Task<Response?> SaveNmnquestionaire(Nmnquestionaire Record)
        {
            Response? data = new Response();
            try
            {
                var exists = await _context.Nmnquestionaire.FirstOrDefaultAsync(o => o.Nmnid == Record.Nmnid);
                if (exists != null)
                {
                    _context.Entry(exists).CurrentValues.SetValues(Record);
                    _context.Entry(exists).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    _context.Entry(exists).State = EntityState.Detached;
                    await _context.SaveChangesAsync();

                }
                else
                {
                    int Id = 1;

                    var lastrecord = _context.Nmnquestionaire.OrderBy(o => o.Nmnid).ToList().LastOrDefault();
                    if (lastrecord != null)
                    {
                        Id = (lastrecord.Nmnid + 1);
                    }
                    Record.Nmnid = Id;
                    Nmnquestionaire m = new Nmnquestionaire();
                    m.Nmnid = Record.Nmnid;
                    m.ImplementingPartnerId = Record.ImplementingPartnerId;
                    m.QuestionairDate = Record.QuestionairDate;
                    m.DistrictId = Record.DistrictId;
                    m.SubcountyId = Record.SubcountyId;
                    m.ParishId = Record.ParishId;
                    m.VillageId = Record.VillageId;
                    m.SampledForId = Record.SampledForId;
                    m.GroupName = Record.GroupName;
                    m.DeliveryMethodId = Record.DeliveryMethodId;
                    m.ImplementationMethodId = Record.ImplementationMethodId;
                    m.InstructorNames = Record.InstructorNames;
                    m.InstructorAge = Record.InstructorAge;
                    m.SerialNo = Record.SerialNo;


                    _context.Add(m);
                    await _context.SaveChangesAsync();
                    _context.Entry(m).State = EntityState.Detached;
                    await _context.SaveChangesAsync();
                }

                if (Record.NmnquestionaireSectionOne != null && Record.NmnquestionaireSectionOne.Any())
                {
                    foreach (var item in Record.NmnquestionaireSectionOne)
                    {
                        var _exists = _context.NmnquestionaireSectionOne.ToList().FirstOrDefault(o => o.NmnsectionOneId == item.NmnsectionOneId
                        || (o.Nmnid == Record.Nmnid && o.QuestionId == item.QuestionId));
                        if (_exists != null)
                        {
                            item.NmnsectionOneId = _exists.NmnsectionOneId;
                            item.Nmnid = _exists.Nmnid;
                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                            _context.Entry(_exists).State = EntityState.Detached;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int Id = 1;

                            var lastrecord = _context.NmnquestionaireSectionOne.OrderBy(o => o.NmnsectionOneId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                Id = (lastrecord.NmnsectionOneId + 1);
                            }
                            item.NmnsectionOneId = Id;
                            item.Nmnid = Record.Nmnid;

                            _context.Add(item);
                            await _context.SaveChangesAsync();
                            _context.Entry(item).State = EntityState.Detached;
                            await _context.SaveChangesAsync();
                        }
                    }
                }
                if (Record.NmnquestionaireSectionTwo != null && Record.NmnquestionaireSectionTwo.Any())
                {
                    foreach (var item in Record.NmnquestionaireSectionTwo)
                    {
                        var _exists = _context.NmnquestionaireSectionTwo.ToList().FirstOrDefault(o => o.NmnsectionTwoId == item.NmnsectionTwoId
                        || (o.Nmnid == Record.Nmnid && o.QuestionId == item.QuestionId));
                        if (_exists != null)
                        {
                            item.NmnsectionTwoId = _exists.NmnsectionTwoId;
                            item.Nmnid = _exists.Nmnid;
                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                            _context.Entry(_exists).State = EntityState.Detached;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int Id = 1;

                            var lastrecord = _context.NmnquestionaireSectionTwo.OrderBy(o => o.NmnsectionTwoId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                Id = (lastrecord.NmnsectionTwoId + 1);
                            }
                            item.NmnsectionTwoId = Id;
                            item.Nmnid = Record.Nmnid;

                            _context.Add(item);
                            await _context.SaveChangesAsync();
                            _context.Entry(item).State = EntityState.Detached;
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                data = new Response() { IsSuccess = true, Message = "Record was successfully saved/Updated.", Status = "Success!" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                data = new Response() { IsSuccess = false, Message = ex.Message, Status = "Error!" };
            }
            return data;
        }
    }
}
