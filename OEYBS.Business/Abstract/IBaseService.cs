using OEYBS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Abstract
{
    public interface IBaseService<T>
        where T : class, new()
    {
        List<T> GetAll();
        List<T> List(Expression<Func<T, bool>> filter);
        T Find(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
