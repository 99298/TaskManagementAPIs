namespace TaskManagement.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Task>> GetTasksAsync();
        Task<Task> GetTaskByIdAsync(int id);
        Task AddTaskAsync(Task task);
        Task UpdateTaskAsync(Task task);
        Task DeleteTaskAsync(int id);
    }
}
