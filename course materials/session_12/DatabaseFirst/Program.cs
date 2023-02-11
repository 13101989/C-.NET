using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StoreContext storeContext = new StoreContext();
            //storeContext.Customers.Include(customer => customer.Orders);
            foreach (var customer in storeContext.Customers.Include(customer => customer.Orders))
            {
                Console.WriteLine("{0} - {1} - {2}", customer.Companyname, customer.Contactname, customer.Orders.Count);
            }
        }
    }
}

