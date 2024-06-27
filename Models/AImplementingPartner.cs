using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AImplementingPartner
    {
        public AImplementingPartner()
        {
            BeneficiaryEnrolmentRegisterHeader = new HashSet<BeneficiaryEnrolmentRegisterHeader>();
            BeneficiaryLinkageTrackingTool = new HashSet<BeneficiaryLinkageTrackingTool>();
            BeneficiaryLinkageTrackingToolNew = new HashSet<BeneficiaryLinkageTrackingToolNew>();
            CaseCare = new HashSet<CaseCare>();
            CommunityTrainingRegister = new HashSet<CommunityTrainingRegister>();
            EcdAttendenceRegister = new HashSet<EcdAttendenceRegister>();
            GraduationBenchMark = new HashSet<GraduationBenchMark>();
            MonthlyCaseTrackingRegister = new HashSet<MonthlyCaseTrackingRegister>();
            SinoParentingAttendenceRegister = new HashSet<SinoParentingAttendenceRegister>();
            VslaTrackingTool = new HashSet<VslaTrackingTool>();
        }

        public int ImplementingPartnerId { get; set; }
        public string ImplementingPartnerName { get; set; }

        public virtual ICollection<BeneficiaryEnrolmentRegisterHeader> BeneficiaryEnrolmentRegisterHeader { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingTool> BeneficiaryLinkageTrackingTool { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolNew> BeneficiaryLinkageTrackingToolNew { get; set; }
        public virtual ICollection<CaseCare> CaseCare { get; set; }
        public virtual ICollection<CommunityTrainingRegister> CommunityTrainingRegister { get; set; }
        public virtual ICollection<EcdAttendenceRegister> EcdAttendenceRegister { get; set; }
        public virtual ICollection<GraduationBenchMark> GraduationBenchMark { get; set; }
        public virtual ICollection<MonthlyCaseTrackingRegister> MonthlyCaseTrackingRegister { get; set; }
        public virtual ICollection<SinoParentingAttendenceRegister> SinoParentingAttendenceRegister { get; set; }
        public virtual ICollection<VslaTrackingTool> VslaTrackingTool { get; set; }
    }
}
