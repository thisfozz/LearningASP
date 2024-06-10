using Microsoft.AspNetCore.Mvc;
using LearningASP.Models;

namespace LearningASP.Controllers;

public class RestaurantController : Controller
{
    [HttpGet]
    [Route("Homework/HomeWorkOne/RestaurantInfo")]
    public IActionResult RestaurantDisplayInfo()
    {
        var restaurant = new Restaurant
        {
            Name = "PIANO BAR",
            CuisineType = "PIANO – двухуровневое заведение современной русской и европейской кухни с нотками Азии в центре Тюмени на Пешеходной улице Дзержинского.",
            PhoneNumber = "+7 (3452) 55-55-75",
            Address = "ул. Республики, 33",
            StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0),
            EndTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 22, 0, 0)
        };
        return View("RestaurantInfo", restaurant);
    }
}