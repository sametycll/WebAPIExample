using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        T Create(T entity);
        T Update(T entity);
        void Delete(int id);   
    }
}
