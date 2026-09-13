using Microsoft.AspNetCore.Mvc.Rendering;
using BakuTech.Business.DTOs.Specifications;

namespace BakuTech.Web.Areas.Admin.ViewModels.Specifications;

public class CreateSpecificationViewModel
{
    public CreateSpecificationDto Specification { get; set; } = new();

    public List<SelectListItem> SpecificationGroups { get; set; } = new();
}
