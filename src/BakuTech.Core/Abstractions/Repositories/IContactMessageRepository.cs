using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface IContactMessageRepository : IGenericRepository<ContactMessage>
{
    Task<List<ContactMessage>> GetUnreadMessagesAsync();
}
