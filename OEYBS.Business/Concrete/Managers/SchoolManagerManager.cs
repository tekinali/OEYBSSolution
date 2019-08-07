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
    public class SchoolManagerManager : ISchoolManagerService
    {
        private ISchoolManagerDal _corporationManagerDal;
        private IMapper _mapper;

        public SchoolManagerManager(ISchoolManagerDal corporationManagerDal, IMapper mapper)
        {
            _corporationManagerDal = corporationManagerDal;
            _mapper = mapper;
        }

        public SchoolManager Add(SchoolManager entity)
        {
            return _corporationManagerDal.Add(entity);
        }

        public void Delete(SchoolManager entity)
        {
            _corporationManagerDal.Delete(entity);
        }

        public SchoolManager Find(Expression<Func<SchoolManager, bool>> filter)
        {
            var data = _mapper.Map<SchoolManager>(_corporationManagerDal.Get(filter));
            return data;
        }

        public List<SchoolManager> GetAll()
        {
            var data = _mapper.Map<List<SchoolManager>>(_corporationManagerDal.GetList());
            return data;
        }

        public List<SchoolManager> List(Expression<Func<SchoolManager, bool>> filter)
        {
            var data = _mapper.Map<List<SchoolManager>>(_corporationManagerDal.GetList(filter));
            return data;
        }

        public SchoolManager Update(SchoolManager entity)
        {
            return _corporationManagerDal.Update(entity);
        }
    }
}
