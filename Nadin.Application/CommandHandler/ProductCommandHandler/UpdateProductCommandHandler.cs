using MediatR;
using Nadin.Application.Commands.ProductCommand;
using Nadin.Domain.Contract;
using Nadin.Domain.Model;

namespace Nadin.Application.CommandHandler.ProductCommandHandler;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    private readonly IProductRepositories _productRepositories;

    public UpdateProductCommandHandler(IProductRepositories productRepository)
    {
        _productRepositories = productRepository;
    }

    public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            ProductId= request.Id,
            Name = request.Name,
            IsAvailable = request.IsAvailable,
            ManufactureEmail = request.ManufactureEmail,
            ManufacturePhone = request.ManufacturePhone,
            ProduceDate = request.ProduceDate,
            CreatedBy = request.CreatedBy
        };

        await _productRepositories.UpdateProductAsync(product);
        return Unit.Value;
    }
}