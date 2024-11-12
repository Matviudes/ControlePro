using Microsoft.AspNetCore.Mvc;

namespace ControlePro.Controllers;

public class NotFoundController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}