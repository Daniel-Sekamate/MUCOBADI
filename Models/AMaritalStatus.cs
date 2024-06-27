using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AMaritalStatus
    {
        public AMaritalStatus()
        {
            Avat = new HashSet<Avat>();
            BusinessPlanHeader = new HashSet<BusinessPlanHeader>();
            Hvat = new HashSet<Hvat>();
            SmuPreGroupGuide = new HashSet<SmuPreGroupGuide>();
        }

        public int MaritalStatusId { get; set; }
        public string MaritalStatusDescription { get; set; }

        public virtual ICollection<Avat> Avat { get; set; }
        public virtual ICollection<BusinessPlanHeader> BusinessPlanHeader { get; set; }
        public virtual ICollection<Hvat> Hvat { get; set; }
        public virtual ICollection<SmuPreGroupGuide> SmuPreGroupGuide { get; set; }
    }
}
