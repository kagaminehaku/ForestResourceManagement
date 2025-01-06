using System;
using System.Collections.Generic;

namespace ForestResourceManagement.Models;

public partial class RoleGroupTable
{
    public Guid RoleGroupId { get; set; }

    public string RoleGroupName { get; set; } = null!;

    public int AccessId { get; set; }
}
