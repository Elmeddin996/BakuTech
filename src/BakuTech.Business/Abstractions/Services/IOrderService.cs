using BakuTech.Business.DTOs.Orders;
using BakuTech.Core.Common.Pagination;

namespace BakuTech.Business.Abstractions.Services;

public interface IOrderService
{
    Task<int> CreateAsync(CreateOrderDto dto);

    Task<PagedResult<OrderListDto>> GetPagedAsync(
        PagedRequest request);

    Task<OrderDetailDto?> GetByIdAsync(int id);

    Task UpdateStatusAsync(
        int id,
        string status);
}
