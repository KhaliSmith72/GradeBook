using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GradeBook.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
         
        public string GradeLevel { get; set; }

        public IList<StudentClass> StudentClass { get; set; }
        public IList<StudentClub> StudentClub { get; set; }
        public IList<Assignment> Assignment { get; set; }    
        public bool AdminRegister { get; set; }

        

    }
}
