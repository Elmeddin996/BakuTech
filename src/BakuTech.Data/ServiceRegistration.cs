using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BakuTech.Core.Abstractions.Repositories;
using BakuTech.Core.Abstractions.UnitOfWork;
using BakuTech.Data.Context;
using BakuTech.Data.Repositories;

namespace BakuTech.Data;

public static class ServiceRegistration
{
    public static IServiceCollection AddDataServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        // Generic Repository
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        // Repositories
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IBranchRepository, BranchRepository>();
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<INewsRepository, NewsRepository>();
        services.AddScoped<IPageRepository, PageRepository>();
        services.AddScoped<ISliderRepository, SliderRepository>();
        services.AddScoped<IMiniSliderRepository, MiniSliderRepository>();
        services.AddScoped<IMobileSliderRepository, MobileSliderRepository>();
        services.AddScoped<ISettingRepository, SettingRepository>();
        services.AddScoped<ISubscriberRepository, SubscriberRepository>();
        services.AddScoped<IContactMessageRepository, ContactMessageRepository>();
        services.AddScoped<IProductImageRepository, ProductImageRepository>();
        services.AddScoped<ISpecificationGroupRepository, SpecificationGroupRepository>();
        services.AddScoped<ISpecificationRepository, SpecificationRepository>();
        services.AddScoped<IProductSpecificationRepository, ProductSpecificationRepository>();
        services.AddScoped<IFaqRepository, FaqRepository>();
        // Unit of Work
        services.AddScoped<IUnitOfWork, BakuTech.Data.UnitOfWork.UnitOfWork>();

        return services;
    }
}
