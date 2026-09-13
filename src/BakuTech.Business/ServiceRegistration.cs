using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using BakuTech.Business.Abstractions.Services;
using BakuTech.Business.Services;

namespace BakuTech.Business;

public static class ServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg => { }, typeof(ServiceRegistration).Assembly);
        services.AddValidatorsFromAssembly(typeof(ServiceRegistration).Assembly);

        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IBranchService, BranchService>();
        services.AddScoped<IBrandService, BrandService>();
        services.AddScoped<ISliderService, SliderService>();
        services.AddScoped<IMiniSliderService, MiniSliderService>();
        services.AddScoped<IMobileSliderService, MobileSliderService>();
        services.AddScoped<IProductImageService, ProductImageService>();
        services.AddScoped<ISpecificationGroupService, SpecificationGroupService>();
        services.AddScoped<ISpecificationService, SpecificationService>();
        services.AddScoped<IProductSpecificationService, ProductSpecificationService>();
        services.AddScoped<ISettingService, SettingService>();
        services.AddScoped<IFaqService, FaqService>();

        return services;
    }
}
