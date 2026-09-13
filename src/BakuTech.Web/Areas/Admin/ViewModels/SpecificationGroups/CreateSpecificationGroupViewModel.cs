using Microsoft.AspNetCore.Mvc.Rendering;
using BakuTech.Business.DTOs.SpecificationGroups;

namespace BakuTech.Web.Areas.Admin.ViewModels.SpecificationGroups;

public class CreateSpecificationGroupViewModel
{
    public CreateSpecificationGroupDto SpecificationGroup { get; set; } = new();
    public List<SelectListItem> Categories { get; set; } = [];
}
