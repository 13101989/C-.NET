﻿using Microsoft.EntityFrameworkCore; // DbContext, DbContextOptionsBuilder
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Diagnostics;

namespace Packt.Shared;

public class Northwind : DbContext
{
    // these properties map to tables in the database
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }

    // this manages the connection to the database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        string connection = $"Filename={path}";
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"Connection: {connection}");
        ForegroundColor = previousColor;
        optionsBuilder.UseSqlite(connection)
            .LogTo(WriteLine, new[] { RelationalEventId.CommandExecuting }) // Console
            .EnableSensitiveDataLogging()
            .UseLazyLoadingProxies();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // example of using Fluent API instead of attributes
        // to limit the length of a category name to 15
        modelBuilder.Entity<Category>()
          .Property(category => category.CategoryName)
          .IsRequired() // NOT NULL
          .HasMaxLength(15);
        if (Database.ProviderName?.Contains("Sqlite") ?? false)
        {
            // added to "fix" the lack of decimal support in SQLite
            modelBuilder.Entity<Product>()
              .Property(product => product.Cost)
              .HasConversion<double>();
            // global filter to remove discontinued products
            modelBuilder.Entity<Product>()
              .HasQueryFilter(p => !p.Discontinued);
        }
    }
}
