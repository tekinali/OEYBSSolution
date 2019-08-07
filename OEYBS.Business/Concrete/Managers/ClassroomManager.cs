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
    public class ClassroomManager : IClassroomService
    {
        private IClassroomDal _classroomDal;
        private IMapper _mapper;

        public ClassroomManager(IClassroomDal classroomDal, IMapper mapper)
        {
            _classroomDal = classroomDal;
            _mapper = mapper;
        }

        public Classroom Add(Classroom entity)
        {
            return _classroomDal.Add(entity);
        }

        public void Delete(Classroom entity)
        {
            _classroomDal.Delete(entity);
        }

        public Classroom Find(Expression<Func<Classroom, bool>> filter)
        {
            var data = _mapper.Map<Classroom>(_classroomDal.Get(filter));
            return data;
        }

        public List<Classroom> GetAll()
        {
            var data = _mapper.Map<List<Classroom>>(_classroomDal.GetList());
            return data;
        }

        public List<Classroom> List(Expression<Func<Classroom, bool>> filter)
        {
            var data = _mapper.Map<List<Classroom>>(_classroomDal.GetList(filter));
            return data;
        }

        public Classroom Update(Classroom entity)
        {
            return _classroomDal.Update(entity);
        }
    }
}
