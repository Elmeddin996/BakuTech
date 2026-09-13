using BakuTech.Business.DTOs.Faqs;

namespace BakuTech.Business.Abstractions.Services;

public interface IFaqService
{
    Task<List<FaqDto>> GetAllAsync();

    Task<FaqDto?> GetByIdAsync(int id);

    Task CreateAsync(CreateFaqDto dto);

    Task UpdateAsync(UpdateFaqDto dto);

    Task DeleteAsync(int id);
}
