using Microsoft.AspNetCore.Mvc;

namespace BakuTech.Web.Areas.Admin.Controllers;

public class DashboardController : BaseAdminController
{
    public IActionResult Index()
    {
        return View();
    }
}
