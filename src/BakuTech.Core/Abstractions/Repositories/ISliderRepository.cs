using BakuTech.Core.Common.Pagination;
using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface ISliderRepository : IGenericRepository<Slider>
{
    Task<PagedResult<Slider>> GetPagedAsync(PagedRequest request);

    Task<List<Slider>> GetActiveSlidersAsync();
}
