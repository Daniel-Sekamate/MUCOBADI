using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuFacilitator
    {
        public SmuFacilitator()
        {
            SmuGroup = new HashSet<SmuGroup>();
        }

        public int SmuFacilitatorId { get; set; }
        public string SmuFacilitatorName { get; set; }
        public string SmuFacilitatorEmail { get; set; }
        public string SmuFacilitatorPhoneNumber { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CapturedBy { get; set; }

        public virtual ICollection<SmuGroup> SmuGroup { get; set; }
    }
}
