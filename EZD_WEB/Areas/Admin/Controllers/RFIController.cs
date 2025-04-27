using EZD_BLL.Helper;
using Microsoft.AspNetCore.Mvc;

namespace EZD_WEB.Areas.Admin.Controllers
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
