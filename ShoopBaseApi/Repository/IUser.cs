using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IUser
    {
       public Task<T_User>ChekUserAsync(string UserName,string Password);
       Task AddUserAsync(T_User user);
       Task<T_User> GetUserByIdAsync(long userId);
      Task<T_User> GetUserByUsernameAsync(string username);
      Task<T_User> GetUserByMobileAsync(string mobile); 

      Task SaveAsync();

    }
}
