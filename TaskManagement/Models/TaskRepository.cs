using Microsoft.EntityFrameworkCore;
using TaskManagement.Database;
using TaskManagement.Interfaces;

namespace TaskManagement.Models
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagementContext _context;

        public TaskRepository(TaskManagementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Task>> GetTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<Task> GetTaskByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task AddTaskAsync(Task task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTaskAsync(Task task)
        {
            _context.Entry(task).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}
