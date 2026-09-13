using Microsoft.EntityFrameworkCore;
using BakuTech.Core.Abstractions.Repositories;
using BakuTech.Core.Entities;
using BakuTech.Data.Context;

namespace BakuTech.Data.Repositories;

public class ProductSpecificationRepository
    : GenericRepository<ProductSpecification>,
      IProductSpecificationRepository
{
    public ProductSpecificationRepository(ApplicationDbContext context)
        : base(context)
    {
    }

    public async Task<List<ProductSpecification>> GetByProductIdAsync(int productId)
    {
        return await DbSet
            .Where(x => x.ProductId == productId && !x.IsDeleted)
            .ToListAsync();
    }

    public async Task DeleteByProductIdAsync(int productId)
    {
        var specifications = await DbSet
            .Where(x => x.ProductId == productId && !x.IsDeleted)
            .ToListAsync();

        DbSet.RemoveRange(specifications);
    }
}
