using System;
using System.Collections.Generic;

namespace Nhom3.DoAnKTHP.DAL.DTO;

public partial class DangKyThamGia
{
    public int MaSuKien { get; set; }

    public int MaThanhVien { get; set; }

    public DateTime? ThoiGianDangKy { get; set; }

    public int MaTrangThaiDuyet { get; set; }

    public int? MaDanhGia { get; set; }

    public virtual MucDoHaiLong? MaDanhGiaNavigation { get; set; }

    public virtual SuKien MaSuKienNavigation { get; set; } = null!;

    public virtual ThanhVien MaThanhVienNavigation { get; set; } = null!;

    public virtual TrangThaiDuyet MaTrangThaiDuyetNavigation { get; set; } = null!;
}
