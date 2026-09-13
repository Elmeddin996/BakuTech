using Microsoft.AspNetCore.Http;

namespace BakuTech.Web.Areas.Admin.ViewModels.Products;

public class UploadProductImageViewModel
{
    public int ProductId { get; set; }

    public IFormFile? Image { get; set; }

    public bool IsMain { get; set; }

    public int DisplayOrder { get; set; }
}
