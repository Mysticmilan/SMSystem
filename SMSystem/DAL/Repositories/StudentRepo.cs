using Domin.Data;
using Domin.Models;
using Domin.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class StudentRepo : _AbsRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public StudentRepo(ApplicationDBContext context) : base(context)
        {
            _dbContext = context;
        }


        public object findSelectedList()
        {
            var toReturn = _dbContext.Students.Select(
                student => new StudentVM()
                {
                    Name = student.Name,
                    Phone = student.Phone,
                    //Courses = student.Course.Select(c => new CourseVM()
                    //{
                    //    Name = student.Course.Name
                    //})

                }).ToList();
            return toReturn;
        }
    }
}
