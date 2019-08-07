using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Abstract
{
    public interface ICorporationEmployeeService
    {
        List<CorporationEmployee> GetAll();
        List<CorporationEmployee> List(Expression<Func<CorporationEmployee, bool>> filter);
        CorporationEmployee Find(Expression<Func<CorporationEmployee, bool>> filter);
        CorporationEmployee Add(CorporationEmployee entity);
        void Delete(CorporationEmployee entity);

        List<CorporationEmployee> GetAllWithDetails();
        List<CorporationEmployee> ListWithDetails(Expression<Func<CorporationEmployee, bool>> filter);
        CorporationEmployee FindWithDetails(Expression<Func<CorporationEmployee, bool>> filter);
    }
}
