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
    public class EducationManager : IEducationService
    {
        private IEducationDal _educationDal;
        private IMapper _mapper;

        public EducationManager(IEducationDal educationDal, IMapper mapper)
        {
            _educationDal = educationDal;
            _mapper = mapper;
        }

        public Education Add(Education entity)
        {
            return _educationDal.Add(entity);
        }

        public void Delete(Education entity)
        {
            _educationDal.Delete(entity);
        }

        public Education Find(Expression<Func<Education, bool>> filter)
        {
            var data = _mapper.Map<Education>(_educationDal.Get(filter));
            return data;
        }

        public List<Education> GetAll()
        {
            var data = _mapper.Map<List<Education>>(_educationDal.GetList());
            return data;
        }

        public List<Education> List(Expression<Func<Education, bool>> filter)
        {
            var data = _mapper.Map<List<Education>>(_educationDal.GetList(filter));
            return data;
        }

        public Education Update(Education entity)
        {
            return _educationDal.Update(entity);
        }
    }
}
