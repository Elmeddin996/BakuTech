using AutoMapper;
using BakuTech.Business.DTOs.Orders;
using BakuTech.Core.Entities;

namespace BakuTech.Business.Mapping;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Order, OrderListDto>();

        CreateMap<Order, OrderDetailDto>()
            .ForMember(
                dest => dest.Items,
                opt => opt.MapFrom(src => src.OrderItems));

        CreateMap<OrderItem, OrderItemDto>()
            .ForMember(
                dest => dest.ProductName,
                opt => opt.MapFrom(src => src.Product.NameAz))
            .ForMember(
                dest => dest.ProductCode,
                opt => opt.MapFrom(src => src.Product.Code));
    }
}
