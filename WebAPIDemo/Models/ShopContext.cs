namespace WebAPIDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ShopContext : DbContext
    {
        public ShopContext()
            : base("ShopContext")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

    }

}