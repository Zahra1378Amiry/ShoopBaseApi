using Microsoft.EntityFrameworkCore;
using ShoopBaseApi.Contxt;
using ShoopBaseApi.Models;
using ShoopBaseApi.Repository;

namespace ShoopBaseApi.Services
{
    public class ProductServices : IProduct
    {
        private readonly ShoopBaseContxt _context;
        public ProductServices(ShoopBaseContxt context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task AddProductAsync(T_Product product)
        {
            await _context.T_Product.AddAsync(product);
        }

        public async Task<T_Product> ChekProductAsync(long? productId, string? nameProduct)
        {
            return await _context.T_Product
                .FirstOrDefaultAsync(p =>
                    (productId == null || p.ID_Product == productId) &&
                    (string.IsNullOrEmpty(nameProduct) || p.NameProduct == nameProduct));
        }

        public async Task DeleteProductAsync(long productId)
        {
            var product = await _context.T_Product.FindAsync(productId); 
            if (product != null)
            {
                _context.T_Product.Remove(product);
            }
        }

        public async Task<IEnumerable<T_Product>> GetAllProductsAsync()
        {
            return await _context.T_Product.ToListAsync();
        }

        public async Task<T_Product> GetProductByIdAsync(long ProductId)
        {
            return await _context.T_Product.FindAsync(ProductId);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

       
    }
}
