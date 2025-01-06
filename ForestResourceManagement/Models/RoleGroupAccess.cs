using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class RoleGroupAccess
{
    public Guid RoleGroupAccessId { get; set; }

    public Guid RoleGroupId { get; set; }

    public int AccessId { get; set; }

    public virtual AccessTable Access { get; set; } = null!;
}
