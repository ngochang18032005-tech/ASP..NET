using Microsoft.EntityFrameworkCore;
using VANTHINGOCHANG_2123110352.Models;

namespace VANTHINGOCHANG_2123110352.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor nhận options từ Program.cs
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<Overtime> Overtimes { get; set; }
        public DbSet<PayrollDetail> PayrollDetails { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
    }
}