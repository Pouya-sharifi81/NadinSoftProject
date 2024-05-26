using MediatR;

namespace Nadin.Application.Commands.ProductCommand;

public class DeleteProductCommand : IRequest
{
    public int Id { get; set; }
}