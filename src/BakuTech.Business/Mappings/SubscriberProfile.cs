using AutoMapper;
using BakuTech.Business.DTOs.Subscribers;
using BakuTech.Core.Entities;

namespace BakuTech.Business.Mappings;

public sealed class SubscriberProfile : Profile
{
    public SubscriberProfile()
    {
        CreateMap<Subscriber, SubscriberDto>();

        CreateMap<UpdateSubscriberDto, Subscriber>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.IsActive, opt => opt.Ignore())
            .ForMember(dest => dest.IsDeleted, opt => opt.Ignore());
    }
}
