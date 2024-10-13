using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface ITampShoppingBasket
    {
        Task<IEnumerable<T_TampShoppingBasket>> GetAllTampShoppingBasketAsync();
        Task<T_TampShoppingBasket?> GetTampShoppingBasketIdAsync(int TampShoppingBasketId);
        Task AddTampShoppingBasketAsynce(T_TampShoppingBasket tampShoppingBasket);
        void DeletTampShoppingBasketAsynce(T_TampShoppingBasket tampShoppingBasket);
    }
}
