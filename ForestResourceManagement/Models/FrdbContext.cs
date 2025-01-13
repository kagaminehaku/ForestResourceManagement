using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ForestResourceManagement;

public partial class FrdbContext : DbContext
{
    public FrdbContext()
    {
    }

    public FrdbContext(DbContextOptions<FrdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessTable> AccessTables { get; set; }

    public virtual DbSet<CoSoLuuTru> CoSoLuuTrus { get; set; }

    public virtual DbSet<DanhMucCoSoLuuTru> DanhMucCoSoLuuTrus { get; set; }

    public virtual DbSet<DanhMucDongVat> DanhMucDongVats { get; set; }

    public virtual DbSet<DongVat> DongVats { get; set; }

    public virtual DbSet<HuyenTable> HuyenTables { get; set; }

    public virtual DbSet<InstructionTable> InstructionTables { get; set; }

    public virtual DbSet<LogTable> LogTables { get; set; }

    public virtual DbSet<RoleGroupAccess> RoleGroupAccesses { get; set; }

    public virtual DbSet<RoleGroupTable> RoleGroupTables { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<XaTable> XaTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=kagaminehaku.softether.net,25564;Database=FRDB;user id=sa;password=17102003;trust server certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccessTable>(entity =>
        {
            entity.HasKey(e => e.AcessId).HasName("PK_RoleTable");

            entity.ToTable("AccessTable");

            entity.Property(e => e.AcessId)
                .ValueGeneratedNever()
                .HasColumnName("AcessID");
            entity.Property(e => e.AccessInfo).HasColumnType("text");
            entity.Property(e => e.AccessName).HasMaxLength(64);
        });

        modelBuilder.Entity<CoSoLuuTru>(entity =>
        {
            entity.ToTable("CoSoLuuTru");

            entity.Property(e => e.CoSoLuuTruId).HasColumnName("CoSoLuuTruID");
            entity.Property(e => e.DanhMucCoSoLuuTruId).HasColumnName("DanhMucCoSoLuuTruID");
            entity.Property(e => e.TenCoSoLuuTru).HasMaxLength(256);
            entity.Property(e => e.ThongTin).HasColumnType("text");

            entity.HasOne(d => d.DanhMucCoSoLuuTru).WithMany(p => p.CoSoLuuTrus)
                .HasForeignKey(d => d.DanhMucCoSoLuuTruId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CoSoLuuTru_DanhMucCoSoLuuTru");
        });

        modelBuilder.Entity<DanhMucCoSoLuuTru>(entity =>
        {
            entity.ToTable("DanhMucCoSoLuuTru");

            entity.Property(e => e.DanhMucCoSoLuuTruId)
                .ValueGeneratedNever()
                .HasColumnName("DanhMucCoSoLuuTruID");
            entity.Property(e => e.TenDanhMucCoSoLuuTru).HasMaxLength(256);
            entity.Property(e => e.ThongTin).HasColumnType("text");
        });

        modelBuilder.Entity<DanhMucDongVat>(entity =>
        {
            entity.HasKey(e => e.DanhMucDvid);

            entity.ToTable("DanhMucDongVat");

            entity.Property(e => e.DanhMucDvid).HasColumnName("DanhMucDVID");
            entity.Property(e => e.TenDanhMucDv)
                .HasMaxLength(256)
                .HasColumnName("TenDanhMucDV");
            entity.Property(e => e.ThongTin).HasColumnType("text");
        });

        modelBuilder.Entity<DongVat>(entity =>
        {
            entity.ToTable("DongVat");

            entity.Property(e => e.DongVatId).HasColumnName("DongVatID");
            entity.Property(e => e.DanhMucDvid).HasColumnName("DanhMucDVID");
            entity.Property(e => e.TenDongVat).HasMaxLength(256);
            entity.Property(e => e.ThongTinDongVat).HasColumnType("text");
        });

        modelBuilder.Entity<HuyenTable>(entity =>
        {
            entity.HasKey(e => e.HuyenId);

            entity.ToTable("HuyenTable");

            entity.Property(e => e.HuyenId).HasColumnName("HuyenID");
            entity.Property(e => e.Info).HasColumnType("text");
            entity.Property(e => e.TenHuyen).HasMaxLength(256);
        });

        modelBuilder.Entity<InstructionTable>(entity =>
        {
            entity.HasKey(e => e.InstructionId).HasName("PK_Instructiontable");

            entity.ToTable("InstructionTable");

            entity.Property(e => e.InstructionId).HasColumnName("InstructionID");
            entity.Property(e => e.InstructionContent).HasColumnType("text");
            entity.Property(e => e.InstructionName).HasMaxLength(256);
        });

        modelBuilder.Entity<LogTable>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("LogTable");

            entity.Property(e => e.LogId)
                .ValueGeneratedNever()
                .HasColumnName("LogID");
            entity.Property(e => e.LogEvent).HasColumnType("text");
            entity.Property(e => e.LogType).HasMaxLength(256);
        });

        modelBuilder.Entity<RoleGroupAccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RoleGroupAccess");

            entity.Property(e => e.AccessId).HasColumnName("AccessID");
            entity.Property(e => e.RoleGroupAccessId).HasColumnName("RoleGroupAccessID");
            entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");

            entity.HasOne(d => d.Access).WithMany()
                .HasForeignKey(d => d.AccessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleGroupAccess_AccessTable");

            entity.HasOne(d => d.RoleGroup).WithMany()
                .HasForeignKey(d => d.RoleGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleGroupAccess_RoleGroupTable");
        });

        modelBuilder.Entity<RoleGroupTable>(entity =>
        {
            entity.HasKey(e => e.RoleGroupId);

            entity.ToTable("RoleGroupTable");

            entity.Property(e => e.RoleGroupId)
                .ValueGeneratedNever()
                .HasColumnName("RoleGroupID");
            entity.Property(e => e.RoleGroupName).HasMaxLength(128);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK_UserAccounts_1");

            entity.Property(e => e.Email).HasMaxLength(64);
            entity.Property(e => e.Info).HasColumnType("text");
            entity.Property(e => e.Password).HasMaxLength(256);
            entity.Property(e => e.Phone).HasMaxLength(16);
            entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");
            entity.Property(e => e.Username).HasMaxLength(128);

            entity.HasOne(d => d.RoleGroup).WithMany(p => p.UserAccounts)
                .HasForeignKey(d => d.RoleGroupId)
                .HasConstraintName("FK_UserAccounts_RoleGroupTable");
        });

        modelBuilder.Entity<XaTable>(entity =>
        {
            entity.HasKey(e => e.XaId);

            entity.ToTable("XaTable");

            entity.Property(e => e.XaId).HasColumnName("XaID");
            entity.Property(e => e.HuyenId).HasColumnName("HuyenID");
            entity.Property(e => e.Info).HasColumnType("text");
            entity.Property(e => e.TenXa).HasMaxLength(256);

            entity.HasOne(d => d.Huyen).WithMany(p => p.XaTables)
                .HasForeignKey(d => d.HuyenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_XaTable_HuyenTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
