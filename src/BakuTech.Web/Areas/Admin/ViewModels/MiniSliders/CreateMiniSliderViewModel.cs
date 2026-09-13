using Microsoft.AspNetCore.Http;
using BakuTech.Business.DTOs.MiniSliders;

namespace BakuTech.Web.Areas.Admin.ViewModels.MiniSliders;

public class CreateMiniSliderViewModel
{
    public CreateMiniSliderDto MiniSlider { get; set; } = new();

    public IFormFile? ImageFile { get; set; }
}
