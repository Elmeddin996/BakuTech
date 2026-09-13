using BakuTech.Core.Common.Pagination;
using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface IBranchRepository : IGenericRepository<Branch>
{
    Task<List<Branch>> GetAllActiveAsync();

    Task<PagedResult<Branch>> GetPagedAsync(PagedRequest request);

    Task<Branch?> GetByIdAsync(int id);
}
