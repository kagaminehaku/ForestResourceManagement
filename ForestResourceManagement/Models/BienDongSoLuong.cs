using System;
using System.Collections.Generic;

namespace ForestResourceManagement.Models;

public partial class BienDongSoLuong
{
    public int BienDongSoLuongId { get; set; }

    public string TenBienDong { get; set; } = null!;

    public int SoLuongBienDong { get; set; }

    public string DongVat { get; set; } = null!;

    public int? DanhMucBienDongId { get; set; }

    public virtual DanhMucBienDong? DanhMucBienDong { get; set; }
}
