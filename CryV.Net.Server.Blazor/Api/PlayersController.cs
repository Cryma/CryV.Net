using CryV.Net.Server.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CryV.Net.Server.Blazor.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController(IPlayerManager _playerManager) : ControllerBase
    {

        // GET: api/<PlayersController>
        [HttpGet]
        public IEnumerable<IServerPlayer> Get()
        {
            return _playerManager.GetPlayers();
        }

        // GET api/<PlayersController>/5
        [HttpGet("{id}")]
        public IServerPlayer? Get(int id)
        {
            return _playerManager.GetPlayer(id);
        }

        // POST api/<PlayersController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<PlayersController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<PlayersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
