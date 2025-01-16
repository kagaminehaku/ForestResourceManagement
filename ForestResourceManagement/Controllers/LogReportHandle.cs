using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForestResourceManagement.Models;

namespace ForestResourceManagement.Controllers
{
    public class LogReportHandler
    {
        private readonly FrdbContext _context; 

        public LogReportHandler(FrdbContext context)
        {
            _context = context;
        }
        public void OnGenerateReportButtonClick()
        {
            var logs = _context.LogTables.ToList();

            var groupedLogs = logs
                .Where(log => log.LogEvent != null)
                .GroupBy(log => log.LogType)
                .Select(group => new
                {
                    LogType = group.Key,
                    Count = group.Count(),
                    Events = group.Select(log => log.LogEvent).ToList()
                })
                .ToList();

            var reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Activity History Report");
            reportBuilder.AppendLine("========================");

            foreach (var summary in groupedLogs)
            {
                reportBuilder.AppendLine($"Log Type: {summary.LogType}");
                reportBuilder.AppendLine($"Count: {summary.Count}");
                reportBuilder.AppendLine("Events:");
                foreach (var logEvent in summary.Events)
                {
                    reportBuilder.AppendLine($"  - {logEvent}");
                }
                reportBuilder.AppendLine();
            }

            MessageBox.Show(reportBuilder.ToString(), "Activity History Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
