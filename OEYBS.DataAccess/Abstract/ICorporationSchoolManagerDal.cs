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
    public interface ICorporationSchoolManagerDal : IEntityRepository<CorporationSchoolManager>
    {
        CorporationSchoolManager GetWithDetails(Expression<Func<CorporationSchoolManager, bool>> filter);
        List<CorporationSchoolManager> GetListWithDetails(Expression<Func<CorporationSchoolManager, bool>> filter = null);
    }
}
