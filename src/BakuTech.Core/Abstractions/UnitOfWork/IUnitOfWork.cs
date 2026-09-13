using BakuTech.Core.Abstractions.Repositories;

namespace BakuTech.Core.Abstractions.UnitOfWork;

public interface IUnitOfWork
{
    IProductRepository Products { get; }
    IOrderRepository Orders { get; }
    ICategoryRepository Categories { get; }
    IBrandRepository Brands { get; }
    IBranchRepository Branches { get; }
    INewsRepository News { get; }
    IFaqRepository Faqs { get; }
    IPageRepository Pages { get; }
    ISliderRepository Sliders { get; }
    IMiniSliderRepository MiniSliders { get; }
    IMobileSliderRepository MobileSliders { get; }
    ISettingRepository Settings { get; }
    ISubscriberRepository Subscribers { get; }
    IContactMessageRepository ContactMessages { get; }

    IProductImageRepository ProductImages { get; }
    ISpecificationGroupRepository SpecificationGroups { get; }
    ISpecificationRepository Specifications { get; }
    IProductSpecificationRepository ProductSpecifications { get; }

    Task<int> SaveChangesAsync();
}
