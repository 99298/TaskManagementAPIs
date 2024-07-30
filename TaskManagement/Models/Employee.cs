using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int ManagerId { get; set; }

        public Manager Manager { get; set; }

        public ICollection<TaskList> Tasks { get; set; }
    }
}
