using JWT.Core.Application.Features.CQRS.Commend;
using JWT.Core.Application.Features.CQRS.Queries;
using JWT.infrastructure.Tools;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace JWT.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly  IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]

        public  async Task<IActionResult> Register(RegisterUserCommendRequest request)
        {
            await _mediator.Send(request); 

            return Created("",request);
        }

        [HttpPost("[action]")]

        public async Task<IActionResult> SignIn(ChekUserQueryRequest request)
        {
            var userdto = await _mediator.Send(request);

            if (userdto.IsExist){

                var Token = JwtTokenGenerator.GenerateToken(userdto);

           

                return Created("", Token);
            }

            return BadRequest("UserName Veya Password Hatalı");

        }


    }
}
