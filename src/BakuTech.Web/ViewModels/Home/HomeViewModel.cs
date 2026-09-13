using BakuTech.Business.DTOs.Categories;
using BakuTech.Business.DTOs.MiniSliders;
using BakuTech.Business.DTOs.MobileSliders;
using BakuTech.Business.DTOs.Products;
using BakuTech.Business.DTOs.Sliders;

namespace BakuTech.Web.ViewModels.Home;

public class HomeViewModel
{
    public IReadOnlyList<SliderDetailDto> Sliders { get; set; } = [];
    public IReadOnlyList<MiniSliderListDto> MiniSliders { get; set; } = [];
    public IReadOnlyList<CategoryListDto> Categories { get; set; } = [];
    public IReadOnlyList<ProductListDto> NewProducts { get; set; } = [];
    public IReadOnlyList<MobileSliderListDto> MobileSliders { get; set; }
        = new List<MobileSliderListDto>();

    public string? YoutubeVideo1 { get; set; }
    public string? YoutubeVideo2 { get; set; }
}
