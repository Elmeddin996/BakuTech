using Microsoft.AspNetCore.Mvc.Rendering;
using BakuTech.Business.DTOs.SpecificationGroups;

namespace BakuTech.Web.Areas.Admin.ViewModels.SpecificationGroups;

public class UpdateSpecificationGroupViewModel
{
    public UpdateSpecificationGroupDto SpecificationGroup { get; set; } = new();
    public List<SelectListItem> Categories { get; set; } = [];
}
