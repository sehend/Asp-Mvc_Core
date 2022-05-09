using AutoMapper;
using JWT.Core.Application.Dto;
using JWT.Core.Application.Features.CQRS.Queries;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class GetCategoryQueryHandler1 : IRequestHandler<GetCategoryQueryRequest, CategoryListDto>
    {

        private readonly IRepository<Category> repository;

        private readonly IMapper mapper;

        public GetCategoryQueryHandler1(IRepository<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CategoryListDto> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
        {

            var data = await this.repository.GetByFilterAsync(x=>x.Id==request.Id);


            return this.mapper.Map<CategoryListDto>(data);
        }
    }
}
