using MediatR;
using Nadin.Application.Queries.ProductQuery;
using Nadin.Domain.Contract;
using Nadin.Domain.Model;

namespace Nadin.Application.QueryHandler.ProductQueyHandler;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IProductRepositories _productRepositories;

    public GetAllProductsQueryHandler(IProductRepositories productRepository)
    {
        _productRepositories = productRepository;
    }

    public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return await _productRepositories.GetAllProductsAsync();
    }
}