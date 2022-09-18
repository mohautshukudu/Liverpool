using Liverpool.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Liverpool.Controllers
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

        public IActionResult Memorabilia()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Product1()
        {
            return View();
        }

        public IActionResult Product2()
        {
            return View();
        }

        public IActionResult Product3()
        {
            return View();
        }

        public IActionResult Product4()
        {
            return View();
        }

        public IActionResult Product5()
        {
            return View();
        }

        public IActionResult Product6()
        {
            return View();
        }

        public IActionResult Product7()
        {
            return View();
        }

        public IActionResult Product8()
        {
            return View();
        }

        public IActionResult Product9()
        {
            return View();
        }

        public IActionResult Product10()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}