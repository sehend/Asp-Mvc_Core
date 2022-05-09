using MediatR;

namespace JWT.Core.Application.Features.CQRS.Commend
{
    public class DeleteProductCommentRequest : IRequest
    {

        public int Id { get; set; }

        public DeleteProductCommentRequest(int id)
        {
            Id = id;
        }
    }
}
