using AutoMapper;
using BakuTech.Business.Abstractions.Services;
using BakuTech.Business.DTOs.Faqs;
using BakuTech.Core.Abstractions.UnitOfWork;
using BakuTech.Core.Entities;

namespace BakuTech.Business.Services;

public class FaqService : IFaqService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FaqService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<FaqDto>> GetAllAsync()
    {
        var faqs = await _unitOfWork.Faqs.GetAllAsync();

        return _mapper.Map<List<FaqDto>>(faqs);
    }

    public async Task<FaqDto?> GetByIdAsync(int id)
    {
        var faq = await _unitOfWork.Faqs.GetByIdAsync(id);

        if (faq == null)
            return null;

        return _mapper.Map<FaqDto>(faq);
    }

    public async Task CreateAsync(CreateFaqDto dto)
    {
        var faq = _mapper.Map<Faq>(dto);

        await _unitOfWork.Faqs.AddAsync(faq);

        await _unitOfWork.SaveChangesAsync();
    }

    public async Task UpdateAsync(UpdateFaqDto dto)
    {
        var faq = await _unitOfWork.Faqs.GetByIdAsync(dto.Id);

        if (faq == null)
            throw new KeyNotFoundException("FAQ not found.");

        _mapper.Map(dto, faq);

        await _unitOfWork.Faqs.UpdateAsync(faq);

        await _unitOfWork.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var faq = await _unitOfWork.Faqs.GetByIdAsync(id);

        if (faq == null)
            throw new KeyNotFoundException("FAQ not found.");

        await _unitOfWork.Faqs.DeleteAsync(faq);

        await _unitOfWork.SaveChangesAsync();
    }
}
