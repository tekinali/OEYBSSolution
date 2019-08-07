using OEYBS.Business.Abstract;
using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OEYBS.DataAccess.Abstract;
using AutoMapper;

namespace OEYBS.Business.Concrete.Managers
{
    public class AppUserManager : IAppUserService
    {
        private IAppUserDal _appUserDal;
        private IMapper _mapper;

        public AppUserManager(IAppUserDal appUserDal, IMapper mapper)
        {
            _appUserDal = appUserDal;
            _mapper = mapper;
        }

        public AppUser Add(AppUser entity)
        {       
            return _appUserDal.Add(entity);
        }

        public void Delete(AppUser entity)
        {
            _appUserDal.Delete(entity);
        }

        public AppUser Find(Expression<Func<AppUser, bool>> filter)
        {
            var data = _mapper.Map<AppUser>(_appUserDal.Get(filter));
            return data;
        }

        public List<AppUser> GetAll()
        {
            var data = _mapper.Map<List<AppUser>>(_appUserDal.GetList());
            return data;
        }

        public List<AppUser> List(Expression<Func<AppUser, bool>> filter)
        {
            var data = _mapper.Map<List<AppUser>>(_appUserDal.GetList(filter));
            return data;
        }

        public AppUser Update(AppUser entity)
        {
            return _appUserDal.Update(entity);
        }
    }
}
