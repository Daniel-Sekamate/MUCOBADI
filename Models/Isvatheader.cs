using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class Isvatheader
    {
        public Isvatheader()
        {
            IsvatcurrentBusinessOpportunity = new HashSet<IsvatcurrentBusinessOpportunity>();
            IsvatcurrentBusinessRisk = new HashSet<IsvatcurrentBusinessRisk>();
            IsvatgeneratedProfit = new HashSet<IsvatgeneratedProfit>();
            IsvatincomeEarner = new HashSet<IsvatincomeEarner>();
            Isvatloss = new HashSet<Isvatloss>();
            IsvatstartBusinessAnswer = new HashSet<IsvatstartBusinessAnswer>();
            IsvatworkingCapital = new HashSet<IsvatworkingCapital>();
        }

        public int IsvatheaderId { get; set; }
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
        public virtual ANatureofResidence NatureofResidence { get; set; }
        public virtual AParish Parish { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual AVillage Village { get; set; }
        public virtual ICollection<IsvatcurrentBusinessOpportunity> IsvatcurrentBusinessOpportunity { get; set; }
        public virtual ICollection<IsvatcurrentBusinessRisk> IsvatcurrentBusinessRisk { get; set; }
        public virtual ICollection<IsvatgeneratedProfit> IsvatgeneratedProfit { get; set; }
        public virtual ICollection<IsvatincomeEarner> IsvatincomeEarner { get; set; }
        public virtual ICollection<Isvatloss> Isvatloss { get; set; }
        public virtual ICollection<IsvatstartBusinessAnswer> IsvatstartBusinessAnswer { get; set; }
        public virtual ICollection<IsvatworkingCapital> IsvatworkingCapital { get; set; }
    }
}
