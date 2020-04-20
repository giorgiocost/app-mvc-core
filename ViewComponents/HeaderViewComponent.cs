using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace app_mvc_core.ViewComponents
{
    [ViewComponent(Name = "Header")]
    public class HeaderViewComponent : ViewComponent
    {
        // public string Title { get; set; }
        // public HeaderViewComponent()
        // {   
        //     Title = "Header";
        // }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}