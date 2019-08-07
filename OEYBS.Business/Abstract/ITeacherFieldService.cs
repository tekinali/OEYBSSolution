using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Abstract
{
    public interface ITeacherFieldService 
    {
        List<TeacherField> GetAll();
        List<TeacherField> List(Expression<Func<TeacherField, bool>> filter);
        TeacherField Find(Expression<Func<TeacherField, bool>> filter);
        TeacherField Add(TeacherField entity);
        void Delete(TeacherField entity);
    }
}
