using BakuTech.Business.DTOs.Faqs;

namespace BakuTech.Web.Areas.Admin.ViewModels.Faqs;

public class CreateFaqViewModel
{
    public CreateFaqDto Faq { get; set; } = new();
}
