using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IOstan
    {
        Task<IEnumerable<T_Ostan>> GetAllOstanAsync();
        Task<T_Ostan?> GetOstanIdAsync(int OstanId);
        Task AddOstanAsynce(T_Ostan ostan);
        void DeletOstanAsynce(T_Ostan ostan);
    }
}
