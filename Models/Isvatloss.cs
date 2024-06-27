using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class Isvatloss
    {
        public int IsvatlossId { get; set; }
        public int? IsvatheaderId { get; set; }
        public int? AssetIncomeId { get; set; }
        public string OtherAssetIncome { get; set; }
        public int? BusinessVentureCapitalInvestmentId { get; set; }

        public virtual AAssetIncome AssetIncome { get; set; }
        public virtual ABusinessVentureCapitalInvestment BusinessVentureCapitalInvestment { get; set; }
        public virtual Isvatheader Isvatheader { get; set; }
    }
}
