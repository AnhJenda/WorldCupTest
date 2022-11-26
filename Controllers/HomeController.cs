using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WorldCup.Models;

namespace WorldCup.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Details(int id)
        {
            if (id == 1)
            {
                return "Viet Nam   10 : 0   England";
            }
            else if (id == 2)
            {
                return "Argentina   0 : 0   Poturgal";
            }
            else if (id == 3)
            {
                return "France   1 : 1   Italy";
            }
            else if (id == 4)
            {
                return "Viet Name   10 : 0   Argentina";
            }
            else
                return "No match found!";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}