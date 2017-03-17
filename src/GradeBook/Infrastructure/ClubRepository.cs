using GradeBook.Data;
using GradeBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Infrastructure
{
    public class ClubRepository
    {
        private ApplicationDbContext _db;

        public ClubRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IQueryable<Clubs> GetClubName(string ClubName)
        {
            return from u in _db.Clubs
                   where u.ClubName == ClubName
                   select u;
        }

        public void Add(Clubs ClubId)
        {
            _db.Clubs.Add(ClubId);
            _db.SaveChanges();
        }

        public void JoinClub(StudentClub StudentId)
        {
            if ((from db in _db.StudentClub
                 where db.ClubId == StudentId.ClubId
                 && db.StudentId == StudentId.StudentId
                 select db).FirstOrDefault() == null)
                {


                _db.StudentClub.Add(StudentId);
                _db.SaveChanges();
            }
        }

        public void UpdateClub(Clubs dbClub)
        {
            _db.Clubs.Update(dbClub);
            _db.SaveChanges();
        }

        public void DeleteClub(Clubs dbClub, string user)
        {
            _db.Clubs.Remove(dbClub);
            _db.SaveChanges();
        }


    }
}
