using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BeneficiaryEnrolmentRegisterDetails
    {
        public int EnrolmentRegisterDetailsId { get; set; }
        public int EnrolmentRegisterHeaderId { get; set; }
        public int HouseHoldMemberId { get; set; }
        public int? AssessedOfferedAccepted { get; set; }
        public int? AssessedOfferedRefused { get; set; }
        public int? AssessedNotEligible { get; set; }
        public int? NotAssessed { get; set; }
        public int? OvcOffer { get; set; }
        public int? OvcEnroll { get; set; }

        public virtual AYesNo AssessedNotEligibleNavigation { get; set; }
        public virtual AYesNo AssessedOfferedAcceptedNavigation { get; set; }
        public virtual AYesNo AssessedOfferedRefusedNavigation { get; set; }
        public virtual BeneficiaryEnrolmentRegisterHeader EnrolmentRegisterHeader { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AYesNo NotAssessedNavigation { get; set; }
        public virtual AYesNo OvcEnrollNavigation { get; set; }
        public virtual AYesNo OvcOfferNavigation { get; set; }
    }
}
