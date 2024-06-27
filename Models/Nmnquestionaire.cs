using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class Nmnquestionaire
    {
        public Nmnquestionaire()
        {
            NmnquestionaireSectionOne = new HashSet<NmnquestionaireSectionOne>();
            NmnquestionaireSectionTwo = new HashSet<NmnquestionaireSectionTwo>();
        }

        public int Nmnid { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public DateTime? QuestionairDate { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public string GroupName { get; set; }
        public int? SampledForId { get; set; }
        public int? DeliveryMethodId { get; set; }
        public int? ImplementationMethodId { get; set; }
        public string InstructorNames { get; set; }
        public int? InstructorAge { get; set; }
        public string SerialNo { get; set; }

        public virtual ADeliveryMethod DeliveryMethod { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AImplementationMethod ImplementationMethod { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual AParish Parish { get; set; }
        public virtual ANmnSampledFor SampledFor { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual AVillage Village { get; set; }
        public virtual ICollection<NmnquestionaireSectionOne> NmnquestionaireSectionOne { get; set; }
        public virtual ICollection<NmnquestionaireSectionTwo> NmnquestionaireSectionTwo { get; set; }
    }
}
