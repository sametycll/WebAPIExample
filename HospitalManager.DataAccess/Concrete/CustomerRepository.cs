using HospitalManager.DataAccess.Abstract;
using HospitalManager.Entities.Context;
using HospitalManager.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.DataAccess.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        public ICustomerRepository _icustomerRepository;

        public CustomerRepository(ICustomerRepository icustomerRepository)
        {
            _icustomerRepository = icustomerRepository;
        }
       //var dbContext = new NorthwindContext();
        public Customer Create(Customer entity)
        {
            using (var dbContext = new NorthwindContext())
            {
                dbContext.Customers.Add(entity);
                dbContext.SaveChanges();
                return entity;
            }
        }

        public void Delete(int id)
        {
            using (var dbContext = new NorthwindContext())
            {
                var deletedEmp = GetById(id);
                dbContext.Customers.Remove(deletedEmp);
                dbContext.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
           using (var dbContext = new NorthwindContext())
            {
                return dbContext.Customers.ToList();
            }
        }

        public Customer GetById(int id)
        {
            using (var dbContext = new NorthwindContext())
            {
                return dbContext.Customers.Find(id);
            }
        }

        public Customer Update(Customer entity)
        {
            using (var dbContext = new NorthwindContext())
            {
                dbContext.Customers.Update(entity);
                dbContext.SaveChanges();
                return entity;
            }
        }
    }
}
