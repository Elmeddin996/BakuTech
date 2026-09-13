using BakuTech.Business.DTOs.Categories;
using BakuTech.Business.DTOs.Products;
using BakuTech.Core.Common.Pagination;

namespace BakuTech.Web.ViewModels.Category;

public class CategoryPageViewModel
{
    public CategoryDetailDto Category { get; set; } = null!;

    public List<CategoryListDto> ChildCategories { get; set; } = new();

    public ProductFilterOptionsDto FilterOptions { get; set; } = new();

    public PagedResult<ProductListDto> Products { get; set; } = new();
}
