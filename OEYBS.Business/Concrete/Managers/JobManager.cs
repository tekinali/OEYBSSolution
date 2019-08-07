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
    public class JobManager : IJobService
    {
        private IJobDal _jobDal;
        private IMapper _mapper;

        public JobManager(IJobDal jobDal, IMapper mapper)
        {
            _jobDal = jobDal;
            _mapper = mapper;
        }

        public Job Add(Job entity)
        {
            return _jobDal.Add(entity);
        }

        public void Delete(Job entity)
        {
            _jobDal.Delete(entity);
        }

        public Job Find(Expression<Func<Job, bool>> filter)
        {
            var data = _mapper.Map<Job>(_jobDal.Get(filter));
            return data;
        }

        public List<Job> GetAll()
        {
            var data = _mapper.Map<List<Job>>(_jobDal.GetList());
            return data;
        }

        public List<Job> List(Expression<Func<Job, bool>> filter)
        {
            var data = _mapper.Map<List<Job>>(_jobDal.GetList(filter));
            return data;
        }

        public Job Update(Job entity)
        {
            return _jobDal.Update(entity);
        }

    }
}
