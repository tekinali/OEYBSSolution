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
    public class CorporationManager : ICorporationService
    {
        private ICorporationDal _corporationDal;
        private IMapper _mapper;

        public CorporationManager(ICorporationDal corporationDal, IMapper mapper)
        {
            _corporationDal = corporationDal;
            _mapper = mapper;
        }

        public Corporation Add(Corporation entity)
        {
            return _corporationDal.Add(entity);
        }

        public void Delete(Corporation entity)
        {
            _corporationDal.Delete(entity);
        }

        public Corporation Find(Expression<Func<Corporation, bool>> filter)
        {
            var data = _mapper.Map<Corporation>(_corporationDal.Get(filter));
            return data;
        }

        public List<Corporation> GetAll()
        {
            var data = _mapper.Map<List<Corporation>>(_corporationDal.GetList());
            return data;
        }

        public List<Corporation> List(Expression<Func<Corporation, bool>> filter)
        {
            var data = _mapper.Map<List<Corporation>>(_corporationDal.GetList(filter));
            return data;
        }

        public Corporation Update(Corporation entity)
        {
            return _corporationDal.Update(entity);
        }
    }
}
