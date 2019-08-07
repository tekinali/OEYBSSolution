using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Abstract
{
    public interface ICorporationStudentService
    {
        List<CorporationStudent> GetAll();
        List<CorporationStudent> List(Expression<Func<CorporationStudent, bool>> filter);
        CorporationStudent Find(Expression<Func<CorporationStudent, bool>> filter);
        CorporationStudent Add(CorporationStudent entity);
        void Delete(CorporationStudent entity);

        List<CorporationStudent> GetAllWithDetails();
        List<CorporationStudent> ListWithDetails(Expression<Func<CorporationStudent, bool>> filter);
        CorporationStudent FindWithDetails(Expression<Func<CorporationStudent, bool>> filter);
    }
}
