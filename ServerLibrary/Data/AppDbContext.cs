using BaseLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace ServerLibrary.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Process> Processs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProcessProductDetail> ProcessProductDetails { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<EmployeeProcess> EmployeeProcesses { get; set; }   
        public DbSet<AppliacationUser> AppliacationUsers { get; set; }
        public DbSet<BreakDown> BreakDowns { get; set; }    
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }
        public DbSet<ProductBreak> ProductBreaks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierPiece> SupplierPieces { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerProduct>()
                .HasKey(cp => new { cp.CustomerId, cp.ProductId }); // Composite key

            modelBuilder.Entity<ProcessProductDetail>()
                .HasKey(cp => new { cp.ProcessId, cp.ProductId });

            modelBuilder.Entity<EmployeeProcess>().HasKey(cp => new { cp.ProcessId,cp.EmployeeId });

            modelBuilder.Entity<ProductBreak>().HasKey(cp => new { cp.ProductId, cp.BreakId });

            modelBuilder.Entity<SupplierPiece>().HasKey(cp=> new {cp.PieceId,cp.SupplierId});

        } 
        
      




    }
}
