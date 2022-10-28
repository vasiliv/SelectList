using Microsoft.AspNetCore.Mvc.Rendering;

namespace Techcedence.Models
{
    public class MyViewModelSample
    {
        public int SelectedMovieID { get; set; }
        public List<SelectListItem> MoviesList { get; set; }
    }
}
