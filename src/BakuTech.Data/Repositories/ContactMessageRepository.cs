using Microsoft.EntityFrameworkCore;
using BakuTech.Core.Abstractions.Repositories;
using BakuTech.Core.Entities;
using BakuTech.Data.Context;

namespace BakuTech.Data.Repositories;

public class ContactMessageRepository : GenericRepository<ContactMessage>, IContactMessageRepository
{
    public ContactMessageRepository(ApplicationDbContext context)
        : base(context)
    {
    }

    public async Task<List<ContactMessage>> GetUnreadMessagesAsync()
    {
        return await DbSet
            .AsNoTracking()
            .Where(m => !m.IsRead)
            .OrderByDescending(m => m.CreatedDate)
            .ToListAsync();
    }
}
