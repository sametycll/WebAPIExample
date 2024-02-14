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
    public class ShipperRepository : IShipperRepository
    {
        public Shipper Create(Shipper entity)
        {
            using (var dbContext = new NorthwindContext())
            {
                dbContext.Shippers.Add(entity);
                dbContext.SaveChanges();
                return entity;
            }
        }

        public void Delete(int id)
        {
            using (var dbContext = new NorthwindContext())
            {
                var deletedEmp = GetById(id);
                dbContext.Shippers.Remove(deletedEmp);
                dbContext.SaveChanges();
            }
        }

        public List<Shipper> GetAll()
        {
            using (var dbContext = new NorthwindContext())
            {
                return dbContext.Shippers.ToList();
            }
        }

        public Shipper GetById(int id)
        {
            using (var dbContext = new NorthwindContext())
            {
                return dbContext.Shippers.Find(id);
            }
        }

        public Shipper Update(Shipper entity)
        {
            using (var dbContext = new NorthwindContext())
            {
                dbContext.Shippers.Update(entity);
                dbContext.SaveChanges();
                return entity;
            }
        }
    }
}
