using Microsoft.EntityFrameworkCore;
using TaskManagement.Models;

namespace TaskManagement.Database
{
    public class TaskManagementContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public TaskManagementContext(DbContextOptions<TaskManagementContext> options) : base(options) { }
    }
}
