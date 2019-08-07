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
    public class CorporationSchoolManagerManager : ICorporationSchoolManagerService
    {
        private ICorporationSchoolManagerDal _corporationSchoolManagerDal;
        private IMapper _mapper;

        public CorporationSchoolManagerManager(ICorporationSchoolManagerDal corporationSchoolManagerDal, IMapper mapper)
        {
            _corporationSchoolManagerDal = corporationSchoolManagerDal;
            _mapper = mapper;
        }

        public CorporationSchoolManager Add(CorporationSchoolManager entity)
        {
            return _corporationSchoolManagerDal.Add(entity);
        }

        public void Delete(CorporationSchoolManager entity)
        {
            _corporationSchoolManagerDal.Delete(entity);
        }

        public CorporationSchoolManager Find(Expression<Func<CorporationSchoolManager, bool>> filter)
        {
            var data = _mapper.Map<CorporationSchoolManager>(_corporationSchoolManagerDal.Get(filter));
            return data;
        }

        public CorporationSchoolManager FindWithDetails(Expression<Func<CorporationSchoolManager, bool>> filter)
        {
            var data = _mapper.Map<CorporationSchoolManager>(_corporationSchoolManagerDal.GetWithDetails(filter));
            return data;
        }

        public List<CorporationSchoolManager> GetAll()
        {
            var data = _mapper.Map<List<CorporationSchoolManager>>(_corporationSchoolManagerDal.GetList());
            return data;
        }

        public List<CorporationSchoolManager> GetAllWithDetails()
        {
            var data = _mapper.Map<List<CorporationSchoolManager>>(_corporationSchoolManagerDal.GetListWithDetails());
            return data;
        }

        public List<CorporationSchoolManager> List(Expression<Func<CorporationSchoolManager, bool>> filter)
        {
            var data = _mapper.Map<List<CorporationSchoolManager>>(_corporationSchoolManagerDal.GetList(filter));
            return data;
        }

        public List<CorporationSchoolManager> ListWithDetails(Expression<Func<CorporationSchoolManager, bool>> filter)
        {
            var data = _mapper.Map<List<CorporationSchoolManager>>(_corporationSchoolManagerDal.GetListWithDetails(filter));
            return data;
        }
    }
}
