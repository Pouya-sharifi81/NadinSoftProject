using MediatR;
using Nadin.Domain.Model;

namespace Nadin.Application.Queries.ProductQuery;

public class GetAllProductsQuery : IRequest<List<Product>>
{
    
}