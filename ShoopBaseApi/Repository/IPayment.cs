using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IPayment
    {
        Task<IEnumerable<T_Payment>> GetAllPaymentAsync();
        Task<T_Payment?> GetPaymentIdAsync(int PaymentId);
        Task AddPaymentAsynce(T_Payment payment);
        void DeletPaymentAsynce(T_Payment payment);
    }
}
