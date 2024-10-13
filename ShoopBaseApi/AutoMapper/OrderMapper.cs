using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;


namespace ShoopBaseApi.AutoMapper
{
    public class OrderMapper : Profile
    {
        public OrderMapper()
        {
            CreateMap<T_Order, OrderUpdateDto>();
            CreateMap<OrderUpdateDto, T_Order>();
            CreateMap<OrderCreationDto, T_Order>();
              

        }

    }
}
