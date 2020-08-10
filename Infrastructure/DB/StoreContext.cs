using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DB
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Products> products { get; set; }
    }
}