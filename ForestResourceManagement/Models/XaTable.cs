using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class XaTable
{
    public int XaId { get; set; }

    public string TenXa { get; set; } = null!;

    public string? Info { get; set; }

    public int HuyenId { get; set; }

    public virtual HuyenTable Huyen { get; set; } = null!;
}
