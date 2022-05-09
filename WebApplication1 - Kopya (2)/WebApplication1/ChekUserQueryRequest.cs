using MediatR;

namespace WebApplication1
{
    public class ChekUserQueryRequest : IRequest<ChekUserResponsDto>
    {


        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;


    }
}
