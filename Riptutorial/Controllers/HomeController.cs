using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Riptutorial.Models;
using System.Diagnostics;

namespace Riptutorial.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Create()
        {
            var vm = new CreateProduct();
            vm.Categories = new List<SelectListItem>
            {
                new SelectListItem {Text = "Books", Value = "1"},
                new SelectListItem {Text = "Furniture", Value = "2"}
            };
            return View(vm);
        }
    }
}