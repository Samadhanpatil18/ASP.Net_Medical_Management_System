using System.ComponentModel.DataAnnotations;

namespace Medical_Management_System.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        public string SupplierName { get; set; }

        public string Phone { get; set; }
    }
}



