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
    public interface ICorporationEmployeeDal : IEntityRepository<CorporationEmployee>
    {
        CorporationEmployee GetWithDetails(Expression<Func<CorporationEmployee, bool>> filter);
        List<CorporationEmployee> GetListWithDetails(Expression<Func<CorporationEmployee, bool>> filter = null);
    }
}
