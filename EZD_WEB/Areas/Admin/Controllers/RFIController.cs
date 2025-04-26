using Microsoft.AspNetCore.Mvc;

namespace EZD_WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RFIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
