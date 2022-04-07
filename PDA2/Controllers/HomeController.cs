using Microsoft.AspNetCore.Mvc;
using PDA2.Data;
using PDA2.Services.Managers;
using PDA2.Web.Models;
using System.Diagnostics;

namespace PDA2.Web.Controllers
{
    public class HomeController : Controller
    {
        private IArticleService artSer;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext, IArticleService artSe)
        {
            _logger = logger;

            artSer = artSe;
        }

        public IActionResult Index()
        {
            var aa = artSer.GetAll();

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