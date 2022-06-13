using Microsoft.EntityFrameworkCore;

namespace AspNetMvc.Models.ORM
{
    public class SiemensContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database =MVC ; Trusted_Connection = True;");
        }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
//güncelleme diye buton olacak