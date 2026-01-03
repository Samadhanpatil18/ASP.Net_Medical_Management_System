using Medical_Management_System.Data;
using Medical_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalController : ControllerBase
    {
        private readonly MedicalDbContext _context;

        public MedicalController(MedicalDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateMedical(Medical medical)
        {
            _context.Medicals.Add(medical);
            _context.SaveChanges();

            return Ok(medical);
        }
        [HttpGet]
        public IActionResult getMedicleData()
        {
            var MedicleData = _context.Medicals.ToList();
            return Ok (MedicleData);
        }
    }
}
