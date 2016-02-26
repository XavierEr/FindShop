using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindShop.Model
{
    public class FindShopContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }

        public DbSet<Location> Locations { get; set; }

        public FindShopContext() : this("FindShopContext")
        {
        }

        public FindShopContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
    }
}
