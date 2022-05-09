using JWT.Core.Application.Features.CQRS.Commend;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class CreateProductCommendHandler : IRequestHandler<CreateProductCommendRequest>
    {
        private readonly IRepository<Product> repository;

        public CreateProductCommendHandler(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateProductCommendRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(new Product
            {
                CategoryId = request.CategoryId,

                Name = request.Name,

                Price = request.Price,

                Stock = request.Stock,
            });

            return Unit.Value;
        }
    }
}
