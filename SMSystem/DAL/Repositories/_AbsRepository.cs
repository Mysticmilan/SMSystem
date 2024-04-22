using Domin.Data;
using Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.Repositories
{
    public abstract class _AbsRepository
    {
        private readonly ApplicationDBContext _context;

        protected _AbsRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public string Create<T>(T _object) where T : class
        {
            try
            {
                _context.Set<T>().Add(_object);
                _context.SaveChanges();
                return "Student Data Saved Successfully";
            }
            catch (Exception ex)
            {
                return (ex.Message + "\n An Error occured while connecting to database");
            }


        }


        public string Delete<T>(int id) where T : _AbsClass
        {
            try
            {
                T _object = _context.Set<T>().Find(id);
                if(_object != null) {
                    _object.Status = 0;
                    _context.Set<T>().Update(_object);
                    _context.SaveChanges();
                    return "Data Deleted Successfully";
                }
                else
                {
                    return "Data to delete not found";
                }
            }
            catch (Exception ex)
            {
                return (ex.Message + "\n An Error Occured While Deleting Data");
            }

        }

        public string Update<T>(T _object, int Id) where T : class
        {
            try
            {
                _context.Set<T>().Update(_object);
                _context.SaveChanges();
                return "Data Updated Successfully!";
            }
            catch (Exception ex)
            {
                return (ex.Message + "\n An Error Occured While Updating Data");
            }

        }
        public IEnumerable<T> GetAll<T>() where T : _AbsClass
        {
            return _context.Set<T>().Where(x => x.Status == 1).ToList();
        }
        public T GetById<T>(int Id) where T : class
        {
            return _context.Set<T>().Find(Id);
        }

        


    }
}
