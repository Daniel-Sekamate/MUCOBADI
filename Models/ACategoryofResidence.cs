using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACategoryofResidence
    {
        public ACategoryofResidence()
        {
            BusinessPlanHeader = new HashSet<BusinessPlanHeader>();
            Isvatheader = new HashSet<Isvatheader>();
        }

        public int CategoryofResidenceId { get; set; }
        public string CategoryofResidenceDesc { get; set; }

        public virtual ICollection<BusinessPlanHeader> BusinessPlanHeader { get; set; }
        public virtual ICollection<Isvatheader> Isvatheader { get; set; }
    }
}
