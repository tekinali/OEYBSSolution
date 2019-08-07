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
    public class UserRoleManager : IUserRoleService
    {
        private IUserRoleDal _userRoleDal;
        private IMapper _mapper;

        public UserRoleManager(IUserRoleDal userRoleDal, IMapper mapper)
        {
            _userRoleDal = userRoleDal;
            _mapper = mapper;
        }

        public UserRole Add(UserRole entity)
        {
            return _userRoleDal.Add(entity);
        }

        public void Delete(UserRole entity)
        {
            _userRoleDal.Delete(entity);
        }

        public UserRole Find(Expression<Func<UserRole, bool>> filter)
        {
            var data = _mapper.Map<UserRole>(_userRoleDal.Get(filter));
            return data;
        }

        public List<UserRole> GetAll()
        {
            var data = _mapper.Map<List<UserRole>>(_userRoleDal.GetList());
            return data;
        }

        public List<UserRole> List(Expression<Func<UserRole, bool>> filter)
        {
            var data = _mapper.Map<List<UserRole>>(_userRoleDal.GetList(filter));
            return data;
        }
      
    }
}
