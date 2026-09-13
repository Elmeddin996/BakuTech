using Microsoft.AspNetCore.Http;
using BakuTech.Business.DTOs.Settings;

namespace BakuTech.Web.Areas.Admin.ViewModels.Settings;

public class UpdateSettingViewModel
{
    public UpdateSettingDto Setting { get; set; } = new();

    public IFormFile? LogoFile { get; set; }
}
