using System.ComponentModel.DataAnnotations;

namespace Medical_Management_System.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }

        [Required]
        public string productType { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime createdAt { get; set; } = DateTime.Now;

    }
}
