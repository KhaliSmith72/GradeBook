using GradeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Services.Models
{
    public class ClubDTO
    {
        public int Id { get; set; }
        public string ClubName { get; set; }
        public IList<StudentClub> StudentClub { get; set; }
    }
}
