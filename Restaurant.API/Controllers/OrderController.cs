using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.DTO;
using Restaurant.Core.Services;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrder_Service _order_service;

        public OrderController(IOrder_Service order_service)
        {
            _order_service = order_service;
        }

        [HttpGet]
        [Route("GetTotalOrdersByCustomer/{name}")]
        public TotalOrders GetTotalOrdersByCustomer(string name)// https://localhost:7031/api/order/GetTotalOrdersByCustomer/
        {
            return _order_service.GetTotalOrdersByCustomer(name);
        }
    }
}
