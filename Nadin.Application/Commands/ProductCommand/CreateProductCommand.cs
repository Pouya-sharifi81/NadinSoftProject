using MediatR;
using Nadin.Domain.Model;

namespace Nadin.Application.Commands.ProductCommand;

public class CreateProductCommand :IRequest<Product>
{
    
    public string Name { get; set; }
    public bool IsAvailable { get; set; }
    public string ManufactureEmail { get; set; }
    public string ManufacturePhone { get; set; }
    public DateTime ProduceDate { get; set; }
    public string CreatedBy { get; set; }
}