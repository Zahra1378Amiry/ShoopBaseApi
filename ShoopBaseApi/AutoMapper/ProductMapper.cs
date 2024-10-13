using AutoMapper;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;

namespace ShoopBaseApi.AutoMapper
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<T_Product, ProductUpdateDto>();
            CreateMap<ProductUpdateDto, T_Product>();
            CreateMap<ProductCreationDto, T_Product>();
            CreateMap<T_Product, ProductResponseDto>();
        }
    }
}
