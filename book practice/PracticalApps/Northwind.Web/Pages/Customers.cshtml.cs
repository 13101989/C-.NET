using Microsoft.AspNetCore.Mvc.RazorPages; // PageModel
using Packt.Shared; // NorthwindContext


namespace Northwind.Web.Pages;

public class CustomersModel : PageModel
{
    private NorthwindContext db;
    public IEnumerable<Customer>? Customers { get; set; }

    public CustomersModel(NorthwindContext injectedCotext)
    {
        db = injectedCotext;
    }
    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Customers";
        Customers = db.Customers.OrderBy(c => c.Country).ThenBy(c => c.CompanyName);
    }
}
