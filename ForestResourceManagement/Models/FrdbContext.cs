﻿using System;
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

    public virtual DbSet<LogTable> LogTables { get; set; }

    public virtual DbSet<RoleGroupAccess> RoleGroupAccesses { get; set; }

    public virtual DbSet<RoleGroupTable> RoleGroupTables { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=miracleland.ddns.net,25564;Database=FRDB;user id=sa;password=17102003;trust server certificate=true");

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

        modelBuilder.Entity<LogTable>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("LogTable");

            entity.Property(e => e.LogId)
                .ValueGeneratedNever()
                .HasColumnName("LogID");
            entity.Property(e => e.LogEvent).HasColumnType("text");
            entity.Property(e => e.LogIndex).ValueGeneratedOnAdd();
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
            entity.Property(e => e.AccessId).HasColumnName("AccessID");
            entity.Property(e => e.RoleGroupName).HasMaxLength(128);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.Property(e => e.Uid).ValueGeneratedNever();
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}