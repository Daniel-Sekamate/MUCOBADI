using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BusinessPlanHeader
    {
        public BusinessPlanHeader()
        {
            BusinessPlanDetail = new HashSet<BusinessPlanDetail>();
        }

        public int BusinessPlanHeaderId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public int? HouseholdId { get; set; }
        public int? HouseholdMemberId { get; set; }
        public int? NatureofResidenceId { get; set; }
        public int? CategoryofResidenceId { get; set; }
        public string GenderId { get; set; }
        public DateTime? Dob { get; set; }
        public int? Age { get; set; }
        public int? MaritalStatusId { get; set; }
        public string DataCollectorName { get; set; }
        public string DataCollectorTitle { get; set; }
        public DateTime? DataCollectionDate { get; set; }
        public string DataReviewerName { get; set; }
        public string DataReviewerTitle { get; set; }
        public DateTime? DataReviewDate { get; set; }

        public virtual ACategoryofResidence CategoryofResidence { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AGender Gender { get; set; }
        public virtual BeneficiaryIdentificationRegister Household { get; set; }
        public virtual HouseHoldMembers HouseholdMember { get; set; }
        public virtual AMaritalStatus MaritalStatus { get; set; }
        public virtual ANatureofResidence NatureofResidence { get; set; }
        public virtual AParish Parish { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual AVillage Village { get; set; }
        public virtual ICollection<BusinessPlanDetail> BusinessPlanDetail { get; set; }
    }
}
