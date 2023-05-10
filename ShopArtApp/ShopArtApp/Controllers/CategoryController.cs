using Microsoft.AspNetCore.Mvc;
using ShopArtApp.BussinessLogic.Services;
using ShopArtApp.Models;

namespace ShopArtApp.Controllers
{
    public class CategoryController : Controller
    {

        private readonly CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryByIdAsync(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategoryAsync(Category category)
        {
            _categoryService.AddCategory(category);
            return Ok(category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategoryAsync(int id, Category category)
        {
            if (id != category.IdCategory)
            {
                return BadRequest();
            }

            var existingCategory = await _categoryService.GetByIdAsync(id);

            if (existingCategory == null)
            {
                return NotFound();
            }

            _categoryService.UpdateCategory(category);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryAsync(int id)
        {
            var existingCategory = await _categoryService.GetByIdAsync(id);

            if (existingCategory == null)
            {
                return NotFound();
            }

            _categoryService.RemoveCategory(existingCategory);

            return Ok();
        }
    }

}

