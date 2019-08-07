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
    public interface ICorporationStudentDal : IEntityRepository<CorporationStudent>
    {
        CorporationStudent GetWithDetails(Expression<Func<CorporationStudent, bool>> filter);
        List<CorporationStudent> GetListWithDetails(Expression<Func<CorporationStudent, bool>> filter = null);
    }
}
