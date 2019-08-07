using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Abstract
{
    public interface IAppRoleService
    {
        List<AppRole> GetAll();
        List<AppRole> List(Expression<Func<AppRole, bool>> filter);
        AppRole Find(Expression<Func<AppRole, bool>> filter);


    }
}
