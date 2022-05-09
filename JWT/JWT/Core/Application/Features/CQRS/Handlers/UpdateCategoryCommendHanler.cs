using JWT.Core.Application.Features.CQRS.Commend;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class UpdateCategoryCommendHanler : IRequestHandler<UpdateCategoryCommendRequest>
    {

        private readonly IRepository<Category> repository;

        public UpdateCategoryCommendHanler(IRepository<Category> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommendRequest request, CancellationToken cancellationToken)
        {

            var updateentity = await this.repository.GetByIdAsync(request.Id);
            if (updateentity != null)
            {
                updateentity.Defination = request.Defination;

                await this.repository.UpdateAsync(updateentity);
            }

            return Unit.Value;    
        }
    }
}
