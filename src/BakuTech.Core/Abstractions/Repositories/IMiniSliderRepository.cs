using BakuTech.Core.Common.Pagination;
using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface IMiniSliderRepository : IGenericRepository<MiniSlider>
{
    Task<List<MiniSlider>> GetActiveAsync();

    Task<PagedResult<MiniSlider>> GetPagedAsync(PagedRequest request);
}
