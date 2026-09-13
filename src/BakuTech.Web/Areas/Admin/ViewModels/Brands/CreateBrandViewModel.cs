using Microsoft.AspNetCore.Http;
using BakuTech.Business.DTOs.Brands;

namespace BakuTech.Web.Areas.Admin.ViewModels.Brands;

public class CreateBrandViewModel
{
    public CreateBrandDto Brand { get; set; } = new();

    public IFormFile? LogoFile { get; set; }
}
