using AutoMapper;
using DAL.Repositories;
using Domin.Data;
using Domin.Models;
using Domin.ViewModels;
using Domin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class ClassesLogic : _AbsLogic
    {
        private readonly IMapper _mapper;
        private readonly ClassesRepo _repo;
        public ClassesLogic(ClassesRepo repo, IMapper mapper) : base(repo)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public string Create(ClassCreateVM model)
        {
            //Classes classes = new Classes();
            //Classes.Name = model.Name;
            //Classes.Status = 1;

            var classes = _mapper.Map<Classes>(model);

            var respond = _repo.Create(classes);
            return respond.ToString();
        }

        public string Update(ClassUpdateVM model, int Id)
        {
            if (model != null)
            {
                Classes ClassesToUpdate = _repo.GetById<Classes>(Id);
                if (ClassesToUpdate != null)
                {
                    ClassesToUpdate.Name = model.Name;
                    return _repo.Update<Classes>(ClassesToUpdate, model.Id);
                }
                else
                {
                    return "Classes Not Found";
                }
            }

            return "Classes to update is null";

        }

        public IEnumerable<ClassGetVM> GetAll()
        {

           var classlist = _repo.GetAll<Classes>();

            //IList<ClassesVM> classes = new List<ClassesVM>();
            //foreach (var Classes in Classeslist)
            //{
            //    var toReturn = new ClassesVM()
            //    {
            //        Id = Classes.Id,
            //        Name = Classes.Name
            //    };
            //    Classess.Add(toReturn);
            //}

            var classes = _mapper.Map<IEnumerable<ClassGetVM>>(classlist);

            return classes;
        }

        public object Find(int Id)
        {
            var model = _repo.GetById<Classes>(Id);
            //ClassesVM toReturn = new ClassesVM()
            //{
            //    Id = model.Id,
            //    Name = model.Name,
            //};

            var toReturn = _mapper.Map<ClassGetVM>(model);
            return toReturn;
        }

        public string Delete(int id)
        {
            var response = _repo.Delete<Classes>(id);
            return response.ToString();
        }
    }
}
