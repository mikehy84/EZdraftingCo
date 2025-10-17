
using Application.Helper;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.Admin.Controllers
{
    [Area(AreaNames.Admin)]
    //[Route("Admin")]
    //[Route("Admin/{controller}/{action}")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
