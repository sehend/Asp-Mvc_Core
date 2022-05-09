using MediatR;

namespace JWT.Core.Application.Features.CQRS.Commend
{
    public class DeleteCategoryCommendRequest : IRequest
    {
        public DeleteCategoryCommendRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }



    }
}
