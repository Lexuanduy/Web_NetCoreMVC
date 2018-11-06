using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T1708E.Models
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
        public string SubjectId { get; set; }
        public string StudentRollNumber { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
