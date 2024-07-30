using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
