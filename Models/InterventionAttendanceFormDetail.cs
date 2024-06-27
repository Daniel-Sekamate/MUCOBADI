using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class InterventionAttendanceFormDetail
    {
        public int InterventionAttendanceFormDetailId { get; set; }
        public int? InterventionAttendanceFormId { get; set; }
        public string UniqueId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public DateTime? ModuleOneDate { get; set; }
        public int? ModuleOneInterventionAttendanceId { get; set; }
        public DateTime? ModuleTwoDate { get; set; }
        public int? ModuleTwoInterventionAttendanceId { get; set; }
        public DateTime? ModuleThreeDate { get; set; }
        public int? ModuleThreeInterventionAttendanceId { get; set; }
        public DateTime? ModuleFourDate { get; set; }
        public int? ModuleFourInterventionAttendanceId { get; set; }
        public DateTime? ModuleFiveDate { get; set; }
        public int? ModuleFiveInterventionAttendanceId { get; set; }
        public DateTime? ModuleSixDate { get; set; }
        public int? ModuleSixInterventionAttendanceId { get; set; }
        public DateTime? ModuleSevenDate { get; set; }
        public int? ModuleSevenInterventionAttendanceId { get; set; }
        public DateTime? ModuleEightDate { get; set; }
        public int? ModuleEightInterventionAttendanceId { get; set; }
        public DateTime? ModuleNineDate { get; set; }
        public int? ModuleNineInterventionAttendanceId { get; set; }
        public DateTime? ModuleTenDate { get; set; }
        public int? ModuleTenInterventionAttendanceId { get; set; }
        public int? GraduatedYesNoId { get; set; }

        public virtual AYesNo GraduatedYesNo { get; set; }
        public virtual InterventionAttendanceForm InterventionAttendanceForm { get; set; }
        public virtual AInterventionAttendance ModuleEightInterventionAttendance { get; set; }
        public virtual AInterventionAttendance ModuleFiveInterventionAttendance { get; set; }
        public virtual AInterventionAttendance ModuleFourInterventionAttendance { get; set; }
        public virtual AInterventionAttendance ModuleNineInterventionAttendance { get; set; }
        public virtual AInterventionAttendance ModuleOneInterventionAttendance { get; set; }
        public virtual AInterventionAttendance ModuleSevenInterventionAttendance { get; set; }
        public virtual AInterventionAttendance ModuleSixInterventionAttendance { get; set; }
        public virtual AInterventionAttendance ModuleTenInterventionAttendance { get; set; }
        public virtual AInterventionAttendance ModuleThreeInterventionAttendance { get; set; }
        public virtual AInterventionAttendance ModuleTwoInterventionAttendance { get; set; }
    }
}
