using EZD_BLL.Helper;
using Microsoft.AspNetCore.Mvc;

namespace EZD_WEB.Areas.Admin.Controllers
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
