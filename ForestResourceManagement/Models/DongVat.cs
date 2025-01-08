using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class DongVat
{
    public int DongVatId { get; set; }

    public string TenDongVat { get; set; } = null!;

    public string? ThongTinDongVat { get; set; }

    public int DanhMucDvid { get; set; }
}
