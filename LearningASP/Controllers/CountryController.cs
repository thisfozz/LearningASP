using Microsoft.AspNetCore.Mvc;

namespace LearningASP.Controllers;

public class CountryController : Controller
{

    [HttpGet]
    [Route("/Homework/HomeWorkOne/CountryDisplayInfo")]
    public IActionResult CountryDisplayInfoOnTr()
    {
        return View("CountryInfo");
    }
}
