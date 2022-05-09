using JWT.Core.Application.Dto;
using JWT.Core.Application.Features.CQRS.Queries;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class ChekUserQueryRequestHandler : IRequestHandler<ChekUserQueryRequest, ChekUserResponsDto>
    {
        private readonly IRepository<AppUser> UserRepository;

        private readonly IRepository<AppRole> RoleRepository;

        public ChekUserQueryRequestHandler(IRepository<AppUser> userRepository, IRepository<AppRole> roleRepository)
        {
            UserRepository = userRepository;
            RoleRepository = roleRepository;
        }

        public async Task<ChekUserResponsDto> Handle(ChekUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto= new ChekUserResponsDto();

            var user= await UserRepository.GetByFilterAsync(x=>x.UserName==request.UserName && x.Password == request.Password);

            if (user==null)
            {
                dto.IsExist = false;

                
            }
            else
            {
                dto.UserName = user.UserName;

                dto.Id = user.Id;

                dto.IsExist=true;

                var role=await RoleRepository.GetByFilterAsync(x=>x.Id==user.AppRoleId);

                dto.Role = role?.Definition;
            }
  

            return dto;
        }
    }
}
