using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ARiskLevelRating
    {
        public ARiskLevelRating()
        {
            IsvatcurrentBusinessRisk = new HashSet<IsvatcurrentBusinessRisk>();
        }

        public int RiskLevelRatingId { get; set; }
        public string RiskLevelRatingDesc { get; set; }

        public virtual ICollection<IsvatcurrentBusinessRisk> IsvatcurrentBusinessRisk { get; set; }
    }
}
