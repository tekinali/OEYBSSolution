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
    public class CorporationTeacherManager : ICorporationTeacherService
    {
        private ICorporationTeacherDal _corporationTeacherDal;
        private IMapper _mapper;

        public CorporationTeacherManager(ICorporationTeacherDal corporationTeacherDal, IMapper mapper)
        {
            _corporationTeacherDal = corporationTeacherDal;
            _mapper = mapper;
        }

        public CorporationTeacher Add(CorporationTeacher entity)
        {
            return _corporationTeacherDal.Add(entity);
        }

        public void Delete(CorporationTeacher entity)
        {
            _corporationTeacherDal.Delete(entity);
        }

        public CorporationTeacher Find(Expression<Func<CorporationTeacher, bool>> filter)
        {
            var data = _mapper.Map<CorporationTeacher>(_corporationTeacherDal.Get(filter));
            return data;
        }

        public CorporationTeacher FindWithDetails(Expression<Func<CorporationTeacher, bool>> filter)
        {
            var data = _mapper.Map<CorporationTeacher>(_corporationTeacherDal.GetList(filter));
            return data;
        }

        public List<CorporationTeacher> GetAll()
        {
            var data = _mapper.Map<List<CorporationTeacher>>(_corporationTeacherDal.GetList());
            return data;
        }

        public List<CorporationTeacher> GetAllWithDetails()
        {
            var data = _mapper.Map<List<CorporationTeacher>>(_corporationTeacherDal.GetListWithDetails());
            return data;
        }

        public List<CorporationTeacher> List(Expression<Func<CorporationTeacher, bool>> filter)
        {
            var data = _mapper.Map<List<CorporationTeacher>>(_corporationTeacherDal.GetList(filter));
            return data;
        }

        public List<CorporationTeacher> ListWithDetails(Expression<Func<CorporationTeacher, bool>> filter)
        {
            var data = _mapper.Map<List<CorporationTeacher>>(_corporationTeacherDal.GetListWithDetails(filter));
            return data;
        }
    }
}
