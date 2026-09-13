using BakuTech.Business.DTOs.Settings;

namespace BakuTech.Business.Abstractions.Services;

public interface ISettingService
{
    Task<SettingDetailDto?> GetAsync();

    Task UpdateAsync(UpdateSettingDto dto);
}
