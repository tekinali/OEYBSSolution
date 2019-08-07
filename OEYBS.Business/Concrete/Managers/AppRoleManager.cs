using AutoMapper;
using OEYBS.Business.Abstract;
using OEYBS.DataAccess.Abstract;
using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Concrete.Managers
{
    public class AppRoleManager : IAppRoleService
    {
        private IAppRoleDal _appRoleDal;
        private readonly IMapper _mapper;

        public AppRoleManager(IAppRoleDal appRoleDal, IMapper mapper)
        {
            _appRoleDal = appRoleDal;
            _mapper = mapper;
        }

        public AppRole Find(Expression<Func<AppRole, bool>> filter)
        {
            var role = _mapper.Map<AppRole>(_appRoleDal.Get(filter));
            return role;
        }

        public List<AppRole> GetAll()
        {
            var roles = _mapper.Map<List<AppRole>>(_appRoleDal.GetList());
            return roles;            
        }

        public List<AppRole> List(Expression<Func<AppRole, bool>> filter)
        {
            var roles = _mapper.Map<List<AppRole>>(_appRoleDal.GetList(filter));
            return roles;
        }
    }
}
