using Microsoft.AspNetCore.Mvc;

namespace LearningASP.Controllers;

public class AlphabetController : Controller
{
    [HttpGet]
    [Route("/Homework/HomeWorkOne/RandomAlphabetDispay")]
    public IActionResult RandomAlphabetOnDisplay(int? userInput)
    {
        if (userInput.HasValue)
        {
            if (userInput < 1 || userInput > 26)
            {
                ViewBag.Message = "Ваше число больше чем букв в английском алфавите";
            }

            List<char> alphabet = new List<char>();

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                alphabet.Add(letter);
            }
            ViewBag.Message = alphabet[userInput.Value - 1];
        }

        return View("RandomAlphabetDispay");
    }
}
