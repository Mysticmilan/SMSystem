using Domin.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ClassesRepo : _AbsRepository
    {
        public ClassesRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
