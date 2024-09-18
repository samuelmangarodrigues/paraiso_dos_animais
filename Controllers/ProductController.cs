using Microsoft.AspNetCore.Mvc;
using ParaisoDosAnimais.Models;
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
            IEnumerable<Product> products = [];

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Product product = null;

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Created();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok("Product updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Product deleted");
        }
    }
}
