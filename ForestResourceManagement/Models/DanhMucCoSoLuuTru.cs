using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class DanhMucCoSoLuuTru
{
    public int DanhMucCoSoLuuTruId { get; set; }

    public string TenDanhMucCoSoLuuTru { get; set; } = null!;

    public string? ThongTin { get; set; }

    public virtual ICollection<CoSoLuuTru> CoSoLuuTrus { get; set; } = new List<CoSoLuuTru>();
}
