using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace T1708E.Models
{
    public class Student
    {
        [Key]
        public string RollNumber { get; set; }
        [NotMe]
        [Required(ErrorMessage = "Vui lòng nhập tên của bạn")]
        [MaxLength(30, ErrorMessage = "Tên quá dài, lớn nhất là 30 ký tự.")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Vui lòng nhập email đúng định dạng.")]
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public StudentStatus Status { get; set; }
        public List<Mark> Marks { get; set; }
        public Student()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Status = StudentStatus.Activated;
        }
    }

    public class NotMeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            var firstName = value as String;
            if (firstName.Contains("Duy"))
            {
                return new ValidationResult("Phạm húy");
            }
            return ValidationResult.Success;
        }
    }

    public enum StudentStatus
    {
        Activated = 1,
        Deactivated = 0
    }
}
