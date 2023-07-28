using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; // PageModel
using Packt.Shared; // NorthwindContext
using System;


namespace Northwind.Web.Pages;

public class CustomersModel : PageModel
{
    private NorthwindContext db;
    public IEnumerable<Customer>? Customers { get; set; }
    public Customer? Customer { get; set; }

    public CustomersModel(NorthwindContext injectedCotext)
    {
        db = injectedCotext;
    }
    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Customers";
        Customers = db.Customers.OrderBy(c => c.Country).ThenBy(c => c.CompanyName);
    }

    public IActionResult CustomerDetail(string? id)
    {
        if (string.IsNullOrEmpty(id))
        {
            return BadRequest("You must pass a product ID in the route, for example, / Home / ProductDetail / 21");
        }
        Customer = db.Customers.SingleOrDefault(c => c.CustomerId == id);

        if (Customer is null)
        {
            return NotFound($"Customer with ID {id} not found.");
        }

        return RedirectToPage($"/CustomerDetail/{id}");
    }
}
