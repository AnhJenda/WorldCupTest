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

        public IActionResult Details(int id, string team1, string team2, int score1, int score2,
            string flag1, string flag2)
        {
            if (id == 1)
            {
                ViewData["team1"] = "Viet Nam";
                ViewData["flag1"] = "../../img/vietnam.png";
                ViewData["flag2"] = "../../img/england.png";
                ViewData["team2"] = "England";
                ViewData["score1"] = 10;
                ViewData["score2"] = 0;
                return View();
            }
            else if (id == 2)
            {
                ViewData["team1"] = "Poturgal";
                ViewData["team2"] = "Argentina";
                ViewData["flag1"] = "../../img/poturgal.png";
                ViewData["flag2"] = "../../img/argentina.png";
                ViewData["score1"] = 0;
                ViewData["score2"] = 0;
                return View();
            }
            else if (id == 3)
            {
                ViewData["team1"] = "France";
                ViewData["team2"] = "Italy";
                ViewData["flag1"] = "../../img/france.png";
                ViewData["flag2"] = "../../img/italia.png";
                ViewData["score1"] = 2;
                ViewData["score2"] = 2;
                return View();
            }
            else if (id == 4)
            {
                ViewData["team1"] = "Viet Nam";
                ViewData["team2"] = "Argentina";
                ViewData["flag1"] = "../../img/vietnam.png";
                ViewData["flag2"] = "../../img/argentina.png";
                ViewData["score1"] = 10;
                ViewData["score2"] = 0;
                return View();
            }
            else
                return Redirect("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}