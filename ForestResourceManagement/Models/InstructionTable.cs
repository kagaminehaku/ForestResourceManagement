using System;
using System.Collections.Generic;

namespace ForestResourceManagement.Models;

public partial class InstructionTable
{
    public int InstructionId { get; set; }

    public string InstructionName { get; set; } = null!;

    public string? InstructionContent { get; set; }
}
