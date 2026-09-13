using BakuTech.Core.Common.Pagination;
using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface IMobileSliderRepository : IGenericRepository<MobileSlider>
{
    Task<List<MobileSlider>> GetActiveAsync();

    Task<PagedResult<MobileSlider>> GetPagedAsync(
        PagedRequest request);
}
