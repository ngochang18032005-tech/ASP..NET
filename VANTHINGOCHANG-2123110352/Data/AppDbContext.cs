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
    }
}