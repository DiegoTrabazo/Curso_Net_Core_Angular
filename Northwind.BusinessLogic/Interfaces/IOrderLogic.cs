using Northwind.Models;
using System.Collections.Generic;

namespace Northwind.BusinessLogic.Interfaces
{
    public interface IOrderLogic
    {
        Order GetOrderById(int id);
        IEnumerable<OrderList> getPaginatedOrderList(int page, int rows);
        public int Insert(Order order);
        public bool Update(Order order);
        public bool Delete(Order order);
        public string GetOrderNumber(int orderId);
    }
}
