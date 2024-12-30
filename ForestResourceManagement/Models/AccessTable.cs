using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class AccessTable
{
    public int AcessId { get; set; }

    public string AccessName { get; set; } = null!;

    public string AccessInfo { get; set; } = null!;
}
