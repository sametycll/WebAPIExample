using HospitalManager.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManager.Business.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
        Customer GetByName(string name);

    }
}
