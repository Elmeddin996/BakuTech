using Microsoft.AspNetCore.Mvc;

namespace BakuTech.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class NewsController : BaseAdminController
{
    public IActionResult Index()
    {
        ViewData["Title"] = "News";
        return View();
    }
}
