using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MUCOBADI.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
using MUCOBADI.Models;

#nullable disable

namespace MUCOBADI.Context
{
    public partial class UtilitiesContext : DbContext
    {
        public UtilitiesContext()
        {
        }

        public UtilitiesContext(DbContextOptions<UtilitiesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AAdministrationPhase> AAdministrationPhases { get; set; }
        public virtual DbSet<AAgreeDisagree> AAgreeDisagrees { get; set; }
        public virtual DbSet<AAssetIncome> AAssetIncomes { get; set; }
        public virtual DbSet<ABusinessPlanQuestion> ABusinessPlanQuestions { get; set; }
        public virtual DbSet<ABusinessVentureCapitalInvestment> ABusinessVentureCapitalInvestments { get; set; }
        public virtual DbSet<ACategoryofResidence> ACategoryofResidences { get; set; }
        public virtual DbSet<ACurrenBusinessOpportunity> ACurrenBusinessOpportunities { get; set; }
        public virtual DbSet<ACurrenBusinessRisk> ACurrenBusinessRisks { get; set; }
        public virtual DbSet<ADeliveryMethod> ADeliveryMethods { get; set; }
        public virtual DbSet<AImplementationMethod> AImplementationMethods { get; set; }
        public virtual DbSet<AInterventionAttendance> AInterventionAttendances { get; set; }
        public virtual DbSet<AInterventionType> AInterventionTypes { get; set; }
        public virtual DbSet<ANatureofResidence> ANatureofResidences { get; set; }
        public virtual DbSet<ANmnSampledFor> ANmnSampledFors { get; set; }
        public virtual DbSet<ANmnSectionOneQuestion> ANmnSectionOneQuestions { get; set; }
        public virtual DbSet<ANmnSectionTwoAnswer> ANmnSectionTwoAnswers { get; set; }
        public virtual DbSet<ANmnSectionTwoQuestion> ANmnSectionTwoQuestions { get; set; }
        public virtual DbSet<ARiskLevelRating> ARiskLevelRatings { get; set; }
        public virtual DbSet<AStartBusinessQuestion> AStartBusinessQuestions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                               .SetBasePath(Directory.GetCurrentDirectory())
                                               .AddJsonFile("appsettings.json")
                                               .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AAdministrationPhase>(entity =>
            {
                entity.HasKey(e => e.AdministrationPhaseId);

                entity.ToTable("A_AdministrationPhase");

                entity.Property(e => e.AdministrationPhaseId).ValueGeneratedNever();

                entity.Property(e => e.AdministrationPhaseDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<AAgreeDisagree>(entity =>
            {
                entity.HasKey(e => e.AgreeDisagreeId);

                entity.ToTable("A_AgreeDisagree");

                entity.Property(e => e.AgreeDisagreeId).ValueGeneratedNever();

                entity.Property(e => e.AgreeDisagreeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AAssetIncome>(entity =>
            {
                entity.HasKey(e => e.AssetIncomeId);

                entity.ToTable("A_AssetIncome");

                entity.Property(e => e.AssetIncomeId).ValueGeneratedNever();

                entity.Property(e => e.AssetIncomeDesc).HasMaxLength(2000);
            });

            modelBuilder.Entity<ABusinessPlanQuestion>(entity =>
            {
                entity.HasKey(e => e.BusinessPlanQuestionId);

                entity.ToTable("A_BusinessPlanQuestion");

                entity.Property(e => e.BusinessPlanQuestionId).ValueGeneratedNever();

                entity.Property(e => e.QuestionCategory).HasMaxLength(3000);

                entity.Property(e => e.QuestionClassification).HasMaxLength(3000);
            });

            modelBuilder.Entity<ABusinessVentureCapitalInvestment>(entity =>
            {
                entity.HasKey(e => e.BusinessVentureCapitalInvestmentId);

                entity.ToTable("A_BusinessVentureCapitalInvestment");

                entity.Property(e => e.BusinessVentureCapitalInvestmentId).ValueGeneratedNever();

                entity.Property(e => e.BusinessVentureCapitalInvestmentDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACategoryofResidence>(entity =>
            {
                entity.HasKey(e => e.CategoryofResidenceId);

                entity.ToTable("A_CategoryofResidence");

                entity.Property(e => e.CategoryofResidenceId).ValueGeneratedNever();

                entity.Property(e => e.CategoryofResidenceDesc).HasMaxLength(2000);
            });

            modelBuilder.Entity<ACurrenBusinessOpportunity>(entity =>
            {
                entity.HasKey(e => e.CurrenBusinessOpportunityId);

                entity.ToTable("A_CurrenBusinessOpportunity");

                entity.Property(e => e.CurrenBusinessOpportunityId).ValueGeneratedNever();

                entity.Property(e => e.CurrenBusinessOpportunityDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACurrenBusinessRisk>(entity =>
            {
                entity.HasKey(e => e.CurrenBusinessRiskId);

                entity.ToTable("A_CurrenBusinessRisk");

                entity.Property(e => e.CurrenBusinessRiskId).ValueGeneratedNever();

                entity.Property(e => e.CurrenBusinessRiskDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ADeliveryMethod>(entity =>
            {
                entity.HasKey(e => e.DeliveryMethodId);

                entity.ToTable("A_DeliveryMethod");

                entity.Property(e => e.DeliveryMethodId).ValueGeneratedNever();

                entity.Property(e => e.DeliveryMethodDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AImplementationMethod>(entity =>
            {
                entity.HasKey(e => e.ImplementationMethodId);

                entity.ToTable("A_ImplementationMethod");

                entity.Property(e => e.ImplementationMethodId).ValueGeneratedNever();

                entity.Property(e => e.ImplementationMethodDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AInterventionAttendance>(entity =>
            {
                entity.HasKey(e => e.InterventionAttendanceId);

                entity.ToTable("A_InterventionAttendance");

                entity.Property(e => e.InterventionAttendanceId).ValueGeneratedNever();

                entity.Property(e => e.InterventionAttendanceDesc).HasMaxLength(2000);
            });

            modelBuilder.Entity<AInterventionType>(entity =>
            {
                entity.HasKey(e => e.InterventionTypeId);

                entity.ToTable("A_InterventionType");

                entity.Property(e => e.InterventionTypeId).ValueGeneratedNever();

                entity.Property(e => e.InterventionTypeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ANatureofResidence>(entity =>
            {
                entity.HasKey(e => e.NatureofResidenceId);

                entity.ToTable("A_NatureofResidence");

                entity.Property(e => e.NatureofResidenceId).ValueGeneratedNever();

                entity.Property(e => e.NatureofResidenceDesc).HasMaxLength(2000);
            });

            modelBuilder.Entity<ANmnSampledFor>(entity =>
            {
                entity.HasKey(e => e.SampledForId);

                entity.ToTable("A_NMN_SampledFor");

                entity.Property(e => e.SampledForId).ValueGeneratedNever();

                entity.Property(e => e.SampledForDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ANmnSectionOneQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("A_NMN_Section_One_Question");

                entity.Property(e => e.QuestionId).ValueGeneratedNever();

                entity.Property(e => e.QuestionDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ANmnSectionTwoAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId);

                entity.ToTable("A_NMN_Section_Two_Answer");

                entity.Property(e => e.AnswerId).ValueGeneratedNever();

                entity.Property(e => e.AnswerDesc).HasMaxLength(3000);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ANmnSectionTwoAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_A_NMN_Section_Two_Answer_A_NMN_Section_Two_Question");
            });

            modelBuilder.Entity<ANmnSectionTwoQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("A_NMN_Section_Two_Question");

                entity.Property(e => e.QuestionId).ValueGeneratedNever();

                entity.Property(e => e.QuestionDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ARiskLevelRating>(entity =>
            {
                entity.HasKey(e => e.RiskLevelRatingId);

                entity.ToTable("A_RiskLevelRating");

                entity.Property(e => e.RiskLevelRatingId).ValueGeneratedNever();

                entity.Property(e => e.RiskLevelRatingDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AStartBusinessQuestion>(entity =>
            {
                entity.HasKey(e => e.StartBusinessQuestionId);

                entity.ToTable("A_StartBusinessQuestion");

                entity.Property(e => e.StartBusinessQuestionId).ValueGeneratedNever();

                entity.Property(e => e.StartBusinessQuestionDesc).HasMaxLength(3000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
