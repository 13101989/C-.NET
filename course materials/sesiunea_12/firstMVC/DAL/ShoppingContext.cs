using System;
using firstMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace firstMVC.DAL
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}

