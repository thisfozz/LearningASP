using Microsoft.AspNetCore.Mvc;
using LearningASP.Models;

namespace LearningASP.Controllers;

public class RestaurantInfoController : Controller
{
    [HttpGet]
    [Route("/Homework/HomeWorkOne/RestaurantInfo")]
    public IActionResult RestaurantInfoOnTr()
    {
        var restaurant = new Restaurant {Name = "PIANO BAR", CuisineType = "Modern Russian and European cuisine with notes of Asia", PhoneNumber = "+7 (3452) 55-55-75", Address = "Republic, 33" };
        return View("RestaurantInfo", restaurant);
    }
}