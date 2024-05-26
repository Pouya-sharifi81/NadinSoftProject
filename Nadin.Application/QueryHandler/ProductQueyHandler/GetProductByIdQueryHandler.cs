using MediatR;
using Nadin.Application.Queries.ProductQuery;
using Nadin.Domain.Contract;
using Nadin.Domain.Model;

namespace Nadin.Application.QueryHandler.ProductQueyHandler;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly IProductRepositories _productRepositories;

    public GetProductByIdQueryHandler(IProductRepositories productRepository)
    {
        _productRepositories = productRepository;
    }

    public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        return await _productRepositories.GetProductByIdAsync(request.Id);
    }
}