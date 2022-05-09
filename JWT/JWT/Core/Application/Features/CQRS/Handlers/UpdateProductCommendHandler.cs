using JWT.Core.Application.Features.CQRS.Commend;
using JWT.Core.Application.interfaces;
using JWT.Core.Domain;
using MediatR;

namespace JWT.Core.Application.Features.CQRS.Handlers
{
    public class UpdateProductCommendHandler : IRequestHandler<UpdateProductCommendRequest>
    {

        private readonly IRepository<Product> repository;

        public UpdateProductCommendHandler(IRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommendRequest request, CancellationToken cancellationToken)
        {
            var UptatedProduct = await this.repository.GetByIdAsync(request.Id);

            if (UptatedProduct!=null)
            {
                UptatedProduct.CategoryId =  request.CategoryId;

                UptatedProduct.Stock = request.Stock;

                UptatedProduct.Price= request.Price;

                UptatedProduct.Name = request.Name;

                await this.repository.UpdateAsync(UptatedProduct);
            }

            return Unit.Value;
        }
    }
}
