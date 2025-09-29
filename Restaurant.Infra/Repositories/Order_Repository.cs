using Dapper;
using Restaurant.Core.Common;
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
    public class Order_Repository : IOrder_Repository
    {
        private readonly IDBContext _dBContext;

        public Order_Repository(IDBContext dBContext)
        {
            _dBContext = dBContext;
        }


        public TotalOrders GetTotalOrdersByCustomer(string name)
        {
            var p = new DynamicParameters();
            p.Add("customer_name", name, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Query<TotalOrders>("ORDERS_PACKAGE.GetTotalOrdersByCustomer", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
