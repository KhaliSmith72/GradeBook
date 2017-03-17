using GradeBook.Data;
using GradeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Infrastructure
{
    public class AssignmentRepository
    {
        private ApplicationDbContext _db;
        public AssignmentRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public IQueryable<Assignment> GetAssignmentForUser()
        {
            return from a in _db.Assignment
                   select a;
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
