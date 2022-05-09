
using AutoMapper;
using JWT.Core.Application.Dto;
using JWT.Core.Application.Features.CQRS.Queries;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetProductsQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product>  repository;
        private readonly IMapper mapper;
        public GetAllProductQueryHandler(IRepository<Product> repository , IMapper mapper)
        {
            this.repository = repository;

            this.mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllAsync();

            return this.mapper.Map<List<ProductListDto>>(data);
        }
    }
}
