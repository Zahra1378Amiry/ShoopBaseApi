using ShoopBaseApi.Models;

namespace ShoopBaseApi.DTo
{
    public class ProductResponseDto
    {
        public int Status { get; set; }        
        public string Message { get; set; }    
        public bool IsSuccess { get; set; }    
        public long ID_Product { get; set; }  
        public string Name { get; set; }       
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? C_Product { get; set; }
        public int? T_Category_Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? ISActive { get; set; }
        
    }
}

