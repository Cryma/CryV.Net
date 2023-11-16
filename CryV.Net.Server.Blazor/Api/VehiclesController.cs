using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CryV.Net.Server.Blazor.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        private readonly IVehicleManager _vehicleManager;

        public VehiclesController(IVehicleManager vehicleManager)
        {
            _vehicleManager = vehicleManager;
        }


        // GET: api/<VehiclesController>
        [HttpGet]
        public IEnumerable<IServerVehicle> Get()
        {
            return _vehicleManager.GetVehicles();
        }

        // GET api/<VehiclesController>/5
        [HttpGet("{id}")]
        public IServerVehicle? Get(int id)
        {
            return _vehicleManager.GetVehicle(id);
        }

        // POST api/<VehiclesController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<VehiclesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<VehiclesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
