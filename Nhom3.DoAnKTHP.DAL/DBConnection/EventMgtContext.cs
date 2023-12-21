using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Nhom3.DoAnKTHP.DAL.DTO;

namespace Nhom3.DoAnKTHP.DAL.DBConnection;

public partial class EventMgtContext : DbContext
{
    public EventMgtContext()
    {
    }

    public EventMgtContext(DbContextOptions<EventMgtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChuDe> ChuDes { get; set; }

    public virtual DbSet<DangKyThamGia> DangKyThamGia { get; set; }

    public virtual DbSet<DangSuKien> DangSuKiens { get; set; }

    public virtual DbSet<MucDoHaiLong> MucDoHaiLongs { get; set; }

    public virtual DbSet<SuKien> SuKiens { get; set; }

    public virtual DbSet<ThanhVien> ThanhViens { get; set; }

    public virtual DbSet<ThongBao> ThongBaos { get; set; }

    public virtual DbSet<TrangThaiDuyet> TrangThaiDuyets { get; set; }

    public virtual DbSet<VaiTro> VaiTros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());


    private string? GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DBDefault"];
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChuDe>(entity =>
        {
            entity.HasKey(e => e.MaChuDe).HasName("PK__ChuDe__358545119FBC5DC1");

            entity.ToTable("ChuDe");

            entity.Property(e => e.TenChuDe).HasMaxLength(50);
        });

        modelBuilder.Entity<DangKyThamGia>(entity =>
        {
            entity.HasKey(e => new { e.MaSuKien, e.MaThanhVien }).HasName("PK__DangKyTh__D3DA53914AD1D436");

            entity.Property(e => e.ThoiGianDangKy).HasColumnType("datetime");

            entity.HasOne(d => d.MaDanhGiaNavigation).WithMany(p => p.DangKyThamGia)
                .HasForeignKey(d => d.MaDanhGia)
                .HasConstraintName("FK__DangKyTha__MaDan__5070F446");

            entity.HasOne(d => d.MaSuKienNavigation).WithMany(p => p.DangKyThamGia)
                .HasForeignKey(d => d.MaSuKien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DangKyTha__MaSuK__48CFD27E");

            entity.HasOne(d => d.MaThanhVienNavigation).WithMany(p => p.DangKyThamGia)
                .HasForeignKey(d => d.MaThanhVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DangKyTha__MaTha__49C3F6B7");

            entity.HasOne(d => d.MaTrangThaiDuyetNavigation).WithMany(p => p.DangKyThamGia)
                .HasForeignKey(d => d.MaTrangThaiDuyet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DangKyTha__MaTra__4AB81AF0");
        });

        modelBuilder.Entity<DangSuKien>(entity =>
        {
            entity.HasKey(e => new { e.MaSuKien, e.MaThanhVien }).HasName("PK__DangSuKi__D3DA539151B9D662");

            entity.ToTable("DangSuKien");

            entity.Property(e => e.ThoiGianDangBai).HasColumnType("datetime");

            entity.HasOne(d => d.MaSuKienNavigation).WithMany(p => p.DangSuKiens)
                .HasForeignKey(d => d.MaSuKien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DangSuKie__MaSuK__440B1D61");

            entity.HasOne(d => d.MaThanhVienNavigation).WithMany(p => p.DangSuKiens)
                .HasForeignKey(d => d.MaThanhVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DangSuKie__MaTha__44FF419A");

            entity.HasOne(d => d.MaTrangThaiDuyetNavigation).WithMany(p => p.DangSuKiens)
                .HasForeignKey(d => d.MaTrangThaiDuyet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DangSuKie__MaTra__45F365D3");
        });

        modelBuilder.Entity<MucDoHaiLong>(entity =>
        {
            entity.HasKey(e => e.MaMucDoHaiLong).HasName("PK__MucDoHai__5480CE063E33C005");

            entity.ToTable("MucDoHaiLong");

            entity.Property(e => e.MoTa).HasMaxLength(50);
            entity.Property(e => e.MucDoHaiLong1).HasColumnName("MucDoHaiLong");
        });

        modelBuilder.Entity<SuKien>(entity =>
        {
            entity.HasKey(e => e.MaSuKien).HasName("PK__SuKien__C164599EA2E6B6BD");

            entity.ToTable("SuKien");

            entity.Property(e => e.DiaDiem).HasMaxLength(100);
            entity.Property(e => e.MoTa).HasMaxLength(1000);
            entity.Property(e => e.TenSuKien).HasMaxLength(100);
            entity.Property(e => e.ThoiGianBatDau).HasColumnType("datetime");

            entity.HasOne(d => d.MaBenToChucNavigation).WithMany(p => p.SuKiens)
                .HasForeignKey(d => d.MaBenToChuc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SuKien__MaBenToC__412EB0B6");

            entity.HasOne(d => d.MaChuDeNavigation).WithMany(p => p.SuKiens)
                .HasForeignKey(d => d.MaChuDe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SuKien__MaChuDe__403A8C7D");
        });

        modelBuilder.Entity<ThanhVien>(entity =>
        {
            entity.HasKey(e => e.MaThanhVien).HasName("PK__ThanhVie__2BE0A0F01F4144CB");

            entity.ToTable("ThanhVien");

            entity.Property(e => e.AnhDaiDien).HasColumnType("image");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mssv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MSSV");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenThanhVien).HasMaxLength(100);

            entity.HasOne(d => d.MaVaiTroNavigation).WithMany(p => p.ThanhViens)
                .HasForeignKey(d => d.MaVaiTro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ThanhVien__MaVai__3D5E1FD2");
        });

        modelBuilder.Entity<ThongBao>(entity =>
        {
            entity.HasKey(e => e.MaThongBao).HasName("PK__ThongBao__04DEB54EC9C1DA3B");

            entity.ToTable("ThongBao");

            entity.Property(e => e.NoiDung).HasMaxLength(1000);
            entity.Property(e => e.ThoiGianHieuLuc).HasColumnType("datetime");

            entity.HasOne(d => d.MaNguoiLapThongBaoNavigation).WithMany(p => p.ThongBaos)
                .HasForeignKey(d => d.MaNguoiLapThongBao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ThongBao__MaNguo__4D94879B");
        });

        modelBuilder.Entity<TrangThaiDuyet>(entity =>
        {
            entity.HasKey(e => e.MaTrangThaiDuyet).HasName("PK__TrangTha__242CA4AF4282D0A7");

            entity.ToTable("TrangThaiDuyet");

            entity.Property(e => e.TenTrangThaiDuyet).HasMaxLength(50);
        });

        modelBuilder.Entity<VaiTro>(entity =>
        {
            entity.HasKey(e => e.MaVaiTro).HasName("PK__VaiTro__C24C41CFFBD6AFF8");

            entity.ToTable("VaiTro");

            entity.Property(e => e.TenVaiTro).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
