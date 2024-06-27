using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuOffice
    {
        public SmuOffice()
        {
            SmuGroup = new HashSet<SmuGroup>();
        }

        public int OfficeId { get; set; }
        public int? DistrictId { get; set; }
        public int? RegionId { get; set; }
        public string OfficeName { get; set; }

        public virtual ICollection<SmuGroup> SmuGroup { get; set; }
    }
}
