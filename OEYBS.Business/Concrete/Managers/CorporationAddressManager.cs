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
    public class CorporationAddressManager : ICorporationAddressService
    {
        private ICorporationAddressDal _corporationAddressDal;
        private IMapper _mapper;

        public CorporationAddressManager(ICorporationAddressDal corporationAddressDal, IMapper mapper)
        {
            _corporationAddressDal = corporationAddressDal;
            _mapper = mapper;
        }

        public CorporationAddress Add(CorporationAddress entity)
        {
            return _corporationAddressDal.Add(entity);
        }

        public void Delete(CorporationAddress entity)
        {
            _corporationAddressDal.Delete(entity);
        }

        public CorporationAddress Find(Expression<Func<CorporationAddress, bool>> filter)
        {
            var data = _mapper.Map<CorporationAddress>(_corporationAddressDal.Get(filter));
            return data;
        }

        public List<CorporationAddress> GetAll()
        {
            var data = _mapper.Map<List<CorporationAddress>>(_corporationAddressDal.GetList());
            return data;
        }

        public List<CorporationAddress> List(Expression<Func<CorporationAddress, bool>> filter)
        {
            var data = _mapper.Map<List<CorporationAddress>>(_corporationAddressDal.GetList(filter));
            return data;
        }

        public CorporationAddress Update(CorporationAddress entity)
        {
            return _corporationAddressDal.Update(entity);
        }
    }
}
