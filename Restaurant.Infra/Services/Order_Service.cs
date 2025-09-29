using Restaurant.Core.DTO;
using Restaurant.Core.Repositories;
using Restaurant.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infra.Services
{
    public class Order_Service : IOrder_Service
    {
        private readonly IOrder_Repository _order_Repository;

        public Order_Service(IOrder_Repository order_Repository)
        {
            _order_Repository = order_Repository;
        }

        public TotalOrders GetTotalOrdersByCustomer(string name)
        {
            return _order_Repository.GetTotalOrdersByCustomer(name);
        }
    }
}
