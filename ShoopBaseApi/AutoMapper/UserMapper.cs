using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;

namespace ShoopBaseApi.AutoMapper
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<T_User, UserUpdateDto>();
            CreateMap<UserUpdateDto, T_User>();
            CreateMap<UserCreationDto, T_User>();
        }
    }
}
