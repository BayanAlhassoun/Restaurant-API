using Dapper;
using Restaurant.Core.Common;
using Restaurant.Core.Data;
using Restaurant.Core.DTO;
using Restaurant.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infra.Repositories
{
    public class Login_Repository : ILogin_Repository
    {
        private readonly IDBContext _dBContext;

        public Login_Repository(IDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public UserLogin Login(Login login)// Mohammad , 123
        {
            var p = new DynamicParameters();
            p.Add("user_name", login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Query<UserLogin>("Login_Package.Login", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
