using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ARegion
    {
        public ARegion()
        {
            ADistrict = new HashSet<ADistrict>();
            SmuGroup = new HashSet<SmuGroup>();
        }

        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<ADistrict> ADistrict { get; set; }
        public virtual ICollection<SmuGroup> SmuGroup { get; set; }
    }
}
