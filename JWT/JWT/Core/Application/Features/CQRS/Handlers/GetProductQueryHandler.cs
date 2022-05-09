using AutoMapper;
using JWT.Core.Application.Dto;
using JWT.Core.Application.Features.CQRS.Queries;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQueryRequest, ProductListDto>
    {
        private readonly IRepository<Product> repository;

        private readonly IMapper mapper;

        public GetProductQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ProductListDto> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
        {
          var data =  await this.repository.GetByFilterAsync(x=>x.Id==request.Id);

            return this.mapper.Map<ProductListDto>(data);
        }
    }
}
