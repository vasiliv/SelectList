using Microsoft.AspNetCore.Mvc.Rendering;

namespace asp.mvc_tutorial.com.Models
{
    public class GroupedMoviesViewModel
    {
        public GroupedMoviesViewModel()
        {
            this.Movies = new List<SelectListItem>();
        }

        public List<SelectListItem> Movies { get; set; }
    }
}
