using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Abstract
{
    public interface IUserRoleService 
    {
        List<UserRole> GetAll();
        List<UserRole> List(Expression<Func<UserRole, bool>> filter);
        UserRole Find(Expression<Func<UserRole, bool>> filter);
        UserRole Add(UserRole entity);        
        void Delete(UserRole entity);
    }
}
