using Microsoft.AspNetCore.Http;
using BakuTech.Business.DTOs.MobileSliders;

namespace BakuTech.Web.Areas.Admin.ViewModels.MobileSliders;

public class EditMobileSliderViewModel
{
    public UpdateMobileSliderDto MobileSlider { get; set; } = new();

    public IFormFile? ImageFile { get; set; }
}
