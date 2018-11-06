using System;
using System.ComponentModel.DataAnnotations;

namespace T1708E.Models
{
    public class Student
    {
        [Key]
        public string RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public StudentStatus Status { get; set; }

        public Student()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Status = StudentStatus.Activated;
        }
    }

    public enum StudentStatus
    {
        Activated = 1,
        Deactivated = 0
    }
}
