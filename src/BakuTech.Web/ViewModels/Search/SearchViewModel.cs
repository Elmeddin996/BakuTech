using BakuTech.Business.DTOs.Categories;
using BakuTech.Business.DTOs.Products;
using BakuTech.Core.Common.Pagination;

namespace BakuTech.Web.ViewModels.Search;

public class SearchViewModel
{
    public string? Search { get; set; }

    public int? CategoryId { get; set; }

    public List<CategoryListDto> Categories { get; set; } = new();

    public PagedResult<ProductListDto> Products { get; set; } = new();
}
