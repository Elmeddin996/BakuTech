using BakuTech.Core.Common.Pagination;
using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface IBrandRepository : IGenericRepository<Brand>
{
    Task<Brand?> GetBySlugAsync(string slug);
    Task<List<Brand>> GetActiveBrandsAsync();
    Task<PagedResult<Brand>> GetPagedAsync(PagedRequest request);
}
