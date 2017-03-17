using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class StudentClass
    {
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public ApplicationUser Student { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Class Subject { get; set; }
    }
}
