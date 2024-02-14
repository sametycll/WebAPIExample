using HospitalManager.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.DataAccess.Abstract
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
    }
}
