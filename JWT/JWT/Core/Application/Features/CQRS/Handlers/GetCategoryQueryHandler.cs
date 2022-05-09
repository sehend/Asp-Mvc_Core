using AutoMapper;
using JWT.Core.Application.Dto;
using JWT.Core.Application.Features.CQRS.Queries;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoriesQueryRequest, List<CategoryListDto>>
    {

        private readonly IRepository<Category> repository;

        private readonly IMapper mapper;

        public GetCategoryQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<CategoryListDto>> Handle(GetCategoriesQueryRequest request, CancellationToken cancellationToken)
        {

            var data = await this.repository.GetAllAsync();


           return this.mapper.Map<List<CategoryListDto>>(data);
        }
    }
}
