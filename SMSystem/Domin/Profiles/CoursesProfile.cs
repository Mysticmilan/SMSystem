using Domin.Models;
using Domin.ViewModels;
using AutoMapper;
namespace Domin.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Course, CourseVM>();


            CreateMap<CourseVM, Course>()
            .AfterMap((src, dest) => dest.Status = 1);

            //CreateMap<Classes, ClassesVM>().ReverseMap();



        }
    }
}

