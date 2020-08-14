using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Northwind.BusinessLogic.Interfaces;
using Northwind.Models;
using Northwind.UnitOfWork;

namespace Northwind.WebApi.Controllers
{
    [Route("Customer")]
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly ICustomerLogic _logic;
        public CustomerController(ICustomerLogic logic)
        {
            _logic = logic;
        }
        
        [HttpGet]
        [Route("{id:int}")]        
        public IActionResult GetById(int id)
        {
            return Ok(_logic.GetById(id));
        }
        
        [HttpGet]
        [Route("GetPaginatedCustomer/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedCustomer(int page, int rows)
        {
            return Ok(_logic.GetPaginatedCustomer(page, rows));
        }

        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            if (!ModelState.IsValid) return BadRequest();

            return Ok(_logic.Insert(customer));
        }

        [HttpPut]
        public IActionResult Put([FromBody]Customer customer)
        {
            if (ModelState.IsValid && _logic.Update(customer))
                return Ok(new { Message = "The Customer is Updated" });
            
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]Customer customer)
        {
            if (customer.Id > 0) return Ok(_logic.Delete(customer));

            return BadRequest();
        }
    }
}
