using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BeneficiaryLinkageTrackingToolNew
    {
        public int LinkageTrackingToolId { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public DateTime? LinkageDate { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? LinkageServiceCategoryId { get; set; }
        public string PersonProvidingService { get; set; }
        public string TitlePersonProvidingService { get; set; }
        public DateTime? DateProvidingService { get; set; }
        public string SubmittedBy { get; set; }
        public string SubmittedTitle { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewTitle { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int? HouseHoldId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public int? ServiceLinkedToId { get; set; }
        public int? ServiceReceived { get; set; }
        public string IteamCost { get; set; }
        public string ServiceRecievedDetail { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual ALinkageServiceCategory LinkageServiceCategory { get; set; }
        public virtual AServiceLinkedTo LinkageTrackingTool { get; set; }
        public virtual AServiceProvider ServiceProvider { get; set; }
        public virtual AServiceReceived ServiceReceivedNavigation { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
    }
}
