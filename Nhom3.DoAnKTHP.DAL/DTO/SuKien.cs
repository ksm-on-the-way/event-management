using System;
using System.Collections.Generic;

namespace Nhom3.DoAnKTHP.DAL.DTO;

public partial class SuKien
{
    public int MaSuKien { get; set; }

    public string? TenSuKien { get; set; }

    public string? MoTa { get; set; }

    public int MaChuDe { get; set; }

    public string? DiaDiem { get; set; }

    public bool ChoPhepSinhVien { get; set; }

    public int? SoLuongChoPhep { get; set; }

    public int? SoLuongHienTai { get; set; }

    public DateTime ThoiGianBatDau { get; set; }

    public int MaBenToChuc { get; set; }

    public virtual ICollection<DangKyThamGia> DangKyThamGia { get; set; } = new List<DangKyThamGia>();

    public virtual ICollection<DangSuKien> DangSuKiens { get; set; } = new List<DangSuKien>();

    public virtual ThanhVien MaBenToChucNavigation { get; set; } = null!;

    public virtual ChuDe MaChuDeNavigation { get; set; } = null!;
}
