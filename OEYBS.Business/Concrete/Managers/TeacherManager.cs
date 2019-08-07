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
    public class TeacherManager : ITeacherService
    {
        private ITeacherDal _teacherDal;
        private IMapper _mapper;

        public TeacherManager(ITeacherDal teacherDal, IMapper mapper)
        {
            _teacherDal = teacherDal;
            _mapper = mapper;
        }

        public Teacher Add(Teacher entity)
        {
            return _teacherDal.Add(entity);
        }

        public void Delete(Teacher entity)
        {
            _teacherDal.Delete(entity);
        }

        public Teacher Find(Expression<Func<Teacher, bool>> filter)
        {
            var data = _mapper.Map<Teacher>(_teacherDal.Get(filter));
            return data;
        }

        public List<Teacher> GetAll()
        {
            var data = _mapper.Map<List<Teacher>>(_teacherDal.GetList());
            return data;
        }

        public List<Teacher> List(Expression<Func<Teacher, bool>> filter)
        {
            var data = _mapper.Map<List<Teacher>>(_teacherDal.GetList(filter));
            return data;
        }

        public Teacher Update(Teacher entity)
        {
            return _teacherDal.Update(entity);
        }



    }
}
