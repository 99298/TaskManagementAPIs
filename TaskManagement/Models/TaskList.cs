using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class TaskList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

        public string DocumentPath { get; set; }

        public bool IsCompleted { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
