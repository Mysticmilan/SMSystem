using BLL;
using Microsoft.AspNetCore.Mvc;
using Domin.Models;
using Domin.ViewModels;

namespace UI.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseLogic _Logic;
        public CourseController(CourseLogic CourseLogic)
        {
            _Logic = CourseLogic;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var CourseList = _Logic.GetAll();
            return View(CourseList);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CourseVM Course)
        {
            var respond = _Logic.Create(Course);
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var course = _Logic.Find(Id);
            return View(course);
        }

        [HttpPost]
        public IActionResult Edit(CourseVM Course,int Id)
        {
            _Logic.Update(Course, Id);
            return RedirectToAction("Index", "Course");
            
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            _Logic.Delete(Id);
            return RedirectToAction("Index", "Course");
        }


        [HttpPost]
        public IActionResult Find(int id)
        {
            var Course = _Logic.Find(id);
            return View(Course);
        }


    }
}
