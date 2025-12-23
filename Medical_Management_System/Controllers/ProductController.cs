using Medical_Management_System.Data;
using Medical_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        private readonly MedicalDbContext _context;

        public ProductController(MedicalDbContext mdbc)
        {

            _context = mdbc;
        }
     


    [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);


        }


    }
}