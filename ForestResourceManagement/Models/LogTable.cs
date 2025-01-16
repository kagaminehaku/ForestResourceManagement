using System;
using System.Collections.Generic;

namespace ForestResourceManagement.Models;

public partial class LogTable
{
    public Guid LogId { get; set; }

    public int LogIndex { get; set; }

    public string LogType { get; set; } = null!;

    public string? LogEvent { get; set; }
}
