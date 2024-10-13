using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IFeedback
    {
        Task<IEnumerable<T_Feedback>> GetAllFeedbackAsync();
        Task<T_Feedback?> GetFeedbackIdAsync(int FeedbackId);
        Task AddFeedbackAsynce(T_Feedback feedback);
        void DeletFeedbackAsynce(T_Feedback feedback);
    }
}
