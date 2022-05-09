using JWT.Core.Application.Features.CQRS.Commend;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class DeleteCategoryCommendHandler : IRequestHandler<DeleteCategoryCommendRequest>
    {

        private readonly IRepository<Category> repository;

        public DeleteCategoryCommendHandler(IRepository<Category> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteCategoryCommendRequest request, CancellationToken cancellationToken)
        {

            var deleteentity = await repository.GetByIdAsync(request.Id);
            if (deleteentity!=null)
            {
                await this.repository.RemoveAsync(deleteentity);
            }

            return Unit.Value;
        
        }
    }
}
