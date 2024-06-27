using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AInterventionAttendance
    {
        public AInterventionAttendance()
        {
            InterventionAttendanceFormDetailModuleEightInterventionAttendance = new HashSet<InterventionAttendanceFormDetail>();
            InterventionAttendanceFormDetailModuleFiveInterventionAttendance = new HashSet<InterventionAttendanceFormDetail>();
            InterventionAttendanceFormDetailModuleFourInterventionAttendance = new HashSet<InterventionAttendanceFormDetail>();
            InterventionAttendanceFormDetailModuleNineInterventionAttendance = new HashSet<InterventionAttendanceFormDetail>();
            InterventionAttendanceFormDetailModuleOneInterventionAttendance = new HashSet<InterventionAttendanceFormDetail>();
            InterventionAttendanceFormDetailModuleSevenInterventionAttendance = new HashSet<InterventionAttendanceFormDetail>();
            InterventionAttendanceFormDetailModuleSixInterventionAttendance = new HashSet<InterventionAttendanceFormDetail>();
            InterventionAttendanceFormDetailModuleTenInterventionAttendance = new HashSet<InterventionAttendanceFormDetail>();
            InterventionAttendanceFormDetailModuleThreeInterventionAttendance = new HashSet<InterventionAttendanceFormDetail>();
            InterventionAttendanceFormDetailModuleTwoInterventionAttendance = new HashSet<InterventionAttendanceFormDetail>();
        }

        public int InterventionAttendanceId { get; set; }
        public string InterventionAttendanceDesc { get; set; }

        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetailModuleEightInterventionAttendance { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetailModuleFiveInterventionAttendance { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetailModuleFourInterventionAttendance { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetailModuleNineInterventionAttendance { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetailModuleOneInterventionAttendance { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetailModuleSevenInterventionAttendance { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetailModuleSixInterventionAttendance { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetailModuleTenInterventionAttendance { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetailModuleThreeInterventionAttendance { get; set; }
        public virtual ICollection<InterventionAttendanceFormDetail> InterventionAttendanceFormDetailModuleTwoInterventionAttendance { get; set; }
    }
}
