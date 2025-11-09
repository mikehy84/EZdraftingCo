
using Application.DTO.UserAccountDTO;
using Application.Helper;
using Application.Services.UserAccountDir;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Areas.Client.Controllers
{
    [Area(AreaNames.Client)]
    public class AboutUsController : Controller
    {
        private readonly IUserAccountService<UserAccountDto> _AppUserService;

        public AboutUsController(IUserAccountService<UserAccountDto> appUserService)
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
