using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class GiongCayTrong
{
    public int GiongCayTrongId { get; set; }

    public string TenGiongCayTrong { get; set; } = null!;

    public string? ThongTin { get; set; }

    public int DanhMucGiongCayId { get; set; }

    public virtual DanhMucGiongCay DanhMucGiongCay { get; set; } = null!;
}
