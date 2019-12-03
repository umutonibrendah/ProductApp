using Microsoft.EntityFrameworkCore;

namespace ProductAsp.Data
{
    public class ProductsContext: DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options): base(options){}
        public DbSet<Models.Product> Products { get; set; }
    }
}