using Northwind.BusinessLogic.Interfaces;
using Northwind.Models;
using Northwind.UnitOfWork;
using System.Collections.Generic;

namespace Northwind.BusinessLogic.Implementatios
{
    public class CustomerLogic : ICustomerLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerLogic(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
        public bool Delete(Customer customer) => _unitOfWork.Customer.Delete(customer);

        public Customer GetById(int id) => _unitOfWork.Customer.GetById(id);

        public IEnumerable<Customer> GetPaginatedCustomer(int page, int rows) => _unitOfWork.Customer.CustomerPagedList(page, rows);

        public int Insert(Customer customer) => _unitOfWork.Customer.Insert(customer);

        public bool Update(Customer customer) => _unitOfWork.Customer.Update(customer);
    }
}
