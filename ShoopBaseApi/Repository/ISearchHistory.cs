using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface ISearchHistory
    {
        Task<IEnumerable<T_SearchHistory>> GetAllSearchHistoryAsync();
        Task<T_User?> GetSearchHistoryIdAsync(int SearchHistoryId);
        Task AddSearchHistoryAsynce(T_SearchHistory searchHistory);
        void DeletSearchHistoryAsynce(T_SearchHistory searchHistory);
    }
}
