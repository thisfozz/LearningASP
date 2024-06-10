using LearningASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningASP.Controllers;

public class CountryController : Controller
{

    [HttpGet]
    [Route("/Homework/HomeWorkOne/CountryDisplayInfo")]
    public IActionResult CountryDisplayInfo()
    {
        var countries = new List<Country>
        {
                new Country
                {
                    Name = "Абхазия",
                    FullName = "Республика Абхазия",
                    NameInEnglish = "Abkhazia",
                    Alpha2 = "AB",
                    Alpha3 = "ABH",
                    ISO = "895",
                    Location = "Азия, Закавказье"
                },
                new Country
                {
                    Name = "Австралия",
                    FullName = "",
                    NameInEnglish = "Australia",
                    Alpha2 = "AU",
                    Alpha3 = "AUS",
                    ISO = "036",
                    Location = "Океания, Австралия и Новая Зеландия"
                },
                new Country
                {
                    Name = "Австрия",
                    FullName = "Австрийская Республика",
                    NameInEnglish = "Austria",
                    Alpha2 = "AT",
                    Alpha3 = "AUT",
                    ISO = "040",
                    Location = "Европа, Западная Европа"
                },
                new Country
                {
                    Name = "Азербайджан",
                    FullName = "Республика Азербайджан",
                    NameInEnglish = "Azerbaijan",
                    Alpha2 = "AZ",
                    Alpha3 = "AZE",
                    ISO = "031",
                    Location = "Азия, Западная Азия"
                },
                new Country
                {
                    Name = "Албания",
                    FullName = "Республика Албания",
                    NameInEnglish = "Albania",
                    Alpha2 = "AL",
                    Alpha3 = "ALB",
                    ISO = "008",
                    Location = "Европа, Южная Европа"
                },
                new Country
                {
                    Name = "Алжир",
                    FullName = "Алжирская Народная Демократическая Республика",
                    NameInEnglish = "Algeria",
                    Alpha2 = "DZ",
                    Alpha3 = "DZA",
                    ISO = "012",
                    Location = "Африка, Северная Африка"
                },
                new Country
                {
                    Name = "Американское Самоа",
                    FullName = "",
                    NameInEnglish = "American Samoa",
                    Alpha2 = "AS",
                    Alpha3 = "ASM",
                    ISO = "016",
                    Location = "Океания, Полинезия"
                },
                new Country
                {
                    Name = "Ангилья",
                    FullName = "",
                    NameInEnglish = "Anguilla",
                    Alpha2 = "AI",
                    Alpha3 = "AIA",
                    ISO = "660",
                    Location = "Америка, Карибский бассейн"
                },
                new Country
                {
                    Name = "Ангола",
                    FullName = "Республика Ангола",
                    NameInEnglish = "Angola",
                    Alpha2 = "AO",
                    Alpha3 = "AGO",
                    ISO = "024",
                    Location = "Африка, Центральная Африка"
                },
                new Country
                {
                    Name = "Андорра",
                    FullName = "Княжество Андорра",
                    NameInEnglish = "Andorra",
                    Alpha2 = "AD",
                    Alpha3 = "AND",
                    ISO = "020",
                    Location = "Европа,	Южная Европа"
                },
                new Country
                {
                    Name = "Антарктида",
                    FullName = "",
                    NameInEnglish = "Antarctica",
                    Alpha2 = "AQ",
                    Alpha3 = "ATA",
                    ISO = "010",
                    Location = "Антарктика"
                },
        };
        return View("CountryInfo" ,countries);
    }
}