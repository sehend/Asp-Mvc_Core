using JWT.Core.Application.Features.CQRS.Commend;
using JWT.Core.Application.Features.CQRS.Handlers;
using JWT.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin,Member")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]

        public async Task<IActionResult> List()
        {

            var result = await this.mediator.Send(new GetProductsQueryRequest());


            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetProductQueryRequest(id));

            return result==null ? NotFound():Ok(result);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await this.mediator.Send(new DeleteProductCommentRequest(id));

            return NoContent();
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateProductCommendRequest  createProductCommendRequest)
        {
            await this.mediator.Send(createProductCommendRequest);

            return Created("", createProductCommendRequest); 
        }

        [HttpPut]

        public async Task<IActionResult> Update(UpdateProductCommendRequest updateProductCommendRequest)
        {
            await this.mediator.Send(updateProductCommendRequest);

            return NoContent();
        }
    }
}
