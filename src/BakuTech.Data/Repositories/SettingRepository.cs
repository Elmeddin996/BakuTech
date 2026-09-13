using Microsoft.EntityFrameworkCore;
using BakuTech.Core.Abstractions.Repositories;
using BakuTech.Core.Entities;
using BakuTech.Data.Context;

namespace BakuTech.Data.Repositories;

public class SettingRepository
    : GenericRepository<Setting>,
      ISettingRepository
{
    public SettingRepository(ApplicationDbContext context)
        : base(context)
    {
    }

    public async Task<Setting?> GetSettingAsync()
    {
        return await DbSet
            .FirstOrDefaultAsync(x => !x.IsDeleted);
    }
}
