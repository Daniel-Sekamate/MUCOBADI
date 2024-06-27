using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AInterventionType
    {
        public AInterventionType()
        {
            InterventionAttendanceForm = new HashSet<InterventionAttendanceForm>();
        }

        public int InterventionTypeId { get; set; }
        public string InterventionTypeDesc { get; set; }

        public virtual ICollection<InterventionAttendanceForm> InterventionAttendanceForm { get; set; }
    }
}
