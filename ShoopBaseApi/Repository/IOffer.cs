using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IOffer
    {
        Task<IEnumerable<T_Offer>> GetAllOfferAsync();
        Task<T_Offer?> GetOfferIdAsync(int OfferId);
        Task AddOfferAsynce(T_Offer offer);
        void DeletOfferAsynce(T_Offer offer);
    }
}
