using System.ComponentModel.DataAnnotations;
namespace Packt.Shared;
public class Customer
{
    public string? CustomerId { get; set; }

    [Required]
    [StringLength(40)]
    public string CompanyName { get; set; } = null!;

    [StringLength(15)]
    public string? City { get; set; }
}
