using BakuTech.Business.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace BakuTech.Web.Controllers;

public class FaqController : Controller
{
    private readonly IFaqService _faqService;

    public FaqController(IFaqService faqService)
    {
        _faqService = faqService;
    }

    public async Task<IActionResult> Index()
    {
        var faqs = await _faqService.GetAllAsync();

        faqs = faqs
            .Where(x => x.IsActive)
            .OrderBy(x => x.DisplayOrder)
            .ThenBy(x => x.Id)
            .ToList();

        return View(faqs);
    }
}
