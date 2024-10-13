using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;

namespace ShoopBaseApi.AutoMapper
{
    public class AddressMapper:Profile
    {
        public AddressMapper()
        {
            CreateMap<T_Address, AddressUpdateDto>();
            CreateMap< AddressUpdateDto,T_Address>();
            CreateMap<T_Address, AddressCreationDto>().ReverseMap();
        }
    
    }
}
