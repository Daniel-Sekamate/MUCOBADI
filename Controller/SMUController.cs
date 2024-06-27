using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MUCOBADI.DTOs;
using MUCOBADI.Interfaces.SMUtools;
using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUCOBADI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMUController : ControllerBase
    {
        private readonly ISMUtools _smuTools;
        private readonly MUCOBADIContext _context;
        public SMUController(ISMUtools sMUtools, MUCOBADIContext context)
        {
          _smuTools = sMUtools;
          _context = context;
        }
        [HttpPost("SaveSMUGroup")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Response> SaveSMUGroup(SmuGroup? group)
        {
            return await _smuTools.SaveSMUGroup(group);
        }
        [HttpGet("GetAllSMUGroups")]
        public async Task<ActionResult<PagedResult<List<SmuGroup>>>> GetAllSMUGroups(int page = 1, int pageSize = 30, string? searchTerm = "")
        {
            var result = await _smuTools.GetAllSMUGroups(page, pageSize, searchTerm);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetClientRegisteredByGroupId")]
        public async Task<ActionResult<List<SmuClientRegistrationForm>>> GetClientRegisteredByGroupId(int SMUGroupId)
        {
            var result = await _smuTools.GetClientRegisteredByGroupId(SMUGroupId);
            return Ok(result);
        }

        //[HttpGet("GenerateClientRegistrationReport")]
        //public async Task<IActionResult> GenerateClientRegistrationReport(
        //   DateTime? startDate,
        //   DateTime? endDate,
        //   string? smuGroupIds = "",
        //   string? regionIds = "",
        //   string? districtIds = "",
        //   string? subcountyIds = "",
        //   string? clientAgeRangeIds = "",
        //   string? smuOfficeIds = "",
        //   string? smuFacilitatorIds = "")
        //{
        //    var fileContent = await _smuTools.GenerateClientRegistrationReport(
        //        startDate, endDate, smuGroupIds, regionIds, districtIds, subcountyIds, clientAgeRangeIds, smuOfficeIds, smuFacilitatorIds);

        //    return File(fileContent, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ClientRegistrationReport.xlsx");
        //}
    }
}
