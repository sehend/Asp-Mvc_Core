using MediatR;

namespace JWT.Core.Application.Features.CQRS.Commend
{
    public class RegisterUserCommendRequest : IRequest
    {
        public string? UserName { get; set; }

        public string? Password { get; set; }
    }
}
