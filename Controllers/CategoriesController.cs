using Microsoft.AspNetCore.Mvc;
using NorthWind_API.Repositories.Categories;

namespace NorthWind_API.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        #region Injection
        private readonly ICategoryRepository _categories;
        public CategoriesController(ICategoryRepository categories)
        {
            _categories = categories;
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Json(await _categories.GetCategories());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Json(await _categories.GetCategory(id));
        }
    }
}
