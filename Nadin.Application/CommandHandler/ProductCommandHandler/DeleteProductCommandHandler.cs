using MediatR;
using Nadin.Application.Commands.ProductCommand;
using Nadin.Domain.Contract;

namespace Nadin.Application.CommandHandler.ProductCommandHandler;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
{
    private readonly IProductRepositories _productRepositories;

    public DeleteProductCommandHandler(IProductRepositories productRepository)
    {
        _productRepositories = productRepository;
    }

    public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        await _productRepositories.DeleteProductAsync(request.Id);
        return Unit.Value;
    }
}