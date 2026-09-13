using Microsoft.AspNetCore.Mvc.Rendering;
using BakuTech.Business.DTOs.ProductImages;
using BakuTech.Business.DTOs.Products;

namespace BakuTech.Web.Areas.Admin.ViewModels.Products;

public class UpdateProductViewModel
{
    public UpdateProductDto Product { get; set; } = new();

    public List<ProductImageDto> Images { get; set; } = [];

    public UploadProductImageViewModel UploadImage { get; set; } = new();
    public List<UpdateProductSpecificationViewModel> Specifications { get; set; } = [];

    public List<SelectListItem> Categories { get; set; } = [];

    public List<SelectListItem> Brands { get; set; } = [];
}
