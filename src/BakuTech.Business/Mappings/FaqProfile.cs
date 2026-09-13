using AutoMapper;
using BakuTech.Business.DTOs.Faqs;
using BakuTech.Core.Entities;

namespace BakuTech.Business.Mappings;

public class FaqProfile : Profile
{
    public FaqProfile()
    {
        CreateMap<Faq, FaqDto>();

        CreateMap<CreateFaqDto, Faq>();

        CreateMap<UpdateFaqDto, Faq>();
    }
}
