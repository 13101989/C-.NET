using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; // PageModel
using Packt.Shared; // NorthwindContext


namespace Northwind.Web.Pages;

public class CustomerInfoModel : PageModel
{
    private NorthwindContext db;
    public Customer? Customer { get; set; }

    public CustomerInfoModel(NorthwindContext injectedContext)
    {
        db = injectedContext;
    }
    public IActionResult OnGet([FromRoute] string customerId)
    {
        ViewData["Title"] = "Northwind B2B - Customer details";
        Customer = GetCustomerById(customerId);

        return Page();
    }

    private Customer GetCustomerById(string customerId)
    {
        return db.Customers.FirstOrDefault(c => c.CustomerId == customerId)!;
    }
}

