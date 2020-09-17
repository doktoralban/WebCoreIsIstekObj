using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
 


namespace WebCoreIsIstek.Core.Entities
{
    public partial class EX_dbMakinaBakimContext : DbContext
    {
        public EX_dbMakinaBakimContext()
        {
        }

        public EX_dbMakinaBakimContext(DbContextOptions<EX_dbMakinaBakimContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbJobRequests> TbJobRequests { get; set; }
        public virtual DbSet<TbJobTypes> TbJobTypes { get; set; }
        public virtual DbSet<TbLocations> TbLocations { get; set; }
        public virtual DbSet<TbMachines> TbMachines { get; set; }
        public virtual DbSet<TbMaintainanceAndRepaires> TbMaintainanceAndRepaires { get; set; }
        public virtual DbSet<TbMaintainanceCategories> TbMaintainanceCategories { get; set; }
        public virtual DbSet<TbMaintainanceGroups> TbMaintainanceGroups { get; set; }
        public virtual DbSet<TbMaintainanceTypes> TbMaintainanceTypes { get; set; }
        public virtual DbSet<TbRecordGroups> TbRecordGroups { get; set; }
        public virtual DbSet<TbSituations> TbSituations { get; set; }
        public virtual DbSet<TbUsers> TbUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //var connection = WebCoreIsIstek.Core.Configuration.WebCoreIsIstekSettings.
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=localhost;Database=dbMakinaBakim;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbJobRequests>(entity =>
            {
                entity.HasKey(e => e.JobRequestId);

                entity.ToTable("tbJobRequests");

                entity.HasIndex(e => e.JobSituationId)
                    .HasName("IX_tbJobRequests_4");

                entity.HasIndex(e => e.JobTypeId)
                    .HasName("IX_tbJobRequests_1");

                entity.HasIndex(e => e.LocationId)
                    .HasName("IX_tbJobRequests_2");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_tbJobRequests_3");

                entity.HasIndex(e => e.RequestUserIid)
                    .HasName("IX_tbJobRequests");

                entity.Property(e => e.JobRequestId)
                    .HasColumnName("JobRequestID")
                    .ValueGeneratedNever();

                entity.Property(e => e.JobDescription).IsUnicode(false);

                entity.Property(e => e.JobSituationId).HasColumnName("JobSituationID");

                entity.Property(e => e.JobSubject)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.RecordCreatedBy).HasMaxLength(50);

                entity.Property(e => e.RecordCreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordGroupId)
                    .HasColumnName("RecordGroupID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RecordLastUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordLastUpdatedBy).HasMaxLength(50);

                entity.Property(e => e.RequestUserIid).HasColumnName("RequestUserIID");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.TbJobRequests)
                    .HasForeignKey(d => d.JobTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbJobRequests_tbJobTypes");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.TbJobRequests)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbJobRequests_tbLocations");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TbJobRequests)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK_tbJobRequests_tbMachines");
            });

            modelBuilder.Entity<TbJobTypes>(entity =>
            {
                entity.HasKey(e => e.JobTypeId);

                entity.ToTable("tbJobTypes");

                entity.HasIndex(e => e.TypeName)
                    .HasName("IX_tbJobTypes");

                entity.Property(e => e.JobTypeId)
                    .HasColumnName("JobTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'a')");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbLocations>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("tbLocations");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TbMachines>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("tbMachines");

                entity.HasIndex(e => e.Code)
                    .HasName("IX_tbMachines")
                    .IsUnique();

                entity.HasIndex(e => e.LocationId)
                    .HasName("IX_tbMachines_1");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModelName).HasMaxLength(50);

                entity.Property(e => e.RecordCreatedBy).HasMaxLength(50);

                entity.Property(e => e.RecordCreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordLastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordLastUpdatedBy).HasMaxLength(50);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.TypeName).HasMaxLength(50);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.TbMachines)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_tbMachines_tbLocations");
            });

            modelBuilder.Entity<TbMaintainanceAndRepaires>(entity =>
            {
                entity.HasKey(e => e.MaintainanceAndRepaireId);

                entity.ToTable("tbMaintainanceAndRepaires");

                entity.HasIndex(e => e.JobTypeId)
                    .HasName("IX_tbMaintainanceAndRepaires_1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_tbMaintainanceAndRepaires_2");

                entity.HasIndex(e => e.MaintainanceCategoryId)
                    .HasName("IX_tbMaintainanceAndRepaires");

                entity.Property(e => e.MaintainanceAndRepaireId)
                    .HasColumnName("MaintainanceAndRepaireID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccepptingBy).HasMaxLength(50);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MaintainanceCategoryId).HasColumnName("MaintainanceCategoryID");

                entity.Property(e => e.RecordCreatedBy).HasMaxLength(50);

                entity.Property(e => e.RecordCreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordGroupId)
                    .HasColumnName("RecordGroupID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.RecordLastUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordLastUpdatedBy).HasMaxLength(50);

                entity.Property(e => e.RequestBy).HasMaxLength(50);

                entity.Property(e => e.SituationId).HasColumnName("SituationID");

                entity.Property(e => e.StartDateTine).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbMaintainanceCategories>(entity =>
            {
                entity.HasKey(e => e.MaintainanceCategoryId);

                entity.ToTable("tbMaintainanceCategories");

                entity.HasIndex(e => e.CategoryName)
                    .HasName("IX_tbMaintainanceCategories")
                    .IsUnique();

                entity.Property(e => e.MaintainanceCategoryId)
                    .HasColumnName("MaintainanceCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbMaintainanceGroups>(entity =>
            {
                entity.HasKey(e => e.MaintainanceGroupId);

                entity.ToTable("tbMaintainanceGroups");

                entity.HasIndex(e => e.MaintainanceGroupName)
                    .HasName("IX_tbMaintainanceGroups")
                    .IsUnique();

                entity.Property(e => e.MaintainanceGroupId)
                    .HasColumnName("MaintainanceGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaintainanceGroupName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbMaintainanceTypes>(entity =>
            {
                entity.HasKey(e => e.MaintainanceTypeId);

                entity.ToTable("tbMaintainanceTypes");

                entity.HasIndex(e => new { e.MaintainanceGroupId, e.MaintainanceTypeName })
                    .HasName("IX_tbMaintainanceTypes")
                    .IsUnique();

                entity.Property(e => e.MaintainanceTypeId)
                    .HasColumnName("MaintainanceTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaintainanceGroupId).HasColumnName("MaintainanceGroupID");

                entity.Property(e => e.MaintainanceTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbRecordGroups>(entity =>
            {
                entity.HasKey(e => e.RecordGroupId);

                entity.ToTable("tbRecordGroups");

                entity.HasIndex(e => e.GroupName)
                    .HasName("IX_tbRecordGroups")
                    .IsUnique();

                entity.Property(e => e.RecordGroupId)
                    .HasColumnName("RecordGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbSituations>(entity =>
            {
                entity.HasKey(e => e.SituationId);

                entity.ToTable("tbSituations");

                entity.HasIndex(e => new { e.RecordGroupId, e.SituationName })
                    .HasName("IX_tbSituations")
                    .IsUnique();

                entity.Property(e => e.SituationId)
                    .HasColumnName("SituationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordGroupId)
                    .HasColumnName("RecordGroupID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SituationName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tbUsers");

                entity.HasIndex(e => e.IsActive)
                    .HasName("IX_tbUsers_1");

                entity.HasIndex(e => e.UserName)
                    .HasName("IX_tbUsers")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
