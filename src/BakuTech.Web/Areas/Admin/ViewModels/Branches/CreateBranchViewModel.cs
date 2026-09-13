using Microsoft.AspNetCore.Http;
using BakuTech.Business.DTOs.Branches;

namespace BakuTech.Web.Areas.Admin.ViewModels.Branches;

public class CreateBranchViewModel
{
    public CreateBranchDto Branch { get; set; } = new();

    public IFormFile? ImageFile { get; set; }
}
