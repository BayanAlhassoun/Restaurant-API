using Restaurant.Core.Data;
using Restaurant.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Repositories
{
    public interface ILogin_Repository
    {
      UserLogin Login(Login login);
        void Register(UserLogin userLogin);
    }
}
