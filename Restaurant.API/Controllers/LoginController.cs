using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Data;
using Restaurant.Core.DTO;
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

        [HttpPost]
        [Route("Register")]
        public void Register(UserLogin userLogin)// Mohammad, 123
        {
           _loginService.Register(userLogin);

        }

        [HttpPost]
        [Route("UploadImage")]
        public string UploadImage(IFormFile file)// person.png
        {
            var fileName = Guid.NewGuid().ToString() +"_" + file.FileName; // 4tiwehoiwejfpoweur979_Person.png / reywiquipfjpmjmdf_Person.png / hlgjlkteejhoslmk_Person.png
            var fullPath = Path.Combine("C:\\Users\\User\\source\\repos\\finalRestaurant\\src\\assets\\Images", fileName);

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return fileName;
        }

    }
}
