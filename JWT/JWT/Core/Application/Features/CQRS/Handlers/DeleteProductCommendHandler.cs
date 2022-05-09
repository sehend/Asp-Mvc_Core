using JWT.Core.Application.Features.CQRS.Commend;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class DeleteProductCommendHandler : IRequestHandler<DeleteProductCommentRequest>
    {

        private readonly IRepository<Product>  repository ;

        public DeleteProductCommendHandler(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteProductCommentRequest request, CancellationToken cancellationToken)
        {
            var deleteentity=await this.repository.GetByIdAsync(request.Id);
            if (deleteentity!=null)
            {
                await this.repository.RemoveAsync(deleteentity);
            }

            return Unit.Value;
        
        }
    }
}
