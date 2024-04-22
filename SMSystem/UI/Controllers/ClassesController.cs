using BLL;
using Microsoft.AspNetCore.Mvc;
using Domin.Models;
using Domin.ViewModels;
using Domin.ViewModels;

namespace UI.Controllers
{
    public class ClassesController : Controller
    {
        private readonly ClassesLogic _Logic;
        public ClassesController(ClassesLogic ClassesLogic)
        {
            _Logic = ClassesLogic;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var ClassesList = _Logic.GetAll();
            return View(ClassesList);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClassCreateVM Classes)
        {
            var respond = _Logic.Create(Classes);
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var Classes = _Logic.Find(Id);
            return View(Classes);
        }

        [HttpPost]
        public IActionResult Edit(ClassUpdateVM Classes,int Id)
        {
            _Logic.Update(Classes, Id);
            return RedirectToAction("Index", "Classes");
            
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            _Logic.Delete(Id);
            return RedirectToAction("Index", "Classes");
        }


        [HttpPost]
        public IActionResult Find(int id)
        {
            var Classes = _Logic.Find(id);
            return View(Classes);
        }


    }
}
