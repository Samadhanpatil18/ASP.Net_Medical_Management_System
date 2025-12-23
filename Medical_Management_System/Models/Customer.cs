using System.ComponentModel.DataAnnotations;

namespace Medical_Management_System.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Phone { get; set; }
    }
}




