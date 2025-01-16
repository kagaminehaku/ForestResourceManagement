using System;
using System.Collections.Generic;

namespace ForestResourceManagement.Models;

public partial class DanhMucDongVat
{
    public int DanhMucDvid { get; set; }

    public string TenDanhMucDv { get; set; } = null!;

    public string ThongTin { get; set; } = null!;
}
