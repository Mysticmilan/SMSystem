using AutoMapper;
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

    public class CourseLogic : _AbsLogic
    {
        private readonly CourseRepo _repo;
        private readonly IMapper _mapper;
        public CourseLogic(CourseRepo repo, IMapper mapper) : base(repo)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public string Create(CourseVM model)
        {
            Course course = new Course();
            course.Name = model.Name;
            course.Status = 1;

            var respond = _repo.Create(course);
            return respond.ToString();
        }

        public string Update(CourseVM model, int Id)
        {
            if(model != null)
            {
               Course courseToUpdate = _repo.GetById<Course>(Id);
               if(courseToUpdate != null)
                {
                    courseToUpdate.Name = model.Name;
                    return _repo.Update<Course>(courseToUpdate, model.Id);
                }
               else
                {
                    return "Course Not Found";
                }
            }

            return "Course to update is null";

        }

        public IEnumerable<CourseVM> GetAll()
        {

            //var allCourse = _repo.GetAll<Course>();
            //IList<CourseVM> courseList = new List<CourseVM>();
            ////foreach (var Course in allCourse)
            //{
            //    var model = new CourseVM()
            //    {
            //        Id = Course.Id,
            //        Name = Course.Name
            //    };
            //    courseList.Add(model);
            //}

            //var courseList = _mapper.Map<IEnumerable<CourseVM>>(allCourse);
            return _repo.GetAllCourse();
        }

        public object Find(int Id)
        {
            var model = _repo.GetById<Course>(Id);
            //CourseVM courseVM = new CourseVM()
            //{
            //    Id = model.Id,
            //    Name = model.Name,
            //};

            var courseVM = _mapper.Map<CourseVM>(model);
            return courseVM;
        }

        public string Delete(int id)
        {
            var response = _repo.Delete<Course>(id);
            return response.ToString();
        }
    }
}
