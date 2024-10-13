using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface ICity
    {
        Task<IEnumerable<T_City>> GetAllCityAsync();
        Task<T_City?> GetCityIdAsync(int CityId);
        Task AddCityAsynce(T_City city);
        void DeletCityAsynce(T_City city);
    }
}
