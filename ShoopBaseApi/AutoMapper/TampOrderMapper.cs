using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;


namespace ShoopBaseApi.AutoMapper
{
    public class TampOrderMapper : Profile
    {
        public TampOrderMapper()
        {
            CreateMap<T_TampOrder, TampOrderUpdateDto>();
            CreateMap<TampOrderUpdateDto, T_TampOrder>();
            CreateMap<TampOrderCreationDto, T_TampOrder>();
        }
    }
}
