using NorthWind_API.Models.Categories;

namespace NorthWind_API.Repositories.Categories
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetCategories();
        public Task<Category> GetCategory(int id);
    }
}
