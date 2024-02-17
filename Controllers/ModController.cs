using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoyModsAPI.Contracts;

namespace RoyModsAPI.Controllers
{
    [ApiController]
    [Route("mod")]
    [AllowAnonymous]
    public class ModController : Controller
    {
        private readonly IUserService userService;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ModController(IUserService _userService, IWebHostEnvironment _webHostEnvironment)
        {
            this.userService = _userService;
            this.webHostEnvironment = _webHostEnvironment;

        }

        [HttpGet("get-users")]
        public IActionResult GetUsers()
        {
            var names = userService.GetUsers(webHostEnvironment.ContentRootPath + @"Data/bin.bls");
            return Ok(names);
        }
    }
}
