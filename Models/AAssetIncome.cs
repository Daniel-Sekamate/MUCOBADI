using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AAssetIncome
    {
        public AAssetIncome()
        {
            IsvatgeneratedProfit = new HashSet<IsvatgeneratedProfit>();
            IsvatincomeOwnership = new HashSet<IsvatincomeOwnership>();
            Isvatloss = new HashSet<Isvatloss>();
            IsvatworkingCapital = new HashSet<IsvatworkingCapital>();
        }

        public int AssetIncomeId { get; set; }
        public string AssetIncomeDesc { get; set; }

        public virtual ICollection<IsvatgeneratedProfit> IsvatgeneratedProfit { get; set; }
        public virtual ICollection<IsvatincomeOwnership> IsvatincomeOwnership { get; set; }
        public virtual ICollection<Isvatloss> Isvatloss { get; set; }
        public virtual ICollection<IsvatworkingCapital> IsvatworkingCapital { get; set; }
    }
}
