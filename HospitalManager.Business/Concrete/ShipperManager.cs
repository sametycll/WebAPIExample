using HospitalManager.Business.Abstract;
using HospitalManager.DataAccess.Abstract;
using HospitalManager.DataAccess.Concrete;
using HospitalManager.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.Business.Concrete
{
    public class ShipperManager : IShipperService
    {
        IShipperRepository _ishipperRepository;

        public ShipperManager(IShipperRepository ishipperRepository)
        {
            _ishipperRepository = ishipperRepository;
        }

        public Shipper Create(Shipper entity)
        {
            return _ishipperRepository.Create(entity);

        }

        public void Delete(int id)
        {
            _ishipperRepository.Delete(id);

        }

        public List<Shipper> GetAll()
        {
            return _ishipperRepository.GetAll();

        }

        public Shipper GetById(int id)
        {
            if (id > 0)
            {
                return _ishipperRepository.GetById(id);

            }
            throw new Exception("ID na cot be less than 1");
        }

        public Shipper Update(Shipper entity)
        {
            return _ishipperRepository.Update(entity);

        }
    }
}
