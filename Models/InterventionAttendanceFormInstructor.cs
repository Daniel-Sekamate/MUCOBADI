using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class InterventionAttendanceFormInstructor
    {
        public int InterventionAttendanceFormInstructorId { get; set; }
        public int? InterventionAttendanceFormId { get; set; }
        public string InstructorName { get; set; }

        public virtual InterventionAttendanceForm InterventionAttendanceForm { get; set; }
    }
}
