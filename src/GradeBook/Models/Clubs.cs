using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class Clubs
    {
        public int Id { get; set; }
        public string ClubName { get; set; }
        public IList<StudentClub> StudentClub { get; set; }

        
    }
}
