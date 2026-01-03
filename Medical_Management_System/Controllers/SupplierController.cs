using Medical_Management_System.Data;
using Medical_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly MedicalDbContext _context;   //readonly decclare --it will assign once and it should be in constructor only


        //A constructor is a special method that runs automatically when an object is created, and its main job is to receive required dependencies and assign them to class-level variables so the object is ready to work.


        public SupplierController(MedicalDbContext mdbc)  //controller constructor will call so it will create obj mdbc that will hold all properties of medicalDbcontext which was child class of dbcontext
        {
            _context = mdbc;    // passing properties into class level blank variable _context so we can use it throughout the class
        }



        [HttpPost]
        public IActionResult CreateSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
            return Ok(supplier);

            //return CreatedAtAction(nameof(CreateSupplier), new { id = supplier.SupplierId }, supplier);
        }

        [HttpGet]

        public IActionResult getallSupplier()
        {
            var SupplierList = _context.Suppliers.ToList();
            return Ok(SupplierList);

        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> getSupplier(int id)
        //{
        //    var supplier = await _context.Suppliers.FirstOrDefault(p=> id==p.Id);

        //    return Ok(supplier);
        //}

        //[HttpGet("{id}")]
        public async Task<IActionResult> GetSupplier(int id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
           
            if (supplier == null)
                return NotFound();

            return Ok(supplier);
        }




    }
}