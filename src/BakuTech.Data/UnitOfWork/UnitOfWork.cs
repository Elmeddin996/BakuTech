using BakuTech.Core.Abstractions.Repositories;
using BakuTech.Core.Abstractions.UnitOfWork;
using BakuTech.Core.Entities;
using BakuTech.Data.Context;

namespace BakuTech.Data.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(
        ApplicationDbContext context,
        IProductRepository productRepository,
        IOrderRepository orderRepository,
        ICategoryRepository categoryRepository,
        IBrandRepository brandRepository,
        IBranchRepository branchRepository,
        INewsRepository newsRepository,
        IPageRepository pageRepository,
        ISliderRepository sliderRepository,
        IMiniSliderRepository miniSliderRepository,
        IMobileSliderRepository mobileSliderRepository,
        ISettingRepository settingRepository,
        IFaqRepository faqRepository,
        ISubscriberRepository subscriberRepository,
        IContactMessageRepository contactMessageRepository,
        ISpecificationGroupRepository specificationGroupRepository,
        ISpecificationRepository specificationRepository,
        IProductImageRepository productImageRepository,
        IProductSpecificationRepository productSpecificationRepository)
    {
        _context = context;

        Products = productRepository;
        Orders = orderRepository;
        ProductImages = productImageRepository;
        ProductSpecifications = productSpecificationRepository;

        Categories = categoryRepository;
        Brands = brandRepository;
        Branches = branchRepository;

        SpecificationGroups = specificationGroupRepository;
        Specifications = specificationRepository;

        News = newsRepository;
        Pages = pageRepository;

        Sliders = sliderRepository;
        MiniSliders = miniSliderRepository;
        MobileSliders = mobileSliderRepository;

        Settings = settingRepository;
        Faqs = faqRepository;
        Subscribers = subscriberRepository;
        ContactMessages = contactMessageRepository;
    }

    public IProductRepository Products { get; }

    public IOrderRepository Orders { get; }

    public IProductImageRepository ProductImages { get; }

    public IProductSpecificationRepository ProductSpecifications { get; }

    public ISpecificationGroupRepository SpecificationGroups { get; }

    public ISpecificationRepository Specifications { get; }

    public ICategoryRepository Categories { get; }

    public IBrandRepository Brands { get; }

    public IBranchRepository Branches { get; }

    public INewsRepository News { get; }

    public IPageRepository Pages { get; }

    public ISliderRepository Sliders { get; }

    public IMiniSliderRepository MiniSliders { get; }

    public IMobileSliderRepository MobileSliders { get; }

    public ISettingRepository Settings { get; }
    public IFaqRepository Faqs { get; }

    public ISubscriberRepository Subscribers { get; }

    public IContactMessageRepository ContactMessages { get; }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
