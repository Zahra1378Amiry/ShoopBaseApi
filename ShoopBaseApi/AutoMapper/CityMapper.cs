using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;

namespace ShoopBaseApi.AutoMapper
{
    public class CityMapper : Profile
    {
        public CityMapper()
        {
            CreateMap<T_City, CityUpdateDto>();
            CreateMap<CityUpdateDto, T_City>();
            CreateMap<CityCreationDto, T_City>();
        }
    }
}
