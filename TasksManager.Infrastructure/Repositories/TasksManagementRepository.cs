using Microsoft.EntityFrameworkCore;
using TasksManager.Application.Interfaces;
using TasksManager.Domain.Entities;
using TasksManager.Infrastructure.Context;

namespace TasksManager.Infrastructure.Repositories
{
    public class TasksManagementRepository : ITasksManagementRepository
    {
        private readonly TasksManagerDbContext Context;
        public TasksManagementRepository(IDbContextFactory<TasksManagerDbContext> factory)
        {
            Context = factory.CreateDbContext();
        }
        public async Task AddAsync(TaskManagement taskManagement)
        {
            await Context.TaskManagements.AddAsync(taskManagement);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var taskManagement = await GetByIdAsync(id);
            if (taskManagement is not null)
            {
                Context.TaskManagements.Remove(taskManagement);
                await Context.SaveChangesAsync();
            }
        }

        public async Task<List<TaskManagement>> GetAllAsync()
        {
            var listsItems = await Context.TaskManagements.ToListAsync();
            return listsItems;
        }

        public async Task<TaskManagement?> GetByIdAsync(int id)
        {
            var listItem = await Context.TaskManagements.FirstOrDefaultAsync(e => e.Id == id);
            return listItem;
        }

        public async Task UpdateAsync(TaskManagement taskManagement)
        {
            Context.Entry(taskManagement).State = EntityState.Modified;
            await Context.SaveChangesAsync();
        }
    }
}
