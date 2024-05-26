using MediatR;
using Nadin.Domain.Model;

namespace Nadin.Application.Queries.ProductQuery;

public class GetProductByIdQuery : IRequest<Product>
{
    public int Id { get; set; }
}