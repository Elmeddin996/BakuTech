using BakuTech.Business.DTOs.ProductSpecifications;

namespace BakuTech.Business.Abstractions.Services;

public interface IProductSpecificationService
{
    Task<List<ProductSpecificationDto>> GetByProductIdAsync(int productId);

    Task UpdateAsync(
        int productId,
        List<UpdateProductSpecificationDto> specifications);
}
