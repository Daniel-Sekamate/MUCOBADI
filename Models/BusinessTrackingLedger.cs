using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BusinessTrackingLedger
    {
        public BusinessTrackingLedger()
        {
            BusinessTrackingLedgerMoc = new HashSet<BusinessTrackingLedgerMoc>();
            BusinessTrackingLedgerSue = new HashSet<BusinessTrackingLedgerSue>();
        }

        public int BusinessTrackingLedgerId { get; set; }
        public string ProposedBusinessName { get; set; }
        public double? StartupExpenseTotalAmount { get; set; }
        public double? BusinessViabilityAnalysisTotalAmount { get; set; }
        public double? EstimatedOutputPerDay { get; set; }
        public double? NetProfits { get; set; }
        public string DataCollectorName { get; set; }
        public string DataCollectorTitle { get; set; }
        public DateTime? DataCollectionDate { get; set; }
        public string DataReviewerName { get; set; }
        public string DataReviewerTitle { get; set; }
        public DateTime? DataReviewDate { get; set; }

        public virtual ICollection<BusinessTrackingLedgerMoc> BusinessTrackingLedgerMoc { get; set; }
        public virtual ICollection<BusinessTrackingLedgerSue> BusinessTrackingLedgerSue { get; set; }
    }
}
