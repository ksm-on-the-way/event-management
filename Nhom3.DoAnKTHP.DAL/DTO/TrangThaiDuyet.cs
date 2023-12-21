using System;
using System.Collections.Generic;

namespace Nhom3.DoAnKTHP.DAL.DTO;

public partial class TrangThaiDuyet
{
    public int MaTrangThaiDuyet { get; set; }

    public string TenTrangThaiDuyet { get; set; } = null!;

    public virtual ICollection<DangKyThamGia> DangKyThamGia { get; set; } = new List<DangKyThamGia>();

    public virtual ICollection<DangSuKien> DangSuKiens { get; set; } = new List<DangSuKien>();
}
