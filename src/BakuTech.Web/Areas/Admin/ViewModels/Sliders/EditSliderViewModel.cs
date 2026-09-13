using Microsoft.AspNetCore.Http;
using BakuTech.Business.DTOs.Sliders;

namespace BakuTech.Web.Areas.Admin.ViewModels.Sliders;

public class EditSliderViewModel
{
    public UpdateSliderDto Slider { get; set; } = new();

    public IFormFile? ImageFile { get; set; }
}
