using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;

namespace ShoopBaseApi.AutoMapper
{
    public class SearchHistoryMapper : Profile
    {
        public SearchHistoryMapper()
        {
            CreateMap<T_SearchHistory, SearchHistoryUpdateDto>();
            CreateMap<SearchHistoryUpdateDto, T_Product>();
            CreateMap<SearchHistoryCreationDto, T_SearchHistory>();
        }
    }
}
