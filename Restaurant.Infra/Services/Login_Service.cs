using Microsoft.IdentityModel.Tokens;
using Restaurant.Core.Data;
using Restaurant.Core.Repositories;
using Restaurant.Core.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infra.Services
{
    public class Login_Service : ILogin_Service
    {
        private readonly ILogin_Repository _loginRepository;

        public Login_Service(ILogin_Repository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public string Login(Login login) // Mohammad, 123
        {
           var result = _loginRepository.Login(login);
            if (result == null)
            {
                return null;
            }
            else
            {
                var auth_Handler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes("Hello EveryOne, I hope you are all doing well, Hello EveryOne, I hope you are all doing well");
                var tokenDescriptor = new SecurityTokenDescriptor()
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserId", result.Userid.ToString()),
                        new Claim("RoleId", result.Positionid.ToString()),
                        new Claim("email", result.Email)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(10),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = auth_Handler.CreateToken(tokenDescriptor);
                return auth_Handler.WriteToken(token);
            }
        }
    }
}
