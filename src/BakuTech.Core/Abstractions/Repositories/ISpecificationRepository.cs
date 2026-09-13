using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface ISpecificationRepository : IGenericRepository<Specification>
{
    Task<List<Specification>> GetForProductAsync(int productId);
}
