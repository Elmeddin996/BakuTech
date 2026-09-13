using Microsoft.EntityFrameworkCore;
using BakuTech.Core.Abstractions.Repositories;
using BakuTech.Core.Entities;
using BakuTech.Data.Context;

namespace BakuTech.Data.Repositories;

public class SubscriberRepository : GenericRepository<Subscriber>, ISubscriberRepository
{
    public SubscriberRepository(ApplicationDbContext context)
        : base(context)
    {
    }

    public async Task<Subscriber?> GetByEmailAsync(string email)
    {
        return await DbSet
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.Email == email);
    }

    public async Task<bool> ExistsByEmailAsync(string email)
    {
        return await DbSet
            .AsNoTracking()
            .AnyAsync(s => s.Email == email);
    }
}
