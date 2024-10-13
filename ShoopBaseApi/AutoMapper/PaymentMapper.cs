using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;

namespace ShoopBaseApi.AutoMapper
{
    public class PaymentMapper : Profile
    {
        public PaymentMapper()
        {
            CreateMap<T_Payment, PaymentUpdateDto>();
            CreateMap<PaymentUpdateDto, T_Payment>();
            CreateMap<PaymentCreationDto, T_Payment>();
        }
    }
}
