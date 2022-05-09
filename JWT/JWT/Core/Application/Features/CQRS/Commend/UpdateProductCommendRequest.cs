using MediatR;

namespace JWT.Core.Application.Features.CQRS.Commend
{
    public class UpdateProductCommendRequest : IRequest
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
