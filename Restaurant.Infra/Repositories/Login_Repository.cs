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

        public void Register(UserLogin userLogin)
        {
            var p = new DynamicParameters();
            p.Add("user_name", userLogin.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", userLogin.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("name", userLogin.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Useremail", userLogin.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phoneNumber", userLogin.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("gender", userLogin.Genderid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("role", userLogin.Positionid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("imageName", userLogin.ImageName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Execute("Login_Package.Register", p, commandType: CommandType.StoredProcedure);
        }
    }
}
