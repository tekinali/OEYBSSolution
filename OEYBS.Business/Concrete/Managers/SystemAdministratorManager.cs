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
    public class SystemAdministratorManager : ISystemAdministratorService
    {
        private ISystemAdministratorDal _systemAdministratorDal;
        private IMapper _mapper;

        public SystemAdministratorManager(ISystemAdministratorDal systemAdministratorDal, IMapper mapper)
        {
            _systemAdministratorDal = systemAdministratorDal;
            _mapper = mapper;
        }

        public SystemAdministrator Add(SystemAdministrator entity)
        {
            return _systemAdministratorDal.Add(entity);
        }

        public void Delete(SystemAdministrator entity)
        {
            _systemAdministratorDal.Delete(entity);
        }

        public SystemAdministrator Find(Expression<Func<SystemAdministrator, bool>> filter)
        {
            var data = _mapper.Map<SystemAdministrator>(_systemAdministratorDal.Get(filter));
            return data;
        }

        public List<SystemAdministrator> GetAll()
        {
            var data = _mapper.Map<List<SystemAdministrator>>(_systemAdministratorDal.GetList());
            return data;
        }

        public List<SystemAdministrator> List(Expression<Func<SystemAdministrator, bool>> filter)
        {
            var data = _mapper.Map<List<SystemAdministrator>>(_systemAdministratorDal.GetList(filter));
            return data;
        }

        public SystemAdministrator Update(SystemAdministrator entity)
        {
            return _systemAdministratorDal.Update(entity);
        }
    }
}
