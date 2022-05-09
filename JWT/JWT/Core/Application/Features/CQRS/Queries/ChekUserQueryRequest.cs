using JWT.Core.Application.Dto;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Queries
{
    public class ChekUserQueryRequest : IRequest<ChekUserResponsDto>
    {
        

        public string UserName { get; set; }=string.Empty;

        public string Password { get; set; }=string.Empty ;


    }
}
