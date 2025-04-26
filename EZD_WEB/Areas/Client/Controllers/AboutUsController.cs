using EZD_BLL.AppUserDir;
using EZD_BLL.AppUserDtoDir;
using Microsoft.AspNetCore.Mvc;

namespace EZD_WEB.Areas.Client.Controllers
{
    [Area("Client")]
    public class AboutUsController : Controller
    {
        private readonly IAppUserService<AppUserDto> _AppUserService;

        public AboutUsController(IAppUserService<AppUserDto> appUserService)
        {
            _AppUserService = appUserService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var appUsersDto = await _AppUserService.GetAllAsync();

            return View(appUsersDto);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(string id)
        {
            return View(await _AppUserService.GetByIdAsync(id));
        }
    }
}
