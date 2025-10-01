using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Data;
using Restaurant.Core.Services;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly ILogin_Service _loginService;

        public LoginController(ILogin_Service loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(Login login)// Mohammad, 123
        {
           var result = _loginService.Login(login);
            if (result == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
