using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class CoSoLuuTru
{
    public int CoSoLuuTruId { get; set; }

    public string TenCoSoLuuTru { get; set; } = null!;

    public string? ThongTin { get; set; }

    public int DanhMucCoSoLuuTruId { get; set; }

    public virtual DanhMucCoSoLuuTru DanhMucCoSoLuuTru { get; set; } = null!;
}
