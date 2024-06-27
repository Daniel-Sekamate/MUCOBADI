using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class InterventionAttendanceForm
    {
        public InterventionAttendanceForm()
        {
            InterventionAttendanceFormDetail = new HashSet<InterventionAttendanceFormDetail>();
            InterventionAttendanceFormInstructor = new HashSet<InterventionAttendanceFormInstructor>();
        }

        public int InterventionAttendanceFormId { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public int? InterventionTypeId { get; set; }
        public DateTime? AttendenceStartDate { get; set; }
        public DateTime? AttendenceEndDate { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public int? SampledForId { get; set; }
        public string GroupName { get; set; }
        public int? DeliveryMethodId { get; set; }
        public string Venue { get; set; }
        public int? NumberDisclosingSexualViolence { get; set; }
        public int? NumberRefered { get; set; }
        public string SerialNo { get; set; }
        public string ReviewdBy { get; set; }

        public virtual ADeliveryMethod DeliveryMethod { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual AInterventionType InterventionType { get; set; }
        public virtual AParish Parish { get; set; }
        public virtual ANmnSampledFor SampledFor { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual AVillage Village { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetail { get; set; }
        public virtual ICollection<InterventionAttendanceFormInstructor> InterventionAttendanceFormInstructor { get; set; }
    }
}
