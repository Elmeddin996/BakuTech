using AutoMapper;
using BakuTech.Business.DTOs.Pages;
using BakuTech.Core.Entities;

namespace BakuTech.Business.Mappings;

public sealed class PageProfile : Profile
{
    public PageProfile()
    {
        CreateMap<Page, PageListDto>();

        CreateMap<Page, PageDetailDto>();

        CreateMap<CreatePageDto, Page>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.IsActive, opt => opt.Ignore())
            .ForMember(dest => dest.IsDeleted, opt => opt.Ignore());

        CreateMap<UpdatePageDto, Page>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.IsActive, opt => opt.Ignore())
            .ForMember(dest => dest.IsDeleted, opt => opt.Ignore());
    }
}
