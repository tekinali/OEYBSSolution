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
    public class EducationBranchManager : IEducationBranchService
    {
        private IEducationBranchDal _educationBranchDal;
        private IMapper _mapper;

        public EducationBranchManager(IEducationBranchDal educationBranchDal, IMapper mapper)
        {
            _educationBranchDal = educationBranchDal;
            _mapper = mapper;
        }

        public EducationBranch Add(EducationBranch entity)
        {
            return _educationBranchDal.Add(entity);
        }

        public void Delete(EducationBranch entity)
        {
            _educationBranchDal.Delete(entity);
        }

        public EducationBranch Find(Expression<Func<EducationBranch, bool>> filter)
        {
            var data = _mapper.Map<EducationBranch>(_educationBranchDal.Get(filter));
            return data;
        }

        public List<EducationBranch> GetAll()
        {
            var data = _mapper.Map<List<EducationBranch>>(_educationBranchDal.GetList());
            return data;
        }

        public List<EducationBranch> List(Expression<Func<EducationBranch, bool>> filter)
        {
            var data = _mapper.Map<List<EducationBranch>>(_educationBranchDal.GetList(filter));
            return data;
        }

        public EducationBranch Update(EducationBranch entity)
        {
            return _educationBranchDal.Update(entity);
        }
    }
}
