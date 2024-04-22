using DAL.Repositories;
using Domin.Data;
using Domin.Models;
using Domin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class StudentLogic : _AbsLogic
    {
        private readonly StudentRepo _repo;
        public StudentLogic(StudentRepo repo) : base(repo)
        {
            _repo = repo;
        }

        public string Create(StudentVM model)
        {
            Student student = new Student();
            student.Name = model.Name;
            student.Email = model.Email;
            student.Phone = model.Phone;
            student.CourseId = 1; //Leter To Change
            student.Status = 1;

            var respond = _repo.Create(student);
            return respond.ToString();
        }

        public string Update(StudentVM model, int Id)
        {
            if (model != null)
            {
                Student studentToUpdate = _repo.GetById<Student>(Id);
                if (studentToUpdate != null)
                {
                    studentToUpdate.Name = model.Name;
                    studentToUpdate.Email = model.Email;
                    studentToUpdate.Phone = model.Phone;
                    studentToUpdate.CourseId = 1;
                    return _repo.Update<Student>(studentToUpdate, model.Id);
                }
                else
                {
                    return "Student Not Found";
                }
            }

            return "Student to update is null";
        }

        public IEnumerable<StudentVM> GetAll()
        {

            //var studentlist = _repo.GetAll<Student>();

            //IList<StudentVM> students = new List<StudentVM>();
            //foreach (var student in studentlist)
            //{
            //    var toReturn = new StudentVM()
            //    {
            //        Id = student.Id,
            //        Name = student.Name
            //    };
            //    students.Add(toReturn);
            //}

            var students = _repo.GetAll<Student>().Select(student => new StudentVM
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email,
                Phone = student.Phone
            }).ToList();
            return students;
        }

        public object Find(int Id)
        {
            var model = _repo.GetById<Student>(Id);
            StudentVM toReturn = new StudentVM()
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone
            };
            return toReturn;
        }

        public string Delete(int id)
        {
            var response = _repo.Delete<Student>(id);
            return response.ToString();
        }

    }
}
