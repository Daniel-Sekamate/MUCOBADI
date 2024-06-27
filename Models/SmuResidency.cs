using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuResidency
    {
        public SmuResidency()
        {
            SmuPreGroupGuide = new HashSet<SmuPreGroupGuide>();
        }

        public int ResidencyId { get; set; }
        public string ResidencyDescription { get; set; }

        public virtual ICollection<SmuPreGroupGuide> SmuPreGroupGuide { get; set; }
    }
}
