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
    public class EmployeeJobManager : IEmployeeJobService
    {
        private IEmployeeJobDal _employeeJobDal;
        private IMapper _mapper;

        public EmployeeJobManager(IEmployeeJobDal employeeJobDal, IMapper mapper)
        {
            _employeeJobDal = employeeJobDal;
            _mapper = mapper;
        }

        public EmployeeJob Add(EmployeeJob entity)
        {
            return _employeeJobDal.Add(entity);
        }

        public void Delete(EmployeeJob entity)
        {
            _employeeJobDal.Delete(entity);
        }

        public EmployeeJob Find(Expression<Func<EmployeeJob, bool>> filter)
        {
            var data = _mapper.Map<EmployeeJob>(_employeeJobDal.Get(filter));
            return data;
        }

        public List<EmployeeJob> GetAll()
        {
            var data = _mapper.Map<List<EmployeeJob>>(_employeeJobDal.GetList());
            return data;
        }

        public List<EmployeeJob> List(Expression<Func<EmployeeJob, bool>> filter)
        {
            var data = _mapper.Map<List<EmployeeJob>>(_employeeJobDal.GetList(filter));
            return data;
        }

        public EmployeeJob Update(EmployeeJob entity)
        {
            return _employeeJobDal.Update(entity);
        }
    }
}
