using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Abstract
{
    public interface ICorporationSchoolManagerService
    {
        List<CorporationSchoolManager> GetAll();
        List<CorporationSchoolManager> List(Expression<Func<CorporationSchoolManager, bool>> filter);
        CorporationSchoolManager Find(Expression<Func<CorporationSchoolManager, bool>> filter);
        CorporationSchoolManager Add(CorporationSchoolManager entity);
        void Delete(CorporationSchoolManager entity);

        List<CorporationSchoolManager> GetAllWithDetails();
        List<CorporationSchoolManager> ListWithDetails(Expression<Func<CorporationSchoolManager, bool>> filter);
        CorporationSchoolManager FindWithDetails(Expression<Func<CorporationSchoolManager, bool>> filter);
    }
}
