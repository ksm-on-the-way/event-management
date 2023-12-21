using System;
using System.Collections.Generic;

namespace Nhom3.DoAnKTHP.DAL.DTO;

public partial class ThanhVien
{
    public int MaThanhVien { get; set; }

    public string TenThanhVien { get; set; } = null!;

    public DateOnly? NgaySinh { get; set; }

    public bool? GioiTinh { get; set; }

    public string SoDienThoai { get; set; } = null!;

    public string? Mssv { get; set; }

    public string Email { get; set; } = null!;

    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public int MaVaiTro { get; set; }

    public byte[]? AnhDaiDien { get; set; }

    public virtual ICollection<DangKyThamGia> DangKyThamGia { get; set; } = new List<DangKyThamGia>();

    public virtual ICollection<DangSuKien> DangSuKiens { get; set; } = new List<DangSuKien>();

    public virtual VaiTro MaVaiTroNavigation { get; set; } = null!;

    public virtual ICollection<SuKien> SuKiens { get; set; } = new List<SuKien>();

    public virtual ICollection<ThongBao> ThongBaos { get; set; } = new List<ThongBao>();
}
