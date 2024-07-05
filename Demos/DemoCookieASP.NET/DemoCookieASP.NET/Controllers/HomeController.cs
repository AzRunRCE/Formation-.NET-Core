using DemoCookieASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoCookieASP.NET.Controllers
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
            String? test = Request.Cookies["test"];
            if (test == null)
            {
                TempData["test"] = "Pas de cookie test";
            }
            else
            {
                TempData["test"] = test;
            }
            return View();
        }


        public IActionResult Privacy()
        {
            Response.Cookies.Append("test", "Hello World!");
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
