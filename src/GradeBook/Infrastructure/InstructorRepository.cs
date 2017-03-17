using GradeBook.Data;
using GradeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Infrastructure
{
    public class InstructorRepository
    {
        private ApplicationDbContext _db;
        public InstructorRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public IQueryable<Class> GetClassById(int ClassId)
        {
            return from b in _db.Class
                   where b.Id == ClassId
                   select b;
        }
        public IQueryable<ApplicationUser> GetStudentById(string UserName)
        {
            return from o in _db.Users
                   where o.UserName == UserName
                   select o;
        }

        public IQueryable<ApplicationUser> GetStudentByLastName(string LastName)
        {
            return from c in _db.Users
                   where c.LastName == LastName
                   select c;
        }

        public IQueryable<Assignment> GetAssignments(string ClassWork)
        {
            return from w in _db.Assignment
                   where w.ClassWork == ClassWork
                   select w;
        }



        public void RemoveClass(Class classes)
        {
            _db.Class.Remove(classes);
            _db.SaveChanges();
        }

        public void RemoveUser(ApplicationUser user)
        {
            _db.Users.Remove(user);
            _db.SaveChanges();
        }

        public void EditGrade()
        {
            _db.SaveChanges();
        }

        public void AddClasses(Class Class, string currentUser)
        {
            _db.Class.Add(Class);
            _db.SaveChanges();
        }

        public void RemoveAssignment(Assignment ClassWork)
        {
            _db.Assignment.Remove(ClassWork);
            _db.SaveChanges();
        }

        public void EditClassWorkGrade()
        {
            _db.SaveChanges();
        }

        public void AddAssignments(Assignment ClassWork)
        {
            _db.Assignment.Add(ClassWork);
            _db.SaveChanges();
        }
    }
}
