using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AParish
    {
        public AParish()
        {
            AVillage = new HashSet<AVillage>();
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            CommunityTbSensitization = new HashSet<CommunityTbSensitization>();
            EcdAttendenceRegister = new HashSet<EcdAttendenceRegister>();
            GraduationBenchMark = new HashSet<GraduationBenchMark>();
            SinoParentingAttendenceRegister = new HashSet<SinoParentingAttendenceRegister>();
            VslaGroupComposition = new HashSet<VslaGroupComposition>();
            VslaGroupIndirectMember = new HashSet<VslaGroupIndirectMember>();
        }

        public int ParishId { get; set; }
        public int? SubcountyId { get; set; }
        public string ParishDescription { get; set; }

        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<AVillage> AVillage { get; set; }
        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitization { get; set; }
        public virtual ICollection<EcdAttendenceRegister> EcdAttendenceRegister { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMark { get; set; }
        public virtual ICollection<SinoParentingAttendenceRegister> SinoParentingAttendenceRegister { get; set; }
        public virtual ICollection<VslaGroupComposition> VslaGroupComposition { get; set; }
        public virtual ICollection<VslaGroupIndirectMember> VslaGroupIndirectMember { get; set; }
    }
}
