using Microsoft.AspNetCore.Http;
using BakuTech.Business.DTOs.MobileSliders;

namespace BakuTech.Web.Areas.Admin.ViewModels.MobileSliders;

public class CreateMobileSliderViewModel
{
    public CreateMobileSliderDto MobileSlider { get; set; } = new();

    public IFormFile? ImageFile { get; set; }
}
