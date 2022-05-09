using JWT.Core.Application.Features.CQRS.Commend;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class CreateCategoryCommendHandler : IRequestHandler<CreateCategoryCommedRequest>
    {

        private readonly IRepository<Category> repository;

        public CreateCategoryCommendHandler(IRepository<Category> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateCategoryCommedRequest request, CancellationToken cancellationToken)
        {
           await this.repository.CreateAsync(new Category
            {
                Defination = request.Defination,
            });

            return Unit.Value;
        }
    }
}
