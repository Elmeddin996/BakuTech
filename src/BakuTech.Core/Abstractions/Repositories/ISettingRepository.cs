using BakuTech.Core.Entities;

namespace BakuTech.Core.Abstractions.Repositories;

public interface ISettingRepository : IGenericRepository<Setting>
{
    Task<Setting?> GetSettingAsync();
}
