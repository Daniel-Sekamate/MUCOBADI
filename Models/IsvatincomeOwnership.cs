using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class IsvatincomeOwnership
    {
        public int IsvatincomeOwnershipId { get; set; }
        public int? IsvatincomeEarnerId { get; set; }
        public int? AssetIncomeId { get; set; }
        public string OtherAssetIncome { get; set; }
        public int? AssetIncomeYesNoId { get; set; }

        public virtual AAssetIncome AssetIncome { get; set; }
        public virtual AYesNo AssetIncomeYesNo { get; set; }
        public virtual IsvatincomeEarner IsvatincomeEarner { get; set; }
    }
}
