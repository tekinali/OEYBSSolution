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
    public class ClassroomTypeManager : IClassroomTypeService
    {
        private IClassroomTypeDal _classroomTypeDal;
        private IMapper _mapper;

        public ClassroomTypeManager(IClassroomTypeDal classroomTypeDal, IMapper mapper)
        {
            _classroomTypeDal = classroomTypeDal;
            _mapper = mapper;
        }

        public ClassroomType Add(ClassroomType entity)
        {
            return _classroomTypeDal.Add(entity);
        }

        public void Delete(ClassroomType entity)
        {
            _classroomTypeDal.Delete(entity);
        }

        public ClassroomType Find(Expression<Func<ClassroomType, bool>> filter)
        {
            var data = _mapper.Map<ClassroomType>(_classroomTypeDal.Get(filter));
            return data;
        }

        public List<ClassroomType> GetAll()
        {
            var data = _mapper.Map<List<ClassroomType>>(_classroomTypeDal.GetList());
            return data;
        }

        public List<ClassroomType> List(Expression<Func<ClassroomType, bool>> filter)
        {
            var data = _mapper.Map<List<ClassroomType>>(_classroomTypeDal.GetList(filter));
            return data;
        }

        public ClassroomType Update(ClassroomType entity)
        {
            return _classroomTypeDal.Update(entity);
        }


    }
}
