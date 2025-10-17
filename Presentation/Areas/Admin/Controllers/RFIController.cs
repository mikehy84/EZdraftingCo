
using Application.Helper;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.Admin.Controllers
{
    [Area(AreaNames.Admin)]
    public class RFIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
