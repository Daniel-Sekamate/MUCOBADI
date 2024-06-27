using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AFinancialYear
    {
        public AFinancialYear()
        {
            ATargets = new HashSet<ATargets>();
            ProjectIndicatorTargetsHeader = new HashSet<ProjectIndicatorTargetsHeader>();
            StakeHolderDataCapture = new HashSet<StakeHolderDataCapture>();
        }

        public int FinancialYearId { get; set; }
        public string FinancialYearDesc { get; set; }

        public virtual ICollection<ATargets> ATargets { get; set; }
        public virtual ICollection<ProjectIndicatorTargetsHeader> ProjectIndicatorTargetsHeader { get; set; }
        public virtual ICollection<StakeHolderDataCapture> StakeHolderDataCapture { get; set; }
    }
}
