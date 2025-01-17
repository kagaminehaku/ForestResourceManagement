using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class DanhMucBienDong
{
    public int DanhMucBienDongId { get; set; }

    public string TenDanhMucBienDong { get; set; } = null!;

    public string? ThongTin { get; set; }

    public virtual ICollection<BienDongSoLuong> BienDongSoLuongs { get; set; } = new List<BienDongSoLuong>();
}
