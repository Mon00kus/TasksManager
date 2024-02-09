using TasksManager.Domain.Entities;

namespace TasksManager.Application.Interfaces
{
    public interface ITasksManagementRepository
    {
        Task AddAsync(TaskManagement taskManagement);
        Task<List<TaskManagement>> GetAllAsync();
        Task<TaskManagement?> GetByIdAsync(int id);
        Task UpdateAsync(TaskManagement taskManagement);
        Task DeleteAsync(int id);
    }
}
