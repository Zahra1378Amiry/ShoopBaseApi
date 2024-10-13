using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;


namespace ShoopBaseApi.AutoMapper
{
    public class OstanMapper : Profile
    {
        public OstanMapper()
        {
            CreateMap<T_Ostan, OstanUpdateDto>();
            CreateMap<OstanUpdateDto, T_Ostan>();
            CreateMap<OstanCreationDto, T_Ostan>();
        }
    }
}
