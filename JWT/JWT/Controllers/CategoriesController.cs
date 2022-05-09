using JWT.Core.Application.Features.CQRS.Commend;
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
    [Authorize(Roles = "Admin")]
    public class CategoriesController : ControllerBase
    {

        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var result = await this._mediator.Send(new GetCategoriesQueryRequest());

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategories(int ıd)
        {
            var result = await this._mediator.Send(new GetCategoryQueryRequest(ıd));

            return Ok(result);
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateCategoryCommedRequest request)
        {
            await _mediator.Send(request);

            return Created("",request);
        }
        [HttpPut]

        public async Task<IActionResult> update(UpdateCategoryCommendRequest request)
        {
            await _mediator.Send(request);

            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            await this._mediator.Send(new DeleteCategoryCommendRequest(id));

            return NoContent();
        }
    }
}
