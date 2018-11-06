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
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<T1708E.Models.Subject> Subject { get; set; }

        public DbSet<T1708E.Models.Mark> Mark { get; set; }
    }
}
