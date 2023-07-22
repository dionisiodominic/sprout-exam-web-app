using System;
using System.ComponentModel.DataAnnotations;

namespace Sprout.Exam.WebApp.Models
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Birthdate is required")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Tin is required")]
        public string Tin { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
