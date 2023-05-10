using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Interfaces.IServices
{
    public interface ICategoryService
    {
        public interface ICategoryService
        {
            Task<IEnumerable<Category>> GetAllCategoriesAsync();
            Task<Category> GetCategoryByIdAsync(int id);
            Task<Category> AddCategoryAsync(Category category);
            Task UpdateCategoryAsync(Category category);
            void RemoveCategory(Category category);
        }

    }

}
