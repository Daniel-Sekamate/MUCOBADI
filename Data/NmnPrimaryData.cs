using MUCOBADI.Models;
using System.Collections.Generic;

namespace MUCOBADI.Data
{
    public class NmnPrimaryData
    {
        public List<AImplementingPartner>? ImplementingPartnerData { get; set; }
        public List<AInterventionType>? InterventionTypeData { get; set; }
        public List<ADistrict>? DistrictData { get; set; }
        public List<ASubcounty>? SubcountyData { get; set; }
        public List<AParish>? ParishData { get; set; }
        public List<AVillage>? VillageData { get; set; }
        public List<ANmnSampledFor>? NmnSampledForData { get; set; }
        public List<ADeliveryMethod>? DeliveryMethodData { get; set; }
        public List<AImplementationMethod>? ImplementationMethodData { get; set; }
        public List<ANmnSectionOneQuestion>? NmnSectionOneQuestionData { get; set; }
        public List<ANmnSectionTwoQuestion>? NmnSectionTwoQuestionData { get; set; }
        public List<AAgreeDisagree>? AgreeDisagreeData { get; set; }
        public List<AInterventionAttendance>? InterventionAttendanceData { get; set; }
        public List<ANmnSectionTwoAnswer>? NmnSectionTwoAnswerData { get; set; }
        public List<AYesNo>? YesNoData { get; set; }
    }
}
