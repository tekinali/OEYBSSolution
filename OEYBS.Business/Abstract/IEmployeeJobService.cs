using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Abstract
{
    public interface IEmployeeJobService 
    {
        List<EmployeeJob> GetAll();
        List<EmployeeJob> List(Expression<Func<EmployeeJob, bool>> filter);
        EmployeeJob Find(Expression<Func<EmployeeJob, bool>> filter);
        EmployeeJob Add(EmployeeJob entity);
        void Delete(EmployeeJob entity);
    }
}
