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
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;
        private IMapper _mapper;

        public StudentManager(IStudentDal studentDal, IMapper mapper)
        {
            _studentDal = studentDal;
            _mapper = mapper;
        }

        public Student Add(Student entity)
        {
            return _studentDal.Add(entity);
        }

        public void Delete(Student entity)
        {
            _studentDal.Delete(entity);
        }

        public Student Find(Expression<Func<Student, bool>> filter)
        {
            var data = _mapper.Map<Student>(_studentDal.Get(filter));
            return data;
        }

        public List<Student> GetAll()
        {
            var data = _mapper.Map<List<Student>>(_studentDal.GetList());
            return data;
        }

        public List<Student> List(Expression<Func<Student, bool>> filter)
        {
            var data = _mapper.Map<List<Student>>(_studentDal.GetList(filter));
            return data;
        }

        public Student Update(Student entity)
        {
            return _studentDal.Update(entity);
        }
    }
}
