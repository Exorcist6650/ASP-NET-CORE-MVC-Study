using System.Diagnostics;
using ASPCORE_MVC_study.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCORE_MVC_study.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {

            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult PrintInfo()
        {
            return View();
        }

        public IActionResult Index()
        {
            var adminName = _configuration.GetSection("Name");
            var password = _configuration.GetSection("Password");
            return View();
        }

        public IActionResult Privacy()
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
