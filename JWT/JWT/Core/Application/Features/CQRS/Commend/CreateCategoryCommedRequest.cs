using MediatR;

namespace JWT.Core.Application.Features.CQRS.Commend
{
    public class CreateCategoryCommedRequest : IRequest
    {
        public string? Defination { get; set; }
    }
}
