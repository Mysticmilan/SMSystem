using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domin.Data;
using Domin.Models;
using Domin.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CourseRepo : _AbsRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;
        public CourseRepo(ApplicationDBContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;

        }

        public IEnumerable<CourseVM> GetAllCourse()
        {
            var temp = _context.Courses.ToList();
            var temp2 = _mapper.Map<CourseVM>(temp);
            return _context.Courses.ProjectTo<CourseVM>(_mapper.ConfigurationProvider)
            .ToList(); ;
        }
    }
}
