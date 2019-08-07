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
    public class StudentReportManager : IStudentReportService
    {
        private IStudentReportDal _studentReportDal;
        private IMapper _mapper;

        public StudentReportManager(IStudentReportDal studentReportDal, IMapper mapper)
        {
            _studentReportDal = studentReportDal;
            _mapper = mapper;
        }

        public StudentReport Add(StudentReport entity)
        {
            return _studentReportDal.Add(entity);
        }

        public void Delete(StudentReport entity)
        {
            _studentReportDal.Delete(entity);
        }

        public StudentReport Find(Expression<Func<StudentReport, bool>> filter)
        {
            var data = _mapper.Map<StudentReport>(_studentReportDal.Get(filter));
            return data;
        }

        public List<StudentReport> GetAll()
        {
            var data = _mapper.Map<List<StudentReport>>(_studentReportDal.GetList());
            return data;
        }

        public List<StudentReport> List(Expression<Func<StudentReport, bool>> filter)
        {
            var data = _mapper.Map<List<StudentReport>>(_studentReportDal.GetList(filter));
            return data;
        }

        public StudentReport Update(StudentReport entity)
        {
            return _studentReportDal.Update(entity);
        }
    }
}
