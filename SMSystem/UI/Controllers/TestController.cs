using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domin.Data;
using Domin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UI.Controllers
{
    public class TestController: Controller
    {

        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;

        public TestController(ApplicationDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public IActionResult Index() 
        {
           var studentList =  _dbContext.Students
            .ProjectTo<TestVM>(_mapper.ConfigurationProvider)
            .ToList();
            return View(studentList);
        }
    }
}
