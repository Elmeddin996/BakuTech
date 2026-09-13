using Microsoft.AspNetCore.Mvc;
using BakuTech.Business.Abstractions.Services;
using BakuTech.Business.DTOs.Faqs;
using BakuTech.Web.Areas.Admin.ViewModels.Faqs;

namespace BakuTech.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class FaqController : BaseAdminController
{
    private readonly IFaqService _faqService;

    public FaqController(IFaqService faqService)
    {
        _faqService = faqService;
    }

    public async Task<IActionResult> Index()
    {
        ViewData["Title"] = "FAQ";

        var faqs = await _faqService.GetAllAsync();

        var orderedFaqs = faqs
            .OrderBy(x => x.DisplayOrder)
            .ThenBy(x => x.Id)
            .ToList();

        return View(orderedFaqs);
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewData["Title"] = "Create FAQ";

        return View(new CreateFaqViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateFaqViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        try
        {
            await _faqService.CreateAsync(model.Faq);

            TempData["Success"] = "FAQ created successfully.";

            return RedirectToAction(nameof(Index));
        }
        catch (InvalidOperationException ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);

            return View(model);
        }
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var faq = await _faqService.GetByIdAsync(id);

        if (faq == null)
            return NotFound();

        var model = new EditFaqViewModel
        {
            Faq = new UpdateFaqDto
            {
                Id = faq.Id,

                QuestionAz = faq.QuestionAz,
                QuestionEn = faq.QuestionEn,
                QuestionRu = faq.QuestionRu,

                AnswerAz = faq.AnswerAz,
                AnswerEn = faq.AnswerEn,
                AnswerRu = faq.AnswerRu,

                DisplayOrder = faq.DisplayOrder,
                IsActive = faq.IsActive
            }
        };

        ViewData["Title"] = "Edit FAQ";

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(EditFaqViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        try
        {
            await _faqService.UpdateAsync(model.Faq);

            TempData["Success"] = "FAQ updated successfully.";

            return RedirectToAction(nameof(Index));
        }
        catch (KeyNotFoundException ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);

            return View(model);
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        var faq = await _faqService.GetByIdAsync(id);

        if (faq == null)
            return NotFound();

        try
        {
            await _faqService.DeleteAsync(id);

            TempData["Success"] = "FAQ deleted successfully.";
        }
        catch (InvalidOperationException ex)
        {
            TempData["Error"] = ex.Message;
        }

        return RedirectToAction(nameof(Index));
    }
}
