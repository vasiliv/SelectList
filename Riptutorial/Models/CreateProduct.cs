using Microsoft.AspNetCore.Mvc.Rendering;

namespace Riptutorial.Models
{
    public class CreateProduct
    {
        public IEnumerable<SelectListItem> Categories { set; get; }
        public int SelectedCategory { set; get; }
    }
}
