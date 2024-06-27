using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class EcdAttendenceRegister
    {
        public EcdAttendenceRegister()
        {
            EcdDirectMemberAttendence = new HashSet<EcdDirectMemberAttendence>();
            EcdIndirectMemberAttendence = new HashSet<EcdIndirectMemberAttendence>();
        }

        public int SinoParentingId { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public string Venue { get; set; }
        public int? GroupCompositionCode { get; set; }
        public string MotherSpace { get; set; }
        public string FacilitatorOne { get; set; }
        public string FacilitatorOneCode { get; set; }
        public string FacilitatorTwo { get; set; }
        public string FacilitatorTwoCode { get; set; }
        public string SubmittedBy { get; set; }
        public string SubmittedTitle { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewTitle { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int? GroupId { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual AGroups Group { get; set; }
        public virtual VslaGroupComposition GroupCompositionCodeNavigation { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual AParish Parish { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<EcdDirectMemberAttendence> EcdDirectMemberAttendence { get; set; }
        public virtual ICollection<EcdIndirectMemberAttendence> EcdIndirectMemberAttendence { get; set; }
    }
}
