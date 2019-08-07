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
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        private IMapper _mapper;

        public EmployeeManager(IEmployeeDal employeeDal, IMapper mapper)
        {
            _employeeDal = employeeDal;
            _mapper = mapper;
        }

        public Employee Add(Employee entity)
        {
            return _employeeDal.Add(entity);
        }

        public void Delete(Employee entity)
        {
            _employeeDal.Delete(entity);
        }

        public Employee Find(Expression<Func<Employee, bool>> filter)
        {
            var data = _mapper.Map<Employee>(_employeeDal.Get(filter));
            return data;
        }

        public List<Employee> GetAll()
        {
            var data = _mapper.Map<List<Employee>>(_employeeDal.GetList());
            return data;
        }

        public List<Employee> List(Expression<Func<Employee, bool>> filter)
        {
            var data = _mapper.Map<List<Employee>>(_employeeDal.GetList(filter));
            return data;
        }

        public Employee Update(Employee entity)
        {
            return _employeeDal.Update(entity);
        }
    }
}
