using System;
using System.Collections.Generic;

namespace Nhom3.DoAnKTHP.DAL.DTO;

public partial class ThongBao
{
    public int MaThongBao { get; set; }

    public string? NoiDung { get; set; }

    public int MaNguoiLapThongBao { get; set; }

    public DateTime ThoiGianHieuLuc { get; set; }

    public virtual ThanhVien MaNguoiLapThongBaoNavigation { get; set; } = null!;
}
