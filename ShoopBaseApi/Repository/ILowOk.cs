using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface ILowOk
    {
        Task<IEnumerable<T_LowOk>> GetAllLowOkAsync();
        Task<T_LowOk?> GetLowOkIdAsync(int LowOkId);
        Task AddLowOkAsynce(T_LowOk lowOk);
        void DeletLowOkAsynce(T_LowOk lowOk);
    }
}
