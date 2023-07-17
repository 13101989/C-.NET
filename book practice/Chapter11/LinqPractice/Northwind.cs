using Microsoft.EntityFrameworkCore; // DbContext, DbSet<T>
using System.Diagnostics;

namespace Packt.Shared;
public class Northwind : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        optionsBuilder.UseSqlite($"Filename={path}");
        /*
        string connection = "Data Source=.;" +
            "Initial Catalog=Northwind;" +
            "Integrated Security=true;" +
            "MultipleActiveResultSets=true;";
        optionsBuilder.UseSqlServer(connection);
        */
    }
}
