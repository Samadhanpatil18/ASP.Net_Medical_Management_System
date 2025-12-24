using Medical_Management_System.Data;
using Medical_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicalController : ControllerBase
    {
        private readonly MedicalDbContext _context;

        // Constructor (Dependency Injection)
        public MedicalController(MedicalDbContext context)
        {
            _context = context;
        }

        // POST: api/medical
        [HttpPost]
        public IActionResult CreateMedical(Medical medical)
        {
            _context.Medical.Add(medical);
            _context.SaveChanges();

            return Ok(medical);
        }
    }
}
