using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACurrenBusinessRisk
    {
        public ACurrenBusinessRisk()
        {
            IsvatcurrentBusinessRisk = new HashSet<IsvatcurrentBusinessRisk>();
        }

        public int CurrenBusinessRiskId { get; set; }
        public string CurrenBusinessRiskDesc { get; set; }

        public virtual ICollection<IsvatcurrentBusinessRisk> IsvatcurrentBusinessRisk { get; set; }
    }
}
