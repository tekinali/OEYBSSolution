using OEYBS.Core.DataAccess.EntityFramework;
using OEYBS.DataAccess.Abstract;
using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.DataAccess.Concrete.EntityFramework
{
    public class EfCorporationSchoolManagerDal : EfEntityRepositoryBase<CorporationSchoolManager, DatabaseContext>, ICorporationSchoolManagerDal
    {
        public CorporationSchoolManager GetWithDetails(Expression<Func<CorporationSchoolManager, bool>> filter)
        {
            using (var context = new DatabaseContext())
            {
                var result = context.CorporationSchoolManagers
                    .Include("Corporation")
                    .Include("SchoolManager")
                    .Where(filter)
                    .FirstOrDefault();

                return result;
            }


        }

        public List<CorporationSchoolManager> GetListWithDetails(Expression<Func<CorporationSchoolManager, bool>> filter = null)
        {
            using (var context = new DatabaseContext())
            {
                if (filter != null)
                {
                    var result = context.CorporationSchoolManagers
                    .Include("Corporation")
                    .Include("SchoolManager")
                    .Where(filter)
                    .ToList();
                    return result;
                }
                else
                {
                    var result = context.CorporationSchoolManagers
                    .Include("Corporation")
                    .Include("SchoolManager")
                    .ToList();
                    return result;
                }
            }
        }

    }
}
