using System.ComponentModel.DataAnnotations;

namespace Medical_Management_System.Models
{
    public class Medical
    {
        [Key]
        public int MedicalId { get; set; }

        [Required]
        public string MedicalName { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string LicenseNumber { get; set; }

        public int SupplierId { get; set; }
        public int TaxId { get; set; }
    }
}
