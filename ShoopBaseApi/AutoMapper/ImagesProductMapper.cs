using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;


namespace ShoopBaseApi.AutoMapper
{
    public class ImagesProductMapper : Profile
    {
        public ImagesProductMapper()
        {
            CreateMap<T_ImagesProduct, ImagesProductUpdateDto>();
            CreateMap<ImagesProductUpdateDto, T_ImagesProduct>();
            CreateMap<ImagesProductCreationDto, T_ImagesProduct>();
        }
    }
}
