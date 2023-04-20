using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BNI_POC.API.Models
{
    public partial class BNI_POCContext : DbContext
    {
        public BNI_POCContext()
        {
        }

        public BNI_POCContext(DbContextOptions<BNI_POCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<MsApprovalMatrix> MsApprovalMatrices { get; set; } = null!;
        public virtual DbSet<MsAtm> MsAtms { get; set; } = null!;
        public virtual DbSet<MsBranch> MsBranches { get; set; } = null!;
        public virtual DbSet<MsBranchType> MsBranchTypes { get; set; } = null!;
        public virtual DbSet<MsDenomType> MsDenomTypes { get; set; } = null!;
        public virtual DbSet<MsIconInfo> MsIconInfos { get; set; } = null!;
        public virtual DbSet<MsMediaType> MsMediaTypes { get; set; } = null!;
        public virtual DbSet<MsMenu> MsMenus { get; set; } = null!;
        public virtual DbSet<MsRegion> MsRegions { get; set; } = null!;
        public virtual DbSet<MsRole> MsRoles { get; set; } = null!;
        public virtual DbSet<MsRoleMenu> MsRoleMenus { get; set; } = null!;
        public virtual DbSet<MsUser> MsUsers { get; set; } = null!;
        public virtual DbSet<TrAtmOpname> TrAtmOpnames { get; set; } = null!;
        public virtual DbSet<TrCashOpname> TrCashOpnames { get; set; } = null!;
        public virtual DbSet<TrCashOpnameDetail> TrCashOpnameDetails { get; set; } = null!;
        public virtual DbSet<TrSecuritiesOpname> TrSecuritiesOpnames { get; set; } = null!;
        public virtual DbSet<TrainingLog> TrainingLogs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=34.101.154.119;Initial Catalog=BNI_POC;User Id=sa;Password=Indocyber.100;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Log1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Log");
            });

            modelBuilder.Entity<MsApprovalMatrix>(entity =>
            {
                entity.ToTable("Ms_ApprovalMatrix");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovalRoleId).HasColumnName("ApprovalRoleID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsAtm>(entity =>
            {
                entity.ToTable("Ms_Atm");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AtmCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IpAtm)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsBranch>(entity =>
            {
                entity.ToTable("Ms_Branch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchTypeId).HasColumnName("BranchTypeID");

                entity.Property(e => e.ParentBranchId).HasColumnName("ParentBranchID");

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsBranchType>(entity =>
            {
                entity.ToTable("Ms_BranchType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsDenomType>(entity =>
            {
                entity.ToTable("Ms_DenomType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DenomType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenomTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenomTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsIconInfo>(entity =>
            {
                entity.ToTable("Ms_Icon_Info");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Atmid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ATMID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CutoffDate).HasColumnType("datetime");

                entity.Property(e => e.Denom100).HasColumnType("money");

                entity.Property(e => e.Denom20).HasColumnType("money");

                entity.Property(e => e.Denom50).HasColumnType("money");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("");

                entity.Property(e => e.RegisterQty).HasComment("");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.Uom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("");
            });

            modelBuilder.Entity<MsMediaType>(entity =>
            {
                entity.ToTable("Ms_MediaType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MediaTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MediaTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsMenu>(entity =>
            {
                entity.ToTable("Ms_Menu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsRegion>(entity =>
            {
                entity.ToTable("Ms_Region");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsRole>(entity =>
            {
                entity.ToTable("Ms_Role");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsRoleMenu>(entity =>
            {
                entity.ToTable("Ms_RoleMenu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsUser>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("Ms_User");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrAtmOpname>(entity =>
            {
                entity.ToTable("Tr_AtmOpname");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdminInputAmount).HasColumnType("money");

                entity.Property(e => e.AtmBeginAmount).HasColumnType("money");

                entity.Property(e => e.AtmBillAmount).HasColumnType("money");

                entity.Property(e => e.AtmId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.AtmOpnameAmount).HasColumnType("money");

                entity.Property(e => e.AtmOpnameDate).HasColumnType("datetime");

                entity.Property(e => e.AtmOpnameNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DifferenceAmount).HasColumnType("money");

                entity.Property(e => e.LocationLongitude)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NotesDifferenceBillAmount)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoLongitude)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PhotoPath)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.RegionId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("money")
                    .HasComment("");

                entity.Property(e => e.UnitType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UpdDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<TrCashOpname>(entity =>
            {
                entity.ToTable("Tr_CashOpname");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CashOpnameDate).HasColumnType("datetime");

                entity.Property(e => e.CashOpnameNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckingType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DifferenceAmount).HasColumnType("money");

                entity.Property(e => e.IconsTotalAmount).HasColumnType("money");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MediaTypeId).HasColumnName("MediaTypeID");

                entity.Property(e => e.OpnameTotalAmount).HasColumnType("money");

                entity.Property(e => e.PhotoLongLat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPath)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrCashOpnameDetail>(entity =>
            {
                entity.ToTable("Tr_CashOpnameDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CashOpnameId).HasColumnName("CashOpnameID");

                entity.Property(e => e.DenomTypeId).HasColumnName("DenomTypeID");

                entity.Property(e => e.OpnameAmount).HasColumnType("money");

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrSecuritiesOpname>(entity =>
            {
                entity.ToTable("Tr_SecuritiesOpname");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.PhotoLongitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SecuritiesNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SecuritiesType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrainingLog>(entity =>
            {
                entity.ToTable("TrainingLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Customername)
                    .HasMaxLength(50)
                    .HasColumnName("customername");

                entity.Property(e => e.Identityno)
                    .HasMaxLength(50)
                    .HasColumnName("identityno");

                entity.Property(e => e.Logdate)
                    .HasColumnType("datetime")
                    .HasColumnName("logdate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
