using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Abstract
{
    public interface ICorporationTeacherService
    {
        List<CorporationTeacher> GetAll();
        List<CorporationTeacher> List(Expression<Func<CorporationTeacher, bool>> filter);
        CorporationTeacher Find(Expression<Func<CorporationTeacher, bool>> filter);
        CorporationTeacher Add(CorporationTeacher entity);
        void Delete(CorporationTeacher entity);

        List<CorporationTeacher> GetAllWithDetails();
        List<CorporationTeacher> ListWithDetails(Expression<Func<CorporationTeacher, bool>> filter);
        CorporationTeacher FindWithDetails(Expression<Func<CorporationTeacher, bool>> filter);
    }
}
