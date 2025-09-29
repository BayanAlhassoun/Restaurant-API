using Restaurant.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Services
{
    public interface IOrder_Service
    {
        TotalOrders GetTotalOrdersByCustomer(string name);
    }
}
