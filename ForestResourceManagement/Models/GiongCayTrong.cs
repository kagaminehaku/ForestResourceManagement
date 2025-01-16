using System;
using System.Collections.Generic;

namespace ForestResourceManagement.Models;

public partial class GiongCayTrong
{
    public int GiongCayTrongId { get; set; }

    public string TenGiongCayTrong { get; set; } = null!;

    public string? ThongTin { get; set; }

    public int DanhMucGiongCayTrongId { get; set; }
}
