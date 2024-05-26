using System.ComponentModel.DataAnnotations;

namespace Nadin.Domain.Model;

public class Product
{
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Availability status is required")]
    public bool IsAvailable { get; set; }

    [Required(ErrorMessage = "Manufacture email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string ManufactureEmail { get; set; }

    [Phone(ErrorMessage = "Invalid phone number")]
    public string ManufacturePhone { get; set; }

    [Required(ErrorMessage = "Production date is required")]
    [DataType(DataType.Date)]
    public DateTime ProduceDate { get; set; }
}
