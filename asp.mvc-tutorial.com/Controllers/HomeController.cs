using asp.mvc_tutorial.com.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace asp.mvc_tutorial.com.Controllers
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

        public IActionResult SelectGroups()
        {
            GroupedMoviesViewModel viewModel = new GroupedMoviesViewModel();

            SelectListGroup dramaMovies = new SelectListGroup() { Name = "Dramas" };
            viewModel.Movies.Add(new SelectListItem()
            {
                Group = dramaMovies,
                Text = "Forrest Gump"
            });
            viewModel.Movies.Add(new SelectListItem()
            {
                Group = dramaMovies,
                Text = "Fight Club"
            });

            SelectListGroup comedyMovies = new SelectListGroup() { Name = "Comedies" };
            viewModel.Movies.Add(new SelectListItem()
            {
                Group = comedyMovies,
                Text = "Anchorman: The Legend of Ron Burgundy"
            });
            viewModel.Movies.Add(new SelectListItem()
            {
                Group = comedyMovies,
                Text = "Step Brothers"
            });

            return View(viewModel);
        }
    }
}