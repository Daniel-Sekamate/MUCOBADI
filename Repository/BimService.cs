using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MUCOBADI.Context;
using MUCOBADI.Data;
using MUCOBADI.DTOs;
using MUCOBADI.Interfaces;
using MUCOBADI.Models;
<<<<<<< HEAD
=======
using Syncfusion.DocIO.DLS;
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MUCOBADI.Repository
{
<<<<<<< HEAD
    //public class BimService : IBimService
    //{
    //    //private readonly BIMContext _context;
    //    private readonly ILogger<BimService> _logger;
    //    //private readonly UtilitiesContext _db;
    //    private readonly MUCOBADIContext _context;
    //    public BimService(/*BIMContext _context,*/ ILogger<BimService> _logger, /*UtilitiesContext _db,*/ MUCOBADIContext _context)
    //    {
    //        this._context = _context;
    //        this._logger = _logger;
    //        //this._db = _db;
    //        //this._context = _Mucodb;
    //    }
    //    public async Task<List<BusinessPlanHeader>?> GetBusinessPlan(string? DistrictId, string? SubcountyId, string? HouseholdId, string? NatureofResidenceId, string? CategoryofResidenceId)
    //    {
    //        List<BusinessPlanHeader>? data = new List<BusinessPlanHeader>();
    //        try
    //        {
    //            data = (await _context.BusinessPlanHeader.AsNoTracking().ToListAsync())
    //                .Where(o => (string.IsNullOrEmpty(DistrictId) == true || (!string.IsNullOrEmpty(DistrictId) && o.DistrictId.HasValue == true && DistrictId.Split(",").Any(x => x == o.DistrictId.ToString())))
    //                && (string.IsNullOrEmpty(SubcountyId) == true || (!string.IsNullOrEmpty(SubcountyId) && o.SubcountyId.HasValue == true && SubcountyId.Split(",").Any(x => x == o.SubcountyId.ToString())))
    //                && (string.IsNullOrEmpty(HouseholdId) == true || (!string.IsNullOrEmpty(HouseholdId) && o.HouseholdId.HasValue == true && HouseholdId.Split(",").Any(x => x == o.HouseholdId.ToString())))
    //                && (string.IsNullOrEmpty(NatureofResidenceId) == true || (!string.IsNullOrEmpty(NatureofResidenceId) && o.NatureofResidenceId.HasValue == true && NatureofResidenceId.Split(",").Any(x => x == o.NatureofResidenceId.ToString())))
    //                && (string.IsNullOrEmpty(CategoryofResidenceId) == true || (!string.IsNullOrEmpty(CategoryofResidenceId) && o.CategoryofResidenceId.HasValue == true && CategoryofResidenceId.Split(",").Any(x => x == o.CategoryofResidenceId.ToString())))
    //                ).ToList();

    //            if (data != null && data.Count > 0)
    //            {
    //                var details = _context.BusinessPlanDetail.AsNoTracking().ToList().Where(o => data.Any(x => x.BusinessPlanHeaderId == o.BusinessPlanHeaderId)).ToList();
    //                if (details != null && details.Count > 0)
    //                {
    //                    foreach (var item in data)
    //                    {
    //                        item.BusinessPlanDetail = details.Where(o => o.BusinessPlanHeaderId == item.BusinessPlanHeaderId).ToList();
    //                    }
    //                }
    //            }


    //        }
    //        catch (Exception ex)
    //        {
    //            _logger.LogError(ex, ex.Message);
    //        }
    //        return data;
    //    }
    //    public async Task<List<BusinessTrackingLedger>?> GetBusinessTrackingLedger(string? ProposedBusinessName)
    //    {
    //        List<BusinessTrackingLedger>? data = new List<BusinessTrackingLedger>();
    //        try
    //        {
    //            data = (await _context.BusinessTrackingLedger.AsNoTracking().ToListAsync())
    //                .Where(o => (string.IsNullOrEmpty(ProposedBusinessName) == true || (!string.IsNullOrEmpty(ProposedBusinessName) && !string.IsNullOrEmpty(o.ProposedBusinessName) && Regex.Replace(o.ProposedBusinessName, @"\s", "") == Regex.Replace(ProposedBusinessName, @"\s", "")))
    //                ).ToList();

    //            if (data != null && data.Count > 0)
    //            {
    //                var details = _context.BusinessTrackingLedgerMoc.AsNoTracking().ToList().Where(o => data.Any(x => x.BusinessTrackingLedgerId == o.BusinessTrackingLedgerId)).ToList();
    //                if (details != null && details.Count > 0)
    //                {
    //                    foreach (var item in data)
    //                    {
    //                        item.BusinessTrackingLedgerMoc = details.Where(o => o.BusinessTrackingLedgerId == item.BusinessTrackingLedgerId).ToList();
    //                    }
    //                }
    //                var _details = _context.BusinessTrackingLedgerSue.AsNoTracking().ToList().Where(o => data.Any(x => x.BusinessTrackingLedgerId == o.BusinessTrackingLedgerId)).ToList();
    //                if (_details != null && _details.Count > 0)
    //                {
    //                    foreach (var item in data)
    //                    {
    //                        item.BusinessTrackingLedgerSue = _details.Where(o => o.BusinessTrackingLedgerId == item.BusinessTrackingLedgerId).ToList();
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            _logger.LogError(ex, ex.Message);
    //        }
    //        return data;
    //    }
    //    public async Task<List<Isvatheader>?> GetIsvat(string? DistrictId, string? SubcountyId, string? HouseholdId, string? NatureofResidenceId, string? CategoryofResidenceId)
    //    {
    //        List<Isvatheader>? data = new List<Isvatheader>();
    //        try
    //        {
    //            data = (await _context.Isvatheader.AsNoTracking().ToListAsync())
    //                .Where(o => (string.IsNullOrEmpty(DistrictId) == true || (!string.IsNullOrEmpty(DistrictId) && o.DistrictId.HasValue == true && DistrictId.Split(",").Any(x => x == o.DistrictId.ToString())))
    //                && (string.IsNullOrEmpty(SubcountyId) == true || (!string.IsNullOrEmpty(SubcountyId) && o.SubcountyId.HasValue == true && SubcountyId.Split(",").Any(x => x == o.SubcountyId.ToString())))
    //                && (string.IsNullOrEmpty(HouseholdId) == true || (!string.IsNullOrEmpty(HouseholdId) && o.HouseholdId.HasValue == true && HouseholdId.Split(",").Any(x => x == o.HouseholdId.ToString())))
    //                && (string.IsNullOrEmpty(NatureofResidenceId) == true || (!string.IsNullOrEmpty(NatureofResidenceId) && o.NatureofResidenceId.HasValue == true && NatureofResidenceId.Split(",").Any(x => x == o.NatureofResidenceId.ToString())))
    //                && (string.IsNullOrEmpty(CategoryofResidenceId) == true || (!string.IsNullOrEmpty(CategoryofResidenceId) && o.CategoryofResidenceId.HasValue == true && CategoryofResidenceId.Split(",").Any(x => x == o.CategoryofResidenceId.ToString())))
    //                ).ToList();

    //            if (data != null && data.Count > 0)
    //            {
    //                var BusinessOpportunitydetails = _context.IsvatcurrentBusinessOpportunity.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
    //                if (BusinessOpportunitydetails != null && BusinessOpportunitydetails.Count > 0)
    //                {
    //                    foreach (var item in data)
    //                    {
    //                        item.IsvatcurrentBusinessOpportunity = BusinessOpportunitydetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
    //                    }
    //                }

    //                var BusinessRiskdetails = _context.IsvatcurrentBusinessRisk.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
    //                if (BusinessRiskdetails != null && BusinessRiskdetails.Count > 0)
    //                {
    //                    foreach (var item in data)
    //                    {
    //                        item.IsvatcurrentBusinessRisk = BusinessRiskdetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
    //                    }
    //                }

    //                var generatedProfitdetails = _context.IsvatgeneratedProfit.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
    //                if (generatedProfitdetails != null && generatedProfitdetails.Count > 0)
    //                {
    //                    foreach (var item in data)
    //                    {
    //                        item.IsvatgeneratedProfit = generatedProfitdetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
    //                    }
    //                }

    //                var lossdetails = _context.Isvatloss.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
    //                if (lossdetails != null && lossdetails.Count > 0)
    //                {
    //                    foreach (var item in data)
    //                    {
    //                        item.Isvatloss = lossdetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
    //                    }
    //                }

    //                var BusinessAnswerdetails = _context.IsvatstartBusinessAnswer.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
    //                if (BusinessAnswerdetails != null && BusinessAnswerdetails.Count > 0)
    //                {
    //                    foreach (var item in data)
    //                    {
    //                        item.IsvatstartBusinessAnswer = BusinessAnswerdetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
    //                    }
    //                }

    //                var workingCapitaldetails = _context.IsvatworkingCapital.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
    //                if (workingCapitaldetails != null && workingCapitaldetails.Count > 0)
    //                {
    //                    foreach (var item in data)
    //                    {
    //                        item.IsvatworkingCapital = workingCapitaldetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
    //                    }
    //                }

    //                var incomeEarnerdetails = _context.IsvatincomeEarner.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
    //                if (incomeEarnerdetails != null && incomeEarnerdetails.Count > 0)
    //                {
    //                    var Incomeowners = _context.IsvatincomeOwnership.AsNoTracking().ToList().Where(o => incomeEarnerdetails.Any(x => x.IsvatincomeEarnerId == o.IsvatincomeEarnerId)).ToList();
    //                    if (Incomeowners != null && Incomeowners.Count > 0)
    //                    {
    //                        foreach (var item in incomeEarnerdetails)
    //                        {
    //                            item.IsvatincomeOwnership = Incomeowners.Where(o => o.IsvatincomeEarnerId == item.IsvatincomeEarnerId).ToList();
    //                        }
    //                    }

    //                    foreach (var item in data)
    //                    {
    //                        item.IsvatincomeEarner = incomeEarnerdetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            _logger.LogError(ex, ex.Message);
    //        }
    //        return data;
    //    }
    //    public async Task<BimPrimaryData?> GetPrimaryData()
    //    {
    //        BimPrimaryData? data = new BimPrimaryData();
    //        try
    //        {
    //            data.GenderData = _context.AGender.AsNoTracking().ToList();
    //            data.MaritalStatusData = _context.AMaritalStatus.AsNoTracking().ToList();
    //            data.SubcountyData = _context.ASubcounty.AsNoTracking().ToList();
    //            data.DistrictData = _context.ADistrict.AsNoTracking().ToList();
    //            data.ParishData = _context.AParish.AsNoTracking().ToList();
    //            data.VillageData = _context.AVillage.AsNoTracking().ToList();
    //            data.NatureofResidenceData = _context.ANatureofResidence.AsNoTracking().ToList();
    //            data.CategoryofResidenceData = _context.ACategoryofResidence.AsNoTracking().ToList();
    //            data.BusinessPlanQuestionData = await _context.ABusinessPlanQuestion.AsNoTracking().ToListAsync();
    //            data.YesNoData = await _context.AYesNo.AsNoTracking().ToListAsync();
    //            data.AssetIncomeData = await _context.AAssetIncome.AsNoTracking().ToListAsync();
    //            data.RiskLevelRatingData = await _context.ARiskLevelRating.AsNoTracking().ToListAsync();
    //            data.BusinessVentureCapitalInvestmentData = await _context.ABusinessVentureCapitalInvestment.AsNoTracking().ToListAsync();
    //            data.BusinessOpportunityData = await _context.ACurrenBusinessOpportunity.AsNoTracking().ToListAsync();
    //            data.BusinessRiskData = await _context.ACurrenBusinessRisk.AsNoTracking().ToListAsync();
    //            data.StartBusinessQuestionData = await _context.AStartBusinessQuestion.AsNoTracking().ToListAsync();
    //        }
    //        catch (Exception ex)
    //        {
    //            _logger.LogError(ex, ex.Message);
    //        }
    //        return data;
    //    }
    //    public async Task<Response?> SaveBusinessPlan(BusinessPlanHeader record)
    //    {
    //        Response? data = new Response();
    //        try
    //        {
    //            var exists = _context.BusinessPlanHeader.FirstOrDefault(o => o.BusinessPlanHeaderId == record.BusinessPlanHeaderId);
    //            if (exists != null)
    //            {
    //                _context.Entry(exists).CurrentValues.SetValues(record);
    //                _context.Entry(exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                await _context.SaveChangesAsync();
    //            }
    //            else
    //            {
    //                int id = 1;
    //                var lastrecord = _context.BusinessPlanHeader.OrderBy(o => o.BusinessPlanHeaderId).ToList().LastOrDefault();
    //                if (lastrecord != null)
    //                {
    //                    id = (lastrecord.BusinessPlanHeaderId + 1);
    //                }
    //                record.BusinessPlanHeaderId = id;
    //                BusinessPlanHeader m = new BusinessPlanHeader();
    //                m.BusinessPlanHeaderId = record.BusinessPlanHeaderId;
    //                m.DistrictId = record.DistrictId;
    //                m.SubcountyId = record.SubcountyId;
    //                m.ParishId = record.ParishId;
    //                m.VillageId = record.VillageId;
    //                m.HouseholdId = record.HouseholdId;
    //                m.HouseholdMemberId = record.HouseholdMemberId;
    //                m.NatureofResidenceId = record.NatureofResidenceId;
    //                m.CategoryofResidenceId = record.CategoryofResidenceId;
    //                m.GenderId = record.GenderId;
    //                m.Dob = record.Dob;
    //                m.Age = record.Age;
    //                m.MaritalStatusId = record.MaritalStatusId;
    //                m.DataCollectorName = record.DataCollectorName;
    //                m.DataCollectorTitle = record.DataCollectorTitle;
    //                m.DataCollectionDate = record.DataCollectionDate;
    //                m.DataReviewerName = record.DataReviewerName;
    //                m.DataReviewerTitle = record.DataReviewerTitle;
    //                m.DataReviewDate = record.DataReviewDate;
    //                _context.BusinessPlanHeader.Add(m);
    //                await _context.SaveChangesAsync();

    //            }

    //            if (record.BusinessPlanDetail != null && record.BusinessPlanDetail.Any() && record.BusinessPlanHeaderId > 0)
    //            {
    //                foreach (var item in record.BusinessPlanDetail)
    //                {
    //                    var _exists = _context.BusinessPlanDetail.FirstOrDefault(o => o.BusinessPlanDetailId == item.BusinessPlanDetailId
    //                    || (o.BusinessPlanHeaderId == record.BusinessPlanHeaderId && o.BusinessPlanQuestionId == item.BusinessPlanQuestionId));
    //                    if (_exists != null)
    //                    {
    //                        item.BusinessPlanDetailId = _exists.BusinessPlanDetailId;
    //                        item.BusinessPlanHeaderId = record.BusinessPlanHeaderId;

    //                        _context.Entry(_exists).CurrentValues.SetValues(item);
    //                        _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                        await _context.SaveChangesAsync();
    //                    }
    //                    else
    //                    {
    //                        int id = 1;
    //                        var lastrecord = _context.BusinessPlanDetail.OrderBy(o => o.BusinessPlanDetailId).ToList().LastOrDefault();
    //                        if (lastrecord != null)
    //                        {
    //                            id = (lastrecord.BusinessPlanDetailId + 1);
    //                        }
    //                        item.BusinessPlanDetailId = id;
    //                        item.BusinessPlanHeaderId = record.BusinessPlanHeaderId;
    //                        _context.BusinessPlanDetail.Add(item);
    //                        await _context.SaveChangesAsync();
    //                    }
    //                }
    //            }

    //            data = new Response() { IsSuccess = true, Message = "Record was successfully saved.", Status = "Success!" };
    //        }
    //        catch (Exception ex)
    //        {
    //            _logger.LogError(ex, ex.Message);
    //            data = new Response() { IsSuccess = false, Message = ex.Message, Status = "Error!" };
    //        }
    //        return data;
    //    }

    //    public async Task<Response?> SaveBusinessTrackingLedger(BusinessTrackingLedger record)
    //    {
    //        Response? data = new Response();
    //        try
    //        {
    //            var exists = _context.BusinessTrackingLedger.FirstOrDefault(o => o.BusinessTrackingLedgerId == record.BusinessTrackingLedgerId);
    //            if (exists != null)
    //            {
    //                _context.Entry(exists).CurrentValues.SetValues(record);
    //                _context.Entry(exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                await _context.SaveChangesAsync();
    //            }
    //            else
    //            {
    //                int id = 1;
    //                var lastrecord = _context.BusinessTrackingLedger.OrderBy(o => o.BusinessTrackingLedgerId).ToList().LastOrDefault();
    //                if (lastrecord != null)
    //                {
    //                    id = (lastrecord.BusinessTrackingLedgerId + 1);
    //                }
    //                record.BusinessTrackingLedgerId = id;
    //                BusinessTrackingLedger m = new BusinessTrackingLedger();
    //                m.BusinessTrackingLedgerId = record.BusinessTrackingLedgerId;
    //                m.ProposedBusinessName = record.ProposedBusinessName;
    //                m.StartupExpenseTotalAmount = record.StartupExpenseTotalAmount;
    //                m.BusinessViabilityAnalysisTotalAmount = record.BusinessViabilityAnalysisTotalAmount;
    //                m.EstimatedOutputPerDay = record.EstimatedOutputPerDay;
    //                m.NetProfits = record.NetProfits;
    //                m.DataCollectorName = record.DataCollectorName;
    //                m.DataCollectorTitle = record.DataCollectorTitle;
    //                m.DataCollectionDate = record.DataCollectionDate;
    //                m.DataReviewerName = record.DataReviewerName;
    //                m.DataReviewerTitle = record.DataReviewerTitle;
    //                m.DataReviewDate = record.DataReviewDate;

    //                _context.BusinessTrackingLedger.Add(m);
    //                await _context.SaveChangesAsync();

    //            }

    //            if (record.BusinessTrackingLedgerSue != null && record.BusinessTrackingLedgerSue.Any() && record.BusinessTrackingLedgerId > 0)
    //            {
    //                foreach (var item in record.BusinessTrackingLedgerSue)
    //                {
    //                    var _exists = _context.BusinessTrackingLedgerSue.ToList().FirstOrDefault(o => o.StartUpExpensesId == item.StartUpExpensesId
    //                    || (o.BusinessTrackingLedgerId == record.BusinessTrackingLedgerId && !string.IsNullOrEmpty(o.Item) && !string.IsNullOrEmpty(item.Item) && Regex.Replace(o.Item, @"\s", "") == Regex.Replace(item.Item, @"\s", "")));
    //                    if (_exists != null)
    //                    {
    //                        item.StartUpExpensesId = _exists.StartUpExpensesId;
    //                        item.BusinessTrackingLedgerId = record.BusinessTrackingLedgerId;

    //                        _context.Entry(_exists).CurrentValues.SetValues(item);
    //                        _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                        await _context.SaveChangesAsync();
    //                    }
    //                    else
    //                    {
    //                        int id = 1;
    //                        var lastrecord = _context.BusinessTrackingLedgerSue.OrderBy(o => o.StartUpExpensesId).ToList().LastOrDefault();
    //                        if (lastrecord != null)
    //                        {
    //                            id = (lastrecord.StartUpExpensesId + 1);
    //                        }
    //                        item.StartUpExpensesId = id;
    //                        item.BusinessTrackingLedgerId = record.BusinessTrackingLedgerId;
    //                        _context.BusinessTrackingLedgerSue.Add(item);
    //                        await _context.SaveChangesAsync();
    //                    }
    //                }
    //            }

    //            if (record.BusinessTrackingLedgerMoc != null && record.BusinessTrackingLedgerMoc.Any() && record.BusinessTrackingLedgerId > 0)
    //            {
    //                foreach (var item in record.BusinessTrackingLedgerMoc)
    //                {
    //                    var _exists = _context.BusinessTrackingLedgerMoc.ToList().FirstOrDefault(o => o.MonthlyOperationalCostsId == item.MonthlyOperationalCostsId
    //                    || (o.BusinessTrackingLedgerId == record.BusinessTrackingLedgerId && !string.IsNullOrEmpty(o.Item) && !string.IsNullOrEmpty(item.Item) && Regex.Replace(o.Item, @"\s", "") == Regex.Replace(item.Item, @"\s", "")));
    //                    if (_exists != null)
    //                    {
    //                        item.MonthlyOperationalCostsId = _exists.MonthlyOperationalCostsId;
    //                        item.BusinessTrackingLedgerId = record.BusinessTrackingLedgerId;

    //                        _context.Entry(_exists).CurrentValues.SetValues(item);
    //                        _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                        await _context.SaveChangesAsync();
    //                    }
    //                    else
    //                    {
    //                        int id = 1;
    //                        var lastrecord = _context.BusinessTrackingLedgerMoc.OrderBy(o => o.MonthlyOperationalCostsId).ToList().LastOrDefault();
    //                        if (lastrecord != null)
    //                        {
    //                            id = (lastrecord.MonthlyOperationalCostsId + 1);
    //                        }
    //                        item.MonthlyOperationalCostsId = id;
    //                        item.BusinessTrackingLedgerId = record.BusinessTrackingLedgerId;
    //                        _context.BusinessTrackingLedgerMoc.Add(item);
    //                        await _context.SaveChangesAsync();
    //                    }
    //                }
    //            }

    //            data = new Response() { IsSuccess = true, Message = "Record was successfully saved.", Status = "Success!" };
    //        }
    //        catch (Exception ex)
    //        {
    //            _logger.LogError(ex, ex.Message);
    //            data = new Response() { IsSuccess = false, Message = ex.Message, Status = "Error!" };
    //        }
    //        return data;
    //    }

    //    public async Task<Response?> SaveIsvat(Isvatheader record)
    //    {
    //        Response? data = new Response();
    //        try
    //        {
    //            var exists = _context.Isvatheader.FirstOrDefault(o => o.IsvatheaderId == record.IsvatheaderId);
    //            if (exists != null)
    //            {
    //                _context.Entry(exists).CurrentValues.SetValues(record);
    //                _context.Entry(exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                await _context.SaveChangesAsync();
    //            }
    //            else
    //            {
    //                int id = 1;
    //                var lastrecord = _context.Isvatheader.OrderBy(o => o.IsvatheaderId).ToList().LastOrDefault();
    //                if (lastrecord != null)
    //                {
    //                    id = (lastrecord.IsvatheaderId + 1);
    //                }
    //                record.IsvatheaderId = id;
    //                Isvatheader m = new Isvatheader();
    //                m.IsvatheaderId = record.IsvatheaderId;
    //                m.DistrictId = record.DistrictId;
    //                m.SubcountyId = record.SubcountyId;
    //                m.ParishId = record.ParishId;
    //                m.VillageId = record.VillageId;
    //                m.HouseholdId = record.HouseholdId;
    //                m.HouseholdMemberId = record.HouseholdMemberId;
    //                m.NatureofResidenceId = record.NatureofResidenceId;
    //                m.CategoryofResidenceId = record.CategoryofResidenceId;
    //                m.GenderId = record.GenderId;
    //                m.Dob = record.Dob;
    //                m.Age = record.Age;
    //                m.DataCollectorName = record.DataCollectorName;
    //                m.DataCollectorTitle = record.DataCollectorTitle;
    //                m.DataCollectionDate = record.DataCollectionDate;
    //                m.DataReviewerName = record.DataReviewerName;
    //                m.DataReviewerTitle = record.DataReviewerTitle;
    //                m.DataReviewDate = record.DataReviewDate;


    //                _context.Isvatheader.Add(m);
    //                await _context.SaveChangesAsync();

    //            }

    //            if (record.IsvatworkingCapital != null && record.IsvatworkingCapital.Any() && record.IsvatheaderId > 0)
    //            {
    //                foreach (var item in record.IsvatworkingCapital)
    //                {
    //                    var _exists = _context.IsvatworkingCapital.ToList().FirstOrDefault(o => o.IsvatworkingCapitalId == item.IsvatworkingCapitalId
    //                    || (o.IsvatheaderId == record.IsvatheaderId && o.AssetIncomeId == item.AssetIncomeId));
    //                    if (_exists != null)
    //                    {
    //                        item.IsvatworkingCapitalId = _exists.IsvatworkingCapitalId;
    //                        item.IsvatheaderId = record.IsvatheaderId;

    //                        _context.Entry(_exists).CurrentValues.SetValues(item);
    //                        _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                        await _context.SaveChangesAsync();
    //                    }
    //                    else
    //                    {
    //                        int id = 1;
    //                        var lastrecord = _context.IsvatworkingCapital.OrderBy(o => o.IsvatworkingCapitalId).ToList().LastOrDefault();
    //                        if (lastrecord != null)
    //                        {
    //                            id = (lastrecord.IsvatworkingCapitalId + 1);
    //                        }
    //                        item.IsvatworkingCapitalId = id;
    //                        item.IsvatheaderId = record.IsvatheaderId;
    //                        _context.IsvatworkingCapital.Add(item);
    //                        await _context.SaveChangesAsync();
    //                    }
    //                }
    //            }

    //            if (record.IsvatcurrentBusinessOpportunity != null && record.IsvatcurrentBusinessOpportunity.Any() && record.IsvatheaderId > 0)
    //            {
    //                foreach (var item in record.IsvatcurrentBusinessOpportunity)
    //                {
    //                    var _exists = _context.IsvatcurrentBusinessOpportunity.ToList().FirstOrDefault(o => o.IsvatcurrentBusinessOpportunityId == item.IsvatcurrentBusinessOpportunityId
    //                    || (o.IsvatheaderId == record.IsvatheaderId && o.CurrenBusinessOpportunityId == item.CurrenBusinessOpportunityId));
    //                    if (_exists != null)
    //                    {
    //                        item.IsvatcurrentBusinessOpportunityId = _exists.IsvatcurrentBusinessOpportunityId;
    //                        item.IsvatheaderId = record.IsvatheaderId;

    //                        _context.Entry(_exists).CurrentValues.SetValues(item);
    //                        _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                        await _context.SaveChangesAsync();
    //                    }
    //                    else
    //                    {
    //                        int id = 1;
    //                        var lastrecord = _context.IsvatcurrentBusinessOpportunity.OrderBy(o => o.IsvatcurrentBusinessOpportunityId).ToList().LastOrDefault();
    //                        if (lastrecord != null)
    //                        {
    //                            id = (lastrecord.IsvatcurrentBusinessOpportunityId + 1);
    //                        }
    //                        item.IsvatcurrentBusinessOpportunityId = id;
    //                        item.IsvatheaderId = record.IsvatheaderId;
    //                        _context.IsvatcurrentBusinessOpportunity.Add(item);
    //                        await _context.SaveChangesAsync();
    //                    }
    //                }
    //            }
    //            if (record.IsvatcurrentBusinessRisk != null && record.IsvatcurrentBusinessRisk.Any() && record.IsvatheaderId > 0)
    //            {
    //                foreach (var item in record.IsvatcurrentBusinessRisk)
    //                {
    //                    var _exists = _context.IsvatcurrentBusinessRisk.ToList().FirstOrDefault(o => o.IsvatcurrentBusinessRiskId == item.IsvatcurrentBusinessRiskId
    //                    || (o.IsvatheaderId == record.IsvatheaderId && o.CurrenBusinessRiskId == item.CurrenBusinessRiskId));
    //                    if (_exists != null)
    //                    {
    //                        item.IsvatcurrentBusinessRiskId = _exists.IsvatcurrentBusinessRiskId;
    //                        item.IsvatheaderId = record.IsvatheaderId;

    //                        _context.Entry(_exists).CurrentValues.SetValues(item);
    //                        _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                        await _context.SaveChangesAsync();
    //                    }
    //                    else
    //                    {
    //                        int id = 1;
    //                        var lastrecord = _context.IsvatcurrentBusinessRisk.OrderBy(o => o.IsvatcurrentBusinessRiskId).ToList().LastOrDefault();
    //                        if (lastrecord != null)
    //                        {
    //                            id = (lastrecord.IsvatcurrentBusinessRiskId + 1);
    //                        }
    //                        item.IsvatcurrentBusinessRiskId = id;
    //                        item.IsvatheaderId = record.IsvatheaderId;
    //                        _context.IsvatcurrentBusinessRisk.Add(item);
    //                        await _context.SaveChangesAsync();
    //                    }
    //                }
    //            }

    //            if (record.IsvatgeneratedProfit != null && record.IsvatgeneratedProfit.Any() && record.IsvatheaderId > 0)
    //            {
    //                foreach (var item in record.IsvatgeneratedProfit)
    //                {
    //                    var _exists = _context.IsvatgeneratedProfit.ToList().FirstOrDefault(o => o.IsvatgeneratedProfitId == item.IsvatgeneratedProfitId
    //                    || (o.IsvatheaderId == record.IsvatheaderId && o.AssetIncomeId == item.AssetIncomeId));
    //                    if (_exists != null)
    //                    {
    //                        item.IsvatgeneratedProfitId = _exists.IsvatgeneratedProfitId;
    //                        item.IsvatheaderId = record.IsvatheaderId;

    //                        _context.Entry(_exists).CurrentValues.SetValues(item);
    //                        _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                        await _context.SaveChangesAsync();
    //                    }
    //                    else
    //                    {
    //                        int id = 1;
    //                        var lastrecord = _context.IsvatgeneratedProfit.OrderBy(o => o.IsvatgeneratedProfitId).ToList().LastOrDefault();
    //                        if (lastrecord != null)
    //                        {
    //                            id = (lastrecord.IsvatgeneratedProfitId + 1);
    //                        }
    //                        item.IsvatgeneratedProfitId = id;
    //                        item.IsvatheaderId = record.IsvatheaderId;
    //                        _context.IsvatgeneratedProfit.Add(item);
    //                        await _context.SaveChangesAsync();
    //                    }
    //                }
    //            }

    //            if (record.Isvatloss != null && record.Isvatloss.Any() && record.IsvatheaderId > 0)
    //            {
    //                foreach (var item in record.Isvatloss)
    //                {
    //                    var _exists = _context.Isvatloss.ToList().FirstOrDefault(o => o.IsvatlossId == item.IsvatlossId
    //                    || (o.IsvatheaderId == record.IsvatheaderId && o.BusinessVentureCapitalInvestmentId == item.BusinessVentureCapitalInvestmentId));
    //                    if (_exists != null)
    //                    {
    //                        item.IsvatlossId = _exists.IsvatlossId;
    //                        item.IsvatheaderId = record.IsvatheaderId;

    //                        _context.Entry(_exists).CurrentValues.SetValues(item);
    //                        _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                        await _context.SaveChangesAsync();
    //                    }
    //                    else
    //                    {
    //                        int id = 1;
    //                        var lastrecord = _context.Isvatloss.OrderBy(o => o.IsvatlossId).ToList().LastOrDefault();
    //                        if (lastrecord != null)
    //                        {
    //                            id = (lastrecord.IsvatlossId + 1);
    //                        }
    //                        item.IsvatlossId = id;
    //                        item.IsvatheaderId = record.IsvatheaderId;
    //                        _context.Isvatloss.Add(item);
    //                        await _context.SaveChangesAsync();
    //                    }
    //                }
    //            }

    //            if (record.IsvatstartBusinessAnswer != null && record.IsvatstartBusinessAnswer.Any() && record.IsvatheaderId > 0)
    //            {
    //                foreach (var item in record.IsvatstartBusinessAnswer)
    //                {
    //                    var _exists = _context.IsvatstartBusinessAnswer.ToList().FirstOrDefault(o => o.IsvatstartBusinessAnswerId == item.IsvatstartBusinessAnswerId
    //                    || (o.IsvatheaderId == record.IsvatheaderId && o.StartBusinessQuestionId == item.StartBusinessQuestionId));
    //                    if (_exists != null)
    //                    {
    //                        item.IsvatstartBusinessAnswerId = _exists.IsvatstartBusinessAnswerId;
    //                        item.IsvatheaderId = record.IsvatheaderId;

    //                        _context.Entry(_exists).CurrentValues.SetValues(item);
    //                        _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                        await _context.SaveChangesAsync();
    //                    }
    //                    else
    //                    {
    //                        int id = 1;
    //                        var lastrecord = _context.IsvatstartBusinessAnswer.OrderBy(o => o.IsvatstartBusinessAnswerId).ToList().LastOrDefault();
    //                        if (lastrecord != null)
    //                        {
    //                            id = (lastrecord.IsvatstartBusinessAnswerId + 1);
    //                        }
    //                        item.IsvatstartBusinessAnswerId = id;
    //                        item.IsvatheaderId = record.IsvatheaderId;
    //                        _context.IsvatstartBusinessAnswer.Add(item);
    //                        await _context.SaveChangesAsync();
    //                    }
    //                }
    //            }

    //            if (record.IsvatincomeEarner != null && record.IsvatincomeEarner.Any() && record.IsvatheaderId > 0)
    //            {
    //                foreach (var item in record.IsvatincomeEarner)
    //                {
    //                    var _exists = _context.IsvatincomeEarner.ToList().FirstOrDefault(o => o.IsvatincomeEarnerId == item.IsvatincomeEarnerId
    //                    || (o.IsvatheaderId == record.IsvatheaderId && o.HouseHoldMemberId == item.HouseHoldMemberId));
    //                    if (_exists != null)
    //                    {
    //                        item.IsvatincomeEarnerId = _exists.IsvatincomeEarnerId;
    //                        item.IsvatheaderId = record.IsvatheaderId;

    //                        _context.Entry(_exists).CurrentValues.SetValues(item);
    //                        _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                        await _context.SaveChangesAsync();
    //                    }
    //                    else
    //                    {
    //                        int id = 1;
    //                        var lastrecord = _context.IsvatincomeEarner.OrderBy(o => o.IsvatincomeEarnerId).ToList().LastOrDefault();
    //                        if (lastrecord != null)
    //                        {
    //                            id = (lastrecord.IsvatincomeEarnerId + 1);
    //                        }
    //                        item.IsvatincomeEarnerId = id;
    //                        item.IsvatheaderId = record.IsvatheaderId;

    //                        IsvatincomeEarner m = new IsvatincomeEarner();

    //                        m.IsvatincomeEarnerId = item.IsvatincomeEarnerId;
    //                        m.IsvatheaderId = item.IsvatheaderId;
    //                        m.HouseHoldMemberId = item.HouseHoldMemberId;
    //                        m.IncomeEarnerYesNoId = item.IncomeEarnerYesNoId;

    //                        _context.IsvatincomeEarner.Add(m);
    //                        await _context.SaveChangesAsync();
    //                    }

    //                    if (item.IsvatincomeOwnership != null && item.IsvatincomeOwnership.Any() && item.IsvatincomeEarnerId > 0)
    //                    {
    //                        foreach (var _item in item.IsvatincomeOwnership)
    //                        {
    //                            var exists1 = _context.IsvatincomeOwnership.ToList().FirstOrDefault(o => o.IsvatincomeOwnershipId == _item.IsvatincomeOwnershipId
    //                            || (o.IsvatincomeEarnerId == item.IsvatincomeEarnerId && o.AssetIncomeId == _item.AssetIncomeId));
    //                            if (exists1 != null)
    //                            {
    //                                _item.IsvatincomeOwnershipId = exists1.IsvatincomeOwnershipId;
    //                                _item.IsvatincomeEarnerId = item.IsvatincomeEarnerId;

    //                                _context.Entry(exists1).CurrentValues.SetValues(_item);
    //                                _context.Entry(exists1).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //                                await _context.SaveChangesAsync();
    //                            }
    //                            else
    //                            {
    //                                int id = 1;
    //                                var lastrecord = _context.IsvatincomeOwnership.OrderBy(o => o.IsvatincomeOwnershipId).ToList().LastOrDefault();
    //                                if (lastrecord != null)
    //                                {
    //                                    id = (lastrecord.IsvatincomeOwnershipId + 1);
    //                                }
    //                                _item.IsvatincomeOwnershipId = id;
    //                                _item.IsvatincomeEarnerId = item.IsvatincomeEarnerId;
    //                                _context.IsvatincomeOwnership.Add(_item);
    //                                await _context.SaveChangesAsync();
    //                            }
    //                        }
    //                    }
    //                }
    //            }

    //            data = new Response() { IsSuccess = true, Message = "Record was successfully saved.", Status = "Success!" };
    //        }
    //        catch (Exception ex)
    //        {
    //            _logger.LogError(ex, ex.Message);
    //            data = new Response() { IsSuccess = false, Message = ex.Message, Status = "Error!" };
    //        }
    //        return data;
    //    }
    //}
=======
    public class BimService : IBimService
    {
        //private readonly BIMContext _context;
        private readonly ILogger<BimService> _logger;
        //private readonly UtilitiesContext _db;
        private readonly MUCOBADIContext _context;
        public BimService(/*BIMContext _context,*/ ILogger<BimService> _logger, /*UtilitiesContext _db,*/ MUCOBADIContext _context)
        {
            this._context = _context;
            this._logger = _logger;
            //this._db = _db;
            //this._context = _Mucodb;
        }
        public async Task<List<BusinessPlanHeader>?> GetBusinessPlan(string? DistrictId, string? SubcountyId, string? HouseholdId, string? NatureofResidenceId, string? CategoryofResidenceId, string? StartDate, string? EndDate)
        {
            List<BusinessPlanHeader>? data = new List<BusinessPlanHeader>();
            try
            {
                DateTime? startDate = null;
                if (!string.IsNullOrEmpty(StartDate))
                {
                    DateTime date = DateTime.Now;
                    if (DateTime.TryParseExact(StartDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                    {
                        startDate = date;
                    }
                }
                DateTime? endDate = null;
                if (!string.IsNullOrEmpty(EndDate))
                {
                    DateTime date = DateTime.Now;
                    if (DateTime.TryParseExact(EndDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                    {
                        endDate = date;
                    }
                }
                data = (await _context.BusinessPlanHeader.AsNoTracking().ToListAsync())
                    .Where(o => (string.IsNullOrEmpty(DistrictId) == true || (!string.IsNullOrEmpty(DistrictId) && o.DistrictId.HasValue == true && DistrictId.Split(",").Any(x => x == o.DistrictId.ToString())))
                    && (string.IsNullOrEmpty(SubcountyId) == true || (!string.IsNullOrEmpty(SubcountyId) && o.SubcountyId.HasValue == true && SubcountyId.Split(",").Any(x => x == o.SubcountyId.ToString())))
                    && (string.IsNullOrEmpty(HouseholdId) == true || (!string.IsNullOrEmpty(HouseholdId) && o.HouseholdId.HasValue == true && HouseholdId.Split(",").Any(x => x == o.HouseholdId.ToString())))
                    && (string.IsNullOrEmpty(NatureofResidenceId) == true || (!string.IsNullOrEmpty(NatureofResidenceId) && o.NatureofResidenceId.HasValue == true && NatureofResidenceId.Split(",").Any(x => x == o.NatureofResidenceId.ToString())))
                    && (string.IsNullOrEmpty(CategoryofResidenceId) == true || (!string.IsNullOrEmpty(CategoryofResidenceId) && o.CategoryofResidenceId.HasValue == true && CategoryofResidenceId.Split(",").Any(x => x == o.CategoryofResidenceId.ToString())))
                     && ((startDate.HasValue == false && endDate.HasValue == false) || (endDate.HasValue == false && startDate.HasValue == true && o.DataCollectionDate.HasValue == true && o.DataCollectionDate.Value.Date == startDate.Value.Date)
                || (endDate.HasValue == true && startDate.HasValue == false && o.DataCollectionDate.HasValue == true && o.DataCollectionDate.Value.Date == endDate.Value.Date)
                || (endDate.HasValue == true && startDate.HasValue == true && o.DataCollectionDate.HasValue == true && o.DataCollectionDate.Value.Date >= startDate.Value.Date && o.DataCollectionDate.Value.Date <= endDate.Value.Date))
                    ).ToList();
                 
                if (data != null && data.Count > 0)
                {
                    var details = _context.BusinessPlanDetail.AsNoTracking().ToList().Where(o => data.Any(x => x.BusinessPlanHeaderId == o.BusinessPlanHeaderId)).ToList();
                    if (details != null && details.Count > 0)
                    {
                        foreach (var item in data)
                        {
                            item.BusinessPlanDetail = details.Where(o => o.BusinessPlanHeaderId == item.BusinessPlanHeaderId).ToList();
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

        public async Task<List<BusinessTrackingLedger>?> GetBusinessTrackingLedger(string? ProposedBusinessName)
        {
            List<BusinessTrackingLedger>? data = new List<BusinessTrackingLedger>();
            try
            {
                data = (await _context.BusinessTrackingLedger.AsNoTracking().ToListAsync())
                    .Where(o => (string.IsNullOrEmpty(ProposedBusinessName) == true || (!string.IsNullOrEmpty(ProposedBusinessName) && !string.IsNullOrEmpty(o.ProposedBusinessName) && Regex.Replace(o.ProposedBusinessName, @"\s", "") == Regex.Replace(ProposedBusinessName, @"\s", "")))
                    ).ToList();

                if (data != null && data.Count > 0)
                {
                    var details = _context.BusinessTrackingLedgerMoc.AsNoTracking().ToList().Where(o => data.Any(x => x.BusinessTrackingLedgerId == o.BusinessTrackingLedgerId)).ToList();
                    if (details != null && details.Count > 0)
                    {
                        foreach (var item in data)
                        {
                            item.BusinessTrackingLedgerMoc = details.Where(o => o.BusinessTrackingLedgerId == item.BusinessTrackingLedgerId).ToList();
                        }
                    }
                    var _details = _context.BusinessTrackingLedgerSue.AsNoTracking().ToList().Where(o => data.Any(x => x.BusinessTrackingLedgerId == o.BusinessTrackingLedgerId)).ToList();
                    if (_details != null && _details.Count > 0)
                    {
                        foreach (var item in data)
                        {
                            item.BusinessTrackingLedgerSue = _details.Where(o => o.BusinessTrackingLedgerId == item.BusinessTrackingLedgerId).ToList();
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

        public async Task<List<Isvatheader>?> GetIsvat(string? DistrictId, string? SubcountyId, string? HouseholdId, string? NatureofResidenceId, string? CategoryofResidenceId)
        {
            List<Isvatheader>? data = new List<Isvatheader>();
            try
            {
                data = (await _context.Isvatheader.AsNoTracking().ToListAsync())
                    .Where(o => (string.IsNullOrEmpty(DistrictId) == true || (!string.IsNullOrEmpty(DistrictId) && o.DistrictId.HasValue == true && DistrictId.Split(",").Any(x => x == o.DistrictId.ToString())))
                    && (string.IsNullOrEmpty(SubcountyId) == true || (!string.IsNullOrEmpty(SubcountyId) && o.SubcountyId.HasValue == true && SubcountyId.Split(",").Any(x => x == o.SubcountyId.ToString())))
                    && (string.IsNullOrEmpty(HouseholdId) == true || (!string.IsNullOrEmpty(HouseholdId) && o.HouseholdId.HasValue == true && HouseholdId.Split(",").Any(x => x == o.HouseholdId.ToString())))
                    && (string.IsNullOrEmpty(NatureofResidenceId) == true || (!string.IsNullOrEmpty(NatureofResidenceId) && o.NatureofResidenceId.HasValue == true && NatureofResidenceId.Split(",").Any(x => x == o.NatureofResidenceId.ToString())))
                    && (string.IsNullOrEmpty(CategoryofResidenceId) == true || (!string.IsNullOrEmpty(CategoryofResidenceId) && o.CategoryofResidenceId.HasValue == true && CategoryofResidenceId.Split(",").Any(x => x == o.CategoryofResidenceId.ToString())))
                    ).ToList();

                if (data != null && data.Count > 0)
                {
                    var BusinessOpportunitydetails = _context.IsvatcurrentBusinessOpportunity.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
                    if (BusinessOpportunitydetails != null && BusinessOpportunitydetails.Count > 0)
                    {
                        foreach (var item in data)
                        {
                            item.IsvatcurrentBusinessOpportunity = BusinessOpportunitydetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
                        }
                    }

                    var BusinessRiskdetails = _context.IsvatcurrentBusinessRisk.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
                    if (BusinessRiskdetails != null && BusinessRiskdetails.Count > 0)
                    {
                        foreach (var item in data)
                        {
                            item.IsvatcurrentBusinessRisk = BusinessRiskdetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
                        }
                    }

                    var generatedProfitdetails = _context.IsvatgeneratedProfit.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
                    if (generatedProfitdetails != null && generatedProfitdetails.Count > 0)
                    {
                        foreach (var item in data)
                        {
                            item.IsvatgeneratedProfit = generatedProfitdetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
                        }
                    }

                    var lossdetails = _context.Isvatloss.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
                    if (lossdetails != null && lossdetails.Count > 0)
                    {
                        foreach (var item in data)
                        {
                            item.Isvatloss = lossdetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
                        }
                    }

                    var BusinessAnswerdetails = _context.IsvatstartBusinessAnswer.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
                    if (BusinessAnswerdetails != null && BusinessAnswerdetails.Count > 0)
                    {
                        foreach (var item in data)
                        {
                            item.IsvatstartBusinessAnswer = BusinessAnswerdetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
                        }
                    }

                    var workingCapitaldetails = _context.IsvatworkingCapital.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
                    if (workingCapitaldetails != null && workingCapitaldetails.Count > 0)
                    {
                        foreach (var item in data)
                        {
                            item.IsvatworkingCapital = workingCapitaldetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
                        }
                    }

                    var incomeEarnerdetails = _context.IsvatincomeEarner.AsNoTracking().ToList().Where(o => data.Any(x => x.IsvatheaderId == o.IsvatheaderId)).ToList();
                    if (incomeEarnerdetails != null && incomeEarnerdetails.Count > 0)
                    {
                        var Incomeowners = _context.IsvatincomeOwnership.AsNoTracking().ToList().Where(o => incomeEarnerdetails.Any(x => x.IsvatincomeEarnerId == o.IsvatincomeEarnerId)).ToList();
                        if (Incomeowners != null && Incomeowners.Count > 0)
                        {
                            foreach (var item in incomeEarnerdetails)
                            {
                                item.IsvatincomeOwnership = Incomeowners.Where(o => o.IsvatincomeEarnerId == item.IsvatincomeEarnerId).ToList();
                            }
                        }

                        foreach (var item in data)
                        {
                            item.IsvatincomeEarner = incomeEarnerdetails.Where(o => o.IsvatheaderId == item.IsvatheaderId).ToList();
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

        public async Task<BimPrimaryData?> GetPrimaryData()
        {
            BimPrimaryData? data = new BimPrimaryData();
            try
            {
                data.GenderData = await _context.AGender.AsNoTracking().ToListAsync();
                data.MaritalStatusData = await _context.AMaritalStatus.AsNoTracking().ToListAsync();
                data.SubcountyData = await _context.ASubcounty.AsNoTracking().ToListAsync();
                data.DistrictData = await _context.ADistrict.AsNoTracking().ToListAsync();
                data.ParishData = await _context.AParish.AsNoTracking().ToListAsync();
                data.VillageData = await _context.AVillage.AsNoTracking().ToListAsync();
                data.NatureofResidenceData = await _context.ANatureofResidence.AsNoTracking().ToListAsync();
                data.CategoryofResidenceData = await _context.ACategoryofResidence.AsNoTracking().ToListAsync();
                data.BusinessPlanQuestionData = await _context.ABusinessPlanQuestion.AsNoTracking().ToListAsync();
                data.YesNoData = await _context.AYesNo.AsNoTracking().ToListAsync();
                data.AssetIncomeData = await _context.AAssetIncome.AsNoTracking().ToListAsync();
                data.RiskLevelRatingData = await _context.ARiskLevelRating.AsNoTracking().ToListAsync();
                data.BusinessVentureCapitalInvestmentData = await _context.ABusinessVentureCapitalInvestment.AsNoTracking().ToListAsync();
                data.BusinessOpportunityData = await _context.ACurrenBusinessOpportunity.AsNoTracking().ToListAsync();
                data.BusinessRiskData = await _context.ACurrenBusinessRisk.AsNoTracking().ToListAsync();
                data.StartBusinessQuestionData = await _context.AStartBusinessQuestion.AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return data;
        }

        public async Task<Response?> SaveBusinessPlan(BusinessPlanHeader record)
        {
            Response? data = new Response();
            try
            {
                var exists = _context.BusinessPlanHeader.FirstOrDefault(o => o.BusinessPlanHeaderId == record.BusinessPlanHeaderId);
                if (exists != null)
                {
                    _context.Entry(exists).CurrentValues.SetValues(record);
                    _context.Entry(exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    int id = 1;
                    var lastrecord = _context.BusinessPlanHeader.OrderBy(o => o.BusinessPlanHeaderId).ToList().LastOrDefault();
                    if (lastrecord != null)
                    {
                        id = (lastrecord.BusinessPlanHeaderId + 1);
                    }
                    record.BusinessPlanHeaderId = id;
                    BusinessPlanHeader m = new BusinessPlanHeader();
                    m.BusinessPlanHeaderId = record.BusinessPlanHeaderId;
                    m.DistrictId = record.DistrictId;
                    m.SubcountyId = record.SubcountyId;
                    m.ParishId = record.ParishId;
                    m.VillageId = record.VillageId;
                    m.HouseholdId = record.HouseholdId;
                    m.HouseholdMemberId = record.HouseholdMemberId;
                    m.NatureofResidenceId = record.NatureofResidenceId;
                    m.CategoryofResidenceId = record.CategoryofResidenceId;
                    m.GenderId = record.GenderId;
                    m.Dob = record.Dob;
                    m.Age = record.Age;
                    m.MaritalStatusId = record.MaritalStatusId;
                    m.DataCollectorName = record.DataCollectorName;
                    m.DataCollectorTitle = record.DataCollectorTitle;
                    m.DataCollectionDate = record.DataCollectionDate;
                    m.DataReviewerName = record.DataReviewerName;
                    m.DataReviewerTitle = record.DataReviewerTitle;
                    m.DataReviewDate = record.DataReviewDate;
                    _context.BusinessPlanHeader.Add(m);
                    await _context.SaveChangesAsync();

                }

                if (record.BusinessPlanDetail != null && record.BusinessPlanDetail.Any() && record.BusinessPlanHeaderId > 0)
                {
                    foreach (var item in record.BusinessPlanDetail)
                    {
                        var _exists = _context.BusinessPlanDetail.FirstOrDefault(o => o.BusinessPlanDetailId == item.BusinessPlanDetailId
                        || (o.BusinessPlanHeaderId == record.BusinessPlanHeaderId && o.BusinessPlanQuestionId == item.BusinessPlanQuestionId));
                        if (_exists != null)
                        {
                            item.BusinessPlanDetailId = _exists.BusinessPlanDetailId;
                            item.BusinessPlanHeaderId = record.BusinessPlanHeaderId;

                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int id = 1;
                            var lastrecord = _context.BusinessPlanDetail.OrderBy(o => o.BusinessPlanDetailId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                id = (lastrecord.BusinessPlanDetailId + 1);
                            }
                            item.BusinessPlanDetailId = id;
                            item.BusinessPlanHeaderId = record.BusinessPlanHeaderId;
                            _context.BusinessPlanDetail.Add(item);
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                data = new Response() { IsSuccess = true, Message = "Record was successfully saved.", Status = "Success!" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                data = new Response() { IsSuccess = false, Message = ex.Message, Status = "Error!" };
            }
            return data;
        }

        public async Task<Response?> SaveBusinessTrackingLedger(BusinessTrackingLedger record)
        {
            Response? data = new Response();
            try
            {
                var exists = _context.BusinessTrackingLedger.FirstOrDefault(o => o.BusinessTrackingLedgerId == record.BusinessTrackingLedgerId);
                if (exists != null)
                {
                    _context.Entry(exists).CurrentValues.SetValues(record);
                    _context.Entry(exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    int id = 1;
                    var lastrecord = _context.BusinessTrackingLedger.OrderBy(o => o.BusinessTrackingLedgerId).ToList().LastOrDefault();
                    if (lastrecord != null)
                    {
                        id = (lastrecord.BusinessTrackingLedgerId + 1);
                    }
                    record.BusinessTrackingLedgerId = id;
                    BusinessTrackingLedger m = new BusinessTrackingLedger();
                    m.BusinessTrackingLedgerId = record.BusinessTrackingLedgerId;
                    m.ProposedBusinessName = record.ProposedBusinessName;
                    m.StartupExpenseTotalAmount = record.StartupExpenseTotalAmount;
                    m.BusinessViabilityAnalysisTotalAmount = record.BusinessViabilityAnalysisTotalAmount;
                    m.EstimatedOutputPerDay = record.EstimatedOutputPerDay;
                    m.NetProfits = record.NetProfits;
                    m.DataCollectorName = record.DataCollectorName;
                    m.DataCollectorTitle = record.DataCollectorTitle;
                    m.DataCollectionDate = record.DataCollectionDate;
                    m.DataReviewerName = record.DataReviewerName;
                    m.DataReviewerTitle = record.DataReviewerTitle;
                    m.DataReviewDate = record.DataReviewDate;

                    _context.BusinessTrackingLedger.Add(m);
                    await _context.SaveChangesAsync();

                }

                if (record.BusinessTrackingLedgerSue != null && record.BusinessTrackingLedgerSue.Any() && record.BusinessTrackingLedgerId > 0)
                {
                    foreach (var item in record.BusinessTrackingLedgerSue)
                    {
                        var _exists = _context.BusinessTrackingLedgerSue.ToList().FirstOrDefault(o => o.StartUpExpensesId == item.StartUpExpensesId
                        || (o.BusinessTrackingLedgerId == record.BusinessTrackingLedgerId && !string.IsNullOrEmpty(o.Item) && !string.IsNullOrEmpty(item.Item) && Regex.Replace(o.Item, @"\s", "") == Regex.Replace(item.Item, @"\s", "")));
                        if (_exists != null)
                        {
                            item.StartUpExpensesId = _exists.StartUpExpensesId;
                            item.BusinessTrackingLedgerId = record.BusinessTrackingLedgerId;

                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int id = 1;
                            var lastrecord = _context.BusinessTrackingLedgerSue.OrderBy(o => o.StartUpExpensesId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                id = (lastrecord.StartUpExpensesId + 1);
                            }
                            item.StartUpExpensesId = id;
                            item.BusinessTrackingLedgerId = record.BusinessTrackingLedgerId;
                            _context.BusinessTrackingLedgerSue.Add(item);
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                if (record.BusinessTrackingLedgerMoc != null && record.BusinessTrackingLedgerMoc.Any() && record.BusinessTrackingLedgerId > 0)
                {
                    foreach (var item in record.BusinessTrackingLedgerMoc)
                    {
                        var _exists = _context.BusinessTrackingLedgerMoc.ToList().FirstOrDefault(o => o.MonthlyOperationalCostsId == item.MonthlyOperationalCostsId
                        || (o.BusinessTrackingLedgerId == record.BusinessTrackingLedgerId && !string.IsNullOrEmpty(o.Item) && !string.IsNullOrEmpty(item.Item) && Regex.Replace(o.Item, @"\s", "") == Regex.Replace(item.Item, @"\s", "")));
                        if (_exists != null)
                        {
                            item.MonthlyOperationalCostsId = _exists.MonthlyOperationalCostsId;
                            item.BusinessTrackingLedgerId = record.BusinessTrackingLedgerId;

                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int id = 1;
                            var lastrecord = _context.BusinessTrackingLedgerMoc.OrderBy(o => o.MonthlyOperationalCostsId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                id = (lastrecord.MonthlyOperationalCostsId + 1);
                            }
                            item.MonthlyOperationalCostsId = id;
                            item.BusinessTrackingLedgerId = record.BusinessTrackingLedgerId;
                            _context.BusinessTrackingLedgerMoc.Add(item);
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                data = new Response() { IsSuccess = true, Message = "Record was successfully saved.", Status = "Success!" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                data = new Response() { IsSuccess = false, Message = ex.Message, Status = "Error!" };
            }
            return data;
        }

        public async Task<Response?> SaveIsvat(Isvatheader record)
        {
            Response? data = new Response();
            try
            {
                var exists = _context.Isvatheader.FirstOrDefault(o => o.IsvatheaderId == record.IsvatheaderId);
                if (exists != null)
                {
                    _context.Entry(exists).CurrentValues.SetValues(record);
                    _context.Entry(exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    int id = 1;
                    var lastrecord = _context.Isvatheader.OrderBy(o => o.IsvatheaderId).ToList().LastOrDefault();
                    if (lastrecord != null)
                    {
                        id = (lastrecord.IsvatheaderId + 1);
                    }
                    record.IsvatheaderId = id;
                    Isvatheader m = new Isvatheader();
                    m.IsvatheaderId = record.IsvatheaderId;
                    m.DistrictId = record.DistrictId;
                    m.SubcountyId = record.SubcountyId;
                    m.ParishId = record.ParishId;
                    m.VillageId = record.VillageId;
                    m.HouseholdId = record.HouseholdId;
                    m.HouseholdMemberId = record.HouseholdMemberId;
                    m.NatureofResidenceId = record.NatureofResidenceId;
                    m.CategoryofResidenceId = record.CategoryofResidenceId;
                    m.GenderId = record.GenderId;
                    m.Dob = record.Dob;
                    m.Age = record.Age;
                    m.DataCollectorName = record.DataCollectorName;
                    m.DataCollectorTitle = record.DataCollectorTitle;
                    m.DataCollectionDate = record.DataCollectionDate;
                    m.DataReviewerName = record.DataReviewerName;
                    m.DataReviewerTitle = record.DataReviewerTitle;
                    m.DataReviewDate = record.DataReviewDate;


                    _context.Isvatheader.Add(m);
                    await _context.SaveChangesAsync();

                }

                if (record.IsvatworkingCapital != null && record.IsvatworkingCapital.Any() && record.IsvatheaderId > 0)
                {
                    foreach (var item in record.IsvatworkingCapital)
                    {
                        var _exists = _context.IsvatworkingCapital.ToList().FirstOrDefault(o => o.IsvatworkingCapitalId == item.IsvatworkingCapitalId
                        || (o.IsvatheaderId == record.IsvatheaderId && o.AssetIncomeId == item.AssetIncomeId));
                        if (_exists != null)
                        {
                            item.IsvatworkingCapitalId = _exists.IsvatworkingCapitalId;
                            item.IsvatheaderId = record.IsvatheaderId;

                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int id = 1;
                            var lastrecord = _context.IsvatworkingCapital.OrderBy(o => o.IsvatworkingCapitalId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                id = (lastrecord.IsvatworkingCapitalId + 1);
                            }
                            item.IsvatworkingCapitalId = id;
                            item.IsvatheaderId = record.IsvatheaderId;
                            _context.IsvatworkingCapital.Add(item);
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                if (record.IsvatcurrentBusinessOpportunity != null && record.IsvatcurrentBusinessOpportunity.Any() && record.IsvatheaderId > 0)
                {
                    foreach (var item in record.IsvatcurrentBusinessOpportunity)
                    {
                        var _exists = _context.IsvatcurrentBusinessOpportunity.ToList().FirstOrDefault(o => o.IsvatcurrentBusinessOpportunityId == item.IsvatcurrentBusinessOpportunityId
                        || (o.IsvatheaderId == record.IsvatheaderId && o.CurrenBusinessOpportunityId == item.CurrenBusinessOpportunityId));
                        if (_exists != null)
                        {
                            item.IsvatcurrentBusinessOpportunityId = _exists.IsvatcurrentBusinessOpportunityId;
                            item.IsvatheaderId = record.IsvatheaderId;

                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int id = 1;
                            var lastrecord = _context.IsvatcurrentBusinessOpportunity.OrderBy(o => o.IsvatcurrentBusinessOpportunityId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                id = (lastrecord.IsvatcurrentBusinessOpportunityId + 1);
                            }
                            item.IsvatcurrentBusinessOpportunityId = id;
                            item.IsvatheaderId = record.IsvatheaderId;
                            _context.IsvatcurrentBusinessOpportunity.Add(item);
                            await _context.SaveChangesAsync();
                        }
                    }
                }
                if (record.IsvatcurrentBusinessRisk != null && record.IsvatcurrentBusinessRisk.Any() && record.IsvatheaderId > 0)
                {
                    foreach (var item in record.IsvatcurrentBusinessRisk)
                    {
                        var _exists = _context.IsvatcurrentBusinessRisk.ToList().FirstOrDefault(o => o.IsvatcurrentBusinessRiskId == item.IsvatcurrentBusinessRiskId
                        || (o.IsvatheaderId == record.IsvatheaderId && o.CurrenBusinessRiskId == item.CurrenBusinessRiskId));
                        if (_exists != null)
                        {
                            item.IsvatcurrentBusinessRiskId = _exists.IsvatcurrentBusinessRiskId;
                            item.IsvatheaderId = record.IsvatheaderId;

                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int id = 1;
                            var lastrecord = _context.IsvatcurrentBusinessRisk.OrderBy(o => o.IsvatcurrentBusinessRiskId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                id = (lastrecord.IsvatcurrentBusinessRiskId + 1);
                            }
                            item.IsvatcurrentBusinessRiskId = id;
                            item.IsvatheaderId = record.IsvatheaderId;
                            _context.IsvatcurrentBusinessRisk.Add(item);
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                if (record.IsvatgeneratedProfit != null && record.IsvatgeneratedProfit.Any() && record.IsvatheaderId > 0)
                {
                    foreach (var item in record.IsvatgeneratedProfit)
                    {
                        var _exists = _context.IsvatgeneratedProfit.ToList().FirstOrDefault(o => o.IsvatgeneratedProfitId == item.IsvatgeneratedProfitId
                        || (o.IsvatheaderId == record.IsvatheaderId && o.AssetIncomeId == item.AssetIncomeId));
                        if (_exists != null)
                        {
                            item.IsvatgeneratedProfitId = _exists.IsvatgeneratedProfitId;
                            item.IsvatheaderId = record.IsvatheaderId;

                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int id = 1;
                            var lastrecord = _context.IsvatgeneratedProfit.OrderBy(o => o.IsvatgeneratedProfitId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                id = (lastrecord.IsvatgeneratedProfitId + 1);
                            }
                            item.IsvatgeneratedProfitId = id;
                            item.IsvatheaderId = record.IsvatheaderId;
                            _context.IsvatgeneratedProfit.Add(item);
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                if (record.Isvatloss != null && record.Isvatloss.Any() && record.IsvatheaderId > 0)
                {
                    foreach (var item in record.Isvatloss)
                    {
                        var _exists = _context.Isvatloss.ToList().FirstOrDefault(o => o.IsvatlossId == item.IsvatlossId
                        || (o.IsvatheaderId == record.IsvatheaderId && o.BusinessVentureCapitalInvestmentId == item.BusinessVentureCapitalInvestmentId));
                        if (_exists != null)
                        {
                            item.IsvatlossId = _exists.IsvatlossId;
                            item.IsvatheaderId = record.IsvatheaderId;

                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int id = 1;
                            var lastrecord = _context.Isvatloss.OrderBy(o => o.IsvatlossId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                id = (lastrecord.IsvatlossId + 1);
                            }
                            item.IsvatlossId = id;
                            item.IsvatheaderId = record.IsvatheaderId;
                            _context.Isvatloss.Add(item);
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                if (record.IsvatstartBusinessAnswer != null && record.IsvatstartBusinessAnswer.Any() && record.IsvatheaderId > 0)
                {
                    foreach (var item in record.IsvatstartBusinessAnswer)
                    {
                        var _exists = _context.IsvatstartBusinessAnswer.ToList().FirstOrDefault(o => o.IsvatstartBusinessAnswerId == item.IsvatstartBusinessAnswerId
                        || (o.IsvatheaderId == record.IsvatheaderId && o.StartBusinessQuestionId == item.StartBusinessQuestionId));
                        if (_exists != null)
                        {
                            item.IsvatstartBusinessAnswerId = _exists.IsvatstartBusinessAnswerId;
                            item.IsvatheaderId = record.IsvatheaderId;

                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int id = 1;
                            var lastrecord = _context.IsvatstartBusinessAnswer.OrderBy(o => o.IsvatstartBusinessAnswerId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                id = (lastrecord.IsvatstartBusinessAnswerId + 1);
                            }
                            item.IsvatstartBusinessAnswerId = id;
                            item.IsvatheaderId = record.IsvatheaderId;
                            _context.IsvatstartBusinessAnswer.Add(item);
                            await _context.SaveChangesAsync();
                        }
                    }
                }

                if (record.IsvatincomeEarner != null && record.IsvatincomeEarner.Any() && record.IsvatheaderId > 0)
                {
                    foreach (var item in record.IsvatincomeEarner)
                    {
                        var _exists = _context.IsvatincomeEarner.ToList().FirstOrDefault(o => o.IsvatincomeEarnerId == item.IsvatincomeEarnerId
                        || (o.IsvatheaderId == record.IsvatheaderId && o.HouseHoldMemberId == item.HouseHoldMemberId));
                        if (_exists != null)
                        {
                            item.IsvatincomeEarnerId = _exists.IsvatincomeEarnerId;
                            item.IsvatheaderId = record.IsvatheaderId;

                            _context.Entry(_exists).CurrentValues.SetValues(item);
                            _context.Entry(_exists).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            int id = 1;
                            var lastrecord = _context.IsvatincomeEarner.OrderBy(o => o.IsvatincomeEarnerId).ToList().LastOrDefault();
                            if (lastrecord != null)
                            {
                                id = (lastrecord.IsvatincomeEarnerId + 1);
                            }
                            item.IsvatincomeEarnerId = id;
                            item.IsvatheaderId = record.IsvatheaderId;

                            IsvatincomeEarner m = new IsvatincomeEarner();

                            m.IsvatincomeEarnerId = item.IsvatincomeEarnerId;
                            m.IsvatheaderId = item.IsvatheaderId;
                            m.HouseHoldMemberId = item.HouseHoldMemberId;
                            m.IncomeEarnerYesNoId = item.IncomeEarnerYesNoId;

                            _context.IsvatincomeEarner.Add(m);
                            await _context.SaveChangesAsync();
                        }

                        if (item.IsvatincomeOwnership != null && item.IsvatincomeOwnership.Any() && item.IsvatincomeEarnerId > 0)
                        {
                            foreach (var _item in item.IsvatincomeOwnership)
                            {
                                var exists1 = _context.IsvatincomeOwnership.ToList().FirstOrDefault(o => o.IsvatincomeOwnershipId == _item.IsvatincomeOwnershipId
                                || (o.IsvatincomeEarnerId == item.IsvatincomeEarnerId && o.AssetIncomeId == _item.AssetIncomeId));
                                if (exists1 != null)
                                {
                                    _item.IsvatincomeOwnershipId = exists1.IsvatincomeOwnershipId;
                                    _item.IsvatincomeEarnerId = item.IsvatincomeEarnerId;

                                    _context.Entry(exists1).CurrentValues.SetValues(_item);
                                    _context.Entry(exists1).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                }
                                else
                                {
                                    int id = 1;
                                    var lastrecord = _context.IsvatincomeOwnership.OrderBy(o => o.IsvatincomeOwnershipId).ToList().LastOrDefault();
                                    if (lastrecord != null)
                                    {
                                        id = (lastrecord.IsvatincomeOwnershipId + 1);
                                    }
                                    _item.IsvatincomeOwnershipId = id;
                                    _item.IsvatincomeEarnerId = item.IsvatincomeEarnerId;
                                    _context.IsvatincomeOwnership.Add(_item);
                                    await _context.SaveChangesAsync();
                                }
                            }
                        }
                    }
                }

                data = new Response() { IsSuccess = true, Message = "Record was successfully saved.", Status = "Success!" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                data = new Response() { IsSuccess = false, Message = ex.Message, Status = "Error!" };
            }
            return data;
        }
    }
>>>>>>> 8bc1de6fbfadf219bc83e728615777a61ac50699
}
