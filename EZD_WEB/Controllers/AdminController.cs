using Microsoft.AspNetCore.Mvc;

namespace EZD_WEB.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
