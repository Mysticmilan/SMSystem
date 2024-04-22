using AutoMapper;
using Domin.Models;
using Domin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Profiles
{
    public class TestProfile: Profile
    {
        public TestProfile()
        {
            CreateMap<Student, TestVM>()
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name));



        }
    }
}
