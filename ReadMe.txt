Table 1: A_ProgramParticipationStatus 
1	Active
2	Graduated

Table 2: BeneficiaryIdentificationRegister
Table 3:HomeVisitServiceReportingToolHeader
Table 4: HomeVisitServiceReportingToolDetail



//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//{
//	if (!optionsBuilder.IsConfigured)
//	{
//		IConfigurationRoot configuration = new ConfigurationBuilder()
//									   .SetBasePath(Directory.GetCurrentDirectory())
//									   .AddJsonFile("appsettings.json")
//									   .Build();
//		var connectionString = configuration.GetConnectionString("DefaultConnection");
//		optionsBuilder.UseSqlServer(connectionString);
//	}
//}


//using Microsoft.Extensions.Configuration;
//using System.IO;



BIMModel
Scaffold-DbContext "Server=HENRY;Database=MUCOBADI;User Id=sa;password=**Root@85;Trusted_Connection=False;Encrypt=False;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/BIMModels -Tables "ISVATHeader","ISVATIncomeEarner","ISVATIncomeOwnership","ISVATWorkingCapital","ISVATGeneratedProfit","ISVATLoss","ISVATCurrentBusinessRisk","ISVATCurrentBusinessOpportunity","ISVATStartBusinessAnswer","BusinessPlanHeader","BusinessPlanDetail","BusinessTrackingLedger","BusinessTrackingLedgerSUE","BusinessTrackingLedgerMOC" -ContextDir Context -Context BIMContext -ContextNamespace MUCOBADI.Context -NoPluralize -Force

Utilities
Scaffold-DbContext "Server=HENRY;Database=MUCOBADI;User Id=sa;password=**Root@85;Trusted_Connection=False;Encrypt=False;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/UtilitiesModels -Tables "A_AdministrationPhase","A_DeliveryMethod","A_ImplementationMethod","A_NMN_Section_One_Question","A_NMN_Section_Two_Question","A_NMN_Section_Two_Answer","A_AgreeDisagree","A_NMN_SampledFor","A_InterventionAttendance","A_InterventionType","A_AssetIncome","A_BusinessPlanQuestion","A_StartBusinessQuestion","A_CurrenBusinessOpportunity","A_RiskLevelRating","A_CurrenBusinessRisk","A_BusinessVentureCapitalInvestment","A_NatureofResidence","A_CategoryofResidence" -ContextDir Context -Context UtilitiesContext -ContextNamespace MUCOBADI.Context  -Force




Scaffold-DbContext "Server=HENRY;Database=MUCOBADI;User Id=sa;password=**Root@85;Trusted_Connection=False;Encrypt=False;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Tables "ISVATHeader","ISVATIncomeEarner","ISVATIncomeOwnership","ISVATWorkingCapital","ISVATGeneratedProfit","ISVATLoss","ISVATCurrentBusinessRisk","ISVATCurrentBusinessOpportunity","ISVATStartBusinessAnswer","BusinessPlanHeader","BusinessPlanDetail","BusinessTrackingLedger","BusinessTrackingLedgerSUE","BusinessTrackingLedgerMOC" -ContextDir Context -Context BIMContext -ContextNamespace MUCOBADI.Context -NoPluralize -Force