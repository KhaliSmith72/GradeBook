using GradeBook.Infrastructure;
using GradeBook.Models;
using GradeBook.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Services
{
    public class InstructorService
    {

        private UserRepository _uRepo;
        private InstructorRepository _gradeRepo;

        public InstructorService(UserRepository ur, InstructorRepository gr)
        {
            _uRepo = ur;
            _gradeRepo = gr;
        }
        public IEnumerable<StudentClassDTO> AdminViewUsers()
        {
            return (from u in _uRepo.AdminViewUsers()
                    select new StudentClassDTO()
                    {
                       FirstName = u.Student.FirstName,
                       LastName = u.Student.LastName,
                       Subject = u.Subject.Subject,
                       Gr

                        




                        

                         = (from b in u.StudentClass
                                   select new StudentClassDTO()
                                   {
                                       StudentId = u.
                                   }).ToList()
                    }).ToList();
        }
        public UserDTO GetClassesForInstructor(string LastName)
        {
            return (from s in _uRepo.GetLastName(LastName)
                    select new UserDTO()
                    {
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        GradeLevel = s.GradeLevel,
                       

                        Classes = (from w in s.StudentClass
                                   select new ClassDTO()
                                   {
                                       Id = w.Id,
                                       Grade = w.Grade,
                                       GradeLevel = w.GradeLevel,
                                       Subject = w.Subject
                                   }).ToList()
                    }).FirstOrDefault();
        }
        public ClassDTO FindById(int ClassId)
        {
            return (from e in _gradeRepo.GetClassById(ClassId)
                    select new ClassDTO
                    {
                        Id = e.Id,
                        Subject = e.Subject
                    }).FirstOrDefault();
        }
        public void EditGrade(ClassDTO Class, int ClassId)
        {
            Class dbClass = _gradeRepo.GetClassById(ClassId).FirstOrDefault();

            dbClass.Grade = Class.Grade;
            _gradeRepo.EditGrade();
        }



        public void RemoveClass(ClassDTO Class, int ClassId)
        {
            _gradeRepo.RemoveClass(_gradeRepo.GetClassById(ClassId).First());
        }
        public void RemoveUser(UserDTO User, string LastName)
        {
            _gradeRepo.RemoveUser(_gradeRepo.GetStudentByLastName(LastName).First());
        }

    }
}
