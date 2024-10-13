using Microsoft.EntityFrameworkCore;
using ShoopBaseApi.Contxt;
using ShoopBaseApi.Models;
using ShoopBaseApi.Repository;

namespace ShoopBaseApi.Services
{
    public class UserServices : IUser
    {
        private readonly ShoopBaseContxt _context;
        public UserServices(ShoopBaseContxt context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));


        }

        public async Task AddUserAsync(T_User user)
        {
           await _context.T_User.AddAsync(user);
        }

        public async Task<T_User> ChekUserAsync(string UserName, string Password)
        {
            return await _context.T_User.FirstOrDefaultAsync(u => u.UserName == UserName && u.Password == Password );
        }

        public async Task<T_User> GetUserByIdAsync(long userId)
        {
            return await _context.T_User.FirstOrDefaultAsync(u => u.ID_User == userId && u.ISActive == true);
        }

        public async Task<T_User> GetUserByMobileAsync(string mobile)
        {
            return await _context.T_User.FirstOrDefaultAsync(u => u.Mobile == mobile && u.ISActive == true);
        }
    

        public async Task<T_User> GetUserByUsernameAsync(string username)
        {
        return await _context.T_User.FirstOrDefaultAsync(u => u.UserName == username && u.ISActive == true);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync(); 
        }
    }
}
