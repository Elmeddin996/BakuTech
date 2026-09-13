using BakuTech.Business.DTOs.ProductImages;

namespace BakuTech.Business.Services;

public interface IProductImageService
{
    Task<List<ProductImageDto>> GetByProductIdAsync(int productId);

    Task UploadAsync(UploadProductImageDto dto);

    Task DeleteAsync(int imageId);

    Task SetMainImageAsync(int imageId);

    Task UpdateDisplayOrderAsync(List<UpdateProductImageOrderDto> dto);
    Task<ProductImageDto?> GetByIdAsync(int imageId);
}
