using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface IPageRepository : IGenericRepository<Page>
{
    Task<Page?> GetBySlugAsync(string slug);
}
