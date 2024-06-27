using MUCOBADI.Models;
using System.Collections.Generic;

namespace MUCOBADI.Data
{
    public class BimPrimaryData
    {
        public List<AGender>? GenderData { get; set; }
        public List<AMaritalStatus>? MaritalStatusData { get; set; }
        public List<ASubcounty>? SubcountyData { get; set; }
        public List<ADistrict>? DistrictData { get; set; }
        public List<AParish>? ParishData { get; set; }
        public List<AVillage>? VillageData { get; set; }
        public List<ANatureofResidence>? NatureofResidenceData { get; set; }
        public List<ACategoryofResidence>? CategoryofResidenceData { get; set; }
        public List<ABusinessPlanQuestion>? BusinessPlanQuestionData { get; set; }
        public List<AYesNo>? YesNoData { get; set; }
        public List<AAssetIncome>? AssetIncomeData { get; set; }
        public List<ARiskLevelRating>? RiskLevelRatingData { get; set; }
        public List<ABusinessVentureCapitalInvestment>? BusinessVentureCapitalInvestmentData { get; set; }
        public List<ACurrenBusinessOpportunity>? BusinessOpportunityData { get; set; }
        public List<ACurrenBusinessRisk>? BusinessRiskData { get; set; }
        public List<AStartBusinessQuestion>? StartBusinessQuestionData { get; set; }
    }
}
