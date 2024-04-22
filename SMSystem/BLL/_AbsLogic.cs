using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;

namespace BLL
{
    public abstract class _AbsLogic
    {
        private readonly  _AbsRepository _repo;
        protected _AbsLogic(_AbsRepository repo)
        {
            _repo = repo;
        }

    }
}
