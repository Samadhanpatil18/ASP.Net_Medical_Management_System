using Microsoft.EntityFrameworkCore;
using Medical_Management_System.Models;

namespace Medical_Management_System.Data
{
    public class MedicalDbContext : DbContext
    {
        public MedicalDbContext(DbContextOptions<MedicalDbContext> options)
            : base(options)
        {
        }

        public DbSet<Medical> Medicals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}





//using Microsoft.EntityFrameworkCore;
//using Medical_Management_System.Models;
//using Medical_Management_System.Controllers;

//namespace Medical_Management_System.Data

//{
//    public class MedicalDbContext : DbContext
//    {
//        public MedicalDbContext(DbContextOptions<MedicalDbContext> options) : base(options)
//        {
//        }

//        // DbSets (tables)


//        public DbSet<Medical> Medicals { get; set; }

//        public DbSet<Product> Products { get; set; }

//        public DbSet<Customer> Customers { get; set; }

//        public DbSet<Supplier> Suppliers { get; set; }




//    }
//}
