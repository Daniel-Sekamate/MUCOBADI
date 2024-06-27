using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ANatureofResidence
    {
        public ANatureofResidence()
        {
            BusinessPlanHeader = new HashSet<BusinessPlanHeader>();
            Isvatheader = new HashSet<Isvatheader>();
        }

        public int NatureofResidenceId { get; set; }
        public string NatureofResidenceDesc { get; set; }

        public virtual ICollection<BusinessPlanHeader> BusinessPlanHeader { get; set; }
        public virtual ICollection<Isvatheader> Isvatheader { get; set; }
    }
}
