using Microsoft.AspNetCore.Mvc;

namespace EZD_WEB.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
