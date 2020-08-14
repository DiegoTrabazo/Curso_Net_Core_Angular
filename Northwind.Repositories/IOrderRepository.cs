using Northwind.Models;
using System.Collections.Generic;

namespace Northwind.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<OrderList> getPaginatedOrderList(int page, int rows);
        OrderList GetOrderById(int orderId);
    }
}
