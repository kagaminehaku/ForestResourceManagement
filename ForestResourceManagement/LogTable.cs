using System;
using System.Collections.Generic;

namespace ForestResourceManagement;

public partial class LogTable
{
    public Guid LogId { get; set; }

    public int LogIndex { get; set; }

    public string LogType { get; set; } = null!;

    public string? LogEvent { get; set; }
}
