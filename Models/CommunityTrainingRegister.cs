using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class CommunityTrainingRegister
    {
        public CommunityTrainingRegister()
        {
            CommunityTrainingRegisterDirectMember = new HashSet<CommunityTrainingRegisterDirectMember>();
            CommunityTrainingRegisterIndirectMember = new HashSet<CommunityTrainingRegisterIndirectMember>();
        }

        public int CommunityTrainingRegisterId { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? GroupCompositionCode { get; set; }
        public int? GroupCycleId { get; set; }
        public int? CurriculumId { get; set; }
        public int? TotalNoSessions { get; set; }
        public DateTime? TrainingStartDate { get; set; }
        public DateTime? TrainingEndDate { get; set; }
        public string TrainingVenue { get; set; }
        public string Trainer { get; set; }
        public string CoodinatedBy { get; set; }
        public string CoordinatorPhoneNumber { get; set; }
        public DateTime? CoordinatorDate { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewerPhoneNumber { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int? GroupId { get; set; }
        public string GroupCode { get; set; }

        public virtual ATrainningCurriculum Curriculum { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AGroups Group { get; set; }
        public virtual VslaGroupComposition GroupCompositionCodeNavigation { get; set; }
        public virtual AGroupCycle GroupCycle { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<CommunityTrainingRegisterDirectMember> CommunityTrainingRegisterDirectMember { get; set; }
        public virtual ICollection<CommunityTrainingRegisterIndirectMember> CommunityTrainingRegisterIndirectMember { get; set; }
    }
}
