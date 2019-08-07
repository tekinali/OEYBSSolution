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
    public class EfCorporationTeacherDal : EfEntityRepositoryBase<CorporationTeacher, DatabaseContext>, ICorporationTeacherDal
    {
        public CorporationTeacher GetWithDetails(Expression<Func<CorporationTeacher, bool>> filter)
        {
            using (var context = new DatabaseContext())
            {
                var result = context.CorporationTeachers
                    .Include("Corporation")
                    .Include("Teacher")
                    .Where(filter)
                    .FirstOrDefault();

                return result;
            }


        }

        public List<CorporationTeacher> GetListWithDetails(Expression<Func<CorporationTeacher, bool>> filter = null)
        {
            using (var context = new DatabaseContext())
            {
                if (filter != null)
                {
                    var result = context.CorporationTeachers
                    .Include("Corporation")
                    .Include("Teacher")
                    .Where(filter)
                    .ToList();
                    return result;
                }
                else
                {
                    var result = context.CorporationTeachers
                    .Include("Corporation")
                    .Include("Teacher")
                    .ToList();
                    return result;
                }
            }
        }

    }
}
