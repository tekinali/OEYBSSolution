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
    public class CorporationOwnerManager : ICorporationOwnerService
    {
        private ICorporationOwnerDal _corporationOwnerDal;
        private IMapper _mapper;

        public CorporationOwnerManager(ICorporationOwnerDal corporationOwnerDal, IMapper mapper)
        {
            _corporationOwnerDal = corporationOwnerDal;
            _mapper = mapper;
        }

        public CorporationOwner Add(CorporationOwner entity)
        {
            return _corporationOwnerDal.Add(entity);
        }

        public void Delete(CorporationOwner entity)
        {
            _corporationOwnerDal.Delete(entity);
        }

        public CorporationOwner Find(Expression<Func<CorporationOwner, bool>> filter)
        {
            var data = _mapper.Map<CorporationOwner>(_corporationOwnerDal.Get(filter));
            return data;
        }

        public List<CorporationOwner> GetAll()
        {
            var data = _mapper.Map<List<CorporationOwner>>(_corporationOwnerDal.GetList());
            return data;
        }

        public List<CorporationOwner> List(Expression<Func<CorporationOwner, bool>> filter)
        {
            var data = _mapper.Map<List<CorporationOwner>>(_corporationOwnerDal.GetList(filter));
            return data;
        }

        public CorporationOwner Update(CorporationOwner entity)
        {
            return _corporationOwnerDal.Update(entity);
        }
    }
}
