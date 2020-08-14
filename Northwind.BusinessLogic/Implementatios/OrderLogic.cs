using Northwind.BusinessLogic.Interfaces;
using Northwind.Models;
using Northwind.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.BusinessLogic.Implementatios
{
    public class OrderLogic : IOrderLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderLogic(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
        public Order GetOrderById(int id) => _unitOfWork.Order.GetById(id);

        public IEnumerable<OrderList> getPaginatedOrderList(int page, int rows) => _unitOfWork.Order.getPaginatedOrderList(page, rows);

        public int Insert(Order order) => _unitOfWork.Order.Insert(order);

        public bool Update(Order order) => _unitOfWork.Order.Update(order);
        
        public bool Delete(Order order) => _unitOfWork.Order.Delete(order);

        public string GetOrderNumber(int orderId) 
        {
            var list = _unitOfWork.Order.GetList();
            var record = list?.First(o => o.Id == orderId);
            return record?.OrderNumber;
        }
    }
}
