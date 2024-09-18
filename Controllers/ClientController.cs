using Microsoft.AspNetCore.Mvc;
using ParaisoDosAnimais.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParaisoDosAnimais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController :ControllerBase
    {
        // GET: api/<ClientController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Client> clients = [];

            return Ok(clients);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Client client = null;

            return Ok(client);
        }

        // POST api/<ClientController>
        [HttpPost]
        
        public IActionResult Post([FromBody] Client client)
        {

            return Created();
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok("Value updated");
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Value deleted");
        }
    }
}
