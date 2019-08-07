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
    public class TeacherFieldManager : ITeacherFieldService
    {
        private ITeacherFieldDal _teacherFieldDal;
        private IMapper _mapper;

        public TeacherFieldManager(ITeacherFieldDal teacherFieldDal, IMapper mapper)
        {
            _teacherFieldDal = teacherFieldDal;
            _mapper = mapper;
        }

        public TeacherField Add(TeacherField entity)
        {
            return _teacherFieldDal.Add(entity);
        }

        public void Delete(TeacherField entity)
        {
            _teacherFieldDal.Delete(entity);
        }

        public TeacherField Find(Expression<Func<TeacherField, bool>> filter)
        {
            var data = _mapper.Map<TeacherField>(_teacherFieldDal.Get(filter));
            return data;
        }

        public List<TeacherField> GetAll()
        {
            var data = _mapper.Map<List<TeacherField>>(_teacherFieldDal.GetList());
            return data;
        }

        public List<TeacherField> List(Expression<Func<TeacherField, bool>> filter)
        {
            var data = _mapper.Map<List<TeacherField>>(_teacherFieldDal.GetList(filter));
            return data;
        }
      
    }
}
