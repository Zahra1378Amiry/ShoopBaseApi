using ShoopBaseApi.Models;

namespace ShoopBaseApi.Repository
{
    public interface IImagesProduct
    {
        Task<IEnumerable<T_ImagesProduct>> GetAllImagesProductAsync();
        Task<T_ImagesProduct?> GetImagesProductIdAsync(int ImagesProductId);
        Task AddImagesProductAsynce(T_ImagesProduct imagesProduct);
        void DeletImagesProductAsynce(T_ImagesProduct imagesProduct);
    }
}
