using CsharpCorner.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CsharpCorner.Controllers
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
        public IActionResult EmployeeDropdown()
        {
            //If you are getting data from the database, then you can bind it like below,
            //model.EmployeesList = data.Select(x => new Itemlist { Value = x.EmployeeId, Text = x.EmployeeName }).ToList();
            EmployeeViewModel model = new EmployeeViewModel();
            return View(model);
        }


    }
}