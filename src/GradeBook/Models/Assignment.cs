using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public int ClassID { get; set; }
        [ForeignKey("ClassID")]
        public Class Course { get; set; }
        public string ClassWork { get; set; }
        public int AssignmentGrade { get; set; }
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public ApplicationUser Student { get; set; }
    }
}
