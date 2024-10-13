using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using ShoopBaseApi.Repository;
using ShoopBaseApi.DTo;
using ShoopBaseApi.Models;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProduct _product;
    private readonly IMapper _mapper;
    private readonly ILogger<ProductController> _logger;

    public ProductController(IProduct product, IMapper mapper, ILogger<ProductController> logger)
    {
        _product = product ?? throw new ArgumentNullException(nameof(product));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }



    #region Get list
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductResponseDto>>> GetProducts()
    {
        try
        {
            var products = await _product.GetAllProductsAsync();


            if (products == null || !products.Any())
            {
                return NotFound(new ResponseDto
                {
                    Status = 404,
                    Message = "محصولی یافت نشد",
                    IsSuccess = false
                });
            }


            var productsDto = _mapper.Map<IEnumerable<ProductResponseDto>>(products);


            return Ok(new ResponseDto
            {
                Status = 200,
                Message = "لیست محصولات با موفقیت دریافت شد",
                IsSuccess = true,


            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "خطایی در دریافت محصولات رخ داد.");

            return StatusCode(500, new ErrorDto
            {
                Message = "خطایی در دریافت محصولات رخ داد.",
                Success = false
            });
        }
    }
    #endregion
    #region Get

    [HttpGet("search")]
    public async Task<ActionResult<ProductResponseDto>> GetProduct(long? productId, string? nameproduct)
    {
        try
        {
            if (productId == null && string.IsNullOrWhiteSpace(nameproduct))
            {
                return BadRequest(new ResponseDto
                {
                    Status = 400,
                    Message = "لطفاً یا شناسه محصول یا نام محصول را وارد کنید",
                    IsSuccess = false,
                });
            }

            var product = await _product.ChekProductAsync(productId, nameproduct);

            if (product == null)
            {
                return NotFound(new ResponseDto
                {
                    Status = 404,
                    Message = "محصول پیدا نشد",
                    IsSuccess = false,
                });
            }

            var success = new ProductResponseDto
            {
                Status = 200,
                Message = "محصول با موفقیت پیدا شد",
                IsSuccess = true,
                ID_Product = product.ID_Product,
                Name = product.NameProduct,
                Description = product.Description,
                Price = product.Price,
                C_Product = product.C_Product,
                CreatedAt = product.CreatedAt,
                T_Category_Id = product.T_Category_Id,
                ISActive = true,
            };

            return Ok(success);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "خطا رخ داد.");
            return StatusCode(500, new ErrorDto
            {
                Message = "خطا رخ داد.",
                Success = false,
            });
            

        }
    }
    #endregion

    #region Add Product

    [HttpPost]
    [Authorize(Roles = "Admin")] // فقط ادمین می‌تواند محصول اضافه کند
    public async Task<ActionResult<ProductResponseDto>> CreateProduct(ProductCreationDto productCreationDto)
    {
        try
        {
        

            var existingProduct = await _product.GetProductByIdAsync(productCreationDto.ID_Product);
            if (existingProduct != null)
            {
                var error = new NotFoundDto
                {
                    Status = 404,
                    Message = "محصولی با این شناسه ثبت شده است",
                    IsSuccess = false,
                };
                return NotFound(error);
            }

        
            var newProduct = _mapper.Map<T_Product>(productCreationDto);
            await _product.AddProductAsync(newProduct);
            await _product.SaveAsync();

         
            var success = new ProductResponseDto
            {
                Status = 201, 
                Message = "محصول با موفقیت اضافه شد",
                IsSuccess = true,
                ID_Product = newProduct.ID_Product,
                Name = newProduct.NameProduct,
                Description = newProduct.Description,
                Price = newProduct.Price,
                C_Product = newProduct.C_Product,
                CreatedAt = newProduct.CreatedAt,
                T_Category_Id = newProduct.T_Category_Id,
                ISActive = true,
            };

            return CreatedAtAction(nameof(GetProduct), new { id = newProduct.ID_Product }, success);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "خطا رخ داد.");
            return StatusCode(500, new ErrorDto
            {
                Message = "خطا رخ داد.",
                Success = false,
            });
        }
    }

    #endregion

    #region Update Product

    [HttpPut]
    [Authorize(Roles = "Admin")] // فقط ادمین می‌تواند محصول ویرایش کند
    public async Task<ActionResult> UpdateProduct(long productId, ProductUpdateDto productUpdateDto)
    {
        try
        {
            var product = await _product.GetProductByIdAsync(productId);
            if (product == null)
            {
                var error = new NotFoundDto
                {
                    Status = 404,
                    Message = "محصول پیدا نشد",
                    IsSuccess = false,
                };
                return NotFound(error);
            }

            _mapper.Map(productUpdateDto, product);
            await _product.SaveAsync();

            var success = new ResponseDto
            {
                Status = 200,
                Message = "محصول با موفقیت به‌روزرسانی شد",
                IsSuccess = true,
            };

            return Ok(success);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "an error occurred.");
            var error = new ErrorDto
            {
                Message = "خطا رخ داد.",
                Success = false,
            };
            return BadRequest(error);
        }
    }

    #endregion

    #region Delete Product

    [HttpDelete]
    [Authorize(Roles = "Admin")] // فقط ادمین می‌تواند محصول حذف کند
    public async Task<ActionResult> DeleteProduct(long productId)
    {
        try
        {
            var product = await _product.GetProductByIdAsync(productId);
            if (product == null)
            {
                var error = new NotFoundDto
                {
                    Status = 404,
                    Message = "محصول پیدا نشد",
                    IsSuccess = false,
                };
                return NotFound(error);
            }

            await _product.DeleteProductAsync(productId);
            await _product.SaveAsync();

            var success = new ResponseDto
            {
                Status = 200,
                Message = "محصول با موفقیت حذف شد",
                IsSuccess = true,
            };

            return Ok(success);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "an error occurred.");
            var error = new ErrorDto
            {
                Message = "خطا رخ داد.",
                Success = false,
            };
            return BadRequest(error);
        }
    }

    #endregion
}
