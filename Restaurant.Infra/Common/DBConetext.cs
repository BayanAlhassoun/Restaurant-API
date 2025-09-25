using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using Restaurant.Core.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infra.Common
{
    public class DBConetext: IDBContext
    {
        private DbConnection _conection;
        private readonly IConfiguration _configuration;


        public DBConetext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbConnection Conection
        {
            get
            {
                if (_conection == null)
                {
                    _conection = new OracleConnection(_configuration["ConnectionStrings:DBConnectionString"]);
                    _conection.Open();
                }
                else if (_conection.State != ConnectionState.Open)
                {
                    _conection.Open();
                }
                return _conection;
            }
        }

    }
}
