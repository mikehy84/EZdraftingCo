using AutoMapper;
using EZD_BLL;
using EZD_BLL.AppUserDtoDir;
using EZD_BLL.ProjectDir;
using EZD_BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EZD_WEB.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IService<AppUserDto> _AppUserService;

        public AboutUsController(
            IService<AppUserDto> appUserService)
        {
            _AppUserService = appUserService;
        }

        public async Task<IActionResult> Index()
        {
            var appUsersDto = await _AppUserService.GetAllAsync();

            return View(appUsersDto);
        }
    }
}
