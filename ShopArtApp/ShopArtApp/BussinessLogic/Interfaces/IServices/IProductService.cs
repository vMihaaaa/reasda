using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Interfaces.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> AddProductAsync(Product product);
        Product UpdateProductAsync(Product product);
        void DeleteProductAsync(Product product);
    }

}
