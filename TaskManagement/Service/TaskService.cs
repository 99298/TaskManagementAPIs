using TaskManagement.Interfaces;

namespace TaskManagement.Service
{
    public class TaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<Task>> GetTasksAsync()
        {
            return await _taskRepository.GetTasksAsync();
        }

        public async Task<Task> GetTaskByIdAsync(int id)
        {
            return await _taskRepository.GetTaskByIdAsync(id);
        }

        public async Task AddTaskAsync(Task task)
        {
            await _taskRepository.AddTaskAsync(task);
        }

        public async Task UpdateTaskAsync(Task task)
        {
            await _taskRepository.UpdateTaskAsync(task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepository.DeleteTaskAsync(id);
        }
    }
}