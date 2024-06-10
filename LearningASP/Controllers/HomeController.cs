using Microsoft.AspNetCore.Mvc;

namespace LearningASP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}