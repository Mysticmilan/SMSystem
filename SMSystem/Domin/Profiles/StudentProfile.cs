using Domin.Models;
using Domin.ViewModels;
using AutoMapper;
namespace Domin.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentVM>();
            CreateMap<StudentVM, Student>();

        }
    }
}

