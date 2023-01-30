using Microsoft.EntityFrameworkCore;
using NorthWind_API.Data;
using NorthWind_API.Models.Categories;

namespace NorthWind_API.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        #region Injection
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<List<Category>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetCategory(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryID == id);
            return category;
        }
    }
}
