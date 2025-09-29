using Restaurant.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Repositories
{
    public interface IOrder_Repository
    {
       TotalOrders GetTotalOrdersByCustomer(string name);
    }
}
