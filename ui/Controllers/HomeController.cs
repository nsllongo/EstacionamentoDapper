using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace estacionamento.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }
    
}
