using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ForestResourceManagement.Controllers
{
    public class ForestControllerUserAccounts
    {
        private readonly FrdbContext _context;

        public ForestControllerUserAccounts(FrdbContext context)
        {
            _context = context;
        }

        // Helper to log actions
        private void LogAction(string username, string action)
        {
            _context.LogTables.Add(new LogTable
            {
                LogId = Guid.NewGuid(),
                LogIndex = _context.LogTables.Count() + 1,
                LogType = action,
                LogEvent = $"{DateTime.UtcNow}: {action} by {username}"
            });
            _context.SaveChanges();
        }

        // Access Management
        public IEnumerable<AccessTable> GetAccessList(string username)
        {
            LogAction(username, "Retrieve access list");
            return _context.AccessTables.ToList();
        }

        // Role Group Management
        public IEnumerable<RoleGroupTable> GetRoleGroups(string username)
        {
            LogAction(username, "Retrieve role groups");
            return _context.RoleGroupTables.ToList();
        }

        public RoleGroupTable? GetRoleGroupDetails(Guid roleGroupId, string username)
        {
            LogAction(username, "View role group details");
            return _context.RoleGroupTables.FirstOrDefault(rg => rg.RoleGroupId == roleGroupId);
        }

        public void AddRoleGroup(RoleGroupTable newGroup, string username)
        {
            _context.RoleGroupTables.Add(newGroup);
            _context.SaveChanges();
            LogAction(username, "Add role group");
        }

        public void UpdateRoleGroup(RoleGroupTable updatedGroup, string username)
        {
            _context.RoleGroupTables.Update(updatedGroup);
            _context.SaveChanges();
            LogAction(username, "Update role group");
        }

        public void DeleteRoleGroup(Guid roleGroupId, string username)
        {
            var group = _context.RoleGroupTables.FirstOrDefault(rg => rg.RoleGroupId == roleGroupId);
            if (group != null)
            {
                _context.RoleGroupTables.Remove(group);
                _context.SaveChanges();
                LogAction(username, "Delete role group");
            }
        }

        // User Account Management
        public UserAccount? Login(string username, string password)
        {
            var user = _context.UserAccounts.FirstOrDefault(u => u.Username == username && u.Password == password);
            LogAction(username, "User login attempt");
            return user;
        }

        public UserAccount? GetUserDetails(Guid userId, string username)
        {
            LogAction(username, "Retrieve user details");
            return _context.UserAccounts.FirstOrDefault(u => u.Uid == userId);
        }

        public void UpdateUserDetails(UserAccount updatedUser, string username)
        {
            _context.UserAccounts.Update(updatedUser);
            _context.SaveChanges();
            LogAction(username, "Update user details");
        }

        public void ReportForgotPassword(Guid userId, string username)
        {
            var user = _context.UserAccounts.FirstOrDefault(u => u.Uid == userId);
            if (user != null)
            {
                user.IsForgotPassword = true;
                _context.SaveChanges();
                LogAction(username, "Report forgot password");
            }
        }

        public void BanUser(Guid userId, string username)
        {
            var user = _context.UserAccounts.FirstOrDefault(u => u.Uid == userId);
            if (user != null)
            {
                user.IsActive = false;
                _context.SaveChanges();
                LogAction(username, "Ban user");
            }
        }

        public void AssignRoleGroup(Guid userId, Guid roleGroupId, string username)
        {
            var user = _context.UserAccounts.FirstOrDefault(u => u.Uid == userId);
            if (user != null)
            {
                user.RoleGroupId = roleGroupId;
                _context.SaveChanges();
                LogAction(username, "Assign role group to user");
            }
        }

        public IEnumerable<AccessTable> GetAccessByRoleGroup(Guid roleGroupId, string username)
        {
            LogAction(username, "Retrieve access by role group");
            return _context.RoleGroupAccesses
                .Where(rga => rga.RoleGroupId == roleGroupId)
                .Select(rga => rga.Access)
                .ToList();
        }

        // Reporting Functions
        public IEnumerable<UserAccount> ReportUserStatistics(string username)
        {
            LogAction(username, "Generate user statistics report");
            return _context.UserAccounts.ToList();
        }

        public IEnumerable<LogTable> ReportAccessHistory(string username)
        {
            LogAction(username, "Generate access history report");
            return _context.LogTables.Where(log => log.LogType.Contains("Access")).ToList();
        }

        public IEnumerable<LogTable> ReportSystemActivity(string username)
        {
            LogAction(username, "Generate system activity report");
            return _context.LogTables.ToList();
        }

        public object ReportSummary(string username)
        {
            LogAction(username, "Generate summary report");
            return new
            {
                TotalUsers = _context.UserAccounts.Count(),
                TotalRoleGroups = _context.RoleGroupTables.Count(),
                TotalAccessLogs = _context.LogTables.Count()
            };
        }
    }
}
