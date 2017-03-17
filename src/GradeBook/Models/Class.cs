using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class Class
    {
        public int Id { get; set; }

        public string Subject { get; set; }        
        public string TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public ApplicationUser Teacher { get; set; }
        public IList<Assignment> Assignment { get; set; }

        public ICollection<StudentClass> StudentClass { get; set; }
    }
}
