using System;
using System.Collections.Generic;

namespace Nhom3.DoAnKTHP.DAL.DTO;

public partial class ChuDe
{
    public int MaChuDe { get; set; }

    public string TenChuDe { get; set; } = null!;

    public virtual ICollection<SuKien> SuKiens { get; set; } = new List<SuKien>();
}
