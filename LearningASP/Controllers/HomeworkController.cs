using Microsoft.AspNetCore.Mvc;

namespace LearningASP.Controllers;

public class HomeworkController : Controller
{
    [HttpGet]
    [Route("Homework/HomeworkOneHome")]
    public IActionResult HomeworkOne()
    {
        return View("HomeworkOneHome");
    }

    [HttpGet]
    [Route("Homework/HomeworkTwoHome")]
    public IActionResult HomeworkTwo()
    {
        return View("HomeworkTwoHome");
    }
}