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
    public class EfCorporationEmployeeDal : EfEntityRepositoryBase<CorporationEmployee, DatabaseContext>, ICorporationEmployeeDal
    {
        public CorporationEmployee GetWithDetails(Expression<Func<CorporationEmployee, bool>> filter)
        {
            using (var context = new DatabaseContext())
            {
                var result = context.CorporationEmployees
                    .Include("Corporation")
                    .Include("Employee")           
                    .Where(filter)
                    .FirstOrDefault();

                return result;
            }


        }

        public List<CorporationEmployee> GetListWithDetails(Expression<Func<CorporationEmployee, bool>> filter = null)
        {
            using (var context = new DatabaseContext())
            {
                if (filter != null)
                {
                    var result = context.CorporationEmployees
                    .Include("Corporation")
                    .Include("Employee")
                    .Where(filter)
                    .ToList();
                    return result;
                }
                else
                {
                    var result = context.CorporationEmployees
                    .Include("Corporation")
                    .Include("Employee")
                    .ToList();
                    return result;
                }
            }
        }

    }
}
