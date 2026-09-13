using BakuTech.Business.DTOs.Categories;
using BakuTech.Business.DTOs.Settings;

namespace BakuTech.Web.ViewModels.Layout;

public class LayoutViewModel
{
    public SettingDetailDto? Setting { get; set; }

    public List<CategoryListDto> Categories { get; set; } = [];
}
