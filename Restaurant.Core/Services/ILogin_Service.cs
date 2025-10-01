using Restaurant.Core.Data;
using Restaurant.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Services
{
    public interface ILogin_Service
    {
       string Login(Login login);
    }
}
