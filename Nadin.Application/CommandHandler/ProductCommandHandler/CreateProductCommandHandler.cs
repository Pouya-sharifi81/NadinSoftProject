using MediatR;
using Nadin.Application.Commands.ProductCommand;
using Nadin.Domain.Contract;
using Nadin.Domain.Model;

namespace Nadin.Application.CommandHandler.ProductCommandHandler;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
{
    private readonly IProductRepositories _productRepositories;

    public CreateProductCommandHandler(IProductRepositories productRepository)
    {
        _productRepositories = productRepository;
    }

    public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = request.Name,
            IsAvailable = request.IsAvailable,
            ManufactureEmail = request.ManufactureEmail,
            ManufacturePhone = request.ManufacturePhone,
            ProduceDate = request.ProduceDate,
            CreatedBy = request.CreatedBy
        };

        await _productRepositories.AddProductAsync(product);
        return product;
    }
}