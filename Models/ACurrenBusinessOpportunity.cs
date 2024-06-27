using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACurrenBusinessOpportunity
    {
        public ACurrenBusinessOpportunity()
        {
            IsvatcurrentBusinessOpportunity = new HashSet<IsvatcurrentBusinessOpportunity>();
        }

        public int CurrenBusinessOpportunityId { get; set; }
        public string CurrenBusinessOpportunityDesc { get; set; }

        public virtual ICollection<IsvatcurrentBusinessOpportunity> IsvatcurrentBusinessOpportunity { get; set; }
    }
}
