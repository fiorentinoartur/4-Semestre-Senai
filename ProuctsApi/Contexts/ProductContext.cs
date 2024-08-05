using Microsoft.EntityFrameworkCore;
using ProuctsApi.Domains;

namespace ProuctsApi.Contexts
{
    public class ProductContext : DbContext
    {
        public DbSet<Products> Product { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE19-SALA21; DataBase = dbProducts; user id = sa; Pwd = Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
