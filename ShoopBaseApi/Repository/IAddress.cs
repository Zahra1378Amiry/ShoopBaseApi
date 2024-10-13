using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IAddress
    {
        Task<IEnumerable<T_Address>> GetAllAddressAsync();
        Task<T_Address?> GetAddressIdAsync(int AddressId);
        Task AddAddressAsynce(T_Address address);
        void DeletAddressAsynce(T_Address address);
    }
}
