using AutoMapper;
using BakuTech.Business.DTOs.Sliders;
using BakuTech.Core.Entities;

namespace BakuTech.Business.Mappings;

public sealed class SliderProfile : Profile
{
    public SliderProfile()
    {
        CreateMap<Slider, SliderListDto>();

        CreateMap<Slider, SliderDetailDto>();

        CreateMap<CreateSliderDto, Slider>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.IsDeleted, opt => opt.Ignore());

        CreateMap<UpdateSliderDto, Slider>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.IsDeleted, opt => opt.Ignore());
    }
}
