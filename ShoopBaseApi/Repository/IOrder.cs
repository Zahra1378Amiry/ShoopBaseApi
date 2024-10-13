using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IOrder
    {
        Task<IEnumerable<T_Order>> GetAllOrderAsync();
        Task<T_Order?> GetOrderIdAsync(int OrderId);
        Task AddOrderAsynce(T_Order order);
        void DeletOrderAsynce(T_Order order);
    }
}
