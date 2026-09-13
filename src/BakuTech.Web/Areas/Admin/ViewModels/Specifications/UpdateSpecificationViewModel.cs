using Microsoft.AspNetCore.Mvc.Rendering;
using BakuTech.Business.DTOs.Specifications;

namespace BakuTech.Web.Areas.Admin.ViewModels.Specifications;

public class UpdateSpecificationViewModel
{
    public UpdateSpecificationDto Specification { get; set; } = new();

    public List<SelectListItem> SpecificationGroups { get; set; } = new();
}
