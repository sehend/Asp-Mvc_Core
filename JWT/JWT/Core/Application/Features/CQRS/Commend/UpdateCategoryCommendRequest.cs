using MediatR;

namespace JWT.Core.Application.Features.CQRS.Commend
{
    public class UpdateCategoryCommendRequest : IRequest
    {
        public int Id { get; set; }

        public string? Defination { get; set; }
    }
}
