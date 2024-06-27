using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuCycle
    {
        public SmuCycle()
        {
            SmuAttendenceHeader = new HashSet<SmuAttendenceHeader>();
        }

        public int CycleId { get; set; }
        public string CycleDescription { get; set; }

        public virtual ICollection<SmuAttendenceHeader> SmuAttendenceHeader { get; set; }
    }
}
