using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ANmnSampledFor
    {
        public ANmnSampledFor()
        {
            InterventionAttendanceForm = new HashSet<InterventionAttendanceForm>();
            Nmnquestionaire = new HashSet<Nmnquestionaire>();
        }

        public int SampledForId { get; set; }
        public string SampledForDesc { get; set; }

        public virtual ICollection<InterventionAttendanceForm> InterventionAttendanceForm { get; set; }
        public virtual ICollection<Nmnquestionaire> Nmnquestionaire { get; set; }
    }
}
