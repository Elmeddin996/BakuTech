using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using BakuTech.Business.DTOs.Categories;

namespace BakuTech.Web.Areas.Admin.ViewModels.Categories;

public class EditCategoryViewModel
{
    public UpdateCategoryDto Category { get; set; } = new();

    public IFormFile? ImageFile { get; set; }

    public IFormFile? IconFile { get; set; }
    public List<SelectListItem> ParentCategories { get; set; } = [];
}
