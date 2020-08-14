using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Northwind.BusinessLogic.Interfaces;

namespace Northwind.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("Order")]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderLogic _logic;
        public OrderController(IOrderLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        [Route("GetPaginatedOrder/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedOrder(int page, int rows)
        {
            return Ok(_logic.getPaginatedOrderList(page, rows));
        }

        [HttpGet]
        [Route("GetOrderById/{orderId:int}")]
        public IActionResult GetOrderById(int orderId)
        {
            return Ok(_logic.GetOrderById(orderId));
        }
    }
}
