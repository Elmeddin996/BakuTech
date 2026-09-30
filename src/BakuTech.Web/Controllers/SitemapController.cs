using System.Security;
using BakuTech.Business.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace BakuTech.Web.Controllers;

public class SitemapController : Controller
{
    private readonly ICategoryService _categoryService;
    private readonly IProductService _productService;
    private readonly IFaqService _faqService;

    public SitemapController(
        ICategoryService categoryService,
        IProductService productService,
        IFaqService faqService)
    {
        _categoryService = categoryService;
        _productService = productService;
        _faqService = faqService;
    }

    [HttpGet("/sitemap.xml")]
    public async Task<IActionResult> Index()
    {
        var baseUrl = $"{Request.Scheme}://{Request.Host}";

        var categories = await _categoryService.GetAllAsync();
        var products = await _productService.GetAllAsync();
        var faqs = await _faqService.GetAllAsync();

        var urls = new List<string>
        {
            baseUrl
        };

        // Categories
        foreach (var category in categories.Where(x => x.IsActive))
        {
            if (!string.IsNullOrWhiteSpace(category.SlugAz))
                urls.Add($"{baseUrl}/az/{category.SlugAz}");

            if (!string.IsNullOrWhiteSpace(category.SlugEn))
                urls.Add($"{baseUrl}/en/{category.SlugEn}");

            if (!string.IsNullOrWhiteSpace(category.SlugRu))
                urls.Add($"{baseUrl}/ru/{category.SlugRu}");
        }

        // Products
        foreach (var product in products.Where(x => x.IsActive))
        {
            if (!string.IsNullOrWhiteSpace(product.SlugAz))
                urls.Add($"{baseUrl}/Product/{product.SlugAz}");

            if (!string.IsNullOrWhiteSpace(product.SlugEn))
                urls.Add($"{baseUrl}/Product/{product.SlugEn}");

            if (!string.IsNullOrWhiteSpace(product.SlugRu))
                urls.Add($"{baseUrl}/Product/{product.SlugRu}");
        }

        // FAQ
        if (faqs.Any())
        {
            urls.Add($"{baseUrl}/az/faq");
            urls.Add($"{baseUrl}/en/faq");
            urls.Add($"{baseUrl}/ru/faq");
        }

        var xml = $"""
            <?xml version="1.0" encoding="UTF-8"?>
            <urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">
            {string.Join(Environment.NewLine, urls.Distinct().Select(url => $"""
                <url>
                    <loc>{SecurityElement.Escape(url)}</loc>
                </url>
            """))}
            </urlset>
            """;

        return Content(xml, "application/xml");
    }
}
