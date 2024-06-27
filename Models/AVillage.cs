using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AVillage
    {
        public AVillage()
        {
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            CommunityTbSensitization = new HashSet<CommunityTbSensitization>();
            GraduationBenchMark = new HashSet<GraduationBenchMark>();
            MonthlyCaseTrackingRegisterDetail = new HashSet<MonthlyCaseTrackingRegisterDetail>();
            VslaGroupIndirectMember = new HashSet<VslaGroupIndirectMember>();
        }

        public int VillageId { get; set; }
        public int? ParishId { get; set; }
        public string VillageDescription { get; set; }

        public virtual AParish Parish { get; set; }
        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitization { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMark { get; set; }
        public virtual ICollection<MonthlyCaseTrackingRegisterDetail> MonthlyCaseTrackingRegisterDetail { get; set; }
        public virtual ICollection<VslaGroupIndirectMember> VslaGroupIndirectMember { get; set; }
    }
}
