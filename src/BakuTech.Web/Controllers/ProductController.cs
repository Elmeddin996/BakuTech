
using Microsoft.AspNetCore.Mvc;
using BakuTech.Business.Abstractions.Services;

namespace BakuTech.Web.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;

    public ProductController(
        IProductService productService,
        ICategoryService categoryService)
    {
        _productService = productService;
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> Index(string slug)
    {
        if (string.IsNullOrWhiteSpace(slug))
            return NotFound();

        var product = await _productService.GetBySlugAsync(slug);

        if (product == null)
            return NotFound();

        ViewData["Category"] =
            await _categoryService.GetByIdAsync(product.CategoryId);

        return View(product);
    }
}
