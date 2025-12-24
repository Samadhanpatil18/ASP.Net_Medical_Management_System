using System;
using System.ComponentModel.DataAnnotations;

namespace MedicleManagementCodeFirstApp.Models
{
    public class Medical
    {
        [Key]
        public int MedicalId { get; set; }

        public string MedicalName { get; set; }
        // Pricing
        public string Contact { get; set; }

        public string Address { get; set; }

        public string LicenseNumber { get; set; }

        // Relations (simple IDs only)
        public int SupplierId { get; set; }

        public int TaxId { get; set; }
    }
}
