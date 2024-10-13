using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;


namespace ShoopBaseApi.AutoMapper
{
    public class SendEmailMapper : Profile
    {
        public SendEmailMapper()
        {
            CreateMap<T_SendEmail, SendEmailUpdateDto>();
            CreateMap<SendEmailUpdateDto, T_SendEmail>();
            CreateMap<SendEmailCreationDto, T_SendEmail>();
        }
    }
}
