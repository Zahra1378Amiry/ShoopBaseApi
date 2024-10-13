using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IProduct
    {
      Task<IEnumerable<T_Product>> GetAllProductsAsync();
        public Task<T_Product> ChekProductAsync(long? ProductId, string? nameProduct);
        Task<T_Product> GetProductByIdAsync(long ProductId);
        Task AddProductAsync(T_Product product);
        Task DeleteProductAsync(long productId);
        Task SaveAsync();

    }
 
}
