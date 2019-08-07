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
    public class EfCorporationStudentDal : EfEntityRepositoryBase<CorporationStudent, DatabaseContext>, ICorporationStudentDal
    {
        public CorporationStudent GetWithDetails(Expression<Func<CorporationStudent, bool>> filter)
        {
            using (var context = new DatabaseContext())
            {
                var result = context.CorporationStudents
                    .Include("Corporation")
                    .Include("Student")
                    .Where(filter)
                    .FirstOrDefault();

                return result;
            }


        }

        public List<CorporationStudent> GetListWithDetails(Expression<Func<CorporationStudent, bool>> filter = null)
        {
            using (var context = new DatabaseContext())
            {
                if (filter != null)
                {
                    var result = context.CorporationStudents
                    .Include("Corporation")
                    .Include("Student")
                    .Where(filter)
                    .ToList();
                    return result;
                }
                else
                {
                    var result = context.CorporationStudents
                    .Include("Corporation")
                    .Include("Student")
                    .ToList();
                    return result;
                }
            }
        }



    }
}
