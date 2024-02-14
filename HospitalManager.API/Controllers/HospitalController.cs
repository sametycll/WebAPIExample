using HospitalManager.Business.Abstract;
using HospitalManager.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private IEmployeeService _iemployeeService;
        private ICustomerService _icustomerService;

        public HospitalController(IEmployeeService iemployeeService, ICustomerService icustomerService)
        {
            _iemployeeService = iemployeeService;
            _icustomerService = icustomerService;
        }

        //[HttpGet]
        //public List<Employee> GetEmployees()
        //{
        //    return _iemployeeService.GetAll();
        //}

        //[HttpGet("{id}")]
        //public Employee GetEmployees(int id)
        //{
        //    return _iemployeeService.GetById(id);
        //}



        //[HttpGet]
        //public List<Customer> GetCustomer()
        //{
        //    return _icustomerService.GetAll();
        //}

        //[HttpGet("{name}")]
        //public Customer GetCustomer(string name)
        //{
        //    return _icustomerService.GetByName(name);
        //}








    }
}
