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
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeRepository _iemployeeRepository;

        public EmployeeManager(IEmployeeRepository iemployeeRepository)
        {
            _iemployeeRepository = iemployeeRepository;
        }

        public Employee Create(Employee entity)
        {
            return _iemployeeRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _iemployeeRepository.Delete(id);
        }

        public List<Employee> GetAll()
        {

            return _iemployeeRepository.GetAll();
        }

        public Employee GetById(int id)
        {
            if (id > 0)
            {
                return _iemployeeRepository.GetById(id);

            }
            throw new Exception("ID na cot be less than 1");
        }

        public Employee Update(Employee entity)
        {
            return _iemployeeRepository.Update(entity);
        }
    }
}
