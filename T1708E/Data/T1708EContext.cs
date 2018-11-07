using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using T1708E.Models;

namespace T1708E.Models
{
    public class T1708EContext : DbContext
    {
        public T1708EContext (DbContextOptions<T1708EContext> options)
            : base(options)
        {
        }
        public DbSet<T1708E.Models.Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    RollNumber = "D00469",
                    FirstName = "Duy",
                    LastName = "Le",
                    Email = "admin@gmail.com"
                },
                new Student()
                {
                    RollNumber = "D00529",
                    FirstName = "Phuoc",
                    LastName = "Nguyen",
                    Email = "phuocding@gmail.com"
                },
                new Student()
                {
                    RollNumber = "D00553",
                    FirstName = "Nhat",
                    LastName = "Nguyen",
                    Email = "Vannhat@gmail.com"
                }
            );
            modelBuilder.Entity<Mark>().HasData(
                new Mark()
                {
                    Id = 1,
                    SubjectName = "Java Core",
                    StudentRollNumber = "D00469",
                    SubjectMark = 10
                },
                new Mark()
                {
                    Id = 2,
                    SubjectName = "C#",
                    StudentRollNumber = "D00529",
                    SubjectMark = 7
                },
                new Mark()
                {
                    Id = 3,
                    SubjectName = "PHP",
                    StudentRollNumber = "D00553",
                    SubjectMark = 8
                }
            );
        }
        public DbSet<T1708E.Models.Subject> Subject { get; set; }

        public DbSet<T1708E.Models.Mark> Mark { get; set; }
        
    }
}
