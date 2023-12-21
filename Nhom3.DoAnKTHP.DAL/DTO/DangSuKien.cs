using System;
using System.Collections.Generic;

namespace Nhom3.DoAnKTHP.DAL.DTO;

public partial class DangSuKien
{
    public int MaSuKien { get; set; }

    public int MaThanhVien { get; set; }

    public DateTime? ThoiGianDangBai { get; set; }

    public int MaTrangThaiDuyet { get; set; }

    public virtual SuKien MaSuKienNavigation { get; set; } = null!;

    public virtual ThanhVien MaThanhVienNavigation { get; set; } = null!;

    public virtual TrangThaiDuyet MaTrangThaiDuyetNavigation { get; set; } = null!;
}
