using JWT.Core.Application.Dto;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Queries
{
    public class GetProductsQueryRequest : IRequest<List<ProductListDto>>
    {
    }
}
