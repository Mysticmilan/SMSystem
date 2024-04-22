using Domin.Models;
using Domin.ViewModels;
using AutoMapper;
using Domin.ViewModels;
namespace Domin.Profiles
{
    public class ClassesProfile : Profile
    {
        public ClassesProfile()
        {
            CreateMap<ClassCreateVM, Classes>();
            CreateMap<ClassUpdateVM, Classes>();
            CreateMap<Classes, ClassGetVM>()
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Name));
        }
    }
}
