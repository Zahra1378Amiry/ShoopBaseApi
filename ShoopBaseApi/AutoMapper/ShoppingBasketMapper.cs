using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;

namespace ShoopBaseApi.AutoMapper
{
    public class ShoppingBasketMapper : Profile
    {
        public ShoppingBasketMapper()
        {
            CreateMap<T_ShoppingBasket, ShoppingBasketUpdateDto>();
            CreateMap<ShoppingBasketUpdateDto, T_ShoppingBasket>();
            CreateMap<ShoppingBasketCreationDto, T_ShoppingBasket>();
        }

    }
}
