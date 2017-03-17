using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Models
{
    public class StudentClub
    {
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public ApplicationUser Student { get; set; }      
        public int ClubId { get; set; }
        [ForeignKey("ClubId")]
        public Clubs ClubName { get; set; }

    }
}
