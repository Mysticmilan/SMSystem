using BLL;
using Microsoft.AspNetCore.Mvc;
using Domin.Models;
using Domin.ViewModels;

namespace UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentLogic _Logic;
        public StudentController(StudentLogic studentLogic)
        {
            _Logic = studentLogic;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var studentList = _Logic.GetAll();
            return View(studentList);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentVM student)
        {
            _Logic.Create(student);
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var student = _Logic.Find(Id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(StudentVM student, int Id)
        {
            _Logic.Update(student, Id);
            return RedirectToAction("Index", "Student");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var message = _Logic.Delete(Id);
            return RedirectToAction("Index", "Student");
        }


        [HttpPost]
        public IActionResult Find(int id)
        {
            var student = _Logic.Find(id);
            return View(student);
        }


    }
}
