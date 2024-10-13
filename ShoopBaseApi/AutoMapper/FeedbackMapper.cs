using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;

namespace ShoopBaseApi.AutoMapper
{
    public class FeedbackMapper : Profile
    {
        public FeedbackMapper()
        {
            CreateMap<T_Feedback, FeedbackUpdateDto>();
            CreateMap<FeedbackUpdateDto, FeedbackUpdateDto>();
            CreateMap<FeedbackCreationDto, T_Feedback>();
        }
    }
}
