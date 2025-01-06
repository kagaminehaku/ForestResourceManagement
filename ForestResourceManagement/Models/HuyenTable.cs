using System;
using System.Collections.Generic;

namespace ForestResourceManagement.Models;

public partial class HuyenTable
{
    public int HuyenId { get; set; }

    public string TenHuyen { get; set; } = null!;

    public string? Info { get; set; }

    public virtual ICollection<XaTable> XaTables { get; set; } = new List<XaTable>();
}
