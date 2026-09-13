using BakuTech.Business.DTOs.Branches;
using BakuTech.Core.Common.Pagination;

namespace BakuTech.Business.Abstractions.Services;

public interface IBranchService
{
    Task<PagedResult<BranchListDto>> GetPagedAsync(PagedRequest request);

    Task<List<BranchListDto>> GetAllActiveAsync();

    Task<BranchListDto?> GetByIdAsync(int id);

    Task<int> CreateAsync(CreateBranchDto dto);

    Task<bool> UpdateAsync(UpdateBranchDto dto);

    Task<bool> DeleteAsync(int id);
}
