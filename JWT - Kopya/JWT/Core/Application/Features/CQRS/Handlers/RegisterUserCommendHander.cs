using JWT.Core.Application.Enums;
using JWT.Core.Application.Features.CQRS.Commend;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommendHander : IRequestHandler<RegisterUserCommendRequest>
    {
        private readonly IRepository<AppUser> repository;

        public RegisterUserCommendHander(IRepository<AppUser> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserCommendRequest request, CancellationToken cancellationToken)
        {

            await this.repository.CreateAsync(new AppUser
            {
               AppRoleId=(int)RoleType.Member,

               Password=request.Password,

               UserName=request.UserName,
            });


            return Unit.Value; 
        }
    }
}
