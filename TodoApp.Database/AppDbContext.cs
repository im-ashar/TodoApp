using Microsoft.EntityFrameworkCore;
using TodoApp.Shared;

namespace TodoApp.Database
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatabasePath.Path);
        }
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}