using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;


namespace ShoopBaseApi.AutoMapper
{
    public class TampShoppingBasketMapper : Profile
    {
        public TampShoppingBasketMapper()
        {
            CreateMap<T_TampShoppingBasket, TampShoppingBasketUpdateDto>();
            CreateMap<TampShoppingBasketUpdateDto, T_TampShoppingBasket>();
            CreateMap<TampShoppingBasketUpdateDto, T_TampShoppingBasket>();
        }
    }
}
