using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Techcedence.Models;

namespace Techcedence.Controllers
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
        public IActionResult Sample()
        {
            var vm = new MyViewModelSample();

            var group2018 = new SelectListGroup { Name = "2018" };
            var group2019 = new SelectListGroup { Name = "2019" };

            var movieList = new List<SelectListItem>()
        {
            new SelectListItem() { Value = "1", Text = "Incredibles 2", Group = group2018 },
            new SelectListItem() { Value = "2", Text = "Ralph Breaks the Internet", Group = group2018 },
            new SelectListItem() { Value = "3", Text = "Aladdin", Group = group2019 },
            new SelectListItem() { Value = "4", Text = "The Lion King", Group = group2019 },
            new SelectListItem() { Value = "5", Text = "Frozen II", Group = group2019 }
        };
            vm.MoviesList = movieList;
            return View(vm);
        }

        [HttpPost]
        public IActionResult SampleSubmit(MyViewModelSample vm)
        {
            return View("SampleResult", vm.SelectedMovieID);
        }
    }
}