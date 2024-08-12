using Microsoft.EntityFrameworkCore;
using ProductTestApi.Domain;

namespace ProductTestApi.Contexts
{
    public partial class ProductContext : DbContext
    {
        //public ProductContext()
        //{

        //}

        //public ProductContext(DbContextOptions<ProductContext> options) : base(options) 
        //{
            
        //}

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE19-SALA19; initial catalog=Products; user id= sa; Pwd = Senai@134; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
