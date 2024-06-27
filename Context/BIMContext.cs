using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using MUCOBADI.Models;

#nullable disable

namespace MUCOBADI.Context
{
    public partial class BIMContext : DbContext
    {
        public BIMContext()
        {
        }

        public BIMContext(DbContextOptions<BIMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BusinessPlanDetail> BusinessPlanDetail { get; set; }
        public virtual DbSet<BusinessPlanHeader> BusinessPlanHeader { get; set; }
        public virtual DbSet<BusinessTrackingLedger> BusinessTrackingLedger { get; set; }
        public virtual DbSet<BusinessTrackingLedgerMoc> BusinessTrackingLedgerMoc { get; set; }
        public virtual DbSet<BusinessTrackingLedgerSue> BusinessTrackingLedgerSue { get; set; }
        public virtual DbSet<IsvatcurrentBusinessOpportunity> IsvatcurrentBusinessOpportunity { get; set; }
        public virtual DbSet<IsvatcurrentBusinessRisk> IsvatcurrentBusinessRisk { get; set; }
        public virtual DbSet<IsvatgeneratedProfit> IsvatgeneratedProfit { get; set; }
        public virtual DbSet<Isvatheader> Isvatheader { get; set; }
        public virtual DbSet<IsvatincomeEarner> IsvatincomeEarner { get; set; }
        public virtual DbSet<IsvatincomeOwnership> IsvatincomeOwnership { get; set; }
        public virtual DbSet<Isvatloss> Isvatloss { get; set; }
        public virtual DbSet<IsvatstartBusinessAnswer> IsvatstartBusinessAnswer { get; set; }
        public virtual DbSet<IsvatworkingCapital> IsvatworkingCapital { get; set; }

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

            modelBuilder.Entity<BusinessPlanDetail>(entity =>
            {
                entity.Property(e => e.BusinessPlanDetailId).ValueGeneratedNever();

                entity.HasOne(d => d.BusinessPlanHeader)
                    .WithMany(p => p.BusinessPlanDetail)
                    .HasForeignKey(d => d.BusinessPlanHeaderId)
                    .HasConstraintName("FK_BusinessPlanDetail_BusinessPlanHeader");
            });

            modelBuilder.Entity<BusinessPlanHeader>(entity =>
            {
                entity.Property(e => e.BusinessPlanHeaderId).ValueGeneratedNever();

                entity.Property(e => e.DataCollectionDate).HasColumnType("date");

                entity.Property(e => e.DataCollectorName).HasMaxLength(3000);

                entity.Property(e => e.DataCollectorTitle).HasMaxLength(2000);

                entity.Property(e => e.DataReviewDate).HasColumnType("date");

                entity.Property(e => e.DataReviewerName).HasMaxLength(3000);

                entity.Property(e => e.DataReviewerTitle).HasMaxLength(2000);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BusinessTrackingLedger>(entity =>
            {
                entity.Property(e => e.BusinessTrackingLedgerId).ValueGeneratedNever();

                entity.Property(e => e.DataCollectionDate).HasColumnType("date");

                entity.Property(e => e.DataCollectorName).HasMaxLength(3000);

                entity.Property(e => e.DataCollectorTitle).HasMaxLength(2000);

                entity.Property(e => e.DataReviewDate).HasColumnType("date");

                entity.Property(e => e.DataReviewerName).HasMaxLength(3000);

                entity.Property(e => e.DataReviewerTitle).HasMaxLength(2000);

                entity.Property(e => e.ProposedBusinessName).HasMaxLength(3000);
            });

            modelBuilder.Entity<BusinessTrackingLedgerMoc>(entity =>
            {
                entity.HasKey(e => e.MonthlyOperationalCostsId);

                entity.ToTable("BusinessTrackingLedgerMOC");

                entity.Property(e => e.MonthlyOperationalCostsId).ValueGeneratedNever();

                entity.Property(e => e.Item).HasMaxLength(3000);

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(3000);

                entity.HasOne(d => d.BusinessTrackingLedger)
                    .WithMany(p => p.BusinessTrackingLedgerMoc)
                    .HasForeignKey(d => d.BusinessTrackingLedgerId)
                    .HasConstraintName("FK_BusinessTrackingLedgerMOC_BusinessTrackingLedger");
            });

            modelBuilder.Entity<BusinessTrackingLedgerSue>(entity =>
            {
                entity.HasKey(e => e.StartUpExpensesId);

                entity.ToTable("BusinessTrackingLedgerSUE");

                entity.Property(e => e.StartUpExpensesId).ValueGeneratedNever();

                entity.Property(e => e.AvailableResources).HasMaxLength(3000);

                entity.Property(e => e.Item).HasMaxLength(3000);

                entity.Property(e => e.SourceofResources).HasMaxLength(3000);

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(3000);

                entity.HasOne(d => d.BusinessTrackingLedger)
                    .WithMany(p => p.BusinessTrackingLedgerSue)
                    .HasForeignKey(d => d.BusinessTrackingLedgerId)
                    .HasConstraintName("FK_BusinessTrackingLedgerSUE_BusinessTrackingLedger");
            });

            modelBuilder.Entity<IsvatcurrentBusinessOpportunity>(entity =>
            {
                entity.ToTable("ISVATCurrentBusinessOpportunity");

                entity.Property(e => e.IsvatcurrentBusinessOpportunityId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATCurrentBusinessOpportunityId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.Property(e => e.OtherCurrenBusinessOpportunity).HasMaxLength(3000);

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatcurrentBusinessOpportunity)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATCurrentBusinessOpportunity_ISVATHeader");
            });

            modelBuilder.Entity<IsvatcurrentBusinessRisk>(entity =>
            {
                entity.ToTable("ISVATCurrentBusinessRisk");

                entity.Property(e => e.IsvatcurrentBusinessRiskId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATCurrentBusinessRiskId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.Property(e => e.OtherCurrenBusinessRisk).HasMaxLength(3000);

                //entity.HasOne(d => d.Isvatheader)
                //    .WithMany(p => p.IsvatcurrentBusinessRisk)
                //    .HasForeignKey(d => d.IsvatheaderId)
                //    .HasConstraintName("FK_ISVATCurrentBusinessRisk_ISVATHeader");
            });

            modelBuilder.Entity<IsvatgeneratedProfit>(entity =>
            {
                entity.ToTable("ISVATGeneratedProfit");

                entity.Property(e => e.IsvatgeneratedProfitId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATGeneratedProfitId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.Property(e => e.OtherAssetIncome).HasMaxLength(3000);

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatgeneratedProfit)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATGeneratedProfit_ISVATHeader");
            });

            modelBuilder.Entity<Isvatheader>(entity =>
            {
                entity.ToTable("ISVATHeader");

                entity.Property(e => e.IsvatheaderId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATHeaderId");

                entity.Property(e => e.DataCollectionDate).HasColumnType("date");

                entity.Property(e => e.DataCollectorName).HasMaxLength(3000);

                entity.Property(e => e.DataCollectorTitle).HasMaxLength(2000);

                entity.Property(e => e.DataReviewDate).HasColumnType("date");

                entity.Property(e => e.DataReviewerName).HasMaxLength(3000);

                entity.Property(e => e.DataReviewerTitle).HasMaxLength(2000);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<IsvatincomeEarner>(entity =>
            {
                entity.ToTable("ISVATIncomeEarner");

                entity.Property(e => e.IsvatincomeEarnerId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATIncomeEarnerId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatincomeEarner)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolIncomeEarner_IncomeSourceViabilityAssessmentToolHeader");
            });

            modelBuilder.Entity<IsvatincomeOwnership>(entity =>
            {
                entity.ToTable("ISVATIncomeOwnership");

                entity.Property(e => e.IsvatincomeOwnershipId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATIncomeOwnershipId");

                entity.Property(e => e.IsvatincomeEarnerId).HasColumnName("ISVATIncomeEarnerId");

                entity.Property(e => e.OtherAssetIncome).HasMaxLength(3000);

                entity.HasOne(d => d.IsvatincomeEarner)
                    .WithMany(p => p.IsvatincomeOwnership)
                    .HasForeignKey(d => d.IsvatincomeEarnerId)
                    .HasConstraintName("FK_IncomeSourceViabilityAssessmentToolIncomeOwnership_IncomeSourceViabilityAssessmentToolIncomeEarner");
            });

            modelBuilder.Entity<Isvatloss>(entity =>
            {
                entity.ToTable("ISVATLoss");

                entity.Property(e => e.IsvatlossId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATLossId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.Property(e => e.OtherAssetIncome).HasMaxLength(3000);

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.Isvatloss)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATLoss_ISVATHeader");
            });

            modelBuilder.Entity<IsvatstartBusinessAnswer>(entity =>
            {
                entity.ToTable("ISVATStartBusinessAnswer");

                entity.Property(e => e.IsvatstartBusinessAnswerId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATStartBusinessAnswerId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatstartBusinessAnswer)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATStartBusinessAnswer_ISVATHeader");
            });

            modelBuilder.Entity<IsvatworkingCapital>(entity =>
            {
                entity.ToTable("ISVATWorkingCapital");

                entity.Property(e => e.IsvatworkingCapitalId)
                    .ValueGeneratedNever()
                    .HasColumnName("ISVATWorkingCapitalId");

                entity.Property(e => e.IsvatheaderId).HasColumnName("ISVATHeaderId");

                entity.Property(e => e.OtherAssetIncome).HasMaxLength(3000);

                entity.HasOne(d => d.Isvatheader)
                    .WithMany(p => p.IsvatworkingCapital)
                    .HasForeignKey(d => d.IsvatheaderId)
                    .HasConstraintName("FK_ISVATWorkingCapital_ISVATHeader");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
