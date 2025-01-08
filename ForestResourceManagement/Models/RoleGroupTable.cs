using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class RoleGroupTable
{
    public Guid RoleGroupId { get; set; }

    public string RoleGroupName { get; set; } = null!;

    public virtual ICollection<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
}
