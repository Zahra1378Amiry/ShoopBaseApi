using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;


namespace ShoopBaseApi.AutoMapper
{
    public class LowOkMapper : Profile
    {
        public LowOkMapper()
        {
            CreateMap<T_LowOk, LowOkUpdateDto>();
            CreateMap<LowOkUpdateDto, T_LowOk>();
            CreateMap<LowOkCreationDto, T_LowOk>();
        }
    }
}
