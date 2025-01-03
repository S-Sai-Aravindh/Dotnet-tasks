using Microsoft.AspNetCore.Mvc;
using MyDemoApp.Models;
using System.Diagnostics;

namespace MyDemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CompanyContext context;

        public HomeController(ILogger<HomeController> logger,CompanyContext cc)
        {
            _logger = logger;
            context = cc;
        }

        public string CreateInformation()
        {
            var info = new Information()
            {
                Name = "Hematite Infotech",
                License = "27AECH36F2S",
                Revenue = 1000000,
                Established = Convert.ToDateTime("2017/04/27")
            };

            context.Entry(info).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            context.SaveChanges();

            return "Record Added Successfully";
        }

        public IActionResult Index()
        {
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
