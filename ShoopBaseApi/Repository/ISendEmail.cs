using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface ISendEmail
    {
        Task<IEnumerable<T_SendEmail>> GetAllSendEmailAsync();
        Task<T_SendEmail?> GetSendEmailIdAsync(int SendEmailId);
        Task AddSendEmailAsynce(T_SendEmail sendEmail);
        void DeletSendEmailAsynce(T_SendEmail sendEmail);
    }
}
