using Microsoft.AspNetCore.Http;
using BakuTech.Business.DTOs.Branches;

namespace BakuTech.Web.Areas.Admin.ViewModels.Branches;

public class EditBranchViewModel
{
    public UpdateBranchDto Branch { get; set; } = new();

    public IFormFile? ImageFile { get; set; }
}
