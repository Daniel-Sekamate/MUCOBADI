using Blazored.Toast;
using BlazorStrap;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MUCOBADI.Areas.Identity;
using MUCOBADI.Data;
using MUCOBADI.Interfaces;
using MUCOBADI.Interfaces.Dashboard;
using MUCOBADI.Models;
using MUCOBADI.Repository;
using MUCOBADI.Repository.Dashboard;
using MUCOBADI.Repository.TrackingTools;
using MUCOBADI.ScheduleTask;
using Syncfusion.Blazor;
using Syncfusion.JavaScript.DataVisualization.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static MUCOBADI.Pages.Account.ChangeUserPasswordPage;
using static MUCOBADI.Pages.Account.UserManagementPage;
using static MUCOBADI.Pages.APIUpload.APIUploadPage;
using static MUCOBADI.Pages.Dashboards.Charts.StakeholderDataCapture;
using static MUCOBADI.Pages.RegistrationForms.BeneficiaryEnrolmentRegisterPage;
using static MUCOBADI.Pages.RegistrationForms.IdentificationRegister;
using static MUCOBADI.Pages.RegistrationForms.NewIdentificationRegisterPage;
using static MUCOBADI.Pages.TrackingTools.AVATPage;
using static MUCOBADI.Pages.TrackingTools.AVATPartialPage;
using static MUCOBADI.Pages.TrackingTools.CaseCarePage;
using static MUCOBADI.Pages.TrackingTools.CaseTrackingRegisterPage;
using static MUCOBADI.Pages.TrackingTools.CommunityTraingRegisterPage;
using static MUCOBADI.Pages.TrackingTools.ECDRegisterPage;
using static MUCOBADI.Pages.TrackingTools.GraduationBenchmarkPage;
using static MUCOBADI.Pages.TrackingTools.GraduationCheckListPage;
using static MUCOBADI.Pages.TrackingTools.GroupCompositionPage;
using static MUCOBADI.Pages.TrackingTools.HIV_TB_TrackingAndMonitoringToolPage;
using static MUCOBADI.Pages.TrackingTools.HIVTBRiskAssessmentToolPage;
using static MUCOBADI.Pages.TrackingTools.HomeVisitServiceReportingToolPage;
using static MUCOBADI.Pages.TrackingTools.HVATPage;
using static MUCOBADI.Pages.TrackingTools.LinkageTrackingToolPage;
using static MUCOBADI.Pages.TrackingTools.NewLinkageTrackingToolPage;
using static MUCOBADI.Pages.TrackingTools.ReferralFormPage;
using static MUCOBADI.Pages.TrackingTools.SchoolAttendencyPage;
using static MUCOBADI.Pages.TrackingTools.SINOParentingRegister;
using static MUCOBADI.Pages.TrackingTools.VSLAGroupCompositionPage;
using static MUCOBADI.Pages.TrackingTools.VSLAShareOutPage;
using static MUCOBADI.Pages.TrackingTools.VSLATrackingToolPage;
using static MUCOBADI.Pages.Utilities.AdministrationPhasePage;
using static MUCOBADI.Pages.Utilities.AdolescenceIssueofAbussePage;
using static MUCOBADI.Pages.Utilities.AdolescentHealthServiceReferredPage;
using static MUCOBADI.Pages.Utilities.AdolosentsEnrolledAttendingSchoolPage;
using static MUCOBADI.Pages.Utilities.ApplicableOptionsPage;
using static MUCOBADI.Pages.Utilities.AssessmentStatusPage;
using static MUCOBADI.Pages.Utilities.AssetsPage;
using static MUCOBADI.Pages.Utilities.AttendencyPage;
using static MUCOBADI.Pages.Utilities.CandidateClassesPage;
using static MUCOBADI.Pages.Utilities.CareGiverPage;
using static MUCOBADI.Pages.Utilities.CaseNatureReportedPage;
using static MUCOBADI.Pages.Utilities.CasePlanPage;
using static MUCOBADI.Pages.Utilities.CasePLanStausPage;
using static MUCOBADI.Pages.Utilities.ChildAbuseOccurancesPage;
using static MUCOBADI.Pages.Utilities.ChildAbusePage;
using static MUCOBADI.Pages.Utilities.ChildrenComplicationsPage;
using static MUCOBADI.Pages.Utilities.CientClassificationPage;
using static MUCOBADI.Pages.Utilities.ClientCareModalityPage;
using static MUCOBADI.Pages.Utilities.ClientMemberStatusPage;
using static MUCOBADI.Pages.Utilities.ContactsPage;
using static MUCOBADI.Pages.Utilities.CurrentClassPage;
using static MUCOBADI.Pages.Utilities.DailyMealsPage;
using static MUCOBADI.Pages.Utilities.DistrictPage;
using static MUCOBADI.Pages.Utilities.DrugDispensingModalityPage;
using static MUCOBADI.Pages.Utilities.DrugDispensingModelPage;
using static MUCOBADI.Pages.Utilities.EconomicActivityPage;
using static MUCOBADI.Pages.Utilities.EducationLevelPage;
using static MUCOBADI.Pages.Utilities.EIDCascadePage;
using static MUCOBADI.Pages.Utilities.ExpensePaymentPage;
using static MUCOBADI.Pages.Utilities.FacilitiesPage;
using static MUCOBADI.Pages.Utilities.FeedingStatusPage;
using static MUCOBADI.Pages.Utilities.FollowUpMeansPage;
using static MUCOBADI.Pages.Utilities.FoodConsumedSourcePage;
using static MUCOBADI.Pages.Utilities.FoodGroupsPage;
using static MUCOBADI.Pages.Utilities.GenderBasedViolencePage;
using static MUCOBADI.Pages.Utilities.GraduationCriteriaPage;
using static MUCOBADI.Pages.Utilities.GroupCyclePage;
using static MUCOBADI.Pages.Utilities.GroupMemberStatusPage;
using static MUCOBADI.Pages.Utilities.GroupPositionPage;
using static MUCOBADI.Pages.Utilities.GroupsPage;
using static MUCOBADI.Pages.Utilities.GroupTypePage;
using static MUCOBADI.Pages.Utilities.HasDisabilityPage;
using static MUCOBADI.Pages.Utilities.HHIncomePage;
using static MUCOBADI.Pages.Utilities.HHIncomeSourcePage;
using static MUCOBADI.Pages.Utilities.HHIncurredExpensesPage;
using static MUCOBADI.Pages.Utilities.HHKnownHIVStatusPage;
using static MUCOBADI.Pages.Utilities.HHPreSchoolNotEnrolledPage;
using static MUCOBADI.Pages.Utilities.HHTreatmentAdherancePage;
using static MUCOBADI.Pages.Utilities.HHViralLoadBloodTestPage;
using static MUCOBADI.Pages.Utilities.HHViralLoadSuppressedPage;
using static MUCOBADI.Pages.Utilities.HIVStatusPage;
using static MUCOBADI.Pages.Utilities.HomeVisitReasonPage;
using static MUCOBADI.Pages.Utilities.ImplementingPartnerPage;
using static MUCOBADI.Pages.Utilities.InfectionWaysPage;
using static MUCOBADI.Pages.Utilities.JobCausedHarmPage;
using static MUCOBADI.Pages.Utilities.KnownRiskFactorsPage;
using static MUCOBADI.Pages.Utilities.LinkageServiceCategoryPage;
using static MUCOBADI.Pages.Utilities.MalnutritionSignsPage;
using static MUCOBADI.Pages.Utilities.MaritalStatusPage;
using static MUCOBADI.Pages.Utilities.MemberBenefitsPage;
using static MUCOBADI.Pages.Utilities.NonAdherencePage;
using static MUCOBADI.Pages.Utilities.NotSuppressingReasonPage;
using static MUCOBADI.Pages.Utilities.OVCServiceProviderPage;
using static MUCOBADI.Pages.Utilities.ParentingGroupSessionPage;
using static MUCOBADI.Pages.Utilities.ParentingGroupSessionTypePage;
using static MUCOBADI.Pages.Utilities.ParishPage;
using static MUCOBADI.Pages.Utilities.PCRTestPage;
using static MUCOBADI.Pages.Utilities.PersonContactedPage;
using static MUCOBADI.Pages.Utilities.PriorityAreaCodesPage;
using static MUCOBADI.Pages.Utilities.PriorityAreaPage;
using static MUCOBADI.Pages.Utilities.ProgramParticipationStatusPage;
using static MUCOBADI.Pages.Utilities.ReasonForBorrowingLoanPage;
using static MUCOBADI.Pages.Utilities.ReferredDisabilityPage;
using static MUCOBADI.Pages.Utilities.RegimenCategoryPage;
using static MUCOBADI.Pages.Utilities.RegimenPage;
using static MUCOBADI.Pages.Utilities.RegistrationStatusPage;
using static MUCOBADI.Pages.Utilities.RelationshipPage;
using static MUCOBADI.Pages.Utilities.SavingSchemePage;
using static MUCOBADI.Pages.Utilities.SchoolEnrolmentPage;
using static MUCOBADI.Pages.Utilities.SchoolNotProgressingReasonPage;
using static MUCOBADI.Pages.Utilities.SelfProtectionPage;
using static MUCOBADI.Pages.Utilities.Service_ProvidedPage;
using static MUCOBADI.Pages.Utilities.Service_ProviderPage;
using static MUCOBADI.Pages.Utilities.Service_ReceivedPage;
using static MUCOBADI.Pages.Utilities.ServiceCategoryPage;
using static MUCOBADI.Pages.Utilities.ServiceLinkedToPage;
using static MUCOBADI.Pages.Utilities.SourceDocumentPage;
using static MUCOBADI.Pages.Utilities.SourceofIdentificationPage;
using static MUCOBADI.Pages.Utilities.StableShelterPage;
using static MUCOBADI.Pages.Utilities.ProjectsTargetsPage;
using static MUCOBADI.Pages.Utilities.SubcountyPage;
using static MUCOBADI.Pages.Utilities.TargetsPage;
using static MUCOBADI.Pages.Utilities.TBClientReferedPage;
using static MUCOBADI.Pages.Utilities.TBTestResultPage;
using static MUCOBADI.Pages.Utilities.TBTReatmentDurationPage;
using static MUCOBADI.Pages.Utilities.TBTreatmentPage;
using static MUCOBADI.Pages.Utilities.TermPage;
using static MUCOBADI.Pages.Utilities.Training_SessionPage;
using static MUCOBADI.Pages.Utilities.Trainning_CurriculumPage;
using static MUCOBADI.Pages.Utilities.TuberclosisTreatmentPage;
using static MUCOBADI.Pages.Utilities.VillagePage;
using static MUCOBADI.Pages.Utilities.ViralLoadLevelPage;
using static MUCOBADI.Pages.Utilities.ViralLoadResultsPage;
using static MUCOBADI.Pages.Utilities.ViralLoadSuppressedPage;
using static MUCOBADI.Pages.Utilities.VSLA_Group_TrainerPage;
using static MUCOBADI.Pages.TrackingTools.TBSensitizationPage;

namespace MUCOBADI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"), sqloptions => sqloptions.CommandTimeout(9000)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking), ServiceLifetime.Scoped);
            services.AddDbContext<MUCOBADIContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection"), sqloptions => sqloptions.CommandTimeout(9000)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking),ServiceLifetime.Scoped);
            services.AddDbContext<SPToCoreContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection"), sqloptions => sqloptions.CommandTimeout(9000)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking), ServiceLifetime.Scoped);
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            var baseurl = Configuration.GetValue<string>("ApiUrl:Url");
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseurl), Timeout = TimeSpan.FromMinutes(10) });
            services.Configure<IdentityOptions>(options =>
            {
                // Default Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(60);
                options.Lockout.MaxFailedAccessAttempts = 4;
                options.Lockout.AllowedForNewUsers = true;
            });
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<WeatherForecastService>();
            services.AddSyncfusionBlazor();
            services.AddBootstrapCss();
            services.AddBlazoredToast();
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );
            services.AddControllers().AddJsonOptions(x =>x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
            services.AddSignalR(e => {
                e.MaximumReceiveMessageSize = 102400000;
            });
            services.AddServerSideBlazor().AddHubOptions(o =>
            {
                o.MaximumReceiveMessageSize = 10 * 1024 * 1024; // 10MB
            });
            services.AddHttpClient();
            services.AddScoped<IRegisterService, RegisterService>();
            services.AddScoped<UserManagement>();
            services.AddScoped<BeneficiaryIdentificationRegisterHeaderAdapter>();
            services.AddScoped<NewBeneficiaryIdentificationRegisterHeaderAdapter>();
            services.AddScoped<HouseholdMemberAdapter>();
            services.AddScoped<spHIV_TB_TrackingFormGetAllResultHeaderAdapter>();
            services.AddScoped<TrackingBeneficiaryRegisterAdapter>();
            services.AddScoped<ServiceReportBeneficiaryRegisterAdapter>();
            services.AddScoped<HomeVisitServiceReportingToolHeaderHeaderAdapter>();
            services.AddScoped<HIVTBRiskAssessmentBeneficiaryRegisterAdapter>();
            services.AddScoped<AdultRiskAssessmentAdapter>();
            services.AddScoped<ChildrenRiskAssessmentAdapter>();
            services.AddScoped<BeneficiaryEnrollmentRegisterAdapter>();
            services.AddScoped<EnrolmentRegisterHeaderAdapter>();
            services.AddScoped<HVATBeneficiaryRegisterAdapter>();
            services.AddScoped<HvatAdapter>();
            services.AddScoped<HVATAddendumAdapter>();
            services.AddScoped<AVATBeneficiaryRegisterAdapter>();
            services.AddScoped<AvatAdapter>();
            services.AddScoped<AspNetUsersAdapter>();
            services.AddScoped<AccountManagementAdapter>();
            services.AddScoped<ReferralBeneficiaryRegisterAdapter>();
            services.AddScoped<ReferralFormAdapter>();
            services.AddScoped<SchoolAttendancyBeneficiaryRegisterAdapter>();
            services.AddScoped<OvcSchoolAttendencyHeaderAdapter>();
            services.AddScoped<CaseCareBeneficiaryRegisterAdapter>();
            services.AddScoped<CaseCareHeaderAdapter>();
            services.AddScoped<CaseCareSummaryAdapter>();
            services.AddScoped<GraduationChecklistBeneficiaryRegisterAdapter>();
            services.AddScoped<GraduationChecklistHeaderAdapter>();
            services.AddScoped<VslaGroupCompositionAdapter>();
            services.AddScoped<VslaTrackingToolAdapter>();
            services.AddScoped<TrackingToolMonthAdapter>();
            services.AddScoped<TrackingToolChildDirectMemberAdapter>();
            services.AddScoped<TrackingToolChildIndirectMemberAdapter>();
            services.AddScoped<ShareOutIndirectMemberAdapter>();
            services.AddScoped<CommunityTrainingRegisterAdapter>();
            services.AddScoped<CommunityTrainingSessionsAdapter>();
            services.AddScoped<CommunityTrainingRegisterDirectMemberAdapter>();
            services.AddScoped<CommunityTrainingRegisterIndirectMemberAdapter>();
            services.AddScoped<VslaGroupShareOutHeaderAdapter>();
            services.AddScoped<ShareOutDirectMemberAdapter>();
            services.AddScoped<ShareOutIndirectMemberAdapter>();
            services.AddScoped<BeneficiaryLinkageTrackingToolAdapter>();
            services.AddScoped<LinkageTrackingToolDirectMemberAdapter>();
            services.AddScoped<LinkageTrackingToolIndirectMemberAdapter>();

            services.AddScoped<SinoParentingAttendenceRegisterAdapter>();
            services.AddScoped<SINOParentingDirectMemberAdapter>();
            services.AddScoped<SINOParentingIndirectMemberAdapter>();
            services.AddScoped<SINOParentingRegisterSessionsAdapter>();

            services.AddScoped<EcdAttendenceRegisterAdapter>();
            services.AddScoped<ECDRegisterSessionsAdapter>();
            services.AddScoped<ECDDirectMemberAdapter>();
            services.AddScoped<ECDIndirectMemberAdapter>();
            services.AddScoped<DistrictAdapter>();
            services.AddScoped<SubcountyAdapter>();
            services.AddScoped<ParishAdapter>();
            services.AddScoped<VillageAdapter>();
            services.AddScoped<FacilityAdapter>();
            services.AddScoped<FeedingStatusAdapter>();
            services.AddScoped<FollowupMeansAdapter>();
            services.AddScoped<FoodConsumedSourceAdapter>();
            services.AddScoped<FoodGroupsAdapter>();
            services.AddScoped<GenderBasedViolenceAdapter>();
            services.AddScoped<GraduationCriteriaAdapter>();
            services.AddScoped<GroupMemberStatusAdapter>();
            services.AddScoped<GroupPositionAdapter>();
            services.AddScoped<GroupCycleAdapter>();
            services.AddScoped<GroupsAdapter>();
            services.AddScoped<GroupTypeAdapter>();
            services.AddScoped<HasDisabilityAdapter>();
            services.AddScoped<ApplicableOptionsAdapter>();
            services.AddScoped<AssessmentStatusAdapter>();
            services.AddScoped<AssetsAdapter>();
            services.AddScoped<ChildAbuseAdapter>();
            services.AddScoped<ChildrenComplicationsAdapter>();
            services.AddScoped<EducationLevelAdapter>();
            services.AddScoped<IncomeAdapter>();
            services.AddScoped<IncomeSourceAdapter>();
            services.AddScoped<IncurredExpensesAdapter>();
            services.AddScoped<KnownHIVStatusAdapter>();
            services.AddScoped<ExpensePaymentAdapter>();
            services.AddScoped<AdministrationAdapter>();
            services.AddScoped<AdolosentsEnrollmentAdapter>();
            services.AddScoped<AdolosenteHealthServiceReferedAdapter>();
            services.AddScoped<AdolosceneIssueofAbusseAdapter>();
            services.AddScoped<AttendencyAdapter>();
            services.AddScoped<CandidateClassAdapter>();
            services.AddScoped<CareGiverAdapter>();
            services.AddScoped<CasePlanAdapter>();
            services.AddScoped<CasePLanStausAdapter>();
            services.AddScoped<AChildAbuseOccurancesAdapter>();
            services.AddScoped<ACientClassificationAdapter>();
            services.AddScoped<AClientCareModalityAdapter>();
            services.AddScoped<AClientMemberStatusAdapter>();
            services.AddScoped<ADailyMealsAdapter>();
            services.AddScoped<ADrugDispensingModalityAdapter>();
            services.AddScoped<ADrugDispensingModelAdapter>();
            services.AddScoped<AEconomicActivityAdapter>();
            services.AddScoped<CaseNatureReportedAdapter>();

            services.AddScoped<AEidCascadeAdapter>();
            services.AddScoped<ASchoolEnrolmentAdapter>();
            services.AddScoped<ASchoolNotProgressingReasonAdapter>();
            services.AddScoped<ASelfProtectionAdapter>();
            services.AddScoped<AServiceProvidedAdapter>();
            services.AddScoped<HHPreSchoolNotEnrolledAdapter>();
            services.AddScoped<CurrentClassAdapter>();
            services.AddScoped<TreatmentAdheranceAdapter>();
            services.AddScoped<ViralLoadAdapter>();
            services.AddScoped<HIVStatusAdapter>();

            services.AddScoped<ViralLoadBloodTestAdapter>();
            services.AddScoped<HomeVisitAdapter>();
            services.AddScoped<ImplementingPartnerAdapter>();
            services.AddScoped<InfectionWaysAdapter>();
            services.AddScoped<JobCausedHarmAdapter>();
            services.AddScoped<KnownRiskFactorsAdapter>();
            services.AddScoped<LinkageServiceCategoryAdapter>();
            services.AddScoped<MalnutritionSignsAdapter>();
            services.AddScoped<MaritalStatusAdapter>();
            services.AddScoped<MemberBenefitsAdapter>();
            services.AddScoped<NonAdherenceAdapter>();
            services.AddScoped<NotSuppressingAdapter>();
            services.AddScoped<OvcserviceProviderAdapter>();
            services.AddScoped<ParentingGroupSessionAdapter>();
            services.AddScoped<ParentingAdapter>();
            services.AddScoped<PCRTestAdapter>();
            services.AddScoped<PersonContactedAdapter>();
            services.AddScoped<PriorityAreaAdapter>();
            services.AddScoped<PriorityAreaCodesAdapter>();

            services.AddScoped<AServiceProviderAdapter>();
            services.AddScoped<ServiceRecievedAdapter>();
            services.AddScoped<AServiceCategoryAdapter>();
            services.AddScoped<ServiceLinkedAdapter>();
            services.AddScoped<ASourceDocumentAdapter>();
            services.AddScoped<ASourceofIdentificationAdapter>();
            services.AddScoped<AStableShelterAdapter>();
            services.AddScoped<ATbclientReferedAdapter>();
            services.AddScoped<ATbtestResultAdapter>();
            services.AddScoped<ATbtreatmentAdapter>();
            services.AddScoped<ATbtreatmentDurationAdapter>();
            services.AddScoped<ATermAdapter>();
            services.AddScoped<ATrainningCurriculumAdapter>();
            services.AddScoped<ATuberclosisTreatmentAdapter>();
            services.AddScoped<AViralLoadLevelAdapter>();
            services.AddScoped<AViralLoadResultsAdapter>();
            services.AddScoped<AViralLoadSuppressedAdapter>();
            services.AddScoped<AVslaGroupTrainerAdapter>();
            services.AddScoped<TrainingSessionAdapter>();
            services.AddScoped<ProgramParticipationStatusAdapter>();
            services.AddScoped<ReasonForBorrowingLoanAdapter>();
            services.AddScoped<ReferredDisabilityAdapter>();
            services.AddScoped<RegimenAdapter>();
            services.AddScoped<RegimenCategoryAdapter>();
            services.AddScoped<RelationshipAdapter>();
            services.AddScoped<SavingSchemeAdapter>();
            services.AddScoped<RegistrationStatusAdapter>();
            services.AddScoped<AvatPartialAdapter>();
            services.AddScoped<GroupCompositionAdapter>();
            services.AddScoped<MonthlyCaseTrackingRegisterAdapter>();
            services.AddScoped<MonthlyCaseTrackingRegisterDetailAdapter>();

            services.AddScoped<VslaGroupCompositionDirectMemberAdapter>();
            services.AddScoped<VslaGroupCompositionIndirectMemberAdapter>();
            services.AddScoped<VslaGroupCompositionCommiteeAdapter>();

            services.AddScoped<OtherVslaGroupCompositionDirectMemberAdapter>();
            services.AddScoped<OtherVslaGroupCompositionIndirectMemberAdapter>();
            services.AddScoped<OtherVslaGroupCompositionCommiteeAdapter>();
            services.AddScoped<APIUploadAdapter>();
            services.AddScoped<HomevisitDetailAdapter>();
            services.AddScoped<ProjectsTargetAdaptor>();
            services.AddScoped<ContactsAdapter>();

            services.AddScoped<IHivStatPositiveClients, HivStatPositiveClientsRepository>();
            services.AddScoped<IHivStatPositiveClientsArt, HivStatPositiveClientsArtRepository>();
            services.AddScoped<IHivStatPositiveClientsEligibleVL, HivStatPositiveClientsEligibleVLRepository>();
            services.AddScoped<IHivStatPositiveClientsReceivedVLResults, HivStatPositiveClientsReceivedVLResultsRepository>();
            services.AddScoped<IHivStatPositiveClientsSuppressedResultsVL, HivStatPositiveClientsSuppressedResultsVLRepository>();
            services.AddScoped<IHivStatPositiveClientsTakenVL, HivStatPositiveClientsTakenVLRepository>();
            services.AddScoped<IHivStatHei, HivStatHeiRepository>();
            services.AddScoped<IHivStatHeiEidNegative, HivStatHeiEidNegativeRepository>();
            services.AddScoped<IHivStatHeiEidPositive, HivStatHeiEidPositiveRepository>();
            services.AddScoped<IHivStatHeiPcr, HivStatHeiPcrRepository>();

            services.AddScoped<IOvcBeneficiariesHivStatus, OvcBeneficiariesHivStatusRepository>();
            services.AddScoped<IOvcBeneficiariesICare, OvcBeneficiariesICareRepository>();
            services.AddScoped<IOvcChildProtection, OvcChildProtectionRepository>();
            services.AddScoped<IOvcEconomicStability, OvcEconomicStabilityRepository>();
            services.AddScoped<IOvcEducation, OvcEducationRepository>();
            services.AddScoped<IOvcFoodSecurity, OvcFoodSecurityRepository>();
            services.AddScoped<IOvcGenderICare, OvcGenderICareRepository>();
            services.AddScoped<IOvcHealthService, OvcHealthServiceRepository>();
            services.AddScoped<IOvcHhICare, OvcHhICareRepository>();
            services.AddScoped<IOvcPss, OvcPssRepository>();
            services.AddScoped<BeneficiaryLinkageTrackingToolNewAdapter>();
            services.AddScoped<GraduationBenchMarkAdapter>();
			services.AddScoped<TargetsAdapter>(); 
            services.AddScoped<StakeHolderDataCaptureAdaptor>(); 
            services.AddScoped<DataCaptureHeaderAdapter>();
            services.AddScoped<TbSensitizationAdapter>();

            SchedulerTask.StartAsync().GetAwaiter().GetResult();

            services.AddCors(o => o.AddPolicy("AllowAnyOrigins", builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTMwOTMyOUAzMjMwMmUzNDJlMzBHRG1KR3BMTUZQd25XYmNXa2U1M2xkUkVNQmoyc2ovcGRiU0V1dDk3SFJVPQ==");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjU2MjUyMUAzMjMyMmUzMDJlMzBoYTB5OFBJa0IxZlc5Z1RHUVYycWRuV2k3cTNqd1BIU2Q1emIvcjAxWllnPQ==");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors("AllowAnyOrigins");
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
//Scaffold-DbContext "Server=.;Database=MUCOBADI;User Id=sa;password=8686;Trusted_Connection=False;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f -context "MUCOBADIContext" -NoPluralize

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


//SPToCore.exe scan -cnn "Data Source=.;Initial Catalog=MUCOBADI;Persist Security Info=True;User ID=sa;Password=8686;" -sch * -nsp MUCOBADI -ctx MUCOBADIContext -sf Models -pf D:\MVCProjects\BlazorProject\MUCOBADI06Jan2023\MUCOBADI_21_12_2022\MUCOBADI06Jan2023\Models\ -f SPToCoreContext.cs

//SfCarousel indicator type
//https://blazor.syncfusion.com/demos/carousel/indicator-type?theme=fluent&_gl=1*10lhko1*_ga*Mzg0MTE4NDM5LjE2NTU3MjY3NTk.*_ga_WC4JKKPHH0*MTY4OTA2NjAxNC40MDUuMS4xNjg5MDY4NzE4LjU5LjAuMA..*_ga_2QTHE2Y2YX*MTY4OTA2NjAxNS4yOS4xLjE2ODkwNjg3MTguNjAuMC4w&_ga=2.124005699.894994975.1688991822-384118439.1655726759