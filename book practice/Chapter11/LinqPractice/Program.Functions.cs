using Microsoft.EntityFrameworkCore;
using Packt.Shared; // Northwind, Customer

partial class Program
{
    static void DisplayCompaniesUnderSpecificCity()
    {
        WriteLine($"Enter the name of a city:");
        string city = ReadLine();
        city = UppercaseFirstLetter(city!);
        WriteLine();

        using (Northwind db = new())
        {
            DbSet<Customer> allCustomers = db.Customers;

            IQueryable<Customer> customersInCity = allCustomers.Where(customer => customer.City == city);

            if (!(customersInCity.Count() > 0))
            {
                WriteLine($"There are no customers for this city");
                return;
            }

            WriteLine($"There are {customersInCity.Count()} customers in {city}:");
            foreach (var customer in customersInCity)
            {
                WriteLine($"{customer.CompanyName}");
            }
        }
        
    }

    static void DisplayCompaniesUnderListOfCities()
    {
        WriteLine($"Enter the name of a city from the below list:");
        WriteLine();

        using (Northwind db = new())
        {
            DbSet<Customer> allCustomers = db.Customers;
            SortedSet<string> cities = new();

            foreach (Customer customer in allCustomers)
            {
                cities.Add(customer.City!);
            }
            foreach (var uniqueCity in cities)
            {
                Write($"{uniqueCity} ");
            }

            WriteLine();
            WriteLine();
            string city = ReadLine();
            city = UppercaseFirstLetter(city!);
            WriteLine();


            if (!(cities.Contains(city)))
            {
                WriteLine($"City is not in the list provided");
                return;
            }

            IQueryable<Customer> customersInCity = allCustomers.Where(customer => customer.City == city);

            WriteLine($"There are {customersInCity.Count()} customers in {city}:");
            foreach (var customer in customersInCity)
            {
                WriteLine($"{customer.CompanyName}");
            }
        }
    }

    static string UppercaseFirstLetter(string cityName)
    {
        if (string.IsNullOrEmpty(cityName))
        {
            return string.Empty;
        }

        cityName = cityName.ToLower();

        return char.ToUpper(cityName[0]) + cityName.Substring(1);
    }

}
