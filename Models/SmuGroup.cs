using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuGroup
    {
        public SmuGroup()
        {
            SmuAssessmentGuide = new HashSet<SmuAssessmentGuide>();
            SmuAttendenceHeader = new HashSet<SmuAttendenceHeader>();
            SmuClientRegistrationForm = new HashSet<SmuClientRegistrationForm>();
            SmuPreGroupGuide = new HashSet<SmuPreGroupGuide>();
            SmuSafetyPlanningForm = new HashSet<SmuSafetyPlanningForm>();
            SmuTerminantionGuide = new HashSet<SmuTerminantionGuide>();
        }

        public int SmuGroupId { get; set; }
        public string SmuGroupName { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CapturedBy { get; set; }
        public int? DistrictId { get; set; }
        public int? RegionId { get; set; }
        public DateTime? RegistartionDate { get; set; }
        public int? SmuFacilitatorId { get; set; }
        public int? SmuOfficeId { get; set; }
        public int? SubcountyId { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual ARegion Region { get; set; }
        public virtual SmuFacilitator SmuFacilitator { get; set; }
        public virtual SmuOffice SmuOffice { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<SmuAssessmentGuide> SmuAssessmentGuide { get; set; }
        public virtual ICollection<SmuAttendenceHeader> SmuAttendenceHeader { get; set; }
        public virtual ICollection<SmuClientRegistrationForm> SmuClientRegistrationForm { get; set; }
        public virtual ICollection<SmuPreGroupGuide> SmuPreGroupGuide { get; set; }
        public virtual ICollection<SmuSafetyPlanningForm> SmuSafetyPlanningForm { get; set; }
        public virtual ICollection<SmuTerminantionGuide> SmuTerminantionGuide { get; set; }
    }
}
