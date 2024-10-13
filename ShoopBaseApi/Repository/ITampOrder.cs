using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface ITampOrder
    {
        Task<IEnumerable<T_TampOrder>> GetAllTampOrderAsync();
        Task<T_TampOrder?> GetTampOrderIdAsync(int tampOrderId);
        Task AddTampOrderAsynce(T_TampOrder tampOrder);
        void DeletTampOrderAsynce(T_TampOrder tampOrder);
    }
}
