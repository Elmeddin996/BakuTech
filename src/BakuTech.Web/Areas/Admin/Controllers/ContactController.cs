using Microsoft.AspNetCore.Mvc;

namespace BakuTech.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class ContactController : BaseAdminController
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Contacts";
        return View();
    }
}
