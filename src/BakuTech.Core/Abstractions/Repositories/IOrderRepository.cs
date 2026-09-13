using BakuTech.Core.Common.Pagination;
using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface IOrderRepository : IGenericRepository<Order>
{
    Task<PagedResult<Order>> GetPagedAsync(
        PagedRequest request);

    Task<Order?> GetByIdWithItemsAsync(int id);
}
