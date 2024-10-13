using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IShoppingBasket
    {
        Task<IEnumerable<T_ShoppingBasket>> GetAllShoppingBasketAsync();
        Task<T_ShoppingBasket?> GetShoppingBasketIdAsync(int ShoppingBasketId);
        Task AddShoppingBasketAsynce(T_ShoppingBasket shoppingBasket);
        void DeletShoppingBasketAsynce(T_ShoppingBasket shoppingBasket);
    }
}
