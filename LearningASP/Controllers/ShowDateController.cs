using Microsoft.AspNetCore.Mvc;

namespace LearningASP.Controllers;

public class ShowDateController : Controller
{
    [HttpGet]
    [Route("ShowDate/CurrentDate")]
    public IActionResult CurrentDateInYear()
    {
        DateTime now = DateTime.Now;
        ViewBag.Message = now.DayOfYear;
        return View("CurrentDate");
    }
}
