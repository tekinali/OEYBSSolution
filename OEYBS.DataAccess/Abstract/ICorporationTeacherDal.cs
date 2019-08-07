using OEYBS.Core.DataAccess;
using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.DataAccess.Abstract
{
    public interface ICorporationTeacherDal : IEntityRepository<CorporationTeacher>
    {
        CorporationTeacher GetWithDetails(Expression<Func<CorporationTeacher, bool>> filter);
        List<CorporationTeacher> GetListWithDetails(Expression<Func<CorporationTeacher, bool>> filter = null);
    }
}
