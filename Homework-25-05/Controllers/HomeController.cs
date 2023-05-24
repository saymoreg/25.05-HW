using Microsoft.AspNetCore.Mvc;

namespace Homework_25_05.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Title = "25 05 2023 Homework";
        ViewBag.Name = "Seymur";
        ViewBag.Surname = "Guliyev";
        ViewBag.Age = "23";
        ViewBag.Country = "Azerbaijan";
        ViewBag.PhoneNumber = "+994 55 555 55 55";
        
        return View();
    }
}