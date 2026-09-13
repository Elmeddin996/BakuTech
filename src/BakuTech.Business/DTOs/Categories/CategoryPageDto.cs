using BakuTech.Business.DTOs.Products;
using BakuTech.Core.Common.Pagination;

namespace BakuTech.Business.DTOs.Categories;

public class CategoryPageDto
{
    public CategoryDetailDto Category { get; set; } = null!;

    public List<CategoryListDto> ChildCategories { get; set; } = new();

    public PagedResult<ProductListDto> Products { get; set; } = new();
}
