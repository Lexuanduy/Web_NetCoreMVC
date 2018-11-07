using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace T1708E.Models
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        public int SubjectMark { get; set; }
        public string SubjectName { get; set; }
        public string StudentRollNumber { get; set; }
        [ForeignKey("StudentRollNumber")]
        public Student Student { get; set; }
    }
}
