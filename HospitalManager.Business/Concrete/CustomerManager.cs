using HospitalManager.Business.Abstract;
using HospitalManager.DataAccess.Abstract;
using HospitalManager.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public ICustomerRepository _icustomerRepository;

        public CustomerManager(ICustomerRepository icustomerRepository)
        {
            _icustomerRepository = icustomerRepository;
        }

        public Customer Create(Customer entity)
        {
           return _icustomerRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _icustomerRepository.Delete(id);
        }

        public List<Customer> GetAll()
        {
            return _icustomerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
            if (id > 0)
            {
                return _icustomerRepository.GetById(id);

            }
            throw new Exception("ID na cot be less than 1");
        }

        public Customer GetByName(string name)
        {
            return _icustomerRepository.GetByName(name);
        }

        public Customer Update(Customer entity)
        {
            return _icustomerRepository.Update(entity);
        }
    }
}
