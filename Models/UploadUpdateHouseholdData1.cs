using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class UploadUpdateHouseholdData1
    {
        public string District { get; set; }
        public string HibridSubcounty { get; set; }
        public string Parish { get; set; }
        public string Village { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string HouseholdCode { get; set; }
        public string HouseholdMemberCode { get; set; }
        public string HouseholdMemberName { get; set; }
        public string Surname { get; set; }
        public string Givenname { get; set; }
        public string Sex { get; set; }
        public double? Age { get; set; }
        public string AgeCategory { get; set; }
        public string Iscaregiver { get; set; }
        public string AdjustedHivStatus { get; set; }
        public string AdjustedRiskFactorQ3Final { get; set; }
        public string ProgramParticipationStatus { get; set; }
    }
}
