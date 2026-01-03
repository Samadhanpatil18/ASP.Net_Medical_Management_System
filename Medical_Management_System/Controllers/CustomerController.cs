using Medical_Management_System.Data;
using Medical_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly MedicalDbContext _context;

        public CustomerController(MedicalDbContext mdbc)
        {
            _context = mdbc;
        }




        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return Ok(customer);

        }

        [HttpGet]
        public IActionResult getAllcustomers()
        {
            var customersList = _context.Customers.ToList();
            return Ok(customersList);

        }



    }
}
