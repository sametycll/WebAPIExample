using HospitalManager.Business.Abstract;
using HospitalManager.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private IShipperService _ishipperService;

        public ShipperController(IShipperService ishipperService)
        {
            _ishipperService = ishipperService;
        }

        /// <summary>
        /// Get All Shippers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Shipper> Get()
        {
            return _ishipperService.GetAll();
        }

        /// <summary>
        /// Get Shipper By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Shipper Get(int id)
        {
            return _ishipperService.GetById(id);
        }

        /// <summary>
        /// Create a Shipper
        /// </summary>
        /// <param name="shipper"></param>
        /// <returns></returns>
        [HttpPost]
        public Shipper Post(Shipper shipper)
        {
            return _ishipperService.Create(shipper);
        }


        /// <summary>
        /// Update the Shipper
        /// </summary>
        /// <param name="shipper"></param>
        /// <returns></returns>
        [HttpPut]
        public Shipper Put(Shipper shipper)
        {
            return _ishipperService.Update(shipper);
        }


        /// <summary>
        /// Delete the Shipper
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ishipperService.Delete(id);
        }
    }
}
