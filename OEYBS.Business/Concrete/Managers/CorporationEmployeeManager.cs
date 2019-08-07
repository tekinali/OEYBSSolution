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
    public class CorporationEmployeeManager : ICorporationEmployeeService
    {
        private ICorporationEmployeeDal _corporationEmployeeDal;
        private IMapper _mapper;

        public CorporationEmployeeManager(ICorporationEmployeeDal corporationEmployeeDal, IMapper mapper)
        {
            _corporationEmployeeDal = corporationEmployeeDal;
            _mapper = mapper;
        }

        public CorporationEmployee Add(CorporationEmployee entity)
        {
            return _corporationEmployeeDal.Add(entity);
        }

        public void Delete(CorporationEmployee entity)
        {
            _corporationEmployeeDal.Delete(entity);
        }

        public CorporationEmployee Find(Expression<Func<CorporationEmployee, bool>> filter)
        {
            var data = _mapper.Map<CorporationEmployee>(_corporationEmployeeDal.Get(filter));
            return data;
        }

        public CorporationEmployee FindWithDetails(Expression<Func<CorporationEmployee, bool>> filter)
        {
            var data = _mapper.Map<CorporationEmployee>(_corporationEmployeeDal.GetWithDetails(filter));
            return data;
        }

        public List<CorporationEmployee> GetAll()
        {
            var data = _mapper.Map<List<CorporationEmployee>>(_corporationEmployeeDal.GetList());
            return data;
        }

        public List<CorporationEmployee> GetAllWithDetails()
        {
            var data = _mapper.Map<List<CorporationEmployee>>(_corporationEmployeeDal.GetListWithDetails());
            return data;
        }

        public List<CorporationEmployee> List(Expression<Func<CorporationEmployee, bool>> filter)
        {
            var data = _mapper.Map<List<CorporationEmployee>>(_corporationEmployeeDal.GetList(filter));
            return data;
        }

        public List<CorporationEmployee> ListWithDetails(Expression<Func<CorporationEmployee, bool>> filter)
        {
            var data = _mapper.Map<List<CorporationEmployee>>(_corporationEmployeeDal.GetListWithDetails(filter));
            return data;
        }
    }
}
