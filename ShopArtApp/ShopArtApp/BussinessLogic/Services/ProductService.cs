using ShopArtApp.BussinessLogic.Interfaces.IServices;
using ShopArtApp.DataAcces.Repositories.Interfaces;
using ShopArtApp.Models;

namespace ShopArtApp.BussinessLogic.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _unitOfWork.ProductRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _unitOfWork.ProductRepository.GetByIdAsync(id);
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            await _unitOfWork.ProductRepository.AddAsync(product);
            _unitOfWork.Save();
            return product;
        }

        public Product UpdateProductAsync(Product product)
        {
            _unitOfWork.ProductRepository.Update(product);
            _unitOfWork.Save();
            return product;
        }

        public void DeleteProductAsync(Product product)
        {
            _unitOfWork.ProductRepository.RemoveAsync(product.IdProduct);
            _unitOfWork.Save();
        }
    }
}
