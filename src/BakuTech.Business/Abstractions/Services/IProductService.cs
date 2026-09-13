using BakuTech.Business.DTOs.Products;
using BakuTech.Core.Common.Filters;
using BakuTech.Core.Common.Pagination;

namespace BakuTech.Business.Abstractions.Services;

public interface IProductService
{
    Task<List<ProductListDto>> GetAllAsync();

    Task<ProductDetailDto?> GetByIdAsync(int id);

    Task<ProductDetailDto?> GetBySlugAsync(string slug);

    Task<int> CreateAsync(CreateProductDto dto);

    Task UpdateAsync(UpdateProductDto dto);

    Task DeleteAsync(int id);

    Task<bool> ExistsAsync(int id);
    Task<PagedResult<ProductListDto>> SearchAsync(
     string search,
     int? categoryId,
     PagedRequest request);

    Task<PagedResult<ProductListDto>> GetByCategoryIdsAsync(
        IReadOnlyCollection<int> categoryIds,
        ProductFilterRequest filter,
        PagedRequest request);


    Task<ProductFilterOptionsDto> GetFilterOptionsAsync(
       IReadOnlyCollection<int> categoryIds);

    Task<List<ProductListDto>> GetNewProductsAsync(int count);

}
