using JWT.Core.Application.Dto;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Queries
{
    public class GetCategoryQueryRequest : IRequest<CategoryListDto>
    {
        public int Id { get; set; }

        public GetCategoryQueryRequest(int ıd)
        {
            Id = ıd;
        }

       


    }
}
