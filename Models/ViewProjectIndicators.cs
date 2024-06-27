using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewProjectIndicators
    {
        public int? ServiceProviderId { get; set; }
        public int? IndicatorId { get; set; }
        public double? TargetValue { get; set; }
    }
}
