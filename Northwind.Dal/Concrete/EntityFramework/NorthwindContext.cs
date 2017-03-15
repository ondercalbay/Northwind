using Northwind.Entities;
using System.Data.Entity;

namespace Northwind.Dal.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
