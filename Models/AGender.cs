using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AGender
    {
        public AGender()
        {
            AContacts = new HashSet<AContacts>();
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            CommunityTbSensitization = new HashSet<CommunityTbSensitization>();
            EcdIndirectMemberAttendence = new HashSet<EcdIndirectMemberAttendence>();
            HouseHoldMembers = new HashSet<HouseHoldMembers>();
            SinoParentingIndirectMemberAttendence = new HashSet<SinoParentingIndirectMemberAttendence>();
            VslaGroupCommittee = new HashSet<VslaGroupCommittee>();
            VslaGroupIndirectMember = new HashSet<VslaGroupIndirectMember>();
        }

        public string GenderId { get; set; }
        public string GenderDescription { get; set; }

        public virtual ICollection<AContacts> AContacts { get; set; }
        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitization { get; set; }
        public virtual ICollection<EcdIndirectMemberAttendence> EcdIndirectMemberAttendence { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembers { get; set; }
        public virtual ICollection<SinoParentingIndirectMemberAttendence> SinoParentingIndirectMemberAttendence { get; set; }
        public virtual ICollection<VslaGroupCommittee> VslaGroupCommittee { get; set; }
        public virtual ICollection<VslaGroupIndirectMember> VslaGroupIndirectMember { get; set; }
    }
}
