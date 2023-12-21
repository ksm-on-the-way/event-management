using System;
using System.Collections.Generic;

namespace Nhom3.DoAnKTHP.DAL.DTO;

public partial class MucDoHaiLong
{
    public int MaMucDoHaiLong { get; set; }

    public int MucDoHaiLong1 { get; set; }

    public string MoTa { get; set; } = null!;

    public virtual ICollection<DangKyThamGia> DangKyThamGia { get; set; } = new List<DangKyThamGia>();
}
