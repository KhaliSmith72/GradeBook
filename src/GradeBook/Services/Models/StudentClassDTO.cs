using GradeBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Services.Models
{
    public class StudentClassDTO
    {
        public string StudentId { get; set; }
       
        public UserDTO Student { get; set; }
        public int SubjectId { get; set; }
       
        public IList<ClassDTO> Subject { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string GradeLevel { get; set; }
        
        
    }
}
