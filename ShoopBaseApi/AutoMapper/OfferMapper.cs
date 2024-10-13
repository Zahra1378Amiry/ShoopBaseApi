using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;

namespace ShoopBaseApi.AutoMapper
{
    public class OfferMapper : Profile
    {
        public OfferMapper()
        {
            CreateMap<T_Offer, OfferUpdateDto>();
            CreateMap<OfferUpdateDto, T_Offer>();
            CreateMap<OfferCreationDto, T_Offer>();
        }
    }
}
