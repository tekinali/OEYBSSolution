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
    public class CorporationStudentManager : ICorporationStudentService
    {
        private ICorporationStudentDal _corporationStudentDal;
        private IMapper _mapper;

        public CorporationStudentManager(ICorporationStudentDal corporationStudentDal, IMapper mapper)
        {
            _corporationStudentDal = corporationStudentDal;
            _mapper = mapper;
        }

        public CorporationStudent Add(CorporationStudent entity)
        {
            return _corporationStudentDal.Add(entity);
        }

        public void Delete(CorporationStudent entity)
        {
            _corporationStudentDal.Delete(entity);
        }

        public CorporationStudent Find(Expression<Func<CorporationStudent, bool>> filter)
        {
            var data = _mapper.Map<CorporationStudent>(_corporationStudentDal.Get(filter));
            return data;
        }

        public CorporationStudent FindWithDetails(Expression<Func<CorporationStudent, bool>> filter)
        {
            var data = _mapper.Map<CorporationStudent>(_corporationStudentDal.GetWithDetails(filter));
            return data;
        }

        public List<CorporationStudent> GetAll()
        {
            var data = _mapper.Map<List<CorporationStudent>>(_corporationStudentDal.GetList());
            return data;
        }

        public List<CorporationStudent> GetAllWithDetails()
        {
            var data = _mapper.Map<List<CorporationStudent>>(_corporationStudentDal.GetListWithDetails());
            return data;
        }

        public List<CorporationStudent> List(Expression<Func<CorporationStudent, bool>> filter)
        {
            var data = _mapper.Map<List<CorporationStudent>>(_corporationStudentDal.GetList(filter));
            return data;
        }

        public List<CorporationStudent> ListWithDetails(Expression<Func<CorporationStudent, bool>> filter)
        {
            var data = _mapper.Map<List<CorporationStudent>>(_corporationStudentDal.GetListWithDetails(filter));
            return data;
        }
    }
}
