using Microsoft.AspNetCore.Mvc;
using ParaisoDosAnimais.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParaisoDosAnimais.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController(ProductService productService) :ControllerBase
    {
        private readonly ProductService _productService = productService;

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }


        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {


            return Created();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id:guid}")]
        public IActionResult Put(Guid id, [FromBody] string value)
        {
            return Ok("Product updated");
        }

        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            return Ok("Product deleted");
        }
    }
}