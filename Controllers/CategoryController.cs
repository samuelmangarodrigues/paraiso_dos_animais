using Microsoft.AspNetCore.Mvc;
using ParaisoDosAnimais.Dtos;
using ParaisoDosAnimais.Models;
using ParaisoDosAnimais.Services;
using ParaisoDosAnimais.Services.Errors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParaisoDosAnimais.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController(CategoryService categoryService) :ControllerBase
    {

        private readonly CategoryService _categoryService = categoryService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categoriesResult = await _categoryService.GetCategoriesAsync();

            return Ok(categoriesResult);

        }


        [HttpGet("{categoryId}")]
        public async Task<IActionResult> Get(Guid categoryId)
        {

            var categoryResult = await _categoryService.GetCategoryByIdAsync(categoryId);

            if (categoryResult.IsT0)
            {
                var category = categoryResult.AsT0;

                return Ok(category);
            }

            var error = categoryResult.AsT1;

            if (error.ErrorType == ErrorTypes.NotFound)
                return NotFound(new { message = error.Detail });

            return BadRequest(new { message = error.Detail });

        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCategoryDto category)
        {
            var categoryResult = await _categoryService.AddCategoryAsync(category);

            if (categoryResult.IsT0)
            {
                return Created();
            }

            var error = categoryResult.AsT1;

            return Conflict(new { message = error.Detail });

        }


        [HttpPut("{categoryId}")]
        public async Task<IActionResult> Put(Guid categoryId, [FromBody] UpdateCategoryDto category)
        {
            var categoryResult = await _categoryService.UpdateCategoryAsync(categoryId, category);

            if (categoryResult.IsT0)
            {
                var categoryUpdated = categoryResult.AsT0;
                return Ok(new { message = "Update success", data = categoryUpdated });
            }

            var error = categoryResult.AsT1;

            if (error.ErrorType == ErrorTypes.NotFound)
                return NotFound(new { message = error.Detail });

            return BadRequest(new { message = error.Detail });

        }


        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> Delete(Guid categoryId)
        {
            var categoryResult = await _categoryService.DeleteCategoryAsync(categoryId);

            if (categoryResult.IsT0)
            {
                return Ok(new { message = "Category deleted!" });
            }

            var error = categoryResult.AsT1;

            if (error.ErrorType == ErrorTypes.NotFound)
                return NotFound(error.Detail);

            return BadRequest(new { message = error.Detail });

        }
    }
}
