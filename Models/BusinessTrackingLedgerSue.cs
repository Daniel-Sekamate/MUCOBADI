using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BusinessTrackingLedgerSue
    {
        public int StartUpExpensesId { get; set; }
        public int? BusinessTrackingLedgerId { get; set; }
        public string Item { get; set; }
        public string UnitOfMeasure { get; set; }
        public double? Qty { get; set; }
        public double? UnitCost { get; set; }
        public string AvailableResources { get; set; }
        public string SourceofResources { get; set; }
        public double? Amount { get; set; }

        public virtual BusinessTrackingLedger BusinessTrackingLedger { get; set; }
    }
}
