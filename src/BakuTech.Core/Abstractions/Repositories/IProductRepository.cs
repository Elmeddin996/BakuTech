using BakuTech.Core.Common.Filters;
using BakuTech.Core.Common.Pagination;
using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<List<Product>> GetFeaturedProductsAsync();

    Task<List<Product>> GetNewProductsAsync();

    Task<Product?> GetBySlugAsync(string slug);
    Task<PagedResult<Product>> SearchAsync(
     string search,
     int? categoryId,
     PagedRequest request);

    Task<PagedResult<Product>> GetByCategoryIdsAsync(
    IReadOnlyCollection<int> categoryIds,
    ProductFilterRequest filter,
    PagedRequest request);


    Task<ProductFilterOptions> GetFilterOptionsAsync(
        IReadOnlyCollection<int> categoryIds);

    Task<List<Product>> GetNewProductsAsync(int count);
}
