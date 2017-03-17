using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GradeBook.Models;

namespace GradeBook.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Class> Class { get; set; }
        public DbSet<Clubs> Clubs { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<StudentClass> StudentClass { get; set; }
        public DbSet<StudentClub> StudentClub { get; set; }
       
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<StudentClass>().HasKey(x => new { x.StudentId, x.SubjectId });
            builder.Entity<StudentClub>().HasKey(x => new { x.StudentId, x.ClubId });
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

        }
    }
}
