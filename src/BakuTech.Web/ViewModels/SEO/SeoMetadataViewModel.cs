namespace BakuTech.Web.ViewModels.SEO;

public class SeoMetadataViewModel
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Keywords { get; set; }

    public string? CanonicalUrl { get; set; }

    public string? OgTitle { get; set; }
    public string? OgDescription { get; set; }
    public string? OgImage { get; set; }
    public string OgType { get; set; } = "website";

    public string Robots { get; set; } = "index,follow";
}
