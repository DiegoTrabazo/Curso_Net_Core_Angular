using Northwind.Models;
using System.Collections.Generic;

namespace Northwind.BusinessLogic.Interfaces
{
    public interface ICustomerLogic
    {
        Customer GetById(int id);
        IEnumerable<Customer> GetPaginatedCustomer(int page, int rows);
        int Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(Customer customer);
    }
}
