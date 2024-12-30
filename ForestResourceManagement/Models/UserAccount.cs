using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class UserAccount
{
    public Guid Uid { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Info { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsForgotPassword { get; set; }

    public Guid? RoleGroupId { get; set; }

    public virtual RoleGroupTable? RoleGroup { get; set; }
}
