using Microsoft.EntityFrameworkCore;

namespace VerstaTest.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            /*Database.EnsureDeleted();
            Database.EnsureCreated();*/
        }

        public DbSet<Order> Orders => Set<Order>();
    }
}