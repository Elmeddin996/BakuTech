using AutoMapper;
using BakuTech.Business.DTOs.Settings;
using BakuTech.Core.Entities;

namespace BakuTech.Business.Mappings;

public sealed class SettingProfile : Profile
{
    public SettingProfile()
    {
        CreateMap<Setting, SettingDetailDto>();

        CreateMap<UpdateSettingDto, Setting>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.IsActive, opt => opt.Ignore())
            .ForMember(dest => dest.IsDeleted, opt => opt.Ignore());
    }
}
