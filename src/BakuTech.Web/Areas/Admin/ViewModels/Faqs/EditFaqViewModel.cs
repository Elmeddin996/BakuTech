using BakuTech.Business.DTOs.Faqs;

namespace BakuTech.Web.Areas.Admin.ViewModels.Faqs;

public class EditFaqViewModel
{
    public UpdateFaqDto Faq { get; set; } = new();
}
