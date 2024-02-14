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
    public class EmployeeRepositorycs : IEmployeeRepository
    {
        public Employee Create(Employee entity)
        {
            using (var dbContext = new NorthwindContext())
            {
                dbContext.Employees.Add(entity);
                dbContext.SaveChanges();
                return entity;
            }
        }

        public void Delete(int id)
        {
            using (var dbContext = new NorthwindContext())
            {
                var deletedEmp = GetById(id);
                dbContext.Employees.Remove(deletedEmp);
                dbContext.SaveChanges();
            }
        }

        public List<Employee> GetAll()
        {
            using (var dbContext = new NorthwindContext())
            {
                return dbContext.Employees.ToList();
            }
        }

        public Employee GetById(int id)
        {
            using (var dbContext = new NorthwindContext())
            {
                return dbContext.Employees.Find(id);
            }
        }

        public Employee Update(Employee entity)
        {
            using (var dbContext = new NorthwindContext())
            {
                dbContext.Employees.Update(entity);
                dbContext.SaveChanges();
                return entity;
            }
        }
    }
}
