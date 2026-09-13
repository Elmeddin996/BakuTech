using Microsoft.AspNetCore.Http;
using BakuTech.Business.DTOs.MiniSliders;

namespace BakuTech.Web.Areas.Admin.ViewModels.MiniSliders;

public class EditMiniSliderViewModel
{
    public UpdateMiniSliderDto MiniSlider { get; set; } = new();

    public IFormFile? ImageFile { get; set; }
}
