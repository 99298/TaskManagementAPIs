﻿using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
