using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TasksManager.Domain.Entities;

namespace TasksManager.Infrastructure.Context
{
    public class TasksManagerDbContext : DbContext
    {
        public TasksManagerDbContext(DbContextOptions<TasksManagerDbContext> options) : base(options)
        {
            
        }
        public DbSet<TaskManagement> TaskManagements { get; set; }
    }
}
