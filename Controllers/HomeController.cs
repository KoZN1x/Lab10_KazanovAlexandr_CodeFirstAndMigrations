using Lab10_KazanovAlexandr_CodeFirst.Context;
using Lab10_KazanovAlexandr_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Lab10_KazanovAlexandr_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DbContextOptions<ApplicationContext> _context;

        public HomeController(ILogger<HomeController> logger, DbContextOptions<ApplicationContext> context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            using (var app = new ApplicationContext(_context))
            {
                var x = app.Player.OrderBy(x => x.Id);
            }
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