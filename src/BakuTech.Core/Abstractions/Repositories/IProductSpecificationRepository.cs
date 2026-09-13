using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface IProductSpecificationRepository : IGenericRepository<ProductSpecification>
{
    Task<List<ProductSpecification>> GetByProductIdAsync(int productId);

    Task DeleteByProductIdAsync(int productId);
}
