using BakuTech.Core.Abstractions.Repositories;
using BakuTech.Core.Entities;
using BakuTech.Data.Context;

namespace BakuTech.Data.Repositories;

public class FaqRepository : GenericRepository<Faq>, IFaqRepository
{
    public FaqRepository(ApplicationDbContext context)
        : base(context)
    {
    }
}
