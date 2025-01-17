using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class DanhMucGiongCay
{
    public int DanhMucGiongCayId { get; set; }

    public string TenDanhMuc { get; set; } = null!;

    public string? ThongTin { get; set; }

    public virtual ICollection<GiongCayTrong> GiongCayTrongs { get; set; } = new List<GiongCayTrong>();
}
